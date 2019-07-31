using System;
namespace ChocAnDB
{
    public class Service
    {
        public Service()
        {
        }
        private int service_code;
        private float service_fee;
        private String service_name;
        private String service_description;

        public String Service_name { get { return service_name; } set { service_name = value; } }
        public String Service_description { get { return service_description; } set { service_description = value; } }
        public int Service_code { get { return service_code; } set { service_code = value; } }
        public float Service_fee { get { return service_fee; } set { service_fee = value; } }
    };
}