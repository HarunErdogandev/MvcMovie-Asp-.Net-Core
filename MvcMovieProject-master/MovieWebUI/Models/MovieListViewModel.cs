using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Dtos;

namespace MovieWebUI.Models
{
    public class MovieListViewModel
    {
        public IDataResult<List<Movie>>? Movies { get; set; }
        public IDataResult<List<MovieGenreDetailDto>>? MovieGenres { get; set; }
        public IDataResult<List<Movie>>? RandomMovies { get; set; }




    }
}
