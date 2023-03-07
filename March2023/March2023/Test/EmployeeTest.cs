using Feb2023.Pages;
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
	public class Employees_Test : CommonDriver
	{
		EmployeePage empObj = new EmployeePage();
		HomePage homePageObj = new HomePage();

		[Test, Order(1)]
		public void CreateEmployeeTest()
		{
			homePageObj.GoToEmployeePage(driver);
			empObj.CreateEmployee(driver);
		}

		[Test, Order(2)]
		public void EditEmployeeTest()
		{
			homePageObj.GoToEmployeePage(driver);
			empObj.EditEmployee(driver);
		}

		[Test, Order(3)]
		public void DeleteEmployeeTest()
		{
			homePageObj.GoToEmployeePage(driver);
			empObj.DeleteEmployee(driver);
		}
	}
}
