Imports System.Data.SqlClient
Public Class funciones_cliente
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_clientes") With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = cnn
            }
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


    Public Function insertar(ByVal dts As datos_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@nombre", dts.hnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.hapellido)
            cmd.Parameters.AddWithValue("@direccion", dts.hdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.htelefono)
            cmd.Parameters.AddWithValue("@email", dts.hemail)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As datos_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcliente", dts.hidcliente)
            cmd.Parameters.AddWithValue("@nombre", dts.hnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.hapellido)
            cmd.Parameters.AddWithValue("@direccion", dts.hdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.htelefono)
            cmd.Parameters.AddWithValue("@email", dts.hemail)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As datos_clientes) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idcliente", SqlDbType.NVarChar, 50).Value = dts.hidcliente
            If cmd.ExecuteNonQuery Then
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
