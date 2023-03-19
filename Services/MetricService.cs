using Microsoft.Extensions.Configuration;
using MonitoringWebApp.Models;
using Npgsql;

namespace MonitoringWebApp.Services
{
    public class MetricService : IMetricService
    {
        private readonly IDbService _dbService;
        private readonly IConfiguration _config;

        public MetricService(IDbService dbService, IConfiguration config)
        {
            _dbService = dbService;
            _config = config;

        }
        public async Task<List<Metric>> GetMetricList()
        {

            var scriptPath = _config.GetValue<string>("ScriptPath");
            string[] allFiles = Directory.GetFiles(scriptPath, "*.sql");
            string file = allFiles[0];
            string querytext = File.ReadAllText(file);
            var metricList = await _dbService.GetAll<Metric>(querytext, new { });
                return metricList;

            }
    }
}
