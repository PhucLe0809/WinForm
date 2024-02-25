namespace FStudent
{
    partial class FLoginLecture
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLoginLecture));
            labelHeading = new Label();
            SuspendLayout();
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = Color.Tomato;
            labelHeading.Location = new Point(30, 20);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(259, 32);
            labelHeading.TabIndex = 2;
            labelHeading.Text = "LECTURE LOGIN";
            // 
            // FLoginLecture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 603);
            Controls.Add(labelHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FLoginLecture";
            Text = "Lecture";
            Load += FLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelHeading;
    }
}
