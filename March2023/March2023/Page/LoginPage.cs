using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Page
{
	public class LoginPage
	{
		public void LoginAction(IWebDriver driver)
		{
			// Maximize the window
			driver.Manage().Window.Maximize();

			// Lauch the turnup portal
			driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

			// Identify Username Textbox and entry valid username
			IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
			userNameTextBox.SendKeys("hari");

			// Identify Password Textbox and entry valid password
			IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
			passwordTextBox.SendKeys("123123");

			// Identify the Log in button and click on it
			IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
			loginButton.Click();


		}

	}
}