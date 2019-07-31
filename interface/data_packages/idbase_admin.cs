

namespace database{

    // The custom data types passed in this interface can be found in the data_packages folder
    // More comments forthcoming. For now, assume 0 is failure and 1 indicates success. 
    // As per the requirements doc, this lays out two interfaces for the database, one for administrators and another for providers
    // Please let me know if you see functionality you will require fromthe database that is not currently indicated here. 
    // EFT report has yet to be figured out - I am not storing that information at this point
    // I will generate some STUBS tomorrow to help you see what the returns will be when you query the database for strings of information

    public interface idbase_admin {

        // create, update, remove records
        int create_member(Member new_member);
        int create_provider(Info new_provider);
        int remove_member(int id_number);
        int update_memeber(Member updates);
        int update_provider(Info updates);
        int remove_provider(int id_number);
        int create_service(Service new_service);
        int update_service(int svc_number, Service updates);
        int remove_service(int svc_number);

        // search and reports generation
        String[] create_provider_report(int id_number);
        String [] create_member_report(int id_number);
        String[] generate_weekly_summary();
        Info search(int id_number);
        SvcRecord search_record(int id_number);

    }

    