using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;  
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Model;

namespace SMS
{
    public partial class updateStudent : Form
    {
        TrainerModel Tm = new TrainerModel();
        public updateStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateStudent_Load(object sender, EventArgs e)
        {
            Tm.StudentGridviewBind(dgv1);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TrainerModel.StudentName = dgv1.CurrentCell.Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int ID = 0; 
        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());  
            txtName.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();  
            comGender.SelectedItem = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPass.Text = dgv1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCity.Text = dgv1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCountry.Text = dgv1.Rows[e.RowIndex].Cells[8].Value.ToString();  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tm.StudentNameGridviewBind(dgv1, txtSearch.Text);
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            ManageStudent NextForm = new ManageStudent();
            NextForm.Show();
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (txtName.Text == "" && txtPhone.Text == "" && txtCity.Text == "" && txtCountry.Text == "" && txtName.Text == "" && txtEmail.Text == "" && txtPass.Text == "" && comGender.SelectedItem == "")
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("update Students set sName=@name,sGender=@gender,sPhone=@phone,sAddress=@address,sEmail=@email,sPassword=@pass,sCity=@city,sCountry=@country where StudentID=@id", ConnectionString.connect());
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gender", comGender.SelectedItem);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                Tm.StudentGridviewBind(dgv1);
                this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
        
    }
}
