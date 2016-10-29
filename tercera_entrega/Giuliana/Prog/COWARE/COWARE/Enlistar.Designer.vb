<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnlistar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnlistar))
        Me.lbxEnlistar = New System.Windows.Forms.ListBox()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbxEnlistar
        '
        Me.lbxEnlistar.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxEnlistar.FormattingEnabled = True
        Me.lbxEnlistar.ItemHeight = 32
        Me.lbxEnlistar.Location = New System.Drawing.Point(12, 68)
        Me.lbxEnlistar.Name = "lbxEnlistar"
        Me.lbxEnlistar.Size = New System.Drawing.Size(722, 420)
        Me.lbxEnlistar.TabIndex = 70
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(682, 2)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 120
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(635, 2)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 119
        Me.pbxMini.TabStop = False
        '
        'frmEnlistar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(749, 513)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.lbxEnlistar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnlistar"
        Me.Text = "Enlistar"
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxEnlistar As System.Windows.Forms.ListBox
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
End Class
