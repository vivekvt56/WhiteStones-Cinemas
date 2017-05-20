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

public partial class Default2 : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;

     protected void Page_Load(object sender, EventArgs e)
     {
         DropDownList1.Focus();
         if (IsPostBack == false)
         {
             SqlCommand cmd = new SqlCommand("SELECT hall_id FROM edit_hall", con);
             SqlDataReader dr;
             con.Open();
             dr = cmd.ExecuteReader();
             while (dr.Read() == true)
             {
                 DropDownList1.Items.Add(dr.GetValue(0).ToString());
             }

             con.Close();
         }
     }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        getdata();
        binddata();
    }
    protected void getdata()
    {    
        string s = DropDownList1.SelectedItem.ToString();
        da = new SqlDataAdapter("select * from edit_hall where hall_id='" + s + "'", con);
        ds = new DataSet();
        da.Fill(ds, "new");
        SqlCommandBuilder scbd = new SqlCommandBuilder(da);
        Session["da"] = da;
        Session["dt"] = ds.Tables[0];
    }
    protected void binddata()
    {
        DataTable dt = (DataTable)Session["dt"];
        GridView2.DataSource = dt; ;
        GridView2.DataBind();
    }

    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView2.EditIndex = e.NewEditIndex;//event neweditindex bataega ki kaun sa textbox main click kiye hai
        binddata();
    }
    protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView2.EditIndex = -1;//is liye kiye kyunki aisa row select karo jo wxist hi nae karta hai 
        binddata();
    }
    protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int r = e.RowIndex;
        DataTable dt = (DataTable)Session["dt"];
        TextBox t = (TextBox)GridView2.Rows[r].FindControl("TextBox3");
        int tt = int.Parse(t.Text);
        dt.Rows[r][3] = tt;
        t = (TextBox)GridView2.Rows[r].FindControl("TextBox4");
        string p = t.Text;
        dt.Rows[r][4] = p;
        t = (TextBox)GridView2.Rows[r].FindControl("TextBox5");
        int ttt = int.Parse(t.Text);
        dt.Rows[r][5] = ttt;
        t = (TextBox)GridView2.Rows[r].FindControl("TextBox6");
        string tts = t.Text;
        dt.Rows[r][6] = tts;

        SqlDataAdapter daa = (SqlDataAdapter)Session["da"];
        daa.Update(dt);
        getdata();
        GridView2.EditIndex = -1;
        binddata();
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int r = e.RowIndex;
        DataTable dt = (DataTable)Session["dt"];
        dt.Rows[r].Delete();
        SqlDataAdapter daa = (SqlDataAdapter)Session["da"];
        daa.Update(dt);
        getdata();
        binddata();
        DropDownList1.Items.Remove(DropDownList1.SelectedItem);
        //DropDownList1.Text = "Select";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Halls.aspx");
    }
}