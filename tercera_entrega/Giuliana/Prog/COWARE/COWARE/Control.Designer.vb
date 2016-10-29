<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.gbxGeneral = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.chbVacuna = New System.Windows.Forms.CheckBox()
        Me.tbxPeso = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cbxVacuna = New System.Windows.Forms.ComboBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.gbxCria = New System.Windows.Forms.GroupBox()
        Me.lblRecria = New System.Windows.Forms.Label()
        Me.btnRecria_Add = New System.Windows.Forms.Button()
        Me.dtprecriavuelta = New System.Windows.Forms.DateTimePicker()
        Me.dtprecriaida = New System.Windows.Forms.DateTimePicker()
        Me.lblRecriavuelta = New System.Windows.Forms.Label()
        Me.lblRecriaIda = New System.Windows.Forms.Label()
        Me.gbxEtapa = New System.Windows.Forms.GroupBox()
        Me.btnEtapa_add = New System.Windows.Forms.Button()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaF = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaI = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.cbxEtapa = New System.Windows.Forms.ComboBox()
        Me.lbxEnlistar = New System.Windows.Forms.ListBox()
        Me.btnRecria = New System.Windows.Forms.Button()
        Me.cbxRecria = New System.Windows.Forms.ComboBox()
        Me.gbxGeneral.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCria.SuspendLayout()
        Me.gbxEtapa.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxGeneral
        '
        Me.gbxGeneral.Controls.Add(Me.btnGuardar)
        Me.gbxGeneral.Controls.Add(Me.lblkg)
        Me.gbxGeneral.Controls.Add(Me.chbVacuna)
        Me.gbxGeneral.Controls.Add(Me.tbxPeso)
        Me.gbxGeneral.Controls.Add(Me.dtpNacimiento)
        Me.gbxGeneral.Controls.Add(Me.lblFecha)
        Me.gbxGeneral.Controls.Add(Me.cbxVacuna)
        Me.gbxGeneral.Controls.Add(Me.lblPeso)
        Me.gbxGeneral.Enabled = False
        Me.gbxGeneral.Location = New System.Drawing.Point(331, 348)
        Me.gbxGeneral.Name = "gbxGeneral"
        Me.gbxGeneral.Size = New System.Drawing.Size(438, 136)
        Me.gbxGeneral.TabIndex = 78
        Me.gbxGeneral.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(303, 88)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(118, 42)
        Me.btnGuardar.TabIndex = 131
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkg.Location = New System.Drawing.Point(324, 59)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(31, 24)
        Me.lblkg.TabIndex = 81
        Me.lblkg.Text = "kg"
        '
        'chbVacuna
        '
        Me.chbVacuna.AutoSize = True
        Me.chbVacuna.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVacuna.Location = New System.Drawing.Point(6, 94)
        Me.chbVacuna.Name = "chbVacuna"
        Me.chbVacuna.Size = New System.Drawing.Size(97, 28)
        Me.chbVacuna.TabIndex = 80
        Me.chbVacuna.Text = "Vacuna"
        Me.chbVacuna.UseVisualStyleBackColor = True
        '
        'tbxPeso
        '
        Me.tbxPeso.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPeso.Location = New System.Drawing.Point(152, 56)
        Me.tbxPeso.MaxLength = 9
        Me.tbxPeso.Name = "tbxPeso"
        Me.tbxPeso.Size = New System.Drawing.Size(145, 32)
        Me.tbxPeso.TabIndex = 79
        Me.tbxPeso.Text = "000000000"
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(152, 18)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(145, 32)
        Me.dtpNacimiento.TabIndex = 66
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(29, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 49
        Me.lblFecha.Text = "Fecha"
        '
        'cbxVacuna
        '
        Me.cbxVacuna.Enabled = False
        Me.cbxVacuna.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxVacuna.FormattingEnabled = True
        Me.cbxVacuna.Location = New System.Drawing.Point(152, 94)
        Me.cbxVacuna.Name = "cbxVacuna"
        Me.cbxVacuna.Size = New System.Drawing.Size(145, 32)
        Me.cbxVacuna.TabIndex = 36
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(28, 59)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(59, 24)
        Me.lblPeso.TabIndex = 4
        Me.lblPeso.Text = "Peso"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(343, 6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 42)
        Me.btnBuscar.TabIndex = 77
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxNum
        '
        Me.tbxNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNum.Location = New System.Drawing.Point(180, 12)
        Me.tbxNum.MaxLength = 9
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(145, 32)
        Me.tbxNum.TabIndex = 76
        Me.tbxNum.Text = "000000000"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(12, 15)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(82, 24)
        Me.lblNumero.TabIndex = 75
        Me.lblNumero.Text = "Numero"
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(692, 0)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 118
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(645, 0)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 117
        Me.pbxMini.TabStop = False
        '
        'gbxCria
        '
        Me.gbxCria.Controls.Add(Me.cbxRecria)
        Me.gbxCria.Controls.Add(Me.btnRecria)
        Me.gbxCria.Controls.Add(Me.lblRecria)
        Me.gbxCria.Controls.Add(Me.btnRecria_Add)
        Me.gbxCria.Controls.Add(Me.dtprecriavuelta)
        Me.gbxCria.Controls.Add(Me.dtprecriaida)
        Me.gbxCria.Controls.Add(Me.lblRecriavuelta)
        Me.gbxCria.Controls.Add(Me.lblRecriaIda)
        Me.gbxCria.Enabled = False
        Me.gbxCria.Location = New System.Drawing.Point(331, 69)
        Me.gbxCria.Name = "gbxCria"
        Me.gbxCria.Size = New System.Drawing.Size(438, 124)
        Me.gbxCria.TabIndex = 120
        Me.gbxCria.TabStop = False
        '
        'lblRecria
        '
        Me.lblRecria.AutoSize = True
        Me.lblRecria.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecria.Location = New System.Drawing.Point(4, 89)
        Me.lblRecria.Name = "lblRecria"
        Me.lblRecria.Size = New System.Drawing.Size(154, 24)
        Me.lblRecria.TabIndex = 114
        Me.lblRecria.Text = "Campo de reria"
        '
        'btnRecria_Add
        '
        Me.btnRecria_Add.Enabled = False
        Me.btnRecria_Add.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecria_Add.Location = New System.Drawing.Point(402, 23)
        Me.btnRecria_Add.Name = "btnRecria_Add"
        Me.btnRecria_Add.Size = New System.Drawing.Size(33, 42)
        Me.btnRecria_Add.TabIndex = 113
        Me.btnRecria_Add.Text = "+"
        Me.btnRecria_Add.UseVisualStyleBackColor = True
        '
        'dtprecriavuelta
        '
        Me.dtprecriavuelta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprecriavuelta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprecriavuelta.Location = New System.Drawing.Point(254, 48)
        Me.dtprecriavuelta.Name = "dtprecriavuelta"
        Me.dtprecriavuelta.Size = New System.Drawing.Size(145, 32)
        Me.dtprecriavuelta.TabIndex = 68
        '
        'dtprecriaida
        '
        Me.dtprecriaida.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprecriaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtprecriaida.Location = New System.Drawing.Point(254, 10)
        Me.dtprecriaida.Name = "dtprecriaida"
        Me.dtprecriaida.Size = New System.Drawing.Size(145, 32)
        Me.dtprecriaida.TabIndex = 67
        '
        'lblRecriavuelta
        '
        Me.lblRecriavuelta.AutoSize = True
        Me.lblRecriavuelta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriavuelta.Location = New System.Drawing.Point(6, 54)
        Me.lblRecriavuelta.Name = "lblRecriavuelta"
        Me.lblRecriavuelta.Size = New System.Drawing.Size(241, 24)
        Me.lblRecriavuelta.TabIndex = 61
        Me.lblRecriavuelta.Text = "Campo de recria (vuelta)"
        '
        'lblRecriaIda
        '
        Me.lblRecriaIda.AutoSize = True
        Me.lblRecriaIda.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecriaIda.Location = New System.Drawing.Point(4, 16)
        Me.lblRecriaIda.Name = "lblRecriaIda"
        Me.lblRecriaIda.Size = New System.Drawing.Size(213, 24)
        Me.lblRecriaIda.TabIndex = 57
        Me.lblRecriaIda.Text = "Campo de recria (ida)"
        '
        'gbxEtapa
        '
        Me.gbxEtapa.Controls.Add(Me.btnEtapa_add)
        Me.gbxEtapa.Controls.Add(Me.dtpFin)
        Me.gbxEtapa.Controls.Add(Me.lblFechaF)
        Me.gbxEtapa.Controls.Add(Me.dtpInicio)
        Me.gbxEtapa.Controls.Add(Me.lblFechaI)
        Me.gbxEtapa.Controls.Add(Me.lblEtapa)
        Me.gbxEtapa.Controls.Add(Me.cbxEtapa)
        Me.gbxEtapa.Enabled = False
        Me.gbxEtapa.Location = New System.Drawing.Point(331, 199)
        Me.gbxEtapa.Name = "gbxEtapa"
        Me.gbxEtapa.Size = New System.Drawing.Size(438, 141)
        Me.gbxEtapa.TabIndex = 119
        Me.gbxEtapa.TabStop = False
        '
        'btnEtapa_add
        '
        Me.btnEtapa_add.Enabled = False
        Me.btnEtapa_add.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEtapa_add.Location = New System.Drawing.Point(308, 52)
        Me.btnEtapa_add.Name = "btnEtapa_add"
        Me.btnEtapa_add.Size = New System.Drawing.Size(118, 42)
        Me.btnEtapa_add.TabIndex = 112
        Me.btnEtapa_add.Text = "Agregar"
        Me.btnEtapa_add.UseVisualStyleBackColor = True
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(146, 98)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(145, 32)
        Me.dtpFin.TabIndex = 68
        '
        'lblFechaF
        '
        Me.lblFechaF.AutoSize = True
        Me.lblFechaF.Enabled = False
        Me.lblFechaF.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaF.Location = New System.Drawing.Point(6, 104)
        Me.lblFechaF.Name = "lblFechaF"
        Me.lblFechaF.Size = New System.Drawing.Size(97, 24)
        Me.lblFechaF.TabIndex = 67
        Me.lblFechaF.Text = "Fecha fin"
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(146, 55)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(145, 32)
        Me.dtpInicio.TabIndex = 66
        '
        'lblFechaI
        '
        Me.lblFechaI.AutoSize = True
        Me.lblFechaI.Enabled = False
        Me.lblFechaI.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaI.Location = New System.Drawing.Point(6, 61)
        Me.lblFechaI.Name = "lblFechaI"
        Me.lblFechaI.Size = New System.Drawing.Size(124, 24)
        Me.lblFechaI.TabIndex = 47
        Me.lblFechaI.Text = "Fecha inicio"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtapa.Location = New System.Drawing.Point(6, 16)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(65, 24)
        Me.lblEtapa.TabIndex = 5
        Me.lblEtapa.Text = "Etapa"
        '
        'cbxEtapa
        '
        Me.cbxEtapa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEtapa.FormattingEnabled = True
        Me.cbxEtapa.Items.AddRange(New Object() {"Ninguno", "Servicio", "Preñada", "Lactancia", "Seca", "Antibiotico"})
        Me.cbxEtapa.Location = New System.Drawing.Point(146, 13)
        Me.cbxEtapa.Name = "cbxEtapa"
        Me.cbxEtapa.Size = New System.Drawing.Size(146, 32)
        Me.cbxEtapa.TabIndex = 34
        '
        'lbxEnlistar
        '
        Me.lbxEnlistar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEnlistar.FormattingEnabled = True
        Me.lbxEnlistar.ItemHeight = 32
        Me.lbxEnlistar.Location = New System.Drawing.Point(0, 69)
        Me.lbxEnlistar.Name = "lbxEnlistar"
        Me.lbxEnlistar.Size = New System.Drawing.Size(325, 420)
        Me.lbxEnlistar.TabIndex = 121
        '
        'btnRecria
        '
        Me.btnRecria.Enabled = False
        Me.btnRecria.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecria.Location = New System.Drawing.Point(402, 80)
        Me.btnRecria.Name = "btnRecria"
        Me.btnRecria.Size = New System.Drawing.Size(33, 42)
        Me.btnRecria.TabIndex = 116
        Me.btnRecria.Text = "+"
        Me.btnRecria.UseVisualStyleBackColor = True
        '
        'cbxRecria
        '
        Me.cbxRecria.Enabled = False
        Me.cbxRecria.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRecria.FormattingEnabled = True
        Me.cbxRecria.Location = New System.Drawing.Point(254, 86)
        Me.cbxRecria.Name = "cbxRecria"
        Me.cbxRecria.Size = New System.Drawing.Size(145, 32)
        Me.cbxRecria.TabIndex = 132
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(839, 537)
        Me.Controls.Add(Me.lbxEnlistar)
        Me.Controls.Add(Me.gbxCria)
        Me.Controls.Add(Me.gbxEtapa)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.gbxGeneral)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.lblNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControl"
        Me.Text = "Control"
        Me.gbxGeneral.ResumeLayout(False)
        Me.gbxGeneral.PerformLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCria.ResumeLayout(False)
        Me.gbxCria.PerformLayout()
        Me.gbxEtapa.ResumeLayout(False)
        Me.gbxEtapa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cbxVacuna As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents chbVacuna As System.Windows.Forms.CheckBox
    Friend WithEvents tbxPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblkg As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
    Friend WithEvents gbxCria As System.Windows.Forms.GroupBox
    Friend WithEvents dtprecriavuelta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtprecriaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRecriavuelta As System.Windows.Forms.Label
    Friend WithEvents lblRecriaIda As System.Windows.Forms.Label
    Friend WithEvents gbxEtapa As System.Windows.Forms.GroupBox
    Friend WithEvents btnEtapa_add As System.Windows.Forms.Button
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaF As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaI As System.Windows.Forms.Label
    Friend WithEvents lblEtapa As System.Windows.Forms.Label
    Friend WithEvents cbxEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents btnRecria_Add As System.Windows.Forms.Button
    Friend WithEvents lbxEnlistar As System.Windows.Forms.ListBox
    Friend WithEvents lblRecria As System.Windows.Forms.Label
    Friend WithEvents cbxRecria As System.Windows.Forms.ComboBox
    Friend WithEvents btnRecria As System.Windows.Forms.Button
End Class
