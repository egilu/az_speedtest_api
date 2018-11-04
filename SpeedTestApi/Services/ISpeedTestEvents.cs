using System.Threading.Tasks;
using SpeedTestApi.Models;
using SpeedTestApi.Models.SpeedTestApi.Models;

namespace SpeedTestApi.Services
{
    public interface ISpeedTestEvents
    {
        Task PublishSpeedTest(TestResult SpeedTest);
    }
}