Imports MySql.Data.MySqlClient
Public Class Presupuesto
    Dim Consulta

    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conectar()

    End Sub

    Sub CargarDatos(Busqueda As String)

        Dim Da As New MySqlDataAdapter(Busqueda, Conexion)
        ':::Creamos nuestro DataTable para almacenar el resultado

        Dim Dt As New DataTable
        Try
            ':::Llenamos nuestro DataTable con el resultado de la consulta
            Da.Fill(Dt)
            ':::Asignamos a nuestro DataGridView el DataTable para mostrar los registros
            DataGridView.DataSource = Dt
            ':::Damos color a las filas y formato a la columna hora
            DataGridView.RowsDefaultCellStyle.BackColor = Color.LightBlue
            DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White

            Me.DataGridView.Columns(0).Visible = False
            'DataGridView.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)

        Catch ex As Exception
            MsgBox("No se puede realizar la consulta por: " & ex.Message)
        End Try
    End Sub
    Sub OcultaCmb()
        CmbCaracter.Visible = False
        LblCaracter.Visible = False
        CmbJurisdiccion.Visible = False
        LblJurisdiccion.Visible = False
        CmbSubJurisdiccion.Visible = False
        LblSubJurisdiccion.Visible = False
        CmbServicio.Visible = False
        LblServicio.Visible = False
        CmbPrograma.Visible = False
        LblPrograma.Visible = False

    End Sub

    Private Sub RdbEntidad_CheckedChanged(sender As Object, e As EventArgs) Handles RdbEntidad.CheckedChanged

        OcultaCmb()

        If RdbEntidad.Checked = True Then

            'Cargo la informacion de caracter 
            Try
                Consulta = "select * from Caracter"

                Dim Adaptador = New MySqlDataAdapter(Consulta, Conexion)

                Dim Datos = New DataSet

                Datos.Tables.Add("Caracter")

                Adaptador.Fill(Datos.Tables("Caracter"))

                CmbCaracter.DataSource = (Datos.Tables("Caracter"))
                CmbCaracter.ValueMember = "caracter_id"
                CmbCaracter.DisplayMember = "caracter_desc"
                CmbCaracter.Text = "Seleccione una opción"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            CargarDatos("SELECT caracter.caracter_id,
                            caracter.caracter_desc AS caracter,
                            SUM(credito_vigente) AS Credito, 
	                        SUM(credito_comprometido) AS Comprometido,
	                        SUM(credito_devengado) AS Devengado,
	                        SUM(credito_pagado) AS Pagado
                        FROM presupuestos, caracter, jurisdiccion,subjurisdiccion,entidad
                        WHERE presupuestos.IdEntidad = entidad.IdEndidad AND
	                        entidad.IdSubJurisdiccion=subjurisdiccion.IdSubjurisdiccion and
	                        subjurisdiccion.IdJurisdiccion=jurisdiccion.IdJurisdiccion and
	                        jurisdiccion.caracter_id=caracter.caracter_id 
                        GROUP BY caracter.caracter_id")
        End If
        CmbCaracter.Visible = True
        LblCaracter.Visible = True

    End Sub
    Private Sub CmbCaracter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCaracter.SelectionChangeCommitted

        'Cargo la jurisdiccion
        CargarDatos("SELECT jurisdiccion.idjurisdiccion,
                                jurisdiccion.jurisdiccion_desc AS Jurisdiccion,
                                SUM(credito_vigente) AS Credito, 
                             SUM(credito_comprometido) AS Comprometido,
                             SUM(credito_devengado) AS Devengado,
                             SUM(credito_pagado) AS Pagado
                            FROM presupuestos, caracter, jurisdiccion,subjurisdiccion,entidad
                            WHERE presupuestos.IdEntidad = entidad.IdEndidad AND
                             entidad.IdSubJurisdiccion=subjurisdiccion.IdSubjurisdiccion and
                             subjurisdiccion.IdJurisdiccion=jurisdiccion.IdJurisdiccion and
                             jurisdiccion.caracter_id=caracter.caracter_id and
                             caracter.caracter_id = '" & CmbCaracter.SelectedValue.ToString & "'
                            GROUP BY jurisdiccion.idjurisdiccion")

        'Cargo la informacion de jurisdiccion 
        Try
            Consulta = "select * from Jurisdiccion, caracter where 
                        jurisdiccion.caracter_id=caracter.caracter_id and
                        jurisdiccion.caracter_id='" & CmbCaracter.SelectedValue.ToString & "'"

            Dim Adaptador = New MySqlDataAdapter(Consulta, Conexion)

            Dim Datos = New DataSet

            Datos.Tables.Add("Jurisdiccion")

            Adaptador.Fill(Datos.Tables("Jurisdiccion"))

            CmbJurisdiccion.DataSource = (Datos.Tables("Jurisdiccion"))
            CmbJurisdiccion.ValueMember = "IdJurisdiccion"
            CmbJurisdiccion.DisplayMember = "Jurisdiccion_desc"
            CmbJurisdiccion.Text = "Seleccione una opción"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CmbJurisdiccion.Visible = True
        LblJurisdiccion.Visible = True
    End Sub
    Private Sub CmbJurisdiccion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbJurisdiccion.SelectionChangeCommitted
        'Cargo la Subjurisdiccion
        CargarDatos("SELECT subjurisdiccion.IdSubjurisdiccion,
                            subjurisdiccion.subjurisdiccion_desc AS Subjurisdicción,
                             SUM(credito_vigente) AS Credito, 
                             SUM(credito_comprometido) AS Comprometido,
                             SUM(credito_devengado) AS Devengado,
                             SUM(credito_pagado) AS Pagado
                            FROM presupuestos, caracter, jurisdiccion,subjurisdiccion,entidad
                            WHERE presupuestos.IdEntidad = entidad.IdEndidad AND
                             entidad.IdSubJurisdiccion=subjurisdiccion.IdSubjurisdiccion and
                             subjurisdiccion.IdJurisdiccion=jurisdiccion.IdJurisdiccion and
                             jurisdiccion.caracter_id=caracter.caracter_id and
                             jurisdiccion.IdJurisdiccion = '" & CmbJurisdiccion.SelectedValue.ToString & "'
                            GROUP BY subjurisdiccion.idsubjurisdiccion")

        'Cargo la informacion de Subjurisdiccion 
        Try
            Consulta = "select * from subjurisdiccion, jurisdiccion where 
                        subjurisdiccion.idjurisdiccion=jurisdiccion.idjurisdiccion and
                        subjurisdiccion.idjurisdiccion='" & CmbJurisdiccion.SelectedValue.ToString & "'"

            Dim Adaptador = New MySqlDataAdapter(Consulta, Conexion)

            Dim Datos = New DataSet

            Datos.Tables.Add("subjurisdiccion")

            Adaptador.Fill(Datos.Tables("subjurisdiccion"))

            CmbSubJurisdiccion.DataSource = (Datos.Tables("subjurisdiccion"))
            CmbSubJurisdiccion.ValueMember = "IdSubjurisdiccion"
            CmbSubJurisdiccion.DisplayMember = "Subjurisdiccion_desc"
            CmbSubJurisdiccion.Text = "Seleccione una opción"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CmbSubJurisdiccion.Visible = True
        LblSubJurisdiccion.Visible = True
    End Sub
    Private Sub CmbSubJurisdiccion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSubJurisdiccion.SelectionChangeCommitted
        'Cargo la entidad
        CargarDatos("SELECT entidad.IdEndidad,
                            entidad.entidad_desc AS Entidadn,
                             SUM(credito_vigente) AS Credito, 
                             SUM(credito_comprometido) AS Comprometido,
                             SUM(credito_devengado) AS Devengado,
                             SUM(credito_pagado) AS Pagado
                            FROM presupuestos, caracter, jurisdiccion,subjurisdiccion,entidad
                            WHERE presupuestos.IdEntidad = entidad.IdEndidad AND
                             entidad.IdSubJurisdiccion=subjurisdiccion.IdSubjurisdiccion and
                             subjurisdiccion.IdJurisdiccion=jurisdiccion.IdJurisdiccion and
                             jurisdiccion.caracter_id=caracter.caracter_id and
                             subjurisdiccion.IdSubjurisdiccion = '" & CmbSubJurisdiccion.SelectedValue.ToString & "'
                            GROUP BY entidad.IdEndidad")
    End Sub

    Private Sub RdbPrograma_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPrograma.CheckedChanged

        OcultaCmb()

        If RdbPrograma.Checked = True Then

            'Cargo la informacion de servicio 
            CargarDatos("SELECT servicio.servicio_id,
	                        servicio.servicio_desc AS servicio,
                            SUM(credito_vigente) AS Credito, 
	                        SUM(credito_comprometido) AS Comprometido,
	                        SUM(credito_devengado) AS Devengado,
	                        SUM(credito_pagado) AS Pagado
                        FROM presupuestos, servicio, programa
                        WHERE servicio.servicio_id = programa.servicio_id                             
                        GROUP BY servicio.servicio_id")

            'Cargo la informacion de programa 
            Try
                Consulta = "select * from servicio"

                Dim Adaptador = New MySqlDataAdapter(Consulta, Conexion)

                Dim Datos = New DataSet

                Datos.Tables.Add("servicio")

                Adaptador.Fill(Datos.Tables("servicio"))

                CmbServicio.DataSource = (Datos.Tables("servicio"))
                CmbServicio.ValueMember = "servicio_id"
                CmbServicio.DisplayMember = "servicio_desc"
                CmbServicio.Text = "Seleccione una opción"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            CmbServicio.Visible = True
            LblServicio.Visible = True

        End If

    End Sub

    Private Sub CmbServicio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbServicio.SelectionChangeCommitted

        'Cargo la informacion de programa 

        CargarDatos("SELECT programa.IdPrograma,
	                        programa.programa_desc AS Programa,
                            SUM(credito_vigente) AS Credito, 
	                        SUM(credito_comprometido) AS Comprometido,
	                        SUM(credito_devengado) AS Devengado,
	                        SUM(credito_pagado) AS Pagado
                        FROM presupuestos, servicio, programa
                        WHERE servicio.servicio_id = programa.servicio_id and
                            programa.servicio_id = '" & CmbServicio.SelectedValue.ToString & "'
                        GROUP BY programa.IdPrograma")

        Try
            Consulta = "select * from programa, Servicio    
                        where programa.servicio_id = servicio.servicio_id  and
                        programa.servicio_id = " & CmbServicio.SelectedValue.ToString & ""
            'MsgBox(Consulta)

            Dim Adaptador = New MySqlDataAdapter(Consulta, Conexion)

            Dim Datos = New DataSet

            Datos.Tables.Add("programa")

            Adaptador.Fill(Datos.Tables("programa"))

            CmbPrograma.DataSource = (Datos.Tables("programa"))
            CmbPrograma.ValueMember = "idprograma"
            CmbPrograma.DisplayMember = "programa_desc"
            CmbPrograma.Text = "Seleccione una opción"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CmbPrograma.Visible = True
        LblPrograma.Visible = True
    End Sub
End Class
