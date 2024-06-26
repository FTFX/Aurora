﻿namespace Aurora.Framework.Data.Extensions
{
    public static class DataServiceCollectionExtensions
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.AddScoped<DataService>();
            return services;
        }
    }
}
