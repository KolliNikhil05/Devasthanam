using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace DataBind.views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    list();
        //}

        //public void list()
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_people"].ConnectionString);
        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "dropdown";
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ad.Fill(ds);
        //    drd.DataSource = ds.Tables[0];
        //    drd.DataTextField = ds.Tables[0].Columns["Name"].ColumnName.ToString();
        //    drd.DataBind();
        //    con.Close();
        //}

        //protected void drd_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedValue = drd.SelectedValue;
        //}

        //protected void button_click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_people"].ConnectionString);
        //        con.Open();
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandText = "getdata";
        //        cmd.Parameters.AddWithValue("@TheId", textbox1.Text);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //        textbox2.Text = dt.Rows[0]["Name"].ToString();
        //        textbox3.Text = dt.Rows[0]["Address"].ToString();
        //    }

        //    catch(Exception ex) 
        //    {
        //        lblException.Text = ex.Message;
        //    }

        //}


        protected void button_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection_people"].ConnectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insertdata";
            cmd.Parameters.AddWithValue("@Id", textbox1.Text);
            cmd.Parameters.AddWithValue("@Name", textbox2.Text);
            cmd.Parameters.AddWithValue("@Address", textbox3.Text);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}



