using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJect
{
    public class PageObj
    {
		public IWebDriver driver;

		public PageObj(IWebDriver redriver)
		{
			driver = redriver;
			PageFactory.InitElements(redriver, this);
		}


		[FindsBy(How = How.Id, Using = "username")]
		public IWebElement emailbox;

		[FindsBy(How = How.Id, Using = "password")]
	       IWebElement passbox;

		[FindsBy(How = How.XPath, Using = "//input[@name='login']")]
		IWebElement registerbutton;

		public void email(String email)
		{
			emailbox.SendKeys(email);
		}

		public void password(String password)
		{
			
			passbox.SendKeys(password);
		}

		public void Register()
		{
			registerbutton.Click();

		}

	}
}
