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

public partial class user : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (CheckBox2.Checked == false)
                TextBox1.Enabled = false;
            if (CheckBox1.Checked == true)
                DropDownList2.Enabled = false;
            LinkButton10.Text = Session["user"].ToString();
            //TextBox1.Text = "Search Movies";
            //TextBox1.Focus();
            SqlCommand cmd = new SqlCommand("select image from newuser where user_name=@u1",con);
            cmd.Parameters.AddWithValue("@u1",Session["user"].ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetValue(0).ToString()!="")
                    ImageButton1.ImageUrl = "~/Image/" + dr.GetValue(0).ToString();
                else
                    ImageButton1.ImageUrl = "Image/default_img.jpg";
            }
            con.Close();
        }
        else
            Response.Redirect("error.aspx");

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("cc.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("Movies.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("Book.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("About.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Session["user"] = null;
            Response.Redirect("Home.aspx");
        }
        else
            Response.Redirect("error.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
        {
            if (DropDownList1.SelectedItem.ToString() == "SELECT")
            {
                Label1.Text = "";

                //Session["a"]=Label1.Text;
            }
            else
            {
                Label1.Text = DropDownList1.SelectedItem.ToString();
                DropDownList1.Text = "SELECT";

                //Session["a"]=DropDownList1.SelectedItem.ToString();
            }
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        if(Session["user"]==null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("MyAccount.aspx");

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("error.aspx");
        else
            Response.Redirect("MyAccount.aspx");

        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)
            Session["search1"] = TextBox1.Text;
        if (CheckBox1.Checked == true)
            Session["search2"] = DropDownList2.SelectedItem.ToString();
        Response.Redirect("SEARCH.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "SELECT")
        {
            Label1.Text = "";
        }
        else
        {
            Label1.Text = DropDownList1.SelectedItem.ToString();
            DropDownList1.Text = DropDownList1.SelectedItem.ToString();
        }
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("feedback.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == false)
            TextBox1.Enabled = false;
        else
            TextBox1.Enabled = true;
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
            DropDownList2.Enabled = false;
        else
        {
            DropDownList2.Enabled = true;
            SqlCommand cmd = new SqlCommand("select distinct date from al_mov", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                DropDownList2.Items.Add(dr.GetValue(0).ToString());
            con.Close();
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
