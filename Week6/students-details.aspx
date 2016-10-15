<%@ Page Title="Students-details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students-details.aspx.cs" Inherits="Week6.students_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Details</h1>

    <div class="form-group">
        <label for="txtName" class="col-sm-3 control-label">LastName:</label>
        <asp:TextBox ID="txtLastName" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtName" class="col-sm-3 control-label">FirstName:</label>
        <asp:TextBox ID="txtFirstName" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtName" class="col-sm-3 control-label">EnrollmentDate:</label>
        <asp:TextBox ID="txtEnrollemntDate" runat="server" required Type="Date"/>
    </div>
   
    <asp:button class="btn btn-success col-sm-offset-3" ID="btnSave" runat="server" Text="save" OnClick="btnSave_Click" />
</asp:Content>
