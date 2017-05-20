using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["city"] == null)
        //{
            TextBox1.Text = "Search Movies";
            TextBox1.Focus();
        //}
        //else
        //{
        //    TextBox1.Text = "Search Movies";
        //    TextBox1.Focus();
        //    Label1.Text = DropDownList1.SelectedItem.ToString();
        //}
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            //Response.Redirect("Home.aspx");
            Label2.Text = "Please LOGIN To Continue...";
        }
        else
            Response.Redirect("Book.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cc.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "SELECT")
        {
            Label1.Text = "";

            
        }
        else
        {
            Label1.Text = DropDownList1.SelectedItem.ToString();
            DropDownList1.Text = DropDownList1.SelectedItem.ToString();

            Session["city"] = Label1.Text;
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Movies.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            //Response.Redirect("Home.aspx");
            Label2.Text = "Please LOGIN To Continue...";
        }
        else
            Response.Redirect("myaccount.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //if(Session["city"]==null)
            Response.Redirect("Home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //if (TextBox1.Text == "SEARCH")
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
}
