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
    public partial class seeResult : Form
    {
        StudentModel Sm = new StudentModel();
        public seeResult()
        {
            InitializeComponent();
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            MenuStudent NextForm = new MenuStudent();
            NextForm.Show();
            this.Visible = false;
        }

        private void seeResult_Load(object sender, EventArgs e)
        {
            Sm.GetStdSubjects(comboBox1);
            Sm.SeeALLResultGridviewBind(dgv1, Login.StudentID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sm.SeeResultGridviewBind(dgv1, comboBox1);
        }

    }
}
