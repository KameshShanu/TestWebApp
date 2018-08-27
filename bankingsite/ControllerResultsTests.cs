using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;
using WebApplication.Controllers;
using WebApplication.Models;

namespace bankingsite
{
    [TestFixture]
    class ControllerResultsTests
    {

        [Test]
        public void DefaultView()
        {
            var controller = new HomeController();
            controller.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }

        [Test]
        public void AboutPageView()
        {
            var controller = new HomeController();
            controller.WithCallTo(x => x.About()).ShouldRenderView("About");
        }

        [Test]
        public void ContactView()
        {
            var controller = new HomeController();
            controller.WithCallTo(x => x.Contact()).ShouldRenderView("Contact");
        }

        [Test]
        public void Registreview()
        {
            var controller = new AccountController();
            controller.WithCallTo(x => x.Register()).ShouldRenderView("Register");

        }

        [Test]
        public void Loginview()
        {
            var controller = new AccountController();
            controller.WithCallTo(x => x.Login("http://localhost:54881")).ShouldRenderView("Login");
        }

        [Test]
        public void redirectToAction()
        {
            var controller = new AccountController();
        }
    }
}
