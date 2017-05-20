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


public partial class viewfeed : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        getdata();
        binddata();
    }

    
    protected void getdata()
    {
       // string s = DropDownList1.SelectedItem.ToString();
        da = new SqlDataAdapter("select * from feedback"  , con);
        ds = new DataSet();
        da.Fill(ds, "new");
        //SqlCommandBuilder scbd = new SqlCommandBuilder(da);
        Session["da"] = da;
        Session["dt"] = ds.Tables[0];

    }
    protected void binddata()
    {
        DataTable dt = (DataTable)Session["dt"];
        GridView1.DataSource = dt; ;
        GridView1.DataBind();

    }

    }

