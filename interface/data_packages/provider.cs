using namecpace database;

public class provider: idbase_provider{

        bool validate_provider(int provider_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        bool validate_member(int member_number){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int create_service_record(SvcRecord new_record){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
           
        }

        String[] provider_directory(){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }

        int search_service(String name){
            database_connection.OpenConnection();
            ///Database calls
            database_connection.CloseConnection();
        }
}