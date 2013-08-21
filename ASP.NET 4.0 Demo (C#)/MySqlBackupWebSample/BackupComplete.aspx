<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BackupComplete.aspx.cs" Inherits="MySqlBackupWebSample.BackupComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Backup Completed.</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        The SQL Dump File will be deleted after 15 minutes.</p>
    <p>
        Download &gt;&gt; 
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Download backup.sql" />
    </p>
    <hr />
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Show the content of Dump File" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Font-Names="Courier New" 
            Font-Size="Small"></asp:Label>
    </p>
</asp:Content>
