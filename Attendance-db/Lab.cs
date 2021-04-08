using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Attendance_db
{
    public partial class Lab : Form
    {
        mainForm f;
        public Lab(mainForm parent)
        {
            InitializeComponent();
            f = parent;
        }

        private void labFrmBtn_Click(object sender, EventArgs e)
        {

            this.labTableAdapter.Insert(textBox1.Text);
            this.labTableAdapter.Fill(this.attendance_dbDataSet1.lab);



        }

        private void labBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.labBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attendance_dbDataSet1);

        }

        private void Lab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance_dbDataSet1.lab' table. You can move, or remove it, as needed.
            this.labTableAdapter.Fill(this.attendance_dbDataSet1.lab);

        }
    }
}
