using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccessSqlServer
    {
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(@"Data Source=.\;Initial Catalog=techshopping;Integrated Security=True");
        }

        public void ParametersClear()
        {
            sqlParameterCollection.Clear();
        }

        public void ParameterAdd(string name, object value)
        {
            sqlParameterCollection.Add(new SqlParameter(name, value));
        }

        public object PersistenceExecute(CommandType commandType, string instruction)
        {
            SqlConnection sqlConnection = CreateConnection();

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = instruction;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                return sqlCommand.ExecuteScalar();
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    
        public DataTable QueryExecute(CommandType commandType, string instruction)
        {
            SqlConnection sqlConnection = CreateConnection();
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = instruction;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
