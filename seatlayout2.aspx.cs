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

public partial class seatlayout2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\DB\\multiplex2.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    string s, un = "";
    int n;

    protected void Page_Load(object sender, EventArgs e)
    {
        s = "";
        n = 0;
        string s1 = Session["mid"].ToString();
        string s2 = Session["hid"].ToString();
        string s3 = Session["date"].ToString();
        string s4 = Session["slot"].ToString();

        SqlCommand cmd = new SqlCommand("select seats from book_ticket where hall_id=@a1 and m_id=@a2 and date=@a3 and slot=@a4", con);
        cmd.Parameters.AddWithValue("@a1", s2);
        cmd.Parameters.AddWithValue("@a2", s1);
        cmd.Parameters.AddWithValue("@a3", s3);
        cmd.Parameters.AddWithValue("@a4", s4);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            un = un + dr.GetValue(0).ToString() + ",";
        }
        con.Close();
        Label3.Text = un;
        int pa = un.Length;
        for (int i = 0; i <= pa; i++)
        {
            int pos = 0;
            int x = un.IndexOf(",");
            if (x > 0)
            {
                string sb = un.Substring(pos, x);
                int p = int.Parse(sb);
                switch (p)
                {
                    case 1:
                        Button2.Enabled = false;
                        break;
                    case 2:
                        Button3.Enabled = false;
                        break;
                    case 3:
                        Button4.Enabled = false;
                        break;
                    case 4:
                        Button5.Enabled = false;
                        break;
                    case 5:
                        Button6.Enabled = false;
                        break;
                    case 6:
                        Button7.Enabled = false;
                        break;
                    case 7:
                        Button8.Enabled = false;
                        break;
                    case 8:
                        Button9.Enabled = false;
                        break;
                    case 9:
                        Button10.Enabled = false;
                        break;
                    case 10:
                        Button11.Enabled = false;
                        break;
                    case 11:
                        Button12.Enabled = false;
                        break;
                    case 12:
                        Button13.Enabled = false;
                        break;
                    case 13:
                        Button14.Enabled = false;
                        break;
                    case 14:
                        Button15.Enabled = false;
                        break;
                    case 15:
                        Button16.Enabled = false;
                        break;
                    case 16:
                        Button17.Enabled = false;
                        break;
                    case 17:
                        Button18.Enabled = false;
                        break;
                    case 18:
                        Button19.Enabled = false;
                        break;
                    case 19:
                        Button20.Enabled = false;
                        break;
                    case 20:
                        Button21.Enabled = false;
                        break;
                    case 21:
                        Button22.Enabled = false;
                        break;
                    case 22:
                        Button23.Enabled = false;
                        break;
                    case 23:
                        Button24.Enabled = false;
                        break;
                    case 24:
                        Button25.Enabled = false;
                        break;
                    case 25:
                        Button26.Enabled = false;
                        break;
                    case 26:
                        Button27.Enabled = false;
                        break;
                    case 27:
                        Button28.Enabled = false;
                        break;
                    case 28:
                        Button29.Enabled = false;
                        break;
                }
                un = un.Substring(x + 1);
            }
        }
    }

    protected void Button30_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment.aspx");
    }

    protected void allocate(Button b1)
    {
        if (Session["nosel"] == null)
        {
            n++;
            Session["nosel"] = n;
            if (Session["ns"] == null)
                s = b1.Text;
            else
                s = Session["ns"].ToString() + "," + b1.Text;
            b1.Enabled = false;
            Label3.Text = s;
            Session["ns"] = null;
            Session["ns"] = s;
        }
        else if (Session["nosel"].ToString() != Session["nos"].ToString())
        {
            n = int.Parse(Session["nosel"].ToString());
            n++;
            Session["nosel"] = n;
            Label4.Text = n.ToString();
            if (Session["ns"] == null)
                s = b1.Text;
            else
                s = Session["ns"].ToString() + "," + b1.Text;
            b1.Enabled = false;
            Label3.Text = s;
            Session["ns"] = null;
            Session["ns"] = s;
        }
        else if (Session["nosel"].ToString() == Session["nos"].ToString())
            Label4.Text = "Nos exceedeed";
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        allocate(Button2);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        allocate(Button3);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        allocate(Button4);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        allocate(Button5);
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        allocate(Button6);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        allocate(Button7);
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        allocate(Button8);
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        allocate(Button9);
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        allocate(Button10);
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        allocate(Button11);
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        allocate(Button12);
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        allocate(Button13);
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        allocate(Button14);
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        allocate(Button15);
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        allocate(Button16);
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        allocate(Button17);
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        allocate(Button18);
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        allocate(Button19);
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        allocate(Button20);
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        allocate(Button22);
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        allocate(Button22);
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        allocate(Button23);
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        allocate(Button24);
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        allocate(Button25);
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        allocate(Button26);
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        allocate(Button27);
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        allocate(Button28);
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        allocate(Button29);
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        s = Session["ns"].ToString();
        s = s + ",";
        int pa = s.Length;
        for (int i = 0; i <= pa; i++)
        {
            int pos = 0;
            int x = s.IndexOf(",");
            if (x > 0)
            {
                string sb = s.Substring(pos, x);
                int p = int.Parse(sb);
                switch (p)
                {
                    case 1:
                        Button2.Enabled = true;
                        break;
                    case 2:
                        Button3.Enabled = true;
                        break;
                    case 3:
                        Button4.Enabled = true;
                        break;
                    case 4:
                        Button5.Enabled = true;
                        break;
                    case 5:
                        Button6.Enabled = true;
                        break;
                    case 6:
                        Button7.Enabled = true;
                        break;
                    case 7:
                        Button8.Enabled = true;
                        break;
                    case 8:
                        Button9.Enabled = true;
                        break;
                    case 9:
                        Button10.Enabled = true;
                        break;
                    case 10:
                        Button11.Enabled = true;
                        break;
                    case 11:
                        Button12.Enabled = true;
                        break;
                    case 12:
                        Button13.Enabled = true;
                        break;
                    case 13:
                        Button14.Enabled = true;
                        break;
                    case 14:
                        Button15.Enabled = true;
                        break;
                    case 15:
                        Button16.Enabled = true;
                        break;
                    case 16:
                        Button17.Enabled = true;
                        break;
                    case 17:
                        Button18.Enabled = true;
                        break;
                    case 18:
                        Button19.Enabled = true;
                        break;
                    case 19:
                        Button20.Enabled = true;
                        break;
                    case 20:
                        Button21.Enabled = true;
                        break;
                    case 21:
                        Button22.Enabled = true;
                        break;
                    case 22:
                        Button23.Enabled = true;
                        break;
                    case 23:
                        Button24.Enabled = true;
                        break;
                    case 24:
                        Button25.Enabled = true;
                        break;
                    case 25:
                        Button26.Enabled = true;
                        break;
                    case 26:
                        Button27.Enabled = true;
                        break;
                    case 27:
                        Button28.Enabled = true;
                        break;
                    case 28:
                        Button29.Enabled = true;
                        break;
                }
                s = s.Substring(x + 1);
            }
        } Label4.Text = s;
        Session["ns"] = null;
    }
}
