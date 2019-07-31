using System;
using MySql.dll;
using ChocAnDB
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
        }
        private MySqlConnection connection;

        public MySqlConnection Connection { get { return connection; } }

        public bool OpenConnection()
        {
    private string cs = @"server=localhost; userid=root; password=; database=chocan_DB";
        Connection = null;
try {
    connection = new MySqlConnection(cs);
        connection.Open();
}
catch (MySqlException ex) {
    switch (ex.Number) {
        case 0:
        Debug.log("Cannot connect to server.");
        break;

        case 1045:
        Debug.log("");
        break;
    }
}
}

public bool CloseConnection()
{

    if (connection != null)
    {
        connection.Close();
    }
}
}
}

    }
}
