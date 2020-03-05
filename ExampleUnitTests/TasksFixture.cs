using Liquid;
using Liquid.Domain.API;
using Liquid.Runtime.Test;

namespace TasksUnitTest
{
    public class TasksFixture : LightDisposable
    {
        public static ApiWrapper api { get; private set; }
        
        public TasksFixture()
        {
            LightUnitTest.PrepareUnitTestMode("runsettings", WorkBench.EnvironmentName);
            var fullAccessToken = LightUnitTest.GetAuthorization("BackofficeAdmin");
            api = new ApiWrapper("TASKS", fullAccessToken);
            api.Get("reseed/Unit");
        }

        public override void Dispose()
        {

        }
    }
}
