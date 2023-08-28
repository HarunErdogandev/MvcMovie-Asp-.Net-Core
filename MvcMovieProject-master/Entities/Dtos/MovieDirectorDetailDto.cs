using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MovieDirectorDetailDto:IDto
    {
        public int MovieId { get; set; }
        public int DirectorId { get; set; }
        public string? DirectoryName { get; set; }
    }
}
