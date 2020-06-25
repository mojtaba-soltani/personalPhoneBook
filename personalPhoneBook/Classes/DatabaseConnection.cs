using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DatabaseConnectionNamespace.Classes
{
    static class DatabaseConnection
    {
        //database fields
        private static string _dataSource = ".";
        private static string _initialCatalog = "personalPhoneBook";
        private static string _connectingString = "";
        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static SqlDataAdapter _sqlDataAdapter;
        private static DataTable _dataTable;

        //open coonnection
        public static void OPenConnection()
        {
            _connectingString = $"Data Source={_dataSource};Initial Catalog = {_initialCatalog};Integrated Security=true;";
            _connection = new SqlConnection(_connectingString);
            _connection.Open();
        }

        //close connection
        public static void CloseConnection()
        {
            _connection.Close();
        }

        //sql query
        public static void CreateCommand(string queryString)
        {
            _command = new SqlCommand(queryString, _connection);
        }

        //bind values
        public static void BindValues(string param, string value)
        {
            _command.Parameters.AddWithValue(param, value);
        }

        //select query
        public static DataTable ExecuteQueries()
        {
            _sqlDataAdapter = new SqlDataAdapter(_command);
            _dataTable = new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            return _dataTable;
        }

        //delete, insert and update query
        public static void ExecuteNonQueries()
        {
            _command.ExecuteNonQuery();
        }
    }
}
