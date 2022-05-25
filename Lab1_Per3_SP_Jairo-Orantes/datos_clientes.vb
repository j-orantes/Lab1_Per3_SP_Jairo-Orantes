Public Class datos_clientes
    Dim idcliente As Integer

    Dim nombre, apellido, direccion, fecha_nacimiento, telefono, email As String

    'METODOS SEETERS Y GETTERS

    Public Property hidcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property

    Public Property hnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property hapellido
        Get
            Return apellido
        End Get
        Set(value)
            apellido = value
        End Set
    End Property

    Public Property hdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property hfecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property

    Public Property htelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property hemail
        Get
            Return email
        End Get
        Set(value)
            email = value
        End Set
    End Property

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal fecha_nacimiento As String, ByVal telefono As String, ByVal email As String)
        hidcliente = idcliente
        hnombre = nombre
        hapellido = apellido
        hdireccion = direccion
        hfecha_nacimiento = fecha_nacimiento
        htelefono = telefono
        hemail = email

    End Sub
End Class
