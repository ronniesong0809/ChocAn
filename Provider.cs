using System;
using ChocAnDB;
using MySql.dll;

public class Provider : IDBase_provider
{
        public bool Validate_provider(int provider_number)
        {
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        public bool Validate_member(int member_number)
        {
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        public int Create_service_record(SvcRecord new_record)
        {
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();

        }

        public String[] Provider_directory()
        {
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        public int Search_service(String name)
        {
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

    }
}