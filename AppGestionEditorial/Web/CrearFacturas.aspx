<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="CrearFacturas.aspx.cs" Inherits="AppGestionEditorial.Web.Facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server" role="form" class="form-horizontal">
    <div class="jumbotron">
        <h2>Generar Factura</h2>
        

        
             <div class="form-group">
                <label class="control-label">Id</label>
                 <asp:TextBox ID="txtid" runat="server" class="form-control" ></asp:TextBox> 
         </div>

             <div class="form-group">
                <label class="control-label" >Estado</label>
                 <asp:TextBox ID="txtestado" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             
             <div class="form-group">
                <label class="control-label" >Sucursal</label>
                 <asp:TextBox ID="txtsucursal" runat="server" class="form-control"  ></asp:TextBox>
             </div>

                 <div class="form-group">
                <label class="control-label" >Fecha</label>
                 <asp:TextBox ID="txtfecha" runat="server" class="form-control"  ></asp:TextBox>
             </div>
                 
             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
        
    </form>
</asp:Content>
