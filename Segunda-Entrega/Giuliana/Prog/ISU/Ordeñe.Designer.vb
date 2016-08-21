<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdeñe
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
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.gbxLeche = New System.Windows.Forms.GroupBox()
        Me.tbxConsumoe = New System.Windows.Forms.TextBox()
        Me.tbxConsumoi = New System.Windows.Forms.TextBox()
        Me.chbConsumoi = New System.Windows.Forms.CheckBox()
        Me.chbConsumoe = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOrdeñado = New System.Windows.Forms.Button()
        Me.tbxNumLote = New System.Windows.Forms.TextBox()
        Me.lblNumLote = New System.Windows.Forms.Label()
        Me.tbxGrasa = New System.Windows.Forms.TextBox()
        Me.lblGrasa = New System.Windows.Forms.Label()
        Me.tbxProteina = New System.Windows.Forms.TextBox()
        Me.lblProteina = New System.Windows.Forms.Label()
        Me.tbxUrea = New System.Windows.Forms.TextBox()
        Me.lblUrea = New System.Windows.Forms.Label()
        Me.tbxRecuentocel = New System.Windows.Forms.TextBox()
        Me.lblRecuentoCel = New System.Windows.Forms.Label()
        Me.tbxRecuentobac = New System.Windows.Forms.TextBox()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.lblRecuentobac = New System.Windows.Forms.Label()
        Me.tbxLitros = New System.Windows.Forms.TextBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.gbxTercer = New System.Windows.Forms.GroupBox()
        Me.dtpFint = New System.Windows.Forms.DateTimePicker()
        Me.dtpIniciot = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFinalt = New System.Windows.Forms.Label()
        Me.lblIniciot = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbxLeche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxTercer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 579)
        Me.pnlBlue.TabIndex = 72
        Me.pnlBlue.Visible = False
        '
        'gbxLeche
        '
        Me.gbxLeche.Controls.Add(Me.btnOrdeñado)
        Me.gbxLeche.Controls.Add(Me.tbxConsumoe)
        Me.gbxLeche.Controls.Add(Me.tbxConsumoi)
        Me.gbxLeche.Controls.Add(Me.chbConsumoi)
        Me.gbxLeche.Controls.Add(Me.chbConsumoe)
        Me.gbxLeche.Controls.Add(Me.GroupBox1)
        Me.gbxLeche.Controls.Add(Me.tbxGrasa)
        Me.gbxLeche.Controls.Add(Me.lblGrasa)
        Me.gbxLeche.Controls.Add(Me.tbxProteina)
        Me.gbxLeche.Controls.Add(Me.lblProteina)
        Me.gbxLeche.Controls.Add(Me.tbxUrea)
        Me.gbxLeche.Controls.Add(Me.lblUrea)
        Me.gbxLeche.Controls.Add(Me.tbxRecuentocel)
        Me.gbxLeche.Controls.Add(Me.lblRecuentoCel)
        Me.gbxLeche.Controls.Add(Me.tbxRecuentobac)
        Me.gbxLeche.Controls.Add(Me.lblLitros)
        Me.gbxLeche.Controls.Add(Me.lblRecuentobac)
        Me.gbxLeche.Controls.Add(Me.tbxLitros)
        Me.gbxLeche.Enabled = False
        Me.gbxLeche.Location = New System.Drawing.Point(28, 154)
        Me.gbxLeche.Name = "gbxLeche"
        Me.gbxLeche.Size = New System.Drawing.Size(756, 370)
        Me.gbxLeche.TabIndex = 73
        Me.gbxLeche.TabStop = False
        '
        'tbxConsumoe
        '
        Me.tbxConsumoe.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxConsumoe.Location = New System.Drawing.Point(607, 75)
        Me.tbxConsumoe.MaxLength = 11
        Me.tbxConsumoe.Name = "tbxConsumoe"
        Me.tbxConsumoe.Size = New System.Drawing.Size(142, 32)
        Me.tbxConsumoe.TabIndex = 117
        Me.tbxConsumoe.Text = "00000000000"
        '
        'tbxConsumoi
        '
        Me.tbxConsumoi.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxConsumoi.Location = New System.Drawing.Point(608, 38)
        Me.tbxConsumoi.MaxLength = 11
        Me.tbxConsumoi.Name = "tbxConsumoi"
        Me.tbxConsumoi.Size = New System.Drawing.Size(142, 32)
        Me.tbxConsumoi.TabIndex = 116
        Me.tbxConsumoi.Text = "00000000000"
        '
        'chbConsumoi
        '
        Me.chbConsumoi.AutoSize = True
        Me.chbConsumoi.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbConsumoi.Location = New System.Drawing.Point(415, 40)
        Me.chbConsumoi.Name = "chbConsumoi"
        Me.chbConsumoi.Size = New System.Drawing.Size(187, 28)
        Me.chbConsumoi.TabIndex = 115
        Me.chbConsumoi.Text = "Consumo interno"
        Me.chbConsumoi.UseVisualStyleBackColor = True
        '
        'chbConsumoe
        '
        Me.chbConsumoe.AutoSize = True
        Me.chbConsumoe.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbConsumoe.Location = New System.Drawing.Point(415, 77)
        Me.chbConsumoe.Name = "chbConsumoe"
        Me.chbConsumoe.Size = New System.Drawing.Size(193, 28)
        Me.chbConsumoe.TabIndex = 114
        Me.chbConsumoe.Text = "Consumo externo"
        Me.chbConsumoe.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.tbxNumLote)
        Me.GroupBox1.Controls.Add(Me.lblNumLote)
        Me.GroupBox1.Location = New System.Drawing.Point(416, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 156)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        '
        'btnOrdeñado
        '
        Me.btnOrdeñado.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdeñado.Location = New System.Drawing.Point(342, 312)
        Me.btnOrdeñado.Name = "btnOrdeñado"
        Me.btnOrdeñado.Size = New System.Drawing.Size(118, 42)
        Me.btnOrdeñado.TabIndex = 116
        Me.btnOrdeñado.Text = "Ordeñado"
        Me.btnOrdeñado.UseVisualStyleBackColor = True
        '
        'tbxNumLote
        '
        Me.tbxNumLote.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumLote.Location = New System.Drawing.Point(25, 85)
        Me.tbxNumLote.MaxLength = 9
        Me.tbxNumLote.Name = "tbxNumLote"
        Me.tbxNumLote.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumLote.TabIndex = 114
        Me.tbxNumLote.Text = "000000000"
        '
        'lblNumLote
        '
        Me.lblNumLote.AutoSize = True
        Me.lblNumLote.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLote.Location = New System.Drawing.Point(21, 46)
        Me.lblNumLote.Name = "lblNumLote"
        Me.lblNumLote.Size = New System.Drawing.Size(151, 24)
        Me.lblNumLote.TabIndex = 113
        Me.lblNumLote.Text = "Numero de lote"
        '
        'tbxGrasa
        '
        Me.tbxGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGrasa.Location = New System.Drawing.Point(257, 76)
        Me.tbxGrasa.MaxLength = 3
        Me.tbxGrasa.Name = "tbxGrasa"
        Me.tbxGrasa.Size = New System.Drawing.Size(142, 32)
        Me.tbxGrasa.TabIndex = 57
        Me.tbxGrasa.Text = "000"
        '
        'lblGrasa
        '
        Me.lblGrasa.AutoSize = True
        Me.lblGrasa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrasa.Location = New System.Drawing.Point(12, 79)
        Me.lblGrasa.Name = "lblGrasa"
        Me.lblGrasa.Size = New System.Drawing.Size(199, 24)
        Me.lblGrasa.TabIndex = 56
        Me.lblGrasa.Text = "Porcentaje de grasa"
        '
        'tbxProteina
        '
        Me.tbxProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxProteina.Location = New System.Drawing.Point(257, 119)
        Me.tbxProteina.MaxLength = 3
        Me.tbxProteina.Name = "tbxProteina"
        Me.tbxProteina.Size = New System.Drawing.Size(142, 32)
        Me.tbxProteina.TabIndex = 55
        Me.tbxProteina.Text = "000"
        '
        'lblProteina
        '
        Me.lblProteina.AutoSize = True
        Me.lblProteina.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteina.Location = New System.Drawing.Point(12, 122)
        Me.lblProteina.Name = "lblProteina"
        Me.lblProteina.Size = New System.Drawing.Size(222, 24)
        Me.lblProteina.TabIndex = 54
        Me.lblProteina.Text = "Porcentaje de proteina"
        '
        'tbxUrea
        '
        Me.tbxUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUrea.Location = New System.Drawing.Point(257, 166)
        Me.tbxUrea.MaxLength = 3
        Me.tbxUrea.Name = "tbxUrea"
        Me.tbxUrea.Size = New System.Drawing.Size(142, 32)
        Me.tbxUrea.TabIndex = 53
        Me.tbxUrea.Text = "000"
        '
        'lblUrea
        '
        Me.lblUrea.AutoSize = True
        Me.lblUrea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrea.Location = New System.Drawing.Point(12, 169)
        Me.lblUrea.Name = "lblUrea"
        Me.lblUrea.Size = New System.Drawing.Size(188, 24)
        Me.lblUrea.TabIndex = 52
        Me.lblUrea.Text = "Porcentaje de urea"
        '
        'tbxRecuentocel
        '
        Me.tbxRecuentocel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentocel.Location = New System.Drawing.Point(257, 243)
        Me.tbxRecuentocel.MaxLength = 11
        Me.tbxRecuentocel.Name = "tbxRecuentocel"
        Me.tbxRecuentocel.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentocel.TabIndex = 51
        Me.tbxRecuentocel.Text = "00000000000"
        '
        'lblRecuentoCel
        '
        Me.lblRecuentoCel.AutoSize = True
        Me.lblRecuentoCel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentoCel.Location = New System.Drawing.Point(12, 243)
        Me.lblRecuentoCel.Name = "lblRecuentoCel"
        Me.lblRecuentoCel.Size = New System.Drawing.Size(200, 48)
        Me.lblRecuentoCel.TabIndex = 50
        Me.lblRecuentoCel.Text = "Recuento de células" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      somáticas"
        '
        'tbxRecuentobac
        '
        Me.tbxRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecuentobac.Location = New System.Drawing.Point(257, 204)
        Me.tbxRecuentobac.MaxLength = 11
        Me.tbxRecuentobac.Name = "tbxRecuentobac"
        Me.tbxRecuentobac.Size = New System.Drawing.Size(142, 32)
        Me.tbxRecuentobac.TabIndex = 49
        Me.tbxRecuentobac.Text = "00000000000"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(12, 41)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(63, 24)
        Me.lblLitros.TabIndex = 46
        Me.lblLitros.Text = "Litros"
        '
        'lblRecuentobac
        '
        Me.lblRecuentobac.AutoSize = True
        Me.lblRecuentobac.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuentobac.Location = New System.Drawing.Point(12, 207)
        Me.lblRecuentobac.Name = "lblRecuentobac"
        Me.lblRecuentobac.Size = New System.Drawing.Size(205, 24)
        Me.lblRecuentobac.TabIndex = 48
        Me.lblRecuentobac.Text = "Recuento bacteriano"
        '
        'tbxLitros
        '
        Me.tbxLitros.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLitros.Location = New System.Drawing.Point(257, 38)
        Me.tbxLitros.MaxLength = 11
        Me.tbxLitros.Name = "tbxLitros"
        Me.tbxLitros.Size = New System.Drawing.Size(142, 32)
        Me.tbxLitros.TabIndex = 47
        Me.tbxLitros.Text = "00000000000"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(38, 80)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(62, 24)
        Me.lblTurno.TabIndex = 108
        Me.lblTurno.Text = "Turno"
        '
        'cbxCantidad
        '
        Me.cbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxCantidad.Location = New System.Drawing.Point(274, 72)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(142, 32)
        Me.cbxCantidad.TabIndex = 109
        '
        'gbxTercer
        '
        Me.gbxTercer.Controls.Add(Me.dtpFint)
        Me.gbxTercer.Controls.Add(Me.dtpIniciot)
        Me.gbxTercer.Controls.Add(Me.dtpFecha)
        Me.gbxTercer.Controls.Add(Me.lblFecha)
        Me.gbxTercer.Controls.Add(Me.lblFinalt)
        Me.gbxTercer.Controls.Add(Me.lblIniciot)
        Me.gbxTercer.Enabled = False
        Me.gbxTercer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTercer.Location = New System.Drawing.Point(439, 12)
        Me.gbxTercer.Name = "gbxTercer"
        Me.gbxTercer.Size = New System.Drawing.Size(345, 136)
        Me.gbxTercer.TabIndex = 111
        Me.gbxTercer.TabStop = False
        '
        'dtpFint
        '
        Me.dtpFint.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFint.Location = New System.Drawing.Point(178, 95)
        Me.dtpFint.Name = "dtpFint"
        Me.dtpFint.Size = New System.Drawing.Size(152, 32)
        Me.dtpFint.TabIndex = 81
        Me.dtpFint.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'dtpIniciot
        '
        Me.dtpIniciot.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpIniciot.Location = New System.Drawing.Point(178, 57)
        Me.dtpIniciot.Name = "dtpIniciot"
        Me.dtpIniciot.Size = New System.Drawing.Size(152, 32)
        Me.dtpIniciot.TabIndex = 80
        Me.dtpIniciot.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(178, 21)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(152, 32)
        Me.dtpFecha.TabIndex = 79
        Me.dtpFecha.Value = New Date(2016, 11, 1, 20, 54, 0, 0)
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(26, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 78
        Me.lblFecha.Text = "Fecha"
        '
        'lblFinalt
        '
        Me.lblFinalt.AutoSize = True
        Me.lblFinalt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalt.Location = New System.Drawing.Point(26, 101)
        Me.lblFinalt.Name = "lblFinalt"
        Me.lblFinalt.Size = New System.Drawing.Size(99, 24)
        Me.lblFinalt.TabIndex = 64
        Me.lblFinalt.Text = "Hora final"
        '
        'lblIniciot
        '
        Me.lblIniciot.AutoSize = True
        Me.lblIniciot.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciot.Location = New System.Drawing.Point(26, 63)
        Me.lblIniciot.Name = "lblIniciot"
        Me.lblIniciot.Size = New System.Drawing.Size(110, 24)
        Me.lblIniciot.TabIndex = 62
        Me.lblIniciot.Text = "Hora inicio"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(192, 85)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(118, 42)
        Me.btnConsultar.TabIndex = 127
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(192, 37)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 126
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmOrdeñe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxTercer)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.cbxCantidad)
        Me.Controls.Add(Me.gbxLeche)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmOrdeñe"
        Me.Text = "Ordeñe"
        Me.gbxLeche.ResumeLayout(False)
        Me.gbxLeche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxTercer.ResumeLayout(False)
        Me.gbxTercer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents gbxLeche As System.Windows.Forms.GroupBox
    Friend WithEvents tbxGrasa As System.Windows.Forms.TextBox
    Friend WithEvents lblGrasa As System.Windows.Forms.Label
    Friend WithEvents tbxProteina As System.Windows.Forms.TextBox
    Friend WithEvents lblProteina As System.Windows.Forms.Label
    Friend WithEvents tbxUrea As System.Windows.Forms.TextBox
    Friend WithEvents lblUrea As System.Windows.Forms.Label
    Friend WithEvents tbxRecuentocel As System.Windows.Forms.TextBox
    Friend WithEvents lblRecuentoCel As System.Windows.Forms.Label
    Friend WithEvents tbxRecuentobac As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros As System.Windows.Forms.Label
    Friend WithEvents lblRecuentobac As System.Windows.Forms.Label
    Friend WithEvents tbxLitros As System.Windows.Forms.TextBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumLote As System.Windows.Forms.Label
    Friend WithEvents tbxNumLote As System.Windows.Forms.TextBox
    Friend WithEvents btnOrdeñado As System.Windows.Forms.Button
    Friend WithEvents gbxTercer As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFint As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIniciot As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblFinalt As System.Windows.Forms.Label
    Friend WithEvents lblIniciot As System.Windows.Forms.Label
    Friend WithEvents tbxConsumoe As System.Windows.Forms.TextBox
    Friend WithEvents tbxConsumoi As System.Windows.Forms.TextBox
    Friend WithEvents chbConsumoi As System.Windows.Forms.CheckBox
    Friend WithEvents chbConsumoe As System.Windows.Forms.CheckBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
