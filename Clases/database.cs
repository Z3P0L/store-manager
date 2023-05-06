using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_POO.Clases
{
    internal class database
    {
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

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

        public DataTable Query(string sql, List<SqlParameter> parameters = null)
        {
            cmd = new SqlCommand(sql, OpenConnection());

            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }

            if (sql.ToLower().StartsWith("select"))
            {
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
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
            string sql = "SELECT * FROM " + tableName;
            dt = new DataTable();
            cmd = new SqlCommand(sql, OpenConnection());
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            CloseConnection();
            return dt;
        }

        public DataRow GetById(string tableName, int id)
        {
            string sql = "SELECT * FROM " + tableName + " WHERE Id = @id";
            dt = new DataTable();
            cmd = new SqlCommand(sql, OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);    
            
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
