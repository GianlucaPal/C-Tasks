<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Task2._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <h2>Measurements</h2>
    <asp:Table ID="Table1" runat="server" CellPadding ="20" GridLines="Both"  Width ="1000">
        <asp:TableHeaderRow> 
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell>Mean</asp:TableHeaderCell>
            <asp:TableHeaderCell>Highest</asp:TableHeaderCell>
            <asp:TableHeaderCell>Lowest</asp:TableHeaderCell>
            <asp:TableHeaderCell>Sum</asp:TableHeaderCell>
            <asp:TableHeaderCell>Variance</asp:TableHeaderCell>
            <asp:TableHeaderCell>Standard Deviation</asp:TableHeaderCell>
    </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>Temperature</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDTemp" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Humidity</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDHum" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Weight</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDWeight" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Width</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDWidth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Length</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDLength" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Depth</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblAvgDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMaxDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblMinDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSumDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblVarDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lblSDDepth" runat="server" Text="Label"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <a class="btn btn-primary btn-sm" href="/NewData.aspx">New measurements</a>
  <%--  <asp:ListBox ID="listFilter" runat="server" ></asp:ListBox>--%>

   <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" OnRowDataBound="GridView2_RowDataBound" >
    <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="Temperature" HeaderText="Temperature"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="humidity" HeaderText="Humidity"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Weight" HeaderText="Weight"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Width" HeaderText="Width"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Length" HeaderText="Length"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Depth" HeaderText="Depth"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Time" HeaderText="Time"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Name"/>        
        <asp:BoundField ItemStyle-Width="150px" DataField="Checked" HeaderText="Checked"/>
        <asp:BoundField ItemStyle-Width="150px" DataField="id" HeaderText="ID" />
        <asp:TemplateField ShowHeader="False" ItemStyle-HorizontalAlign ="Center" ItemStyle-Width ="75px">
            <ItemTemplate>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass ="btn btn-primary btn-sm"  OnClick="btnEdit_Click" Visible="false"/>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField ShowHeader="False" ItemStyle-HorizontalAlign ="Center" ItemStyle-Width ="100px">
            <ItemTemplate>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass ="btn btn-danger btn-sm" OnClick="btnDelete_Click" Visible ="false" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>   
</asp:Content>
