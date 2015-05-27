<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="IPublicaciones.aspx.cs" Inherits="AppGestionEditorial.Web.IPublicaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server" role="form" class="form-horizontal">
    <div class="jumbotron">
        <h2>Publicar Documentos</h2>
        <div class="form-group">
         <label class="control-label">Seleccionar Tipo de cuenta</label>
         <asp:DropDownList onChange="javascript:mostrar(this.value);" ID="type" runat="server" class="form-control" >
             <asp:ListItem Value="0">-seleccionar-</asp:ListItem>
             <asp:ListItem Value="Libros">Libros</asp:ListItem>
             <asp:ListItem Value="Revistas">Revistas</asp:ListItem>
             <asp:ListItem Value="Cientificos">Clientifos</asp:ListItem>
         </asp:DropDownList>
         </div>

        <div class="form-group">
                <label class="control-label">Codigo</label>
                <asp:TextBox ID="txtcodigo" runat="server" class="form-control" ></asp:TextBox>
         </div>
             <div class="form-group">
                <label class="control-label">Titulo</label>
                 <asp:TextBox ID="txttitulo" runat="server" class="form-control" ></asp:TextBox> 
          </div>       
             <div class="form-group">
                <label class="control-label" >Editorial</label>
                <asp:TextBox ID="txteditorial" runat="server" class="form-control" ></asp:TextBox> 
           </div>
             <div class="form-group">
                <label class="control-label" >Edicion</label>
                 <asp:TextBox ID="txtedicion" runat="server" class="form-control"  ></asp:TextBox>
             </div>
             
             <div class="form-group">
                <label class="control-label" >Autores</label>
                 <asp:TextBox ID="txtautores" runat="server" class="form-control"  ></asp:TextBox>
             </div>
        <div class="form-group">
                <label class="control-label" >Idiomas</label>
                 <asp:TextBox ID="txtidiomas" runat="server" class="form-control"  ></asp:TextBox>
             </div>
        <div class="form-group">
                <label class="control-label" >Categorias</label>
                 <asp:TextBox ID="txtcategorias" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Numero De Paginas</label>
                 <asp:TextBox ID="txtnumeropaginas" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Fecha De Publicacion</label>
                 <asp:TextBox ID="txtfechapublicacion" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Fecha De Edicion</label>
                 <asp:TextBox ID="txtfechaedicion" runat="server" class="form-control"  ></asp:TextBox>
            

        <div class="form-group">
                <label class="control-label" >Numero De Articulos</label>
                 <asp:TextBox ID="txtnumeroarticulos" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Numero De Volumenes</label>
                 <asp:TextBox ID="txtnumerovolumenes" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Numero De Tomos</label>
                 <asp:TextBox ID="txtnumerotomos" runat="server" class="form-control"  ></asp:TextBox>
             </div>

        <div class="form-group">
                <label class="control-label" >Numero De Capitulos</label>
                 <asp:TextBox ID="txtnumerocapitulos" runat="server" class="form-control"  ></asp:TextBox>
             </div>
        <div class="form-group">
                <label class="control-label" >Nivel</label>
                 <asp:TextBox ID="txtnivel" runat="server" class="form-control"  ></asp:TextBox>
             </div>
        <div class="form-group">
                <label class="control-label" >Tipos</label>
                 <asp:TextBox ID="txttipos" runat="server" class="form-control"  ></asp:TextBox>
             </div>

             </div>
             <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>
             </div>  
    </div>
    </form>
</asp:Content>
