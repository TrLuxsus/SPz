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
        private List<Computer> CMComputersList { get; set; }
        private Dictionary<string, Task> CMTaskDictionary { get; set; }
        private int CMComputersAmount { get; set; }
        private int CMWorkplaceAmount { get; set; }
        private bool CMWiFiStatus { get; set; }
        private string CMWiFiPswd { get; set; }


        public void TaskToPC(int c, string k)
        {
            CMComputersList[c].AssignedTasks = CMTaskDictionary[k];
        }

        public void TaskFromPC(int c, Task t)
        {
            CMComputersList[c].CAssignedTasks.Remove(t);
        }

        public void AddComputer()
        {
            CMComputersList.Add(new Computer());
        }

        public void RemoveComputer(Computer c)
        {
            CMComputersList.Remove(c);
        }

        public void AddTask()
        {
            Task tmp = new Task();
            CMTaskDictionary.Add(tmp.Name, tmp);
        }

        public void RemoveTask(string s)
        {
            CMTaskDictionary.Remove(s);
        }

        public void InstallRouter(string pswd)
        {
            if (CMWiFiStatus)
            {
                string message = "You can't install WiFi router because it's already installed.";
                string caption = "WiFi router already installed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                CMWiFiStatus = true;
                CMWiFiPswd = pswd;
            }
        }

        public void RemoveRouter()
        {
            if (!CMWiFiStatus)
            {
                string message = "You can't remove WiFi router because it isn't installed.";
                string caption = "WiFi router isn't installed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                CMWiFiStatus = false;
            }
        }
    }
}
