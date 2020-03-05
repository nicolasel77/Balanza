Imports System
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Const v_Path As String = "D:\Balanza\JDataGate\kSolutions\DataGate\"
    Private dbM As New clsBases.Principal("dbM")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_List(lstSucs, "Sucursales", "Sucursal", "Nombre", "Ver=1 AND Propio=1 AND Balanza=1", "Sucursal")

        With grdPrecios
            .MostrarDatos(dbM.Datos("SELECT TOP 0 CodProd Prod, Descripcion, Grupo, Pesable, Precio, Multi, Final, Fecha FROM Ofertas_Balanza"), True)
            .Texto(0, 0) = "Prod"
            .Texto(0, 1) = "Descripcion"
            .Texto(0, 2) = "Grupo"
            .Texto(0, 3) = "Pesa"
            .Texto(0, 4) = "Precio"
            .Texto(0, 5) = "Multi"
            .Texto(0, 6) = "Final"
            .ColW(0) = 40
            .ColW(1) = 200
            .ColW(2) = 40
            .ColW(3) = 40
            .ColW(4) = 60
            .ColW(5) = 40
            .ColW(6) = 60
            .ColW(7) = 60

            Dim n() As Integer = {13, 32, 42, 43, 45, 47, 107, 112, 123}
            .TeclasManejadas = n
        End With
        Dim dt As DataTable = dbM.Datos("SELECT * FROM vw_AliasBalanza WHERE CodDeProd=-1")
        grdVerPrecios.MostrarDatos(dt, True)
        grdVerPrecios.Filas.Count = 1
    End Sub

    Public Sub Llenar_List(ByRef lst As ListBox, ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
        If Where.Length Then Where = " WHERE " & Where
        If Order.Length = 0 Then Order = ID

        Dim dt As DataTable
        If ID.Length Then
            dt = dbM.Datos(String.Format("SELECT {0}, {1} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order))
        Else
            dt = dbM.Datos("SELECT * FROM " & Tabla & Where)
        End If

        For Each f As DataRow In dt.Rows
            lst.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
        Next
    End Sub

    Public Sub Llenar_List(ByRef lst As ComboBox, ByVal Tabla As String, Optional ByVal ID As String = "", Optional ByVal Nombre As String = "", Optional ByVal Where As String = "", Optional ByVal Order As String = "")
        If Where.Length Then Where = " WHERE " & Where
        If Order.Length = 0 Then Order = ID

        Dim dt As DataTable
        If ID.Length Then
            dt = dbM.Datos(String.Format("SELECT {0}, {1} FROM {2} {3} ORDER BY {4}", ID, Nombre, Tabla, Where, Order))
        Else
            dt = dbM.Datos("SELECT * FROM " & Tabla & Where)
        End If

        For Each f As DataRow In dt.Rows
            lst.Items.Add(String.Format("{0}. {1}", f.Item(0), f.Item(1).ToString.Trim))
        Next
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub cmdCrear_Click(sender As Object, e As EventArgs) Handles cmdCrear.Click
        With lstSucs
            If .SelectedIndex > -1 Then
                Me.Cursor = Cursors.WaitCursor
                Me.Enabled = False
                Dim suc As Integer
                Dim f As Date = mntFecha.SelectionEnd.Date
                Dim dt As DataTable
                Dim s_info As String = v_Path & "INFO.JDG"

                If Dir(s_info) <> "" Then My.Computer.FileSystem.DeleteFile(s_info)

                Dim es As New StreamWriter(s_info)

                'es.WriteLine("// iTegra versión 4.101 - Fecha: 27/03/2018 02:48")

                For Each sucs As String In lstSucs.SelectedItems
                    Dim s As Integer = sucs.Codigo_Seleccionado
                    dt = dbM.Datos(String.Format("SELECT CodDeProd, Nombre, Tipo, Grupo, CASE Pesable 		WHEN 1 THEN 'P'		WHEN 0 THEN 'N'		
                                END AS Pesable, ISNULL((SELECT TOP 1 p.Precio FROM dbPrecios.dbo.Precios p WHERE p.CodProd=CodDeProd AND P.CodSuc={0} AND Fecha<={1} ORDER BY Fecha DESC), 0) AS Precio	
                                FROM Productos WHERE Ver=1 AND CodDeProd IN (347, 348) ORDER BY CodDeProd", s, f.Fecha_SQL))
                    Dim s_Equipo As Integer = dbM.BuscarDato("SELECT ISNULL(Equipo, 0) Equipo FROM Sucursales WHERE Sucursal=" & s)

                    For Each dr As DataRow In dt.Rows
                        Dim cm As String
                        Dim prod As String = dr.Item("Nombre").ToString.PadRight(30, CChar(" "))

                        prod = prod.Substring(0, 26)

                        cm = String.Format("C{0}2005{1}001{2}{3}{3}{4}{5}0000{6}000000000000000000000000000000000000010000000000000000",
                                           Format(s_Equipo, "00"),
                                           Format(dr.Item("CodDeProd"), "000000"),
                                           Format(dr.Item("Grupo"), "000"),
                                           prod,
                                           Format(dr.Item("CodDeProd"), "00000"),
                                           dr.Item("Pesable").ToString.ToUpper,
                                           Format(dr.Item("Precio"), "0000000"))
                        'cm = String.Format("C012005{0}001{1}{2}{2}{3}{4}0000{5}000000000000000000000000000000000000010000000000000000",
                        '                   Format(dr.Item("CodDeProd"), "000000"),
                        '                   Format(dr.Item("Grupo"), "000"),
                        '                   prod,
                        '                   Format(dr.Item("CodDeProd"), "00000"),
                        '                   dr.Item("Pesable").ToString.ToUpper,
                        '                   Format(dr.Item("Precio"), "0000000"))
                        es.WriteLine(cm)
                    Next
                    es.WriteLine(String.Format("C{0}0001", Format(s_Equipo, "00")))
                Next

                es.Close()
                Process.Start(v_Path & "JDataGate.exe")
                '***************************

                'IO.File.Copy("D:\Balanza\Nuevo.txt", "D:\Balanza\Nuevo.iTegra")
                Beep()
                Me.Cursor = DefaultCursor
                Me.Enabled = True
                'End
            End If
        End With
    End Sub
    Private Sub txtBuscador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.TextChanged
        With txtBuscador
            Dim s As String
            grdVerPrecios.Filas.Count = 1
            If .Text.Length Then
                If IsNumeric(.Text) Then
                    s = String.Format("SELECT * FROM vw_AliasBalanza WHERE Nombre like '%{0}%' OR CodDeProd={0} OR Balanza={0} ORDER BY CodDeProd", txtBuscador.Text)
                Else
                    s = String.Format("SELECT * FROM vw_AliasBalanza WHERE Nombre like '%{0}%' ORDER BY CodDeProd", txtBuscador.Text)
                End If
                Dim dt As DataTable = dbM.Datos(s)
                grdVerPrecios.MostrarDatos(dt, True)
                grdVerPrecios.AutosizeAll()

            End If

        End With
    End Sub

    Private Sub cmdActualizar_INFO(sender As Object, e As EventArgs) Handles cmdOfertas.Click
        If lstSucs.SelectedIndex > -1 Then
            Me.Cursor = Cursors.WaitCursor
            Me.Enabled = False
            Dim f As Date = mntFecha.SelectionEnd.Date
            Dim fEsperar As DateTime = Date.Now.AddMinutes(2)

            Dim s_info As String = v_Path & "INFO.JDG"
            'Dim s_info As String = "\\192.168.5.1\Balanza\JDataGate\kSolutions\DataGate\INFO.JDG"

            If Dir(s_info) <> "" Then My.Computer.FileSystem.DeleteFile(s_info)

            Dim es As New StreamWriter(s_info)

            For Each sucs As String In lstSucs.SelectedItems
                Dim s As Integer = sucs.Codigo_Seleccionado
                Dim s_Equipo As Integer = dbM.BuscarDato("SELECT ISNULL(Equipo, 0) Equipo FROM Sucursales WHERE Sucursal=" & s)
                Dim s_IP As String = dbM.BuscarDato("SELECT ISNULL(IP, 0) Equipo FROM Sucursales WHERE Sucursal=" & s)

                Dim s_COM As String = v_Path & "COM.JDG"

                If Dir(s_COM) <> "" Then My.Computer.FileSystem.DeleteFile(s_COM)

                Dim ecom As New StreamWriter(s_COM)

                ecom.WriteLine(String.Format("""01"",""C""""1"", ""TCP"", ""{0}"", ""9101""", s_IP))
                ecom.Close()

                Dim cm As String
                Dim prod As String

                With grdPrecios
                    If .Rows > 2 Then
                        For i As Integer = 1 To .Rows - 2
                            prod = .Texto(i, .ColIndex("Descripcion")).PadRight(30, CChar(" "))
                            prod = prod.Replace("Ñ", "N")
                            prod = prod.Replace("ñ", "n")
                            prod = prod.Replace("ó", "o")
                            prod = prod.Replace("Ó", "O")
                            prod = CambiarAcentos(prod)
                            prod = prod.Substring(0, 26)

                            If chADB.Checked = False Then
                                Dim ps, pr As String
                                If .Texto(i, .ColIndex("Pesable")) = True Then
                                    ps = "P"
                                Else
                                    ps = "N"
                                End If
                                pr = Format(.Texto(i, .ColIndex("Final")), "0000000.00")

                                pr = pr.Remove(pr.IndexOf(","), 1)
                                cm = String.Format("C{0}2005{1}001{2}{3}{3}{4}{5}0000{6}0000000000000000000000000000000000010000000000000000",
                                                   Format(s_Equipo, "00"),
                                                   Format(.Texto(i, .ColIndex("Prod")), "000000"),
                                                   Format(.Texto(i, .ColIndex("Grupo")), "000"),
                                                   prod,
                                                   Format(.Texto(i, .ColIndex("Prod")), "00000"),
                                                   ps, pr
                                                   )
                                es.WriteLine(cm)
                            Else
                                Dim fechaa As Date = mntFecha.SelectionEnd
                                fechaa = fechaa.AddHours(dtHora.Value.Hour)
                                fechaa = fechaa.AddMinutes(dtHora.Value.Minute)
                                cm = String.Format("INSERT INTO [dbM].[dbo].[Ofertas_Balanza] ([Fecha], [CodProd], [Descripcion], [Grupo], [Pesable], [Precio], [Multi], [Final], [Guardado], [Suc]) " &
                                                    "VALUES('{0}', {1}, '{2}', {3}, {4}, {5}, {6}, {7}, 0, {8})",
                                                   fechaa.ToString("MM/dd/yyy HH:mm"),
                                                   .Texto(i, .ColIndex("Prod")),
                                                   prod,
                                                   .Texto(i, .ColIndex("Grupo")),
                                                   FormatearValorAlCornudoDeSql(.Texto(i, .ColIndex("Pesable"))),
                                                   FormatearValorAlCornudoDeSql(.Texto(i, .ColIndex("Precio"))),
                                                   .Texto(i, .ColIndex("Multi")),
                                                   FormatearValorAlCornudoDeSql(.Texto(i, .ColIndex("Final"))),
                                                   s)
                                dbM.EjecutarCadena(cm)
                            End If
                        Next
                    End If
                End With

                If chADB.Checked = False Then
                    es.WriteLine(String.Format("C{0}0001", Format(s_Equipo, "00")))

                    Process.Start(v_Path & "JDataGate.exe")
                    While DateTime.Now < fEsperar

                    End While
                    fEsperar = fEsperar.AddMinutes(2)
                End If
            Next
            es.Close()


            '***************************

            Beep()
            Me.Cursor = DefaultCursor
            Me.Enabled = True
            'End
        End If

    End Sub

    Private Sub tiMail_Tick(sender As Object, e As EventArgs) Handles tiMail.Tick
        Dim dt As DataTable = dbM.Datos($"SELECT * FROM Ofertas_Balanza WHERE Guardado=0 AND Fecha < '{Date.Now.ToString("MM/dd/yyy H:mm")}' ORDER BY Fecha")

        Dim s_info As String = v_Path & "INFO.JDG"

        If Dir(s_info) <> "" Then My.Computer.FileSystem.DeleteFile(s_info)

        Dim es As New StreamWriter(s_info)
        Dim s_Equipo As Integer

        For Each dr As DataRow In dt.Rows
            Dim s As Integer = dr.Item("Suc")
            s_Equipo = dbM.BuscarDato("SELECT ISNULL(Equipo, 0) Equipo FROM Sucursales WHERE Sucursal=" & s)
            Dim s_IP As String = dbM.BuscarDato("SELECT ISNULL(IP, 0) Equipo FROM Sucursales WHERE Sucursal=" & s)

            Dim s_COM As String = v_Path & "COM.JDG"

            If Dir(s_COM) <> "" Then My.Computer.FileSystem.DeleteFile(s_COM)

            Dim ecom As New StreamWriter(s_COM)

            ecom.WriteLine(String.Format("""01"",""C""""1"", ""TCP"", ""{0}"", ""9101""", s_IP))
            ecom.Close()

            Dim cm As String
            Dim prod As String

            prod = dr.Item("Descripcion").PadRight(30, CChar(" "))
            prod = prod.Replace("Ñ", "N")
            prod = prod.Replace("ñ", "n")
            prod = prod.Replace("ó", "o")
            prod = prod.Replace("Ó", "O")
            prod = prod.Substring(0, 26)
            Dim ps, pr As String
            If dr.Item("Pesable") = True Then
                ps = "P"
            Else
                ps = "N"
            End If
            pr = Format(dr.Item("Final"), "0000000.00")

            pr = pr.Remove(pr.IndexOf(","), 1)

            cm = String.Format("C{0}2005{1}001{2}{3}{3}{4}{5}0000{6}0000000000000000000000000000000000010000000000000000",
                                                   Format(s_Equipo, "00"),
                                                   Format(dr.Item("CodProd"), "000000"),
                                                   Format(dr.Item("Grupo"), "000"),
                                                   prod,
                                                   Format(dr.Item("CodProd"), "00000"),
                                                   ps, pr
                                                   )
            'C01200500034800100434834800348N00000001620000000000000000000000000000000000000010000000000000000
            'C012005000347001004Guerreiro                 00347N00000001600000000000000000000000000000000000000010000000000000000
            'C012005000300001006Pollo x Kg                00300P00000000097000000000000000000000000000000000000010000000000000000
            es.WriteLine(cm)
        Next
        If dt.Rows.Count Then
            es.WriteLine(String.Format("C{0}0001", Format(s_Equipo, "00")))
            Process.Start(v_Path & "JDataGate.exe")
            dbM.EjecutarCadena($"UPDATE Ofertas_Balanza SET Guardado=1 WHERE Guardado=0 AND Fecha < '{Date.Now.ToString("MM/dd/yyy H:mm")}'")
        End If
        es.Close()

    End Sub
    Private Sub grdPrecios_Editado(f As Short, c As Short, a As Object) Handles grdPrecios.Editado
        With grdPrecios
            Select Case c
                Case 0
                    Dim s As String
                    If lstSucs.SelectedIndex > -1 Then
                        s = String.Format("(SELECT TOP 1 P.Precio FROM dbPrecios.dbo.Precios P WHERE CodSuc={0} AND Fecha<={1} AND P.CodProd=CodDeProd ORDER BY Fecha DESC)", lstSucs.Text.Codigo_Seleccionado, mntFecha.SelectionEnd.Fecha_SQL)
                    Else
                        s = String.Format("(SELECT TOP 1 P.Precio FROM dbPrecios.dbo.Precios P WHERE Fecha<={0} AND P.CodProd=CodDeProd ORDER BY Fecha DESC)", mntFecha.SelectionEnd.Fecha_SQL)
                    End If
                    Dim dt As DataTable = dbM.Datos(String.Format("SELECT CodDeProd Prod, Nombre, Grupo, Pesable, Multiplicador Multi, {0} Precio FROM vw_AliasBalanza WHERE Balanza={1}", s, a))
                    If dt.Rows.Count Then
                        .Texto = a
                        .Texto(f, c + 1) = CambiarAcentos(dt)
                        .Texto(f, .ColIndex("Grupo")) = dt.Rows(0).Item("Grupo")
                        .Texto(f, .ColIndex("Pesable")) = dt.Rows(0).Item("Pesable")
                        If dt.Rows(0).Item("Multi") > 0 Then
                            .Texto(f, .ColIndex("Multi")) = dt.Rows(0).Item("Multi")
                        Else
                            .Texto(f, .ColIndex("Multi")) = 1
                        End If
                        .Texto(f, .ColIndex("Precio")) = dt.Rows(0).Item("Precio")
                        .Texto(f, .ColIndex("Final")) = .Texto(f, .ColIndex("Precio")) / .Texto(f, .ColIndex("Multi"))
                        .ActivarCelda(f, c + 1)
                    Else
                        .ErrorEnTxt()
                    End If
                Case .ColIndex("Grupo"), .ColIndex("Descripcion")
                    .Texto = a
                Case .ColIndex("Multi")
                    .Texto = a
                    .Texto(f, .ColIndex("Final")) = .Texto(f, .ColIndex("Precio")) / a
                    If .Row = .Rows - 1 Then
                        .AgregarFila()
                        .ActivarCelda(f + 1, 0)
                    Else
                        If .Texto(f + 1, 0) <> 0 Then
                            .ActivarCelda(f + 1, c)
                        Else
                            .ActivarCelda(f + 1, 0)
                        End If
                    End If
                Case .ColIndex("Precio")
                    .Texto = a
                    .Texto(f, .ColIndex("Final")) = .Texto(f, .ColIndex("Precio")) / .Texto(f, .ColIndex("Multi"))
                    If .Row = .Rows - 1 Then
                        .AgregarFila()
                        .ActivarCelda(f + 1, 0)
                    Else
                        If .Texto(f + 1, 0) <> 0 Then
                            .ActivarCelda(f + 1, c)
                        Else
                            .ActivarCelda(f + 1, 0)
                        End If
                    End If

            End Select
        End With
    End Sub

    Private Shared Function CambiarAcentos(dt As DataTable) As String
        Dim s As String = dt.Rows(0).Item("Nombre")
        Dim reg As Regex = New Regex("[^a-zA-Z0-9 ]")

        s = s.Normalize(NormalizationForm.FormD)
        s = reg.Replace(s, "")

        Return s
    End Function
    Private Shared Function CambiarAcentos(s As String) As String
        Dim reg As Regex = New Regex("[^a-zA-Z0-9 ]")

        s = s.Normalize(NormalizationForm.FormD)
        s = reg.Replace(s, "")

        Return s
    End Function

    Public Function FormatearValorAlCornudoDeSql(ByVal Valor As Object) As String
        Dim a As String = ""
        If Not Valor Is Nothing Then
            Select Case Valor.GetType.ToString
                Case "System.String"
                    a = String.Format("'{0}'", Valor.ToString)
                Case "System.Short", "System.Integer", "System.Int16", "System.Int32", "System.Int64"
                    a = Valor.ToString
                Case "System.Single", "System.Double", "System.Decimal"
                    a = Valor.ToString.Replace(",", ".")
                Case "System.Boolean"
                    If Valor = True Then
                        a = "1"
                    Else
                        a = "0"
                    End If
                Case "System.DateTime"
                    a = String.Format("'{0}'", Format(Valor, "MM/dd/yy"))
                Case Else
                    MsgBox("No esta incorporado el Type:" & Valor.GetType.ToString, MsgBoxStyle.Exclamation)
            End Select
        End If
        Return a
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grdPrecios.Rows = 1
        grdPrecios.Rows = 2
    End Sub

    Private Sub grdPrecios_KeyUp(sender As Object, e As Short) Handles grdPrecios.KeyUp
        With grdPrecios

            Select Case e
                Case Keys.Delete
                    If .Rows > 2 Then
                        .BorrarFila(.Row)
                    Else
                        .Rows = 1
                        .Rows = 2
                    End If
                Case Keys.Add
                    Dim S As String = .Texto(.Row, .ColIndex("Descripcion"))
                    If lstRelleno.SelectedIndex > -1 Then
                        S &= " " & lstRelleno.Text
                    End If
                    .Texto(.Row, .ColIndex("Descripcion")) = S
                    .ActivarCelda(.Row, .ColIndex("Precio"))
                Case Keys.Enter
                    If .Col = .ColIndex("Final") Then
                        If .Texto(.Row + 1, 0) <> 0 Then
                            .ActivarCelda(.Row + 1, 0)
                        Else
                            If .Row = .Rows - 1 Then .AgregarFila()
                            .ActivarCelda(.Row, .Col + 1)
                        End If
                    End If
                Case 32 '2 en el teclado no numerico
                    Dim multi As Integer = .Texto(.Row, .ColIndex("Multi"))
                    If multi = 0 Then
                        multi = 2
                    Else
                        multi += 1
                    End If
                    .Texto(.Row, .ColIndex("Multi")) = multi
                    .Texto(.Row, .ColIndex("Final")) = .Texto(.Row, .ColIndex("Precio")) / multi

            End Select

        End With
    End Sub

    Private Sub CmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        'Process.Start("\\192.168.5.1\Balanza\JDataGate\kSolutions\DataGate\JDataGate.exe")
        Process.Start(v_Path & "JDataGate.exe")
    End Sub

    Private Sub CmdCargarPrecios_Click(sender As Object, e As EventArgs) Handles cmdCargarPrecios.Click, cmdGuardar.Click
        Dim s As String = String.Format("(SELECT TOP 1 P.Precio FROM dbPrecios.dbo.Precios P WHERE CodSuc={0} AND Fecha<={1} AND P.CodProd=CodDeProd ORDER BY Fecha DESC)", lstSucs.Text.Codigo_Seleccionado, mntFecha.SelectionEnd.Fecha_SQL)
        Dim dt As DataTable = dbM.Datos(String.Format("SELECT Balanza Prod, Nombre, Grupo, Pesable, {0} Precio, Multiplicador Multi, 0.0 Final FROM vw_AliasBalanza", s))

        grdPrecios.MostrarDatos(dt, False, True)

        With grdPrecios
            For i As Integer = 1 To .Rows - 2
                If .Texto(i, .ColIndex("Multi")) = 0 Then .Texto(i, .ColIndex("Multi")) = 1
                .Texto(i, .ColIndex("Final")) = .Texto(i, .ColIndex("Precio")) / .Texto(i, .ColIndex("Multi"))
            Next
        End With
    End Sub

    Private Sub cmdMail_Click(sender As Object, e As EventArgs) Handles cmdMail.Click
        tiMail_Tick(Nothing, Nothing)
    End Sub

    Private Sub chReloj_CheckedChanged(sender As Object, e As EventArgs) Handles chReloj.CheckedChanged
        tiMail.Enabled = chReloj.Checked
    End Sub

    Private Sub lstRelleno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRelleno.SelectedIndexChanged
        grdPrecios.Focus()
        SendKeys.Send("+")
    End Sub
End Class

