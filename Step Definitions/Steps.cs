using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;

namespace ProJect.Step_Definitions
{
    [Binding]
    public class Steps : br
    {
      
        public PageObj rp;

        [Given(@"User Launch Chrome Browser")]
        public void GivenUserLaunchChromeBrowser()
        { 
            rp = new PageObj(driver);
            //driver.Manage().Window.Maximize();
        }

        [When(@"User opens url  ""([^""]*)""")]
        public void WhenUserOpensUrl(string p)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(p);
        }

        [When(@"enters Email as ""([^""]*)"" and password as ""([^""]*)""")]
        public void WhenEntersEmailAsAndPasswordAs(string User, string pass)
        {
            rp.email(User);
            rp.password(pass);

        }

        [When(@"click on register buttton")]
        public void WhenClickOnRegisterButtton()
        {
            Thread.Sleep(5000);
           rp.Register();
        }

    }
}
