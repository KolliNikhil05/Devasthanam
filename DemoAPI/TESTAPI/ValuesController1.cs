using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Http;

namespace TESTAPI
{
    public class ValuesController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }






        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;

        // GET api/<controller>
        public IHttpActionResult GetSkills()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("Skills_Get", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int skillId = reader.GetInt32(reader.GetOrdinal("SkillId"));
                                    string skill = reader.GetString(reader.GetOrdinal("Skill"));
                                    Console.WriteLine($"SkillId: {skillId}, Skill: {skill}");
                                }

                                return Ok("Data retrieved successfully");
                            }
                            else
                            {
                                return NotFound(); // No data found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }



    }
}