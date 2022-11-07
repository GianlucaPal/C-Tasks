using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Task2.Models;
using System.Data;
using System.Drawing;
using System.Configuration;
using Microsoft.Ajax.Utilities;
using System.ComponentModel;
using System.Web.UI.HtmlControls;
using System.Reflection;
using System.Dynamic;

namespace Task2
{
    public partial class EditData : System.Web.UI.Page
    {

        public string errorMessage = "";
        public string Temp = "";
        public string Weight = "";
        public string Width = "";
        public string Hum = "";
        public string Depth = "";
        public string length = "";

        public Measurements measurements = new Measurements();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string ID = Request["val"].ToString();

                    string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "SELECT * FROM tblTask2Data WHERE id = @ID";

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("id", ID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    txtTemp.Text = reader["Temperature"].ToString();
                                    txthumidity.Text = reader["humidity"].ToString();
                                    txtWeight.Text = reader["Weight"].ToString();
                                    txtWidth.Text = reader["Width"].ToString();
                                    txtLength.Text = reader["Length"].ToString();
                                    txtDepth.Text = reader["Depth"].ToString();
                                    chkChecked.Checked = Convert.ToBoolean(reader["Checked"].ToString());

                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }

           

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
            measurements.Name = User.Identity.Name;


            try
            {
                string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE tblTask2Data SET Temperature = @temperature, humidity = @humidity, Weight = @weight, Width = @width, Length = @length, Depth = @depth, Time = @time, Checked = @checked WHERE id = @ID ;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        
                        command.Parameters.AddWithValue("@ID", Request["val"].ToString());
                        command.Parameters.AddWithValue("@temperature", measurements.Temperature);
                        command.Parameters.AddWithValue("@humidity", measurements.Humidity);
                        command.Parameters.AddWithValue("@weight", measurements.Weight);
                        command.Parameters.AddWithValue("@width", measurements.Width);
                        command.Parameters.AddWithValue("@length", measurements.length);
                        command.Parameters.AddWithValue("@depth", measurements.Depth);
                        command.Parameters.AddWithValue("@time", measurements.DateTime);
                        command.Parameters.AddWithValue("@checked", measurements.Checked);

                        command.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            Response.Redirect("/");

        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
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
      