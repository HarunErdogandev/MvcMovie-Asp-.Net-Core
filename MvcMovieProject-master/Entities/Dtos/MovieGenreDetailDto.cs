using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MovieGenreDetailDto:IDto
    {
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        public string? MovieName { get; set; }
        public string? MovieDescription { get; set; }
        public string? imgUrl { get; set; }
        public string? CategoryName { get; set; }

    }
}
