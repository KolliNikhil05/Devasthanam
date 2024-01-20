using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Test.API.Data.Models;

namespace Test.API.Data
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        { 
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(!context.Students.Any())
                {
                    context.Students.AddRange(new Student()
                    {
                        Name = "Nikhil",
                        JoiningDate = DateTime.Now.AddDays(-15)
                    },
                    new Student()
                    {
                        Name = "Hari",
                        JoiningDate = DateTime.Now.AddDays(-15)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
