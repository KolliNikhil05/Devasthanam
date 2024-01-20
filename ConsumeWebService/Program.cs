using System;
using System.Data;
using System.Net.Http.Headers;

namespace ConsumeWebService
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RecruiteeData.RecruiteeData obj = new RecruiteeData.RecruiteeData();
            DataTable dtRec=obj.GetRecruiteeData();

            Console.WriteLine(dtRec.Rows.Count);

        }
    }
}
