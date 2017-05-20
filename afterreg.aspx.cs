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

public partial class afterreg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlCommand cmd = new SqlCommand("select user_id,user_name,e_mail,password from newuser where user_id=@uu", con);
        string s = Session["userid"].ToString();
        cmd.Parameters.AddWithValue("@uu", s);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label3.Text = dr.GetValue(0).ToString();
            Label4.Text = dr.GetValue(1).ToString();
            Label5.Text = dr.GetValue(2).ToString();
            Label6.Text = dr.GetValue(3).ToString();
        }
        con.Close();

        DateTime dt = DateTime.Now;
        string p = dt.Day.ToString() + "\\" + dt.Month.ToString() + "\\" + dt.Year.ToString();
        Label7.Text = p;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

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

    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void LinkButton3_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
