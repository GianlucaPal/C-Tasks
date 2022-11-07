using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task2.Models;


namespace Task2
{
    public partial class NewData : System.Web.UI.Page
    {
        public string errorMessage = "";
        public string Temp = "";
        public string Weight = "";
        public string Width = "";
        public string Hum = "";
        public string Depth = "";
        public string length = "";
        public Boolean bErrorTemp;


        public Measurements measurements = new Measurements();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void OnPost()
        {

            Temp = txtTemp.Text;
            Hum = txthumidity.Text;
            Weight = txtWeight.Text;
            Width = txthumidity.Text;
            length = txtLength.Text;
            Depth = txtDepth.Text;
            var Checked = chkChecked.Checked;

            measurements.Temperature = Convert.ToDouble(Temp);
            measurements.Humidity = Convert.ToDouble(Hum);
            measurements.Weight = Convert.ToDouble(Weight);
            measurements.Width = Convert.ToDouble(Width);
            measurements.length = Convert.ToDouble(length);
            measurements.Depth = Convert.ToDouble(Depth);
            measurements.Checked = Checked;
            measurements.DateTime = DateTime.Now;
            // measurements.Name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            measurements.Name = User.Identity.Name;


            try
            {
                string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Insert into tblTask2Data (Temperature, humidity, Weight, Width, Length, Depth, Time, Checked, Name ) VALUES " +
                                  "(@temperature, @humidity , @weight, @width, @length, @depth, @time, @checked, @name);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@temperature", measurements.Temperature);
                        command.Parameters.AddWithValue("@humidity", measurements.Humidity);
                        command.Parameters.AddWithValue("@weight", measurements.Weight);
                        command.Parameters.AddWithValue("@width", measurements.Width);
                        command.Parameters.AddWithValue("@length", measurements.length);
                        command.Parameters.AddWithValue("@depth", measurements.Depth);
                        command.Parameters.AddWithValue("@time", measurements.DateTime);
                        command.Parameters.AddWithValue("@checked", measurements.Checked);
                        command.Parameters.AddWithValue("@name", measurements.Name);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            Response.Redirect("/");

        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var bErrorTemp = true;
            var bErrorHum = true;
            var bErrorWeight = true;
            var bErrorWidth = true;
            var bErrorLength = true;
            var bErrorDepth = true;



            lblErrorDepth.Text = "";
            lblErrorHum.Text = "";
            lblErrorTemp.Text = "";
            lblErrorTemp.Text = "";
            lblErrorWeight.Text = "";
            lblErrorWidth.Text = "";


            if (txtTemp.Text.Trim().Length == 0)
            {
                lblErrorTemp.Text = "All the fields are required";
                bErrorTemp = false;
            }
            else
            {
                bErrorTemp = true;
            }

            if (txthumidity.Text.Length == 0)
            {
                lblErrorHum.Text = "All the fields are required";
                bErrorHum = false;
            }
            else
            {
                bErrorHum = true;
            }

            if (txtWeight.Text.Length == 0)
            {
                lblErrorWeight.Text = "All the fields are required";
                bErrorWeight = false;
            }
            else
            {
                bErrorWeight = true;
            }

            if (txtWidth.Text.Length == 0)
            {
                lblErrorWidth.Text = "All the fields are required";
                bErrorWidth = false;
            }
            else
            {
                bErrorWidth = true;
            }

            if (txtLength.Text.Length == 0)
            {
                lblErrorLength.Text = "All the fields are required";
                bErrorLength = false;
            }
            else
            {
                bErrorLength = true;
            }

            if (txtDepth.Text.Length == 0)
            {
                lblErrorDepth.Text = "All the fields are required";
                bErrorDepth = false;
            }
            else
            {
                bErrorDepth = true;
            }


            if (bErrorTemp == true && bErrorHum == true && bErrorWeight == true && bErrorWidth == true && bErrorLength == true && bErrorDepth == true)
            {
                OnPost();
            }
        }

    }
}