using March2023.Page;
using March2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Runtime.CompilerServices;
using TechTalk.SpecFlow;

namespace March2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions: CommonDriver
    {
		LoginPage loginObj = new LoginPage();
		HomePage homeObj = new HomePage();
		TMPage tMObj = new TMPage();

		[Given(@"I logged into turn portal successfully")]
        public void GivenILoggedIntoTurnPortalSuccessfully()
        {
			// Open chrome browser
            driver = new ChromeDriver();

			// Login page
			loginObj.LoginAction(driver);
		}

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // TM page object initialization and definition
			homeObj.GoToTMPage(driver);
		}

		[When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tMObj.CreateNew(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tMObj.GetCode(driver);
            string newDescription = tMObj.GetDescription(driver);
            string newPrice = tMObj.GetPrice(driver);

            Assert.That(newCode == "February2023", "Actual code and expected code do not match.");
            Assert.That(newDescription == "Feb23", "Actual code and expected code do not match.");
            Assert.That(newPrice == "12", "Actual code and expected code do not match.");
        }

		[When(@"I update '([^']*)' on an existing time and material record")]
		public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
		{
            tMObj.Edit(driver, description);
		}

		[Then(@"The record should have the updated '([^']*)'")]
		public void ThenTheRecordShouldHaveTheUpdated(string description)
		{
			throw new PendingStepException();
		}

	}
}
