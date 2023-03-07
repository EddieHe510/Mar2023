using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.Pages
{
	public class EmployeePage : CommonDriver
	{
		public void CreateEmployee(IWebDriver driver)
		{
			// Identify the Create button and click on it
			IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
			createButton.Click();

			// Identify the Name TextBox and input value
			IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
			nameTextBox.SendKeys("Eddie");

			// Identify the Username TextBox and input value
			IWebElement usernameTextBox = driver.FindElement(By.Id("Username"));
			usernameTextBox.SendKeys("EddieHe");

			// Identify the Edit Contact button and click on it
			IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
			editContactButton.Click();

			// Switch to Edit Contact frame and input value
			driver.SwitchTo().Frame(driver.FindElement(By.TagName("iframe")));

			IWebElement firstNameTextBox = driver.FindElement(By.Id("FirstName"));
			firstNameTextBox.SendKeys("Eddie");

			IWebElement lastNameTextBox = driver.FindElement(By.Id("LastName"));
			lastNameTextBox.SendKeys("He");

			IWebElement phoneTextBox = driver.FindElement(By.Id("Phone"));
			phoneTextBox.SendKeys("123456789");

			IWebElement emailTextBox = driver.FindElement(By.Id("email"));
			emailTextBox.SendKeys("111222333@gmail.com");

			IWebElement addressTextBox = driver.FindElement(By.Id("autocomplete"));
			addressTextBox.SendKeys("78 Mary St, Mount Eden, Auckland");

			IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
			saveContactButton.Click();

			Thread.Sleep(2000);
			// Switch back to the main frame
			driver.SwitchTo().ParentFrame();

			// Identify the Password TextBox and input value
			IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
			passwordTextBox.SendKeys("Ed12345!");

			// Identify the Retype Password TextBox and retype the same password
			IWebElement retypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
			retypePasswordTextBox.SendKeys("Ed12345!");

			// Identify the IsAdmin checkbox and click on it
			IWebElement isAdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
			isAdminCheckBox.Click();

			// Identify the Groups dropdown list and click on it
			IWebElement groupsDropDown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
			groupsDropDown.Click();

			Thread.Sleep(2000);

			IWebElement ddddOp = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[4]"));
			ddddOp.Click();

			// Identify the Save button and click on it
			IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
			saveButton.Click();

			// Identify the Back to list button and click on it
			IWebElement bTLButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
			bTLButton.Click();
			Thread.Sleep(3000);

			// Check if new employee has been created
			IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
			goToLastPage.Click();

			IWebElement newEmployee = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
			Assert.That(newEmployee.Text == "Eddie", "Actual code and expected code do not match.");
		}

		public void EditEmployee(IWebDriver driver)
		{
			// Identify the gotolast page button and click on it
			IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
			goToLastPage.Click();

			// Identify the employee and click the edit button
			IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
			editButton.Click();

			//


		}

		public void DeleteEmployee(IWebDriver driver)
		{

		}
	}
}