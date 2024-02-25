using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStudent
{
    internal class Student : People 
    {
        public Student() { }
        public Student(string name, string address, string id, DateTime birthday, string workcode, string gender, string phone, string email)
            : base(name, address, id, birthday, workcode, gender, phone, email) { }
        ~Student() { }
    }
}
