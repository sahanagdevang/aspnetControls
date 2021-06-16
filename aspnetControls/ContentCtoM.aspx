<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ContentCtoM.aspx.cs" Inherits="aspnetControls.WebForm5" %>
<%@ MasterType VirtualPath="~/Site2.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="DataPassingPlaceHolder" runat="server">
    <b>Please enter some text</b>
    <br />
    <br />
    <asp:TextBox ID="Textbox1" runat="server" ></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Set Text" OnClick="Button1_Click"/>
</asp:Content>
 