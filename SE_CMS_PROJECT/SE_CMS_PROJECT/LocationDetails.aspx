<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationDetails.aspx.cs" Inherits="SE_CMS_PROJECT.LocationDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>

                <asp:BoundField DataField="Location_Id" HeaderText="Location ID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="Location_Name" HeaderText="Name" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="Location_Latitude" HeaderText="Latitude" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="Location_Longitude" HeaderText="Longitude" ReadOnly="True" SortExpression="CustomerID" />
                <%--<asp:BoundField DataField="Location_Status" HeaderText="Status" ReadOnly="True" SortExpression="CustomerID" />--%>
                <asp:TemplateField>
                    <ItemTemplate>
               <asp:ImageButton ID="imgCheckMark" ImageUrl='<%# GetCheckMark((bool)Eval("Location_Status")) %>'   runat="server" ToolTip="" OnClick="imgCheckMark_Click"/>
                        <asp:HiddenField Id="hdnLocationID" runat="server" Value='<%#Eval("Location_Id")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
