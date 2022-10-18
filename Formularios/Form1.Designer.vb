<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RdbEntidad = New System.Windows.Forms.RadioButton()
        Me.CmbCaracter = New System.Windows.Forms.ComboBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.CmbJurisdiccion = New System.Windows.Forms.ComboBox()
        Me.LblCaracter = New System.Windows.Forms.Label()
        Me.LblJurisdiccion = New System.Windows.Forms.Label()
        Me.LblSubJurisdiccion = New System.Windows.Forms.Label()
        Me.CmbSubJurisdiccion = New System.Windows.Forms.ComboBox()
        Me.RdbPrograma = New System.Windows.Forms.RadioButton()
        Me.LblPrograma = New System.Windows.Forms.Label()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.CmbPrograma = New System.Windows.Forms.ComboBox()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RdbEntidad
        '
        Me.RdbEntidad.AutoSize = True
        Me.RdbEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbEntidad.Location = New System.Drawing.Point(21, 21)
        Me.RdbEntidad.Name = "RdbEntidad"
        Me.RdbEntidad.Size = New System.Drawing.Size(75, 22)
        Me.RdbEntidad.TabIndex = 0
        Me.RdbEntidad.Text = "Entidad"
        Me.RdbEntidad.UseVisualStyleBackColor = True
        '
        'CmbCaracter
        '
        Me.CmbCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCaracter.FormattingEnabled = True
        Me.CmbCaracter.Location = New System.Drawing.Point(12, 93)
        Me.CmbCaracter.Name = "CmbCaracter"
        Me.CmbCaracter.Size = New System.Drawing.Size(196, 26)
        Me.CmbCaracter.TabIndex = 1
        Me.CmbCaracter.Visible = False
        '
        'DataGridView
        '
        Me.DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(233, 62)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView.Size = New System.Drawing.Size(674, 433)
        Me.DataGridView.TabIndex = 2
        '
        'CmbJurisdiccion
        '
        Me.CmbJurisdiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbJurisdiccion.FormattingEnabled = True
        Me.CmbJurisdiccion.Location = New System.Drawing.Point(12, 167)
        Me.CmbJurisdiccion.Name = "CmbJurisdiccion"
        Me.CmbJurisdiccion.Size = New System.Drawing.Size(196, 26)
        Me.CmbJurisdiccion.TabIndex = 3
        Me.CmbJurisdiccion.Visible = False
        '
        'LblCaracter
        '
        Me.LblCaracter.AutoSize = True
        Me.LblCaracter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCaracter.Location = New System.Drawing.Point(12, 72)
        Me.LblCaracter.Name = "LblCaracter"
        Me.LblCaracter.Size = New System.Drawing.Size(65, 18)
        Me.LblCaracter.TabIndex = 4
        Me.LblCaracter.Text = "Caracter"
        Me.LblCaracter.Visible = False
        '
        'LblJurisdiccion
        '
        Me.LblJurisdiccion.AutoSize = True
        Me.LblJurisdiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJurisdiccion.Location = New System.Drawing.Point(12, 146)
        Me.LblJurisdiccion.Name = "LblJurisdiccion"
        Me.LblJurisdiccion.Size = New System.Drawing.Size(87, 18)
        Me.LblJurisdiccion.TabIndex = 5
        Me.LblJurisdiccion.Text = "Jurisdicción"
        Me.LblJurisdiccion.Visible = False
        '
        'LblSubJurisdiccion
        '
        Me.LblSubJurisdiccion.AutoSize = True
        Me.LblSubJurisdiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubJurisdiccion.Location = New System.Drawing.Point(12, 224)
        Me.LblSubJurisdiccion.Name = "LblSubJurisdiccion"
        Me.LblSubJurisdiccion.Size = New System.Drawing.Size(108, 18)
        Me.LblSubJurisdiccion.TabIndex = 7
        Me.LblSubJurisdiccion.Text = "Subjurisdicción"
        Me.LblSubJurisdiccion.Visible = False
        '
        'CmbSubJurisdiccion
        '
        Me.CmbSubJurisdiccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSubJurisdiccion.FormattingEnabled = True
        Me.CmbSubJurisdiccion.Location = New System.Drawing.Point(12, 245)
        Me.CmbSubJurisdiccion.Name = "CmbSubJurisdiccion"
        Me.CmbSubJurisdiccion.Size = New System.Drawing.Size(196, 26)
        Me.CmbSubJurisdiccion.TabIndex = 6
        Me.CmbSubJurisdiccion.Visible = False
        '
        'RdbPrograma
        '
        Me.RdbPrograma.AutoSize = True
        Me.RdbPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPrograma.Location = New System.Drawing.Point(143, 21)
        Me.RdbPrograma.Name = "RdbPrograma"
        Me.RdbPrograma.Size = New System.Drawing.Size(92, 22)
        Me.RdbPrograma.TabIndex = 8
        Me.RdbPrograma.Text = "Programa"
        Me.RdbPrograma.UseVisualStyleBackColor = True
        '
        'LblPrograma
        '
        Me.LblPrograma.AutoSize = True
        Me.LblPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrograma.Location = New System.Drawing.Point(12, 146)
        Me.LblPrograma.Name = "LblPrograma"
        Me.LblPrograma.Size = New System.Drawing.Size(74, 18)
        Me.LblPrograma.TabIndex = 12
        Me.LblPrograma.Text = "Programa"
        Me.LblPrograma.Visible = False
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServicio.Location = New System.Drawing.Point(12, 72)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(61, 18)
        Me.LblServicio.TabIndex = 11
        Me.LblServicio.Text = "Servicio"
        Me.LblServicio.Visible = False
        '
        'CmbPrograma
        '
        Me.CmbPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrograma.FormattingEnabled = True
        Me.CmbPrograma.Location = New System.Drawing.Point(12, 167)
        Me.CmbPrograma.Name = "CmbPrograma"
        Me.CmbPrograma.Size = New System.Drawing.Size(196, 26)
        Me.CmbPrograma.TabIndex = 10
        Me.CmbPrograma.Visible = False
        '
        'CmbServicio
        '
        Me.CmbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(12, 93)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(196, 26)
        Me.CmbServicio.TabIndex = 9
        Me.CmbServicio.Visible = False
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 493)
        Me.Controls.Add(Me.LblPrograma)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.CmbPrograma)
        Me.Controls.Add(Me.CmbServicio)
        Me.Controls.Add(Me.RdbPrograma)
        Me.Controls.Add(Me.LblSubJurisdiccion)
        Me.Controls.Add(Me.CmbSubJurisdiccion)
        Me.Controls.Add(Me.LblJurisdiccion)
        Me.Controls.Add(Me.LblCaracter)
        Me.Controls.Add(Me.CmbJurisdiccion)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.CmbCaracter)
        Me.Controls.Add(Me.RdbEntidad)
        Me.Name = "Presupuesto"
        Me.Text = "Presupuesto Nacional 2022"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RdbEntidad As RadioButton
    Friend WithEvents CmbCaracter As ComboBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents CmbJurisdiccion As ComboBox
    Friend WithEvents LblCaracter As Label
    Friend WithEvents LblJurisdiccion As Label
    Friend WithEvents LblSubJurisdiccion As Label
    Friend WithEvents CmbSubJurisdiccion As ComboBox
    Friend WithEvents RdbPrograma As RadioButton
    Friend WithEvents LblPrograma As Label
    Friend WithEvents LblServicio As Label
    Friend WithEvents CmbPrograma As ComboBox
    Friend WithEvents CmbServicio As ComboBox
End Class
