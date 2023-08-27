using Microsoft.Extensions.Logging;
using Quartz;

namespace Infra;

[DisallowConcurrentExecution]
public class GreetJob : IJob
{
    private readonly ILogger<GreetJob> _logger;

    public GreetJob(ILogger<GreetJob> logger) => _logger = logger;

    public Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation("{UtcNow}: Greetings!", DateTime.UtcNow);
        return Task.CompletedTask;
    }
}
