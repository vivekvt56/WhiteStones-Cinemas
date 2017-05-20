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

public partial class AddHall : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    int n = 100;
    string s = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
        getmid();
        TextBox3.Enabled = false;
        TextBox7.Enabled = false;
    }

    protected void getmid()
    {
        SqlCommand cmd = new SqlCommand("select max(hall_id) from edit_hall", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            if (dr.GetValue(0).ToString() == "")
            {
                n = 101;
            }
            else
            {
                n = int.Parse(dr.GetValue(0).ToString());
                n++;
            }
        }
        con.Close();
        s = n.ToString();
        TextBox3.Text = TextBox7.Text = s;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into edit_hall values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)",con);
        cmd.Parameters.AddWithValue("@a1",TextBox3.Text);
        cmd.Parameters.AddWithValue("@a2", TextBox1.Text);
        cmd.Parameters.AddWithValue("@a3", TextBox2.Text);
        cmd.Parameters.AddWithValue("@a4", int.Parse(TextBox4.Text));
        cmd.Parameters.AddWithValue("@a5", DropDownList2.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@a6", int.Parse(TextBox6.Text));
        cmd.Parameters.AddWithValue("@a7", TextBox7.Text);
        cmd.Parameters.AddWithValue("@a8", DropDownList1.SelectedItem.ToString());
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label10.Text = "THEATRE ADDED SUCCESFULLY";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        //TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        DropDownList1.Items.Remove(DropDownList1.SelectedItem);
	    DropDownList2.Items.Remove(DropDownList2.SelectedItem);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Halls.aspx");
    }
}
