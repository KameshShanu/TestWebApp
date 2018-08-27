using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using WebApplication.Models;

namespace bankingsite
{
    class StonglyTypeNewUser : Page<RegisterViewModel>
    {
        public void Submit()
        {
            Thread.Sleep(5000);
            Find.Element(By.CssSelector("input[type=submit]")).Click();
        }


        public void creatnewUser(RegisterViewModel model)
        {
            Input.Model(model);
            var modelReadFRomPage = Read.ModelFromPage();

            Submit();
        }
    }
}
