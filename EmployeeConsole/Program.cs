using Employees;
using System;
using System.Collections.Generic;



namespace EmployeeConsole
{
    class Program
    {

        public List<Employee> employees = new List<Employee>();

        public void csv_BuildTree()
        {
            employees.Add(new Employee(4, "Saleh", 2));
            employees.Add(new Employee(1, "Ahmed", null));
            employees.Add(new Employee(5, "Selim", 4));
            employees.Add(new Employee(2, "Tarek", 1));
            employees.Add(new Employee(6, "Mohamed", 2));
            employees.Add(new Employee(3, "Hasan", 1));

            EmployeeTreeNode employeeTreeTopNode = Utilities.GetEmployeeTreeNode(employees);

            BuildTree(employeeTreeTopNode);
        }

        public void BuildTree(EmployeeTreeNode node)
        {
            foreach (EmployeeTreeNode childNode in node.ChildNodes)
            {
                BuildTree(childNode);
            }
        }
        static void Main(string[] args)
        {
            Program myTree = new Program();
            myTree.csv_BuildTree();
            Console.WriteLine(myTree.employees.Count);
            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}
