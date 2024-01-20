using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Devasthanam.views.Utilities
{
    /// <summary>
    /// Summary description for FileUploadHandler
    /// </summary>
    public class FileUploadHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            try
            {
                if (context.Request.Files.Count > 0)
                {
                    HttpPostedFile file = context.Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        string directoryPath = ConfigurationManager.AppSettings["uploads"].ToString();                       
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath); // Create the directory if it doesn't exist
                        }
                        string filePath = Path.Combine(directoryPath, Path.GetFileName(file.FileName));
                        file.SaveAs(filePath);
                        context.Response.Write("File uploaded successfully.");
                    }
                    else
                    {
                        context.Response.Write("No file selected or file is empty.");
                    }
                }
                else
                {
                    context.Response.Write("No files uploaded.");
                }
            }
            catch (Exception ex)
            {
                context.Response.Write("Error: " + ex.Message);
            }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}