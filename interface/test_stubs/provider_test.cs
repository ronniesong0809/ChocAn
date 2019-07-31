using System.Random;
using System.String;
using database;

/* 
This file is written purely for testing purposes and conditions under which
certain values are obtained (i.e. return false if provider number is not 
divisible by 2) will not be reflective of actual program operation. The methods
below are designed to enable testing of code that uses the interface.
  */

class provider_test: IDBase_provider{

    ///<SUMMARY> returns true if provider number is divisible by 2, else false </SUMMARY>
    bool validate_provider(int provider_number){
        if(provider_number % 2 = 0) {return true;}
        else {return false;}
    }

        bool validate_member(int member_number){
            return validate_provider(member_number);
        }

        int create_service_record(SvcRecord new_record){
            if(new_record == null) {return 0;}
            else {return 1;}
        }
        

        String[] provider_directory(){
            Random rnd = new Random();
            int num = new rnd.Next(0,300);
            if(num == 0) { return ["Nothing to Display"];}

            int code = 12345;
            float fee = 333.33;
            String name = "Service";
            String description = "Description";

            String[] teststring = String[num];
            int i = 0;
            while (i<num) {
                teststring[i] = code + "," + fee + "," + name + "," + description;
                ++i;
            }

        }

        int search_service(String name){
            if(name = null) {return 0;}
            Random rnd = new Random();
            int num = rnd.Next(1, 99999);
            return num;
        }
}