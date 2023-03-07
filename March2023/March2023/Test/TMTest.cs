using March2023.Page;
using March2023.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2023.Test
{
	[TestFixture]
	[Parallelizable]
	public class TMTest : CommonDriver
	{
		// Page object initialization
		HomePage homeObj = new HomePage();
		TMPage tMObj = new TMPage();

		[Test, Order(1)]
		public void CreateNew()
		{
			homeObj.GoToTMPage(driver);
			tMObj.CreateNew(driver);
		}

		[Test, Order(2)]
		public void Edit()
		{
			homeObj.GoToTMPage(driver);
			tMObj.Edit(driver);
		}

		[Test, Order(3)]
		public void Delete()
		{
			homeObj.GoToTMPage(driver);
			tMObj.Delete(driver);
		}
	}
}