<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Clase_021018_ASP.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <h1>Hola Mundo c#</h1>
        <form action="SaludarHandler.ashx" id="form1" method="post">
            <input type="text" name="nombre" placeholder="Escriba su nombre"/>
            <input type="submit" value="Saludar"/>
        </form>

        <%
            if (Session["mensaje"] != null) {
                String msg = Session["mensaje"].ToString();
                Response.Write("Mensaje: "+msg);
            }
        %>

        <%
            // Comentario c#
            /* multi line runat="server"*/

            String mensaje = "Hola desde c# hola";
            Response.Write("Mensaje: "+mensaje+"<br>");

            for (int i = 1; i <= 5; i++) {
                Response.Write("Ingles ["+i+"]<br>");
            }
        %>
    </body>
</html>
