using Newtonsoft.Json;
using StudentDemo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentDemo.Services
{
    public class StudentServices
    {
        private readonly HttpClient _httpClient;

        public StudentServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StudentModel>> GetStudentData()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:44374/api/Student");
            var students = JsonConvert.DeserializeObject<List<StudentModel>>(response);
            return students;
        }

        //public List<StudentModel> GetStudentData()
        //{
        //    var response = _httpClient.GetStringAsync("https://localhost:44374/api/Student").Result;  
        //    var students = JsonConvert.DeserializeObject<List<StudentModel>>(response);
        //    return students;
        //}



    }
}
