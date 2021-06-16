<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="BaseCPage2.aspx.cs" Inherits="aspnetControls.WebForm4" %>
<%@ MasterType TypeName="aspnetControls.BaseMasterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DataPassingPlaceHolder" runat="server">
        <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Height="300" Width="100%">

            <asp:GridView ID="GridView1" runat="server" autogeneratecolumns="True" 
                cellpadding="4" height="30px" width="800px" GridLines="None" class="DataScroll" 
                ShowHeader="true" >
                <FooterStyle BorderColor="White" Height="20px" HorizontalAlign="Center"/>
                <RowStyle Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <AlternatingRowStyle BackColor="LightGray" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        </asp:Panel>       
</asp:Content>
