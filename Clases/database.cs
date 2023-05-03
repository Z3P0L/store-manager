using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO.Clases
{
    internal class database
    {
        public static string dbRoute = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diear\Desktop\Diego\Universidad\Desarrollo Software POO\pcSetup\Proyecto_POO\master.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection connection = new SqlConnection( dbRoute );

        public SqlConnection OpenConnection()
        {
            if ( connection.State == ConnectionState.Closed ) connection.Open();
            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if ( connection.State == ConnectionState.Open ) connection.Close();
            return connection;
        }

        public DataTable GetAll(string tableName)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM " + tableName;
            using (SqlCommand cmd = new SqlCommand(sql, OpenConnection()))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            CloseConnection();
            return dt;
        }

    }
}
