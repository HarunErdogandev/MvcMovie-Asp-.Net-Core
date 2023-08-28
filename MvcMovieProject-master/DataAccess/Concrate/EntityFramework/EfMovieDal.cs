
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie, MovieDbContext>, IMovieDal
    {
        public List<MovieGenreDetailDto> GetMovieGenres()
        {
            using (MovieDbContext context = new())
            {
                var result = from m in context.Movies
                             join mc in context.MovieCategories
                             on m.MovieId equals mc.Movieİd
                             join c in context.Categories
                             on mc.Categoryİd equals c.CategoryId
                             select new MovieGenreDetailDto
                             {
                                 MovieId = m.MovieId,
                                 MovieName = m.MovieTitle,
                                 CategoryId = mc.Categoryİd,
                                 CategoryName = c.CategoryName,
                                 imgUrl = m.Movieİmage,
                                 MovieDescription = m.MovieDescription

                             };
                return result.ToList();
            }
        }

        public List<MovieCategoryDetail> MovieCategoryDetail(int movieId)
        {
            using (MovieDbContext context = new())
            {
                var result = from m in context.Movies
                             join mc in context.MovieCategories
                             on m.MovieId equals mc.Movieİd
                             join c in context.Categories
                             on mc.Categoryİd equals c.CategoryId
                             select new MovieCategoryDetail
                             {
                                 MovieId = m.MovieId,

                                 CategoryId = mc.Categoryİd,
                                 CategoryName = c.CategoryName,


                             };
                return result.Where(x => x.MovieId == movieId).ToList();
            }
        }

        public List<MovieActorDetailDto> movieActorDetail(int movieId)
        {
            using (MovieDbContext context = new())
            {
                var result = from m in context.Movies
                             join mc in context.MovieCasts
                             on m.MovieId equals mc.MovieId
                             join a in context.Actors
                             on mc.ActorId equals a.ActorId
                             select new MovieActorDetailDto
                             {
                                 MovieId = m.MovieId,
                                 ActorName = a.ActorName,
                                 ActorId = mc.ActorId,

                             };
                return result.Where(x => x.MovieId == movieId).ToList();

            }
        }

        public MovieDirectorDetailDto movieDirectories(int movieId)
        {
            using (MovieDbContext context = new())
            {
                var result = from m in context.Movies
                             join d in context.Directors
                             on m.DirectorId equals d.DirectorId
                             select new MovieDirectorDetailDto { MovieId = m.MovieId, DirectoryName = d.DirectorName };


                var GetList = result.FirstOrDefault(x => x.MovieId == movieId);

                return GetList;
            }
        }
    }
}

