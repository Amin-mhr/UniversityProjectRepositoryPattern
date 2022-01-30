using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Repository.EntityRepository;
using System;
using University.Contract;
using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace UniversityHost
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Admin ad = new Admin() { AdminName = "test" };

            var builder = Host.CreateDefaultBuilder()
            .ConfigureServices(ConfigureServices)
            .UseConsoleLifetime();


            var host = builder.Build();

            var repositorywrapper = host.Services.GetService<IRepositoryWrapper>();
            repositorywrapper.Admin.Create(ad);
            repositorywrapper.save();
        }


        private static void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            //services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(@"Server=localhost;Database=UniversityDb;Trusted_Connection=True;"));
            services.AddDbContext<UniversityDbContext>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
