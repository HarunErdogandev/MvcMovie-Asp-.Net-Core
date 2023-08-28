using Entities.Concrate;
using Entities.Dtos;

namespace MovieWebUI.Models
{
    public class AdminListViewModel
    {
        public List<Director> Directories;
        public Movie? Movies { get; set; }
    }
}
