using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FStudent
{
    internal class PeopleDAO
    {
        DBConnection DBConnection = new DBConnection();
        string DBname;
        public PeopleDAO()
        {
            this.DBname = "";
        }
        private void UpdateDBname(People people)
        {
            if (people is Student) this.DBname = "HocSinh";
            if (people is Lecture) this.DBname = "GiaoVien";
        }
        public DataTable Load(People people)
        {
            UpdateDBname(people);
            return DBConnection.Load("SELECT *FROM " + DBname);
        }
        public void Add(People people)
        {
            UpdateDBname(people);
            DBConnection.Execution(people, "INSERT INTO " + DBname + "(FullName , Address, ID, Birthday, Workcode, Gender, Phone, Email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", "Add");
        }
        public void Delete(People people)
        {
            UpdateDBname(people);
            DBConnection.Execution(people, "DELETE FROM " + DBname + " WHERE ID = '{2}'", "Delete");
        }
        public void Edit(People people)
        {
            UpdateDBname(people);
            DBConnection.Execution(people, "UPDATE " + DBname + " SET FullName = '{0}', Address = '{1}', ID = '{2}', Birthday = '{3}', Workcode = '{4}', Gender = '{5}', Phone = '{6}', Email = '{7}' WHERE ID = '{2}'", "Edit");
        }
        ~PeopleDAO() { }
    }
}
