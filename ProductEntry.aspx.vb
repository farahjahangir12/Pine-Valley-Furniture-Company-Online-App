
Imports System.Data.SqlClient

Partial Class _ProductEntry
    Inherits System.Web.UI.Page


    Protected Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Dim productId As Integer = Integer.Parse(ProductIdTextBox.Text)
        Dim description As String = DescriptionTextBox.Text
        Dim productFinish As String = ProductFinishTextBox.Text
        Dim standardPrice As Decimal = Decimal.Parse(StandardPriceTextBox.Text)


        Dim connectionString As String = "workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True"


        Dim insertQuery As String = "INSERT INTO PRODUCT_t ([Product_Id], [Product_Finish], [Product_Description], [Standard_Price]) VALUES (@ProductId, @ProductFinish, @Description, @StandardPrice)"
        Dim con As New SqlConnection(connectionString)
        Dim inserted As Integer
        Dim cmd As New SqlCommand(insertQuery, con)
        Try
            con.Open()
            cmd.Parameters.AddWithValue("@ProductId", productId)
            cmd.Parameters.AddWithValue("@ProductFinish", productFinish)
            cmd.Parameters.AddWithValue("@Description", description)
            cmd.Parameters.AddWithValue("@StandardPrice", standardPrice)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Label1.Text = "Connection Error"

        Finally
            con.Close()
        End Try
        If inserted >= 1 Then
            Label1.Text = "Record Inserted"
        End If


    End Sub

End Class
