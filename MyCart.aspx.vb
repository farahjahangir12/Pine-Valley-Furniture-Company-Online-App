
Imports System.Data.SqlClient
Imports Shop
Partial Class _MyCart
    Inherits System.Web.UI.Page

    Private Sub MyCart_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim cartData As List(Of CartItem) = TryCast(Session("CartData"), List(Of CartItem))
        Dim bill As Integer = 0
        If cartData IsNot Nothing Then

            For Each cartItem As CartItem In cartData
                Dim newRow As New TableRow()

                Dim cellProductName As New TableCell()
                cellProductName.Text = cartItem.ProductName
                cellProductName.Style("padding") = "5px"

                Dim cellPrice As New TableCell()
                cellPrice.Text = "$" & cartItem.ProductPrice * cartItem.ProductQuantity
                bill += cartItem.ProductQuantity * CType(cartItem.ProductPrice, Integer)
                cellPrice.Style("padding") = "5px"


                Dim cellQuantity As New TableCell()
                cellQuantity.Text = cartItem.ProductQuantity.ToString()
                cellQuantity.Style("padding") = "5px"

                newRow.Cells.Add(cellProductName)
                newRow.Cells.Add(cellPrice)
                newRow.Cells.Add(cellQuantity)

                Cart.Rows.Add(newRow)
            Next
            ViewState("Bill") = bill
        Else
            Label1.Text = "No Items in cart"
        End If

    End Sub

    Private Sub Order_Click(sender As Object, e As EventArgs) Handles Order.Click
        Dim cartData As List(Of CartItem) = TryCast(Session("CartData"), List(Of CartItem))
        Dim currentDate As Date = Date.Now.Date
        Dim customerId As Integer = Convert.ToInt32(Session("CustomerId"))
        Dim con As New SqlConnection("workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True")
        Dim orderId As Integer = 0

        If cartData IsNot Nothing Then
            Try
                con.Open()
                orderId = GetId(con)
                Dim query1 As String = "INSERT INTO ORDER_t ([Order_Id], [Customer_Id],[Order_Date]) VALUES (@Order_Id, @Customer_Id,@Order_Date)"

                Dim cmd As New SqlCommand(query1, con)
                cmd.Parameters.AddWithValue("@Order_Id", orderId)
                cmd.Parameters.AddWithValue("@Customer_Id", customerId)
                cmd.Parameters.AddWithValue("@Order_Date", currentDate)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Label1.Text = "Error while placing order: " & ex.Message
            Finally
                con.Close()
            End Try
            Dim con2 As New SqlConnection("workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True")
            Try
                con2.Open()
                For Each cartItem As CartItem In cartData
                    Dim productId As Integer = -1
                    Dim query3 As String = "SELECT [Product_Id] FROM PRODUCT_t WHERE [Product_Description]= @productName"
                    Dim cmd3 As New SqlCommand(query3, con2)
                    cmd3.Parameters.AddWithValue("@productName", cartItem.ProductName)
                    productId = Convert.ToInt32(cmd3.ExecuteScalar())


                    If productId <> -1 Then
                        Dim query2 As String = "INSERT INTO Order_line_t ([Order_Id], [Product_Id],[Ordered_Quantity]) VALUES (@Order_Id, @Product_Id, @Ordered_Quantity)"
                        Dim cmd2 As New SqlCommand(query2, con2)
                        cmd2.Parameters.AddWithValue("@Order_Id", orderId)
                        cmd2.Parameters.AddWithValue("@Product_Id", productId)
                        cmd2.Parameters.AddWithValue("@Ordered_Quantity", cartItem.ProductQuantity)
                        cmd2.ExecuteNonQuery()
                    End If
                Next

            Catch ex As Exception
                Label1.Text = ex.Message
            Finally
                con2.Close()
            End Try

            Dim bill As Integer = CType(ViewState("Bill"), Integer)
            BillText.Text = "Your Bill is $ " & bill.ToString

        End If


    End Sub




    Private Function GetId(con As SqlConnection) As Integer
        Dim orderid As Integer = 0
        Dim query As String = "SELECT MAX(Order_Id) FROM ORDER_t"
        Dim cmd As New SqlCommand(query, con)
        Try

            Dim Result As Object = cmd.ExecuteScalar()
            If Result IsNot DBNull.Value AndAlso Result IsNot Nothing Then
                orderid = Convert.ToInt32(Result) + 1
            Else
                orderid = 1
            End If
        Catch ex As Exception
            Label1.Text = ex.Message

        End Try

        Return orderid
    End Function
End Class
