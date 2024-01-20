using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentDemo.Models;
using StudentDemo.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentDemo.Controllers
{

    public class StudentController : Controller
    {
        private readonly StudentServices _apiService;

        public StudentController(StudentServices apiService)
        {
            _apiService = apiService;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var students = await _apiService.GetStudentData();
        //    return View("Student", students);  
        //}
        public IActionResult Index()
        {
            var students = _apiService.GetStudentData().Result;  
            return View("Student", students);
        }





    }
}
