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
    public partial class ManageStudent : Form
    {
        TrainerModel Tm = new TrainerModel();
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            Menu NextForm = new Menu();
            NextForm.Show();
            this.Visible = false;
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            newStudent NextForm = new newStudent();
            NextForm.Show();
            this.Visible = false;
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            Tm.StudentGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            Tm.DeleteStudent(Convert.ToInt32(txtDelStd.Text));
            MessageBox.Show("Successfully Deleted Student.", "Student Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtDelStd.Text = "";
            Tm.StudentGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            updateStudent NextForm = new updateStudent();
            NextForm.Show();
            this.Visible = false;
        }
    }
}
