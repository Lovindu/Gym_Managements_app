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

namespace Gym_Managements_app
{
    public partial class AddToMaintenance : Form
    {
        public AddToMaintenance()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\lovin\Documents\Gym_management_1 (1).mdf"";Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            int maintenanceId;
            int eqId;
            string description = txtDescription.Text;
            double amount;


            if (description != "" && txtmaintenanceID.Text != "" && txtEqId.Text != "" && txtPrice.Text != "")
            {
                try
                {
                    maintenanceId = int.Parse(txtmaintenanceID.Text);
                    eqId = int.Parse(txtEqId.Text);
                    amount = double.Parse(txtPrice.Text);

                    SqlConnection con = new SqlConnection(conString);

                    string sql = "insert into Maintenance (maintenanceID, EquipmentID, description, amount) values('"+maintenanceId+"', '"+eqId+"', '"+description+"', '"+amount+"')";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added equipment to maintenance!");
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Fill all details!");
            }


        }
    }
}
