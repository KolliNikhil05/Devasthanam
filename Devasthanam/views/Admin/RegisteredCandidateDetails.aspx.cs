using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Devasthanam.views.Admin
{
    public partial class RegisteredCandidateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRegisteredData();
            }
        }

        public void BindRegisteredData()
        {
                RegisteredCandidateDetailsBAL candidateBal = new RegisteredCandidateDetailsBAL();
                DataTable dataRegistered = candidateBal.GetRegisteredCandidates();
                gv_Download.DataSource = dataRegistered;
                gv_Download.DataBind();
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
            Response.AddHeader("content-disposition", "attachment;filename=RegisteredCandidates.pdf");
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