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

        public DataTable Query(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, OpenConnection());

            if (sql.ToLower().StartsWith("select"))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CloseConnection();
                return dt;
            }

            cmd.ExecuteNonQuery();
            CloseConnection();

            return null;
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

        public DataRow GetById(string tableName, int id)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM " + tableName + " WHERE Id = @id";
            using (SqlCommand cmd = new SqlCommand(sql, OpenConnection()))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            CloseConnection();
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
    }
}
