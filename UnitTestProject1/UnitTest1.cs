using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employees;
using System.Collections.Generic;
using ConsoleApp1;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddEmployeeMethod()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Salah", "Saleh", 2));
            employees.Add(new Employee("Saleh", "", 2));
            employees.Add(new Employee("sam", "Saleh", 2));
            EmployeeTreeNode employeeTreeTopNode = Utilities.GetEmployeeTreeNode(employees);

        }
        [TestMethod]
        public void TestCsvValidate()
        {

            List<csv> values = File.ReadAllLines("C:\\Users\\Toshiba_pc\\source\\repos\\Employees\\employees.csv")
                                            .Select(v => csv.from_csv(v))
                                           .ToList();

        }
        [TestMethod]
        public void SalarySumTest()
        {
            List<Employee> employees = new List<Employee>();
            List<csv> values = File.ReadAllLines("C:\\Users\\Toshiba_pc\\source\\repos\\Employees\\employees.csv")
                                            .Select(v => csv.from_csv(v))
                                           .ToList();
            foreach (csv newemployee in values)
            {
                employees.Add(new Employee(newemployee.ID, newemployee.ManagerID, newemployee.Salary));
            }
            EmployeeTreeNode employeeTreeTopNode = Utilities.GetEmployeeTreeNode(employees);

            Utilities.BuildTree(employeeTreeTopNode);
            EmployeeTreeNode my_search = Utilities.FindNode(employeeTreeTopNode, "Salah");
            int salo_value = Utilities.SumTree(my_search);
            Assert.AreEqual(salo_value, 32);

        }

    }
}
    
    

