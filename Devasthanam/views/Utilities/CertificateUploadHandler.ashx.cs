using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Devasthanam.views.Utilities
{
    /// <summary>
    /// Summary description for CertificateUploadHandler
    /// </summary>
    public class CertificateUploadHandler : IHttpHandler
    {
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            string virtualPath = ConfigurationManager.AppSettings["uploads"].ToString();
            if (context.Request.Files.Count > 0)
            {
                HttpPostedFile file = context.Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    string filename = Path.GetFileName(file.FileName);
                    string filePath = Path.Combine(virtualPath, filename);
                    //string filePath = virtualPath + filename;
                    file.SaveAs(filePath);
                    context.Response.ContentType = "application/json";
                    context.Response.Write(filePath);
                }
                if (!Directory.Exists(virtualPath))
                {
                    Directory.CreateDirectory(virtualPath);
                }
            }
            context.Response.ContentType = "text/plain";
        }

    }
}


        //public bool IsReusable
        //{
        //    get
        //    {
        //        return false;
        //    }
        //}
    

//try
//{
//    if (context.Request.Files.Count > 0)
//    {
//        HttpPostedFile file = context.Request.Files[0];
//        string fileName = Path.GetFileName(file.FileName);
//        string uploadDirectory = ConfigurationManager.AppSettings["uploads"].ToString();
//        string filePath = (uploadDirectory + fileName);
//        file.SaveAs(filePath);
//        context.Session["file"] = filePath;
//        context.Response.Write("File uploaded successfully.");
//    }
//    else
//    {
//        context.Response.Write("No file found in the request.");
//    }
//}
//catch (Exception ex)
//{
//    context.Response.Write("Error: " + ex.Message);
//}