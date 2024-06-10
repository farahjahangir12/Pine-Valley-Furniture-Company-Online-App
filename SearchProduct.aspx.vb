Imports System.Data
Imports System.Data.SqlClient

Partial Class SearchProduct
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateInventoryDropdown()
        End If
    End Sub

    Private Sub PopulateInventoryDropdown()

        Dim connectionString As String = "workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True"
        Dim con As New SqlConnection(connectionString)


        Dim query As String = "SELECT [Product_Description] FROM PRODUCT_t"
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader


        Try
            con.Open()
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim newItem As New ListItem()


                newItem.Text = reader("Product_Description")

                inventoryDropDown.Items.Add(newItem)
            End While
            reader.Close()

        Catch er As Exception
            Label1.Text = "Error while opening connection"
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim index As String = inventoryDropDown.SelectedItem.Text
        Dim selected As Integer = inventoryDropDown.SelectedIndex
        If selected = 0 Then
            Label1.Text = "Please select a product"

        Else
            details.Visible = True

            Dim connectionString As String = "workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True"
            Dim con As New SqlConnection(connectionString)


            Dim query As String = "SELECT [Standard_Price], [Product_Finish] FROM PRODUCT_t "
            query &= "WHERE [Product_Description] = @Description"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Description", index)

            Dim reader As SqlDataReader


            Try
                con.Open()
                reader = cmd.ExecuteReader()

                While reader.Read()

                    Price.Text = "Standard Price: " & "$" & reader("Standard_Price").ToString()

                    Finish.Text = "Product Finish: " & reader("Product_Finish").ToString()


                End While
                reader.Close()

            Catch er As Exception
                Label1.Text = "Error while opening connection"
            Finally
                con.Close()
            End Try

        End If
    End Sub

End Class
