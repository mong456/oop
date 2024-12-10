using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
            }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (value != "")
                    id = value;
            }
        }

        public Employee() { }
        public Employee(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
