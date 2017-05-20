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

public partial class Movieupdate : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\DB\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;

    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Focus();
        if (IsPostBack == false)
        {
            DropDownList1.Items.Add("Select");
            SqlCommand cmd = new SqlCommand("select m_id from purchase_movies", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetValue(0).ToString());
            }
            con.Close();
        }
    }
    protected void GetData()
    {
        string s = DropDownList1.SelectedItem.ToString();
        da = new SqlDataAdapter("select * from purchase_movies where m_id='" + s + "'", con);
        ds = new DataSet();
        da.Fill(ds, "mov");
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

    protected void imgdata()
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            GridViewRow dr = GridView1.Rows[i];
            Label l = (Label)dr.FindControl("Label1");
            Image img = (Image)dr.FindControl("Image1");
            string ss = "image/" + l.Text + ".jpg";
            img.ImageUrl = ss;
            img.Height = 100;
            img.Width = 100;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
        BindData();
        imgdata();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindData();
        imgdata();
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
        imgdata();
        Label5.Text = "MOVIE DETAILS DELETED";
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int r = e.RowIndex;
        DataTable dt = (DataTable)Session["dt"];
        TextBox t = (TextBox)GridView1.Rows[r].FindControl("TextBox3");
        dt.Rows[r][4] = t.Text;
        t = (TextBox)GridView1.Rows[r].FindControl("TextBox2");
        dt.Rows[r][2] = t.Text;
        t = (TextBox)GridView1.Rows[r].FindControl("TextBox1");
        dt.Rows[r][1] = t.Text;
        t = (TextBox)GridView1.Rows[r].FindControl("TextBox4");
        float t2 = float.Parse(t.Text);
        dt.Rows[r][5] = t2;
        SqlDataAdapter daa = (SqlDataAdapter)Session["da"];
        daa.Update(dt);
        GetData();
        GridView1.EditIndex = -1;
        BindData();
        imgdata();
        Label5.Text = "MOVIE DETAILS UPDATED";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editmovies.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }
}
