<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTambo))
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
        Me.btnTanque_Consultar = New System.Windows.Forms.Button()
        Me.btnTanque_Quitar = New System.Windows.Forms.Button()
        Me.btnTanque_Agregar = New System.Windows.Forms.Button()
        Me.tbxCapacidad = New System.Windows.Forms.TextBox()
        Me.lblNSerie = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.tbxNserie = New System.Windows.Forms.TextBox()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.gbxGeneral.SuspendLayout()
        Me.gbxTanque.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(529, 36)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 105
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(375, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 106
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxSerie
        '
        Me.tbxSerie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSerie.Location = New System.Drawing.Point(174, 42)
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
        Me.gbxGeneral.Controls.Add(Me.tbxNombre)
        Me.gbxGeneral.Controls.Add(Me.lblNombre)
        Me.gbxGeneral.Controls.Add(Me.tbxGanado_max)
        Me.gbxGeneral.Controls.Add(Me.lblganado_max)
        Me.gbxGeneral.Controls.Add(Me.tbxHectareas)
        Me.gbxGeneral.Controls.Add(Me.lblHectareas)
        Me.gbxGeneral.Enabled = False
        Me.gbxGeneral.Location = New System.Drawing.Point(12, 103)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(785, 369)
        Me.gbxGeneral.TabIndex = 114
        Me.gbxGeneral.TabStop = False
        '
        'gbxTanque
        '
        Me.gbxTanque.Controls.Add(Me.btnTanque_Consultar)
        Me.gbxTanque.Controls.Add(Me.btnTanque_Quitar)
        Me.gbxTanque.Controls.Add(Me.btnTanque_Agregar)
        Me.gbxTanque.Controls.Add(Me.tbxCapacidad)
        Me.gbxTanque.Controls.Add(Me.lblNSerie)
        Me.gbxTanque.Controls.Add(Me.lblCapacidad)
        Me.gbxTanque.Controls.Add(Me.tbxNserie)
        Me.gbxTanque.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTanque.Location = New System.Drawing.Point(217, 142)
        Me.gbxTanque.Name = "gbxTanque"
        Me.gbxTanque.Size = New System.Drawing.Size(397, 213)
        Me.gbxTanque.TabIndex = 118
        Me.gbxTanque.TabStop = False
        Me.gbxTanque.Text = "Tanques"
        '
        'btnTanque_Consultar
        '
        Me.btnTanque_Consultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Consultar.Location = New System.Drawing.Point(254, 143)
        Me.btnTanque_Consultar.Name = "btnTanque_Consultar"
        Me.btnTanque_Consultar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Consultar.TabIndex = 125
        Me.btnTanque_Consultar.Text = "Consultar"
        Me.btnTanque_Consultar.UseVisualStyleBackColor = True
        '
        'btnTanque_Quitar
        '
        Me.btnTanque_Quitar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Quitar.Location = New System.Drawing.Point(130, 143)
        Me.btnTanque_Quitar.Name = "btnTanque_Quitar"
        Me.btnTanque_Quitar.Size = New System.Drawing.Size(118, 42)
        Me.btnTanque_Quitar.TabIndex = 123
        Me.btnTanque_Quitar.Text = "Quitar"
        Me.btnTanque_Quitar.UseVisualStyleBackColor = True
        '
        'btnTanque_Agregar
        '
        Me.btnTanque_Agregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanque_Agregar.Location = New System.Drawing.Point(6, 143)
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
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(746, 0)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 118
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(699, 0)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 117
        Me.pbxMini.TabStop = False
        '
        'frmTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 501)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.tbxSerie)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnOpcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTambo"
        Me.Text = "Tambo"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        Me.gbxTanque.ResumeLayout(False)
        Me.gbxTanque.PerformLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents tbxHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents tbxGanado_max As System.Windows.Forms.TextBox
    Friend WithEvents lblganado_max As System.Windows.Forms.Label
    Friend WithEvents gbxGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents gbxTanque As System.Windows.Forms.GroupBox
    Friend WithEvents btnTanque_Quitar As System.Windows.Forms.Button
    Friend WithEvents btnTanque_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbxCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents lblNSerie As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents tbxNserie As System.Windows.Forms.TextBox
    Friend WithEvents btnTanque_Consultar As System.Windows.Forms.Button
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
End Class
