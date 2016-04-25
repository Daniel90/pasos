<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoNuevoCustomer.aspx.cs" Inherits="CapaPresentacion.IngresoNuevoCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <asp:CheckBox ID="chkNameStyle" runat="server" Text="Name Style" />
        
        
        <asp:Panel ID="Panel1" runat="server">
            
            <asp:Label ID="Label1" runat="server" Text="Title (ej: Mr. Ms.)"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server" Width="120px"></asp:TextBox>
            
            <asp:Panel ID="Panel2" runat="server">
                <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" Width="201px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Middle Name"></asp:Label>
                <asp:TextBox ID="txtMiddleName" runat="server" Width="206px"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" Width="213px"></asp:TextBox>
                <asp:Panel ID="Panel3" runat="server">
                    <asp:Label ID="Label5" runat="server" Text="Suffix"></asp:Label>
                    <asp:TextBox ID="txtSuffix" runat="server"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="Company Name"></asp:Label>
                    <asp:TextBox ID="txtCompanyName" runat="server" Width="224px"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="Sales Person"></asp:Label>
                    <asp:TextBox ID="txtSalesPerson" runat="server" Width="148px"></asp:TextBox>
                    <asp:Panel ID="Panel4" runat="server">
                        <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" Width="223px"></asp:TextBox>
                        <asp:Label ID="Label9" runat="server" Text="Phone"></asp:Label>
                        <asp:TextBox ID="txtPhone" runat="server" Width="178px"></asp:TextBox>
                        <asp:Panel ID="Panel5" runat="server">
                            <asp:Label ID="Label10" runat="server" Text="Rut"></asp:Label>
                            <asp:TextBox ID="txtRut" runat="server" Width="109px"></asp:TextBox>
                            <asp:Label ID="Label11" runat="server" Text="-"></asp:Label>
                            <asp:TextBox ID="txtDV" runat="server" Width="16px"></asp:TextBox>
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    
    </div>
        <asp:Label ID="Label12" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" Width="181px"></asp:TextBox>
        <asp:Panel ID="Panel6" runat="server">
            <asp:Label ID="Label13" runat="server" Text="Repetir contraseña"></asp:Label>
            <asp:TextBox ID="txtPassword2" runat="server" Width="172px"></asp:TextBox>
        </asp:Panel>
        <asp:Button ID="btnInsertar" class="btn btn-default" runat="server" Text="Aceptar" OnClick="btnInsertar_Click" />
    </form>
</body>
</html>
