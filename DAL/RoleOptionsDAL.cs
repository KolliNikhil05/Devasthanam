using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class RoleOptionsDAL
    {
        public DataTable GetDistricts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Districts_Get", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    DataTable dt = new DataTable();
                    //dt.Load(cmd.ExecuteReader());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetMandals(string districtId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Mandals_Get", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DistrictId", districtId);
                    connection.Open();
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;

        public DataTable GetSkills()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Skills_Get", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable skillsTable = new DataTable();
                        adapter.Fill(skillsTable);
                        return skillsTable;
                    }
                }
            }
        }

        public DataTable GetRoles(string skillId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Role_Get", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SkillId", skillId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable rolesTable = new DataTable();
                        adapter.Fill(rolesTable);
                        return rolesTable;
                    }
                }
            }
        }

        public DataTable GetRoleById(string roleId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT RoleId, Role FROM Roles WHERE RoleId = @RoleId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleId", roleId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public void InsertData(string name, string surName, string district, string mandal, string gender, string skills, string roles, string dob, string upload)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("test_Insert", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@SurName", surName);
                        cmd.Parameters.AddWithValue("@District", district);
                        cmd.Parameters.AddWithValue("@Mandal", mandal);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Skills", skills);
                        cmd.Parameters.AddWithValue("@Roles", roles);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Upload", upload);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

       























//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Web.UI.WebControls;

//namespace DAL
//{
//    public class RoleOptionsDAL
//    {
//        public void BindDistrictDropdown()
//        {
//            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
//            // Call your stored procedure to get the district data
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                using (SqlCommand cmd = new SqlCommand("Districts_Get", connection))
//                {
//                    cmd.CommandType = CommandType.StoredProcedure;
//                    connection.Open();

//                    ddlDistrict.DataSource = cmd.ExecuteReader();
//                    ddlDistrict.DataTextField = "District";
//                    ddlDistrict.DataValueField = "DistrictId";
//                    ddlDistrict.DataBind();

//                    connection.Close();
//                }
//            }

//            // Add an initial item for better user experience
//            ddlDistrict.Items.Insert(0, new ListItem("Select District", "0"));
//        }
//        public void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Get the selected district ID
//            string selectedDistrictId = ddlDistrict.SelectedValue;

//            if (selectedDistrictId != "0")
//            {
//                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString;
//                // Call the Mandals_Get stored procedure with the selected district ID
//                using (SqlConnection connection = new SqlConnection(connectionString))
//                {
//                    using (SqlCommand cmd = new SqlCommand("Mandals_Get", connection))
//                    {
//                        cmd.CommandType = CommandType.StoredProcedure;
//                        cmd.Parameters.AddWithValue("@DistrictId", selectedDistrictId);
//                        connection.Open();

//                        ddlMandal.DataSource = cmd.ExecuteReader();
//                        ddlMandal.DataTextField = "Mandal";
//                        ddlMandal.DataValueField = "MandalId";
//                        ddlMandal.DataBind();

//                        connection.Close();
//                    }
//                }
//            }
//            else
//            {
//                // Clear the mandal dropdown if "Select District" is chosen
//                ddlMandal.Items.Clear();
//            }

//            // Add an initial item for better user experience
//            ddlMandal.Items.Insert(0, new ListItem("Select Mandal", "0"));
//        }
//    }
//}
