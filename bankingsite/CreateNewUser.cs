using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;
using WebApplication.Controllers;
using WebApplication.Models;
using Xania.AspNet.Simulator;

namespace bankingsite
{
    [TestFixture]
    public class CreateNewUser
    {
        [Test]
        public void UserAddedOK()
        {
            //var instance = new SelenoHost();
            //instance.Run("WebApplication", 54881);
            //Thread.Sleep(5000);

            var registerMenulink = Host.Instance.Application.Browser.FindElement(By.Id("registerLink"));
            registerMenulink.Click();

            var emailtxt = Host.Instance.Application.Browser.FindElement(By.Id("Email"));
            emailtxt.SendKeys("test@gmail.com");

            var passwordxt = Host.Instance.Application.Browser.FindElement(By.Id("Password"));
            passwordxt.SendKeys("123456");

            var confirmpasswodtxt = Host.Instance.Application.Browser.FindElement(By.Id("ConfirmPassword"));
            confirmpasswodtxt.SendKeys("123456");

            //var rgisterbtn = instance.Application.Browser.FindElement(By.ClassName("btn-default"));
            //rgisterbtn.Click();
            var rgisterbtn = Host.Instance.Application.Browser.FindElement(By.CssSelector("input[type=submit]"));
            rgisterbtn.Click();

            Thread.Sleep(2000);
        }

        [Test]
        public void WithPageObjects()
        {
            Thread.Sleep(2000);
            HomePage homepage = Host.Instance.NavigateToInitialPage<HomePage>();

            //NewOrderPage newOrderPage = homepage.GoToNewOrder();
            NewUserPage newuser = homepage.GoToNewUser();
            newuser.navigateregistrelink();
            newuser.email = "test@gh.com";
            newuser.password = "test";
            newuser.conformpassword = "test";
            newuser.submit();
        }

        [Test]
        public void WithPAgeObjectImprove()
        {
            var newuser = Host.Instance.NavigateToInitialPage<NewUserPage>("/Account/Register");
            newuser.CreatNewUser("test@gmail.com", "test", "test");
        }

        [Test]
        public void wihtstrongpageobject()
        {
            var newuser = Host.Instance.NavigateToInitialPage<AccountController, StonglyTypeNewUser>(x => x.Register());
            var newusertocreate = new RegisterViewModel
            {
                Email = "test@dfgdfg",
                Password = "test",
                ConfirmPassword = " test"

            };
            newuser.creatnewUser(newusertocreate);
        }
    }
}
