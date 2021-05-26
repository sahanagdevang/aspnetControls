<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspnetControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="radscriptmanager" runat ="server" ></telerik:RadScriptManager>
        <div>
        
        <asp:TextBox ID="TextBox1" runat="server"  ToolTip="Type Something" AutoPostBack="false" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/Images/Click.jpg"  OnClientClick="alert(&quot;you typed in textbox&quot;)" OnClick="ImageButton1_Click" />
            <br />
        <br />
         <fieldset style="width:350px">
            <legend>Gender</legend>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="OneGender" OnCheckedChanged="RadioButton1_CheckedChanged" TextAlign="Left"/>
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="OneGender" OnCheckedChanged="RadioButton2_CheckedChanged"/>
             <br />
             <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="40px" ImageUrl="~/Images/Click.jpg"  OnClientClick="alert(&quot;you typed in textbox&quot;)" OnClick="ImageButton1_Click" />
            <br />

        </fieldset>
            <br />
        <br />
            <br />
        <br />
        <fieldset style="width:350px">
             <legend>Colours</legend>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Yellow"  OnCheckedChanged="CheckBox1_CheckedChanged"/>
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Red"  AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged"/>
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Blue" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged"/>
            <br />
            <br />
           <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('Are you sure you want to select?')" OnClick="LinkButton1_Click">Checkbox submit</asp:LinkButton>

        </fieldset>
            <br />
            <br />
            <fieldset style="width:350px">
            <legend>Student</legend>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">                  
                    <asp:ListItem Value="1" >Diploma</asp:ListItem>
                    <asp:ListItem Value="2" >Graduate</asp:ListItem>
                    <asp:ListItem Value="3" >Post Graduate</asp:ListItem>
                </asp:CheckBoxList>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Select All" OnClick="Button1_Click" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Deselect All" OnClick="Button2_Click" />
                <br />
                <br />
                <asp:ListBox ID="ListBox2" runat="server" Height="128px"  SelectionMode="Multiple" Width="145px"></asp:ListBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true"></asp:Label>
            <br />
            </fieldset> 

        <br />    
            <br />
            Hyperlink<br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com/" ImageHeight="50px" ImageUrl="~/Images/click-button.jpg" Target ="_Blank">Click here</asp:HyperLink>

            <br />
        <br /> 
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="-1" >Select Gender</asp:ListItem>
                <asp:ListItem Value="1" >Male</asp:ListItem>
                <asp:ListItem Value="2" Selected="True" >Female</asp:ListItem>
                <asp:ListItem Value="3" Enabled="false">Nothing</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<br />
            <br />
            data is feched from database here<br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="Role" DataValueField="Id">
                  
            </asp:DropDownList>
            &nbsp;<br />
            <br />
        <asp:Button ID="submitBtn" runat="server" BackColor="#99FF66" BorderStyle="None" Height="38px" Text="Submit" Width="106px" OnClick="submitBtn_Click" />
            <br />
            <br />
                <fieldset style="width:350px">
            <legend>Student</legend>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" >
                 <asp:ListItem Value="1" >Diploma</asp:ListItem>
                    <asp:ListItem Value="2" >Graduate</asp:ListItem>
                    <asp:ListItem Value="3" >Post Graduate</asp:ListItem>
            </asp:RadioButtonList>
                    <br />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="To get Radio Items" />
                    <br />
                    </fieldset>
            <br />
            <br />
            <br />
            Click on Google<asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink" OnClick="BulletedList1_Click" Target="_blank">
                <asp:ListItem Value="http://google.com"  >Google</asp:ListItem>
                    <asp:ListItem Value="2" >IE</asp:ListItem>
                    <asp:ListItem Value="3" >FireFox</asp:ListItem>
            </asp:BulletedList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server"  Rows="2" SelectionMode="Multiple" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                    <asp:ListItem Value="1" >Diploma</asp:ListItem>
                    <asp:ListItem Value="2" >Graduate</asp:ListItem>
                    <asp:ListItem Value="3" >Post Graduate</asp:ListItem>
            </asp:ListBox>

            <asp:Button ID="listBtn2" runat="server" BackColor="SkyBlue" BorderStyle="None" Height="38px" Text="In List" Width="106px" OnClick="listBtn2_Click"  />

            </div> 
    </form>
</body>
</html>
