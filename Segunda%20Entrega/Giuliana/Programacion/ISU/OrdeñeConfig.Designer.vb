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
        Me.lblFinalt = New System.Windows.Forms.Label()
        Me.lblIniciot = New System.Windows.Forms.Label()
        Me.lblOrdeñecant = New System.Windows.Forms.Label()
        Me.gbxSegundo = New System.Windows.Forms.GroupBox()
        Me.lblFinals = New System.Windows.Forms.Label()
        Me.lblInicios = New System.Windows.Forms.Label()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.gbxPrimer = New System.Windows.Forms.GroupBox()
        Me.lblFinalp = New System.Windows.Forms.Label()
        Me.lblIniciop = New System.Windows.Forms.Label()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
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
        Me.gbxTercer.Controls.Add(Me.DateTimePicker5)
        Me.gbxTercer.Controls.Add(Me.DateTimePicker6)
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
        Me.gbxSegundo.Controls.Add(Me.DateTimePicker1)
        Me.gbxSegundo.Controls.Add(Me.DateTimePicker4)
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
        Me.gbxPrimer.Controls.Add(Me.DateTimePicker3)
        Me.gbxPrimer.Controls.Add(Me.DateTimePicker2)
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
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(126, 268)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 113
        Me.btnOpcion.Text = "Guardar"
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(187, 76)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker3.TabIndex = 83
        Me.DateTimePicker3.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(187, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker2.TabIndex = 82
        Me.DateTimePicker2.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(187, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker1.TabIndex = 85
        Me.DateTimePicker1.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker4.Location = New System.Drawing.Point(187, 35)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker4.TabIndex = 84
        Me.DateTimePicker4.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker5.Location = New System.Drawing.Point(187, 73)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker5.TabIndex = 85
        Me.DateTimePicker5.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker6.Location = New System.Drawing.Point(187, 35)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(152, 32)
        Me.DateTimePicker6.TabIndex = 84
        Me.DateTimePicker6.Value = New Date(2016, 8, 6, 0, 0, 0, 0)
        '
        'frmOrdeñeConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.btnOpcion)
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
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
