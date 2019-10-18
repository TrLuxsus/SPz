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
        private string TName;
        private bool TCompleteStatus { get; set; }
        private DateTime TDateTime { get; set; }
        private string TAdditionalInf { get; set; }

        public string Name
        {
            get { return TName; }
            set { TName = value; }
        }

        //Default constructor
        public Task()
        {
            Name = "Task";
            TCompleteStatus = false;
        }

        //Copy constructor
        public Task(Task OtherTask)
        {
            Name = OtherTask.TName;
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

            return t.Name == this.Name && t.TCompleteStatus == this.TCompleteStatus;
        }

        public override bool Equals(object obj) => Equals(obj as Task);
        public override int GetHashCode() => (Name).GetHashCode();
        
        /*
        //Override GetHashCode for comparison in Comuter Class
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        */
    }
}
