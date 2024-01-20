using Demo.BAL;
using Demo.Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Student
    {
        public readonly StudentInterface obj;
        public Student(StudentInterface StudentModel)
        {
            obj = StudentModel;
        }
        [HttpGet]
        public string GetData()
        {
            DataTable dataList = obj.GetMyDataList();
            var jsonData = JsonConvert.SerializeObject(dataList);
            return jsonData;
        }
    }
}
