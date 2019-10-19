using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPz_Lab3
{
    public partial class ManagerForm : Form
    {
        private CompManager Manager = new CompManager();
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void AddCompButtton_Click(object sender, EventArgs e)
        {
            AddCompForm addComp = new AddCompForm();
            if (addComp.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    bool CompExist = false;
                    for (int counter = 0; counter < Manager._ComputersList.Count; counter++)
                    {
                        if (Manager._ComputersList.ElementAt(counter).Name == addComp.TBCompName.Text)
                            CompExist = true;
                    }

                    if (!CompExist)
                    {
                        Computer tmp = new Computer(addComp.TBCompName.Text == "" ? "" : addComp.TBCompName.Text);
                        Manager.AddComputer(tmp);
                        LBCompurets.Items.Add(Convert.ToString(tmp.Name));
                    }
                    else
                        MessageBox.Show("Computer with the same name already exist!");
                }

                catch (ArgumentNullException)
                {
                    MessageBox.Show("Invalid data input!");
                }
            }

        }

        private void RemoveCompButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.RemoveComputer(LBCompurets.SelectedIndex);
                LBCompurets.Items.RemoveAt(LBCompurets.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Chose computer in ListBox to delete!");
            }
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            if (addTask.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    bool TaskExist = false;
                    for (int counter = 0; counter < Manager._TaskDictionary.Count; counter++)
                    {
                        if (Manager._TaskDictionary.ContainsKey(addTask.TBTaskName.Text))
                            TaskExist = true;
                    }

                    if (!TaskExist)
                    {
                        Task tmp = new Task(addTask.TBTaskName.Text == "" ? "" : addTask.TBTaskName.Text,
                            addTask.TBAdditionalInf.Text == "" ? "" : addTask.TBAdditionalInf.Text);
                        Manager.AddTask(tmp.Name, tmp);
                        LBTasks.Items.Add(Convert.ToString(tmp.Name));
                    }
                    else
                        MessageBox.Show("Task with the same name already exist!");
                }

                catch (ArgumentNullException)
                {
                    MessageBox.Show("Invalid data input!");
                }
            }
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Manager.RemoveTask(LBTasks.SelectedIndex.ToString);
                LBTasks.Items.RemoveAt(LBTasks.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Chose computer in ListBox to delete!");
            }
        }

        private void BAddRouter_Click(object sender, EventArgs e)
        {
            AddRouterForm addRouter = new AddRouterForm();
            if (addRouter.ShowDialog(this) == DialogResult.OK)
            {
                Manager.InstallRouter(addRouter.TBRouterPswd.Text);
            }
        }

    }

}



