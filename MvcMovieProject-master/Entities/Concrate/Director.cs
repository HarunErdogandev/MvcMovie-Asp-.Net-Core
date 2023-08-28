using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Director:IEntity
    {
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }
    }
}
