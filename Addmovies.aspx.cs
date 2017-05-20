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
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

public partial class Addmovies : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    int n = 0;
    string s = null;
    DateTime dt = new DateTime();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label13.Text = "";
        TextBox1.Focus();
        getmid();
        TextBox7.Enabled = false;
    }

    protected void getmid()
    {
        SqlCommand cmd = new SqlCommand("select max(m_id) from purchase_movies", con);
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
                s = dr.GetValue(0).ToString();
                n = int.Parse(s.Substring(1, 3));
                n++;
            }
        }
        con.Close();
        s = "M" + n.ToString();
        TextBox7.Text = s;
    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into purchase_movies values(@mi,@mn,@md,@im,@pd,@pa)", con);
        float mpa = float.Parse(TextBox5.Text);
        string mmd = TextBox3.Text;
        string mmn = TextBox1.Text;
        string mmi = TextBox7.Text;
        string img=Session["ul"].ToString();
        cmd.Parameters.AddWithValue("@mi", mmi);
        cmd.Parameters.AddWithValue("@mn", mmn);
        cmd.Parameters.AddWithValue("@md", mmd);
        cmd.Parameters.AddWithValue("@im", img);
        DateTime dt1=(DateTime)Session["dt"];
        cmd.Parameters.AddWithValue("@pd", dt1.ToShortDateString());
        cmd.Parameters.AddWithValue("@pa", mpa);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label11.Visible = true;
        Label11.Text = "MOVIE ADDED SUCCESSFULLY";
        TextBox1.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        getmid();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
    
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Image/") + TextBox1.Text + ".jpg");
            Session["ul"] = filename;
            Label13.Text = "Upload Status: File Uploaded!";
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        dt = Calendar1.SelectedDate;
        TextBox4.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
        Session["dt"] = dt;
        Calendar1.Visible = false;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editmovies.aspx");
    }
}