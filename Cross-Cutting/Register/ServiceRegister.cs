using CoreServices.Services;
using CoreServices.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cross_Cutting.Register
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            //services.AddScoped<IMDCG_DBContext, MDCG_DBContext>();
            AddRegisterRepositories(services);
            AddRegisterServices(services);

            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {

            //services.AddTransient<ICatalogos_Service, Catalogos_Service>();

            services.AddTransient<ITestService, TestService>();

            return services;
        }

        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {

            //services.AddScoped<IGLOB_GENERO_REPO, GLOB_GENERO_REPO>();


            return services;
        }
    }
}
