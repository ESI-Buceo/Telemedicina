﻿Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim s As New ModeloSintoma With {
            .Nombre = Sintoma
        }
        'asdfkljasdfljhañdsfjh
        Return s.Listar()
    End Function
End Module
