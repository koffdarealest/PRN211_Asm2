using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess.DAO
{
    public class DBContext
    {
        public static SqlConnection GetConnection()
        {
            var Config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            String ConnectionStr = Config.GetConnectionString("salesDB");
            return new SqlConnection(ConnectionStr);
        }

        public static DataTable GetDataBySQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }

        public static int ExcuteSql(String sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0)
            {
                command.Parameters.AddRange(parameters);
            }
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
    }
}
