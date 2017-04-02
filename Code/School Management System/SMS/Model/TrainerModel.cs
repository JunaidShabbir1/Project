using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMS.Model
{
    class TrainerModel
    {
        public static string StudentName { get; set; }

        public void StudentGridviewBind(DataGridView dgv)
        {
            try
            {
                string StudentNames = "Select * FROM Students ORDER By sName";
                SqlCommand cmd = new SqlCommand(StudentNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void StudentNameGridviewBind(DataGridView dgv, string sname)
        {
            try
            {
                string StudentNames = "Select * FROM Students where sName LIKE '%" + sname + "%' ORDER By sName";
                SqlCommand cmd = new SqlCommand(StudentNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void SubjectNameGridviewBind(DataGridView dgv, string sname)
        {
            try
            {
                string SubjectNames = "Select * FROM Subject where subName LIKE '%" + sname + "%' ORDER By subName";
                SqlCommand cmd = new SqlCommand(SubjectNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SubjectGridviewBind(DataGridView dgv)
        {
            try
            {
                string StudentNames = "Select * FROM Subject ORDER By subName";
                SqlCommand cmd = new SqlCommand(StudentNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void ResultGridviewBind(DataGridView dgv)
        {
            try
            {
                string rNames = "Select * FROM StdResult";
                SqlCommand cmd = new SqlCommand(rNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void DeleteStudent(int StudentID)
        {
            try
            {
                string query = "DELETE FROM Students WHERE StudentID = " + StudentID + "";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void AddStudent(string name,string gender, string phone,string address, string email,string pass,string city,string country)
        {
            try
            {
                string query = "INSERT INTO Students (sName, sGender, sPhone, sAddress, sEmail, sPassword, sCity, sCountry, timeStampe) VALUES  ('" + name + "','" + gender + "','" + phone + "','" + address + "','" + email + "','" + pass + "','" + city + "','" + country + "',GETDATE())";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddSubject(string name, int score)
        {
            try
            {
                string query = "INSERT INTO Subject (subName, subScore) VALUES  ('" + name + "'," + score + ")";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        public void AddResult(int tID, int stdID, int subjID, double Score)
        {
            try
            {
                string query = "INSERT INTO StdResult (TrainerID, StudentID, SubjectID, Score, timeStamp) VALUES  (" + tID + "," + stdID + "," + subjID + "," + Score + ",GETDATE())";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        public void DeleteSubject(int SubjectID)
        {
            try
            {
                string query = "DELETE FROM Subject WHERE SubjectID = " + SubjectID + "";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}
