<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BindArrays._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <asp:GridView ID="gridView1" runat="server" CssClass="table-striped"
                    AutoGenerateColumns="true" AllowPaging="true"
                    PageSize="10" Caption="One Dimensional Array">
                </asp:GridView>
            </div>
            <div class="col-sm-8">
                <asp:GridView ID="gridView2" runat="server" CssClass="table-striped"
                    AutoGenerateColumns="false" AllowPaging="true"
                    PageSize="10" Caption="Two Dimensional Array">
                    <Columns>
                        <asp:BoundField ItemStyle-Width="180px"
                            DataField="Text" HeaderText="Name" />
                        <asp:BoundField ItemStyle-Width="180px"
                            DataField="Value" HeaderText="Country" />
                    </Columns>

                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <asp:GridView ID="gridView3" runat="server" CssClass="table-striped"
                AutoGenerateColumns="false" AllowPaging="true"
                PageSize="10" Caption="Multi Dimensional Array">

                <Columns>
                    <asp:BoundField ItemStyle-Width="150px"
                        DataField="Name" HeaderText="Name" />
                    <asp:BoundField ItemStyle-Width="150px"
                        DataField="City" HeaderText="City" />

                    <asp:BoundField ItemStyle-Width="150px"
                        DataField="Country" HeaderText="Country" />

                </Columns>

            </asp:GridView>
        </div>
    </div>

</asp:Content>
