using March2023.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Utilities
{
	public class CommonDriver
	{
		public static IWebDriver driver;

		[SetUp]
		public void LoginSteps()
		{
			driver = new ChromeDriver();

			LoginPage loginObj = new LoginPage();
			loginObj.LoginAction(driver);
		}

		[TearDown]
		public void CloseBrowser()
		{
			driver.Quit();
		}
	}
}