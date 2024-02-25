using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FStudent
{
    public partial class FLoginLecture : Form
    {
        Lecture lecture = new Lecture();
        LectureDAO lectureDAO = new LectureDAO();
        UCInformation ucInfo = new UCInformation();
        public FLoginLecture()
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
            this.lecture = new Lecture(ucInfo.TxtFullName.Text, ucInfo.TxtAddress.Text, ucInfo.TxtID.Text, ucInfo.DtpBirthday.Value,
                ucInfo.Workcode.Text, ucInfo.Gender.SelectedItem.ToString(), ucInfo.Phone.Text, ucInfo.Email.Text);
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            ucInfo.SetGvInfor = lectureDAO.Load(lecture);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckAllInformation) return;
            GetInfo();
            lectureDAO.Add(lecture);
            FLogin_Load(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckToDelete) return;
            GetInfo();
            lectureDAO.Delete(lecture);
            FLogin_Load(sender, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!ucInfo.GetCheckAllInformation) return;
            GetInfo();
            lectureDAO.Edit(lecture);
            FLogin_Load(sender, e);
        }
    }
}
