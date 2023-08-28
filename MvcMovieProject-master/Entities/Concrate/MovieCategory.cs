using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    [Keyless]
    public class MovieCategory:IEntity
    {
        public int Movieİd { get; set; }
        public int Categoryİd { get; set; }
    }
}
