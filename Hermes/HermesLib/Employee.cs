using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesLib
{
    public class Employee
    {

        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (_id == value)
                {
                    return;
                }
                _id = value;
            }
        }

        
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                    if (_name == value)
                    {
                        return;
                    }
                  _name = value;
                }
        }

        public Employee()
        {
            _id = 0;
            _name = "name";

        }

        public Employee(int id)
        {
            ID = id;
            Name = "name"+ID;

        }

    }
}
