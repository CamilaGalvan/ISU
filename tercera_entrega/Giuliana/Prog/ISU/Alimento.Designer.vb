﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlimento
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
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tbxCantidad = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbxLote = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxNumLote = New System.Windows.Forms.TextBox()
        Me.lblNumLote = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.gbxLote.SuspendLayout()
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
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.dtpHora)
        Me.gbxDatos.Controls.Add(Me.lblHora)
        Me.gbxDatos.Controls.Add(Me.dtpFecha)
        Me.gbxDatos.Controls.Add(Me.cbxTipo)
        Me.gbxDatos.Controls.Add(Me.lblTipo)
        Me.gbxDatos.Controls.Add(Me.tbxCantidad)
        Me.gbxDatos.Controls.Add(Me.lblFecha)
        Me.gbxDatos.Controls.Add(Me.lblCantidad)
        Me.gbxDatos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(19, 90)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(442, 310)
        Me.gbxDatos.TabIndex = 116
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Alimento proporcionado"
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(255, 250)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(145, 32)
        Me.dtpHora.TabIndex = 116
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(295, 223)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(55, 24)
        Me.lblHora.TabIndex = 115
        Me.lblHora.Text = "Hora"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(29, 250)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(145, 32)
        Me.dtpFecha.TabIndex = 114
        '
        'cbxTipo
        '
        Me.cbxTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxTipo.Location = New System.Drawing.Point(255, 133)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(145, 32)
        Me.cbxTipo.TabIndex = 113
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(304, 106)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(49, 24)
        Me.lblTipo.TabIndex = 112
        Me.lblTipo.Text = "Tipo"
        '
        'tbxCantidad
        '
        Me.tbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCantidad.Location = New System.Drawing.Point(29, 133)
        Me.tbxCantidad.MaxLength = 50
        Me.tbxCantidad.Name = "tbxCantidad"
        Me.tbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.tbxCantidad.TabIndex = 111
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(69, 223)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 78
        Me.lblFecha.Text = "Fecha"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(45, 106)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(93, 24)
        Me.lblCantidad.TabIndex = 110
        Me.lblCantidad.Text = "Cantidad"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(580, 337)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.btnGuardar.TabIndex = 117
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbxLote
        '
        Me.gbxLote.Controls.Add(Me.btnConsultar)
        Me.gbxLote.Controls.Add(Me.btnAgregar)
        Me.gbxLote.Controls.Add(Me.tbxNumLote)
        Me.gbxLote.Controls.Add(Me.lblNumLote)
        Me.gbxLote.Location = New System.Drawing.Point(467, 126)
        Me.gbxLote.Name = "gbxLote"
        Me.gbxLote.Size = New System.Drawing.Size(330, 156)
        Me.gbxLote.TabIndex = 118
        Me.gbxLote.TabStop = False
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
        'frmAlimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxLote)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmAlimento"
        Me.Text = "Alimento"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.gbxLote.ResumeLayout(False)
        Me.gbxLote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents tbxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents gbxLote As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents tbxNumLote As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLote As System.Windows.Forms.Label
End Class
