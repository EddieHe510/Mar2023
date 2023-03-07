using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Page
{
	public class HomePage
	{
		public void GoToTMPage(IWebDriver driver)
		{
			// Identify the Administration dropdown list and click on it
			IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
			administrationDropDown.Click();

			// Identify the TM option and click on it
			IWebElement tMOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
			tMOption.Click();
		}

		public void GoToEmployeePage(IWebDriver driver) 
		{
			// Identify the Administration dropdown list and click on it
			IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
			administrationDropDown.Click();

			// Identify the Employee option and click on it
			IWebElement empObj = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
			empObj.Click();
		}
	}
}