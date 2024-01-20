using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Devasthanam.views.Utilities
{
    public class LogExceptions
    {
        public static void LogException(string Source, string ErrorCode, string Exc)
        {
            {
                try
                {
                    string Dir = @"E:\LogException\Signup\";
                    if (!Directory.Exists(Dir))
                        Directory.CreateDirectory(Dir);
                    string logfile = Dir + "LogExceptions.txt";
                    StreamWriter sw = new StreamWriter(logfile, true);
                    sw.WriteLine("********** {0} *********", DateTime.Now);
                    sw.Write("\nError Code:" + ErrorCode);
                    sw.WriteLine(" ");
                    sw.WriteLine("\nSource:" + Source);
                    sw.WriteLine("\nEXCEPTION:" + Exc);
                    sw.WriteLine("\nException logged in DB:" + Convert.ToString(false));
                    sw.WriteLine("\n******** X *********");
                    sw.WriteLine("\n");
                    sw.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }


        public static void LogException2(string Source, string ErrorCode, string Exc)
        {
            {
                try
                {
                    string Dir = @"E:\LogException\Login\";
                    if (!Directory.Exists(Dir))
                        Directory.CreateDirectory(Dir);
                    string logfile = Dir + "LogExceptions.txt";
                    StreamWriter sw = new StreamWriter(logfile, true);
                    sw.WriteLine("********** {0} *********", DateTime.Now);
                    sw.Write("\nError Code:" + ErrorCode);
                    sw.WriteLine(" ");
                    sw.WriteLine("\nSource:" + Source);
                    sw.WriteLine("\nEXCEPTION:" + Exc);
                    sw.WriteLine("\nException logged in DB:" + Convert.ToString(false));
                    sw.WriteLine("\n******** X *********");
                    sw.WriteLine("\n");
                    sw.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }


        public static void RegistrationException(string Source, string ErrorCode, string Exc)
        {
            {
                try
                {
                    string Dir = @"E:\LogException\Registration\";
                    if (!Directory.Exists(Dir))
                        Directory.CreateDirectory(Dir);
                    string logfile = Dir + "LogExceptions.txt";
                    StreamWriter sw = new StreamWriter(logfile, true);
                    sw.WriteLine("********** {0} *********", DateTime.Now);
                    sw.Write("\nError Code:" + ErrorCode);
                    sw.WriteLine(" ");
                    sw.WriteLine("\nSource:" + Source);
                    sw.WriteLine("\nEXCEPTION:" + Exc);
                    sw.WriteLine("\nException logged in DB:" + Convert.ToString(false));
                    sw.WriteLine("\n******** X *********");
                    sw.WriteLine("\n");
                    sw.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }


        public static void aspException(string Source, string ErrorCode, string Exc)
        {
            {
                try
                {
                    string Dir = @"E:\LogException\asp\";
                    if (!Directory.Exists(Dir))
                        Directory.CreateDirectory(Dir);
                    string logfile = Dir + "AspExceptions.txt";
                    StreamWriter sw = new StreamWriter(logfile, true);
                    sw.WriteLine("********** {0} *********", DateTime.Now);
                    sw.Write("\nError Code:" + ErrorCode);
                    sw.WriteLine(" ");
                    sw.WriteLine("\nSource:" + Source);
                    sw.WriteLine("\nEXCEPTION:" + Exc);
                    sw.WriteLine("\nException logged in DB:" + Convert.ToString(false));
                    sw.WriteLine("\n******** X *********");
                    sw.WriteLine("\n");
                    sw.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
    }

}

 