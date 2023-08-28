using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Admin:IEntity
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
