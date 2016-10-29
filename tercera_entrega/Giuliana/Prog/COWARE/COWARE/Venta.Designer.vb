<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tbxCantidad = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.gbxDatos.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(285, 381)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.btnGuardar.TabIndex = 120
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.dtpHora)
        Me.gbxDatos.Controls.Add(Me.lblHora)
        Me.gbxDatos.Controls.Add(Me.dtpFecha)
        Me.gbxDatos.Controls.Add(Me.lblTipo)
        Me.gbxDatos.Controls.Add(Me.tbxCantidad)
        Me.gbxDatos.Controls.Add(Me.lblFecha)
        Me.gbxDatos.Controls.Add(Me.lblCantidad)
        Me.gbxDatos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(160, 80)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(378, 269)
        Me.gbxDatos.TabIndex = 119
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Alimento proporcionado"
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(202, 199)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(145, 32)
        Me.dtpHora.TabIndex = 116
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(242, 172)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(55, 24)
        Me.lblHora.TabIndex = 115
        Me.lblHora.Text = "Hora"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(10, 199)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(145, 32)
        Me.dtpFecha.TabIndex = 114
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(248, 85)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(49, 24)
        Me.lblTipo.TabIndex = 112
        Me.lblTipo.Text = "Tipo"
        '
        'tbxCantidad
        '
        Me.tbxCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCantidad.Location = New System.Drawing.Point(10, 82)
        Me.tbxCantidad.MaxLength = 50
        Me.tbxCantidad.Name = "tbxCantidad"
        Me.tbxCantidad.Size = New System.Drawing.Size(145, 32)
        Me.tbxCantidad.TabIndex = 111
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(50, 172)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 78
        Me.lblFecha.Text = "Fecha"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(26, 55)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(93, 24)
        Me.lblCantidad.TabIndex = 110
        Me.lblCantidad.Text = "Cantidad"
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(697, 1)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 129
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(650, 1)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 128
        Me.pbxMini.TabStop = False
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(823, 498)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbxDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVenta"
        Me.Text = "Venta"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents tbxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
End Class
