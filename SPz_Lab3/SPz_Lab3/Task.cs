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
        private bool TCompleteStatus;
        private DateTime TDateTime;
        private string TAdditionalInf;

        public string Name
        {
            get { return TName; }
            set 
            { 
                if (value == null)
                {
                    MessageBox.Show("You must input task name.");
                }
                else
                {
                    TName = value;
                } 
            }
        }

        public bool Status
        {
            get { return TCompleteStatus; }
            set { TCompleteStatus = value; }
        }

        public DateTime ExDateTime
        {
            get { return TDateTime; }
            set { TDateTime = value; }
        }

        public string AdditionalInf
        {
            get { return TAdditionalInf; }
            set { TAdditionalInf = value; }
        }

        //Default constructor
        public Task()
        {
            Name = "Task";
            Status = false;
        }

        //Copy constructor
        public Task(Task OtherTask)
        {
            Name = OtherTask.Name;
            Status = OtherTask.Status;
            ExDateTime = OtherTask.ExDateTime;
            AdditionalInf = OtherTask.AdditionalInf;
        }

        //Special constructor
        public Task(string InName, string InAdditionalInf)
        {
            Name = InName;
            Status = false;

        }

        //Method Task Execution
        public void ExecuteTask()
        {
            if (Status)
            {
                MessageBox.Show("You can't execute task which is already executed."); 
            }
            else
            {
                try 
                {
                    Status = true;
                    ExDateTime = DateTime.Now;
                }
                catch { }
            }
        }

        //Override Equals for comparison in Comuter Class
        public  bool Equals(Task t)
        {
            if (t == null || ! (t is Task))
                return false;

            return t.Name == this.Name && t.Status == this.Status;
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
