<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" 
    style="text-align: center; font-family: 'Footlight MT Light';">
    <div align="center" 
        
        
        style="text-align: right; font-size: large; font-weight: bold; font-style: normal; height: 696px; background-color: #C0C0C0; background-image: url('Image/professional-background-images-for-websites.jpg');">
    
        <br />
        <br />
        <br />
    
    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
            Font-Size="XX-Large">HOME</asp:LinkButton>
        <br />
        <asp:Label ID="Label3" runat="server" style="font-weight: 700" 
            Text="LOGIN PAGE" Font-Size="X-Large" Font-Underline="True" 
            ForeColor="#003399"></asp:Label>
        <br />
        <br />
    <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" BorderColor="#009933" 
        BorderStyle="Groove" Height="390px" Width="400px" HorizontalAlign="Center" 
        Font-Size="Large">
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="195px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp; Password<br />
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="191px" 
            ontextchanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Forgot 
        Password?</asp:LinkButton>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        New User
        <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">SIGN 
        UP</asp:LinkButton>
        &nbsp;Here!!!<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="Button2" runat="server" Height="43px" onclick="Button2_Click" 
            Text="LOGIN" Font-Bold="True" Font-Size="Large" Width="77px" />
    </asp:Panel>
        <br />
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            &nbsp;</p>
    <p style="height: 1px">
        &nbsp;</form>
</body>
</html>
