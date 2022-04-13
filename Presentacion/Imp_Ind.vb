Public Class Imp_Ind

    Public Function consultarNota_Pajilla(ByVal id_nota_paj As Integer) As DataTable
        tabla = Nothing
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla = servidor.consultar("consultarNota_Pajilla", id_nota_paj).Tables(0)
            If tabla Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
            Else
                Dim NroFilas As Integer = tabla.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    tabla = Nothing
                Else
                    servidor.cerrarconexion()
                End If
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
        End If
        Return (tabla)
    End Function

    Public Function consultarpeso_med(ByVal Id_peso_med As Integer) As DataTable
        tabla = Nothing
        Dim servidor As New clinicapacifico.clsaccesodatos
        servidor.cadenaconexion = Ruta
        If servidor.abrirconexion = True Then
            tabla = servidor.consultar("consultarPeso_Med", Id_peso_med).Tables(0)
            If tabla Is Nothing Then
                __mesajeerror = servidor.getMensageError
                servidor.cerrarconexion()
            Else
                Dim NroFilas As Integer = tabla.Rows.Count
                If NroFilas = 0 Then
                    servidor.cerrarconexion()
                    tabla = Nothing
                Else
                    servidor.cerrarconexion()
                End If
            End If
        Else
            __mesajeerror = servidor.getMensageError
            servidor.cerrarconexion()
        End If
        Return (tabla)
    End Function


End Class
