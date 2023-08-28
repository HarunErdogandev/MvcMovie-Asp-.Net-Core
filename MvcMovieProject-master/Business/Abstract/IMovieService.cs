using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        
        IDataResult<List<Movie>> GetAll();
        IDataResult<List<Movie>> GetSearchMovie(string search);
        IDataResult<Movie> GetMovie(int id);
        IDataResult<List<Movie>> GetRandomMovies();
        
        IResult Add(Movie movie);
        IResult Update(Movie movie);
        IResult Delete(Movie movie);

        IDataResult<List<MovieGenreDetailDto>> GetByCategory(int category);
        IDataResult<List<MovieCategoryDetail>> GetMovieCategory(int category);
        IDataResult<List<MovieActorDetailDto>> GetByActor(int actorId);
        IDataResult<MovieDirectorDetailDto> GetByDirector(int director);

    }
}
