using BAL;
using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;
using ListItem = System.Web.UI.WebControls.ListItem;

namespace Devasthanam.views.Test
{
    public partial class GridView : System.Web.UI.Page
    {
        private int footerCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDropDown();
                InitializeDataTable();
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

            ddlCities.DataSource = objCity.GetCity();
            ddlCities.DataTextField = "City";
            ddlCities.DataValueField = "id";
            ddlCities.DataBind();
            ddlCities.Items.Insert(0, new ListItem("Select City", "0"));

        }
        public void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGridView();
        }
        public void BindGridView()
        {
            GridViewBAL objBind = new GridViewBAL();
            string selectedCity = ddlCity.SelectedValue;
            DataTable BindByCity;
            BindByCity = objBind.GetRecruiteePaymentData(selectedCity);
            GridView1.DataSource = BindByCity;
            GridView1.DataBind();
            // ViewState["DataTable"] = dataTable;
        }
        public void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
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
        public void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridView();
        }
        public void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
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
            GridViewBAL objUpdate = new GridViewBAL();
            objUpdate.UpdateUser(userId, phone, uName, surName, email, gender, dob, city, address, qualification, percentage, payment);
            GridView1.EditIndex = -1;
            BindGridView();
            string script = "alert('Updation done Successfully.');";
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);


        }
        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (GridView1.DataKeys.Count > rowIndex && GridView1.DataKeys[rowIndex] != null)
                {
                    string userId = GridView1.DataKeys[rowIndex]["userId"].ToString();
                    GridViewBAL objDelete = new GridViewBAL();
                    objDelete.DeleteRecord(userId);
                    BindGridView();
                    string script = "alert('Deletion done Successfully.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }
            }
            catch (Exception ex)
            {

            }
        }
        //public void btn_AddRow(object sender, EventArgs e)
        //{
        //    TextBox txtNewUserId = (TextBox)GridView1.FooterRow.FindControl("txtNewUserId");
        //    TextBox txtNewUName = (TextBox)GridView1.FooterRow.FindControl("txtNewUName");
        //    TextBox txtNewSurName = (TextBox)GridView1.FooterRow.FindControl("txtNewSurName");
        //    TextBox txtNewPhone = (TextBox)GridView1.FooterRow.FindControl("txtNewPhone");
        //    TextBox txtNewEmail = (TextBox)GridView1.FooterRow.FindControl("txtNewEmail");
        //    RadioButtonList rdbNewGender = (RadioButtonList)GridView1.FooterRow.FindControl("rdbNewGender");
        //    TextBox txtNewDOB = (TextBox)GridView1.FooterRow.FindControl("txtNewDOB");
        //    DropDownList ddlNewCity = (DropDownList)GridView1.FooterRow.FindControl("ddlNewCity");
        //    TextBox txtNewAddress = (TextBox)GridView1.FooterRow.FindControl("txtNewAddress");
        //    TextBox txtNewQualification = (TextBox)GridView1.FooterRow.FindControl("txtNewQualification");
        //    TextBox txtNewPercentage = (TextBox)GridView1.FooterRow.FindControl("txtNewPercentage");
        //    TextBox txtNewPayment = (TextBox)GridView1.FooterRow.FindControl("txtNewPayment");
        //    Button btnInsert = (Button)GridView1.FooterRow.FindControl("btnInsert");
        //    Button btnClear = (Button)GridView1.FooterRow.FindControl("btnClear");
        //    FileUpload txtNewCertificate = (FileUpload)GridView1.FooterRow.FindControl("txtNewCertificate");
        //    if (txtNewUserId != null)
        //    {
        //        txtNewUserId.Visible = !txtNewUserId.Visible;
        //    }
        //    if (txtNewUName != null)
        //    {
        //        txtNewUName.Visible = !txtNewUName.Visible;
        //    }
        //    if (txtNewSurName != null)
        //    {
        //        txtNewSurName.Visible = !txtNewSurName.Visible;
        //    }
        //    if (txtNewPhone != null)
        //    {
        //        txtNewPhone.Visible = !txtNewPhone.Visible;
        //    }
        //    if (txtNewEmail != null)
        //    {
        //        txtNewEmail.Visible = !txtNewEmail.Visible;
        //    }
        //    if (rdbNewGender != null)
        //    {
        //        rdbNewGender.Visible = !rdbNewGender.Visible;
        //    }
        //    if (txtNewDOB != null)
        //    {
        //        txtNewDOB.Visible = !txtNewDOB.Visible;
        //    }
        //    if (ddlNewCity != null)
        //    {
        //        ddlNewCity.Visible = !ddlNewCity.Visible;
        //    }
        //    if (txtNewAddress != null)
        //    {
        //        txtNewAddress.Visible = !txtNewAddress.Visible;
        //    }
        //    if (txtNewQualification != null)
        //    {
        //        txtNewQualification.Visible = !txtNewQualification.Visible;
        //    }
        //    if (txtNewPercentage != null)
        //    {
        //        txtNewPercentage.Visible = !txtNewPercentage.Visible;
        //    }
        //    if (txtNewPayment != null)
        //    {
        //        txtNewPayment.Visible = !txtNewPayment.Visible;
        //    }
        //    if (btnInsert != null)
        //    {
        //        btnInsert.Visible = !btnInsert.Visible;
        //    }
        //    if (btnClear != null)
        //    {
        //        btnClear.Visible = !btnClear.Visible;
        //    }
        //    if (txtNewCertificate != null)
        //    {
        //        txtNewCertificate.Visible = !txtNewCertificate.Visible;
        //    }
        //}    
        public void btn_AddRow(object sender, EventArgs e)
        {

        }
        public void InitializeDataTable()
        {
            DataTable userDataTable = new DataTable();
            userDataTable.Columns.Add("UserId", typeof(string));
            userDataTable.Columns.Add("Name", typeof(string));
            userDataTable.Columns.Add("SurName", typeof(string));
            userDataTable.Columns.Add("Phone", typeof(string));
            userDataTable.Columns.Add("Email", typeof(string));
            userDataTable.Columns.Add("Gender", typeof(string));
            userDataTable.Columns.Add("DOB", typeof(string));
            userDataTable.Columns.Add("City", typeof(string));
            userDataTable.Columns.Add("UAddress", typeof(string));
            userDataTable.Columns.Add("Qualification", typeof(string));
            userDataTable.Columns.Add("UPercentage", typeof(string));
            userDataTable.Columns.Add("UCertificate", typeof(string));
            userDataTable.Columns.Add("Payment", typeof(string));
            ViewState["UserData"] = userDataTable;
        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable userDataTable = ViewState["UserData"] as DataTable;

            DataRow newRow = userDataTable.NewRow();
            newRow["UserId"] = txtuserId.Text;
            newRow["Name"] = txtuName.Text;
            newRow["SurName"] = txtSurName.Text;
            newRow["Phone"] = txtPhone.Text;
            newRow["Email"] = txtEmail.Text;
            newRow["Gender"] = rblGender.Text;
            newRow["DOB"] = txtDOB.Text;
            newRow["City"] = ddlCities.Text;
            newRow["UAddress"] = txtAddress.Text;
            newRow["Qualification"] = txtQualification.Text;
            newRow["UPercentage"] = txtPercentage.Text;
            if (txtCertificates.HasFile)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + txtCertificates.FileName;
                string filePath = Server.MapPath("~/Uploads/" + fileName);
                txtCertificates.SaveAs(filePath);
                newRow["UCertificate"] = "~/Uploads/" + fileName;
            }
            newRow["Payment"] = txtPayment.Text;
            userDataTable.Rows.Add(newRow);
            GridView2.DataSource = userDataTable;
            GridView2.DataBind();
            ViewState["UserData"] = userDataTable;
        }


    }


}
