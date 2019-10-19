using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPz_Lab3
{
    class Computer: IComparable<Computer>
    {
        //Computer fields

        private string _Name;

        public List<Task> _AssignedTasks;
        private int _AmountOfAssgndTsks;
        private bool _Status { get; set; }


        public string Name
        {
            get { return _Name; }
            set
            {
                if (value == null || value == "")
                {
                    MessageBox.Show("You must input computer name.");
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public Task AssignedTasks 
        {
            set { _AssignedTasks.Add(value); }
        }

        public int AmountOfAssgndTsks
        {
            get { return _AmountOfAssgndTsks; }
            set { _AmountOfAssgndTsks = value; }
        }

        //Special constructor
        public Computer(string InName)
        {
            Name = InName;
            _Status = true;
            _AssignedTasks = new List<Task>();
            AmountOfAssgndTsks = _AssignedTasks.Count;
        }



        //Override Equals for comparison in Comuter Class
        public override bool Equals(object c)
        {
            if (c == null || !(c is Computer))
                return false;

            return (((Computer) c)._Status == this._Status &&
                ((Computer)c)._AmountOfAssgndTsks == this._AmountOfAssgndTsks &&
                ((Computer)c)._AssignedTasks.SequenceEqual(this._AssignedTasks));
        }

        public override int GetHashCode() => (Name).GetHashCode();
        public static bool operator ==(Computer c1, Computer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Computer c1, Computer c2)
        {
            return !c1.Equals(c2);
        }

        int IComparable<Computer>.CompareTo(Computer obj)
        {
            if (this._AmountOfAssgndTsks > obj._AmountOfAssgndTsks)
                return 1;
            if (this._AmountOfAssgndTsks < obj._AmountOfAssgndTsks)
                return -1;
            else
                return 0;
        }

    }
}
