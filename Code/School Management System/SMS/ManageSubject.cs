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
    public partial class ManageSubject : Form
    {
        TrainerModel Tm = new TrainerModel();
        public ManageSubject()
        {
            InitializeComponent();
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            Menu NextForm = new Menu();
            NextForm.Show();
            this.Visible = false;
        }

        private void ManageSubject_Load(object sender, EventArgs e)
        {
            Tm.SubjectGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnDelSubj_Click(object sender, EventArgs e)
        {
            Tm.DeleteSubject(Convert.ToInt32(txtDelSubj.Text));
            MessageBox.Show("Successfully Deleted Subject.", "Subject Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtDelSubj.Text = "";
            Tm.SubjectGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            newSubject NextForm = new newSubject();
            NextForm.Show();
            this.Visible = false;
        }

        private void btnUpdateSubj_Click(object sender, EventArgs e)
        {
            updateSubject NextForm = new updateSubject();
            NextForm.Show();
            this.Visible = false;
        }
    }
}
