<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="greeting.aspx.cs" Inherits="Cross_Site_Scripting.greeting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
   
    <div >
        <label style="position:absolute; left:10px"><p> Please Enter your name </p></label>
        <asp:TextBox style="position:absolute; left:200px" ID="txt_username" runat="server"></asp:TextBox>
    </div>
    <br />
    <br />

        <div>
        <asp:Button style="position:absolute; left:275px" Width="100" Text="Click" runat="server" ID="btn_submit" OnClick="btn_submit_Click"  />
    </div>

    <br/>
    <br/>
    <br/>

    <asp:Label ID="lbl_welcome" runat="server"/>
    

</asp:Content>
