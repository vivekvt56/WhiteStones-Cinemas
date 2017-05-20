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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }

    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\DB\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cc.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgotpwd.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label3.Text = TextBox2.Text;
        SqlCommand cmd = new SqlCommand("select user_name,password,type from newuser where user_name=@uu", con);
        cmd.Parameters.AddWithValue("@uu", TextBox1.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        Label3.Text = TextBox2.Text;
        if (dr.Read())
        {
            
            if (TextBox2.Text == dr.GetValue(1).ToString())
            {
                //Label3.Text = "Login Succeeded";
                if (dr.GetValue(2).ToString() == "Admin")
                {
                    Session["admin"] = TextBox1.Text;
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Session["user"] = TextBox1.Text;
                    Response.Redirect("user.aspx");
                }
            }
            else
            {
                Label3.Text = "Invalid password";
            }
        }
        else
        {
            Label3.Text = "Invalid username";
        }

        con.Close();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
