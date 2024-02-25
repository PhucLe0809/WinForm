namespace FStudent
{
    partial class UCInformation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pelFullName = new Panel();
            txtFullName = new TextBox();
            lblFullName = new Label();
            pelAddress = new Panel();
            txtAddress = new TextBox();
            lblAddress = new Label();
            pelID = new Panel();
            txtID = new TextBox();
            lblID = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            gvInfo = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colBirthday = new DataGridViewTextBoxColumn();
            colWorkCode = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pelBirthday = new Panel();
            dtpBirthday = new DateTimePicker();
            lblBirthday = new Label();
            pelWoekCode = new Panel();
            txtWorkCode = new TextBox();
            lblWorkCode = new Label();
            cobGender = new ComboBox();
            pelPhone = new Panel();
            txtPhone = new TextBox();
            lalPhone = new Label();
            pelEmail = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            erpFullName = new ErrorProvider(components);
            pelGender = new Panel();
            lblGender = new Label();
            erpWorkCode = new ErrorProvider(components);
            erpGender = new ErrorProvider(components);
            erpAddress = new ErrorProvider(components);
            erpID = new ErrorProvider(components);
            erpBirthday = new ErrorProvider(components);
            erpPhone = new ErrorProvider(components);
            erpEmail = new ErrorProvider(components);
            pelFullName.SuspendLayout();
            pelAddress.SuspendLayout();
            pelID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvInfo).BeginInit();
            pelBirthday.SuspendLayout();
            pelWoekCode.SuspendLayout();
            pelPhone.SuspendLayout();
            pelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpFullName).BeginInit();
            pelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpWorkCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpBirthday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpEmail).BeginInit();
            SuspendLayout();
            // 
            // pelFullName
            // 
            pelFullName.Controls.Add(txtFullName);
            pelFullName.Controls.Add(lblFullName);
            pelFullName.Location = new Point(11, 9);
            pelFullName.Name = "pelFullName";
            pelFullName.Size = new Size(454, 42);
            pelFullName.TabIndex = 26;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(138, 9);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(263, 27);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += TxtFullName_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(9, 10);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(88, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ và Tên";
            // 
            // pelAddress
            // 
            pelAddress.Controls.Add(txtAddress);
            pelAddress.Controls.Add(lblAddress);
            pelAddress.Location = new Point(11, 161);
            pelAddress.Name = "pelAddress";
            pelAddress.Size = new Size(454, 46);
            pelAddress.TabIndex = 27;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 9);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(261, 27);
            txtAddress.TabIndex = 4;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(9, 10);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 23);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Địa chỉ";
            // 
            // pelID
            // 
            pelID.Controls.Add(txtID);
            pelID.Controls.Add(lblID);
            pelID.Location = new Point(11, 213);
            pelID.Name = "pelID";
            pelID.Size = new Size(454, 48);
            pelID.TabIndex = 28;
            // 
            // txtID
            // 
            txtID.Location = new Point(140, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(261, 27);
            txtID.TabIndex = 5;
            txtID.TextChanged += TxtID_TextChanged;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(9, 10);
            lblID.Name = "lblID";
            lblID.Size = new Size(63, 23);
            lblID.TabIndex = 0;
            lblID.Text = "CMND";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.SandyBrown;
            btnEdit.Location = new Point(295, 449);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.LightCoral;
            btnDelete.Location = new Point(154, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Lime;
            btnAdd.Location = new Point(11, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // gvInfo
            // 
            gvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInfo.Columns.AddRange(new DataGridViewColumn[] { colFullName, colAddress, colID, colBirthday, colWorkCode, colGender, colPhone, colEmail });
            gvInfo.Location = new Point(485, 9);
            gvInfo.Name = "gvInfo";
            gvInfo.RowHeadersWidth = 51;
            gvInfo.Size = new Size(1174, 272);
            gvInfo.TabIndex = 12;
            gvInfo.CellClick += gvInfo_CellClick;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ và Tên";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.Width = 150;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Địa chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 140;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "CMND";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 125;
            // 
            // colBirthday
            // 
            colBirthday.DataPropertyName = "Birthday";
            colBirthday.HeaderText = "Sinh nhật";
            colBirthday.MinimumWidth = 6;
            colBirthday.Name = "colBirthday";
            colBirthday.Width = 200;
            // 
            // colWorkCode
            // 
            colWorkCode.DataPropertyName = "Workcode";
            colWorkCode.HeaderText = "Work code";
            colWorkCode.MinimumWidth = 6;
            colWorkCode.Name = "colWorkCode";
            colWorkCode.Width = 125;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Phái";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.Width = 80;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 125;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 175;
            // 
            // pelBirthday
            // 
            pelBirthday.Controls.Add(dtpBirthday);
            pelBirthday.Controls.Add(lblBirthday);
            pelBirthday.Location = new Point(11, 267);
            pelBirthday.Name = "pelBirthday";
            pelBirthday.Size = new Size(454, 44);
            pelBirthday.TabIndex = 29;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(138, 7);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(263, 27);
            dtpBirthday.TabIndex = 6;
            dtpBirthday.ValueChanged += TxtBirthday_ValueChanged;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(9, 10);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(86, 23);
            lblBirthday.TabIndex = 0;
            lblBirthday.Text = "Sinh nhật";
            // 
            // pelWoekCode
            // 
            pelWoekCode.Controls.Add(txtWorkCode);
            pelWoekCode.Controls.Add(lblWorkCode);
            pelWoekCode.Location = new Point(11, 57);
            pelWoekCode.Name = "pelWoekCode";
            pelWoekCode.Size = new Size(454, 46);
            pelWoekCode.TabIndex = 34;
            // 
            // txtWorkCode
            // 
            txtWorkCode.Location = new Point(138, 9);
            txtWorkCode.Name = "txtWorkCode";
            txtWorkCode.Size = new Size(263, 27);
            txtWorkCode.TabIndex = 2;
            txtWorkCode.TextChanged += TxtWorkCode_TextChanged;
            // 
            // lblWorkCode
            // 
            lblWorkCode.AutoSize = true;
            lblWorkCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorkCode.Location = new Point(9, 10);
            lblWorkCode.Name = "lblWorkCode";
            lblWorkCode.Size = new Size(92, 23);
            lblWorkCode.TabIndex = 0;
            lblWorkCode.Text = "Workcode";
            // 
            // cobGender
            // 
            cobGender.FormattingEnabled = true;
            cobGender.Items.AddRange(new object[] { "Male", "Female" });
            cobGender.Location = new Point(138, 10);
            cobGender.Name = "cobGender";
            cobGender.Size = new Size(263, 28);
            cobGender.TabIndex = 3;
            cobGender.SelectedIndexChanged += TxtGender_SelectedIndexChanged;
            // 
            // pelPhone
            // 
            pelPhone.Controls.Add(txtPhone);
            pelPhone.Controls.Add(lalPhone);
            pelPhone.Location = new Point(11, 317);
            pelPhone.Name = "pelPhone";
            pelPhone.Size = new Size(454, 48);
            pelPhone.TabIndex = 35;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 9);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            // 
            // lalPhone
            // 
            lalPhone.AutoSize = true;
            lalPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lalPhone.Location = new Point(9, 10);
            lalPhone.Name = "lalPhone";
            lalPhone.Size = new Size(58, 23);
            lalPhone.TabIndex = 0;
            lalPhone.Text = "Số ĐT";
            // 
            // pelEmail
            // 
            pelEmail.Controls.Add(txtEmail);
            pelEmail.Controls.Add(lblEmail);
            pelEmail.Location = new Point(11, 371);
            pelEmail.Name = "pelEmail";
            pelEmail.Size = new Size(454, 48);
            pelEmail.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(9, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // erpFullName
            // 
            erpFullName.ContainerControl = this;
            // 
            // pelGender
            // 
            pelGender.Controls.Add(lblGender);
            pelGender.Controls.Add(cobGender);
            pelGender.Location = new Point(11, 109);
            pelGender.Name = "pelGender";
            pelGender.Size = new Size(454, 46);
            pelGender.TabIndex = 37;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(9, 10);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 23);
            lblGender.TabIndex = 0;
            lblGender.Text = "Giới tính";
            // 
            // erpWorkCode
            // 
            erpWorkCode.ContainerControl = this;
            // 
            // erpGender
            // 
            erpGender.ContainerControl = this;
            // 
            // erpAddress
            // 
            erpAddress.ContainerControl = this;
            // 
            // erpID
            // 
            erpID.ContainerControl = this;
            // 
            // erpBirthday
            // 
            erpBirthday.ContainerControl = this;
            // 
            // erpPhone
            // 
            erpPhone.ContainerControl = this;
            // 
            // erpEmail
            // 
            erpEmail.ContainerControl = this;
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pelGender);
            Controls.Add(pelEmail);
            Controls.Add(pelPhone);
            Controls.Add(pelWoekCode);
            Controls.Add(pelFullName);
            Controls.Add(pelAddress);
            Controls.Add(pelID);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(gvInfo);
            Controls.Add(pelBirthday);
            Name = "UCInformation";
            Size = new Size(1671, 500);
            pelFullName.ResumeLayout(false);
            pelFullName.PerformLayout();
            pelAddress.ResumeLayout(false);
            pelAddress.PerformLayout();
            pelID.ResumeLayout(false);
            pelID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvInfo).EndInit();
            pelBirthday.ResumeLayout(false);
            pelBirthday.PerformLayout();
            pelWoekCode.ResumeLayout(false);
            pelWoekCode.PerformLayout();
            pelPhone.ResumeLayout(false);
            pelPhone.PerformLayout();
            pelEmail.ResumeLayout(false);
            pelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpFullName).EndInit();
            pelGender.ResumeLayout(false);
            pelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpWorkCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpID).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpBirthday).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pelFullName;
        private TextBox txtFullName;
        private Label lblFullName;
        private Panel pelAddress;
        private TextBox txtAddress;
        private Label lblAddress;
        private Panel pelID;
        private TextBox txtID;
        private Label lblID;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView gvInfo;
        private Panel pelBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
        private Panel pelWoekCode;
        private ComboBox cobGender;
        private TextBox txtWorkCode;
        private Label lblWorkCode;
        private Panel pelPhone;
        private TextBox txtPhone;
        private Label lalPhone;
        private Panel pelEmail;
        private TextBox txtEmail;
        private Label lblEmail;
        private ErrorProvider erpFullName;
        private Panel pelGender;
        private Label lblGender;
        private ErrorProvider erpWorkCode;
        private ErrorProvider erpGender;
        private ErrorProvider erpAddress;
        private ErrorProvider erpID;
        private ErrorProvider erpBirthday;
        private ErrorProvider erpPhone;
        private ErrorProvider erpEmail;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colBirthday;
        private DataGridViewTextBoxColumn colWorkCode;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
    }
}
