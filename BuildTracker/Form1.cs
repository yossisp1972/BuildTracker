using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace BuildTracker
{
    public partial class Form1 : Form
    {
        bool txtBuildNUmber = true;
        bool txtDetails = true;
        bool txt
        public Form1()
        {
            InitializeComponent();
        }

        //public object ConfigurationManager { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            addBuild.Visible = false;
            //if (buildStatus.Text == "Passed With Errors")
            //{
            //    groupBox2.Visible = true;
            //}

            //connection string from app.config file
            string conStr = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            //create data table for kitID combobox
            SqlDataAdapter da_kitID = new SqlDataAdapter("SELECT kit_type FROM kit_types", conStr);
            DataTable dt_kitID = new DataTable();
            da_kitID.Fill(dt_kitID);
            kitID.DataSource = dt_kitID;
            kitID.ValueMember = "kit_type";
            kitID.SelectedItem = null;
            kitID.SelectedText = "Select kit type";

            //create data table for buildNumber combobox
            //SqlDataAdapter da_buildNumber = new SqlDataAdapter("SELECT build_number FROM builds", conStr);
            //DataTable dt_buildNumber = new DataTable();
            //da_buildNumber.Fill(dt_buildNumber);
            //buildNumber.DataSource = dt_buildNumber;
            //buildNumber.ValueMember = "build_number";
            //buildNumber.SelectedItem = null;
            //buildNumber.SelectedText = "Select Build Number";

            //create data table for buildStatus combobox
            SqlDataAdapter da_buildStatus = new SqlDataAdapter("SELECT status FROM Build_statuses", conStr);
            DataTable dt_buildStatus = new DataTable();
            da_buildStatus.Fill(dt_buildStatus);
            buildStatus.DataSource = dt_buildStatus;
            buildStatus.ValueMember = "status";
            buildStatus.SelectedItem = null;
            buildStatus.SelectedText = "Select status";

            SqlDataAdapter da_Category = new SqlDataAdapter("SELECT category FROM [Build_categories]", conStr);
            DataTable dt_Category = new DataTable();
            da_Category.Fill(dt_Category);
            cbCategory.DataSource = dt_Category;
            cbCategory.ValueMember = "category";
            cbCategory.SelectedItem = null;
            cbCategory.SelectedText = "Select category";
        }

        private void addBuild_Click(object sender, EventArgs e)
        {
            //validat selection in comboboxes
            if (kitID.SelectedIndex == -1 || buildStatus.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a kit type and status", "Error");
            }
            else
            {
                //string invalidCharsRegex = @"^\d+(\.\d+)*$";

                //if (!Regex.IsMatch(buildNumber.Text, invalidCharsRegex) && buildNumber.Text != "")
                //{
                //    MessageBox.Show("Please enter a valid build number (X.X.X.X) or select 'No build'");
                //}
                //using (SqlConnection con = new SqlConnection(dc.Con))
                SqlConnection conStr = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                using (SqlCommand cmd1 = new SqlCommand("SELECT kit_id from Kit_types where kit_type = '" + kitID.Text + "'", conStr))
                using (SqlCommand cmd2 = new SqlCommand("SELECT status_id from Build_statuses where status = '" + buildStatus.Text + "'", conStr))
                {
                    conStr.Open();
                    var kit_id = cmd1.ExecuteScalar();
                    var status_id = cmd2.ExecuteScalar();
                    conStr.Close();
                    //verify build number is a number
                    //Regex invalidCharsRegex = new Regex(@"^[0-9.]+$");
                    //String invalidCharsRegex = @" ^[0 - 9.] + $";
                    //String invalidCharsRegex = @"(?<=^| )\d+(\.\d+)?(?=$| )|(?<=^| )\.\d+(?=$| )";
                    //string invalidCharsRegex = @"^\d+(\.\d+)*$";

                    //string BuildNumber = "";
                    //if (Regex.IsMatch(buildNumber.Text, invalidCharsRegex))
                    //{
                    //     BuildNumber = buildNumber.Text;
                    //}
                    //else
                    //{
                    //    BuildNUmber = "No Build";
                    //}

                    using (SqlCommand cmd3 = new SqlCommand("add_build", conStr))
                    {
                        cmd3.CommandType = CommandType.StoredProcedure;

                        cmd3.Parameters.Add("@kit_id", SqlDbType.Int).Value = kit_id;
                        cmd3.Parameters.Add("@status_id", SqlDbType.Int).Value = status_id;
                        //int parsedValue;
                        //if (Int32.TryParse(buildNumber.Text, out parsedValue))
                        //{
                        //cmd3.Parameters.Add("@build_number", SqlDbType.VarChar).Value = buildNumber.Text;
                        //    cmd3.Parameters.AddWithValue("@build_number", buildNumber.Text);
                        //} else
                        //{
                        //    //cmd3.Parameters.Add("@build_number", SqlDbType.VarChar).Value = "No Build";
                        //    cmd3.Parameters.AddWithValue("@build_number", "No Build");
                        //}
                        cmd3.Parameters.Add("@build_number", SqlDbType.VarChar).Value = buildNumber.Text;
                        cmd3.Parameters.Add("@release_date", SqlDbType.VarChar).Value = dateTimePicker1.Value;

                        conStr.Open();
                        cmd3.ExecuteNonQuery();

                    }


                }
                if (buildNumber.Text == string.Empty || buildNumber.Text == "Build number")
                {
                    MessageBox.Show("Enter a build number or select 'no build'");
                }
                else
                {
                    //label1.Visible = true;
                    var result = MessageBox.Show("Build added, add another one?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        Application.Exit();
                    }
                    else
                    {
                        kitID.Text = "Kit status";
                        buildNumber.Text = "Build number";
                        buildStatus.Text = "Build status";
                        noBuild.Checked = false;
                    }
                }

            }

        }

        private void noBuild_CheckedChanged(object sender, EventArgs e)
        {
            if (noBuild.Checked)
            {
                buildNumber.Enabled = false;
                buildNumber.Text = "No Build";
            }
            else
            {
                buildNumber.Enabled = true;
                buildNumber.Text = "Enter build number";
            }
        }

        private void buildNumber_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(buildNumber.Text, (@"^[0-9.-]+$")) && buildNumber.Text != "" && buildNumber.Text != "No Build" && buildNumber.Text != "Enter build number")
            //if (!Regex.IsMatch(buildNumber.Text, "(\\d+\\.?)*\\d+"))

            {
                MessageBox.Show("Please enter only numbers' or select the 'no build' checkbox");
                //buildNumber.Text = buildNumber.Text.Remove(buildNumber.Text.Length - 1);
                //buildNumber.Text = string.Empty;
                //buildNumber.Text = "";
            }
        }

        private void buildNumber_Click(object sender, EventArgs e)
        {
            if (firstclick)
            {
                buildNumber.Text = string.Empty;
                firstclick = false;
            }
        }

        private void buildStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buildStatus.Text == "Passed with Errors" || buildStatus.Text == "Failed")
            {
                addBuild.Visible = false;
                groupBox2.Show();
            }
            else
             if (buildStatus.SelectedItem == null)
            {
                addBuild.Visible = false;
            }
            else
            {
                groupBox2.Visible = false;
                addBuild.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            //row.Cells[0].Value = "XYZ";
            //row.Cells[1].Value = 50.2;
            //dataGridView1.Rows.Add(row);
            if (cbCategory.SelectedIndex == -1 || cbFailure.SelectedIndex == -1 || txtBug.Text == string.Empty)
            {
                MessageBox.Show("please enter bug details, select category and if this issue caused a failure");
            }
            else
            {
                this.dataGridView1.Rows.Add(txtBug.Text, cbCategory.Text, cbFailure.Text, txtDetails.Text);
            }
            

        }

        private void txtBug_Click(object sender, EventArgs e)
        {
            if (firstclick)
            {
                txtBug.Text = string.Empty;
                firstclick = false;
            }
            
        }

        private void txtDetails_Click(object sender, EventArgs e)
        {
            if (firstclick)
            {
                txtDetails.Text = string.Empty;
                firstclick = false;
            }
        }
    }
}

    


