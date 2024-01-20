using BAL;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml.html;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using static System.Net.Mime.MediaTypeNames;
using Image = iTextSharp.text.Image;

namespace Devasthanam.views.Recruitment
{
    public partial class ApplicationStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string GetStatusData(string phone)
        {
            string jsonResult = "";
            ApplicationStatusBAL objUpdate = new ApplicationStatusBAL();
            DataSet StatusData = objUpdate.GetStatus(phone);
            jsonResult = JsonConvert.SerializeObject(StatusData);
            return jsonResult;
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        public void btnDownload(object sender, EventArgs e)
        {
            string phone = txtPhone.Value;
            string jsonResult = GetStatusData(phone);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jsonResult);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                lblName.InnerText = dataSet.Tables[0].Rows[0]["uName"].ToString();
                lblSurName.InnerText = dataSet.Tables[0].Rows[0]["SurName"].ToString();
                lblPhone.InnerText = dataSet.Tables[0].Rows[0]["Phone"].ToString();
                lblEmail.InnerText = dataSet.Tables[0].Rows[0]["Email"].ToString();
                lblGender.InnerText = dataSet.Tables[0].Rows[0]["Gender"].ToString();
                lblPayment.InnerText = dataSet.Tables[0].Rows[0]["Payment"].ToString();
                lblQualified.InnerText = dataSet.Tables[0].Rows[0]["Qualified"].ToString();
                ExportToPDF();
            }
        }
       
        public void ExportToPDF()
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Candidates.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            letter.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            PdfContentByte pdfContent = pdfWriter.DirectContent;
            pdfContent.BeginText();
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            pdfContent.SetFontAndSize(bf, 11);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "Congratatulation Candidate You have Selected In Recruitment Process By Simhachala Devasthanam !.,", 10, pdfDoc.Top - 7, 0);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "Dear Candidate,", 10, pdfDoc.Top - 20, 0);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "Your Details : ", 10, pdfDoc.Top - 35, 0);
            pdfContent.EndText();
            pdfDoc.Add(new Paragraph("\n"));
            pdfDoc.Add(new Paragraph("\n"));
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            htmlparser.Parse(sr);
            pdfDoc.Add(new Paragraph("\n")); 
            pdfContent.BeginText();
            pdfContent.SetFontAndSize(bf, 11);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "The Pdf is the Proof of Your Offer, please Make A hard Copy and Sign it for reference While Joining. ", 10, pdfDoc.Top - 200, 0);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "Joining Date: 05-01-2024.", 10, pdfDoc.Top - 220, 0);
            pdfContent.ShowTextAligned(Element.ALIGN_LEFT, "Candidate Signature", 10, pdfDoc.Top - 360, 0);
            pdfContent.EndText();
            string imagePath2 = Server.MapPath("~/Image/namam logo.jpg");
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(imagePath2);
            img2.ScaleToFit(200f, 100f);
            float x2 = (pdfDoc.Right - pdfDoc.Left - img2.ScaledWidth) / 2;
            float y2 = pdfDoc.Top - img2.ScaledHeight - 20;
            img2.SetAbsolutePosition(x2, y2);
            pdfDoc.Add(img2);
            string imagePath3 = Server.MapPath("~/Image/Stamp.png");
            iTextSharp.text.Image img3 = iTextSharp.text.Image.GetInstance(imagePath3);
            img3.ScaleToFit(200f, 105f);
            float x3 = (pdfDoc.Right - pdfDoc.Left - img3.ScaledWidth) / 2;
            float y3 = pdfDoc.Bottom + 450; 
            img3.SetAbsolutePosition(x3, y3);
            pdfDoc.Add(img3);
            string imagePath4 = Server.MapPath("~/Image/Devasthanam.png");
            iTextSharp.text.Image img4 = iTextSharp.text.Image.GetInstance(imagePath4);
            img4.ScaleToFit(200f, 150f);
            float x4 = (pdfDoc.Right - pdfDoc.Left - img4.ScaledWidth) / 2;
            float y4 = pdfDoc.Bottom + 400;
            img4.SetAbsolutePosition(x4, y4);
            pdfDoc.Add(img4);
            pdfDoc.Close();
            Response.End();
        }

        [WebMethod]
        public static void Logout()
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["userid"] != null && context.Session["password"] != null)
            {
                context.Session.Remove("userid");
                context.Session.Remove("password");
                context.Session.Abandon();
            }

        }
    }
}