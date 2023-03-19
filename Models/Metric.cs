using MonitoringWebApp.Services;

namespace MonitoringWebApp.Models
{
    public class Metric
    {
        public DateTime Date => DateTime.Now;
        public int Name { get; set; }
    }
}
