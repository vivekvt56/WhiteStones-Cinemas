<%@ Page Language="C#" AutoEventWireup="true" CodeFile="seatlayout1.aspx.cs" Inherits="seatlayout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            font-weight: bold;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: xx-large; color: #008000; text-align: center;">
    
        <span class="style1">Select Your Seat Here...</span><br />
        <br />
        &nbsp;<asp:Button ID="Button31" runat="server" onclick="Button31_Click" 
            style="font-weight: 700" Text="RESET" />
        <br />
&nbsp;<asp:Panel ID="Panel1" runat="server" BackColor="#99FF66" Height="460px" 
            style="margin-top: 0px" Width="765px">
            <br />
            <asp:Label ID="Label1" runat="server" Text="SCREEN"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="LAYOUT STYLE 1"></asp:Label>
            <br />
            <br />
            &nbsp;row1::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button30" runat="server" onclick="Button30_Click" 
                style="height: 26px" Text="1" Width="33px" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" Text="2" Width="35px" 
                onclick="Button3_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="3" Width="35px" 
                onclick="Button4_Click" />
            &nbsp;
            <asp:Button ID="Button5" runat="server" Text="4" Width="35px" 
                onclick="Button5_Click" />
            &nbsp;
            <asp:Button ID="Button6" runat="server" Text="5" Width="35px" 
                onclick="Button6_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="6" Width="35px" 
                onclick="Button7_Click" />
            &nbsp;
            <asp:Button ID="Button8" runat="server" Text="7" Width="35px" 
                onclick="Button8_Click" />
            <br />
            <br />
            &nbsp;row2::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="8" Width="35px" 
                onclick="Button9_Click" />
            &nbsp;
            <asp:Button ID="Button10" runat="server" Text="9" Width="35px" 
                onclick="Button10_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button11" runat="server" Text="10" Width="35px" 
                onclick="Button11_Click" />
            &nbsp;
            <asp:Button ID="Button12" runat="server" Text="11" Width="35px" 
                onclick="Button12_Click" />
            &nbsp;
            <asp:Button ID="Button13" runat="server" Text="12" Width="35px" 
                onclick="Button13_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button14" runat="server" Text="13" Width="35px" 
                onclick="Button14_Click" />
            &nbsp;
            <asp:Button ID="Button15" runat="server" Text="14" Width="35px" 
                onclick="Button15_Click" />
            <br />
            <br />
            &nbsp;row3::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button16" runat="server" Text="15" Width="35px" 
                onclick="Button16_Click" />
            &nbsp;
            <asp:Button ID="Button17" runat="server" Text="16" Width="35px" 
                onclick="Button17_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button18" runat="server" Text="17" Width="35px" 
                onclick="Button18_Click" />
            &nbsp;
            <asp:Button ID="Button19" runat="server" Text="18" Width="35px" 
                onclick="Button19_Click" />
            &nbsp;
            <asp:Button ID="Button20" runat="server" Text="19" Width="35px" 
                onclick="Button20_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button21" runat="server" Text="20" Width="35px" 
                onclick="Button21_Click" />
            &nbsp;
            <asp:Button ID="Button22" runat="server" Text="21" Width="35px" 
                onclick="Button22_Click" />
            <br />
            <br />
            &nbsp;row4::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button23" runat="server" Text="22" Width="35px" 
                onclick="Button23_Click" />
            &nbsp;
            <asp:Button ID="Button24" runat="server" Text="23" Width="35px" 
                onclick="Button24_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button25" runat="server" Text="24" Width="35px" 
                onclick="Button25_Click" />
            &nbsp;
            <asp:Button ID="Button26" runat="server" Text="25" Width="35px" 
                onclick="Button26_Click" />
            &nbsp;
            <asp:Button ID="Button27" runat="server" Text="26" Width="35px" 
                onclick="Button27_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button28" runat="server" Text="27" Width="35px" 
                onclick="Button28_Click" />
            &nbsp;
            <asp:Button ID="Button29" runat="server" Text="28" Width="35px" 
                onclick="Button29_Click" />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="SEATS SELECTED : :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" ForeColor="#006600"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="#006600"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Font-Size="X-Large" ForeColor="Black" 
            Height="55px" Text="Book Now" Width="267px" onclick="Button1_Click" 
            BackColor="#66FF33" />
        <br />
    
    </div>
    </form>
</body>
</html>
