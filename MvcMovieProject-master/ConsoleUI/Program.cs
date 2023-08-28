using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Microsoft.Data.SqlClient;
using MovieWebUI.Models.Logger;

namespace ConsoleUI
{
    internal class Program
    {
        //class Product
        //{
        //    public string Name { get; set; }
        //    public decimal price { get; set; }
        //    public int Stock { get; set; }
        //}
        //class Sale
        //{
        //    public Product Product { get; set; }
        //    public int Stock { get; set; }
        //    public decimal TotolPrice { get; set; }

        //    public Sale(Product product, int stok)
        //    {
        //        Product= product;
        //        Stock = stok;
        //        TotolPrice *=
        //    }

        //}
        static void Main(string[] args)
        {
            //CategoryWorks();
            //MovieUpdate();
            //Randomsfilm();
            //Trailer();
            //Loggers();
            var movie=new Movie();

            movie.MovieTitle = "Black Adam";

            MovieManager movieManager = new MovieManager(new EfMovieDal());

           var result= movieManager.Add(movie);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }

            //foreach (var item in movieManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.MovieTitle);
            //}





        }

        private static void checkType(params object [] type)
        {

            foreach (var item in type)
            {
                if (item  is not null)
                {
                    Console.WriteLine(item.GetType().Name);

                   
                }
            }
            
            
        }

        private static void Loggers()
        {
            var film = new Movie();
            film.MovieTitle = "asdasda ";
            var Log = new Logger();
            Log.LogAdd(film.MovieTitle);
        }

        private static void Trailer()
        {
            //var EfMovieDal = new EfMovieDal();
            //var result = EfMovieDal.MovieCreateDetails(1);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName + "" + item.DirectorName);
            //}
        }

        private static void Randomsfilm()
        {
            //var movie = new MovieManager(new EfMovieDal());
            //var result=movie.GetRandomMovies();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.MovieTitle);
            //}

        }

        private static void CategoryWorks()
        {
            var CategoryManager = new CategoryManager(new EfCategoryDal());
           
            var Category = new Category();
            Category.CategoryName = "Korku";
            CategoryManager.Add(Category);
            var result=CategoryManager.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.CategoryId+":"+item.CategoryName);
            }
        }

        private static void MovieUpdate()
        {
            MovieManager movieManager = new MovieManager(new EfMovieDal());
            Movie Film = new Movie();

            
            Film.MovieTitle = "Test film";
            Film.MovieYear = 2022;
            

            
            

        }
    }
}