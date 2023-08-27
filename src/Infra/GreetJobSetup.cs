using Microsoft.Extensions.Options;
using Quartz;

namespace Infra;

public class GreetJobSetup : IConfigureOptions<QuartzOptions>
{
    public void Configure(QuartzOptions options)
    {
        var greetJobKey = JobKey.Create(nameof(GreetJob));

        options
            .AddJob<GreetJob>(jobBuilder => jobBuilder.WithIdentity(greetJobKey))
            .AddTrigger(trigger =>
                trigger
                    .ForJob(greetJobKey)
                    .WithDailyTimeIntervalSchedule(scheduler =>
                        scheduler
                            .OnEveryDay()
                            .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(9, 29))
                            .WithRepeatCount(0)
                    ));
    }
}
