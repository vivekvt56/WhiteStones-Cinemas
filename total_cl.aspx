<%@ Page Language="C#" AutoEventWireup="true" CodeFile="total_cl.aspx.cs" Inherits="total_cl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #form1
        {
            height: 662px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" 
    style="background-position: -23px; background-image: url('Image/box-office.jpg')">
    <div>
    
    </div>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="XX-Large" 
            onclick="LinkButton1_Click">HOME</asp:LinkButton>
    </p>
    <p style="text-align: center; background-color: #99ABE8">
        <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
            Text="TOTAL COLLECTIONS" Font-Overline="True" Font-Size="XX-Large" 
            Font-Underline="True"></asp:Label>
    </p>
    <br />
&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Height="79px" onclick="Button1_Click" 
        style="font-weight: 700" Text="TOTAL INCOME GENERATED" Font-Size="Large" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p style="background-position: left">
        &nbsp;</p>
    <p>
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="77px" onclick="Button2_Click" 
            Text="CALCELLATION HISTORY" Width="386px" Font-Bold="True" 
            Font-Size="Large" />
    </p>
    </form>
</body>
</html>
