using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pwc.Test.Web.Controllers;
using Pwc.Test.Lib.Models;

namespace Pwc.Test.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        HomeController controller;
        [SetUp]
        public void Setup()
        {
            controller = new HomeController();
        }

        [Test]
        public void IndexTest()
        {

            Assert.IsNotNull(controller.Index());
        }

        [Test]
        public void ReloadModelTest()
        {
            Assert.IsNotNull(controller.ReloadModel());
        }

    }
}
