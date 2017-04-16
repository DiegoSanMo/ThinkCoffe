Imports System.Data.SqlClient
Module Module1
    Public ex, ey As Integer
    Public mover As Boolean
    Public CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ "


    Public conexionSql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'thinkCoffee'; integrated security = true")
    Public comando As SqlCommand = conexionSql.CreateCommand
    Public lector As SqlDataReader


End Module
