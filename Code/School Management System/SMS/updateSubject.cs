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
    public partial class updateSubject : Form
    {
        TrainerModel Tm = new TrainerModel();
   
        public updateSubject()
        {
            InitializeComponent();
        }

        int ID = 0;
        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtScore.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void updateSubject_Load(object sender, EventArgs e)
        {
            Tm.SubjectGridviewBind(dgv1);
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            ManageSubject NextForm = new ManageSubject();
            NextForm.Show();
            this.Visible = false;
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (txtName.Text == "" && txtScore.Text == "")
            {
                MessageBox.Show("Please Atleast Enter all required Fields.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd = new SqlCommand("update Subject set subName=@name,subScore=@score where SubjectID=@id", ConnectionString.connect());
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@score", txtScore.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                Tm.SubjectGridviewBind(dgv1);
                txtName.Text = "";
                txtScore.Text = "";
                txtSearch.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tm.SubjectNameGridviewBind(dgv1, txtSearch.Text);
        }
    }
}
