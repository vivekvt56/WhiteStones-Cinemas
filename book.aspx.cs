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


public partial class book : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    DateTime dtt = new DateTime();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        DropDownList2.Focus();
        if (IsPostBack == false)
        {
            DropDownList1.Items.Add("Select");
            DropDownList2.Items.Add("Select");
            SqlCommand cmd = new SqlCommand("select distinct city from view1 ", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList2.Items.Add(dr.GetValue(0).ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select distinct m_name from view1",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label7.Text = "";
        string s1 = DropDownList2.SelectedItem.ToString();
        string s2 = DropDownList1.SelectedItem.ToString();
        da = new SqlDataAdapter("select * from view3 where city='" + s1 + "' and m_name='" + s2 + "'", con);
        ds = new DataSet();
        da.Fill(ds, "new");
        DataTable dt = ds.Tables[0];
        GridView1.DataSource = dt;
        GridView1.DataBind();
        if(dt.Rows.Count==0)
            Label7.Text = "SORRY...MOVIE NOT AVAILABLE IN SELECTED LOCATION. CHOOSE A DIFFERENT COMBINATION";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["city"] = DropDownList2.SelectedItem.ToString();
        Label9.Text = "PLEASE SELECT A COMBINATION FIRST";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridViewRow dr = GridView1.Rows[i];
                CheckBox ch = (CheckBox)dr.FindControl("CheckBox1");
                if (ch.Checked == true)
                {
                    Label l1 = (Label)dr.FindControl("Label1");
                    Session["mid"] = l1.Text;
                    l1 = (Label)dr.FindControl("Label3");
                    Session["hid"] = l1.Text;
                    l1 = (Label)dr.FindControl("Label4");
                    Session["date"] = l1.Text;
                    l1 = (Label)dr.FindControl("Label6");
                    Session["slot"] = l1.Text;
                    Label l2 = (Label)dr.FindControl("Label2");
                    DropDownList dw = (DropDownList)dr.FindControl("DropDownList3");
                    Session["nos"] = dw.SelectedItem.ToString();
                    Session["nosel"] = null;
                    Session["ns"] = null;
                    l1 = (Label)dr.FindControl("Label5");
                    Session["fare"] = l1.Text;
                    if (l2.Text == "EYLEX1")
                        Response.Redirect("seatlayout1.aspx");
                    else
                        Response.Redirect("seatlayout2.aspx");
                }
            }
            Session["ns"] = null;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
}



