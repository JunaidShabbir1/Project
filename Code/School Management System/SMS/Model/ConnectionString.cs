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
    class ConnectionString
    {
        static SqlConnection con;
        public static SqlConnection connect()
        {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Junaid\Documents\visual studio 2013\Projects\SMS\SMS\Db\smsDB.mdf;Integrated Security=True";
                con.Open();
                return con;
            
        }
    }
}
