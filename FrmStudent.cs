using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentClass
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            LbxStudents.Items.Clear();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student(TxtFirstName.Text, TxtLastName.Text, int.Parse(TxtAge.Text));
            LbxStudents.Items.Add(student.ToString());
        }
    }
}
