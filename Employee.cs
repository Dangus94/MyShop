using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int ManagerLevel  { get; set; }
        public Employee()
        {
            this.Name = " ";
            this.EmployeeNumber = 0;
            this.ManagerLevel = 1;

        }

        public Employee ( string name, int empNum, int manLev)
        {
            this.Name = name;
            this.EmployeeNumber = empNum;
            this.ManagerLevel = manLev;
        }


    }
}
