using NUnit.Framework;
using Pwc.Test.Lib;

namespace Pwc.Test.Tests.Helpers
{
    [TestFixture]
    public class CoreFuncsTests
    {
        CoreFuncs helper;
        [SetUp]
        public void Setup()
        {
            helper = new CoreFuncs();
        }

        [Test]
        public void GetIndexModelTest()
        {
            Assert.AreEqual(helper.GetIndexModel().exception_text, "");
        }

        [Test]
        public void PostDataTest()
        {
            var model = helper.GetIndexModel();
            model.fio = "Иванов Иван Иванович";
            model.captcha_response = "1234";
            var zz = helper.PostData(
                   model
                   );
            Assert.IsNull(zz);
        }

    }
}
