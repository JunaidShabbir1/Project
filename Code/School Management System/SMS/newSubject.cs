using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Model;

namespace SMS
{
    public partial class newSubject : Form
    {
        TrainerModel Tm = new TrainerModel();
        public newSubject()
        {
            InitializeComponent();
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            ManageSubject NextForm = new ManageSubject();
            NextForm.Show();
            this.Visible = false;
        }

        private void newSubject_Load(object sender, EventArgs e)
        {
            Tm.SubjectGridviewBind(dgv1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtScore.Text == "")
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tm.AddSubject(txtName.Text,Convert.ToInt32(txtScore.Text));
                MessageBox.Show("Successfully add new Subject.", "Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Text = "";
                txtScore.Text = "";
                Tm.SubjectGridviewBind(dgv1);
            }
        }
    }
}
