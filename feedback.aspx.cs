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


public partial class feedback : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = ""; 
        TextBox4.Text = "";
        Label5.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label5.Visible = true;
        string s3 = TextBox2.Text.ToString();
        int k = s3.Length;
        int j;
        if (TextBox1.Text.Trim() == "")
        {
            Label6.Text = "user name cannot be blank";
            return;
        }
        if (TextBox2.Text.Trim() == "")
        {
            Label7.Text = "e_mail cannot be blank";
            return;
        }
        if (TextBox3.Text.Trim() == "")
        {
            Label8.Text = "subject cannot be blank";
            return;
        }
        for (j = 0; j < k; j++)
        {
            char ch = s3[j];
            if (ch != '@')
            {
                continue;


            }
            else if (ch == '@')
            {
                break;
            }
        }

        if (j == k)
        {
            Label7.Text = "incorrect e_mail format";
            TextBox2.Text = "";
            return;
        }
        SqlCommand cmd = new SqlCommand("select max(f_id) from feedback", con);
        con.Open();
        int n=0;
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            if (dr.GetValue(0).ToString() == "")
            {
                n = 10;
            }
            else
            {
                n = int.Parse(dr.GetValue(0).ToString());
                n++;
            }
        }
        con.Close();


        cmd = new SqlCommand("insert into feedback  values (@ff,@ss,@oo,@yy,@zz) ", con);
        Label5.Visible = true;
        cmd.Parameters.AddWithValue("@ss", TextBox1.Text);
        cmd.Parameters.AddWithValue("@oo", TextBox2.Text);
        cmd.Parameters.AddWithValue("@yy", TextBox3.Text);
        cmd.Parameters.AddWithValue("@zz",TextBox4.Text );
        cmd.Parameters.AddWithValue("@ff", n);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {

    }
}
