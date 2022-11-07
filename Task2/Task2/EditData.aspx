<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditData.aspx.cs" Inherits="Task2.EditData" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <h2>Edit Data</h2>   




    <div class="row mb-3">
            <label class="col-sm-3 col-form1-label">Temperature</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtTemp" runat="server" Text =""></asp:TextBox>
                <asp:Label ID="lblErrorTemp" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>

       <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Humidity</label>
            <div class="col-sm-6">
                
                <asp:TextBox ID="txthumidity" runat="server" Text =""></asp:TextBox>
                <asp:Label ID="lblErrorHum" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>
        <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Weight</label>
            <div class="col-sm-6">
               
                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
                <asp:Label ID="lblErrorWeight" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>
        <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Width</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
                <asp:Label ID="lblErrorWidth" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>
        <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Length</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
                <asp:Label ID="lblErrorLength" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>
        <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Depth</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtDepth" runat="server"></asp:TextBox>
                <asp:Label ID="lblErrorDepth" runat="server" Text="" ForeColor ="Red"></asp:Label>
            </div>
        </div>

    <div class="row mb-3">
            <label class="col-sm-3 col-form-label">Checked</label>
            <div class="col-sm-6">
                <asp:CheckBox ID="chkChecked" runat="server" />
            </div>
        </div>

        <div class="col-sm-3">
            <div class="offset-sm-3 d-grid">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass ="btn btn-primary" OnClick ="btnSubmit_Click1" />
           </div>
        </div>
        <div class="col-sm-3 d-grid">
            <a class="btn btn-outline-primary" href ="/" role="button">Cancel</a>
        </div>
    
  

</asp:Content>
