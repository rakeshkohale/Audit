﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


namespace Audit
{

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            pnlDonationEntry.Visible = true;
            generateReceiptNo();
            bindPoojaTypeforOffering();
            //bindPoojaNameforOffering();

        }

        private void bindPoojaTypeforOffering()
        {
            try
            {
                DataSet dsDataFromDB = GetDataFromDatabaseinDataSetforPoojaType();
                cboPoojaType.DataSource = dsDataFromDB.Tables[0];
                cboPoojaType.DisplayMember = "PoojaType";
                cboPoojaType.ValueMember = "PoojaTypeID";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private DataSet GetDataFromDatabaseinDataSetforPoojaType()
        {
            DataSet ds = new DataSet();
            try
            {
                // database Connection String
                string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
                using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(constr))
                {
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_GetPoojaType", sqlCon))
                    {
                        SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        SqlDa.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void generateReceiptNo()
        {

            // define connection and command, in using blocks to ensure disposal
            string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("GenerateReceiptNumber", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // set up the parameters
                cmd.Parameters.Add("@ReceiptNo", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                // open connection and execute stored procedure
                conn.Open();
                cmd.ExecuteNonQuery();

                // read output value from @ReceiptNo
                //string ReceiptNo
                txtReceiptNo.Text = Convert.ToString(cmd.Parameters["@ReceiptNo"].Value);
                //txtReceiptNo.Text = ReceiptNo;
                conn.Close();
            }

        }



        private void btnViewAllDonations_Click(object sender, EventArgs e)
        {
            pnlViewAllDonations.Enabled = true;
            dgvAllDonations.Visible = true;
            BindGridOfferings();
        }

        private void btnUpdatePoojaDetails_Click(object sender, EventArgs e)
        {
            pnlUpdatePoojaDetails.Visible = true;
            bindPoojaNametoCombobox();
        }

        private void bindPoojaNametoCombobox()
        {
            try
            {
                DataSet dsDataFromDB = GetDataFromDatabaseinDataSet();
                comboBox1.DataSource = dsDataFromDB.Tables[0];
                comboBox1.DisplayMember = "PoojaName";
                comboBox1.ValueMember = "PoojaID";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void bindPoojaNameforOffering()
        {
            try
            {
                DataSet dsDataFromDB = GetDataFromDatabaseinDataSet();
                cboPoojaName.DataSource = dsDataFromDB.Tables[0];
                cboPoojaName.DisplayMember = "PoojaName";
                cboPoojaName.ValueMember = "PoojaID";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public DataSet GetDataFromDatabaseinDataSet()
        {
            DataSet ds = new DataSet();
            try
            {
                // database Connection String
                string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
                using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(constr))
                {
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter("sp_GetAllPoojaNames", sqlCon))
                    {
                        SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        SqlDa.Fill(ds);
                    }
                }

                //using (SqlConnection conn = new SqlConnection(constr))
                //using (SqlCommand cmd = new SqlCommand("sp_GetAllPoojaNames", conn))
                //{
                //    cmd.CommandType = CommandType.StoredProcedure;

                //    // set up the parameters
                //    //cmd.Parameters.Add("@poojatypeid", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                //    // Add the input parameters and set the properties.
                //    SqlParameter parameter1 = new SqlParameter();
                //    parameter1.ParameterName = "@poojatypeid";
                //    parameter1.SqlDbType = SqlDbType.NVarChar;
                //    parameter1.Direction = ParameterDirection.Input;
                //    parameter1.Value = (cboPoojaType.SelectedIndex) + 1;
                    
                //    // Add the parameter to the Parameters collection. 
                //    cmd.Parameters.Add(parameter1);
                    
                //    // open connection and execute stored procedure
                //    conn.Open();
                //    cmd.ExecuteNonQuery();

                //    // read output value from @ReceiptNo
                //    //string ReceiptNo
                //    //txtReceiptNo.Text = Convert.ToString(cmd.Parameters["@ReceiptNo"].Value);
                //    //txtReceiptNo.Text = ReceiptNo;
                //    conn.Close();
                //}

                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnViewAllPoojas_Click(object sender, EventArgs e)
        {
            pnlViewPoojaDetails.Visible = true;
            BindGrid();
        }

        private void btnSaveDonation_Click(object sender, EventArgs e)
        {
            pnlDonationEntry.Visible = false;
        }

        private void BindGrid()
        {
            string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM MsPoojaDetails", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Set AutoGenerateColumns False
                            dgvAllPoojaDetails.AutoGenerateColumns = false;

                            //Set Columns Count
                            dgvAllPoojaDetails.ColumnCount = 2;

                            //Add Columns
                            dgvAllPoojaDetails.Columns[0].Name = "PoojaName";
                            dgvAllPoojaDetails.Columns[0].HeaderText = "Pooja Name";
                            dgvAllPoojaDetails.Columns[0].DataPropertyName = "PoojaName";

                            dgvAllPoojaDetails.Columns[1].HeaderText = "Offering Amount";
                            dgvAllPoojaDetails.Columns[1].Name = "Rate";
                            dgvAllPoojaDetails.Columns[1].DataPropertyName = "Rate";

                            dgvAllPoojaDetails.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void BindGridOfferings()
        {
            string constr = "Data Source=RAKESH\\SQLEXPRESSRAKESH;Initial Catalog=BHADRAKALI;Persist Security Info=True;User ID=sa;Password=India@123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM msofferings", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Set AutoGenerateColumns False
                            dgvAllDonations.AutoGenerateColumns = false;

                            //Set Columns Count
                            dgvAllDonations.ColumnCount = 5;

                            //Add Columns
                            dgvAllDonations.Columns[0].Name = "ReceiptNo";
                            dgvAllDonations.Columns[0].HeaderText = "Receipt No";
                            dgvAllDonations.Columns[0].DataPropertyName = "ReceiptNo";

                            dgvAllDonations.Columns[1].Name = "Donorname";
                            dgvAllDonations.Columns[1].HeaderText = "Donor Name";
                            dgvAllDonations.Columns[1].DataPropertyName = "Donorname";

                            dgvAllDonations.Columns[2].Name = "PoojaName";
                            dgvAllDonations.Columns[2].HeaderText = "Pooja Name";
                            dgvAllDonations.Columns[2].DataPropertyName = "PoojaName";

                            dgvAllDonations.Columns[3].Name = "ReceiptDate";
                            dgvAllDonations.Columns[3].HeaderText = "Date";
                            dgvAllDonations.Columns[3].DataPropertyName = "ReceiptDate";

                            dgvAllDonations.Columns[4].Name = "Payment";
                            dgvAllDonations.Columns[4].HeaderText = "Amount Paid";
                            dgvAllDonations.Columns[4].DataPropertyName = "Payment";

                            dgvAllDonations.DataSource = dt;
                        }
                    }
                }
            }
        }


        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoButtonCheque_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawnBank.Enabled = true;
            txtBranch.Enabled = true;
            txtChequeNo.Enabled = true;
            txtChequeDate.Enabled = true;
        }

        private void rdoButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            txtChequeDate.Enabled = false;
            txtChequeNo.Enabled = false;
            txtDrawnBank.Enabled = false;
            txtBranch.Enabled = false;
        }

        private void cboPoojaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPoojaNameforOffering();
        }

        private void cboPoojaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtAmount.Text= cboPoojaName
        }
    }
}
