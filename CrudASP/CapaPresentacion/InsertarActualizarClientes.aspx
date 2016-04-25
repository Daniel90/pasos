<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarActualizarClientes.aspx.cs" Inherits="CapaPresentacion.InsertarActualizarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Código: "></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server" Width="116px"></asp:TextBox>
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Nombres: "></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server" Width="429px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Apellidos: "></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server" Width="427px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label4" runat="server" Text="Correo: "></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server" Width="432px"></asp:TextBox>
            <asp:Panel ID="Panel6" runat="server">
                <asp:FileUpload ID="fluExaminar" runat="server" />
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
            <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" Width="96px" />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Width="118px" />
            <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Width="130px" />
            <asp:Button ID="btnSalir" runat="server" OnClick="btnSalir_Click" Text="Salir" Width="130px" />
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
