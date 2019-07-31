namespace database
{
    class SvcRecord {

        private String date_of_svc;
        private String date_time_rcvd;
        private String member_name;
        private int member_number;
        private String provider_name;
        private int provider_number;
        private String comments;
        private Service svc_provided;

        public Date_of_svc{get{return date_of_svc;} set{date_of_svc=value;}}
        public String Date_time_rcvd{get{return date_time_rcvd;} set{date_time_rcvd=value;}}
        public String Member_name{get{return member_name;} set{member_name=value;}}
        public int Member_number{get{return member_number;} set{member_number=value;}}
        public int Provider_number{get{return provider_number;} set{provider_number=value;}}
        public int Provider_number{get{return provider_number;} set{provider_number=value;}}
        public String Comments{get{return comments;} set{comments=value;}}
        public Service Svc_provided{get{return svc_provided;} set svc_provided=value;}}
    }

}