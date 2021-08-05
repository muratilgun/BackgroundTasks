using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackgroundTasks
{
    public class MyScopedService : IScopedService
    {
        private readonly ILogger<MyBackgroundService> _logger;

        public MyScopedService(ILogger<MyBackgroundService> logger)
        {
            _logger = logger;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public void Write()
        {
            _logger.LogInformation("MyScopedService {Id}", Id);   
        }
    }

    public interface IScopedService
    {
        void Write();
    }
}
