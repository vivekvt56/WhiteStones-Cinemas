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
using System.IO;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=movie;Integrated Security=True;Pooling=False");
    int n = 0;

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected bool CheckDigit(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]) == false)
                return false;
        }
        return true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s3 = TextBox2.Text.Trim();
        int k = s3.Length;
        string sk = TextBox4.Text.Trim();
        int k1 = sk.Length;
        string si = TextBox6.Text.Trim();
        int ki = si.Length;
        string d = TextBox8.Text.Trim();
        int kd = d.Length;
        int j;

        if (TextBox2.Text.Trim() == "")
        {
            Label13.Text = "password cannot be blank";
            return;
        }
        if (k < 4)
        {
            Label13.Text = "minimum size of password is 4";
            TextBox2.Text = "";
            return;
        }
        if (TextBox1.Text.Trim() == "")
        {
            Label17.Text = "username cannot be blank";
            return;
        }
        if (TextBox3.Text.Trim() == "")
        {
            Label18.Text = " confirm password cannot be blank";
            return;
        }
        if (TextBox4.Text.Trim() == "")
        {
            Label14.Text = "e_mail cannot be blank";
            return;
        }
        if (TextBox5.Text.Trim() == "")
        {
            Label19.Text = "security answer cannot be blank";
            return;
        }
        if (TextBox6.Text.Trim() == "")
        {
            Label15.Text = "phone no. cannot be blank";
            return;
        }
        if (TextBox7.Text.Trim() == "")
        {
            Label20.Text = "city cannot be blank";
            return;
        }
        if (TextBox8.Text.Trim() == "")
        {
            Label16.Text = "age cannot be blank";
            return;
        }
        //for (j = 0; j < TextBox4.Text.Length; j++)
        {
            int n1 = sk.IndexOf('@');
            int n2 = sk.IndexOf('.');
            if (n1 < 0 && n2 < 0)
            {
                Label14.Text = "Incorrect E-mail format";
                return;
            }
        }

        

        if (CheckDigit(TextBox6.Text) == false)
        {
            Label15.Text = "enter numeric data only";
            return;
        }
        else
            Label15.Text = "ok";

        if (CheckDigit(TextBox8.Text) == false)
        {
            Label16.Text = "enter numeric data only";
            return;
        }
        else
            Label15.Text = "ok";

        if ((ki < 10) || (ki > 10))
        {
            Label15.Text = "Mobile no. must be of 10 character";
            return;
        }

            if (TextBox3.Text.Trim() != TextBox2.Text.Trim())
            {
                Label9.Text = "Confirm Password not matched";
            }
            //try
            {
                SqlCommand cmd = new SqlCommand("select max(user_id) from newuser", con);
                SqlDataReader dr;


                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    n = int.Parse(dr.GetValue(0).ToString());
                con.Close();
                n = n + 1;




                string img = TextBox1.Text + ".jpg";
                cmd = new SqlCommand("insert into newuser values (@uid,@un,@pwd,@img,@em,@sq,@sa,@mn,@cc,@ag,@ty) ", con);
                Label13.Visible = false;
                cmd.Parameters.AddWithValue("@uid", int.Parse(n.ToString()));
                cmd.Parameters.AddWithValue("@un", TextBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
                cmd.Parameters.AddWithValue("@img", img);
                cmd.Parameters.AddWithValue("@em", TextBox4.Text);
                cmd.Parameters.AddWithValue("@sq", DropDownList1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@sa", TextBox5.Text);
                cmd.Parameters.AddWithValue("@mn", int.Parse(TextBox6.Text));
                cmd.Parameters.AddWithValue("@cc", TextBox7.Text);
                cmd.Parameters.AddWithValue("@ag", int.Parse(TextBox8.Text));
                cmd.Parameters.AddWithValue("@ty", "user");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Session["userid"] = n.ToString();
                Response.Redirect("afterreg.aspx");
                Session["userid"] = null;
            }
            //catch
            {
                Label9.Text = "User Name Exixts Choose Another One";
            }

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select user_name from newuser where user_name=@a1", con);
        cmd.Parameters.AddWithValue("@a1", TextBox1.Text);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
            Label21.Text = "User Name is not Available";
        else
            Label21.Text = "User Name is Available";
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Image/") + TextBox1.Text + ".jpg");
            Session["ul"] = filename;
            Label23.Text = "Upload Status: File Uploaded!";
        }
    }
}
