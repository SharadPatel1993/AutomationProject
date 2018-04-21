using System.Threading;
using NUnit.Framework;

namespace TestHarness.Tests
{
    [TestFixture]
    public class SmokeTest : TestBase
    {
        [Test]
        public void OpenSite()
        {
            Thread.Sleep(5000);
        }
    }
}
