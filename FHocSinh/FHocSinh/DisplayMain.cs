using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FStudent
{
    public partial class DisplayMain : Form
    {
        public DisplayMain()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            FLoginStudent fLoginStudent = new FLoginStudent();
            fLoginStudent.Show();
        }
        private void btnLectureLogin_Click(object sender, EventArgs e)
        {
            FLoginLecture fLoginLecture = new FLoginLecture();
            fLoginLecture.Show();
        }
    }
}
