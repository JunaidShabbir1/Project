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
    public partial class Menu : Form
    {
        TrainerModel Tm = new TrainerModel();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login.GetTrainerName(lblAdmin);
            Tm.StudentGridviewBind(dgv1);
            Tm.SubjectGridviewBind(dgv2);
            this.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            ManageStudent NextForm = new ManageStudent();
            NextForm.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSubject NextForm = new ManageSubject();
            NextForm.Show();
            this.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeResult NextForm = new MakeResult();
            NextForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm NextForm = new loginForm();
            NextForm.Show();
            this.Visible = false;
        }
    }
}
