using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Data;

namespace TodoList.DAO
{
    public class DAO
    {
        #region Declare
        protected IDbConnection _dbConnection = null;
        #endregion

        #region Contructor
        public DAO()
        {
            _dbConnection = new MySqlConnection("User Id=root;Host=localhost;Password=123456789;Database=todolist;Character Set=utf8");
            _dbConnection.Open();
        }
        #endregion
    }
}
