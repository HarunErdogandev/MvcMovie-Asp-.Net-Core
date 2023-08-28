using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{


    public class Movie:IEntity
    {
        public int MovieId { get; set; }
        public int ?DirectorId { get; set; }
        public string ?VideoUrl { get; set; }
        public string? MovieTitle { get; set; }
        public int ?MovieYear { get; set; }
        public string? MovieTime { get; set; }
        public string? MovieDescription { get; set;}
        
        public string? Movieİmage { get; set; }
    }
}
