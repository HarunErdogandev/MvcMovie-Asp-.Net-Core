﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class MovieCategoryDetail : IDto
    {
        public int MovieId { get; set; }
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

    }
}
