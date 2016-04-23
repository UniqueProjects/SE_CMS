<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddLocation.aspx.cs" Inherits="SE_CMS_PROJECT.AddLocation" %>

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
               <td><label>Building Name</label></td>
               <td><asp:TextBox runat="server"  id="buildingName"/></td>
           </tr>
           <tr>
               <td><label>Building Latitude</label></td>
               <td><asp:TextBox runat="server"  id="buildingLatitude"/></td>

           </tr>
           <tr>
               <td><label>Building Longitude</label></td>
               <td><asp:TextBox runat="server"  id="buildingLongitude"/></td>

           </tr>
           <tr>
               <td><label>Enabled: </label></td>
               <td><asp:Checkbox runat="server"  id="buildingStatus"/></td>
           </tr>
        </table>
    
    </div>
        <asp:Button ID="btnAddLocation" runat="server" OnClick="btnAddLocation_Click" Text="Submit" />
        
    </form>
</body>
</html>
