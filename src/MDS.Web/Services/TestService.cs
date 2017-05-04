using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDS.Web.Services
{
    public interface ITestService
    {
        string Test();
    }

    public class TestService : ITestService
    {
        private string testMessage;

        public TestService(IConfiguration configuration)
        {
            testMessage = configuration["message"];
        }
        public string Test()
        {
            return testMessage;
        }
    }
}
