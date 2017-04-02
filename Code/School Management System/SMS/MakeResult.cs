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
    public partial class MakeResult : Form
    {
        TrainerModel Tm = new TrainerModel();

        public MakeResult()
        {
            InitializeComponent();
        }

        private void MakeResult_Load(object sender, EventArgs e)
        {
            Login.GetTrainerName(txtTrainer);
            Login.GetTrainerName(label5);
            txtTrainer.Enabled = false;
            Tm.StudentGridviewBind(dgv1);
            Tm.SubjectGridviewBind(dgv2);
            Tm.ResultGridviewBind(dgv3);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            Menu NextForm = new Menu();
            NextForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStudent.Text == "" && txtSubject.Text == "" && txtScore.Text == "")
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tm.AddResult(Convert.ToInt32(txtTrainer.Text), Convert.ToInt32(txtStudent.Text), Convert.ToInt32(txtSubject.Text), Convert.ToDouble(txtScore.Text));
                Tm.ResultGridviewBind(dgv3);
                txtScore.Text = "";
                txtStudent.Text = "";
                txtSubject.Text = "";
                this.dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
        SqlCommand cmd;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtStudent.Text == "" && txtSubject.Text == "" && txtScore.Text == "")
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("update StdResult set TrainerID=@tID,StudentID=@StdID,SubjectID=@SubjID,Score=@score where ResultID=@id", ConnectionString.connect());
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@tID", txtTrainer.Text);
                cmd.Parameters.AddWithValue("@StdID", txtStudent.Text);
                cmd.Parameters.AddWithValue("@SubjID", txtSubject.Text);
                cmd.Parameters.AddWithValue("@score", txtScore.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                Tm.ResultGridviewBind(dgv3);
                txtStudent.Text = "";
                txtScore.Text = "";
                txtSubject.Text = "";
            }
        }
        int ID = 0;
        private void dgv3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtStudent.Text = dgv3.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSubject.Text = dgv3.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtScore.Text = dgv3.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete StdResult where ResultID=@id", ConnectionString.connect());
                
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully!");
                Tm.ResultGridviewBind(dgv3);
                txtStudent.Text = "";
                txtScore.Text = "";
                txtSubject.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
