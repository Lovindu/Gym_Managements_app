using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Managements_app.User_Controls
{
    public partial class Staff : UserControl
    {
        public Staff()
        {
            InitializeComponent();
            LoadStaffGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStaffGrid()
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Tharindu\Downloads\Gym_management (1).mdf"";Integrated Security=True;Connect Timeout=30";
            string qry = "select * from Staff";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Staff");
            dataGridView1.DataSource = ds.Tables["Staff"];

            
        }
    }
}
