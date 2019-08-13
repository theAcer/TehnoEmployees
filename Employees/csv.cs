using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Employees
{
    public class csv
    {
        public string ID;
        public string ManagerID;
        public int Salary;
        public static int root_count = 0;


        public static csv from_csv(string csvline)
        {
            csv myv = new csv();
            string[] values = csvline.Split(',');

            if (values[0] == "")
            {
                throw new System.ArgumentException("Employee Parameter cannot be null");
            }
            else
            {
                myv.ID = Convert.ToString(values[0]);
            }
            if (values[1] == "" && csv.root_count == 0)
            {
                csv.root_count++;
                values[1] = null;
                myv.ManagerID = null;
            }
            else if (values[1] == "" & csv.root_count == 1)
            {
                throw new System.ArgumentException("Only one manager root allowed");
            }
            else { myv.ManagerID = Convert.ToString(values[1]); }


            Regex regex = new Regex(@"\d");

            if (regex.IsMatch(values[2]))
            {
                //true
                myv.Salary = Convert.ToInt32(values[2]);
            }
            else
            {
                throw new System.ArgumentException("Only integers allowed in salary field");

            }


            return myv;


        }

    }
}
