using System;
namespace ChocAnDB
{
    public interface IDB_Admin

    {// create, update, remove records
        int Create_member(Member new_member);
        int Create_provider(Info new_provider);
        int Remove_member(int id_number);
        int Update_member(Member updates);
        int Update_provider(Info updates);
        int Remove_provider(int id_number);
        int Create_service(Service new_service);
        int Update_service(int svc_number, Service updates);
        int Remove_service(int svc_number);

        // search and reports generation
        String[] Create_provider_report(int id_number);
        String[] Create_member_report(int id_number);
        String[] Generate_weekly_summary();
        Info Search(int id_number);
        SvcRecord Search_record(int id_number);


        
    }
}
