<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLote))
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.tbxNumLotec = New System.Windows.Forms.TextBox()
        Me.lblNumLotec = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tbxNumA = New System.Windows.Forms.TextBox()
        Me.lblAnimalnuma = New System.Windows.Forms.Label()
        Me.lbxAgregar = New System.Windows.Forms.ListBox()
        Me.lbxConsultar = New System.Windows.Forms.ListBox()
        Me.tbxNumLote = New System.Windows.Forms.TextBox()
        Me.lblNumLotef = New System.Windows.Forms.Label()
        Me.tbxNumAnimC = New System.Windows.Forms.TextBox()
        Me.lblAnimalnumC = New System.Windows.Forms.Label()
        Me.gbxC = New System.Windows.Forms.GroupBox()
        Me.rbnNumAnimalC = New System.Windows.Forms.RadioButton()
        Me.rbnNumLoteC = New System.Windows.Forms.RadioButton()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.gbxC.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(439, 109)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(118, 42)
        Me.btnConsultar.TabIndex = 131
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'tbxNumLotec
        '
        Me.tbxNumLotec.Enabled = False
        Me.tbxNumLotec.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumLotec.Location = New System.Drawing.Point(199, 15)
        Me.tbxNumLotec.MaxLength = 9
        Me.tbxNumLotec.Name = "tbxNumLotec"
        Me.tbxNumLotec.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumLotec.TabIndex = 129
        Me.tbxNumLotec.Text = "000000000"
        '
        'lblNumLotec
        '
        Me.lblNumLotec.AutoSize = True
        Me.lblNumLotec.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLotec.Location = New System.Drawing.Point(27, 18)
        Me.lblNumLotec.Name = "lblNumLotec"
        Me.lblNumLotec.Size = New System.Drawing.Size(151, 24)
        Me.lblNumLotec.TabIndex = 128
        Me.lblNumLotec.Text = "Numero de lote"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(121, 109)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 134
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tbxNumA
        '
        Me.tbxNumA.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumA.Location = New System.Drawing.Point(198, 47)
        Me.tbxNumA.MaxLength = 9
        Me.tbxNumA.Name = "tbxNumA"
        Me.tbxNumA.Size = New System.Drawing.Size(125, 32)
        Me.tbxNumA.TabIndex = 133
        Me.tbxNumA.Text = "000000000"
        '
        'lblAnimalnuma
        '
        Me.lblAnimalnuma.AutoSize = True
        Me.lblAnimalnuma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalnuma.Location = New System.Drawing.Point(12, 50)
        Me.lblAnimalnuma.Name = "lblAnimalnuma"
        Me.lblAnimalnuma.Size = New System.Drawing.Size(155, 24)
        Me.lblAnimalnuma.TabIndex = 132
        Me.lblAnimalnuma.Text = "Animal, Numero"
        '
        'lbxAgregar
        '
        Me.lbxAgregar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxAgregar.FormattingEnabled = True
        Me.lbxAgregar.ItemHeight = 32
        Me.lbxAgregar.Location = New System.Drawing.Point(4, 160)
        Me.lbxAgregar.Name = "lbxAgregar"
        Me.lbxAgregar.Size = New System.Drawing.Size(319, 260)
        Me.lbxAgregar.TabIndex = 135
        '
        'lbxConsultar
        '
        Me.lbxConsultar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxConsultar.FormattingEnabled = True
        Me.lbxConsultar.ItemHeight = 32
        Me.lbxConsultar.Location = New System.Drawing.Point(341, 160)
        Me.lbxConsultar.Name = "lbxConsultar"
        Me.lbxConsultar.Size = New System.Drawing.Size(356, 260)
        Me.lbxConsultar.TabIndex = 136
        '
        'tbxNumLote
        '
        Me.tbxNumLote.Enabled = False
        Me.tbxNumLote.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumLote.Location = New System.Drawing.Point(178, 441)
        Me.tbxNumLote.MaxLength = 9
        Me.tbxNumLote.Name = "tbxNumLote"
        Me.tbxNumLote.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumLote.TabIndex = 138
        Me.tbxNumLote.Text = "000000000"
        '
        'lblNumLotef
        '
        Me.lblNumLotef.AutoSize = True
        Me.lblNumLotef.Enabled = False
        Me.lblNumLotef.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLotef.Location = New System.Drawing.Point(0, 444)
        Me.lblNumLotef.Name = "lblNumLotef"
        Me.lblNumLotef.Size = New System.Drawing.Size(151, 24)
        Me.lblNumLotef.TabIndex = 137
        Me.lblNumLotef.Text = "Numero de lote"
        '
        'tbxNumAnimC
        '
        Me.tbxNumAnimC.Enabled = False
        Me.tbxNumAnimC.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumAnimC.Location = New System.Drawing.Point(199, 53)
        Me.tbxNumAnimC.MaxLength = 9
        Me.tbxNumAnimC.Name = "tbxNumAnimC"
        Me.tbxNumAnimC.Size = New System.Drawing.Size(145, 32)
        Me.tbxNumAnimC.TabIndex = 140
        Me.tbxNumAnimC.Text = "000000000"
        '
        'lblAnimalnumC
        '
        Me.lblAnimalnumC.AutoSize = True
        Me.lblAnimalnumC.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalnumC.Location = New System.Drawing.Point(27, 56)
        Me.lblAnimalnumC.Name = "lblAnimalnumC"
        Me.lblAnimalnumC.Size = New System.Drawing.Size(155, 24)
        Me.lblAnimalnumC.TabIndex = 139
        Me.lblAnimalnumC.Text = "Animal, Numero"
        '
        'gbxC
        '
        Me.gbxC.Controls.Add(Me.rbnNumAnimalC)
        Me.gbxC.Controls.Add(Me.rbnNumLoteC)
        Me.gbxC.Controls.Add(Me.tbxNumAnimC)
        Me.gbxC.Controls.Add(Me.lblAnimalnumC)
        Me.gbxC.Controls.Add(Me.tbxNumLotec)
        Me.gbxC.Controls.Add(Me.lblNumLotec)
        Me.gbxC.Location = New System.Drawing.Point(341, 12)
        Me.gbxC.Name = "gbxC"
        Me.gbxC.Size = New System.Drawing.Size(356, 91)
        Me.gbxC.TabIndex = 141
        Me.gbxC.TabStop = False
        '
        'rbnNumAnimalC
        '
        Me.rbnNumAnimalC.AutoSize = True
        Me.rbnNumAnimalC.Location = New System.Drawing.Point(7, 64)
        Me.rbnNumAnimalC.Name = "rbnNumAnimalC"
        Me.rbnNumAnimalC.Size = New System.Drawing.Size(14, 13)
        Me.rbnNumAnimalC.TabIndex = 142
        Me.rbnNumAnimalC.TabStop = True
        Me.rbnNumAnimalC.UseVisualStyleBackColor = True
        '
        'rbnNumLoteC
        '
        Me.rbnNumLoteC.AutoSize = True
        Me.rbnNumLoteC.Location = New System.Drawing.Point(7, 26)
        Me.rbnNumLoteC.Name = "rbnNumLoteC"
        Me.rbnNumLoteC.Size = New System.Drawing.Size(14, 13)
        Me.rbnNumLoteC.TabIndex = 141
        Me.rbnNumLoteC.TabStop = True
        Me.rbnNumLoteC.UseVisualStyleBackColor = True
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(750, 12)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 143
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(703, 12)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 142
        Me.pbxMini.TabStop = False
        '
        'frmLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(812, 517)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.gbxC)
        Me.Controls.Add(Me.tbxNumLote)
        Me.Controls.Add(Me.lblNumLotef)
        Me.Controls.Add(Me.lbxConsultar)
        Me.Controls.Add(Me.lbxAgregar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.tbxNumA)
        Me.Controls.Add(Me.lblAnimalnuma)
        Me.Controls.Add(Me.btnConsultar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLote"
        Me.Text = "Lote"
        Me.gbxC.ResumeLayout(False)
        Me.gbxC.PerformLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents tbxNumLotec As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLotec As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents tbxNumA As System.Windows.Forms.TextBox
    Friend WithEvents lblAnimalnuma As System.Windows.Forms.Label
    Friend WithEvents lbxAgregar As System.Windows.Forms.ListBox
    Friend WithEvents lbxConsultar As System.Windows.Forms.ListBox
    Friend WithEvents tbxNumLote As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLotef As System.Windows.Forms.Label
    Friend WithEvents tbxNumAnimC As System.Windows.Forms.TextBox
    Friend WithEvents lblAnimalnumC As System.Windows.Forms.Label
    Friend WithEvents gbxC As System.Windows.Forms.GroupBox
    Friend WithEvents rbnNumLoteC As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNumAnimalC As System.Windows.Forms.RadioButton
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
End Class
