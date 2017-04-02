using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SMS.Model
{
    class Login 
    {
        public static string TrainerName { get; set; }
        public static string StudentName { get; set; }
        public static int StudentID { get; set; }
        string usrname, password;

        public void CheckStudentOrTrainer(ComboBox com, string uname, string pass)
        {
            try
            {
                if (com.SelectedItem == "Trainer")
                {
                    this.usrname = uname;
                    this.password = pass;
                    bool check = doLoginTrainer();
                    if (check)
                    {
                        Form f = new Menu();
                        f.Show();
                    }
                    else
                    {
                        loginForm f = new loginForm();
                        f.Show();

                    }
                }
                else if (com.SelectedItem == "Student")
                {
                    this.usrname = uname;
                    this.password = pass;
                    bool checkk = doLoginStudent();
                    if (checkk)
                    {
                        Form f = new MenuStudent();
                        f.Show();
                    }
                    else
                    {
                        loginForm f = new loginForm();
                        f.Show();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        

        //Get Logged in Trainer Name
        public static void GetTrainerName(Label lbl)
        {
            try
            {
                string query = "Select UPPER(tName) from Trainer where tEmail = '" + TrainerName + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                lbl.Text = sc.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        public static void GetTrainerName(TextBox txt)
        {
            try
            {
                string query = "Select TrainerID from Trainer where tEmail = '" + TrainerName + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                txt.Text = sc.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Get logged in Student Name
        public static void GetStudentName(Label lbl)
        {
            try
            {
                string query = "Select sName from Students where sEmail = '" + StudentName + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                lbl.Text = sc.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static void GetStudentID()
        {
            try
            {
                string query = "Select StudentID from Students where sEmail = '" + StudentName + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                StudentID = Convert.ToInt32(sc.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Trainer Login logic
        public bool doLoginTrainer()
        {
            try
            {
                var query = "SELECT tEmail,tPassword FROM Trainer WHERE tEmail ='" + usrname + "' AND tPassword='" + password + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                sc.CommandType = CommandType.Text;
                SqlDataAdapter sdt = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sdt.Fill(dt);

                string userid = dt.Rows[0][0].ToString();
                string pass = dt.Rows[0][1].ToString();
                TrainerName = dt.Rows[0][0].ToString();
                if (userid != null && pass != null)
                {
                    
                }
                return true;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username Password..","Wrong Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        //Student Login logic
        public bool doLoginStudent()
        {
            try
            {
                var query = "SELECT sEmail,sPassword FROM Students WHERE sEmail ='" + usrname + "' AND sPassword='" + password + "'";
                SqlCommand sc = new SqlCommand(query, ConnectionString.connect());
                sc.CommandType = CommandType.Text;
                SqlDataAdapter sdt = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sdt.Fill(dt);

                string userid = dt.Rows[0][0].ToString();
                string pass = dt.Rows[0][1].ToString();
                StudentName = dt.Rows[0][0].ToString();
                if (userid != null && pass != null)
                {

                }
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username Password..", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
