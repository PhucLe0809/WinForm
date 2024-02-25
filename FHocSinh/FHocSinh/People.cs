using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStudent
{
    internal class People
    {
        private string name;
        private string address;
        private string id;
        private DateTime birthday;
        private string workcode;
        private string gender;
        private string phone;
        private string email;
        public People()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.id = string.Empty;
            this.birthday = DateTime.Now;
            this.workcode = string.Empty;
            this.gender = string.Empty;
            this.phone = string.Empty;
            this.email = string.Empty;
        }
        public People(string name, string address, string id, DateTime birthday, string workcode, string gender, string phone, string email)
        {
            this.name = name;
            this.address = address;
            this.id = id;
            this.birthday = birthday;
            this.workcode = workcode;
            this.gender = gender;
            this.phone = phone;
            this.email = email;
        }
        ~People() { }
        public string Name
        {
            get { return this.name; }
        }
        public string Address
        {
            get { return address; }
        }
        public string Id
        {
            get { return id; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
        }
        public string Workcode
        {
            get { return workcode; }
        }
        public string Gender
        {
            get { return gender; }
        }
        public string Phone
        {
            get { return phone; }
        }
        public string Email
        {
            get { return email; }
        }
    }
}
