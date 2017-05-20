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

public partial class Al_mov_up : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DropDownList2.Items.Add("Select");
            SqlCommand cmd = new SqlCommand("select distinct m_id from al_mov", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList2.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();
        }

    }

    protected void GetData()
    {
        string s = DropDownList2.SelectedItem.ToString();
        da = new SqlDataAdapter("select * from al_mov where m_id='" + s + "'", con);
        ds = new DataSet();
        da.Fill(ds, "stud");
        SqlCommandBuilder scbd = new SqlCommandBuilder(da);
        Session["da"] = da;
        Session["dt"] = ds.Tables[0];
    }
    protected void BindData()
    {
        DataTable dt = (DataTable)Session["dt"];
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
        BindData();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
       Response.Redirect("MoviesAlloc.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int r = e.RowIndex;
        DataTable dt = (DataTable)Session["dt"];
        dt.Rows[r].Delete();
        SqlDataAdapter daa = (SqlDataAdapter)Session["da"];
        daa.Update(dt);
        GetData();
        BindData();
    }
}
