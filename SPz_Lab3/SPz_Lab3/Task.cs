using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SPz_Lab3
{
    public class Task: IEquatable<Task>
    {
        //Task fields & properies
        private string TName { get; set; }
        private bool TCompleteStatus { get; set; }
        private DateTime TDateTime { get; set; }
        private string TAdditionalInf { get; set; }

        //Default constructor
        public Task()
        {
            TName = "Task";
            TCompleteStatus = false;
        }

        //Copy constructor
        public Task(Task OtherTask)
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
                string message = "You can't execute task which is already executed.";
                string caption = "Task already executed.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, caption, buttons); 
            }
            else
            {
                TCompleteStatus = true;
                TDateTime = DateTime.Now;
            }
        }

        //Override Equals for comparison in Comuter Class
        public  bool Equals(Task t)
        {
            if (t == null || ! (t is Task))
                return false;

            return t.TName == this.TName && t.TCompleteStatus == this.TCompleteStatus;
        }

        public override bool Equals(object obj) => Equals(obj as Task);
        public override int GetHashCode() => (TName).GetHashCode();
        
        /*
        //Override GetHashCode for comparison in Comuter Class
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        */
    }
}
