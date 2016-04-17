<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="SE_CMS_PROJECT.LogInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <table>
       <tr>
           <td><asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label></td>
           <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
           <td><asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label></td>
           <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
       </tr>
       <tr>
           <td></td>
           <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />   <asp:Label ID="ErrorMsg" runat="server" Visible="false" ForeColor="Red" Text=" User not found "></asp:Label></td>

       </tr>
   </table> 
    </div>
        
        
        
        
        
    </form>
</body>
</html>
