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

public partial class Ccl_ticket : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    int bd,n;
    float fr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bd = int.Parse(Session["bid"].ToString());
            da = new SqlDataAdapter("select * from view4 where b_id=+'" + bd + "'", con);
            ds = new DataSet();
            da.Fill(ds, "book");
            DataTable dt = ds.Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            fr = float.Parse(Session["fare"].ToString());
            TextBox1.Text = (fr / 2).ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select max(c_id) from cancel_tkt", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            if (dr.GetValue(0).ToString() == "")
            {
                n = 601;
            }
            else
            {
                n = int.Parse(dr.GetValue(0).ToString());
                n++;
            }
        }
        con.Close();
        cmd = new SqlCommand("insert into cancel_tkt values(@t1,@t2,@t3,@t4,@t5)",con);
        cmd.Parameters.AddWithValue("@t1", n);
        cmd.Parameters.AddWithValue("@t2", int.Parse(Session["bid"].ToString()));
        cmd.Parameters.AddWithValue("@t3", int.Parse(Session["hid"].ToString()));
        cmd.Parameters.AddWithValue("@t4", Session["user"].ToString());
        cmd.Parameters.AddWithValue("@t5", float.Parse(TextBox1.Text));
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        cmd = new SqlCommand("delete from book_ticket where b_id=@a1",con);
        cmd.Parameters.AddWithValue("@a1", int.Parse(Session["bid"].ToString()));
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label3.Text = "Your Ticket has been cancelled";
        Label4.Visible = true;
        Label5.Visible = true;
        TextBox2.Visible = true;
        TextBox2.Text = TextBox1.Text;
        Label6.Text = n.ToString();
        Session["bid"]=null;
        Session["hid"] = null;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("book_his.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
}
