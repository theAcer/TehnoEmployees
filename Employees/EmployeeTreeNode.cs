using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class EmployeeTreeNode
    {
        public Employee Employee { set; get; }
        public bool IsProcessed { set; get; }

        public bool IsBuilt { set; get; }
        public bool IsSummed { set; get; }
        public int Level { set; get; }

        private List<EmployeeTreeNode> childNodes;
        public List<EmployeeTreeNode> ChildNodes
        {
            get { return childNodes; }
        }

        public EmployeeTreeNode()
        {
            Level = 0;
            childNodes = new List<EmployeeTreeNode>();
        }

        public EmployeeTreeNode(Employee employee, bool isProcessed) : this()
        {
            Level = 0;
            Employee = employee;
            IsProcessed = isProcessed;
        }


        public IEnumerable<EmployeeTreeNode> GetNodeAndDescendants() // Note that this method is lazy
        {
            return new[] { this }
                   .Concat(childNodes.SelectMany(child => child.GetNodeAndDescendants()));
        }

        public int BuildTree(EmployeeTreeNode node)
        {

            foreach (EmployeeTreeNode childNode in node.ChildNodes)
            {
                BuildTree(childNode);
               

            }
            return 1;
        }

    }
}
