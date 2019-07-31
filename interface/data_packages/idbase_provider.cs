namespace database{

public interface idbaase_provider {

        bool validate_provider(int provider_number);
        bool validate_member(int member_number);
        int create_service_record(SvcRecord new_record);
        String[] provider_directory();
        int search_service(String name);

    }

}