using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPz_Lab3
{
    class CompManager
    {

        //CompManager fields & properies
        public List<Computer> _ComputersList;
        public Dictionary<string, Task> _TaskDictionary;
        private int _ComputersAmount { get; set; }
        private int _WorkplaceAmount { get; set; }
        private bool _WiFiStatus { get; set; }
        private string _WiFiPswd { get; set; }


        //Default constructor
        public CompManager()
        {
            _WiFiStatus = false;
            _ComputersList = new List<Computer>();
            _TaskDictionary = new Dictionary<string, Task>();
            _ComputersAmount = _ComputersList.Count;
            _WorkplaceAmount = _ComputersAmount;
        }

        public void TaskToPC(int c, string k)
        {
            _ComputersList[c]._AssignedTasks.Add( _TaskDictionary[k]);
            _ComputersList[c].AmountOfAssgndTsks++;
        }

        public void TaskFromPC(int c, Task t)
        {
            _ComputersList[c]._AssignedTasks.Remove(t);
            _ComputersList[c].AmountOfAssgndTsks--;
        }

        public void AddComputer(Computer c)
        {
            _ComputersList.Add(c);
        }

        public void RemoveComputer(int i)
        {
            _ComputersList.RemoveAt(i);
        }

        public void AddTask(string s, Task t)
        {
            _TaskDictionary.Add(s, t);
        }

        public void RemoveTask(string s)
        {
            _TaskDictionary.Remove(s);
        }

        public void InstallRouter(string pswd)
        {
            if (_WiFiStatus)
            {
                string message = "You can't install WiFi router because it's already installed.";
                string caption = "WiFi router already installed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                _WiFiStatus = true;
                _WiFiPswd = pswd;
            }
        }

        public void RemoveRouter()
        {
            if (!_WiFiStatus)
            {
                string message = "You can't remove WiFi router because it isn't installed.";
                string caption = "WiFi router isn't installed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                _WiFiStatus = false;
            }
        }
    }
}
