using database;
using random;

class admin_test: idbase_admin{

///<SUMMARY> The create functions return 0 for success and 1 or 2 to indicate falure due to a null object or field</SUMMARY> 
    int create_member(Member new_member){
        if(new_member == null) {return 1;}
        if(new_member.name == null || new_member.id == null || new_member.address == null || new_member.city == null || new_member.state == null || new_member.zip <= 0) {return 2;}
        else {return 0;}
    }

    int create_provider(Info new_provider){
        if(new_provider == null) {return 1;}
        if(new_provider.name == null || new_provider.id == null || new_provider.address == null || new_provider.city == null || new_provider.state == null || new_provider.zip <= 0) {return 2;}
        else {return 0;}
    }

///<SUMMARY> The remove member function returns 1 if the number if divisible by 7, 2 if it is divisible by 11, and 0 otherwise. 1 and 2 indicate failures, 1 being the member account is delinquent and must be settled before the member is removed, and 2 being the ID number was invalid. </SUMMARY>
    int remove_member(int id_number){
        if(id_number <= 0) {return 0;}
        if(id_number % 7) {return 1;}
        if(id_number % 11) {return 2;}
        else {return 0;}

    }

    int update_memeber(Member updates){
        if(updates == null) {return 1;}
        if(updates.name == null && updates.id <= null && updates.address == null && updates.city == null && updates.state == null && updates.zip == 0) {return 2;}
        else {return 0;}
    }

    int update_provider(Info updates){
        if(updates == null) {return 1;}
        if(updates.name == null && updates.id == null && updates.address == null && updates.city == null && updates.state == null && updates.zip == 0) {return 2;}
        else {return 0;}
    }

    int remove_provider(int id_number){
        return remove_member(id_number);
    }

    int create_service(Service new_service){
        if(new_service == null) {return 1;}
        if(new_service.service_code == 0 || new_service.service_fee == 0.0 || new_service.service_name == null) {return 2;}
        else {return 0;}
    }

     int update_service(int svc_number, Service updates){
         if(svc_number < 0) {return 1;}
         if(updates.fee < 0) {return 2;}
         else {return 0;}

    }

    int remove_service(int svc_number){
        if(svc_number < 0) {return 1;}
        if(svc_number % 7 == 0) {return 2;}
        if(svc_number % 11 == 0) {return 3;}
        else {return 0;}

        }

    String[] generate_weekly_summary(int id_number){
        
        Random rnd = new Random();
        int num = rnd.Next(0, 500);
        if(num == 0) {return "Nothing to display";}

        date_of_svc = "00-00-0000";
        date_time_rcvd = "00-00-0000 00:00:00";
        member_name = "Test Subject";
        member_number = 111111;
        provider_name = "Dr. Tester";
        provider_number = 222222;
        comments = "Comments here";
        svc_provided = "Test Service";
        svc_fee = 333.33;

        String[] teststring = new String[num];
        int i = 0;
        while (i<num) {

            teststring[i] = date_of_svc + "," + date_time_rcvd + "," + member_name + "," + member_number + "," + provider_name + "," + provider_number + "," + comments + "," + svc_prov + "," + svc_fee;
            ++i;
        }
            

        }

    String[] create_member_report(int id_number){
        
        if(id_number <= 0) {return "invalid ID";}
        int size = id_number % 45;
        if (size == 44) {return "query not found";} 

        String[] teststring = new String[size];

        // variables to fill strings
        String m_name = "Test Subject";
        int m_num = 111111;
        String m_addr = "1000 E Summer St";
        String m_city = "Acity"; 
        String m_st = "ST";
        int m_zip = 12345;
        String svc_date = "01-01-2111";
        String prov_name = "Dr. Tester";
        String svc_prov = "they did this thing";

        teststring[0] = m_name + "," + m_num + "," + m_addr + "," + m_city + "," + m_st + "," + m_zip;
        int i = 1;
        while (i<size) {
            teststring[i] = svc_date + "," + prov_name + "," + svc_prov;
            i++;
            } 

        return teststring;

        }

    String[] create_provider_report(){

        Random rnd = new Random();
        int num = rnd.Next(0,200);

        if(num == 0) { return "No reports";}

        String[] teststring = String[num+2];

        String p_name = "Test Subject";
        int p_num = 111111;
        String p_addr = "1000 E Summer St";
        String p_city = "Acity"; 
        String p_st = "ST";
        int p_zip = 12345;
        String svc_date = "01-01-2111";
        String dt_rcvd = "01-02-2111 03:20:22";
        String m_name = "Dr. Tester";
        int svc_code = 12345;
        float fee = 333.33;
        float total_fee = 33333.33;

        teststring[0] = p_name + "," + p_num + "," + p_addr + "," + p_city + "," + p_st + "," + p_zip;

        int i = 1;

        while(i <= num) {
            teststring[i] = svc_date + "," + dt_rcvd + "," + m_name + "," + svc_code + "," + fee;
            ++i;
            }

        teststring[num+1] = num + "," + "fee";

        return teststring;

        }

        Info search(int id_number){
            if(id_number == 0) {return null;}

            Info testinfo = new Info();
            testinfo.Name = "Test subject";
            testinfo.Id = 111111;
            testinfo.City = "Aplace";
            testinfo.State = "ST";
            testinfo.Zip = 12345;

            return testinfo;
        }

        SvcRecord search_record(int id_number){

            if(id_number == 0) {return null;}

            SvcRecord testrecord = new SvcRecord();
            testrecord.Date_of_svc = "00-00-0000";
            testrecord.Date_time_rcvd = "00-00-0000 00:00:00";
            testrecord.Member_name = "Test Subject";
            testrecord.Member_number = 111111;
            testrecord.Provider_name = "Dr. Tester";
            testrecord.Provider_number = 222222;
            testrecord.Comments = "Comments here";
            testrecord.Svc_provided = "Test Service";

            return SvcRecord;

        }
}