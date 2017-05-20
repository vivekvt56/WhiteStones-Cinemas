<%@ Page Language="C#" AutoEventWireup="true" CodeFile="seatlayout2.aspx.cs" Inherits="seatlayout2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 594px; font-size: x-large; color: #800080; text-align: center;">
    
        <span class="style1" style="font-size: xx-large">Select Your Seat Here...</span><br />
        <br />
        <asp:Button ID="Button31" runat="server" onclick="Button31_Click" 
            style="font-weight: 700" Text="RESET" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BackColor="#993366" Height="417px" 
            Font-Size="X-Large" ForeColor="Black" Width="813px">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="Red" 
                Text="SCREEN"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="LAYOUT STYLE 2"></asp:Label>
            <br />
            <br />
            &nbsp; row1::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="1" 
    Width="35px" onclick="Button2_Click1" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" Text="2" 
    Width="35px" onclick="Button3_Click" style="height: 26px" />
            &nbsp;
            <asp:Button ID="Button4" runat="server" Text="3" 
    Width="35px" onclick="Button4_Click" />
            &nbsp;
            <asp:Button ID="Button5" runat="server" Text="4" 
    Width="35px" onclick="Button5_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="5" 
    Width="37px" Height="26px" onclick="Button6_Click" />
            &nbsp;
            <asp:Button ID="Button7" runat="server" Text="6" 
    Width="35px" onclick="Button7_Click" />
            &nbsp;
            <asp:Button ID="Button8" runat="server" Text="7" 
    Width="35px" onclick="Button8_Click" />
            &nbsp;
            <br />
            <br />
            &nbsp;row2::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="8" 
    Width="35px" onclick="Button9_Click" />
            &nbsp;
            <asp:Button ID="Button10" runat="server" Text="9" 
    Width="35px" onclick="Button10_Click" />
            &nbsp;
            <asp:Button ID="Button11" runat="server" Text="10" 
    Width="35px" onclick="Button11_Click" />
            &nbsp;
            <asp:Button ID="Button12" runat="server" Text="11" 
    Width="35px" onclick="Button12_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button13" runat="server" Text="12" 
    Width="35px" onclick="Button13_Click" />
            &nbsp;
            <asp:Button ID="Button14" runat="server" Text="13" 
    Width="35px" onclick="Button14_Click" />
            &nbsp;
            <asp:Button ID="Button15" runat="server" Text="14" 
    Width="35px" onclick="Button15_Click" />
            <br />
            <br />
            &nbsp; row3::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button16" runat="server" Text="15" 
    Width="35px" onclick="Button16_Click" />
            &nbsp;
            <asp:Button ID="Button17" runat="server" Text="16" 
    Width="35px" onclick="Button17_Click" />
            &nbsp;<asp:Button ID="Button18" runat="server" Text="17" 
    Width="35px" onclick="Button18_Click" />
            &nbsp;
            <asp:Button ID="Button19" runat="server" onclick="Button19_Click" Text="18" 
                Width="35px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button20" runat="server" Text="19" 
    Width="35px" onclick="Button20_Click" />
            &nbsp;
            <asp:Button ID="Button21" runat="server" Text="20" 
    Width="35px" onclick="Button21_Click" />
            &nbsp;
            <asp:Button ID="Button22" runat="server" Text="21" 
    Width="35px" onclick="Button22_Click" />
            <br />
            <br />
            &nbsp;row4::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button23" runat="server" Text="22" 
    Width="35px" onclick="Button23_Click" />
            &nbsp;
            <asp:Button ID="Button24" runat="server" Text="23" 
    Width="35px" onclick="Button24_Click" />
            &nbsp;<asp:Button ID="Button25" runat="server" Text="24" 
    Width="35px" onclick="Button25_Click" style="height: 26px" />
            &nbsp;
            <asp:Button ID="Button26" runat="server" Text="25" 
    Width="35px" onclick="Button26_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button27" runat="server" Text="26" 
    Width="35px" onclick="Button27_Click" />
            &nbsp;
            <asp:Button ID="Button28" runat="server" Text="27" 
    Width="35px" onclick="Button28_Click" />
            &nbsp;
            <asp:Button ID="Button29" runat="server" Text="28" 
    Width="35px" onclick="Button29_Click" />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
        <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
    <p>
&nbsp;<asp:Button ID="Button30" runat="server" onclick="Button30_Click" 
            Text="Book Now" BackColor="#9900CC" Font-Size="XX-Large" ForeColor="Black" 
            Height="55px" Width="267px" />
    </p>
        <br />
    
    </div>
    <p>
&nbsp;</p>
    </form>
</body>
</html>
