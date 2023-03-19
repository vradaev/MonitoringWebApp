using MonitoringWebApp.Models;

namespace MonitoringWebApp.Services
{
    public interface IMetricService
    {
        Task<List<Metric>> GetMetricList();
    }
}
