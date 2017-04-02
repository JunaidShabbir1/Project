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
    class StudentModel
    {
        public void SeeALLResultGridviewBind(DataGridView dgv,int stdID)
        {
            try
            {
                string StudentNames = "select s.sName as Student_Name,sb.subName as Subject_Name,r.Score as Obtained_Marks,sb.subScore as Total_Marks from StdResult r Inner Join Students s On r.StudentID= s.StudentID INNER Join Subject sb on r.SubjectID=sb.SubjectID Where s.StudentID=" + stdID + "";
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

        public void SeeResultGridviewBind(DataGridView dgv, ComboBox SubjectComboBox)
        {
            try
            {
                string StudentNames = "select s.sName as Student_Name,sb.subName as Subject_Name,r.Score as Obtained_Marks,sb.subScore as Total_Marks from StdResult r Inner Join Students s On r.StudentID= s.StudentID INNER Join Subject sb on r.SubjectID=sb.SubjectID Where sb.subName= '" + SubjectComboBox.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(StudentNames, ConnectionString.connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(),"DB Connection ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            
        }

        public void AverageResultGridviewBind(DataGridView dgv, int stdID)
        {
            try
            {
                string query = "select COUNT(r.Score)as Total_Courses,AVG(r.Score) as Average_Marks from StdResult r INNER Join Students s On r.StudentID= s.StudentID INNER Join Subject sb on r.SubjectID=sb.SubjectID Where s.StudentID=" + stdID + "";
                SqlCommand cmd = new SqlCommand(query, ConnectionString.connect());
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

        public void GetStdSubjects(ComboBox comBox)
        {
            try
            {
                Login.GetStudentID();
                string query = "select sb.subName from Subject sb INNER Join StdResult r on sb.SubjectID=r.SubjectID Inner JOin Students s on r.StudentID=s.StudentID where s.StudentID=" + Login.StudentID + "";
                SqlCommand sqlCmd = new SqlCommand(query, ConnectionString.connect());
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    comBox.Items.Add(sqlReader["subName"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "DB Connection ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

    }
}
