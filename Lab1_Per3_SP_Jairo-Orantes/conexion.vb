Imports System.Data.SqlClient

Public Class conexion
    Protected cnn As New SqlConnection

    Public idususario As Integer

    'Funcion para conectarse a la base de datos
    Protected Function conectado()
        Try
            cnn = New SqlConnection("Data Source=JAIRO-ORANTES\SQLEXPRESS;Initial Catalog=ClientesPOO;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Funcion para desconectarse de la base de datos
    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
