Imports System.ComponentModel
Public Class FormClientes

    Private dt As New DataTable
    'Proceso al momento de cargar el formulario de clientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        txtIdClientes.Enabled = False
        txtNombreClientes.Enabled = False
        txtApellidoCliente.Enabled = False
        txtdireccionCliente.Enabled = False
        txtTelefonoClientes.Enabled = False
        txtEmailCliente.Enabled = False

    End Sub

    'Proceso para mostar los datos en la tabla
    Private Sub mostrar()
        Try
            Dim func As New funciones_cliente
            dt = func.mostrar()
            DataGridViewClientes.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then
                DataGridViewClientes.DataSource = dt
                txtBusquedaClientes.Enabled = True
                DataGridViewClientes.ColumnHeadersVisible = True
                linklblInexistente.Enabled = False
            Else
                DataGridViewClientes.DataSource = Nothing
                txtBusquedaClientes.Enabled = False
                DataGridViewClientes.ColumnHeadersVisible = False
                linklblInexistente.Enabled = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bttAgregarCliente.Enabled = True
        bttGuardarCliente.Enabled = False
        bttEditarCliente.Enabled = False
        bttEditarCliente.Visible = True
        bttEliminarCliente.Enabled = False
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbCampoCliente.Text & " like '" & txtBusquedaClientes.Text & "%'"
            If dv.Count <> 0 Then
                linklblInexistente.Visible = False
                DataGridViewClientes.DataSource = dv
                ocultar_columnas()
            Else
                linklblInexistente.Visible = True
                DataGridViewClientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        DataGridViewClientes.Columns(1).Visible = False
    End Sub

    Public Sub limpiar()
        'BttGuardarCliente.Visible = False
        txtIdClientes.Text = ""
        txtNombreClientes.Text = ""
        txtApellidoCliente.Text = ""
        txtdireccionCliente.Text = ""
        txtTelefonoClientes.Text = ""
        txtEmailCliente.Text = ""

    End Sub
    'Acciones al dar click al boton agregar
    Private Sub BttAgregarCliente_Click(sender As Object, e As EventArgs) Handles bttAgregarCliente.Click
        limpiar()
        mostrar()
        'Habilitar el boton guardar
        bttGuardarCliente.Enabled = True
        'activiacion de los textboxs
        txtIdClientes.Enabled = False
        txtNombreClientes.Enabled = True
        txtApellidoCliente.Enabled = True
        txtdireccionCliente.Enabled = True
        txtTelefonoClientes.Enabled = True
        txtEmailCliente.Enabled = True

    End Sub

    Private Sub BttGuardarCliente_Click(sender As Object, e As EventArgs) Handles bttGuardarCliente.Click
        'Condicion para validar que se hayan registrado datos en texboxs especificos
        If Me.ValidateChildren = True And txtNombreClientes.Text <> "" And txtdireccionCliente.Text <> "" And txtTelefonoClientes.Text <> "" And txtEmailCliente.Text <> "" Then
            Try
                Dim dts As New datos_clientes
                Dim func As New funciones_cliente
                dts.hnombre = txtNombreClientes.Text
                dts.hapellido = txtApellidoCliente.Text
                dts.hdireccion = txtdireccionCliente.Text
                dts.htelefono = txtTelefonoClientes.Text
                dts.hemail = txtTelefonoClientes.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Datos registrados", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    txtIdClientes.Enabled = False
                    txtNombreClientes.Enabled = False
                    txtApellidoCliente.Enabled = False
                    txtdireccionCliente.Enabled = False
                    txtTelefonoClientes.Enabled = False
                    txtEmailCliente.Enabled = False
                    'Acciones de botones
                    bttGuardarCliente.Enabled = False
                Else
                    MessageBox.Show("Datos no registrados", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falto ingresar datos obligatorios", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub DataGridViewClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellClick

        txtIdClientes.Text = DataGridViewClientes.SelectedCells.Item(1).Value
        txtNombreClientes.Text = DataGridViewClientes.SelectedCells.Item(2).Value
        txtApellidoCliente.Text = DataGridViewClientes.SelectedCells.Item(3).Value
        txtdireccionCliente.Text = DataGridViewClientes.SelectedCells.Item(4).Value
        txtTelefonoClientes.Text = DataGridViewClientes.SelectedCells.Item(5).Value
        txtEmailCliente.Text = DataGridViewClientes.SelectedCells.Item(6).Value


        bttEditarCliente.Enabled = True


        bttAgregarCliente.Enabled = False
        bttGuardarCliente.Enabled = False
        bttEliminarCliente.Enabled = False

        txtIdClientes.Enabled = False
        txtNombreClientes.Enabled = True
        txtApellidoCliente.Enabled = True
        txtdireccionCliente.Enabled = True
        txtTelefonoClientes.Enabled = True
        txtEmailCliente.Enabled = True
    End Sub

    'BOTON EDITAR
    Private Sub BttEditarCliente_Click(sender As Object, e As EventArgs) Handles bttEditarCliente.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere editar los datos del cliente?", "Modicando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            'Condicion para validar que se hayan registrado datos en texboxs especificos
            If Me.ValidateChildren = True And txtNombreClientes.Text <> "" And txtApellidoCliente.Text <> "" And txtdireccionCliente.Text <> "" And txtTelefonoClientes.Text <> "" And txtEmailCliente.Text <> "" And txtIdClientes.Text <> "" Then
                Try
                    Dim dts As New datos_clientes
                    Dim func As New funciones_cliente

                    dts.hidcliente = txtIdClientes.Text
                    dts.hnombre = txtNombreClientes.Text
                    dts.hapellido = txtApellidoCliente.Text
                    dts.hdireccion = txtdireccionCliente.Text
                    dts.htelefono = txtTelefonoClientes.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Datos de Cliente modificado correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        txtIdClientes.Enabled = False
                        txtNombreClientes.Enabled = False
                        txtApellidoCliente.Enabled = False
                        txtdireccionCliente.Enabled = False
                        txtTelefonoClientes.Enabled = False
                        txtEmailCliente.Enabled = False

                        cbeliminar.Checked = False
                        limpiar()
                    Else
                        MessageBox.Show("Datos no modificados", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falto ingresar datos obligatorios", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIdClientes.Enabled = False
                txtNombreClientes.Enabled = False
                txtApellidoCliente.Enabled = False
                txtdireccionCliente.Enabled = False
                txtTelefonoClientes.Enabled = False
                txtEmailCliente.Enabled = False
                limpiar()
            End If
        Else
            MessageBox.Show("Cancelando los cambios del registro", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdClientes.Enabled = False
            txtNombreClientes.Enabled = False
            txtApellidoCliente.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False
            txtEmailCliente.Enabled = False

            cbeliminar.Checked = False
            Call mostrar()
        End If
        limpiar()
        bttAgregarCliente.Enabled = True
        bttGuardarCliente.Enabled = False
        bttEditarCliente.Enabled = False
        bttEliminarCliente.Enabled = False
    End Sub

    'Proceso para que muestre la columna que contiene los checkbox para seleccionar el registro a eliminar
    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            DataGridViewClientes.Columns.Item("Eliminar").Visible = True
            bttEliminarCliente.Enabled = True
            bttAgregarCliente.Enabled = False
            bttEditarCliente.Enabled = False
            bttGuardarCliente.Enabled = False
        Else
            DataGridViewClientes.Columns.Item("Eliminar").Visible = False
            bttEliminarCliente.Enabled = False
            bttAgregarCliente.Enabled = True
            bttEditarCliente.Enabled = False
            bttGuardarCliente.Enabled = False
            limpiar()
            txtIdClientes.Enabled = False
            txtNombreClientes.Enabled = False
            txtApellidoCliente.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False
            txtEmailCliente.Enabled = False


        End If

    End Sub
    'Proceso que muestra los checkbox de todas las filas de los registros
    Private Sub DataGridViewClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellContentClick
        If e.ColumnIndex = Me.DataGridViewClientes.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridViewClientes.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
            bttEliminarCliente.Enabled = True
        End If
    End Sub
    'BOTON ELIMINAR
    Private Sub BttEliminarCliente_Click(sender As Object, e As EventArgs) Handles bttEliminarCliente.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro que quiere eliminar a los clientes seleccionados?", "Eliminado registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In DataGridViewClientes.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New datos_clientes
                        Dim func As New funciones_cliente
                        vdb.hidcliente = onekey

                        If func.eliminar(vdb) Then
                            cbeliminar.Checked = False
                            txtIdClientes.Enabled = False
                            txtNombreClientes.Enabled = False
                            txtApellidoCliente.Enabled = False
                            txtdireccionCliente.Enabled = False
                            txtTelefonoClientes.Enabled = False
                            txtEmailCliente.Enabled = False

                        Else
                            MessageBox.Show("El cliente no fue eliminado", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cbeliminar.Checked = False
                            txtIdClientes.Enabled = False
                            txtNombreClientes.Enabled = False
                            txtApellidoCliente.Enabled = False
                            txtdireccionCliente.Enabled = False
                            txtTelefonoClientes.Enabled = False
                            txtEmailCliente.Enabled = False
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando la eliminación de registros", "Eliminado registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbeliminar.Checked = False
            txtIdClientes.Enabled = False
            txtNombreClientes.Enabled = False
            txtApellidoCliente.Enabled = False
            txtdireccionCliente.Enabled = False
            txtTelefonoClientes.Enabled = False
            txtEmailCliente.Enabled = False
            Call mostrar()
        End If
        Call limpiar()
        bttAgregarCliente.Enabled = True
    End Sub

    Private Sub txtBusquedaClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaClientes.TextChanged
        buscar()
    End Sub
End Class
