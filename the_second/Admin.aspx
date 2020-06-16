<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="the_second.WebForm2" %>
<%@ Import Namespace="the_second" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="./style.css" rel="stylesheet"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto" border="1">
                <tr>
                    <td>
                        ФИО
                    </td>
                    <td>
                        Номер телефона
                    </td>
                    <td>
                        Номер забронированной комнаты
                    </td>

                </tr>
                <%=GetPageData()%>
            </table>
        </div>
        <label style="position: relative; left: 45%">Номера отеля:</label>
        <div>
            <table style="margin:auto">
                <%=ShowHotelRooms()%>
            </table>
        </div>
        <a href="Default.aspx">Страница регистрации</a>
    </form>
</body>
</html>
