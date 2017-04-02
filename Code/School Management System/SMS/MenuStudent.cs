using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class MenuStudent : Form
    {
        public MenuStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seeResult NextForm = new seeResult();
            NextForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcAvg NextForm = new calcAvg();
            NextForm.Show();
            this.Visible = false;
        }

        private void MenuStudent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm NextForm = new loginForm();
            NextForm.Show();
            this.Visible = false;
        }
    }
}
