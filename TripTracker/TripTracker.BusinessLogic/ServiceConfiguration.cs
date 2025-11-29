using Microsoft.Extensions.DependencyInjection;
using TripTracker.BusinessLogic.Services;
using TripTracker.DataAccess;
using TripTracker.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection services, string connectionString)
        {
            //services.AddScoped<DepartamentoRepository>();
            //services.AddScoped<MunicipioRepository>();
            //services.AddScoped<CargoRepository>();
            //services.AddScoped<AreaRepository>();
            //services.AddScoped<DeduccionRepository>();
            services.AddScoped<UsuarioRepository>();
            //services.AddScoped<EstadoCivilRepository>();
            //services.AddScoped<RolRepository>();
            //services.AddScoped<FrecuenciaPagoRepository>();
            //services.AddScoped<EmpleadoRepository>();
            //services.AddScoped<PlanillaRepository>();

            TripTrackerContext.BuildConnectionString(connectionString);
        }

        public static void BusinessLogic(this IServiceCollection services)
        {
            //services.AddScoped<GeneralServices>();
            //services.AddScoped<RecursosHumanosServices>();
            services.AddScoped<AccesoServices>();

        }


    }
}
