using System;
namespace ChocAnDB
{
    public class Info
    {
        public Info()
        {
        }
        // generic profile for members and providers since all data fields are shared!

        // private data
        private String name;
        private int id_number;
        private String address;
        private String city;
        private String state;
        private int zip;

        // public properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id_number { get { return id_number; } set { id_number = value; } }
        public String Address { get { return address; } set { address = value; } }
        public String City { get { return city; } set { city = value; } }
        public String State { get { return state; } set { state = value; } }
        public int Zip { get { return zip; } set { zip = value; } }

    };

    class Member : Info
    {
        private int account_status;

        public Account_status{get{return account_status;}
    set{account_status=value;}}

    };
}
