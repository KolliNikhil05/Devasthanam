using BAL;
using iTextSharp.text;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Devasthanam.views.Admin
{
    public partial class RecruiteePaymentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDropDown();               
            }
        }
        public void LoadCityDropDown()
        {
            RecruiteePaymentDetailsBAL objCity = new RecruiteePaymentDetailsBAL();
            ddlCity.DataSource = objCity.GetCity();
            ddlCity.DataTextField = "City";
            ddlCity.DataValueField = "id";
            ddlCity.DataBind();
            ddlCity.Items.Insert(8, new ListItem("All", "All"));
            ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
        }
        public void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridView();
        }
        public void BindGridView()
        {
            RecruiteePaymentDetailsBAL objBind = new RecruiteePaymentDetailsBAL();
            string selectedCity = ddlCity.SelectedValue;
            DataTable BindByCity;
            BindByCity = objBind.GetRecruiteePaymentData(selectedCity);
            GridView1.DataSource = BindByCity;
            GridView1.DataBind();
           // ViewState["DataTable"] = dataTable;
        }
        public void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                string userId = ((TextBox)row.FindControl("txtEditUserId")).Text;
                string uName = ((TextBox)row.FindControl("txtEditUName")).Text;
                string surName = ((TextBox)row.FindControl("txtEditSurName")).Text;
                string phone = ((TextBox)row.FindControl("txtEditPhone")).Text;
                string email = ((TextBox)row.FindControl("txtEditEmail")).Text;
                string gender = ((RadioButtonList)row.FindControl("rblEditGender")).SelectedValue;
                string dob = ((TextBox)row.FindControl("txtEditDOB")).Text;
                DropDownList ddlEditCity = (DropDownList)row.FindControl("ddlEditCity");
                string city = ddlEditCity.SelectedItem.Text;
                string address = ((TextBox)row.FindControl("txtEditAddress")).Text;
                string qualification = ((TextBox)row.FindControl("txtEditQualification")).Text;
                string percentage = ((TextBox)row.FindControl("txtEditPercentage")).Text;
                string payment = ((TextBox)row.FindControl("txtEditPayment")).Text;
                RecruiteePaymentDetailsBAL objUpdate = new RecruiteePaymentDetailsBAL();
                objUpdate.UpdateUser(userId, phone, uName, surName, email, gender, dob, city, address, qualification, percentage, payment);
                GridView1.EditIndex = -1;
                BindGridView();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "UpdateSuccess", "alert('Updation done Successfully.');", true);
            }
            catch (Exception ex)
            {

            }
        }
        public void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridView();
        }
        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (GridView1.DataKeys.Count > rowIndex && GridView1.DataKeys[rowIndex] != null)
                {
                    string userId = GridView1.DataKeys[rowIndex]["userId"].ToString();
                    RecruiteePaymentDetailsBAL objDelete = new RecruiteePaymentDetailsBAL();
                    objDelete.DeleteRecord(userId);
                    BindGridView();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "deleteSuccess", "alert('Record deleted successfully.');", true);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
        public void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();
            DropDownList ddlEditCity = (DropDownList)GridView1.Rows[e.NewEditIndex].FindControl("ddlEditCity");
            HiddenField hdnCity = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("hdnCity");
            LoadCityDropDownForEditing(ddlEditCity, hdnCity.Value);
            RadioButtonList rblEditGender = (RadioButtonList)GridView1.Rows[e.NewEditIndex].FindControl("rblEditGender");
            HiddenField hdnGender = (HiddenField)GridView1.Rows[e.NewEditIndex].FindControl("hdnGender");           
            LoadGenderRadioButtonForEditing(rblEditGender, hdnGender.Value);
        }
        public void LoadCityDropDownForEditing(DropDownList ddlEditCity, string selectedCity)
        {
            RecruiteePaymentDetailsBAL objCities = new RecruiteePaymentDetailsBAL();
            ddlEditCity.DataSource = objCities.GetCity();
            ddlEditCity.DataTextField = "City";
            ddlEditCity.DataValueField = "id";
            ddlEditCity.DataBind();
            ddlEditCity.Items.Insert(0, new ListItem("Select City", "0"));

            //ddlEditCity.SelectedValue =  hdnCity.value ;
            for (int i = 0; i < ddlEditCity.Items.Count; i++)
            {
                if (ddlEditCity.Items[i].Text == selectedCity)
                {
                    ddlEditCity.Items[i].Selected = true;
                    break;
                }
            }
        }
        public void LoadGenderRadioButtonForEditing(RadioButtonList rblEditGender, string selectedGender)
        {
            foreach (ListItem item in rblEditGender.Items)
            {
                if (item.Value == selectedGender)
                {
                    item.Selected = true;
                    break;
                }
            }
        }
        public void data_insert(object sender, EventArgs e)
        {
            try
            {
                string userId = ((TextBox)GridView1.FooterRow.FindControl("txtNewUserId")).Text;
                string uName = ((TextBox)GridView1.FooterRow.FindControl("txtNewUName")).Text;
                string surName = ((TextBox)GridView1.FooterRow.FindControl("txtNewSurName")).Text;
                string phone = ((TextBox)GridView1.FooterRow.FindControl("txtNewPhone")).Text;
                string email = ((TextBox)GridView1.FooterRow.FindControl("txtNewEmail")).Text;
                string gender = ((RadioButtonList)GridView1.FooterRow.FindControl("rdbNewGender")).SelectedValue;
                string dob = ((TextBox)GridView1.FooterRow.FindControl("txtNewDOB")).Text;
                string city = ((DropDownList)GridView1.FooterRow.FindControl("ddlNewCity")).SelectedItem.Text;
                string address = ((TextBox)GridView1.FooterRow.FindControl("txtNewAddress")).Text;
                string qualification = ((TextBox)GridView1.FooterRow.FindControl("txtNewQualification")).Text;
                string percentage = ((TextBox)GridView1.FooterRow.FindControl("txtNewPercentage")).Text;
                FileUpload fileUpload = (FileUpload)GridView1.FooterRow.FindControl("txtNewCertificate");
                if (fileUpload.HasFile)
                {
                    string fileName = Path.GetFileName(fileUpload.FileName);
                    string directoryPath = ConfigurationManager.AppSettings["uploads"].ToString();
                    string filePath = Path.Combine(directoryPath, fileName);
                    fileUpload.SaveAs(filePath);
                    string certificate = filePath;
                    string payment = ((TextBox)GridView1.FooterRow.FindControl("txtNewPayment")).Text;
                    RecruiteePaymentDetailsBAL objInsert = new RecruiteePaymentDetailsBAL();
                    objInsert.InsertUser(userId, uName, surName, phone, email, gender, dob, city, address, qualification, percentage, certificate, payment);
                    BindGridView();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "InsertSuccess", "alert('Insertion done Successfully.');", true);
                }              
            }
            catch (Exception ex)
            {

            }
        }
        public void GridView1_InsertDropdown(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                DropDownList ddlNewCity = (DropDownList)e.Row.FindControl("ddlNewCity");
                if (ddlNewCity != null)
                {
                    RecruiteePaymentDetailsBAL bal = new RecruiteePaymentDetailsBAL();
                    ddlNewCity.DataSource = bal.GetCity();
                    ddlNewCity.DataTextField = "City";
                    ddlNewCity.DataValueField = "id";
                    ddlNewCity.DataBind();
                    ddlNewCity.Items.Insert(0, new ListItem("Select City", "0"));
                }
            }            
        }
        public void btn_AddRow(object sender, EventArgs e)
        {
            TextBox txtNewUserId = (TextBox)GridView1.FooterRow.FindControl("txtNewUserId");
            TextBox txtNewUName = (TextBox)GridView1.FooterRow.FindControl("txtNewUName");
            TextBox txtNewSurName = (TextBox)GridView1.FooterRow.FindControl("txtNewSurName");
            TextBox txtNewPhone = (TextBox)GridView1.FooterRow.FindControl("txtNewPhone");
            TextBox txtNewEmail = (TextBox)GridView1.FooterRow.FindControl("txtNewEmail");
            RadioButtonList rdbNewGender = (RadioButtonList)GridView1.FooterRow.FindControl("rdbNewGender");
            TextBox txtNewDOB = (TextBox)GridView1.FooterRow.FindControl("txtNewDOB");
            DropDownList ddlNewCity = (DropDownList)GridView1.FooterRow.FindControl("ddlNewCity");
            TextBox txtNewAddress = (TextBox)GridView1.FooterRow.FindControl("txtNewAddress");
            TextBox txtNewQualification = (TextBox)GridView1.FooterRow.FindControl("txtNewQualification");
            TextBox txtNewPercentage = (TextBox)GridView1.FooterRow.FindControl("txtNewPercentage");
            TextBox txtNewPayment = (TextBox)GridView1.FooterRow.FindControl("txtNewPayment");
            Button btnInsert = (Button)GridView1.FooterRow.FindControl("btnInsert");
            Button btnClear = (Button)GridView1.FooterRow.FindControl("btnClear");
            FileUpload txtNewCertificate = (FileUpload)GridView1.FooterRow.FindControl("txtNewCertificate");
            if (txtNewUserId != null)
            {
                txtNewUserId.Visible = !txtNewUserId.Visible;
            }
            if (txtNewUName != null)
            {
                txtNewUName.Visible = !txtNewUName.Visible;
            }
            if (txtNewSurName != null)
            {
                txtNewSurName.Visible = !txtNewSurName.Visible;
            }
            if (txtNewPhone != null)
            {
                txtNewPhone.Visible = !txtNewPhone.Visible;
            }
            if (txtNewEmail != null)
            {
                txtNewEmail.Visible = !txtNewEmail.Visible;
            }
            if (rdbNewGender != null)
            {
                rdbNewGender.Visible = !rdbNewGender.Visible;
            }
            if (txtNewDOB != null)
            {
                txtNewDOB.Visible = !txtNewDOB.Visible;
            }
            if (ddlNewCity != null)
            {
                ddlNewCity.Visible = !ddlNewCity.Visible;
            }
            if (txtNewAddress != null)
            {
                txtNewAddress.Visible = !txtNewAddress.Visible;
            }
            if (txtNewQualification != null)
            {
                txtNewQualification.Visible = !txtNewQualification.Visible;
            }
            if (txtNewPercentage != null)
            {
                txtNewPercentage.Visible = !txtNewPercentage.Visible;
            }
            if (txtNewPayment != null)
            {
                txtNewPayment.Visible = !txtNewPayment.Visible;
            }
            if (btnInsert != null)
            {
                btnInsert.Visible = !btnInsert.Visible;
            }
            if (btnClear != null)
            {
                btnClear.Visible = !btnClear.Visible;
            }
            if (txtNewCertificate != null)
            {
                txtNewCertificate.Visible = !txtNewCertificate.Visible;
            }
        }
        public void btn_Clear(object sender, EventArgs e)
        {
            TextBox txtNewUserId = (TextBox)GridView1.FooterRow.FindControl("txtNewUserId");
            TextBox txtNewUName = (TextBox)GridView1.FooterRow.FindControl("txtNewUName");
            TextBox txtNewSurName = (TextBox)GridView1.FooterRow.FindControl("txtNewSurName");
            TextBox txtNewPhone = (TextBox)GridView1.FooterRow.FindControl("txtNewPhone");
            TextBox txtNewEmail = (TextBox)GridView1.FooterRow.FindControl("txtNewEmail");
            RadioButtonList rdbNewGender = (RadioButtonList)GridView1.FooterRow.FindControl("rdbNewGender");
            TextBox txtNewDOB = (TextBox)GridView1.FooterRow.FindControl("txtNewDOB");
            DropDownList ddlNewCity = (DropDownList)GridView1.FooterRow.FindControl("ddlNewCity");
            TextBox txtNewAddress = (TextBox)GridView1.FooterRow.FindControl("txtNewAddress");
            TextBox txtNewQualification = (TextBox)GridView1.FooterRow.FindControl("txtNewQualification");
            TextBox txtNewPercentage = (TextBox)GridView1.FooterRow.FindControl("txtNewPercentage");
            TextBox txtNewPayment = (TextBox)GridView1.FooterRow.FindControl("txtNewPayment");

            if (txtNewUserId != null)
            {
                txtNewUserId.Text = string.Empty;
            }
            if (txtNewUName != null)
            {
                txtNewUName.Text = string.Empty;
            }
            if (txtNewSurName != null)
            {
                txtNewSurName.Text = string.Empty;
            }
            if (txtNewPhone != null)
            {
                txtNewPhone.Text = string.Empty;
            }
            if (txtNewEmail != null)
            {
                txtNewEmail.Text = string.Empty;
            }
            if (rdbNewGender != null)
            {
                rdbNewGender.ClearSelection();
            }
            if (txtNewDOB != null)
            {
                txtNewDOB.Text = string.Empty;
            }
            if (ddlNewCity != null)
            {
                ddlNewCity.SelectedIndex = -1;
            }
            if (txtNewAddress != null)
            {
                txtNewAddress.Text = string.Empty;
            }
            if (txtNewQualification != null)
            {
                txtNewQualification.Text = string.Empty;
            }
            if (txtNewPercentage != null)
            {
                txtNewPercentage.Text = string.Empty;
            }
            if (txtNewPayment != null)
            {
                txtNewPayment.Text = string.Empty;
            }
               


        }
        public void download_Certifiacte(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).NamingContainer;
            HiddenField hdnfile = (HiddenField)row.FindControl("hdnCertificate");
            string file = hdnfile.Value.Trim();
            if (!string.IsNullOrEmpty(file) && File.Exists(file))
            {

                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(file));
                Response.TransmitFile(file);
                Response.End();
            }
            else
            {
                string script = "alert('File not found or invalid path.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

        


    }
}
