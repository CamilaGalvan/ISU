<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimal))
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.gbxBasico = New System.Windows.Forms.GroupBox()
        Me.gbxM = New System.Windows.Forms.GroupBox()
        Me.btnBuscarM = New System.Windows.Forms.Button()
        Me.cbxRazaM = New System.Windows.Forms.ComboBox()
        Me.tbxNumM = New System.Windows.Forms.TextBox()
        Me.lblNumM = New System.Windows.Forms.Label()
        Me.lblRazaM = New System.Windows.Forms.Label()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gbxH = New System.Windows.Forms.GroupBox()
        Me.btnBuscarH = New System.Windows.Forms.Button()
        Me.cbxRazaH = New System.Windows.Forms.ComboBox()
        Me.tbxNumH = New System.Windows.Forms.TextBox()
        Me.lblNumH = New System.Windows.Forms.Label()
        Me.lblRazaH = New System.Windows.Forms.Label()
        Me.cbxLugar = New System.Windows.Forms.ComboBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbxRaza = New System.Windows.Forms.ComboBox()
        Me.cbxDivision = New System.Windows.Forms.ComboBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.lbxEnlistar = New System.Windows.Forms.ListBox()
        Me.gbxBasico.SuspendLayout()
        Me.gbxM.SuspendLayout()
        Me.gbxH.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpcion
        '
        Me.btnOpcion.Enabled = False
        Me.btnOpcion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.Location = New System.Drawing.Point(548, 15)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(118, 42)
        Me.btnOpcion.TabIndex = 113
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'gbxBasico
        '
        Me.gbxBasico.Controls.Add(Me.gbxM)
        Me.gbxBasico.Controls.Add(Me.dtpNacimiento)
        Me.gbxBasico.Controls.Add(Me.gbxH)
        Me.gbxBasico.Controls.Add(Me.cbxLugar)
        Me.gbxBasico.Controls.Add(Me.lblNacimiento)
        Me.gbxBasico.Controls.Add(Me.lblDivision)
        Me.gbxBasico.Controls.Add(Me.cbxSexo)
        Me.gbxBasico.Controls.Add(Me.lblSexo)
        Me.gbxBasico.Controls.Add(Me.cbxRaza)
        Me.gbxBasico.Controls.Add(Me.cbxDivision)
        Me.gbxBasico.Controls.Add(Me.lblRaza)
        Me.gbxBasico.Controls.Add(Me.lblLugar)
        Me.gbxBasico.Enabled = False
        Me.gbxBasico.Location = New System.Drawing.Point(410, 63)
        Me.gbxBasico.Name = "gbxBasico"
        Me.gbxBasico.Size = New System.Drawing.Size(388, 420)
        Me.gbxBasico.TabIndex = 110
        Me.gbxBasico.TabStop = False
        '
        'gbxM
        '
        Me.gbxM.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbxM.Controls.Add(Me.btnBuscarM)
        Me.gbxM.Controls.Add(Me.cbxRazaM)
        Me.gbxM.Controls.Add(Me.tbxNumM)
        Me.gbxM.Controls.Add(Me.lblNumM)
        Me.gbxM.Controls.Add(Me.lblRazaM)
        Me.gbxM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxM.Location = New System.Drawing.Point(6, 14)
        Me.gbxM.Name = "gbxM"
        Me.gbxM.Size = New System.Drawing.Size(376, 87)
        Me.gbxM.TabIndex = 111
        Me.gbxM.TabStop = False
        Me.gbxM.Text = "progenitor macho"
        '
        'btnBuscarM
        '
        Me.btnBuscarM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarM.Location = New System.Drawing.Point(250, 23)
        Me.btnBuscarM.Name = "btnBuscarM"
        Me.btnBuscarM.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscarM.TabIndex = 112
        Me.btnBuscarM.Text = "Buscar"
        Me.btnBuscarM.UseVisualStyleBackColor = True
        '
        'cbxRazaM
        '
        Me.cbxRazaM.Enabled = False
        Me.cbxRazaM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRazaM.FormattingEnabled = True
        Me.cbxRazaM.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRazaM.Location = New System.Drawing.Point(99, 50)
        Me.cbxRazaM.Name = "cbxRazaM"
        Me.cbxRazaM.Size = New System.Drawing.Size(145, 32)
        Me.cbxRazaM.TabIndex = 114
        '
        'tbxNumM
        '
        Me.tbxNumM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumM.Location = New System.Drawing.Point(99, 12)
        Me.tbxNumM.MaxLength = 9
        Me.tbxNumM.Name = "tbxNumM"
        Me.tbxNumM.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumM.TabIndex = 112
        Me.tbxNumM.Text = "000000000"
        '
        'lblNumM
        '
        Me.lblNumM.AutoSize = True
        Me.lblNumM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumM.Location = New System.Drawing.Point(6, 15)
        Me.lblNumM.Name = "lblNumM"
        Me.lblNumM.Size = New System.Drawing.Size(82, 24)
        Me.lblNumM.TabIndex = 49
        Me.lblNumM.Text = "Numero"
        '
        'lblRazaM
        '
        Me.lblRazaM.AutoSize = True
        Me.lblRazaM.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaM.Location = New System.Drawing.Point(6, 53)
        Me.lblRazaM.Name = "lblRazaM"
        Me.lblRazaM.Size = New System.Drawing.Size(58, 24)
        Me.lblRazaM.TabIndex = 50
        Me.lblRazaM.Text = "Raza"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(218, 263)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 66
        '
        'gbxH
        '
        Me.gbxH.BackColor = System.Drawing.Color.Bisque
        Me.gbxH.Controls.Add(Me.btnBuscarH)
        Me.gbxH.Controls.Add(Me.cbxRazaH)
        Me.gbxH.Controls.Add(Me.tbxNumH)
        Me.gbxH.Controls.Add(Me.lblNumH)
        Me.gbxH.Controls.Add(Me.lblRazaH)
        Me.gbxH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxH.Location = New System.Drawing.Point(6, 117)
        Me.gbxH.Name = "gbxH"
        Me.gbxH.Size = New System.Drawing.Size(376, 87)
        Me.gbxH.TabIndex = 110
        Me.gbxH.TabStop = False
        Me.gbxH.Text = "progenitor hembra"
        '
        'btnBuscarH
        '
        Me.btnBuscarH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarH.Location = New System.Drawing.Point(250, 28)
        Me.btnBuscarH.Name = "btnBuscarH"
        Me.btnBuscarH.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscarH.TabIndex = 115
        Me.btnBuscarH.Text = "Buscar"
        Me.btnBuscarH.UseVisualStyleBackColor = True
        '
        'cbxRazaH
        '
        Me.cbxRazaH.Enabled = False
        Me.cbxRazaH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRazaH.FormattingEnabled = True
        Me.cbxRazaH.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRazaH.Location = New System.Drawing.Point(99, 51)
        Me.cbxRazaH.Name = "cbxRazaH"
        Me.cbxRazaH.Size = New System.Drawing.Size(145, 32)
        Me.cbxRazaH.TabIndex = 67
        '
        'tbxNumH
        '
        Me.tbxNumH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumH.Location = New System.Drawing.Point(99, 13)
        Me.tbxNumH.MaxLength = 9
        Me.tbxNumH.Name = "tbxNumH"
        Me.tbxNumH.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumH.TabIndex = 113
        Me.tbxNumH.Text = "000000000"
        '
        'lblNumH
        '
        Me.lblNumH.AutoSize = True
        Me.lblNumH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumH.Location = New System.Drawing.Point(6, 16)
        Me.lblNumH.Name = "lblNumH"
        Me.lblNumH.Size = New System.Drawing.Size(82, 24)
        Me.lblNumH.TabIndex = 49
        Me.lblNumH.Text = "Numero"
        '
        'lblRazaH
        '
        Me.lblRazaH.AutoSize = True
        Me.lblRazaH.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaH.Location = New System.Drawing.Point(6, 54)
        Me.lblRazaH.Name = "lblRazaH"
        Me.lblRazaH.Size = New System.Drawing.Size(58, 24)
        Me.lblRazaH.TabIndex = 50
        Me.lblRazaH.Text = "Raza"
        '
        'cbxLugar
        '
        Me.cbxLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLugar.FormattingEnabled = True
        Me.cbxLugar.Location = New System.Drawing.Point(218, 301)
        Me.cbxLugar.Name = "cbxLugar"
        Me.cbxLugar.Size = New System.Drawing.Size(145, 32)
        Me.cbxLugar.TabIndex = 53
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(11, 269)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(114, 24)
        Me.lblNacimiento.TabIndex = 49
        Me.lblNacimiento.Text = "Nacimiento"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(13, 380)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(85, 24)
        Me.lblDivision.TabIndex = 2
        Me.lblDivision.Text = "División"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.cbxSexo.Location = New System.Drawing.Point(218, 225)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(145, 32)
        Me.cbxSexo.TabIndex = 36
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(13, 228)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(58, 24)
        Me.lblSexo.TabIndex = 35
        Me.lblSexo.Text = "Sexo"
        '
        'cbxRaza
        '
        Me.cbxRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRaza.FormattingEnabled = True
        Me.cbxRaza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer show"})
        Me.cbxRaza.Location = New System.Drawing.Point(218, 339)
        Me.cbxRaza.Name = "cbxRaza"
        Me.cbxRaza.Size = New System.Drawing.Size(145, 32)
        Me.cbxRaza.TabIndex = 31
        '
        'cbxDivision
        '
        Me.cbxDivision.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivision.FormattingEnabled = True
        Me.cbxDivision.Location = New System.Drawing.Point(218, 377)
        Me.cbxDivision.Name = "cbxDivision"
        Me.cbxDivision.Size = New System.Drawing.Size(145, 32)
        Me.cbxDivision.TabIndex = 37
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(13, 339)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(58, 24)
        Me.lblRaza.TabIndex = 6
        Me.lblRaza.Text = "Raza"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(11, 304)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(125, 24)
        Me.lblLugar.TabIndex = 4
        Me.lblLugar.Text = "Lugar actual"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(410, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 109
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(220, 21)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 107
        Me.tbxNum.Text = "000000000"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(17, 22)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 106
        Me.lblNumero.Text = "Numero"
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(747, 0)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 116
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(700, 0)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 115
        Me.pbxMini.TabStop = False
        '
        'lbxEnlistar
        '
        Me.lbxEnlistar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEnlistar.FormattingEnabled = True
        Me.lbxEnlistar.ItemHeight = 32
        Me.lbxEnlistar.Location = New System.Drawing.Point(21, 63)
        Me.lbxEnlistar.Name = "lbxEnlistar"
        Me.lbxEnlistar.Size = New System.Drawing.Size(362, 420)
        Me.lbxEnlistar.TabIndex = 122
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(839, 537)
        Me.Controls.Add(Me.lbxEnlistar)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.btnOpcion)
        Me.Controls.Add(Me.gbxBasico)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAnimal"
        Me.Text = "Animal"
        Me.gbxBasico.ResumeLayout(False)
        Me.gbxBasico.PerformLayout()
        Me.gbxM.ResumeLayout(False)
        Me.gbxM.PerformLayout()
        Me.gbxH.ResumeLayout(False)
        Me.gbxH.PerformLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents gbxBasico As System.Windows.Forms.GroupBox
    Friend WithEvents gbxM As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarM As System.Windows.Forms.Button
    Friend WithEvents cbxRazaM As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNumM As System.Windows.Forms.TextBox
    Friend WithEvents lblNumM As System.Windows.Forms.Label
    Friend WithEvents lblRazaM As System.Windows.Forms.Label
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbxH As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarH As System.Windows.Forms.Button
    Friend WithEvents cbxRazaH As System.Windows.Forms.ComboBox
    Friend WithEvents tbxNumH As System.Windows.Forms.TextBox
    Friend WithEvents lblNumH As System.Windows.Forms.Label
    Friend WithEvents lblRazaH As System.Windows.Forms.Label
    Friend WithEvents cbxLugar As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents cbxRaza As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
    Friend WithEvents lbxEnlistar As System.Windows.Forms.ListBox
End Class
