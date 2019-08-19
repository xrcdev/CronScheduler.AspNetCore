﻿using System;
using System.Threading;
using System.Threading.Tasks;

using CronScheduler.AspNetCore;

using Microsoft.Extensions.Logging;

namespace CronSchedulerApp.Jobs.Startup
{
    public class TestStartupJob : IStartupJob
    {
        private readonly ILogger<TestStartupJob> _logger;

        public TestStartupJob(ILogger<TestStartupJob> logger)
        {
            _logger = logger;
        }

        public async Task ExecuteAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("{job} started", nameof(TestStartupJob));

            await Task.Delay(TimeSpan.FromSeconds(3));

            _logger.LogInformation("{job} ended", nameof(TestStartupJob));
        }
    }
}
