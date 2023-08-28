using Autofac;
using Business.Abstract;
using Business.Concrate;
using Business.DependencyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;

namespace MovieWebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
               .ConfigureContainer<ContainerBuilder>(builder =>
               {
                   builder.RegisterModule(new AutofacBusinessModule());
               });
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddSingleton<IMovieDal, EfMovieDal>();
            //builder.Services.AddSingleton<IMovieService, MovieManager>();
            //builder.Services.AddSingleton<ICategoryDal,EfCategoryDal>();
            //builder.Services.AddSingleton<ICategoryService, CategoryManager>();
            //builder.Services.AddSingleton<IDirectorDal,EfDirectorDal>();
            //builder.Services.AddSingleton<IDirectorService,DirectorManager>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=Index}/{id?}");

            app.Run();
        }

        private static void Services()
        {
            throw new NotImplementedException();
        }
    }
}