using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Post.Contract.Provider;
using Post.Contract.Services;
using Post.Infrastructure.Grpc;

//using Post.Infrastructure.Provider;
using Post.Infrastructure.Services;
using StackExchange.Redis;

namespace Post.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConnectionMultiplexer>(sp =>
            ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis")));

        services.AddScoped<ICacheService, RedisCacheService>();
        //services.AddSingleton<IJsonSerializerOptionsProvider, JsonSerializerOptionsProvider>();
        services.AddSingleton<ICacheVersionManager, RedisCacheVersionManager>();
        services.AddScoped<IFileGrpcClient, FileGrpcClient>();
        return services;
    }
}
