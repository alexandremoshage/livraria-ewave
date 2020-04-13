using Livraria.AppServices.AutoMapper;
using Livraria.Domain.Interfaces.Repositories;
using Livraria.Domain.Interfaces.Services;
using Livraria.Domain.Services;
using Livraria.Domain.UnitOfWork;
using Livraria.Infra.Data.Context;
using Livraria.Infra.Data.Repositories;
using Livraria.Infra.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Infra.CrossCutting.IoC
{
    public class NativeInjectorMapping
    {
        public static void RegisterServices(IServiceCollection services)
        { 
            RegisterServicesDomain(services);
            RegisterServicesRepository(services);

            services.AddSingleton(AutoMapperConfiguration.RegisterMappings().CreateMapper());
            services.AddScoped<LivrariaContext>();
        }
          
        private static void RegisterServicesDomain(IServiceCollection services)
        {
            services.AddScoped<ILivroService, LivroService>(); 
        }

        private static void RegisterServicesRepository(IServiceCollection services)
        {
            services.AddScoped<ILivroRepository, LivroRepository>();
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
