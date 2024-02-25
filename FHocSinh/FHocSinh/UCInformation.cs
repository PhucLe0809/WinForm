using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FStudent
{
    public partial class UCInformation : UserControl
    {
        public UCInformation()
        {
            InitializeComponent();
        }

        public TextBox TxtFullName
        {
            get { return txtFullName; }
        }
        public TextBox TxtAddress
        {
            get { return txtAddress; }
        }
        public TextBox TxtID
        {
            get { return txtID; }
        }
        public DateTimePicker DtpBirthday
        {
            get { return dtpBirthday; }
        }
        public TextBox Workcode
        {
            get { return txtWorkCode; }
        }
        public ComboBox Gender
        {
            get { return cobGender; }
        }
        public TextBox Phone
        {
            get { return txtPhone; }
        }
        public TextBox Email
        {
            get { return txtEmail; }
        }
        public DataTable SetGvInfor
        {
            set { this.gvInfo.DataSource = value; }
        }
        public Button BtnAdd
        {
            get { return btnAdd; }
        }
        public Button BtnDelete
        {
            get { return btnDelete; }
        }
        public Button BtnEdit
        {
            get { return btnEdit; }
        }
        public bool GetCheckAllInformation
        {
            get { return CheckAllInfo(); }
        }
        public bool GetCheckToDelete
        {
            get { return CheckToDelete(); }
        }

        private bool CheckFullName()
        {
            return !string.IsNullOrEmpty(txtFullName.Text);
        }
        private bool CheckAddress()
        {
            return !string.IsNullOrEmpty(txtAddress.Text);
        }
        private bool CheckID()
        {
            return !string.IsNullOrEmpty(txtID.Text);
        }
        private bool CheckBirthday()
        {
            if (dtpBirthday.Value == DateTime.Today)
            {
                return false;
            }
            TimeSpan distance = DateTime.Now - dtpBirthday.Value;
            return (int)(distance.Days / 365.25) >= 17;
        }
        private bool CheckWorkCode()
        {
            return !string.IsNullOrEmpty(txtWorkCode.Text);
        }
        private bool CheckGender()
        {
            return cobGender.SelectedIndex >= 0;
        }
        private bool CheckPhone()
        {
            string pattern = @"^\d{3}-\d{4}-\d{3}$";
            return Regex.IsMatch(txtPhone.Text, pattern);
        }
        private bool CheckEmail()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(txtEmail.Text, pattern);
        }
        private bool CheckAllInfo()
        {
            RunCheckAddInfo();
            bool flag = CheckFullName() && CheckAddress() && CheckID() && CheckBirthday() && CheckWorkCode() && CheckGender() && CheckPhone() && CheckEmail();
            return flag;
        }
        private bool CheckToDelete()
        {
            RunCheckID();
            return CheckID();
        }

        private void RunCheckFullName()
        {
            if (!CheckFullName())
            {
                txtFullName.Focus();
                erpFullName.SetError(txtFullName, "Please enter your full name!");
            }
            else
            {
                erpFullName.SetError(txtFullName, null);
            }
        }
        private void RunCheckWorkCode()
        {
            if (!CheckWorkCode())
            {
                txtWorkCode.Focus();
                erpWorkCode.SetError(txtWorkCode, "Please enter your work code!");
            }
            else
            {
                erpWorkCode.SetError(txtWorkCode, null);
            }
        }
        private void RunCheckGender()
        {
            if (!CheckGender())
            {
                cobGender.Focus();
                erpGender.SetError(cobGender, "Please choose your gender!");
            }
            else
            {
                erpGender.SetError(cobGender, null);
            }
        }
        private void RunCheckAddress()
        {
            if (!CheckAddress())
            {
                txtAddress.Focus();
                erpAddress.SetError(txtAddress, "Please enter your address!");
            }
            else
            {
                erpAddress.SetError(txtAddress, null);
            }
        }
        private void RunCheckID()
        {
            if (!CheckID())
            {
                txtID.Focus();
                erpID.SetError(txtID, "Please enter your ID!");
            }
            else
            {
                erpID.SetError(txtID, null);
            }
        }
        private void RunCheckBirthday()
        {
            if (!CheckBirthday())
            {
                dtpBirthday.Focus();
                erpBirthday.SetError(dtpBirthday, "You are not yet 17 years old!");
            }
            else
            {
                erpBirthday.SetError(dtpBirthday, null);
            }
        }
        private void RunCheckPhone()
        {
            if (!CheckPhone())
            {
                txtPhone.Focus();
                erpPhone.SetError(txtPhone, "Your phone number must be in the form xxx-xxxx-xxx");
            }
            else
            {
                erpPhone.SetError(txtPhone, null);
            }
        }
        private void RunCheckEmail()
        {
            if (!CheckEmail())
            {
                txtEmail.Focus();
                erpEmail.SetError(txtEmail, "Your email must be in the form <name>@<domain>.<domain extension>");
            }
            else
            {
                erpEmail.SetError(txtEmail, null);
            }
        }
        private void RunCheckAddInfo()
        {
            RunCheckFullName();
            RunCheckWorkCode();
            RunCheckGender();
            RunCheckAddress();
            RunCheckID();
            RunCheckBirthday();
            RunCheckPhone();
            RunCheckEmail();
        }

        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            RunCheckFullName();
        }
        private void TxtWorkCode_TextChanged(object sender, EventArgs e)
        {
            RunCheckWorkCode();
        }
        private void TxtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunCheckGender();
        }
        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            RunCheckAddress();
        }
        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            RunCheckID();
        }
        private void TxtBirthday_ValueChanged(object sender, EventArgs e)
        {
            RunCheckBirthday();
        }
        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            RunCheckPhone();
        }
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            RunCheckEmail();
        }
        private void gvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewCell cell = gvInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString())) return;

            DataGridView dta = (DataGridView)sender;
            DataGridViewRow selectedRow = dta.Rows[e.RowIndex];
            txtFullName.Text = selectedRow.Cells["colFullName"].Value.ToString();
            txtWorkCode.Text = selectedRow.Cells["colWorkCode"].Value.ToString();
            cobGender.SelectedItem = selectedRow.Cells["colGender"].Value.ToString();
            txtAddress.Text = selectedRow.Cells["colAddress"].Value.ToString();
            txtID.Text = selectedRow.Cells["colID"].Value.ToString();

            string birth = selectedRow.Cells["colBirthday"].Value.ToString();
            if (!string.IsNullOrEmpty(birth))
            {
                dtpBirthday.Value = DateTime.Parse(birth);
            }
            else
            {
                dtpBirthday.Value = DateTime.Today;
            }

            txtPhone.Text = selectedRow.Cells["colPhone"].Value.ToString();
            txtEmail.Text = selectedRow.Cells["colEmail"].Value.ToString();
        }
    }
}
