using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;

namespace bankingsite
{
    class HomePage : Page
    {
        public NewUserPage GoToNewUser()
        {
            return Navigate.To<NewUserPage>(By.Id("registerLink"));
        }
    }
}
