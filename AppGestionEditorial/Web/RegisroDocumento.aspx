<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Site1.Master" AutoEventWireup="true" CodeBehind="RegisroDocumento.aspx.cs" Inherits="AppGestionEditorial.Web.RegisroDocumento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container">
    
	<div class="page-header">
       <h1>Registrar Documentos </h1>
    </div>

        <div class="form-group">
            <label class="control-label col-xs-2">Codigo:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="textcodigo" class="form-control" placeholder="ID" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
            
        </div>

    <div class="form-group">
            <label class="control-label col-xs-2">Tipo de documento:</label>
            <div class="col-xs-10">
               <asp:DropDownList onChange="javascript:mostrar(this.value);" ID="type" class="form-control" required="" title="Por favor seleccione un dato correspondiente" runat="server">
                   <asp:ListItem Value="0">seleccionar</asp:ListItem>
                   <asp:ListItem Value="Libros">Libro</asp:ListItem>
                   <asp:ListItem Value="Revistas">Revista</asp:ListItem>
                   <asp:ListItem Value="Cientificos">Cientifico</asp:ListItem>
                </asp:DropDownList>
            </div>
    
        </div>


        <div class="form-group">
            <label  class="control-label col-xs-2">Titulo:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Texttitulo" class="form-control" placeholder="Titulo" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>
       
    <div class="form-group">
            <label class="control-label col-xs-2">Autores:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Textautores" class="form-control" placeholder="Autores" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <label  class="control-label col-xs-2">Idiomas:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Textidiomas" class="form-control" placeholder="Idiomas" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>

    <div class="form-group">
            <label  class="control-label col-xs-2">Editorial:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Texteditorial" class="form-control" placeholder="Editorial" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato correspondiente" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <label  class="control-label col-xs-2">Categoria:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Textcategoria" class="form-control" placeholder="Categoria" pattern="[A-Za-z- -]*" required="" title="Por favor ingrese dato numerico." runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <label  class="control-label col-xs-2">Numero de paginas:</label>
            <div class="col-xs-10">
                <asp:TextBox ID="Textnumpaginas" class="form-control" placeholder="Numero" pattern="[1234567890]*" required="" runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <label class="control-label col-xs-2">Fecha de edicion:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textfechaedicion" class="form-control" placeholder="Fecha de edicion" pattern="[1234567890-/-]*" required="" title="Por favor ingrese dato correspondiente 'dd/mm/aa'." runat="server"></asp:TextBox>
            </div>
        </div><div class="form-group">
            <label class="control-label col-xs-2">Fecha de publicacion:</label>
            <div class="col-xs-10">
              <asp:TextBox ID="Textfechapublicacion" class="form-control" placeholder="Fecha de publicacion" pattern="[1234567890-/-]*" required="" title="Por favor ingrese dato correspondiente 'dd/mm/aa'." runat="server"></asp:TextBox>
            </div>
        </div>

    <div class="form-group" style="display: none;" id="numcapitulos">
            <label class="control-label col-xs-2">Numero de capitulos:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textnumcapitulos" class="form-control" value="numero"  onFocus="if (this.value=='numero') this.value='';" placeholder="Numero de capitulos" pattern="[1234567890]*" required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>
     <div class="form-group" style="display: none;" id="numtomas">
            <label class="control-label col-xs-2">Numero de tomas:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textnumtomas" class="form-control" value="0.0"  onFocus="if (this.value=='0.0') this.value='';" placeholder="Numero de tomas" pattern="[1234567890]*" required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group" style="display: none;" id="nivel">
            <label class="control-label col-xs-2">Nivel:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textnivel" class="form-control" value="0.0"  onFocus="if (this.value=='0.0') this.value='';" placeholder="Nivel" required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>

    <div class="form-group" style="display: none;" id="numvolumen">
            <label class="control-label col-xs-2">Numero de volumenes:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textnumvolumenes" class="form-control" value="0.0"  onFocus="if (this.value=='0.0') this.value='';" placeholder="Numero de volumenes" pattern="[1234567890]*" required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group" style="display: none;" id="numarticulo">
            <label class="control-label col-xs-2">Numero de articulos:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Textnumarticulos" class="form-control" value="0.0"  onFocus="if (this.value=='0.0') this.value='';" placeholder="Numero de aticulos"  pattern="[1234567890]*" required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group" style="display: none;" id="tipo">
            <label class="control-label col-xs-2">Tipo:</label>
            <div class="col-xs-10">
               <asp:TextBox ID="Texttipo" class="form-control" value="0.0"  onFocus="if (this.value=='0.0') this.value='';" placeholder="tipo"   required="" title="Por favor ingrese dato correspondiente." runat="server"></asp:TextBox>
            </div>
        </div>
    <div class="form-group">
            <div class="col-xs-10">
                
                <asp:Button ID="btnGuardar" runat="server" Text="Enviar" value="enviar" class="btn btn-primary"  OnClick="btnGuardar_Click"/>

                
            </div>
        </div>
</div>

</asp:Content>