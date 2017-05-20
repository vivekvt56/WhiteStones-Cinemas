<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyAccount.aspx.cs" Inherits="Account" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="White">
    <form id="form1" runat="server">
    <div align="center" 
        
        
        style="font-family: Gabriola; font-size: xx-large; font-weight: bold; text-align: center; background-image: url('Image/images (4).jpg');">
    
        &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" 
            onclick="LinkButton1_Click" Font-Bold="True" Font-Size="XX-Large" 
            ForeColor="Red">HOME</asp:LinkButton>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click" 
            Visible="False">LinkButton</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Booking_History</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">Edit_Profile</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Change_Password</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">LogOut</asp:LinkButton>
        <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#74828B" Height="394px" 
            Visible="False" Width="468px" BorderColor="#006600" BorderStyle="Dotted" 
            Font-Size="Large">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; USERNAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" EnableTheming="True"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E-MAIL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MOBILE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CITY&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" 
                Height="41px" onclick="Button1_Click" Text="UPDATE" Visible="False" 
                Width="96px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </asp:Panel>
    
        <br />
            <br />
        <br />
        <br />
    
    &nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
