Iusing namespace database;

public class administrator: idbase_admin {

    private database_connection;

        int create_member(Member new_member){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();

        }

        int create_provider(Info new_provider){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();

        }

        int remove_member(int id_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int update_memeber(Member updates){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int update_provider(Info updates){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int remove_provider(int id_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int create_service(Service new_service){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int update_service(int svc_number, Service updates){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int remove_service(int svc_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        // search and reports generation
        String[] create_provider_report(int id_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        String [] create_member_report(int id_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        String[] generate_weekly_summary(){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        Info search(int id_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        SvcRecord search_record(int id_number)(){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
            }


}