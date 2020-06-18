using System.Data.SQLite;
using System.Data;

namespace Clients
{
    class ConnectDataBase
    {
        private static SQLiteConnection connection = new SQLiteConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        private static SQLiteCommand command = new SQLiteCommand();
        private static void CreateConnection() => connection.Open();
        private static void CloseConnection() => connection.Close();
        public static void InputSqlInquiry(string inquiry)
        {
            CreateConnection();
            command.Connection = connection;
            command.CommandText = inquiry;
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public static string GetSqlInquiry(string inquiry)
        {
            string result;
            CreateConnection();
            command.Connection = connection;
            command.CommandText = inquiry;
            result = command.ExecuteScalar().ToString();
            CloseConnection();
            return result;
        }
        public static DataTable GetData(string sql)
        {
            CreateConnection();
            command.Connection = connection;
            command.CommandText =sql;
            SQLiteDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataReader.Close();
            CloseConnection();
            return dataTable;
        }
    }
}
