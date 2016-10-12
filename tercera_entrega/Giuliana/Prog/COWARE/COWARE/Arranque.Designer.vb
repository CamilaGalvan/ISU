<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArranque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArranque))
        Me.pbxLog = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxgspot = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.cbxIdioma = New System.Windows.Forms.ComboBox()
        Me.gbxLog = New System.Windows.Forms.GroupBox()
        CType(Me.pbxLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxgspot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxLog
        '
        Me.pbxLog.Image = CType(resources.GetObject("pbxLog.Image"), System.Drawing.Image)
        Me.pbxLog.Location = New System.Drawing.Point(24, 72)
        Me.pbxLog.Name = "pbxLog"
        Me.pbxLog.Size = New System.Drawing.Size(431, 327)
        Me.pbxLog.TabIndex = 0
        Me.pbxLog.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(343, 72)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 1
        Me.pbxMini.TabStop = False
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(390, 72)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 2
        Me.pbxClose.TabStop = False
        '
        'pbxgspot
        '
        Me.pbxgspot.Image = CType(resources.GetObject("pbxgspot.Image"), System.Drawing.Image)
        Me.pbxgspot.Location = New System.Drawing.Point(366, 331)
        Me.pbxgspot.Name = "pbxgspot"
        Me.pbxgspot.Size = New System.Drawing.Size(51, 50)
        Me.pbxgspot.TabIndex = 3
        Me.pbxgspot.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUser.Location = New System.Drawing.Point(43, 14)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(16, 24)
        Me.lblUser.TabIndex = 57
        Me.lblUser.Text = " "
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.BackColor = System.Drawing.Color.White
        Me.Lblpass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lblpass.Location = New System.Drawing.Point(43, 87)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(16, 24)
        Me.Lblpass.TabIndex = 58
        Me.Lblpass.Text = " "
        '
        'tbxPass
        '
        Me.tbxPass.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPass.Location = New System.Drawing.Point(19, 115)
        Me.tbxPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxPass.MaxLength = 13
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(183, 32)
        Me.tbxPass.TabIndex = 60
        '
        'tbxUser
        '
        Me.tbxUser.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.Location = New System.Drawing.Point(19, 42)
        Me.tbxUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxUser.MaxLength = 13
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(183, 32)
        Me.tbxUser.TabIndex = 59
        '
        'cbxIdioma
        '
        Me.cbxIdioma.AutoCompleteCustomSource.AddRange(New String() {"English", "Português"})
        Me.cbxIdioma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIdioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbxIdioma.FormattingEnabled = True
        Me.cbxIdioma.Items.AddRange(New Object() {"Español", "English", "Português"})
        Me.cbxIdioma.Location = New System.Drawing.Point(142, 141)
        Me.cbxIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxIdioma.Name = "cbxIdioma"
        Me.cbxIdioma.Size = New System.Drawing.Size(183, 32)
        Me.cbxIdioma.TabIndex = 61
        Me.cbxIdioma.Text = "Español"
        '
        'gbxLog
        '
        Me.gbxLog.BackColor = System.Drawing.Color.Transparent
        Me.gbxLog.Controls.Add(Me.tbxPass)
        Me.gbxLog.Controls.Add(Me.lblUser)
        Me.gbxLog.Controls.Add(Me.tbxUser)
        Me.gbxLog.Controls.Add(Me.Lblpass)
        Me.gbxLog.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxLog.Location = New System.Drawing.Point(123, 180)
        Me.gbxLog.Name = "gbxLog"
        Me.gbxLog.Size = New System.Drawing.Size(228, 156)
        Me.gbxLog.TabIndex = 62
        Me.gbxLog.TabStop = False
        '
        'frmArranque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(492, 428)
        Me.Controls.Add(Me.cbxIdioma)
        Me.Controls.Add(Me.pbxgspot)
        Me.Controls.Add(Me.pbxClose)
        Me.Controls.Add(Me.pbxMini)
        Me.Controls.Add(Me.gbxLog)
        Me.Controls.Add(Me.pbxLog)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmArranque"
        Me.Text = "COWARE"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        CType(Me.pbxLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxgspot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxLog.ResumeLayout(False)
        Me.gbxLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxLog As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxgspot As System.Windows.Forms.PictureBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Lblpass As System.Windows.Forms.Label
    Friend WithEvents tbxPass As System.Windows.Forms.TextBox
    Friend WithEvents tbxUser As System.Windows.Forms.TextBox
    Friend WithEvents cbxIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents gbxLog As System.Windows.Forms.GroupBox

End Class
