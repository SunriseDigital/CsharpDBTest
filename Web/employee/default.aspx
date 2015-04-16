<%@ Page Language="C#" MasterPageFile="~/Master/Pc.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.employee.Default" %>

<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="panel panel-default">
        <div class="panel-heading">社員リスト</div>
        <table class="table">
            <tr>
                <th>社員番号</th>
                <th>氏名</th>
                <th>給料</th>
                <th>入社日</th>
                <th>編集</th>
            </tr>
             <% foreach(Dictionary<string, string> employee in employees){ %>
            <tr>
                <td><%= employee["employee_id"] %></td>
                <td><%= employee["name"] %></td>
                <td><%= employee["salary"] %></td>
                <td><%= employee["employee_date"] %></td>
                <td><a href="/employee/edit?id=<%= employee["employee_id"] %>">編集</a></td>
            </tr>
            <% } %>
        </table>
    </div>
</asp:Content>
