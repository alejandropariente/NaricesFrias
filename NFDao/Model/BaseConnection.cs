using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFDao.Model
{
    public class BaseConnection
    {
        private string sever = "DESKTOP-7S64QUV";
        private string dataBase = "DbNaricesFrias";
        private string user = "SA";
        private string password = "123bolitas";
        private string connectionString;
        private SqlConnection connection;

        public BaseConnection()
        {
            connectionString = $"Server={this.sever};Database={this.dataBase};User Id={this.user};Password={this.password}";
            connection = new SqlConnection(connectionString);
        }

        public SqlCommand CreateComand(string query)
        {
            return new SqlCommand(query, this.connection);
        }

        public int ExecuteCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { command.Connection.Close(); }
        }

        public DataTable DataTableCommand(SqlCommand command)
        {
            DataTable data = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { command.Connection.Close(); }
        }
        public int ExecuteScalarId(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteScalar() == null ? 0 : (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { command.Connection.Close(); }
        }
    }
}
