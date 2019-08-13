using System;
using Employees;
using System.Collections.Generic;
using System.Linq;
using System.IO;



namespace ConsoleApp1
{



    public class Program
    {

        public List<Employee> employees = new List<Employee>();
        List<csv> values = File.ReadAllLines("C:\\Users\\Toshiba_pc\\source\\repos\\Employees\\employees.csv")
                                .Select(v => csv.from_csv(v))
                               .ToList();
        public void csv_BuildTree()
        {
            values.ForEach(x => employees.Add(new Employee(x.ID, x.ManagerID, x.Salary)));
            //employees.Add(new Employee(values[0].ID, null, 200));
            //employees.Add(new Employee(values[1].ID, "Salah", 200));

            EmployeeTreeNode employeeTreeTopNode = Utilities.GetEmployeeTreeNode(employees);        
            Utilities.BuildTree(employeeTreeTopNode);
            Console.WriteLine("hierarchy built");
            string testString;
            Console.Write("Enter a employee name to view salaries - ");
            testString = Console.ReadLine();
            EmployeeTreeNode my_search = Utilities.FindNode(employeeTreeTopNode, testString);
            int salo_value = Utilities.SumTree(my_search);
            Console.WriteLine(salo_value);
        }

        static void Main(string[] args)
        {
            Program myTree = new Program();
            myTree.csv_BuildTree();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
