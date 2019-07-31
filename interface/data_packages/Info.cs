
namespace database{

class Info { // generic profile for members and providers since all data fields are shared!
       
        // private data
        private String name;
        private int id_number;
        private String address;
        private String city;
        private String state;
        private int zip;

        // public properties
        public Name{get{return name;} set{name=value;}}
        public Id_number{get{return id_number;} set{id_number=value;}}
        public Address{get{return address;} set{address=value;}}
        public City {get{return city;} set{city=value;}}
        public State {get{return state;} set{state=value;}}
        Public Zip{get{return zip;} set{zip=value;}}
        
    };

class Member: Info {
        private int account_status;

        public Account_status{get{return account_status;} set{account_status=value;}}
    }

}