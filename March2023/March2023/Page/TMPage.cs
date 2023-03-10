using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Page
{
	public class TMPage
	{
		public void CreateNew(IWebDriver driver)
		{
			// Identify the CreateNew Button and click on it
			IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
			createNew.Click();

			// Identify the TypeCode drop down list and select the Time option
			IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
			typeCode.Click();

			// selecte the time option
			IWebElement timeOp = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
			timeOp.Click();

			Thread.Sleep(2000);

			// Identify the Code TextBox and input code
			IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
			codeTextBox.SendKeys("February2023");

			// Identify the Description textbox and input description
			IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
			descriptionTextBox.SendKeys("Feb23");

			// Identify the Price TextBox and input price
			IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
			priceTextBox.SendKeys("12");

			// Identify the Save button and click on it
			IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
			saveButton.Click();
			Thread.Sleep(2000);


			// Check if new Time record has been created
			IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
			goToLastPageButton.Click();
			Thread.Sleep(5000);
		}


		public string GetCode(IWebDriver driver)
		{
			IWebElement acutalCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
			return acutalCode.Text;
		}

		public string GetDescription(IWebDriver driver) 
		{
			IWebElement acutalDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
			return acutalDescription.Text;
		}

		public string GetPrice(IWebDriver driver) 
		{
			IWebElement acutalPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
			return acutalPrice.Text;
		}




		public void Edit(IWebDriver driver, string description, string code, string price)
		{
			// Identify the gotolast page button and click on it
			IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
			goToLastPage.Click();

			Thread.Sleep(2000);

			// Identify the last record and click the edit button
			IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
			editButton.Click();

			// Identify the Code TextBox clean it and input new code
			IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
			codeTextBox.Clear();
			codeTextBox.SendKeys(code);

			// edit description textbox
			IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
			editDescriptionTextBox.Clear();
			editDescriptionTextBox.SendKeys(description);
			Thread.Sleep(1500);

			// Identify the Price TextBox clean it and input new code
			IWebElement priceTextBox = driver.FindElement(By.XPath("//input[@id='Price']"));
			priceTextBox.Clear();
			priceTextBox.SendKeys(price);

			// Identify the save button and click on it
			IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
			saveButton.Click();

			// wait for 2s
			Thread.Sleep(2000);

			// Check if the new record has been changed
			IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
			goToLastPageButton.Click();

			//IWebElement newRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
			//Assert.That(newRecord.Text != "Eddie-March2023", "The new record hasn't been changed");
		}

		public string GetEditedDescription(IWebDriver driver)
		{
			IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
			return createdDescription.Text;
		}
		public string GetEditedCode(IWebDriver driver)
		{
			IWebElement acutalCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
			return acutalCode.Text;
		}

		public string GetEditedPrice(IWebDriver driver)
		{
			IWebElement acutalPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
			return acutalPrice.Text;
		}


		public void Delete(IWebDriver driver)
		{
			// Identify the gotolast page button and click on it
			IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
			goToLastPage.Click();

			Thread.Sleep(2000);

			// Identify the delete button and click on it
			IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
			deleteButton.Click();

			// Acquire Alert and click the acceot
			IAlert deleteAlert = driver.SwitchTo().Alert();
			deleteAlert.Accept();

		}

		internal void Edit(IWebDriver driver, string description)
		{
			throw new NotImplementedException();
		}
	}
}
