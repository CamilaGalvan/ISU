<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonal))
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.tbxLogin = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.tbxApellido = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxTelefono = New System.Windows.Forms.ComboBox()
        Me.btnrem = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cbxPuesto = New System.Windows.Forms.ComboBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblPermiso = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.lbxEnlistar = New System.Windows.Forms.ListBox()
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.gbxDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(559, 0)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 104
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblLogin)
        Me.gbxDatos.Controls.Add(Me.tbxLogin)
        Me.gbxDatos.Controls.Add(Me.lblApellido)
        Me.gbxDatos.Controls.Add(Me.tbxApellido)
        Me.gbxDatos.Controls.Add(Me.PictureBox1)
        Me.gbxDatos.Controls.Add(Me.cbxTelefono)
        Me.gbxDatos.Controls.Add(Me.btnrem)
        Me.gbxDatos.Controls.Add(Me.btnadd)
        Me.gbxDatos.Controls.Add(Me.lblTelefono)
        Me.gbxDatos.Controls.Add(Me.tbxNombre)
        Me.gbxDatos.Controls.Add(Me.dtpNacimiento)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.cbxPuesto)
        Me.gbxDatos.Controls.Add(Me.lblNacimiento)
        Me.gbxDatos.Controls.Add(Me.cbxSexo)
        Me.gbxDatos.Controls.Add(Me.lblSexo)
        Me.gbxDatos.Controls.Add(Me.lblPermiso)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Location = New System.Drawing.Point(358, 60)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(434, 393)
        Me.gbxDatos.TabIndex = 102
        Me.gbxDatos.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(16, 189)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(61, 24)
        Me.lblLogin.TabIndex = 117
        Me.lblLogin.Text = "Login"
        '
        'tbxLogin
        '
        Me.tbxLogin.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLogin.Location = New System.Drawing.Point(128, 186)
        Me.tbxLogin.MaxLength = 20
        Me.tbxLogin.Name = "tbxLogin"
        Me.tbxLogin.Size = New System.Drawing.Size(203, 32)
        Me.tbxLogin.TabIndex = 116
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(260, 78)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(82, 24)
        Me.lblApellido.TabIndex = 115
        Me.lblApellido.Text = "Apellido"
        '
        'tbxApellido
        '
        Me.tbxApellido.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApellido.Location = New System.Drawing.Point(208, 105)
        Me.tbxApellido.MaxLength = 20
        Me.tbxApellido.Name = "tbxApellido"
        Me.tbxApellido.Size = New System.Drawing.Size(187, 32)
        Me.tbxApellido.TabIndex = 114
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 148)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'cbxTelefono
        '
        Me.cbxTelefono.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTelefono.FormattingEnabled = True
        Me.cbxTelefono.Items.AddRange(New Object() {"Administrador", "..."})
        Me.cbxTelefono.Location = New System.Drawing.Point(128, 338)
        Me.cbxTelefono.Name = "cbxTelefono"
        Me.cbxTelefono.Size = New System.Drawing.Size(203, 32)
        Me.cbxTelefono.TabIndex = 111
        '
        'btnrem
        '
        Me.btnrem.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrem.Location = New System.Drawing.Point(386, 332)
        Me.btnrem.Name = "btnrem"
        Me.btnrem.Size = New System.Drawing.Size(39, 42)
        Me.btnrem.TabIndex = 113
        Me.btnrem.Text = "-"
        Me.btnrem.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(343, 332)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(39, 42)
        Me.btnadd.TabIndex = 112
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(16, 346)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(89, 24)
        Me.lblTelefono.TabIndex = 111
        Me.lblTelefono.Text = "Telefono"
        '
        'tbxNombre
        '
        Me.tbxNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNombre.Location = New System.Drawing.Point(208, 43)
        Me.tbxNombre.MaxLength = 20
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(187, 32)
        Me.tbxNombre.TabIndex = 107
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(128, 300)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(203, 32)
        Me.dtpNacimiento.TabIndex = 65
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(260, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 24)
        Me.lblNombre.TabIndex = 106
        Me.lblNombre.Text = "Nombre"
        '
        'cbxPuesto
        '
        Me.cbxPuesto.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPuesto.FormattingEnabled = True
        Me.cbxPuesto.Items.AddRange(New Object() {"Administrador", "..."})
        Me.cbxPuesto.Location = New System.Drawing.Point(128, 224)
        Me.cbxPuesto.Name = "cbxPuesto"
        Me.cbxPuesto.Size = New System.Drawing.Size(203, 32)
        Me.cbxPuesto.TabIndex = 64
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(16, 306)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(114, 24)
        Me.lblNacimiento.TabIndex = 60
        Me.lblNacimiento.Text = "Nacimiento"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbxSexo.Location = New System.Drawing.Point(128, 262)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(203, 32)
        Me.cbxSexo.TabIndex = 59
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(16, 265)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 58
        Me.lblSexo.Text = "Sexo"
        '
        'lblPermiso
        '
        Me.lblPermiso.AutoSize = True
        Me.lblPermiso.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermiso.Location = New System.Drawing.Point(16, 229)
        Me.lblPermiso.Name = "lblPermiso"
        Me.lblPermiso.Size = New System.Drawing.Size(76, 24)
        Me.lblPermiso.TabIndex = 57
        Me.lblPermiso.Text = "Puesto"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(12, 9)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(194, 24)
        Me.lblCI.TabIndex = 99
        Me.lblCI.Text = "Cedula de identidad"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(424, 0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 101
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(741, 0)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 118
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(694, 0)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 117
        Me.pbxMini.TabStop = False
        '
        'lbxEnlistar
        '
        Me.lbxEnlistar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEnlistar.FormattingEnabled = True
        Me.lbxEnlistar.ItemHeight = 32
        Me.lbxEnlistar.Location = New System.Drawing.Point(12, 65)
        Me.lbxEnlistar.Name = "lbxEnlistar"
        Me.lbxEnlistar.Size = New System.Drawing.Size(340, 388)
        Me.lbxEnlistar.TabIndex = 119
        '
        'tbxCI
        '
        Me.tbxCI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCI.Location = New System.Drawing.Point(248, 6)
        Me.tbxCI.MaxLength = 8
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(145, 32)
        Me.tbxCI.TabIndex = 100
        Me.tbxCI.Text = "00000000"
        '
        'frmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(839, 537)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lbxEnlistar)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.tbxCI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPersonal"
        Me.Text = "Personal"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblPermiso As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents cbxTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents btnrem As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents tbxApellido As System.Windows.Forms.TextBox
    Friend WithEvents lbxEnlistar As System.Windows.Forms.ListBox
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents tbxLogin As System.Windows.Forms.TextBox
    Friend WithEvents tbxCI As System.Windows.Forms.TextBox
End Class
