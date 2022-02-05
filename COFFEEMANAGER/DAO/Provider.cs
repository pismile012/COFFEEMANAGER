using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace COFFEEMANAGER.DAO
{
    public class Provider
    {
        static string ConnectionString = @"Data Source=DESKTOP-TCBMUD1\SQLEXPRESS;Initial Catalog=QLCoffee;User ID=sa;Password=1";
        SqlConnection Connection { get; set; }
        private static Provider instance;
        public static Provider Instance
        {
            get { if (instance == null) instance = new Provider(); return Provider.instance; }
            private set { Provider.instance = value; }
        }
        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int ExcecuteNonQuery(CommandType cmtType, string sqlSQL,
                        params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = sqlSQL;
                command.CommandType = cmtType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable ExcecuteQuery(CommandType cmtType, string strSQL,
                   params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmtType;
                command.CommandText = strSQL;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable ExeQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
    }
}
