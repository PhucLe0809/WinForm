using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FStudent
{
    public partial class FLoginStudent : Form
    {
        Student student = new Student();
        StudentDAO studentDAO = new StudentDAO();
        UCInformation ucInfo = new UCInformation();
        public FLoginStudent()
        {
            InitializeComponent();
            this.Controls.Add(ucInfo);
            ucInfo.Location = new Point(12, 55);
            ucInfo.BtnAdd.Click += BtnAdd_Click;
            ucInfo.BtnDelete.Click += BtnDelete_Click;
            ucInfo.BtnEdit.Click += BtnEdit_Click;
        }
        private void GetInfo()
        {
            if (ucInfo.Gender.SelectedIndex < 0) return;
            this.student = new Student(ucInfo.TxtFullName.Text, ucInfo.TxtAddress.Text, ucInfo.TxtID.Text, ucInfo.DtpBirthday.Value,
                ucInfo.Workcode.Text, ucInfo.Gender.SelectedItem.ToString(), ucInfo.Phone.Text, ucInfo.Email.Text);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            ucInfo.SetGvInfor = studentDAO.Load(student);
        }

        public void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckAllInformation) return;
            GetInfo();
            studentDAO.Add(student);
            FLogin_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckToDelete) return;
            GetInfo();
            studentDAO.Delete(student);
            FLogin_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckAllInformation) return;
            GetInfo();
            studentDAO.Edit(student);
            FLogin_Load(sender, e);
        }
    }
}
