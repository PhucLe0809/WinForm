namespace FStudent
{
    partial class DisplayMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMain));
            btnStudentLogin = new Button();
            lblHeading = new Label();
            btnLectureLogin = new Button();
            SuspendLayout();
            // 
            // btnStudentLogin
            // 
            btnStudentLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentLogin.ForeColor = Color.Lime;
            btnStudentLogin.Location = new Point(130, 156);
            btnStudentLogin.Name = "btnStudentLogin";
            btnStudentLogin.Size = new Size(194, 78);
            btnStudentLogin.TabIndex = 0;
            btnStudentLogin.Text = "Student";
            btnStudentLogin.UseVisualStyleBackColor = true;
            btnStudentLogin.Click += btnStudentLogin_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Tomato;
            lblHeading.Location = new Point(34, 30);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(290, 39);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "LE HONG PHUC";
            // 
            // btnLectureLogin
            // 
            btnLectureLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLectureLogin.ForeColor = Color.DodgerBlue;
            btnLectureLogin.Location = new Point(475, 156);
            btnLectureLogin.Name = "btnLectureLogin";
            btnLectureLogin.Size = new Size(194, 78);
            btnLectureLogin.TabIndex = 2;
            btnLectureLogin.Text = "Lecture";
            btnLectureLogin.UseVisualStyleBackColor = true;
            btnLectureLogin.Click += btnLectureLogin_Click;
            // 
            // DisplayMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLectureLogin);
            Controls.Add(lblHeading);
            Controls.Add(btnStudentLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisplayMain";
            Text = "DisplayMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentLogin;
        private Label lblHeading;
        private Button btnLectureLogin;
    }
}