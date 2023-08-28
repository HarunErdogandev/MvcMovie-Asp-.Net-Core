using Core.Utilities.Results;
using Entities.Concrate;
using Entities.Dtos;

namespace MovieWebUI.Models
{
    public class MovieDetailListView
    {
        public IDataResult<List<MovieCategoryDetail>>? MovieCategories { get; set; }
        public IDataResult<List<MovieActorDetailDto>>? Actors { get; set; }
        public IDataResult<MovieDirectorDetailDto> Directors { get; set; }
        public IDataResult<Movie>? GetMovie { get; set; }
    }
}
