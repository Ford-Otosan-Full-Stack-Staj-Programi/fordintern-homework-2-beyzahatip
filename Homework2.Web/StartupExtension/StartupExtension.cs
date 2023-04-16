using Homework2.Data;
using Homework2.Data;
using System.Security.Principal;
using Homework2.Data.Model;
using Microsoft.VisualStudio.Services.Account;
using AutoMapper;
using Homework2.Service.Mapper;
using Homework2.Service.Abstract;
using Homework2.Service.Concrete;

namespace Homework2.Web.StartupExtension
{
    public static class StartupExtension
    {
        public static void AddServices (this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
        }
        public static void AddMapperService(this IServiceCollection services)
        {
            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
        public static void AddBussinessServices(this IServiceCollection services)
        {
            // repos
            services.AddScoped<IGenericRepository<Data.Account>, GenericRepository<Data.Account>>();
            services.AddScoped<IGenericRepository<Person>, GenericRepository<Person>>();

            // services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenManagementService, TokenManagementService>();
        }
    }
}
