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
using System.Web.Security;

public partial class forgotpwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }

    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select user_name,e_mail,sea_ques from newuser where user_name=@uu and e_mail=@ee", con);
        cmd.Parameters.AddWithValue("@uu", TextBox1.Text);
        cmd.Parameters.AddWithValue("@ee", TextBox2.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label3.Text = dr.GetValue(2).ToString();
            TextBox3.Visible = true;
            Button2.Visible = true;
        }
        else
            Label3.Text = "Invalid User";
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select * from  newuser where user_name=@u ", con);
        string s = TextBox1.Text;
        cmd.Parameters.AddWithValue("@u", s);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            if (dr.GetValue(5).ToString() == TextBox3.Text)
            {
                con.Close();
                string pwd = Membership.GeneratePassword(6, 0);
                Label4.Text = pwd;
            }
            else
            {
                Label4.Text = "Wrong Answer";
            }
        }
        dr.Close();
        con.Close();
        cmd = new SqlCommand("update newuser set password=@pp where user_name=@uu", con);
        cmd.Parameters.AddWithValue("@uu", TextBox1.Text);
        cmd.Parameters.AddWithValue("@pp", Label4.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void clear_Click(object sender, EventArgs e)
    {
        TextBox1.Text = TextBox2.Text = TextBox3.Text = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

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

    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Home.aspx");
        }
        else
            Response.Redirect("user.aspx");
    }
}
