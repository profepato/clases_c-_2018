<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumar.aspx.cs" Inherits="Clase_021018_ASP.Sumar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="SumarHandler.ashx" method="post" id="form1" runat="server">
        <input type="text" name="s1" placeholder="Ingrese numero"/>
        <input type="text" name="s2" placeholder="Ingrese numero"/>
        <input type="submit" />
    </form>
</body>
</html>
