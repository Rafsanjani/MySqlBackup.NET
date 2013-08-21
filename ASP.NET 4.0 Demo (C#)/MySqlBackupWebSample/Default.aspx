<%@ Page Title="Home Page" Language="C#" Async="true" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MySqlBackupWebSample._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
            Introduction</h2>
    <p>
            This site 
            is a Demo for an open source project of a programming tool (A Class) that can 
            backup/restore MySQL database in .NET Programming Language. It is an alternative 
            to MySqlDump. For more information, support, documentation, source code and bugs 
            report, please visit:
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="http://mysqlbackupnet.codeplex.com">http://mysqlbackupnet.codeplex.com</asp:HyperLink>
        </p>

            <table style="width:100%; border-collapse: collapse;">
                <tr>
                    <td style="padding: 5px; border: 1px solid #465767; background-color: #465767;">
                    
                        <asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="#DFDFDF" 
                            Text="Choose Task"></asp:Label>
                        
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lbVersionInfo" runat="server" Font-Size="Small" 
                            ForeColor="#DFDFDF"></asp:Label>
                        
                    </td>
                </tr>
                <tr>
                    <td style="padding: 10px; border: 1px solid #465767;">
                    
        <p>
            <asp:Button ID="btBackup" runat="server" onclick="btBackup_Click" 
                Text="Backup a MySQL Database" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btRestore" runat="server" onclick="btRestore_Click" 
                Text="Restore a MySQL Database" />
        </p>
        <p>
            MySQL Connection String: (eg: server=www.yourwebsite.com;user=root;password=qwerty;database=test;)</p>
    <p>
        <asp:TextBox ID="txtConnection" runat="server" Width="763px" 
            Font-Names="Courier New" Font-Size="Small"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
        <p>
        Select SQL Dump File (For Restore):<br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
    
        &nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" 
                Text="Ignore SQL syntax error during Import." />
    
        </p>
        <p>
            &nbsp;
            <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
    
        </p>
                        
                    </td>
                </tr>
            </table>

        
        <p>
            <strong>Download source code:</strong>
            <a href="http://mysqlbackupnet.codeplex.com/releases">
            http://mysqlbackupnet.codeplex.com/releases</a></p>
<p>
            <strong>Privacy Policy</strong> - All activities, inputs and outputs are not 
            logged and unable to be traced. The dump files created by anonymous user are 
            visible by public for 15 minutes and the files will be deleted after that. Users 
            can manually delete the files at [<em>Dump Files</em>] page. Deleted dump files 
            will disappear permanently.<br />
        </p>
    <p runat="server" id="pWarn">
<strong><em>Warning!</em></strong><em> Data transmission of this website is not 
        protected by secure connection (https). Data sent and received in human readable 
        clear text form without encryption. You are advised not to use the service 
        hosted here on your real and confidential website database. This service is hosted on free web hosting site, 
        there is web space limitation. Therefore, the services 
        hosted here are for testing purpose and 
        for mini size of MySQL database only.</em></p>
        <p>
    On using the services of this website, you are agreed to the 
        user agreement.<br />
    If you do not agree with the user agreement, do not use the services in this 
    website.<br />
        </p>
        <br />
            <table style="width: 100%; border-collapse: collapse;">
                <tr>
                    <td
                        
                        style="padding: 5px; border: 1px solid #5A6B7C; background-color: #465767;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
                            ForeColor="#F7F7F7" Text="User Agreement"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="padding: 5px; border: 1px solid #465767;">
                        The authors disclaim copyrights of this project (The services of this website). 
                        All the contents and releases of this project is not licensed.
                        <br />
                        <br />
                        THE CONTENTS AND RELEASES OF THIS PROJECT ARE PROVIDED &quot;AS IS&quot;, WITHOUT WARRANTY 
                        OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
                        MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO 
                        EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
                        WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
                        CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. &nbsp;<br />
                        <br />
                        In short, this project can be used for any purposes. Use at your own risk.</td>
                </tr>
            </table>
    
        <h2>
            <br />
            Acknowledgements for Free Web Hosting</h2>
        <p>
            Special thanks to <strong><a href="http://www.somee.com">somee.com</a></strong> 
            which provides a free web hosting for this project and enables MySqlBackup.NET to 
            present a real ASP.NET demo website.</p>
    
</asp:Content>
