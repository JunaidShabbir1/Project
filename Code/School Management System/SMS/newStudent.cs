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
    public partial class newStudent : Form
    {
        TrainerModel Tm = new TrainerModel();
        public newStudent()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageStudent NextForm = new ManageStudent();
            NextForm.Show();
            this.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtPhone.Text == "" && txtCity.Text == "" &&txtCountry.Text == "" &&txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "" && comGender.SelectedItem == "" )
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tm.AddStudent(txtName.Text, comGender.SelectedItem.ToString(), txtPhone.Text, txtAddress.Text, txtEmail.Text, txtPass.Text, txtCity.Text, txtCountry.Text);
                MessageBox.Show("Successfully add new Student.", "Student Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Text = "";
                txtPass.Text = "";
                txtCity.Text = "";
                txtCountry.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                Tm.StudentGridviewBind(dgv1);
                this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        private void newStudent_Load(object sender, EventArgs e)
        {
            Tm.StudentGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
