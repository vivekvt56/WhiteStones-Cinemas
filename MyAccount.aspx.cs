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

public partial class Account : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            LinkButton6.Visible = true;
            Label1.Text = "WelCome     ";
            LinkButton6.Text = Session["user"].ToString();
        }
        else
            //Label1.Text = "";
            Response.Redirect("error.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {

            Response.Redirect("Home.aspx");

        }
        else
        {
            Response.Redirect("user.aspx");

        } 
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("book_his.aspx");
    }
     protected void LinkButton4_Click(object sender, EventArgs e)
     {
         Panel1.Visible = true;
         TextBox1.Text = Session["user"].ToString();
         SqlCommand cmd = new SqlCommand("select * from newuser where user_name=@uu", con);
         string s = TextBox1.Text;
         cmd.Parameters.AddWithValue("@uu", s);
         SqlDataReader dr;
         con.Open();
         dr = cmd.ExecuteReader();
         if (dr.Read() == true)
         {
             TextBox2.Text = dr.GetValue(3).ToString();
             TextBox3.Text = dr.GetValue(6).ToString();
             TextBox4.Text = dr.GetValue(7).ToString();
         }
         con.Close();
         Button1.Visible = true;
         //TextBox1.Enabled = true;
         TextBox2.Enabled = true;
         TextBox3.Enabled = true;
         TextBox4.Enabled = true;
     }
     protected void LinkButton5_Click(object sender, EventArgs e)
     {
         if (Session["user"] == null)
             Response.Redirect("error.aspx");
         else
             Response.Redirect("CP.aspx");
     }
     protected void LinkButton3_Click(object sender, EventArgs e)
     {
         if (Session["user"] != null)
         {
             Session["user"] = null;
             Label1.Text = "";
             Response.Redirect("Home.aspx");
         }


     }
     protected void Button1_Click(object sender, EventArgs e)
     {
         SqlCommand cmd = new SqlCommand("update newuser set e_mail=@e,mobile_no=@m,city=@c where user_name=@uu", con);
            cmd.Parameters.AddWithValue("@uu", TextBox1.Text);
            cmd.Parameters.AddWithValue("@e", TextBox2.Text);
            cmd.Parameters.AddWithValue("@m", TextBox3.Text);
            cmd.Parameters.AddWithValue("@c", TextBox4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.Text = "your profile is up to date";
            Button1.Visible = false;
            //TextBox1.Enabled = true;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            //Panel1.Visible = false;

     }
     protected void LinkButton6_Click(object sender, EventArgs e)
     {
         if (Session["user"] == null)
             Response.Redirect("error.aspx");
         else
         {
             Panel1.Visible = true;
             Label2.Text = "";
             TextBox1.Text = Session["user"].ToString();
             SqlCommand cmd = new SqlCommand("select * from newuser where user_name=@uu", con);
             string s = TextBox1.Text;
             cmd.Parameters.AddWithValue("@uu", s);
             SqlDataReader dr;
             con.Open();
             dr = cmd.ExecuteReader();
             if (dr.Read() == true)
             {
                 TextBox2.Text = dr.GetValue(3).ToString();
                 TextBox3.Text = dr.GetValue(6).ToString();
                 TextBox4.Text = dr.GetValue(7).ToString();
             }
             con.Close();
         }
            
         
     }
}
