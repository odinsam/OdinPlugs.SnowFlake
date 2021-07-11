using Microsoft.Extensions.DependencyInjection;
using OdinPlugs.SnowFlake.SnowFlakePlugs;
using OdinPlugs.SnowFlake.SnowFlakePlugs.ISnowFlake;

namespace OdinPlugs.SnowFlake.Inject
{
    public static class SnowFlakeInject
    {

        /// <summary>
        /// inject SnowFlake
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="datacenterId">datacenter Id</param>
        /// <param name="workId">work Id</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddSingletonSnowFlake(this IServiceCollection services, long datacenterId, long workId)
        {
            services.AddSingleton<IOdinSnowFlake>(new OdinSnowFlake(datacenterId, workId));
            return services;
        }


        /// <summary>
        /// inject SnowFlake
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="datacenterId">datacenter Id</param>
        /// <param name="workId">work Id</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddTransientSnowFlake(this IServiceCollection services, long datacenterId, long workId)
        {
            services.AddTransient<IOdinSnowFlake>(provider => new OdinSnowFlake(datacenterId, workId));
            return services;
        }

        /// <summary>
        /// inject SnowFlake
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="datacenterId">datacenter Id</param>
        /// <param name="workId">work Id</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddScopedSnowFlake(this IServiceCollection services, long datacenterId, long workId)
        {
            services.AddScoped<IOdinSnowFlake>(provider => new OdinSnowFlake(datacenterId, workId));
            return services;
        }
    }
}