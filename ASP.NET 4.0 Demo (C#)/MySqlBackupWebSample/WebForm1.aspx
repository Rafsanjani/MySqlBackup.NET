<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MySqlBackupWebSample.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="content" 
            style="margin: 0px; padding: 5px 0px 0px 5px; line-height: 17px; overflow: hidden; color: rgb(85, 85, 85); font-family: Verdana, 'BitStream vera Sans', Tahoma, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); ">
            <p style="margin: 0px 0px 10px; padding: 1em 0px; ">
                <a href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/">
                http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/</a></p>
            <p style="margin: 0px 0px 10px; padding: 1em 0px; ">
                Have you ever wondered which version of MySQL supports a particular feature? I 
                certainly have. Here is a table listing various major features and storage 
                engines and which versions of MySQL support them, from 3.23 through 5.1. I have 
                cross linked to the MySQL online manual wherever possible, though there are 
                still some gaps.</p>
            <span id="more-10"></span>
            <table style="background-color: rgb(255, 255, 255); border: 2px solid rgb(204, 204, 204); border-collapse: collapse; margin: 5px 0px 10px; overflow: auto; background-position: initial initial; background-repeat: initial initial; ">
                <tr>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        Feature</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        3.23</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        4.0</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        4.1</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        5.0</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        5.1</th>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Statement based replication</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#1" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">1</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/query-cache.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Query Cache</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Unions</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/4.1/en/internationalization-localization.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Character Sets</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#2" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">2</a></td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Limited<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#3" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">3</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#4" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">4</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Subqueries</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/4.1/en/spatial-extensions.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">OpenGIS spatial 
                        types</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/4.1/en/time-zone-support.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Timezone support</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#5" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">5</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/4.1/en/sql-syntax-prepared-statements.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Prepared 
                        statements</a>(server side)</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#6" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">6</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Stored Procedures</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Triggers</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Views</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Server side Cursors</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.0/en/information-schema.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">INFORMATION_SCHEMA</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Row based replication</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#7" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">7</a></td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/events.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Event Scheduler</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/xml-functions.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">XML/Xpath 
                        functions</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        Storage Engine</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        3.23</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        4.0</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        4.1</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        5.0</th>
                    <th style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; background-color: rgb(237, 239, 240); background-position: initial initial; background-repeat: initial initial; ">
                        5.1</th>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/4.1/en/isam-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">ISAM</a></td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Deprecated<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#8" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">8</a></td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Deprecated</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/myisam-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">MyISAM</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/memory-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Memory</a><span 
                            class="Apple-converted-space">&nbsp;</span>(Heap)</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/merge-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Merge</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#9" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">9</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/innodb.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">InnoDB</a></td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Not standard<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#10" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">10</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.0/en/bdb-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">BDB</a><span 
                            class="Apple-converted-space">&nbsp;</span>(BerkeleyDB)</td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Source only</td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Source only</td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Source only</td>
                    <td class="partial" 
                        style="background-color: rgb(255, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Source only</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/archive-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Archive</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#11" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">11</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/csv-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">CSV</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#12" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">12</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/blackhole-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Blackhole</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#13" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">13</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/mysql-cluster.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">NDBCluster</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#14" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">14</a></td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Separate Product<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#15" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">15</a></td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/federated-storage-engine.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">Federated</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes</td>
                </tr>
                <tr>
                    <td style="border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        <a href="http://dev.mysql.com/doc/refman/5.1/en/se-db2.html" 
                            style="color: rgb(41, 112, 166); text-decoration: none; ">IBMDB2I</a></td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="unavailable" 
                        style="background-color: rgb(255, 102, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        No</td>
                    <td class="available" 
                        style="background-color: rgb(102, 255, 102); border: 1px solid rgb(204, 204, 204); padding: 3px 10px; text-align: left; vertical-align: top; ">
                        Yes<a class="super" 
                            href="http://weevilgenius.net/2010/04/mysql-version-comparison-matrix/#16" 
                            style="color: rgb(41, 112, 166); text-decoration: none; vertical-align: super; font-size: 0.75em; ">16</a></td>
                </tr>
            </table>
            <h3 style="margin: 0px; padding: 1em 0px; font-weight: bold; letter-spacing: -0.05em; font-family: Arial; font-size: 18px; ">
                Notes</h3>
            <div style="margin: 0px; padding: 0px; ">
                <a name="1" style="color: rgb(41, 112, 166); text-decoration: none; ">[1]</a>: 
                Statement-based replication support was added in MySQL 3.23.15</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="2" style="color: rgb(41, 112, 166); text-decoration: none; ">[2]</a>: 
                MySQL 3.23 allows you to set a single character set for the server. The default 
                is latin1. Changing it requires restarting (and possibly recompiling) the 
                server.</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="3" style="color: rgb(41, 112, 166); text-decoration: none; ">[3]</a>: 
                MySQL 4.0 added limited character set support for the MyISAM and MEMORY engines. 
                The character set and collation in this version is a single entity.</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="4" style="color: rgb(41, 112, 166); text-decoration: none; ">[4]</a>: 
                MySQL 4.1 added full character set and collation settings for MyISAM, MEMORY, 
                and InnoDB (in version 4.1.2) engines. See the<span 
                    class="Apple-converted-space">&nbsp;</span><a 
                    href="http://dev.mysql.com/doc/refman/4.1/en/charset.html" 
                    style="color: rgb(41, 112, 166); text-decoration: none; ">manual</a><span 
                    class="Apple-converted-space">&nbsp;</span>for more details.</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="5" style="color: rgb(41, 112, 166); text-decoration: none; ">[5]</a>: 
                Multiple timezone support added in MySQL 4.1.3</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="6" style="color: rgb(41, 112, 166); text-decoration: none; ">[6]</a>: 
                Non-binary SQL interface for prepared statements added in MySQL 4.1.3</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="7" style="color: rgb(41, 112, 166); text-decoration: none; ">[7]</a>: 
                Row-based replication support was added in MySQL 5.1.5. Mixed format replication 
                was added in MySQL 5.1.8. See the<span class="Apple-converted-space">&nbsp;</span><a 
                    href="http://dev.mysql.com/doc/refman/5.1/en/replication-formats.html" 
                    style="color: rgb(41, 112, 166); text-decoration: none; ">manual</a><span 
                    class="Apple-converted-space">&nbsp;</span>for more details.</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="8" style="color: rgb(41, 112, 166); text-decoration: none; ">[8]</a>: 
                Prior to MySQL 3.23, ISAM was the only storage engine available. It was replaced 
                by the improved MyISAM engine in release 3.23.0</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="9" style="color: rgb(41, 112, 166); text-decoration: none; ">[9]</a>: 
                Merge storage engine support was added in MySQL 3.23.25</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="10" style="color: rgb(41, 112, 166); text-decoration: none; ">[10]</a>: 
                InnoDB support has to be manually compiled into the binary for My SQL 3.23.x (or 
                use the MySQL Max binary for that version).</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="11" style="color: rgb(41, 112, 166); text-decoration: none; ">[11]</a>: 
                Archive storage engine support was added in MySQL 4.1.3</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="12" style="color: rgb(41, 112, 166); text-decoration: none; ">[12]</a>: 
                CSV storage engine support was added in MySQL 4.1.4</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="13" style="color: rgb(41, 112, 166); text-decoration: none; ">[13]</a>: 
                Blackhole storage engine support was added in MySQL 4.1.11</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="14" style="color: rgb(41, 112, 166); text-decoration: none; ">[14]</a>: 
                NDBCluster storage engine support was added in MySQL 4.1.3</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="15" style="color: rgb(41, 112, 166); text-decoration: none; ">[15]</a>: 
                NDBCluster engine is not available in standard releases of MySQL 5.1. Use the<span 
                    class="Apple-converted-space">&nbsp;</span><a 
                    href="http://dev.mysql.com/doc/refman/5.1/en/mysql-cluster.html" 
                    style="color: rgb(41, 112, 166); text-decoration: none; ">MySQL Cluster</a><span 
                    class="Apple-converted-space">&nbsp;</span>releases instead.</div>
            <div style="margin: 0px; padding: 0px; ">
                <a name="16" style="color: rgb(41, 112, 166); text-decoration: none; ">[16]</a>: 
                IBMDB2I storage engine support was added in MySQL 5.1.35</div>
            <div class="fixed" style="margin: 0px; padding: 0px; clear: both; ">
            </div>
        </div>
        <div class="under" 
            style="margin: 0px 0px 10px; padding: 0px; height: 16px; line-height: 16px; font-size: 11px; color: rgb(85, 85, 85); font-family: Verdana, 'BitStream vera Sans', Tahoma, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); ">
            <br class="Apple-interchange-newline" />
        </div>
    
    </div>
    </form>
</body>
</html>
