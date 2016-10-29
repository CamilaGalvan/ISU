<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClima))
        Me.wbClima = New System.Windows.Forms.WebBrowser()
        Me.cbxInUMet = New System.Windows.Forms.CheckBox()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wbClima
        '
        Me.wbClima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbClima.Location = New System.Drawing.Point(0, 0)
        Me.wbClima.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbClima.Name = "wbClima"
        Me.wbClima.Size = New System.Drawing.Size(832, 536)
        Me.wbClima.TabIndex = 0
        '
        'cbxInUMet
        '
        Me.cbxInUMet.AutoSize = True
        Me.cbxInUMet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInUMet.Location = New System.Drawing.Point(12, 25)
        Me.cbxInUMet.Name = "cbxInUMet"
        Me.cbxInUMet.Size = New System.Drawing.Size(68, 20)
        Me.cbxInUMet.TabIndex = 2
        Me.cbxInUMet.Text = "InUMet"
        Me.cbxInUMet.UseVisualStyleBackColor = True
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(752, 12)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 118
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(705, 12)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 117
        Me.pbxMini.TabStop = False
        '
        'frmClima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.cbxInUMet)
        Me.Controls.Add(Me.wbClima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClima"
        Me.Text = "Form1"
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbClima As System.Windows.Forms.WebBrowser
    Friend WithEvents cbxInUMet As System.Windows.Forms.CheckBox
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
End Class
