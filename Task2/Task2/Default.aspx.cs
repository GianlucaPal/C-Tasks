using System;
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


namespace Task2
{
    public partial class _Default : Page
    {



        public Measurements measurements = new Measurements();


        protected void Page_Load(object sender, EventArgs e)
        {
            lblAvgTemp.Text = Calculations.averageTemp().ToString();
            lblAvgHum.Text = Calculations.averageHum().ToString();
            lblAvgWeight.Text = Calculations.averageWeight().ToString();
            lblAvgWidth.Text = Calculations.averageWidth().ToString();
            lblAvgDepth.Text = Calculations.averageDepth().ToString();
            lblAvgLength.Text = Calculations.averageLength().ToString();

            lblMaxTemp.Text = Calculations.MaxTemp().ToString();
            lblMaxHum.Text = Calculations.MaxHum().ToString();
            lblMaxWeight.Text = Calculations.MaxWeight().ToString();
            lblMaxWidth.Text = Calculations.MaxWidth().ToString();
            lblMaxDepth.Text = Calculations.MaxDepth().ToString();
            lblMaxLength.Text = Calculations.MaxLength().ToString();

            lblMinTemp.Text = Calculations.MinTemp().ToString();
            lblMinHum.Text = Calculations.MinHum().ToString();
            lblMinWeight.Text = Calculations.MinWeight().ToString();
            lblMinWidth.Text = Calculations.MinWidth().ToString();
            lblMinDepth.Text = Calculations.MinDepth().ToString();
            lblMinLength.Text = Calculations.MinLength().ToString();

            lblSumTemp.Text = Calculations.SumTemp().ToString();
            lblSumHum.Text = Calculations.SumHum().ToString();
            lblSumWeight.Text = Calculations.SumWeight().ToString();
            lblSumWidth.Text = Calculations.SumWidth().ToString();
            lblSumDepth.Text = Calculations.SumDepth().ToString();
            lblSumLength.Text = Calculations.SumLength().ToString();

            lblVarTemp.Text = Calculations.varianceTemp().ToString();
            lblVarHum.Text = Calculations.varianceHum().ToString();
            lblVarWeight.Text = Calculations.varianceWeight().ToString();
            lblVarWidth.Text = Calculations.varianceWidth().ToString();
            lblVarDepth.Text = Calculations.varianceDepth().ToString();
            lblVarLength.Text = Calculations.varianceLength().ToString();

            lblSDTemp.Text = Calculations.standardDeviationTemp().ToString();
            lblSDHum.Text = Calculations.standardDeviationHum().ToString();
            lblSDWeight.Text = Calculations.standardDeviationWeight().ToString();
            lblSDWidth.Text = Calculations.standardDeviationWidth().ToString();
            lblSDDepth.Text = Calculations.standardDeviationDepth().ToString();
            lblSDLength.Text = Calculations.standardDeviationLength().ToString();



            if (!this.IsPostBack)
            {
               OnGet();
            }
        }
        public List<Models.Measurements> listMeasurements = new List<Models.Measurements>();

        public void OnGet()
        {
        //    List<Measurements> measurements = new List<Measurements>();
        //    string cnnStr = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
        //    using (SqlConnection cnn = new SqlConnection(cnnStr))
        //    {
        //        cnn.Open();

        //        string sql = "SELECT Distinct  CAST (Name AS VARCHAR(MAX)) FROM tblTask2Data";

        //        using (SqlCommand cmd = new SqlCommand(sql, cnn))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var measurement = new Measurements();
        //                    measurement.Name = reader["name"].ToString();
        //                    measurements.Add(measurement); 
                            
        //                    listFilter.DataSourceID = measurement.Name;
        //                    break;
        //                }
        //            }
        //        }
        //    }
           



             try
            {
                string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Select * FROM tblTask2Data";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            command.Connection = connection;
                            sda.SelectCommand = command;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                GridView2.DataSource = dt;
                                GridView2.DataBind();
                               
                            }
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine("Exeption " + ex.ToString());

            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            Button B = (Button)sender;
            GridViewRow row = (GridViewRow)B.NamingContainer;
            if (row != null)
            {
                int rowIndex = row.RowIndex;
                measurements.id = Convert.ToDouble(GridView2.Rows[rowIndex].Cells[9].Text);
            }
            var ID = measurements.id;

            try
            {
                string connectionString = "Data Source=.;Initial Catalog=task2;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "Delete FROM tblTask2Data WHERE id = @ID ;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", measurements.id);
                        command.ExecuteNonQuery();
                    } 
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            OnGet();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            GridViewRow row = (GridViewRow)B.NamingContainer;
            if (row != null)
            {
                int rowIndex = row.RowIndex;
                measurements.id = Convert.ToDouble(GridView2.Rows[rowIndex].Cells[9].Text);
            }

            //Session.Add("val", measurements.id);
            Response.Redirect("/EditData.aspx?val=" + measurements.id);
           // Response.Redirect("/EditData.aspx");


        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var UserName = DataBinder.Eval(e.Row.DataItem, "Name").ToString();

                var loggedIn = User.Identity.Name;

                var btnEdit = e.Row.FindControl("btnEdit") as Button;
                var btnDelete = e.Row.FindControl("btnDelete") as Button;


                if (loggedIn == UserName)
                {
                    btnEdit.Visible = true;
                    btnDelete.Visible = true;
                }


            }
        }
    }

}