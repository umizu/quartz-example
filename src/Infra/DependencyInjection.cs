using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddQuartz()
            .AddQuartzHostedService(opts =>
            {
                opts.WaitForJobsToComplete = true;
            })
            .ConfigureOptions<GreetJobSetup>();

        return services;
    }
}
