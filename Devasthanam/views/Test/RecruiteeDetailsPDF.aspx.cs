using BAL;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Devasthanam.views.Test
{
    public partial class RecruiteeDetailsPDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDropDown();
            }
        }
        public void LoadCityDropDown()
        {
            RecruiteeDetailsPDFBAL objCity = new RecruiteeDetailsPDFBAL();
            ddlCities.DataSource = objCity.GetCity();
            ddlCities.DataTextField = "City";
            ddlCities.DataValueField = "id";
            ddlCities.DataBind();
            ddlCities.Items.Insert(0, new ListItem("Select City", "0"));
        }
        public void btnDetails_Click(object sender, EventArgs e)
        {
            string city = ddlCities.SelectedItem.Text;
            string phone = txtPhone.Text;
            BindData(city, phone);
        }
        public void BindData(string city, string phone)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RegistrationsByCityAndPhone", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader["uName"].ToString();
                            lblSurName.Text = reader["SurName"].ToString();
                            lblPhone.Text = reader["Phone"].ToString();
                            lblEmail.Text = reader["Email"].ToString();
                            lblGender.Text = reader["Gender"].ToString();
                            lblDob.Text = reader["DOB"].ToString();
                            lblCity.Text = reader["City"].ToString();
                            lblAddress.Text = reader["UAddress"].ToString();
                            lblQualification.Text = reader["Qualification"].ToString();
                            lblPercentage.Text = reader["UPercentage"].ToString();
                            pnlContainer2.Visible = true;
                        }
                        else
                        {
                            string script = "alert('Data not found or invalid Data.');";
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                        }
                    }
                }
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
              
        }
        public void btnDownload(object sender, EventArgs e)
        {
            ExportToPDF();
        }
        public void ExportToPDF()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Candidates.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            assd.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }
    }
}
 
