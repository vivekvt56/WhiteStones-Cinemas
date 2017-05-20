using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Income : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "BY DAY")
        {
            Label6.Visible = false;
            Label5.Visible = true;
            DropDownList2.Visible = true;
            DropDownList3.Visible = false;
            cmd = new SqlCommand("select distinct date from book_ticket",con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
                DropDownList2.Items.Add(dr.GetValue(0).ToString());
            con.Close();
        }
        else if (DropDownList1.SelectedItem.ToString() == "BY LOCATION")
        {
            Label6.Visible = true;
            Label5.Visible = false;
            DropDownList3.Visible = true;
            DropDownList2.Visible = false;
            cmd = new SqlCommand("select distinct city from book_ticket", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
                DropDownList3.Items.Add(dr.GetValue(0).ToString());
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["sel"].ToString() == "1")
        {
            cmd = new SqlCommand("select sum(fare) from book_ticket where date=@a1", con);
            cmd.Parameters.AddWithValue("@a1", DropDownList2.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label3.Visible = true;
                Label4.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }
        else if (Session["sel"].ToString() == "2")
        {
            cmd = new SqlCommand("select sum(fare) from book_ticket where city=@a1", con);
            cmd.Parameters.AddWithValue("@a1", DropDownList3.SelectedItem.ToString());
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label3.Visible = true;
                Label4.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Session["sel"] = "1";
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Button1.Visible = true;
        Session["sel"] = "2";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("total_cl.aspx");
    }
}
