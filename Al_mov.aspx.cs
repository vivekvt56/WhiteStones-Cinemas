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

public partial class Al_mov : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\db\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    DataSet ds;
    DateTime dtt = new DateTime();
    int n = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Focus();
        if (IsPostBack == false)
        {
            DropDownList1.Items.Add("Select");
            SqlCommand cmd = new SqlCommand("select distinct m_id from purchase_movies", con);
            SqlDataReader dr;
            ////con.Open();
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    DropDownList1.Items.Add(dr.GetValue(0).ToString());
            //}
            ////con.Close();
        }
    }
   protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s = DropDownList1.SelectedItem.ToString();
        da = new SqlDataAdapter("select m_name,details,image from purchase_movies where m_id='" + s + "'", con);
        ds = new DataSet();
        da.Fill(ds, "stud");
        DataTable dt = ds.Tables[0]; ;
        GridView1.DataSource = dt;
        GridView1.DataBind();
        imgdata();
    }
   protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
   {
       Calendar1.Visible = true;
   }
   protected void Calendar1_SelectionChanged(object sender, EventArgs e)
   {
       dtt = Calendar1.SelectedDate;
       TextBox3.Text = dtt.Day + "/" + dtt.Month + "/" + dtt.Year;
       Calendar1.Visible = false;
   }
   protected void Button1_Click(object sender, EventArgs e)
   {
       da = new SqlDataAdapter("select * from purchase_movies where m_id='"+DropDownList1.Text+"'",con);
       ds = new DataSet();
       da.Fill(ds, "new");
       DataTable dt = ds.Tables[0]; ;
       GridView2.DataSource = dt;
       GridView2.DataBind();
   }

   protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
   {
       
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

   protected void Button2_Click(object sender, EventArgs e)
   {
       Label15.Text = "";
       for (int i = 0; i < GridView2.Rows.Count; i++)
       {
           GridViewRow dr = GridView2.Rows[i];
           CheckBox ch = (CheckBox)dr.FindControl("CheckBox1");
           if (ch.Checked == true)
           {
               DropDownList dl1 = (DropDownList)dr.FindControl("DropDownList8");
               DropDownList dl2 = (DropDownList)dr.FindControl("DropDownList7");
               DropDownList dl3 = (DropDownList)dr.FindControl("DropDownList9");
               if ((dl1.Text == "SELECT") || (dl2.Text == "SELECT") || (dl3.Text == "0"))
               {
                   Label15.Text = "Unselected Fields!! Please Select All Fields";
                   return;
               }
               SqlCommand cmd = new SqlCommand("select al_id from al_mov where hall_id=@a1 and slot=@a2 and date=@a3", con);
               cmd.Parameters.AddWithValue("@a1",int.Parse(dl1.Text));
               cmd.Parameters.AddWithValue("@a2", dl2.Text);
               cmd.Parameters.AddWithValue("@a3", dtt.ToShortDateString());
               con.Open();
               SqlDataReader drr = cmd.ExecuteReader();
               if (drr.Read())
               {
                   Label15.Text = "Movie is already allocated at selected Hall and Slot";
                   return;
               }
               con.Close();
               cmd = new SqlCommand("select max(al_id) from al_mov", con);
               con.Open();
               drr = cmd.ExecuteReader();
               if (drr.Read() == true)
               {
                   if (drr.GetValue(0).ToString() == "")
                   {
                       n = 201;
                   }
                   else
                   {
                       n = int.Parse(drr.GetValue(0).ToString());
                       n++;
                   }
               }
               con.Close();
               Label l1 = (Label)dr.FindControl("Label2");
               cmd = new SqlCommand("insert into al_mov values(@a1,@a2,@a3,@a4,@a5,@a6)", con);
               cmd.Parameters.AddWithValue("@a1", l1.Text);
               DropDownList d1 = (DropDownList)dr.FindControl("DropDownList8");
               cmd.Parameters.AddWithValue("@a2", d1.SelectedItem.ToString());
               d1 = (DropDownList)dr.FindControl("DropDownList7");
               cmd.Parameters.AddWithValue("@a3", d1.SelectedItem.ToString());
               cmd.Parameters.AddWithValue("@a4", dtt.ToShortDateString());
               d1 = (DropDownList)dr.FindControl("DropDownList9");
               cmd.Parameters.AddWithValue("@a5", float.Parse(d1.SelectedItem.ToString()));
               cmd.Parameters.AddWithValue("@a6",n);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               Label14.Text = "MOVIE ALLOCATED SUCCESSFULLY";
           }
       }
   }
   protected void LinkButton1_Click(object sender, EventArgs e)
   {
       Response.Redirect("MoviesAlloc.aspx");
   }
   protected void LinkButton2_Click(object sender, EventArgs e)
   {
       Response.Redirect("Admin.aspx");
   }
}
