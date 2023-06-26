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
    public partial class MemberDetails : UserControl
    {
        public MemberDetails()
        {
            InitializeComponent();
            LoadMemberGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadMemberGrid()
        {

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Tharindu\Downloads\Gym_management (1).mdf"";Integrated Security=True;Connect Timeout=30";
            string qry = "select * from Member";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Member");
            dataGridView1.DataSource = ds.Tables["Member"];

           
        }
    }
}
