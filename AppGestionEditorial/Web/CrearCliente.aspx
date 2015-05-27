<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="CrearClientes.aspx.cs" Inherits="AppGestionEditorial.Web.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server" role="form" class="form-horizontal">
    <div class="jumbotron">
        <h2>Registar Cliente</h2>
        

        
             <div class="form-group">
                <label class="control-label">Identificacion</label>
                 <asp:TextBox ID="txtid" runat="server" class="form-control" ></asp:TextBox> 
         </div>

             <div class="form-group">
                <label class="control-label" >Nombres</label>
                 <asp:TextBox ID="txtnombres" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             
             <div class="form-group">
                <label class="control-label" >Apellidos</label>
                 <asp:TextBox ID="txtapellidos" runat="server" class="form-control"  ></asp:TextBox>
             </div>

                 <div class="form-group">
                <label class="control-label" >Direccion</label>
                 <asp:TextBox ID="txtdireccion" runat="server" class="form-control"  ></asp:TextBox>
             </div>

                 <div class="form-group">
                <label class="control-label" >Telefono</label>
                 <asp:TextBox ID="txttelefono" runat="server" class="form-control"  ></asp:TextBox>
             </div>

                 <div class="form-group">
                <label class="control-label" >Email</label>
                 <asp:TextBox ID="txtemail" runat="server" class="form-control"  ></asp:TextBox>
             </div>

             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
        
    </form>
</asp:Content>
