using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Attendance_db
{
    public partial class Course : Form
    {
        mainForm f;
        public Course(mainForm parent)
        {
            InitializeComponent();
            f = parent;

        }

        private void courseFrmBtn_Click(object sender, EventArgs e)
        {

            this.coursesTableAdapter.Insert(textBox1.Text);
            this.coursesTableAdapter.Fill(this.attendance_dbDataSet1.courses);

        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendance_dbDataSet1);

        }

        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance_dbDataSet1.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.attendance_dbDataSet1.courses);

        }
    }
}
