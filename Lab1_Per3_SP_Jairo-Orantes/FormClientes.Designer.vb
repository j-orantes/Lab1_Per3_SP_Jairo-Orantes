<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.bttEliminarCliente = New System.Windows.Forms.Button()
        Me.txtEmailCliente = New System.Windows.Forms.TextBox()
        Me.txtfechaCliente = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoClientes = New System.Windows.Forms.TextBox()
        Me.txtdireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreClientes = New System.Windows.Forms.TextBox()
        Me.txtIdClientes = New System.Windows.Forms.TextBox()
        Me.bttGuardarCliente = New System.Windows.Forms.Button()
        Me.txtBusquedaClientes = New System.Windows.Forms.TextBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttEditarCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.linklblInexistente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttAgregarCliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCampoCliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttEliminarCliente
        '
        Me.bttEliminarCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bttEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttEliminarCliente.Location = New System.Drawing.Point(297, 22)
        Me.bttEliminarCliente.Name = "bttEliminarCliente"
        Me.bttEliminarCliente.Size = New System.Drawing.Size(87, 34)
        Me.bttEliminarCliente.TabIndex = 9
        Me.bttEliminarCliente.Text = "Eliminar"
        Me.bttEliminarCliente.UseVisualStyleBackColor = False
        '
        'txtEmailCliente
        '
        Me.txtEmailCliente.Location = New System.Drawing.Point(86, 307)
        Me.txtEmailCliente.Name = "txtEmailCliente"
        Me.txtEmailCliente.Size = New System.Drawing.Size(265, 23)
        Me.txtEmailCliente.TabIndex = 12
        '
        'txtfechaCliente
        '
        Me.txtfechaCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechaCliente.Location = New System.Drawing.Point(132, 223)
        Me.txtfechaCliente.Name = "txtfechaCliente"
        Me.txtfechaCliente.Size = New System.Drawing.Size(219, 23)
        Me.txtfechaCliente.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Nacimiento :"
        '
        'txtTelefonoClientes
        '
        Me.txtTelefonoClientes.Location = New System.Drawing.Point(86, 265)
        Me.txtTelefonoClientes.Name = "txtTelefonoClientes"
        Me.txtTelefonoClientes.Size = New System.Drawing.Size(265, 23)
        Me.txtTelefonoClientes.TabIndex = 11
        '
        'txtdireccionCliente
        '
        Me.txtdireccionCliente.Location = New System.Drawing.Point(86, 146)
        Me.txtdireccionCliente.Multiline = True
        Me.txtdireccionCliente.Name = "txtdireccionCliente"
        Me.txtdireccionCliente.Size = New System.Drawing.Size(265, 59)
        Me.txtdireccionCliente.TabIndex = 10
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.Location = New System.Drawing.Point(86, 106)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(265, 23)
        Me.txtApellidoCliente.TabIndex = 9
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Location = New System.Drawing.Point(86, 66)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(265, 23)
        Me.txtNombreClientes.TabIndex = 8
        '
        'txtIdClientes
        '
        Me.txtIdClientes.Location = New System.Drawing.Point(86, 27)
        Me.txtIdClientes.Name = "txtIdClientes"
        Me.txtIdClientes.Size = New System.Drawing.Size(100, 23)
        Me.txtIdClientes.TabIndex = 7
        '
        'bttGuardarCliente
        '
        Me.bttGuardarCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bttGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttGuardarCliente.Location = New System.Drawing.Point(111, 22)
        Me.bttGuardarCliente.Name = "bttGuardarCliente"
        Me.bttGuardarCliente.Size = New System.Drawing.Size(87, 34)
        Me.bttGuardarCliente.TabIndex = 8
        Me.bttGuardarCliente.Text = "Guardar"
        Me.bttGuardarCliente.UseVisualStyleBackColor = False
        '
        'txtBusquedaClientes
        '
        Me.txtBusquedaClientes.Location = New System.Drawing.Point(624, 7)
        Me.txtBusquedaClientes.Name = "txtBusquedaClientes"
        Me.txtBusquedaClientes.Size = New System.Drawing.Size(348, 23)
        Me.txtBusquedaClientes.TabIndex = 20
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(384, 9)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(69, 19)
        Me.cbeliminar.TabIndex = 19
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(384, 36)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.RowTemplate.Height = 25
        Me.DataGridViewClientes.Size = New System.Drawing.Size(588, 311)
        Me.DataGridViewClientes.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección :"
        '
        'bttEditarCliente
        '
        Me.bttEditarCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bttEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttEditarCliente.Location = New System.Drawing.Point(204, 22)
        Me.bttEditarCliente.Name = "bttEditarCliente"
        Me.bttEditarCliente.Size = New System.Drawing.Size(87, 34)
        Me.bttEditarCliente.TabIndex = 9
        Me.bttEditarCliente.Text = "Editar"
        Me.bttEditarCliente.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido :"
        '
        'linklblInexistente
        '
        Me.linklblInexistente.AutoSize = True
        Me.linklblInexistente.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.linklblInexistente.Location = New System.Drawing.Point(642, 183)
        Me.linklblInexistente.Name = "linklblInexistente"
        Me.linklblInexistente.Size = New System.Drawing.Size(88, 17)
        Me.linklblInexistente.TabIndex = 22
        Me.linklblInexistente.Text = "no hay datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'bttAgregarCliente
        '
        Me.bttAgregarCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bttAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttAgregarCliente.Location = New System.Drawing.Point(18, 22)
        Me.bttAgregarCliente.Name = "bttAgregarCliente"
        Me.bttAgregarCliente.Size = New System.Drawing.Size(87, 34)
        Me.bttAgregarCliente.TabIndex = 3
        Me.bttAgregarCliente.Text = "Nuevo"
        Me.bttAgregarCliente.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(303, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(10, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 36)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Registro de Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Cliente :"
        '
        'cbCampoCliente
        '
        Me.cbCampoCliente.FormattingEnabled = True
        Me.cbCampoCliente.Items.AddRange(New Object() {"nombre", "apellido"})
        Me.cbCampoCliente.Location = New System.Drawing.Point(459, 7)
        Me.cbCampoCliente.Name = "cbCampoCliente"
        Me.cbCampoCliente.Size = New System.Drawing.Size(159, 23)
        Me.cbCampoCliente.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bttEliminarCliente)
        Me.GroupBox2.Controls.Add(Me.bttEditarCliente)
        Me.GroupBox2.Controls.Add(Me.bttGuardarCliente)
        Me.GroupBox2.Controls.Add(Me.bttAgregarCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(588, 73)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmailCliente)
        Me.GroupBox1.Controls.Add(Me.txtfechaCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTelefonoClientes)
        Me.GroupBox1.Controls.Add(Me.txtdireccionCliente)
        Me.GroupBox1.Controls.Add(Me.txtApellidoCliente)
        Me.GroupBox1.Controls.Add(Me.txtNombreClientes)
        Me.GroupBox1.Controls.Add(Me.txtIdClientes)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 347)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cliente"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 434)
        Me.Controls.Add(Me.txtBusquedaClientes)
        Me.Controls.Add(Me.cbeliminar)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.linklblInexistente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbCampoCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormClientes"
        Me.Text = "CLIENTES"
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttEliminarCliente As Button
    Friend WithEvents txtEmailCliente As TextBox
    Friend WithEvents txtfechaCliente As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefonoClientes As TextBox
    Friend WithEvents txtdireccionCliente As TextBox
    Friend WithEvents txtApellidoCliente As TextBox
    Friend WithEvents txtNombreClientes As TextBox
    Friend WithEvents txtIdClientes As TextBox
    Friend WithEvents bttGuardarCliente As Button
    Friend WithEvents txtBusquedaClientes As TextBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bttEditarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents linklblInexistente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bttAgregarCliente As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCampoCliente As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
