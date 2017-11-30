using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using WebApplication1.Data;

namespace WebApplication1.BackgroundTasks
{
    public class SampleBackgroundTask : IHostedService
    {
        private readonly FakeDb _fakeDb;

        public SampleBackgroundTask(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while (true)
            {
                await Task.Delay(3000, cancellationToken).ContinueWith(t =>
                {
                    _fakeDb.IncreaseValue();;
                }, cancellationToken);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
