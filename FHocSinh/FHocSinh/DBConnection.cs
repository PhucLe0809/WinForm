using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStudent
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStudent);
        public DBConnection() { }
        public DataTable Load(string command)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format(command);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable listObject = new DataTable();
                adapter.Fill(listObject);
                return listObject;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return new DataTable();
        }

        public void Execution(People people, string command, string typeExecution)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format(command, people.Name, people.Address, people.Id, people.Birthday, people.Workcode, people.Gender, people.Phone, people.Email);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(typeExecution + " successfully", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(typeExecution + " failed" + ex, "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
