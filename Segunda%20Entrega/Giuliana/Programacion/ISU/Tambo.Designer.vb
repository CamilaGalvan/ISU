﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambo
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
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxSerie = New System.Windows.Forms.TextBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.tbxHectareas = New System.Windows.Forms.TextBox()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.tbxGanado_max = New System.Windows.Forms.TextBox()
        Me.lblganado_max = New System.Windows.Forms.Label()
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.gbxTanque = New System.Windows.Forms.GroupBox()
        Me.btnTanque_Modificar = New System.Windows.Forms.Button()
        Me.btnTanque_Quitar = New System.Windows.Forms.Button()
        Me.btnTanque_Agregar = New System.Windows.Forms.Button()
        Me.tbxCapacidad = New System.Windows.Forms.TextBox()
        Me.lblNSerie = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.tbxNserie = New System.Windows.Forms.TextBox()
        Me.gbxAlimento = New System.Windows.Forms.GroupBox()
        Me.btnAlimento_Quitar = New System.Windows.Forms.Button()
        Me.btnAlimento_Agregar = New System.Windows.Forms.Button()
        Me.cbxCantidad = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tbxCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnTanque_Consultar = New System.Windows.Forms.Button()
        Me.btnAlimento_Consultar = New System.Windows.Forms.Button()
        Me.gbxGeneral.SuspendLayout()
        Me.gbxTanque.SuspendLayout()
        Me.gbxAlimento.SuspendLayout()
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
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(605, 36)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(451, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 106
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxSerie
        '
        Me.tbxSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSerie.Location = New System.Drawing.Point(250, 42)
        Me.tbxSerie.MaxLength = 11
        Me.tbxSerie.Name = "tbxSerie"
        Me.tbxSerie.Size = New System.Drawing.Size(145, 32)
        Me.tbxSerie.TabIndex = 109
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(42, 45)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(60, 24)
        Me.lblSerie.TabIndex = 108
        Me.lblSerie.Text = "Serie"
        '
        'tbxHectareas
        '
        Me.tbxHectareas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHectareas.Location = New System.Drawing.Point(238, 78)
        Me.tbxHectareas.MaxLength = 11
        Me.tbxHectareas.Name = "tbxHectareas"
        Me.tbxHectareas.Size = New System.Drawing.Size(145, 32)
        Me.tbxHectareas.TabIndex = 111
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(30, 81)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(107, 24)
        Me.lblHectareas.TabIndex = 110
        Me.lblHectareas.Text = "Hectareas"
        '
        'tbxGanado_max
        '
        Me.tbxGanado_max.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxGanado_max.Location = New System.Drawing.Point(534, 78)
        Me.tbxGanado_max.MaxLength = 11
        Me.tbxGanado_max.Name = "tbxGanado_max"
        Me.tbxGanado_max.Size = New System.Drawing.Size(145, 32)
        Me.tbxGanado_max.TabIndex = 113
        '
        'lblganado_max
        '
        Me.lblganado_max.AutoSize = True
        Me.lblganado_max.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblganado_max.Location = New System.Drawing.Point(464, 38)
        Me.lblganado_max.Name = "lblganado_max"
        Me.lblganado_max.Size = New System.Drawing.Size(274, 24)
        Me.lblganado_max.TabIndex = 112
        Me.lblganado_max.Text = "Cantidad maxima de ganado"
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.gbxTanque)
        Me.gbxGeneral.Controls.Add(Me.gbxAlimento)
        Me.gbxGeneral.Controls.Add(Me.tbxNombre)
        Me.gbxGeneral.Controls.Add(Me.lblNombre)
        Me.gbxGeneral.Controls.Add(Me.tbxGanado_max)
        Me.gbxGeneral.Controls.Add(Me.lblganado_max)
        Me.gbxGeneral.Controls.Add(Me.tbxHectareas)
        Me.gbxGeneral.Controls.Add(Me.lblHectareas)
        Me.gbxGeneral.Enabled = False
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 103)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(785, 421)
        Me.gbxGeneral.TabIndex = 114
        Me.gbxGeneral.TabStop = False
        '
        'gbxTanque
        '
        Me.gbxTanque.Controls.Add(Me.btnTanque_Consultar)
        Me.gbxTanque.Controls.Add(Me.btnTanque_Modificar)
        Me.gbxTanque.Controls.Add(Me.btnTanque_Quitar)
        Me.gbxTanque.Controls.Add(Me.btnTanque_Agregar)
        Me.gbxTanque.Controls.Add(Me.tbxCapacidad)
        Me.gbxTanque.Controls.Add(Me.lblNSerie)
        Me.gbxTanque.Controls.Add(Me.lblCapacidad)
        Me.gbxTanque.Controls.Add(Me.tbxNserie)
        Me.gbxTanque.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTanque.Location = New System.Drawing.Point(17, 149)
        Me.gbxTanque.Name = "gbxTanque"
        Me.gbxTanque.Size = New System.Drawing.Size(387, 266)
        Me.gbxTanque.TabIndex = 118
        Me.gbxTanque.TabStop = False
        Me.gbxTanque.Text = "Tanques"
        '
        'btnTanque_Modificar
        '
        Me.btnTanque_Modificar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Modificar.Location = New System.Drawing.Point(254, 148)
        Me.btnTanque_Modificar.Name = "btnTanque_Modificar"
        Me.btnTanque_Modificar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Modificar.TabIndex = 124
        Me.btnTanque_Modificar.Text = "Modificar"
        Me.btnTanque_Modificar.UseVisualStyleBackColor = True
        '
        'btnTanque_Quitar
        '
        Me.btnTanque_Quitar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Quitar.Location = New System.Drawing.Point(130, 148)
        Me.btnTanque_Quitar.Name = "btnTanque_Quitar"
        Me.btnTanque_Quitar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Quitar.TabIndex = 123
        Me.btnTanque_Quitar.Text = "Quitar"
        Me.btnTanque_Quitar.UseVisualStyleBackColor = True
        '
        'btnTanque_Agregar
        '
        Me.btnTanque_Agregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Agregar.Location = New System.Drawing.Point(6, 148)
        Me.btnTanque_Agregar.Name = "btnTanque_Agregar"
        Me.btnTanque_Agregar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Agregar.TabIndex = 115
        Me.btnTanque_Agregar.Text = "Agregar"
        Me.btnTanque_Agregar.UseVisualStyleBackColor = True
        '
        'tbxCapacidad
        '
        Me.tbxCapacidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCapacidad.Location = New System.Drawing.Point(220, 92)
        Me.tbxCapacidad.MaxLength = 11
        Me.tbxCapacidad.Name = "tbxCapacidad"
        Me.tbxCapacidad.Size = New System.Drawing.Size(145, 32)
        Me.tbxCapacidad.TabIndex = 120
        '
        'lblNSerie
        '
        Me.lblNSerie.AutoSize = True
        Me.lblNSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNSerie.Location = New System.Drawing.Point(12, 34)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(164, 24)
        Me.lblNSerie.TabIndex = 121
        Me.lblNSerie.Text = "Numero de serie"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.AutoSize = True
        Me.lblCapacidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacidad.Location = New System.Drawing.Point(12, 95)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(175, 24)
        Me.lblCapacidad.TabIndex = 119
        Me.lblCapacidad.Text = "Capacidad (litros)"
        '
        'tbxNserie
        '
        Me.tbxNserie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNserie.Location = New System.Drawing.Point(220, 31)
        Me.tbxNserie.MaxLength = 11
        Me.tbxNserie.Name = "tbxNserie"
        Me.tbxNserie.Size = New System.Drawing.Size(145, 32)
        Me.tbxNserie.TabIndex = 122
        '
        'gbxAlimento
        '
        Me.gbxAlimento.Controls.Add(Me.btnAlimento_Consultar)
        Me.gbxAlimento.Controls.Add(Me.btnAlimento_Quitar)
        Me.gbxAlimento.Controls.Add(Me.btnAlimento_Agregar)
        Me.gbxAlimento.Controls.Add(Me.cbxCantidad)
        Me.gbxAlimento.Controls.Add(Me.lblTipo)
        Me.gbxAlimento.Controls.Add(Me.tbxCantidad)
        Me.gbxAlimento.Controls.Add(Me.lblCantidad)
        Me.gbxAlimento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAlimento.Location = New System.Drawing.Point(410, 149)
        Me.gbxAlimento.Name = "gbxAlimento"
        Me.gbxAlimento.Size = New System.Drawing.Size(369, 266)
        Me.gbxAlimento.TabIndex = 115
        Me.gbxAlimento.TabStop = False
        Me.gbxAlimento.Text = "Alimento proporcionado"
        '
        'btnAlimento_Quitar
        '
        Me.btnAlimento_Quitar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlimento_Quitar.Location = New System.Drawing.Point(245, 148)
        Me.btnAlimento_Quitar.Name = "btnAlimento_Quitar"
        Me.btnAlimento_Quitar.Size = New System.Drawing.Size(118, 42)
        Me.btnAlimento_Quitar.TabIndex = 125
        Me.btnAlimento_Quitar.Text = "Quitar"
        Me.btnAlimento_Quitar.UseVisualStyleBackColor = True
        '
        'btnAlimento_Agregar
        '
        Me.btnAlimento_Agregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlimento_Agregar.Location = New System.Drawing.Point(6, 148)
        Me.btnAlimento_Agregar.Name = "btnAlimento_Agregar"
        Me.btnAlimento_Agregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAlimento_Agregar.TabIndex = 116
        Me.btnAlimento_Agregar.Text = "Agregar"
        Me.btnAlimento_Agregar.UseVisualStyleBackColor = True
        '
        'cbxCantidad
        '
        Me.cbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCantidad.FormattingEnabled = True
        Me.cbxCantidad.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbxCantidad.Location = New System.Drawing.Point(182, 92)
        Me.cbxCantidad.Name = "cbxCantidad"
        Me.cbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.cbxCantidad.TabIndex = 113
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(15, 95)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(49, 24)
        Me.lblTipo.TabIndex = 112
        Me.lblTipo.Text = "Tipo"
        '
        'tbxCantidad
        '
        Me.tbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCantidad.Location = New System.Drawing.Point(182, 31)
        Me.tbxCantidad.MaxLength = 11
        Me.tbxCantidad.Name = "tbxCantidad"
        Me.tbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.tbxCantidad.TabIndex = 111
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(15, 34)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(93, 24)
        Me.lblCantidad.TabIndex = 110
        Me.lblCantidad.Text = "Cantidad"
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNombre.Location = New System.Drawing.Point(238, 35)
        Me.tbxNombre.MaxLength = 11
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(145, 32)
        Me.tbxNombre.TabIndex = 117
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(30, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 24)
        Me.lblNombre.TabIndex = 116
        Me.lblNombre.Text = "Nombre"
        '
        'btnTanque_Consultar
        '
        Me.btnTanque_Consultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Consultar.Location = New System.Drawing.Point(130, 206)
        Me.btnTanque_Consultar.Name = "btnTanque_Consultar"
        Me.btnTanque_Consultar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Consultar.TabIndex = 125
        Me.btnTanque_Consultar.Text = "Consultar"
        Me.btnTanque_Consultar.UseVisualStyleBackColor = True
        '
        'btnAlimento_Consultar
        '
        Me.btnAlimento_Consultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlimento_Consultar.Location = New System.Drawing.Point(130, 206)
        Me.btnAlimento_Consultar.Name = "btnAlimento_Consultar"
        Me.btnAlimento_Consultar.Size = New System.Drawing.Size(118, 42)
        Me.btnAlimento_Consultar.TabIndex = 126
        Me.btnAlimento_Consultar.Text = "Consultar"
        Me.btnAlimento_Consultar.UseVisualStyleBackColor = True
        '
        'frmTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.tbxSerie)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmTambo"
        Me.Text = "Tambo"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.gbxTanque.ResumeLayout(False)
        Me.gbxTanque.PerformLayout()
        Me.gbxAlimento.ResumeLayout(False)
        Me.gbxAlimento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents tbxHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents tbxGanado_max As System.Windows.Forms.TextBox
    Friend WithEvents lblganado_max As System.Windows.Forms.Label
    Friend WithEvents gbxGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents gbxAlimento As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents tbxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents cbxCantidad As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents gbxTanque As System.Windows.Forms.GroupBox
    Friend WithEvents btnTanque_Modificar As System.Windows.Forms.Button
    Friend WithEvents btnTanque_Quitar As System.Windows.Forms.Button
    Friend WithEvents btnTanque_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbxCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents lblNSerie As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents tbxNserie As System.Windows.Forms.TextBox
    Friend WithEvents btnAlimento_Quitar As System.Windows.Forms.Button
    Friend WithEvents btnAlimento_Agregar As System.Windows.Forms.Button
    Friend WithEvents btnTanque_Consultar As System.Windows.Forms.Button
    Friend WithEvents btnAlimento_Consultar As System.Windows.Forms.Button
End Class