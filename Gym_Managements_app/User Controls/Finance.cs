﻿using System;
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
    public partial class Finance : UserControl
    {
        public Finance()
        {
            InitializeComponent();

            ShowTransactionData();
        }

        private void ShowTransactionData()
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lovin\Documents\Gym_management_1 (1).mdf"";Integrated Security=True;Connect Timeout=30";

            string qry = "select * from Transactions";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Transactions");
            dataGridPayments.DataSource = ds.Tables["Transactions"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSalary editSalary = new EditSalary();
            editSalary.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditPackage editPackage = new EditPackage();
            editPackage.Show();
        }
    }
}
