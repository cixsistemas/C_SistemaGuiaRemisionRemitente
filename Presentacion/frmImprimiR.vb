Public Class frmImprimiR

    Public Nivel As String = ""
    Public Titulo_Informe As String = ""
    Public __Parametros As String() = Nothing
    Public __PuntoPartida As String() = Nothing
    Public __PuntoLLegada As String() = Nothing
    Public RUC_Destinatario As String = ""
    Public Tipo_Nro_Doc_Identidad As String = ""
    Public Tabla_Imprimir As DataTable = Nothing
    Public DataSet_Imprimir As DataSet = Nothing

    Private Sub crvImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles crvImprimir.Load
        Text = " ><))))°>... oO0 ... " & Titulo_Informe.Trim


        Dim parametros As New CrystalDecisions.Shared.ParameterFields
        Dim parametro As New CrystalDecisions.Shared.ParameterField
        Dim dVal As New CrystalDecisions.Shared.ParameterDiscreteValue

        Try

            Dim crp As Object

            Select Case Nivel
                Case "FORMULARIO_LISTA_GUIAS"
                    crp = New crguiaremision
                    '---------------------------------------------------------------------------

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(0)
                    parametro.ParameterFieldName = "distritopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(1)
                    parametro.ParameterFieldName = "provinciapp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(2)
                    parametro.ParameterFieldName = "departamentopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)


                    '=========================================================

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(0)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "distritoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(1)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "provinciall"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(2)
                    parametro.ParameterFieldName = "departamentoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = RUC_Destinatario
                    parametro.ParameterFieldName = "rucdestinatario"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Tipo_Nro_Doc_Identidad
                    parametro.ParameterFieldName = "tiponrodocidentidad"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)



                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __Parametros(0)
                    parametro.ParameterFieldName = "destinoguia"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                    '------------------------------------------------------------

                Case "FORMULARIO_LISTA_GUIAS2"
                    crp = New crguiaremision2
                    '---------------------------------------------------------------------------

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(0)
                    parametro.ParameterFieldName = "distritopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(1)
                    parametro.ParameterFieldName = "provinciapp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(2)
                    parametro.ParameterFieldName = "departamentopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)


                    '=========================================================

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(0)
                    parametro.ParameterFieldName = "distritoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(1)
                    parametro.ParameterFieldName = "provinciall"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(2)
                    parametro.ParameterFieldName = "departamentoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = RUC_Destinatario
                    parametro.ParameterFieldName = "rucdestinatario"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Tipo_Nro_Doc_Identidad
                    parametro.ParameterFieldName = "tiponrodocidentidad"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)



                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __Parametros(0)
                    parametro.ParameterFieldName = "destinoguia"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_GUIAS_MOLINOS"
                    crp = New crguiaremision_Molino
                    '---------------------------------------------------------------------------

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(0)
                    parametro.ParameterFieldName = "distritopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(1)
                    parametro.ParameterFieldName = "provinciapp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(2)
                    parametro.ParameterFieldName = "departamentopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)


                    '=========================================================

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(0)
                    parametro.ParameterFieldName = "distritoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(1)
                    parametro.ParameterFieldName = "provinciall"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(2)
                    parametro.ParameterFieldName = "departamentoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = RUC_Destinatario
                    parametro.ParameterFieldName = "rucdestinatario"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Tipo_Nro_Doc_Identidad
                    parametro.ParameterFieldName = "tiponrodocidentidad"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)



                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __Parametros(0)
                    parametro.ParameterFieldName = "destinoguia"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_GUIAS_ZELU"
                    crp = New crguiaremision_Zelu
                    '---------------------------------------------------------------------------

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(0)
                    parametro.ParameterFieldName = "distritopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(1)
                    parametro.ParameterFieldName = "provinciapp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(2)
                    parametro.ParameterFieldName = "departamentopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)


                    '=========================================================

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(0)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "distritoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(1)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "provinciall"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(2)
                    parametro.ParameterFieldName = "departamentoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = RUC_Destinatario
                    parametro.ParameterFieldName = "rucdestinatario"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Tipo_Nro_Doc_Identidad
                    parametro.ParameterFieldName = "tiponrodocidentidad"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)



                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __Parametros(0)
                    parametro.ParameterFieldName = "destinoguia"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                    '------------------------------------------------------------
                    '---------------------------------------------------------------



                    '=========================================================
                    'GUIAS DE BANTEMAR
                Case "FORMULARIO_LISTA_GUIAS_BANTEMAR"
                    crp = New crguiaremision_Bante
                    '---------------------------------------------------------------------------

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(0)
                    parametro.ParameterFieldName = "distritopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(1)
                    parametro.ParameterFieldName = "provinciapp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoPartida(2)
                    parametro.ParameterFieldName = "departamentopp"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)


                    '=========================================================

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(0)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "distritoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(1)
                    'dVal.Value = ""
                    parametro.ParameterFieldName = "provinciall"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __PuntoLLegada(2)
                    parametro.ParameterFieldName = "departamentoll"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = RUC_Destinatario
                    parametro.ParameterFieldName = "rucdestinatario"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    '==============================================================
                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Tipo_Nro_Doc_Identidad
                    parametro.ParameterFieldName = "tiponrodocidentidad"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)



                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = __Parametros(0)
                    parametro.ParameterFieldName = "destinoguia"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros


                    '---------------------------------------------------------------------
                    '---------------------------------------------------------------------

                Case "FORMULARIO_LISTA_LOGOTIPO"
                    crp = New CrLogotipo

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_PRODUCTOS"
                    crp = New crProductos

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_Destinatario"
                    crp = New crDestinatario

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_REMITENTES"
                    crp = New CrRemitente

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_UNIDAD_TRANSPORTES"
                    crp = New crunidadtransportes
                    ' crp = New CrystalReport1

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_EMPRESA_TRANSPORTES"
                    crp = New cremptransportes

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_CHOFERES"
                    crp = New CrChofer

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_COMISIONISTAS"
                    crp = New CrComisionista

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_UBIGEOS"
                    crp = New CrUbigeos

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                    '=========================== PESOS Y MEDIDAS ========================
                Case "FORMULARIO_LISTA_PESO_MEDIDAS"
                    crp = New CrPes_Med

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros


                Case "FORMULARIO_LISTA_PESO_MEDIDAS_MOLINOS"
                    crp = New CrPes_Med_Molinos

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_PESO_MEDIDAS_BANTEMAR"
                    crp = New CrPes_Med_Bantemar

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros


                Case "FORMULARIO_LISTA_PESO_MEDIDAS_ZELU"
                    crp = New CrPes_Med_Zelu

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                    '================= FIN PESOS Y MEDIDAS =================================

                Case "FORMULARIO_LISTA_NOTA_ENVIO_ARROZ"
                    crp = New CrNota_Arroz

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_VENTAS_REMITENTE"
                    crp = New CrRep_Ventas_Rem

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_FLETE_TRANSPORTISTA"
                    crp = New CrRep_Fle_Transp

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_CONTROL_GUIA_FT"
                    crp = New CrRep_Cont_Guia_FT

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros


                Case "FORMULARIO_LISTA_LISTA_INGRESOS_COMPROBANTES"
                    crp = New CrRep_Ing_comp

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_LISTA_ENVIOS_COMPROBANTES"
                    crp = New CrRep_Env_comp

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros


                Case "FORMULARIO_LISTA_LISTA_DEVOLUCION_COMPROBANTES"
                    crp = New CrRep_Dev_comp

                    parametro = New CrystalDecisions.Shared.ParameterField
                    dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    dVal.Value = Titulo_Informe
                    parametro.ParameterFieldName = "Titulo"
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)

                    crvImprimir.ParameterFieldInfo = parametros

                Case "FORMULARIO_LISTA_CONTROL_DE_COMPROBANTES_DE_PAGO"
                    crp = New CRrep_Con_Comp_Pago

                    'parametro = New CrystalDecisions.Shared.ParameterField
                    'dVal = New CrystalDecisions.Shared.ParameterDiscreteValue
                    'dVal.Value = Titulo_Informe
                    '' parametro.ParameterFieldName = "Titulo"
                    'parametro.CurrentValues.Add(dVal)
                    'parametros.Add(parametro)

                    'crvImprimir.ParameterFieldInfo = parametros

            End Select

            If Not Tabla_Imprimir Is Nothing Then
                crp.SetDataSource(Tabla_Imprimir)
            Else
                crp.SetDataSource(DataSet_Imprimir)
            End If


            ''----------------------------------------------------------------------------

            crvImprimir.ReportSource = crp
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmImprimir_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'cerrar formulario con tecla ESC
        If (e.KeyCode = Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub frmImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class