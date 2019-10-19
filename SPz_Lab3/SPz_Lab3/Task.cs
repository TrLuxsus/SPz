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
        private string _Name;
        private bool _CompleteStatus;
        private DateTime _DateTime;
        private string _AdditionalInf;

        public string Name
        {
            get { return _Name; }
            set 
            { 
                if (value == null || value == "")
                {
                    MessageBox.Show("You must input task name.");
                }
                else
                {
                    _Name = value;
                } 
            }
        }

        public bool Status
        {
            get { return _CompleteStatus; }
            set { _CompleteStatus = value; }
        }

        public DateTime ExDateTime
        {
            get { return _DateTime; }
            set { _DateTime = value; }
        }

        public string AdditionalInf
        {
            get { return _AdditionalInf; }
            set { _AdditionalInf = value; }
        }

        public override string ToString()
        {
            return Name;
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
        public Task(string InName, string InAdditionalInf="")
        {
            Name = InName;
            Status = false;
            AdditionalInf = InAdditionalInf;
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
