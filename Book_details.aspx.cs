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

public partial class Book_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds=new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        string s = Session["bid"].ToString();
        da = new SqlDataAdapter("select * from view4 where b_id='"+s+"'",con);
        da.Fill(ds,"m");
        DataTable dt = ds.Tables[0];
        GridView1.DataSource = dt;
        GridView1.DataBind();
        TextBox1.Text = dt.Rows[0][9].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
}
