using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Actor:IEntity
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }

    }
}
