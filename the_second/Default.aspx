<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="the_second.WebForm1" %>
<%@ Import Namespace="the_second" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="./style.css" rel="stylesheet"/>
    <script src="./script.js"></script>
</head>
<body>
    <header>
        Бронь
    </header>
    <form id="form1" runat="server">
        <table style="margin: auto">
            <tr>
                <td>
                    <label>ФИО:</label>
                </td>
                <td>
                    <input type="text" id="FIO" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <label>Ваш номер телефона:</label>
                </td>
                <td>
                    <input type="number" id="phonenumber" runat="server"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <label>Выберите номер для брони:</label>
                </td>
            </tr>
        </table>
        <div>
            <table style="margin:auto">
            <%=ShowHotelRooms()%>
            </table>
        </div>
        <div style="margin: auto">
            <button type="submit" style="position: relative; left: 45%">Подтвердить</button>
        </div>
        <div>
            <input hidden="hidden" type="text" id="chosenroomnumber" value="no-room" runat="server"/>
        </div>
        <div>
            
        </div>
    </form>
</body>
</html>