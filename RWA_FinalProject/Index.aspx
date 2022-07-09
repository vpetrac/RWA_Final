<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RWA_FinalProject.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="p-5">
        <asp:ScriptManager ID="SC1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="form-row">
                    <div class="form-group col-md-3">
                        <label for="inputState">Country</label>
                        <asp:DropDownList AutoPostBack="True" ID="filter_country" class="form-control" runat="server" OnDataBound="filter_country_DataBound" DataSourceID="SqlDataSourceCountries" DataTextField="Naziv" DataValueField="IDDrzava">
                            
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceCountries" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" SelectCommand="SELECT * FROM [Drzava]"></asp:SqlDataSource>
                    </div>
                    <div class="form-group col-md-3">
                        <label for="inputState">City</label>
                        <asp:DropDownList  AutoPostBack="True" ID="filter_city" class="form-control" runat="server"  DataSourceID="SqlDataSourceCities" DataTextField="Naziv" DataValueField="IDGrad">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceCities" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" SelectCommand="SELECT * FROM [Grad] WHERE ([DrzavaID] = @DrzavaID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="filter_country" Name="DrzavaID" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>
                    <div class="form-group col-md-1">
                        <label for="inputState">Per Page</label>
                        <asp:DropDownList AutoPostBack="True" ID="filter_size" class="form-control" runat="server" OnSelectedIndexChanged="filter_size_SelectedIndexChanged">
                            <asp:ListItem Value="10">10</asp:ListItem>
                            <asp:ListItem Value="25">25</asp:ListItem>
                            <asp:ListItem Value="50">50</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <asp:GridView ID="GridView1" runat="server" CssClass="table table-dark" AutoGenerateColumns="False" DataKeyNames="IDKupac" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="IDKupac" HeaderText="IDKupac" InsertVisible="False" ReadOnly="True"/>
                        <asp:BoundField DataField="Ime" HeaderText="Ime" SortExpression="Ime" />
                        <asp:BoundField DataField="Prezime" HeaderText="Prezime" SortExpression="Prezime" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="Telefon" HeaderText="Telefon" />
                        <asp:BoundField DataField="GradID" HeaderText="GradID" />
                        <asp:HyperLinkField datanavigateurlformatstring="~\Racun\PremaKupcu\{0}"  HeaderText="Pregled racuna" Text="Pregled" DataNavigateUrlFields="IDKupac" />

                    </Columns>
                </asp:GridView>
            </ContentTemplate>

        </asp:UpdatePanel>

        <asp:SqlDataSource ID="SqlDataSource1"
            runat="server"
            ConnectionString="<%$ ConnectionStrings:AdventureWorksOBPConnectionString2 %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Kupac] WHERE ([GradID] = @GradID)" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Kupac] WHERE [IDKupac] = @original_IDKupac AND [Ime] = @original_Ime AND [Prezime] = @original_Prezime AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([Telefon] = @original_Telefon) OR ([Telefon] IS NULL AND @original_Telefon IS NULL)) AND (([GradID] = @original_GradID) OR ([GradID] IS NULL AND @original_GradID IS NULL))" InsertCommand="INSERT INTO [Kupac] ([Ime], [Prezime], [Email], [Telefon], [GradID]) VALUES (@Ime, @Prezime, @Email, @Telefon, @GradID)" UpdateCommand="UPDATE [Kupac] SET [Ime] = @Ime, [Prezime] = @Prezime, [Email] = @Email, [Telefon] = @Telefon, [GradID] = @GradID WHERE [IDKupac] = @original_IDKupac AND [Ime] = @original_Ime AND [Prezime] = @original_Prezime AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND (([Telefon] = @original_Telefon) OR ([Telefon] IS NULL AND @original_Telefon IS NULL)) AND (([GradID] = @original_GradID) OR ([GradID] IS NULL AND @original_GradID IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_IDKupac" Type="Int32" />
                <asp:Parameter Name="original_Ime" Type="String" />
                <asp:Parameter Name="original_Prezime" Type="String" />
                <asp:Parameter Name="original_Email" Type="String" />
                <asp:Parameter Name="original_Telefon" Type="String" />
                <asp:Parameter Name="original_GradID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Ime" Type="String" />
                <asp:Parameter Name="Prezime" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Telefon" Type="String" />
                <asp:Parameter Name="GradID" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="filter_city" Name="GradID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Ime" Type="String" />
                <asp:Parameter Name="Prezime" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Telefon" Type="String" />
                <asp:Parameter Name="GradID" Type="Int32" />
                <asp:Parameter Name="original_IDKupac" Type="Int32" />
                <asp:Parameter Name="original_Ime" Type="String" />
                <asp:Parameter Name="original_Prezime" Type="String" />
                <asp:Parameter Name="original_Email" Type="String" />
                <asp:Parameter Name="original_Telefon" Type="String" />
                <asp:Parameter Name="original_GradID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>

</asp:Content>
