using BAL;
using Devasthanam.views.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace Devasthanam.views.UserHome
{
    public partial class RoleOptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RoleOptionsBAL bal = new RoleOptionsBAL();
                ddlDistrict.DataSource = bal.GetDistricts();
                ddlDistrict.DataTextField = "District";
                ddlDistrict.DataValueField = "DistrictId";
                ddlDistrict.DataBind();
                ddlDistrict.Items.Insert(0, new ListItem("Select District", "0"));



                RoleOptionsBAL skillsTable = new RoleOptionsBAL();
                lstSkills.DataSource = skillsTable.GetSkills();
                lstSkills.DataTextField = "Skill";
                lstSkills.DataValueField = "SkillId";
                lstSkills.DataBind();


            }
        }

        public void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDistrictId = ddlDistrict.SelectedValue;

            if (selectedDistrictId != "0")
            {
                RoleOptionsBAL bal = new RoleOptionsBAL();
                ddlMandal.DataSource = bal.GetMandals(selectedDistrictId);
                ddlMandal.DataTextField = "Mandal";
                ddlMandal.DataValueField = "MandalId";
                ddlMandal.DataBind();
            }
            else
            {
                ddlMandal.Items.Clear();
            }
            ddlMandal.Items.Insert(0, new ListItem("Select Mandal", "0"));
        }

        public void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> selectedSkillIds = new List<string>();
            foreach (ListItem item in lstSkills.Items)
            {
                if (item.Selected)
                {
                    selectedSkillIds.Add(item.Value);
                }
            }
            DataTable rolesTable = new DataTable();
            foreach (string skillId in selectedSkillIds)
            {
                DataTable rolesForSkill = new RoleOptionsBAL().GetRoles(skillId);
                rolesTable.Merge(rolesForSkill);
            }
            lstRoles.DataSource = rolesTable;
            lstRoles.DataTextField = "Role";
            lstRoles.DataValueField = "RoleId";
            lstRoles.DataBind();
            //updatePanelRoles.Update();
        }

        public void Insert_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in lstRoles.Items)
            {
                if (item.Selected)
                {
                    string selectedRoleId = item.Value;
                    RoleOptionsBAL roleBAL = new RoleOptionsBAL();
                    DataTable roleData = roleBAL.GetRoleById(selectedRoleId);

                    if (roleData.Rows.Count > 0)
                    {
                        foreach (DataRow row in roleData.Rows)
                        {
                            // Check if the item already exists in lstEditRoles to avoid duplicates
                            bool itemExists = false;
                            foreach (ListItem existingItem in lstEditRoles.Items)
                            {
                                if (existingItem.Value == row["RoleId"].ToString())
                                {
                                    itemExists = true;
                                    break;
                                }
                            }

                            if (!itemExists)
                            {
                                ListItem newItem = new ListItem(row["Role"].ToString(), row["RoleId"].ToString());
                                lstEditRoles.Items.Add(newItem);
                            }
                        }
                    }
                }
            }
        }


        //public void Insert_Click(object sender, EventArgs e)
        //{
        //    if (lstRoles.SelectedIndex >= 0)
        //    {
        //        string selectedRoleId = lstRoles.SelectedValue;
        //        RoleOptionsBAL roleBAL = new RoleOptionsBAL();
        //        DataTable roleData = roleBAL.GetRoleById(selectedRoleId);


        //            if (roleData.Rows.Count > 0)
        //        {
        //            lstEditRoles.DataSource = roleData;
        //            lstEditRoles.DataTextField = "Role";
        //            lstEditRoles.DataValueField = "RoleId";
        //            lstEditRoles.DataBind();
        //        }
        //    }


        //}

        public void Reset_Click(object sender, EventArgs e)
        {
            lstEditRoles.Items.Clear();
        }

        public void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in lstRoles.Items)
            {
                item.Selected = true;
            }
            List<ListItem> selectedItems = new List<ListItem>();
            foreach (ListItem item in lstRoles.Items)
            {
                if (item.Selected)
                {
                    selectedItems.Add(item);
                }
            }
            lstEditRoles.DataSource = selectedItems;
            lstEditRoles.DataTextField = "Text";
            lstEditRoles.DataValueField = "Value";
            lstEditRoles.DataBind();
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            // Iterate through selected items and remove them from the ListBox
            for (int i = lstEditRoles.Items.Count - 1; i >= 0; i--)
            {
                if (lstEditRoles.Items[i].Selected)
                {
                    lstEditRoles.Items.RemoveAt(i);
                }
            }
        }

        public void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = lstSkills.Items.Cast<ListItem>().Any(li => li.Selected);
        }

        public void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();

        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {




                if (IsValid)
                {
                    string name = txtName.Text;
                    string surName = txtSurName.Text;
                    string district = ddlDistrict.SelectedItem.Text;
                    string mandal = ddlMandal.SelectedItem.Text;
                    string gender = rdbGender.SelectedValue;
                    string skills = " ";

                    foreach (ListItem item in lstSkills.Items)
                    {
                        if (item.Selected)
                        {
                            skills = skills + item.Text + " , ";
                        }
                    };

                    string roles = " ";

                    foreach (ListItem item in lstEditRoles.Items)
                    {
                        roles = roles + item.Text + " ,";
                    };


                    string dob = txtDate.Text;
                    string upload = Upload.FileName;

                    // Call the business access layer to insert data
                    RoleOptionsBAL bal = new RoleOptionsBAL();
                    bal.InsertData(name, surName, district, mandal, gender, skills, roles, dob, upload);
                    string script = "alert('Submission successful!');";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessScript", script, true);

                }

                string virtualPath = ConfigurationManager.AppSettings["uploads"].ToString();
                if (Upload.HasFile)
                {
                    string fileName = Path.GetFileName(Upload.FileName);
                    string fileExtension = Path.GetExtension(fileName);
                    string file = virtualPath + fileName;
                    Upload.SaveAs(file);
                }
            }

            //catch (Exception ex)
            //{
            //    aspException("btnSubmit_Click", "ErrorCode123", ex.ToString());


            //}
            catch (Exception ex)
            {
                LogExceptions.aspException("btnSubmit_Click", "101", ex.Message);
            }

        }

        public void CustomDOBValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime selectedDate;

            if (DateTime.TryParse(txtDate.Text, out selectedDate))
            {
                string selectedGender = rdbGender.SelectedValue;

                if (selectedGender == "Male" && (selectedDate < new DateTime(DateTime.Now.Year, 11, 1) || selectedDate > new DateTime(DateTime.Now.Year, 11, 15)))
                {
                    args.IsValid = false;
                    CustomDOBValidator.ErrorMessage = "Male can Select between November 1 to November 15.";
                }
                else if (selectedGender == "Female" && (selectedDate < new DateTime(DateTime.Now.Year, 11, 1) || selectedDate > new DateTime(DateTime.Now.Year, 11, 20)))
                {
                    args.IsValid = false;
                    CustomDOBValidator.ErrorMessage = "FeMale can Select between November 1 to November 20.";
                }
                else if (selectedGender == "Prefer Not to Say" && (selectedDate < new DateTime(DateTime.Now.Year, 11, 1) || selectedDate > new DateTime(DateTime.Now.Year, 11, 30)))
                {
                    args.IsValid = false;
                    CustomDOBValidator.ErrorMessage = "Others can Select between November 1 to November 30.";
                }
                else
                {
                    args.IsValid = true;
                }
            }
            else
            {
                args.IsValid = false;
                CustomDOBValidator.ErrorMessage = "Invalid date format.";
            }
        }




    }

    
}




























