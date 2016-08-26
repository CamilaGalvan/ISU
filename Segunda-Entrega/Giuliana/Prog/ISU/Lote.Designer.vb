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
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.tbxNumLotec = New System.Windows.Forms.TextBox()
        Me.lblNumLotec = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAnimalnuma = New System.Windows.Forms.Label()
        Me.lbxAgregar = New System.Windows.Forms.ListBox()
        Me.lbxConsultar = New System.Windows.Forms.ListBox()
        Me.tbxNumLote = New System.Windows.Forms.TextBox()
        Me.lblNumLotef = New System.Windows.Forms.Label()
        Me.tbxNumAnimC = New System.Windows.Forms.TextBox()
        Me.lblAnimalnumC = New System.Windows.Forms.Label()
        Me.gbxC = New System.Windows.Forms.GroupBox()
        Me.rbnNumLoteC = New System.Windows.Forms.RadioButton()
        Me.rbnNumAnimalC = New System.Windows.Forms.RadioButton()
        Me.gbxC.SuspendLayout()
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
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(567, 101)
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
        Me.tbxNumLotec.Location = New System.Drawing.Point(243, 13)
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
        Me.lblNumLotec.Location = New System.Drawing.Point(57, 16)
        Me.lblNumLotec.Name = "lblNumLotec"
        Me.lblNumLotec.Size = New System.Drawing.Size(151, 24)
        Me.lblNumLotec.TabIndex = 128
        Me.lblNumLotec.Text = "Numero de lote"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(129, 95)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 42)
        Me.btnAgregar.TabIndex = 134
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(206, 36)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 32)
        Me.TextBox1.TabIndex = 133
        Me.TextBox1.Text = "000000000"
        '
        'lblAnimalnuma
        '
        Me.lblAnimalnuma.AutoSize = True
        Me.lblAnimalnuma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimalnuma.Location = New System.Drawing.Point(20, 39)
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
        Me.lbxAgregar.Location = New System.Drawing.Point(12, 161)
        Me.lbxAgregar.Name = "lbxAgregar"
        Me.lbxAgregar.Size = New System.Drawing.Size(384, 292)
        Me.lbxAgregar.TabIndex = 135
        '
        'lbxConsultar
        '
        Me.lbxConsultar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxConsultar.FormattingEnabled = True
        Me.lbxConsultar.ItemHeight = 32
        Me.lbxConsultar.Location = New System.Drawing.Point(413, 161)
        Me.lbxConsultar.Name = "lbxConsultar"
        Me.lbxConsultar.Size = New System.Drawing.Size(384, 292)
        Me.lbxConsultar.TabIndex = 136
        '
        'tbxNumLote
        '
        Me.tbxNumLote.Enabled = False
        Me.tbxNumLote.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumLote.Location = New System.Drawing.Point(210, 479)
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
        Me.lblNumLotef.Location = New System.Drawing.Point(37, 482)
        Me.lblNumLotef.Name = "lblNumLotef"
        Me.lblNumLotef.Size = New System.Drawing.Size(151, 24)
        Me.lblNumLotef.TabIndex = 137
        Me.lblNumLotef.Text = "Numero de lote"
        '
        'tbxNumAnimC
        '
        Me.tbxNumAnimC.Enabled = False
        Me.tbxNumAnimC.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumAnimC.Location = New System.Drawing.Point(243, 51)
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
        Me.lblAnimalnumC.Location = New System.Drawing.Point(57, 54)
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
        Me.gbxC.Location = New System.Drawing.Point(391, 4)
        Me.gbxC.Name = "gbxC"
        Me.gbxC.Size = New System.Drawing.Size(405, 91)
        Me.gbxC.TabIndex = 141
        Me.gbxC.TabStop = False
        '
        'rbnNumLoteC
        '
        Me.rbnNumLoteC.AutoSize = True
        Me.rbnNumLoteC.Location = New System.Drawing.Point(22, 24)
        Me.rbnNumLoteC.Name = "rbnNumLoteC"
        Me.rbnNumLoteC.Size = New System.Drawing.Size(14, 13)
        Me.rbnNumLoteC.TabIndex = 141
        Me.rbnNumLoteC.TabStop = True
        Me.rbnNumLoteC.UseVisualStyleBackColor = True
        '
        'rbnNumAnimalC
        '
        Me.rbnNumAnimalC.AutoSize = True
        Me.rbnNumAnimalC.Location = New System.Drawing.Point(22, 62)
        Me.rbnNumAnimalC.Name = "rbnNumAnimalC"
        Me.rbnNumAnimalC.Size = New System.Drawing.Size(14, 13)
        Me.rbnNumAnimalC.TabIndex = 142
        Me.rbnNumAnimalC.TabStop = True
        Me.rbnNumAnimalC.UseVisualStyleBackColor = True
        '
        'frmLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.gbxC)
        Me.Controls.Add(Me.tbxNumLote)
        Me.Controls.Add(Me.lblNumLotef)
        Me.Controls.Add(Me.lbxConsultar)
        Me.Controls.Add(Me.lbxAgregar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAnimalnuma)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.pnlBlue)
        Me.Name = "frmLote"
        Me.Text = "Lote"
        Me.gbxC.ResumeLayout(False)
        Me.gbxC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBlue As System.Windows.Forms.Panel
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents tbxNumLotec As System.Windows.Forms.TextBox
    Friend WithEvents lblNumLotec As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
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
End Class
