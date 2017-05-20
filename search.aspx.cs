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

public partial class search : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da=new SqlDataAdapter();
        //Label5.Text = Session["search1"].ToString();
       // Label6.Text = Session["search2"].ToString();
        if (Session["search1"]!=null && Session["search2"]==null)
        {
            string s1 = Session["search1"].ToString();
            da = new SqlDataAdapter("select * from view2 where m_name='" + s1 + "'", con);
        }
        if (Session["search1"] == null && Session["search2"]!=null)
        {
            string s2 = Session["search2"].ToString();
            da = new SqlDataAdapter("select * from view2 where date='" + s2 + "'", con);
        }
        if (Session["search1"]!=null && Session["search2"]!=null)
        {
            string s1 = Session["search1"].ToString();
            string s2 = Session["search2"].ToString();
            da = new SqlDataAdapter("select * from view2 where m_name='" + s1 + "' and date='" + s2 + "'", con);
        }
        if (Session["search1"]== null && Session["search2"] == null)
        {
            string s1 = Session["search1"].ToString();
            string s2 = Session["search2"].ToString();
            da = new SqlDataAdapter("select * from view2 ", con);
        }
        DataSet ds = new DataSet();
        da.Fill(ds, "new");
        DataTable dt = ds.Tables[0];
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
