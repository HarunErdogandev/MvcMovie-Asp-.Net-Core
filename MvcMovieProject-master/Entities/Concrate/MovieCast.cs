﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    [Keyless]
    public class MovieCast:IEntity
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
    }
}
