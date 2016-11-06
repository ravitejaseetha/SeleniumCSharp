<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateTip.aspx.cs" Inherits="tipCalculator.CalculateTip" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Country"></asp:Label> 
        <br />
        <asp:DropDownList ID="ddlCountry" runat="server" >
        </asp:DropDownList>
        <br />
        <br />
        Bill Amount<br />
        <asp:TextBox ID="txtBilAMount" runat="server"></asp:TextBox>
        <br />
        Number of courses
        <br />
        <asp:DropDownList ID="ddlNumberOfCOurses" runat="server">
        </asp:DropDownList>
        <br />
        Quality of Service
        <br />
        <asp:DropDownList ID="ddlQOS" runat="server">
        </asp:DropDownList>
        <br />
        Number of Flies in the Soup<br />
        <asp:DropDownList ID="ddlNumOfFlies" runat="server">
        </asp:DropDownList>
        <br />
        Tip Amount<br />
        <asp:TextBox ID="txtTipAmount" runat="server"></asp:TextBox>
        <br />
        Total Amount<br />
        <asp:TextBox ID="txtTotalAmount" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Calculate Tip" onclick="Button1_Click" />
        </form>
</body>
</html>        
