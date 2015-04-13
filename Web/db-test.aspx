<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="db-test.aspx.cs" Inherits="Web.db_test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
        <% foreach(Dictionary<string, string> employee in employees){ %>
        <ul>
            <li><%= employee["name"] %></li>
        </ul>
        <% } %>
    </div>
</body>
</html>
