using Microsoft.AspNetCore.Mvc;
using MonitoringWebApp.Attributes;
using MonitoringWebApp.Services;

namespace MonitoringWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiKey]
    public class MetricController : Controller
    {
        private readonly IMetricService _metricService;
        public MetricController(IMetricService metricService)
        {
            _metricService = metricService;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var result = await _metricService.GetMetricList();

            return Ok(result);
        }
    }
}
