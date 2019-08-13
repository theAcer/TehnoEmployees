using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public string ID { set; get; }
        public string ManagerID { set; get; }
        public int Salary { set; get; }

        public Employee() { }

        public Employee(string id, string managerID, int salary)
        {
            ID = id;
            ManagerID = managerID;
            Salary = salary;
        }
    }
}
