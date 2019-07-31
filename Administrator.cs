using System;
using ChocAnDB;

class Administrator : IDB_Admin
{

    private database_connection;

    public int Create_member(Member new_member)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();

    }

    public int Create_provider(Info new_provider)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();

    }

    public int Remove_member(int id_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Update_member(Member updates)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Update_provider(Info updates)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Remove_provider(int id_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Create_service(Service new_service)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Update_service(int svc_number, Service updates)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public int Remove_service(int svc_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    // search and reports generation
    public String[] Create_provider_report(int id_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public String[] Create_member_report(int id_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public String[] Generate_weekly_summary()
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public Info Search(int id_number)
    {
        database_connection.OpenConnection();
        ///Database calls
        database_connection.CloseConnection();
    }

    public SvcRecord Search_record(int id_number)(){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
            }
}