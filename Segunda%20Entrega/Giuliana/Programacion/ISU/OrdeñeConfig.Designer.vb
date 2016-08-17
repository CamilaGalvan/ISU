<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdeñeConfig
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
        Me.gbxTercer = New System.Windows.Forms.GroupBox()
        Me.dtpFinalt = New System.Windows.Forms.DateTimePicker()
        Me.dtpIniciot = New System.Windows.Forms.DateTimePicker()
        Me.lblFinalt = New System.Windows.Forms.Label()
        Me.lblIniciot = New System.Windows.Forms.Label()
        Me.lblOrdeñecant = New System.Windows.Forms.Label()
        Me.gbxSegundo = New System.Windows.Forms.GroupBox()
        Me.dtpFinals = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicios = New System.Windows.Forms.DateTimePicker()
        Me.lblFinals = New System.Windows.Forms.Label()
        Me.lblInicios = New System.Windows.Forms.Label()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.gbxPrimer = New System.Windows.Forms.GroupBox()
        Me.dtpFinalp = New System.Windows.Forms.DateTimePicker()
        Me.stpIniciop = New System.Windows.Forms.DateTimePicker()
        Me.lblFinalp = New System.Windows.Forms.Label()
        Me.lblIniciop = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbxTercer.SuspendLayout()
        Me.gbxSegundo.SuspendLayout()
        Me.gbxPrimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlBlue.Location = New System.Drawing.Point(803, 0)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(24, 579)
        Me.pnlBlue.TabIndex = 73
        Me.pnlBlue.Visible = False
        '
        'gbxTercer
        '
        Me.gbxTercer.Controls.Add(Me.dtpFinalt)
        Me.gbxTercer.Controls.Add(Me.dtpIniciot)
        Me.gbxTercer.Controls.Add(Me.lblFinalt)
        Me.gbxTercer.Controls.Add(Me.lblIniciot)
        Me.gbxTercer.Enabled = False
        Me.gbxTercer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTercer.Location = New System.Drawing.Point(436, 360)
        Me.gbxTercer.Name = "gbxTercer"
        Me.gbxTercer.Size = New System.Drawing.Size(345, 136)
        Me.gbxTercer.TabIndex = 112
        Me.gbxTercer.TabStop = False
        Me.gbxTercer.Text = "3er Ordeñe"
        '
        'dtpFinalt
        '
        Me.dtpFinalt.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFinalt.Location = New System.Drawing.Point(187, 73)
        Me.dtpFinalt.Name = "dtpFinalt"
        Me.dtpFinalt.Size = New System.Drawing.Size(152, 32)
        Me.dtpFinalt.TabIndex = 85
        Me.dtpFinalt.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'dtpIniciot
        '
        Me.dtpIniciot.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpIniciot.Location = New System.Drawing.Point(187, 35)
        Me.dtpIniciot.Name = "dtpIniciot"
        Me.dtpIniciot.Size = New System.Drawing.Size(152, 32)
        Me.dtpIniciot.TabIndex = 84
        Me.dtpIniciot.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'lblFinalt
        '
        Me.lblFinalt.AutoSize = True
        Me.lblFinalt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalt.Location = New System.Drawing.Point(17, 79)
        Me.lblFinalt.Name = "lblFinalt"
        Me.lblFinalt.Size = New System.Drawing.Size(99, 24)
        Me.lblFinalt.TabIndex = 64
        Me.lblFinalt.Text = "Hora final"
        '
        'lblIniciot
        '
        Me.lblIniciot.AutoSize = True
        Me.lblIniciot.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciot.Location = New System.Drawing.Point(17, 41)
        Me.lblIniciot.Name = "lblIniciot"
        Me.lblIniciot.Size = New System.Drawing.Size(110, 24)
        Me.lblIniciot.TabIndex = 62
        Me.lblIniciot.Text = "Hora inicio"
        '
        'lblOrdeñecant
        '
        Me.lblOrdeñecant.AutoSize = True
        Me.lblOrdeñecant.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdeñecant.Location = New System.Drawing.Point(17, 181)
        Me.lblOrdeñecant.Name = "lblOrdeñecant"
        Me.lblOrdeñecant.Size = New System.Drawing.Size(204, 24)
        Me.lblOrdeñecant.TabIndex = 108
        Me.lblOrdeñecant.Text = "Cantidad de ordeñes"
        '
        'gbxSegundo
        '
        Me.gbxSegundo.Controls.Add(Me.dtpFinals)
        Me.gbxSegundo.Controls.Add(Me.dtpInicios)
        Me.gbxSegundo.Controls.Add(Me.lblFinals)
        Me.gbxSegundo.Controls.Add(Me.lblInicios)
        Me.gbxSegundo.Enabled = False
        Me.gbxSegundo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSegundo.Location = New System.Drawing.Point(436, 198)
        Me.gbxSegundo.Name = "gbxSegundo"
        Me.gbxSegundo.Size = New System.Drawing.Size(345, 136)
        Me.gbxSegundo.TabIndex = 111
        Me.gbxSegundo.TabStop = False
        Me.gbxSegundo.Text = "2do Ordeñe"
        '
        'dtpFinals
        '
        Me.dtpFinals.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFinals.Location = New System.Drawing.Point(187, 73)
        Me.dtpFinals.Name = "dtpFinals"
        Me.dtpFinals.Size = New System.Drawing.Size(152, 32)
        Me.dtpFinals.TabIndex = 85
        Me.dtpFinals.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'dtpInicios
        '
        Me.dtpInicios.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpInicios.Location = New System.Drawing.Point(187, 35)
        Me.dtpInicios.Name = "dtpInicios"
        Me.dtpInicios.Size = New System.Drawing.Size(152, 32)
        Me.dtpInicios.TabIndex = 84
        Me.dtpInicios.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'lblFinals
        '
        Me.lblFinals.AutoSize = True
        Me.lblFinals.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinals.Location = New System.Drawing.Point(17, 79)
        Me.lblFinals.Name = "lblFinals"
        Me.lblFinals.Size = New System.Drawing.Size(99, 24)
        Me.lblFinals.TabIndex = 64
        Me.lblFinals.Text = "Hora final"
        '
        'lblInicios
        '
        Me.lblInicios.AutoSize = True
        Me.lblInicios.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicios.Location = New System.Drawing.Point(17, 41)
        Me.lblInicios.Name = "lblInicios"
        Me.lblInicios.Size = New System.Drawing.Size(110, 24)
        Me.lblInicios.TabIndex = 62
        Me.lblInicios.Text = "Hora inicio"
        '
        'cbxCantidad
        '
        Me.cbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxCantidad.Location = New System.Drawing.Point(281, 178)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(121, 32)
        Me.cbxCantidad.TabIndex = 109
        '
        'gbxPrimer
        '
        Me.gbxPrimer.Controls.Add(Me.dtpFinalp)
        Me.gbxPrimer.Controls.Add(Me.stpIniciop)
        Me.gbxPrimer.Controls.Add(Me.lblFinalp)
        Me.gbxPrimer.Controls.Add(Me.lblIniciop)
        Me.gbxPrimer.Enabled = False
        Me.gbxPrimer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPrimer.Location = New System.Drawing.Point(436, 46)
        Me.gbxPrimer.Name = "gbxPrimer"
        Me.gbxPrimer.Size = New System.Drawing.Size(345, 136)
        Me.gbxPrimer.TabIndex = 110
        Me.gbxPrimer.TabStop = False
        Me.gbxPrimer.Text = "1er Ordeñe"
        '
        'dtpFinalp
        '
        Me.dtpFinalp.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFinalp.Location = New System.Drawing.Point(187, 76)
        Me.dtpFinalp.Name = "dtpFinalp"
        Me.dtpFinalp.Size = New System.Drawing.Size(152, 32)
        Me.dtpFinalp.TabIndex = 83
        Me.dtpFinalp.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'stpIniciop
        '
        Me.stpIniciop.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.stpIniciop.Location = New System.Drawing.Point(187, 38)
        Me.stpIniciop.Name = "stpIniciop"
        Me.stpIniciop.Size = New System.Drawing.Size(152, 32)
        Me.stpIniciop.TabIndex = 82
        Me.stpIniciop.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'lblFinalp
        '
        Me.lblFinalp.AutoSize = True
        Me.lblFinalp.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalp.Location = New System.Drawing.Point(17, 82)
        Me.lblFinalp.Name = "lblFinalp"
        Me.lblFinalp.Size = New System.Drawing.Size(99, 24)
        Me.lblFinalp.TabIndex = 64
        Me.lblFinalp.Text = "Hora final"
        '
        'lblIniciop
        '
        Me.lblIniciop.AutoSize = True
        Me.lblIniciop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciop.Location = New System.Drawing.Point(17, 44)
        Me.lblIniciop.Name = "lblIniciop"
        Me.lblIniciop.Size = New System.Drawing.Size(110, 24)
        Me.lblIniciop.TabIndex = 62
        Me.lblIniciop.Text = "Hora inicio"
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(126, 268)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.btnGuardar.TabIndex = 113
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmOrdeñeConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbxTercer)
        Me.Controls.Add(Me.lblOrdeñecant)
        Me.Controls.Add(Me.gbxSegundo)
        Me.Controls.Add(Me.cbxCantidad)
        Me.Controls.Add(Me.gbxPrimer)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmOrdeñeConfig"
        Me.Text = "Ordeñe"
        Me.gbxTercer.ResumeLayout(False)
        Me.gbxTercer.PerformLayout()
        Me.gbxSegundo.ResumeLayout(False)
        Me.gbxSegundo.PerformLayout()
        Me.gbxPrimer.ResumeLayout(False)
        Me.gbxPrimer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents gbxTercer As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinalt As System.Windows.Forms.Label
    Friend WithEvents lblIniciot As System.Windows.Forms.Label
    Friend WithEvents lblOrdeñecant As System.Windows.Forms.Label
    Friend WithEvents gbxSegundo As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinals As System.Windows.Forms.Label
    Friend WithEvents lblInicios As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents gbxPrimer As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinalp As System.Windows.Forms.Label
    Friend WithEvents lblIniciop As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dtpFinalt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIniciot As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinals As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicios As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinalp As System.Windows.Forms.DateTimePicker
    Friend WithEvents stpIniciop As System.Windows.Forms.DateTimePicker
End Class
