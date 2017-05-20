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

public partial class Payment : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    int n = 0;

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select max(b_id) from book_ticket", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            if (dr.GetValue(0).ToString() == "")
            {
                n = 501;
            }
            else
            {
                n = int.Parse(dr.GetValue(0).ToString());
                n++;
            }
        }
        con.Close();
        string s1 = Session["user"].ToString();
        string s2 = Session["hid"].ToString();
        string s3 = Session["city"].ToString();
        string s4 = Session["date"].ToString();
        string s5 = Session["mid"].ToString();
        string s6 = Session["slot"].ToString();
        DateTime dt = DateTime.Now;
        int fr=int.Parse(Session["fare"].ToString());
        fr = fr * (int.Parse(Session["nos"].ToString()));
        string s7 = fr.ToString();
        string s8 = Session["ns"].ToString();

        cmd = new SqlCommand("insert into book_ticket values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)",con);
        cmd.Parameters.AddWithValue("@a1", n.ToString());
        cmd.Parameters.AddWithValue("@a2", s1.ToString());
        cmd.Parameters.AddWithValue("@a3", s2.ToString());
        cmd.Parameters.AddWithValue("@a4", s3.ToString());
        cmd.Parameters.AddWithValue("@a5", s4);
        cmd.Parameters.AddWithValue("@a6", s5.ToString());
        cmd.Parameters.AddWithValue("@a7", s6);
        cmd.Parameters.AddWithValue("@a8", dt);
        cmd.Parameters.AddWithValue("@a9", s7);
        cmd.Parameters.AddWithValue("@a10", s8);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Session["hid"] = null;
        Session["mid"] = null;
        Session["city"] = null;
        Session["date"] = null;
        Session["fare"] = null;
        Session["ns"] = null;
        Session["slot"] = null;
        Session["bid"]=n.ToString();
        Response.Redirect("Book_details.aspx");
    }
}
