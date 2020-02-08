<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="Tp1_Etudiants_Code_First.Administration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 224px;
    }
    .auto-style3 {
        width: 116px;
    }
    .auto-style4 {
        width: 148px;
    }
    .auto-style5 {
        width: 133px;
    }
        .auto-style6 {
            width: 148px;
            height: 35px;
        }
        .auto-style7 {
            width: 224px;
            height: 35px;
        }
        .auto-style8 {
            width: 116px;
            height: 35px;
        }
        .auto-style9 {
            width: 133px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="ID*"></asp:Label>
        </td>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label8" runat="server" ForeColor="Red" Text="ID*"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Title *"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Title *"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Groupe*"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Description*"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="Filiére*"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="20px" Width="122px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="27px" Text="Add" Width="103px" OnClick="Button2_Click" />
        </td>
        <td class="auto-style3">
            <asp:Label ID="Label6" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
        </td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style7">
        </td>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
        <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="29px" Text="Add" Width="94px" OnClick="Button1_Click" />
            </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style2">
            <table class="w-100">
                <tr>
                    <td>&nbsp;</td>
                    <td>
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
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
</table>
</asp:Content>
