using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devasthanam.views.Test
{
    public partial class GridViewAdd : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt.Columns.Add("userId", typeof(string));
                dt.Columns.Add("uName", typeof(string));
                dt.Columns.Add("SurName", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                ViewState["Records"] = dt;
                gvMultiInsert.DataSource = dt;
                gvMultiInsert.DataBind();
                dt.Rows[0].Delete();
            }
        }
        public void gvMultiInsert_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (!IsPostBack)
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    if (e.Row.RowIndex == 0)
                    {
                        e.Row.Visible = false;
                    }
                }
            }
        }
        public void Gv_Submit(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_data"].ConnectionString);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "InsertGridViewData";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sP = new SqlParameter();
                sP.ParameterName = "@GridViewData";
                sP.Value = ViewState["Records"] as DataTable;
                cmd.Parameters.Add(sP);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert",
                       "alert('Data submitted successfully.');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert",
                       "alert('Failed to submit data.');", true);
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert",
                   $"alert('Error: {ex.Message}');", true);
            }

        }
        public void Gv_row_Delete(object sender, EventArgs e)
        {
            Button state = sender as Button;
            GridViewRow gr = state.NamingContainer as GridViewRow;
            Label userId = gr.FindControl("lbluserId") as Label;
            Label Name = gr.FindControl("lblfname") as Label;
            Label SurName = gr.FindControl("lblSurName") as Label;
            Label Phone = gr.FindControl("lblPhone") as Label;
            int rowindex = gr.DataItemIndex;
            DataTable dt3 = ViewState["Records"] as DataTable;
            dt3.Rows.RemoveAt(rowindex);
            ViewState["Records"] = dt3;
            gvMultiInsert.DataSource = ViewState["Records"];
            gvMultiInsert.DataBind();

        }
        public void Gv_NewRow(object sender, EventArgs e)
        {
            GridViewRow gr = gvMultiInsert.FooterRow;
            TextBox userId = gr.FindControl("txtuserId") as TextBox;
            TextBox Name = gr.FindControl("txtName") as TextBox;
            TextBox SurName = gr.FindControl("txtSurName") as TextBox;
            TextBox Phone = gr.FindControl("txtPhone") as TextBox;
            if (IsPhoneExists(Phone.Text))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert",
                    "alert('Phone number already exists.');", true);
                return;
            }
            if (string.IsNullOrEmpty(userId.Text) || string.IsNullOrEmpty(Name.Text) ||
                    string.IsNullOrEmpty(SurName.Text) || string.IsNullOrEmpty(Phone.Text))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert",
                    "alert('Please fill in all fields.');", true);
            }
            else
            {
                DataRow dr = dt.NewRow();
                DataTable dt1 = ViewState["Records"] as DataTable;

                dt1.Rows.Add(userId.Text, Name.Text, SurName.Text, Phone.Text);
                gvMultiInsert.DataSource = dt1;
                gvMultiInsert.DataBind();
            }
        }
        public bool IsPhoneExists(string phoneNumber)
        {
            DataTable dtRecords = ViewState["Records"] as DataTable;

            foreach (DataRow row in dtRecords.Rows)
            {
                if (row["Phone"].ToString() == phoneNumber)
                {
                    return true;
                }
            }
            return false;
        }
     
 
         
    }
}





 
