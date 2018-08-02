using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractionTests
{
    [TestClass]
    public class EmployeeManager
    {
        [TestMethod]
        public void TestGetTotalSalary()
        {
            // arrange
            var Tom = new Abstraction.WorkerBee("Tom");
            var Jerry = new Abstraction.Boss("Jerry");
            var employees = new Abstraction.Employee[] { Tom, Jerry };
            var expectedResult = Tom.GetSalary() + Jerry.GetSalary();
            // act
            var employeeManager = new Abstraction.EmployeeManager();
            var salaryResult = employeeManager.GetTotalSalary(employees);
            // assert
            Assert.AreEqual(expectedResult, salaryResult);
        }
    }
}
