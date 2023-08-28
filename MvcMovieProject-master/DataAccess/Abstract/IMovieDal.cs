using Core.DataAccess;
using Entities.Concrate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDal : IEntityRepository<Movie>
    {
        public List<MovieGenreDetailDto> GetMovieGenres();


        public List<MovieCategoryDetail> MovieCategoryDetail(int movieId);

        public List<MovieActorDetailDto> movieActorDetail(int movieId);

        public MovieDirectorDetailDto movieDirectories(int movieId);


    }
}
