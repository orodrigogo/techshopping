using System;
using System.Data;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class UserBusiness
    {
        DataAccessSqlServer sqlServer = new DataAccessSqlServer();

        public User Login(string email, string password)
        {
            try
            {
                sqlServer.ParametersClear();
                sqlServer.ParameterAdd("email", email);
                sqlServer.ParameterAdd("password", password);

                DataTable data = sqlServer.QueryExecute(CommandType.StoredProcedure, "spEmployeesUserSignIn");

                if (data.Rows.Count > 0)
                {
                    User user = new User();
                    user.Id = data.Rows[0].Field<int>("id");
                    user.Name = data.Rows[0].Field<string>("name");
                    user.Email = data.Rows[0].Field<string>("email");

                    return user;
                }
                else
                {
                    throw new Exception("Usuário ou Senha inválido!");
                }
            }catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        } 
    }
}
