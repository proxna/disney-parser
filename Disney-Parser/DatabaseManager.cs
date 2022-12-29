using MySql.Data.MySqlClient;

namespace Disney_Parser
{
    internal class DatabaseManager
    {
        public void ExecuteQuery(string query)
        {
            using MySqlConnection mySqlConnection = new(Constants.ConnectionString);
            mySqlConnection.Open();

            using MySqlCommand command = new();
            command.Connection = mySqlConnection;
            command.CommandText = query;

            command.ExecuteNonQuery();
        }

        public int GetVoiceActorId(string query)
        {
            using MySqlConnection mySqlConnection = new(Constants.ConnectionString);
            mySqlConnection.Open();

            using MySqlCommand command = new();
            command.Connection = mySqlConnection;
            command.CommandText = query;

            using MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                return reader.GetInt32(0);
            }

            return -1;
        }
    }
}
