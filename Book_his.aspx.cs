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

public partial class Book_his : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\DB\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    int h;
    string s;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            s = Session["user"].ToString();
            da = new SqlDataAdapter("select * from view4 where user_name=+'" + s + "'", con);
            ds = new DataSet();
            da.Fill(ds, "book");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                Label10.Text = "YOU HAVE NOT BOOKED ANY TICKET";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
            }
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
    protected void MyRadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow oldrow in GridView1.Rows)
        {
            ((RadioButton)oldrow.FindControl("MyRadioButton1")).Checked = false;

        }

        //Set the new selected row
        RadioButton rb = (RadioButton)sender;
        GridViewRow row = (GridViewRow)rb.NamingContainer;
        ((RadioButton)row.FindControl("MyRadioButton1")).Checked = true;
        Button1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            
            string dt="";
            GridViewRow dr = GridView1.Rows[i];
                
            RadioButton rb = new RadioButton();
            rb = (RadioButton)dr.FindControl("MyRadioButton1");
            if (rb.Checked == true)
            {
                Label l1 = (Label)dr.FindControl("Label1");
                int s1 = int.Parse(l1.Text);
                s = Session["user"].ToString();
                int n = s.Length;
                SqlCommand cmd = new SqlCommand("select date from view4 where user_name=@a1 and b_id=@a2", con);
                cmd.Parameters.AddWithValue("@a1",s);
                cmd.Parameters.AddWithValue("@a2", s1);
                con.Open();
                SqlDataReader drr = cmd.ExecuteReader();
                if (drr.Read())
                    dt = drr.GetValue(0).ToString();
                con.Close();
                
                string sb1 = "", sb2 = "", sb3 = "";
                int pos = 0;
                sb1 = dt.Substring(pos, 2);
                dt = dt.Substring(2 + 1);
                sb2 = dt.Substring(pos, 2);
                dt = dt.Substring(2 + 1);
                sb3 = dt.Substring(pos, 4);
                Label10.Text = sb1 + "//" + sb2 + "//" + sb3;

                DateTime dt1 = new DateTime(int.Parse(sb3), int.Parse(sb2), int.Parse(sb1));
                DateTime dt2 = DateTime.Now;
                TimeSpan ts;
                ts = dt2 - dt1;
                int ds = ts.Days;
                Label10.Text = ds.ToString();
                if (ds > 0)
                {
                    Label10.Text = "date has been passed";
                    return; 
                }
                l1 = (Label)dr.FindControl("Label1");
                Session["bid"] = l1.Text;
                l1 = (Label)dr.FindControl("Label8");
                Session["fare"] = l1.Text;
                l1 = (Label)dr.FindControl("Label7");
                Session["hid"] = l1.Text;
            }
        }
        Response.Redirect("Ccl_ticket.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyAccount.aspx");
    }
}
