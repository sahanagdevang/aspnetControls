<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contentpage2.aspx.cs" Inherits="aspnetControls.WebForm3" %>
<%@ MasterType VirtualPath="~/Site1.Master" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <table style="background-color: #5D7B9D">
        <tr>
            <td style="font-weight: bold; width: 200px; border: 1px solid black">
                Person ID
            </td>
            <td style="font-weight: bold; width: 200px; border: 1px solid black">
                Person Name
            </td>
            <td style="font-weight: bold; width: 200px; border: 1px solid black">
                Person Address
            </td>
            <td style="font-weight: bold; width: 200px; border: 1px solid black">
                Person Age
            </td>
        </tr>
    </table>
         <div style="height:300px; width:800px; overflow: scroll" >

       

            <asp:GridView ID="GridView1" runat="server" autogeneratecolumns="True" cellpadding="4" height="400px" width="800px" GridLines="None" class="DataScroll" 
                ShowHeader="false" >

                <FooterStyle BorderColor="White" Height="20px" HorizontalAlign="Center"/>
                <RowStyle Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <AlternatingRowStyle BackColor="LightGray" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
       
            </div>
</asp:Content>
