Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Private connectionString As String = "workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True"

    Private Sub CustomerReg_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateDropDownLists()

        End If
    End Sub

    Private Sub PopulateDropDownLists()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT DISTINCT [Customer_City], [Customer_State] FROM CUSTOMER_t"
            Dim cmd As New SqlCommand(query, con)

            Try
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim cityItem As New ListItem(reader("Customer_City").ToString())
                    Dim stateItem As New ListItem(reader("Customer_State").ToString())
                    DropDownList1.Items.Add(cityItem)
                    DropDownList2.Items.Add(stateItem)
                End While

                reader.Close()
            Catch ex As Exception
                Label1.Text = "Error while populating drop-down lists: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidInput() Then
            Dim name As String = ntext.Text
            Dim address As String = atext.Text
            Dim city As String = DropDownList1.SelectedItem.Text
            Dim state As String = DropDownList2.SelectedItem.Text
            Dim postalCode As String = ptext.Text

            Dim con As New SqlConnection(connectionString)
            Try
                con.Open()
                Dim customerid As Integer = GetId(con)
                Session("CustomerId") = customerid

                Dim query As String = "INSERT INTO CUSTOMER_t ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Customer_State], [Postal_Code])"
                query &= "VALUES (@Customer_Id, @Customer_Name, @Customer_Address, @Customer_City, @Customer_State, @Postal_Code)"

                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Customer_Id", customerid)
                cmd.Parameters.AddWithValue("@Customer_Name", name)
                cmd.Parameters.AddWithValue("@Customer_Address", address)
                cmd.Parameters.AddWithValue("@Customer_City", city)
                cmd.Parameters.AddWithValue("@Customer_State", state)
                cmd.Parameters.AddWithValue("@Postal_Code", postalCode)

                Dim inserted As Integer = cmd.ExecuteNonQuery()

                If inserted > 0 Then
                    Label1.Text = "Customer added successfully!"
                Else
                    Label1.Text = "Failed to add customer. Please try again."
                End If
            Catch ex As Exception
                Label1.Text = "Error while adding customer: " & ex.Message
            Finally
                con.Close()
            End Try

        Else
            Label1.Text = "Enter Valid Input"


        End If
        ntext.Text = ""
        atext.Text = ""
        ptext.Text = ""
        DropDownList1.Controls.Clear()
        DropDownList2.Controls.Clear()
    End Sub

    Private Function GetId(con As SqlConnection) As Integer
        Dim customerid As Integer = 0
        Dim query As String = "SELECT MAX(Customer_Id) FROM CUSTOMER_t"
        Dim cmd As New SqlCommand(query, con)

        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
            customerid = Convert.ToInt32(result) + 1
        Else
            customerid = 1
        End If

        Return customerid
    End Function

    Private Function ValidInput() As Boolean
        If String.IsNullOrWhiteSpace(ntext.Text) OrElse String.IsNullOrWhiteSpace(atext.Text) OrElse
            DropDownList1.SelectedIndex = 0 OrElse DropDownList2.SelectedIndex = 0 OrElse
            String.IsNullOrWhiteSpace(ptext.Text) Then
            Label1.Text = "Please fill in all fields."
            Return False
        End If

        Return True
    End Function
End Class
