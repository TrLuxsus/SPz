using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SPz_Lab3
{
    class Task
    {
        //Task fields & properies
        private string TName { get; set; }
        private bool TCompleteStatus { get; set; }
        private DateTime TDateTime { get; set; }
        private string TAdditionalInf { get; set; }

        //Default constructor
        Task()
        {
            TName = "Task";
            TCompleteStatus = false;
        }

        //Copy constructor
        Task(Task OtherTask)
        {
            TName = OtherTask.TName;
            TCompleteStatus = OtherTask.TCompleteStatus;
            TDateTime = OtherTask.TDateTime;
            TAdditionalInf = OtherTask.TAdditionalInf;
        }

        //Method Task Execution
        public void ExecuteTask()
        {
            if (TCompleteStatus)
            {
                /*
                string message = "You can't execute task which is already executed.";
                string caption = "Task already executed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons);
                */
            }
            else
            {
                TCompleteStatus = true;
                TDateTime = DateTime.Now;
            }
        }
    }
}
