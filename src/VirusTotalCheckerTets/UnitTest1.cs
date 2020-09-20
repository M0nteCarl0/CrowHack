using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirusTotalChecker;
using VirusTotalChecker.Models.Output;

namespace VirusTotalCheckerTests
{
    [TestClass]
    public class ResultContextTests
    {
        [TestMethod]
        public void WaitAnalyzeResult()
        {
            HttpRequest requests = new HttpRequest();
            VirusTotalConfiguration virusTotalConfiguration = new VirusTotalConfiguration();
            IVirusTotal virustotal = new VirusTotal(requests, virusTotalConfiguration);

            var result = virustotal.SendFile("file");
            result.Analyze(virustotal);

        }
    }
}
