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

public partial class CP : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox4.Text=Session["user"].ToString();
        TextBox4.Enabled = false;
        TextBox3.Focus();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else
            Response.Redirect("user.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s3 = TextBox1.Text.ToString();
        int k = s3.Length;
        if (TextBox1.Text.Trim() == "")
        {
            Label3.Text = "password cannot be blank";
            
            return;
        }
        if (k < 4)
        {
            Label3.Text = "minimum size of password is 4";
            TextBox1.Text = "";
            return;
        }
        
        if (k > 4)
        {
            if (TextBox1.Text == TextBox2.Text)
            {
                SqlCommand cmd;
                con.Open();
                cmd = new SqlCommand("update newuser set password=@pp where user_name=@uu", con);
                cmd.Parameters.AddWithValue("@uu", TextBox4.Text);
                cmd.Parameters.AddWithValue("@pp", TextBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Label2.Text = "Password Successfylly Changed";
                Panel1.Visible = false;
            }
            else
                Label2.Text = "Passwords Do not Match";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Focus();
        SqlCommand cmd = new SqlCommand("select user_name,password from newuser where user_name=@uu", con);
        cmd.Parameters.AddWithValue("@uu", TextBox4.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (TextBox3.Text == dr.GetValue(1).ToString())
            {
                Panel1.Visible = true;
                Label1.Visible = false;

            }
            else
                Label1.Text = "Invalid Password";
        }
        else
        {
            Label1.Text = "Invalid username";
        }

        con.Close();
    }
}
