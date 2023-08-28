using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MovieActorDetailDto:IDto
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        public string ActorName { get; set; }
    }
}
