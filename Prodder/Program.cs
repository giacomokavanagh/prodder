using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prodder
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest ResetWaiting, ResetFailed;

            var strHostAddress = Environment.GetEnvironmentVariable("AF_HOST_ADDRESS");

            ResetWaiting = WebRequest.Create(strHostAddress + "TestRuns/ResetWaitingOrBlockedTestRuns");
            ResetWaiting.GetResponse().GetResponseStream();

            ResetFailed = WebRequest.Create(strHostAddress + "TestRuns/ResetFailedTests");
            ResetFailed.GetResponse().GetResponseStream();
        }
    }
}
