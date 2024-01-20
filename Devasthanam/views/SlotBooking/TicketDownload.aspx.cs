using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Devasthanam.views.SlotBooking
{
    public partial class TicketDownload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["aadhar"] != null && Session["bookingdate"] != null)

                {
                    date.InnerText = Session["bookingdate"].ToString();
                    aadhar.InnerText = Session["aadhar"].ToString();

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
            Response.AddHeader("content-disposition", "attachment;filename=SarvaDarshanTicket.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                // Add logo image at the top center
                string imagePath2 = Server.MapPath("~/Image/Ticket.jpg");
                iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(imagePath2);
                img2.ScaleToFit(500f, 300f);
                float x2 = (pdfDoc.Right - pdfDoc.Left - img2.ScaledWidth) / 2;
                float y2 = pdfDoc.Top - img2.ScaledHeight - 20;
                img2.SetAbsolutePosition(x2, y2);
                pdfDoc.Add(img2);
                // Add some space
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph("\n"));
                pdfDoc.Add(new Paragraph("\n"));
                ColumnText ct = new ColumnText(pdfWriter.DirectContent);
                ct.SetSimpleColumn(new Rectangle(350, -750, 200, 700));  
                ct.Alignment = Element.ALIGN_CENTER;

                ct.AddElement(new Paragraph("Special Darshan Entry Ticket", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK)));
                ct.AddElement(new Paragraph("Ticket ID : SMLM0561"));
                ct.AddElement(new Paragraph("Booking Date : " + Session["bookingdate"]?.ToString()));
                ct.AddElement(new Paragraph("Aadhar ID : " + Session["aadhar"]?.ToString()));
                ct.AddElement(new Paragraph("Amount : ₹300/- only"));
                ct.AddElement(new Paragraph("Payment ID : HDFC4106854"));
                ct.Go();

                pdfDoc.Close();
                pdfWriter.Close();
                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
        }

        [WebMethod]
        public static void Logout()
        {
            HttpContext context = HttpContext.Current;
            if (context.Session["userid"] != null && context.Session["password"] != null && context.Session["aadhar"] != null && context.Session["bookingdate"] != null)
            {
                context.Session.Remove("userid");
                context.Session.Remove("password");
                context.Session.Remove("aadhar");
                context.Session.Remove("bookingdate");
                context.Session.Abandon();
            }

        }

    }
}