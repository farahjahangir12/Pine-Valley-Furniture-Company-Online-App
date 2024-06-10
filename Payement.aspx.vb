
Imports System.Data.SqlClient
Imports System.Reflection.Emit

Partial Class Payement
    Inherits System.Web.UI.Page

    Private Sub Payement_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateDropDownLists()
        End If
    End Sub


    Private Sub PopulateDropDownLists()
        Dim connectionstring As String = "workstation id=PineValley.mssql.somee.com;packet size=4096;user id=farahjahangir_SQLLogin_1;pwd=74kd7f8awc;data source=PineValley.mssql.somee.com;persist security info=False;initial catalog=PineValley;TrustServerCertificate=True"
        Dim con As New SqlConnection(connectionstring)
        Dim query As String = "SELECT DISTINCT [Customer_State] FROM CUSTOMER_t"
            Dim cmd As New SqlCommand(query, con)

            Try
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()

                    Dim stateItem As New ListItem(reader("Customer_State").ToString())
                    ddl.Items.Add(stateItem)

                End While
                reader.Close()
            Catch ex As Exception
                Label1.Text = "Error while populating drop-down lists: " & ex.Message
            End Try

    End Sub
End Class
