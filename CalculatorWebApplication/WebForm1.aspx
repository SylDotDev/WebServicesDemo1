﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family:Arial">
            <tr>
                <td>
                    <b>x</b>
                </td>
                <td>
                    <asp:TextBox ID="txtX" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>y</b>
                </td>
                <td>
                    <asp:TextBox ID="txtY" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Result</b>
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
