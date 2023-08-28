using Core.Entities.Concrate;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class MovieDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OBA4SBK;Database=FilmProjeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-OBA4SBK;Database=FilmProjeDb,Trusted_Connection=True,TrustServerCertificate=True;MultiSubnetFailover=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-9PMBFOV;Initial Catalog=FilmProjeDb;Integrated Security=True");
        }

        public static MovieDbContext instance;
        public static readonly object _lock = new object();

        public MovieDbContext()
        {

        }
        public static MovieDbContext Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new MovieDbContext();
                    }
                    return instance;
                }
            }
        }

        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set;}
        public DbSet<MovieCategory> MovieCategories { get; set; }

        public DbSet<Director> Directors { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }




    }
}
