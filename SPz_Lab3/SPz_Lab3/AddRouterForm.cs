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
    public partial class AddRouterForm : Form
    {
        public AddRouterForm()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
