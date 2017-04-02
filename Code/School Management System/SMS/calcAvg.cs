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
    public partial class calcAvg : Form
    {
        StudentModel Sm = new StudentModel();
        public calcAvg()
        {
            InitializeComponent();
        }

        private void calcAvg_Load(object sender, EventArgs e)
        {
            Sm.AverageResultGridviewBind(dgv1, Login.StudentID);
        }

        private void btnBk_Click(object sender, EventArgs e)
        {
            MenuStudent NextForm = new MenuStudent();
            NextForm.Show();
            this.Visible = false;
        }
    }
}
