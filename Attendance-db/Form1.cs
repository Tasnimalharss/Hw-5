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
    public partial class mainForm : Form
    {

       static string connectoionSQL = "server=localhost;database=attendance_db;uid=root;password=;";
        MySqlConnection conn = new MySqlConnection(connectoionSQL);

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance_dbDataSet1.attendances' table. You can move, or remove it, as needed.
            this.attendancesTableAdapter1.Fill(this.attendance_dbDataSet1.attendances);


        }


        private void addLabBtn_Click(object sender, EventArgs e)
        {
            Form labForm = new Lab(this);
            labForm.Show(this);
        }

        public void getLabs()
        {           
          
        }

           


            private void addCourseBtn_Click(object sender, EventArgs e)
        {
            Form courseForm = new Course(this);
            courseForm.Show(this);

        }

 

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            Form teacherForm = new Teacher(this);
            teacherForm.Show(this);
        }

  

        private void saveBtn_Click(object sender, EventArgs e)
        {
         
          


           
            this.attendancesTableAdapter.Insert(date.Value, startTime.Value, endTime.Value, int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), int.Parse(comboBox3.SelectedValue.ToString()));
            this.attendancesTableAdapter1.Fill(this.attendance_dbDataSet1.attendances);

        }

   

        private void attendancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendance_dbDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
