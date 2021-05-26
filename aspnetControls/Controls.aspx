<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="aspnetControls.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="radscriptmanager" runat ="server" ></telerik:RadScriptManager>
        <div>
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
         <fieldset style="width:350px">
            <legend>Colours</legend>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male"/>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female"/>
        </fieldset>
        <br />
        <br />
        <fieldset style="width:350px">
            <legend>Colours</legend>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Yellow"/>
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Red"/>
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Blue"/>
        </fieldset>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="submitBtn" runat="server" BackColor="#99FF66" BorderStyle="None" Height="38px" Text="Submit" Width="106px" />
            </div>
    </form>
</body>
</html>

