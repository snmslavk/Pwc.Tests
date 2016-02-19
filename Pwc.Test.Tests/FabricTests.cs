using NUnit.Framework;
using Pwc.Test.Lib.Factories;

namespace Pwc.Test.Tests
{
    [TestFixture]
    public class FabricTests
    {
        HelpersFactory factory;
        [SetUp]
        public void Setup()
        {
            factory = new HelpersFactory();
        }

        [Test]
        public void CreateParseHtmlHelper()
        {
            Assert.DoesNotThrow(
                () =>
                {
                    factory.GetParseHtmlHelper();
                }
            );
        }

        [Test]
        public void CreateCoreFuncsHelper()
        {
            Assert.DoesNotThrow(
                () =>
                {
                    factory.GetCoreFuncsHelper();
                }
            );

        }

        [Test]
        public void CreateKisaErdModel()
        {
            Assert.DoesNotThrow(
                () =>
                {
                    factory.GetKisaErdModel();
                }
            );
        }

        [Test]
        public void CreateWebClientHelper()
        {
            Assert.DoesNotThrow(
                () =>
                {
                    factory.GetWebClientHelper();
                }
            );
        }
    }
}
