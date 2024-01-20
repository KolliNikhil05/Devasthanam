using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Devasthanam.views.Test
{
    public partial class GridViewDownload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }
        private void BindGridView()
        {
            try
            {
                //string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetDownloadData", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            gv_Download.DataSource = dt;
                            gv_Download.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
              
        }
        protected void btnDownload(object sender, EventArgs e)
        {
            ExportGridToPDF();
        }
        private void ExportGridToPDF()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Nikhil.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            gv_Download.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
            gv_Download.AllowPaging = true;
            gv_Download.DataBind();
        }
    }
}
