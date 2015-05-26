<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="AppGestionEditorial.Web.RegistroCliente" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
    
	<div class="page-header">
       <h1>Registrar Cliente </h1>
    </div>
         <div class="form-group">
            <label  class="control-label col-xs-2">Nombres:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Nombres" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>
         <div class="form-group">
            <label  class="control-label col-xs-2">Apellidos:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="TextBox1" class="form-control" placeholder="Apellidos" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>

         <div class="form-group">
            <label  class="control-label col-xs-2">Direccion:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="TextBox3" class="form-control" placeholder="Direccion"  required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
         </div>
    
    <div class="form-group">
            <label  class="control-label col-xs-2">Telefono:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="TextBox7" class="form-control" placeholder="Telefono" pattern="[1234567890]*"  title="Por favor ingrese su numero telefonico" required="" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <label  class="control-label col-xs-2">Email:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="TextBox4" class="form-control"  type="email"   placeholder="Email" required="" title="Por favor ingrese su email" runat="server"></asp:TextBox>
            </div>
        </div>
    
    <div class="form-group">
            <div class="col-xs-offset-2 col-xs-10">
                <button type="submit" class="btn btn-primary">Enviar</button>
            </div>
        </div>
    </div>


</asp:Content>
