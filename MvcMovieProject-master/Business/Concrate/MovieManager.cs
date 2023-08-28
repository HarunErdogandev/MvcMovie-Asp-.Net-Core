using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class MovieManager : IMovieService
    {
         IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal= movieDal;
        }

        [SecuredOperation("movie.add,admin")]
        [ValidationAspect(typeof(MovieValidator))]
        public IResult Add(Movie movie)
        {
             
            IResult result=BusinessRules.Run(CheckIfMovieNameExists(movie.MovieTitle));
            if (result !=null)
            {
               
                return result;

            }
            //_movieDal.Add(movie);
            return new SuccessResult();



        }

        private IResult CheckIfMovieNameExists(string? movieTitle)
        {
            var result=_movieDal.GetAll(x=>x.MovieTitle== movieTitle).Any();
            if (result)
            {
                return new ErrorResult(Messages.MovieNameAlreadyExists);
            }
            return new SuccessResult();
        }

        public IResult Delete(Movie movie)
        {
            
            _movieDal.Delete(movie);
            return new SuccessResult();

        }

        public IDataResult<List<Movie>> GetAll()
        {
            var GetAll = _movieDal.GetAll();
            return new SuccessDataResult<List<Movie>>(GetAll, Messages.MoviesListed);
        }

        public IDataResult<List<MovieActorDetailDto>> GetByActor(int actorId)
        {
            return new SuccessDataResult<List<MovieActorDetailDto>>(_movieDal.movieActorDetail(actorId));
        }

        public IDataResult<List<MovieGenreDetailDto>> GetByCategory(int category)
        {
            if (category > 0)
            {
                var  result = _movieDal.GetMovieGenres().Where(x => x.CategoryId == category).ToList();
                return new SuccessDataResult<List<MovieGenreDetailDto>>(result, Messages.MovieListed);

            }
            else
                return new ErrorDataResult<List<MovieGenreDetailDto>>(null, Messages.MovieListed);
        }

        public IDataResult<MovieDirectorDetailDto> GetByDirector(int director)
        {
            return new SuccessDataResult<MovieDirectorDetailDto>(_movieDal.movieDirectories(director));
        }

        public IDataResult<Movie> GetMovie(int id)
        {
            return new SuccessDataResult<Movie>(_movieDal.Get(m => m.MovieId == id), Messages.MovieListed);
            
        }

        public IDataResult<List<MovieCategoryDetail>> GetMovieCategory(int category)
        {
            return new SuccessDataResult<List<MovieCategoryDetail>>(_movieDal.MovieCategoryDetail(category));
        }

        public IDataResult<List<Movie>> GetRandomMovies()
        {
            
            
            var Random= new Random();
            return new SuccessDataResult<List<Movie>>(_movieDal.GetAll().OrderBy(m => Random.Next()).Take(2).ToList());

             
        }

        public IDataResult<List<Movie>> GetSearchMovie(string search)
        {
            if (search != null)
                return new SuccessDataResult<List<Movie>>(_movieDal.GetAll().Where(x => x.MovieTitle.Contains(search)).ToList());
            else
                return new ErrorDataResult<List<Movie>>(null);
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult();

        }

        
    }
}
