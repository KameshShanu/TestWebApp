using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.Seleno.Extensions;
using TestStack.Seleno.PageObjects;

namespace bankingsite
{
    class NewUserPage : Page
    {
        private const string registerlink = "registerLink";
        private const string emailtxt = "Email";
        private const string passwordxt = "Password";
        private const string confirmpasswodtxt = "ConfirmPassword";
        private const string rgisterbtn = "input[type=submit]";

        public void navigateregistrelink()
        {
            Find.Element(By.Id(registerlink)).Click();
        }

        public string email
        {
            get
            {
                return Find.Element(By.Id(emailtxt)).GetControlValueAs<string>();
            }

            set
            {
                Find.Element(By.Id(emailtxt)).SendKeys(value);
            }
        }

        public string password
        {
            get
            {
                return Find.Element(By.Id(passwordxt)).GetControlValueAs<string>();
            }
            set
            {
                Find.Element(By.Id(passwordxt)).SendKeys(value);
            }
        }

        public string conformpassword
        {
            get
            {
                return Find.Element(By.Id(confirmpasswodtxt)).GetControlValueAs<string>();
            }
            set
            {
                Find.Element(By.Id(confirmpasswodtxt)).SendKeys(value);
            }
        }

        public void submit()
        {
            Thread.Sleep(5000);
            Find.Element(By.CssSelector(rgisterbtn)).Click();
        }

        public void CreatNewUser(string emailss, string passwordss, string cnpass)
        {
            email = emailss;
            password = passwordss;
            conformpassword = cnpass;
            submit();
        }
    }
}
