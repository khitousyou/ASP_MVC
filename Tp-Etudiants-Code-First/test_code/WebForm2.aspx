<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="test_code.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 105px;
        }
        .auto-style3 {
            width: 224px;
        }
        .auto-style4 {
            width: 182px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp; ID*&nbsp;</td>
                    <td class="auto-style3">&nbsp;<asp:TextBox ID="TextBox8" runat="server" Height="16px" Width="63px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID* :&nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp; Title*</td>
                    <td class="auto-style3">&nbsp;<asp:TextBox ID="TextBox9" runat="server" Height="23px" Width="199px"></asp:TextBox>
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Title* :</td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp; &nbsp;</td>
                    <td class="auto-style3">&nbsp;&nbsp; </td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Description* :&nbsp;</td>
                    <td>&nbsp;
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filiere* :&nbsp;</td>
                    <td>&nbsp; &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="105px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Add" Width="65px" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Height="28px" Text="Add" Width="65px" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
