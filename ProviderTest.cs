using System;
using ChocAnDB;

/* 
This file is written purely for testing purposes and conditions under which
certain values are obtained (i.e. return false if provider number is not 
divisible by 2) will not be reflective of actual program operation. The methods
below are designed to enable testing of code that uses the interface.
  */

class ProviderTest : IDBase_Provider
{

    ///<SUMMARY> returns true if provider number is divisible by 2, else false </SUMMARY>
    public bool validate_provider(int provider_number)
    {
        if (provider_number % 2 == 0) { return true; }
        else { return false; }
    }

    public bool validate_member(int member_number)
    {
        return validate_provider(member_number);
    }

    public int create_service_record(SvcRecord new_record)
    {
        if (new_record == null) { return 0; }
        else { return 1; }
    }


    public String[] Provider_directory()
    {
        Random rnd = new Random();
        int num = new rnd.Next(0, 300);
        if (num == 0) { return null; }

        int code = 12345;
        double fee = 333.33;
        String name = "Service";
        String description = "Description";

        String[] teststring = new String[num];
        int i = 0;
        while (i < num)
        {
            teststring[i] = code + "," + fee + "," + name + "," + description;
            ++i;
        }

    }

    public int search_service(String name)
    {
        if (name.Equals(null)) { return 0; }
        Random rnd = new Random();
        int num = rnd.Next(1, 99999);
        return num;
    }
}