using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPz_Lab3
{
    class CompManager
    {

        //CompManager fields & properies
        private List<Computer> CMComputersList { get; set; }
        private Dictionary<Task,int> CMTaskDictionary { get; set; }
        private int CMComputersAmount { get; set; }
        private int CMWorkplaceAmount { get; set; }
        private bool CMWiFiStatus { get; set; }
        private string CMWiFiPswd { get; set; }
    }
}
