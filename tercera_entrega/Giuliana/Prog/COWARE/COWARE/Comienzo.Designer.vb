<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComienzo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComienzo))
        Me.cbxTambo = New System.Windows.Forms.ComboBox()
        Me.btnEliminar_Animal = New System.Windows.Forms.Button()
        Me.btnIngresar_Animal = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pbxClose = New System.Windows.Forms.PictureBox()
        Me.pbxMini = New System.Windows.Forms.PictureBox()
        Me.btnEnlistar = New System.Windows.Forms.Button()
        Me.cbxEnlistar = New System.Windows.Forms.ComboBox()
        Me.btnLote_animal = New System.Windows.Forms.Button()
        Me.btnControl_animal = New System.Windows.Forms.Button()
        Me.btnConfiguracion_ordenie = New System.Windows.Forms.Button()
        Me.pbxVenta = New System.Windows.Forms.PictureBox()
        Me.gbxPersonal = New System.Windows.Forms.GroupBox()
        Me.btnIngresar_Personal = New System.Windows.Forms.Button()
        Me.btnEliminar_Personal = New System.Windows.Forms.Button()
        Me.btnConsultar_Personal = New System.Windows.Forms.Button()
        Me.btnModificar_Personal = New System.Windows.Forms.Button()
        Me.gbxOrdenie = New System.Windows.Forms.GroupBox()
        Me.btnConsultar_Ordenie = New System.Windows.Forms.Button()
        Me.gbxAlimento = New System.Windows.Forms.GroupBox()
        Me.btnOtrogar_Alimento = New System.Windows.Forms.Button()
        Me.btnAlmacenar_Alimento = New System.Windows.Forms.Button()
        Me.btnIngresar_Alimento = New System.Windows.Forms.Button()
        Me.gbxTambo = New System.Windows.Forms.GroupBox()
        Me.btnIngresar_Tambo = New System.Windows.Forms.Button()
        Me.btnEliminar_Tambo = New System.Windows.Forms.Button()
        Me.btnConsultar_Tambo = New System.Windows.Forms.Button()
        Me.btnModificar_Tambo = New System.Windows.Forms.Button()
        Me.gbxAnimal = New System.Windows.Forms.GroupBox()
        Me.btnConsultar_Animal = New System.Windows.Forms.Button()
        Me.btnModificar_Animal = New System.Windows.Forms.Button()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxClima = New System.Windows.Forms.PictureBox()
        Me.pbxPersonal = New System.Windows.Forms.PictureBox()
        Me.pbxAlimento = New System.Windows.Forms.PictureBox()
        Me.pbxOrdenie = New System.Windows.Forms.PictureBox()
        Me.pbxTambo = New System.Windows.Forms.PictureBox()
        Me.pbxAnimal = New System.Windows.Forms.PictureBox()
        Me.pnlMain.SuspendLayout()
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPersonal.SuspendLayout()
        Me.gbxOrdenie.SuspendLayout()
        Me.gbxAlimento.SuspendLayout()
        Me.gbxTambo.SuspendLayout()
        Me.gbxAnimal.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxClima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAlimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOrdenie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTambo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxTambo
        '
        Me.cbxTambo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTambo.FormattingEnabled = True
        Me.cbxTambo.Location = New System.Drawing.Point(19, 16)
        Me.cbxTambo.Name = "cbxTambo"
        Me.cbxTambo.Size = New System.Drawing.Size(175, 32)
        Me.cbxTambo.TabIndex = 110
        Me.cbxTambo.Text = "Tambo"
        '
        'btnEliminar_Animal
        '
        Me.btnEliminar_Animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar_Animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar_Animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar_Animal.Location = New System.Drawing.Point(6, 47)
        Me.btnEliminar_Animal.Name = "btnEliminar_Animal"
        Me.btnEliminar_Animal.Size = New System.Drawing.Size(43, 29)
        Me.btnEliminar_Animal.TabIndex = 8
        Me.btnEliminar_Animal.Text = "-"
        Me.btnEliminar_Animal.UseVisualStyleBackColor = True
        '
        'btnIngresar_Animal
        '
        Me.btnIngresar_Animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar_Animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar_Animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar_Animal.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar_Animal.Location = New System.Drawing.Point(7, 12)
        Me.btnIngresar_Animal.Name = "btnIngresar_Animal"
        Me.btnIngresar_Animal.Size = New System.Drawing.Size(42, 29)
        Me.btnIngresar_Animal.TabIndex = 7
        Me.btnIngresar_Animal.Text = "+"
        Me.btnIngresar_Animal.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlMain.Controls.Add(Me.pbxClose)
        Me.pnlMain.Controls.Add(Me.pbxMini)
        Me.pnlMain.Controls.Add(Me.btnEnlistar)
        Me.pnlMain.Controls.Add(Me.cbxEnlistar)
        Me.pnlMain.Controls.Add(Me.btnLote_animal)
        Me.pnlMain.Controls.Add(Me.btnControl_animal)
        Me.pnlMain.Controls.Add(Me.btnConfiguracion_ordenie)
        Me.pnlMain.Controls.Add(Me.pbxVenta)
        Me.pnlMain.Controls.Add(Me.gbxPersonal)
        Me.pnlMain.Controls.Add(Me.gbxOrdenie)
        Me.pnlMain.Controls.Add(Me.gbxAlimento)
        Me.pnlMain.Controls.Add(Me.gbxTambo)
        Me.pnlMain.Controls.Add(Me.gbxAnimal)
        Me.pnlMain.Controls.Add(Me.cbxTambo)
        Me.pnlMain.Controls.Add(Me.pbxSalir)
        Me.pnlMain.Controls.Add(Me.pbxClima)
        Me.pnlMain.Controls.Add(Me.pbxPersonal)
        Me.pnlMain.Controls.Add(Me.pbxAlimento)
        Me.pnlMain.Controls.Add(Me.pbxOrdenie)
        Me.pnlMain.Controls.Add(Me.pbxTambo)
        Me.pnlMain.Controls.Add(Me.pbxAnimal)
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(831, 571)
        Me.pnlMain.TabIndex = 111
        '
        'pbxClose
        '
        Me.pbxClose.Image = CType(resources.GetObject("pbxClose.Image"), System.Drawing.Image)
        Me.pbxClose.Location = New System.Drawing.Point(768, 16)
        Me.pbxClose.Name = "pbxClose"
        Me.pbxClose.Size = New System.Drawing.Size(51, 50)
        Me.pbxClose.TabIndex = 121
        Me.pbxClose.TabStop = False
        '
        'pbxMini
        '
        Me.pbxMini.Image = CType(resources.GetObject("pbxMini.Image"), System.Drawing.Image)
        Me.pbxMini.Location = New System.Drawing.Point(721, 16)
        Me.pbxMini.Name = "pbxMini"
        Me.pbxMini.Size = New System.Drawing.Size(51, 50)
        Me.pbxMini.TabIndex = 120
        Me.pbxMini.TabStop = False
        '
        'btnEnlistar
        '
        Me.btnEnlistar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnlistar.Enabled = False
        Me.btnEnlistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnlistar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnlistar.ForeColor = System.Drawing.Color.Black
        Me.btnEnlistar.Location = New System.Drawing.Point(454, 506)
        Me.btnEnlistar.Name = "btnEnlistar"
        Me.btnEnlistar.Size = New System.Drawing.Size(122, 32)
        Me.btnEnlistar.TabIndex = 119
        Me.btnEnlistar.Text = "Enlistar"
        Me.btnEnlistar.UseVisualStyleBackColor = True
        '
        'cbxEnlistar
        '
        Me.cbxEnlistar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEnlistar.FormattingEnabled = True
        Me.cbxEnlistar.Location = New System.Drawing.Point(156, 506)
        Me.cbxEnlistar.Name = "cbxEnlistar"
        Me.cbxEnlistar.Size = New System.Drawing.Size(268, 32)
        Me.cbxEnlistar.TabIndex = 118
        '
        'btnLote_animal
        '
        Me.btnLote_animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLote_animal.Enabled = False
        Me.btnLote_animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLote_animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLote_animal.ForeColor = System.Drawing.Color.Black
        Me.btnLote_animal.Location = New System.Drawing.Point(166, 416)
        Me.btnLote_animal.Name = "btnLote_animal"
        Me.btnLote_animal.Size = New System.Drawing.Size(100, 45)
        Me.btnLote_animal.TabIndex = 117
        Me.btnLote_animal.Text = "Lote"
        Me.btnLote_animal.UseVisualStyleBackColor = True
        '
        'btnControl_animal
        '
        Me.btnControl_animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControl_animal.Enabled = False
        Me.btnControl_animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnControl_animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl_animal.ForeColor = System.Drawing.Color.Black
        Me.btnControl_animal.Location = New System.Drawing.Point(74, 416)
        Me.btnControl_animal.Name = "btnControl_animal"
        Me.btnControl_animal.Size = New System.Drawing.Size(100, 45)
        Me.btnControl_animal.TabIndex = 116
        Me.btnControl_animal.Text = "Control"
        Me.btnControl_animal.UseVisualStyleBackColor = True
        '
        'btnConfiguracion_ordenie
        '
        Me.btnConfiguracion_ordenie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion_ordenie.Enabled = False
        Me.btnConfiguracion_ordenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfiguracion_ordenie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion_ordenie.ForeColor = System.Drawing.Color.Black
        Me.btnConfiguracion_ordenie.Location = New System.Drawing.Point(74, 214)
        Me.btnConfiguracion_ordenie.Name = "btnConfiguracion_ordenie"
        Me.btnConfiguracion_ordenie.Size = New System.Drawing.Size(192, 45)
        Me.btnConfiguracion_ordenie.TabIndex = 11
        Me.btnConfiguracion_ordenie.Text = "Configuracion"
        Me.btnConfiguracion_ordenie.UseVisualStyleBackColor = True
        '
        'pbxVenta
        '
        Me.pbxVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxVenta.Image = CType(resources.GetObject("pbxVenta.Image"), System.Drawing.Image)
        Me.pbxVenta.Location = New System.Drawing.Point(677, 96)
        Me.pbxVenta.Name = "pbxVenta"
        Me.pbxVenta.Size = New System.Drawing.Size(131, 127)
        Me.pbxVenta.TabIndex = 115
        Me.pbxVenta.TabStop = False
        '
        'gbxPersonal
        '
        Me.gbxPersonal.Controls.Add(Me.btnIngresar_Personal)
        Me.gbxPersonal.Controls.Add(Me.btnEliminar_Personal)
        Me.gbxPersonal.Controls.Add(Me.btnConsultar_Personal)
        Me.gbxPersonal.Controls.Add(Me.btnModificar_Personal)
        Me.gbxPersonal.Location = New System.Drawing.Point(467, 268)
        Me.gbxPersonal.Name = "gbxPersonal"
        Me.gbxPersonal.Size = New System.Drawing.Size(55, 152)
        Me.gbxPersonal.TabIndex = 114
        Me.gbxPersonal.TabStop = False
        '
        'btnIngresar_Personal
        '
        Me.btnIngresar_Personal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar_Personal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar_Personal.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar_Personal.Location = New System.Drawing.Point(7, 12)
        Me.btnIngresar_Personal.Name = "btnIngresar_Personal"
        Me.btnIngresar_Personal.Size = New System.Drawing.Size(42, 29)
        Me.btnIngresar_Personal.TabIndex = 7
        Me.btnIngresar_Personal.Text = "+"
        Me.btnIngresar_Personal.UseVisualStyleBackColor = True
        '
        'btnEliminar_Personal
        '
        Me.btnEliminar_Personal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar_Personal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar_Personal.Location = New System.Drawing.Point(6, 47)
        Me.btnEliminar_Personal.Name = "btnEliminar_Personal"
        Me.btnEliminar_Personal.Size = New System.Drawing.Size(43, 29)
        Me.btnEliminar_Personal.TabIndex = 8
        Me.btnEliminar_Personal.Text = "-"
        Me.btnEliminar_Personal.UseVisualStyleBackColor = True
        '
        'btnConsultar_Personal
        '
        Me.btnConsultar_Personal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultar_Personal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar_Personal.Location = New System.Drawing.Point(7, 82)
        Me.btnConsultar_Personal.Name = "btnConsultar_Personal"
        Me.btnConsultar_Personal.Size = New System.Drawing.Size(42, 29)
        Me.btnConsultar_Personal.TabIndex = 9
        Me.btnConsultar_Personal.Text = "?"
        Me.btnConsultar_Personal.UseVisualStyleBackColor = True
        '
        'btnModificar_Personal
        '
        Me.btnModificar_Personal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Personal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Personal.Location = New System.Drawing.Point(6, 117)
        Me.btnModificar_Personal.Name = "btnModificar_Personal"
        Me.btnModificar_Personal.Size = New System.Drawing.Size(43, 29)
        Me.btnModificar_Personal.TabIndex = 10
        Me.btnModificar_Personal.Text = "+/-"
        Me.btnModificar_Personal.UseVisualStyleBackColor = True
        '
        'gbxOrdenie
        '
        Me.gbxOrdenie.Controls.Add(Me.btnConsultar_Ordenie)
        Me.gbxOrdenie.Location = New System.Drawing.Point(211, 165)
        Me.gbxOrdenie.Name = "gbxOrdenie"
        Me.gbxOrdenie.Size = New System.Drawing.Size(55, 49)
        Me.gbxOrdenie.TabIndex = 112
        Me.gbxOrdenie.TabStop = False
        '
        'btnConsultar_Ordenie
        '
        Me.btnConsultar_Ordenie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar_Ordenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultar_Ordenie.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar_Ordenie.Location = New System.Drawing.Point(7, 12)
        Me.btnConsultar_Ordenie.Name = "btnConsultar_Ordenie"
        Me.btnConsultar_Ordenie.Size = New System.Drawing.Size(42, 29)
        Me.btnConsultar_Ordenie.TabIndex = 9
        Me.btnConsultar_Ordenie.Text = "?"
        Me.btnConsultar_Ordenie.UseVisualStyleBackColor = True
        '
        'gbxAlimento
        '
        Me.gbxAlimento.Controls.Add(Me.btnOtrogar_Alimento)
        Me.gbxAlimento.Controls.Add(Me.btnAlmacenar_Alimento)
        Me.gbxAlimento.Controls.Add(Me.btnIngresar_Alimento)
        Me.gbxAlimento.Location = New System.Drawing.Point(467, 98)
        Me.gbxAlimento.Name = "gbxAlimento"
        Me.gbxAlimento.Size = New System.Drawing.Size(55, 116)
        Me.gbxAlimento.TabIndex = 113
        Me.gbxAlimento.TabStop = False
        '
        'btnOtrogar_Alimento
        '
        Me.btnOtrogar_Alimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOtrogar_Alimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOtrogar_Alimento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtrogar_Alimento.ForeColor = System.Drawing.Color.Black
        Me.btnOtrogar_Alimento.Location = New System.Drawing.Point(7, 11)
        Me.btnOtrogar_Alimento.Name = "btnOtrogar_Alimento"
        Me.btnOtrogar_Alimento.Size = New System.Drawing.Size(42, 29)
        Me.btnOtrogar_Alimento.TabIndex = 7
        Me.btnOtrogar_Alimento.Text = "++"
        Me.btnOtrogar_Alimento.UseVisualStyleBackColor = True
        '
        'btnAlmacenar_Alimento
        '
        Me.btnAlmacenar_Alimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlmacenar_Alimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAlmacenar_Alimento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacenar_Alimento.Location = New System.Drawing.Point(6, 46)
        Me.btnAlmacenar_Alimento.Name = "btnAlmacenar_Alimento"
        Me.btnAlmacenar_Alimento.Size = New System.Drawing.Size(43, 29)
        Me.btnAlmacenar_Alimento.TabIndex = 8
        Me.btnAlmacenar_Alimento.Text = "l_l"
        Me.btnAlmacenar_Alimento.UseVisualStyleBackColor = True
        '
        'btnIngresar_Alimento
        '
        Me.btnIngresar_Alimento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar_Alimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar_Alimento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar_Alimento.Location = New System.Drawing.Point(7, 81)
        Me.btnIngresar_Alimento.Name = "btnIngresar_Alimento"
        Me.btnIngresar_Alimento.Size = New System.Drawing.Size(42, 29)
        Me.btnIngresar_Alimento.TabIndex = 9
        Me.btnIngresar_Alimento.Text = "+"
        Me.btnIngresar_Alimento.UseVisualStyleBackColor = True
        '
        'gbxTambo
        '
        Me.gbxTambo.Controls.Add(Me.btnIngresar_Tambo)
        Me.gbxTambo.Controls.Add(Me.btnEliminar_Tambo)
        Me.gbxTambo.Controls.Add(Me.btnConsultar_Tambo)
        Me.gbxTambo.Controls.Add(Me.btnModificar_Tambo)
        Me.gbxTambo.Location = New System.Drawing.Point(715, 262)
        Me.gbxTambo.Name = "gbxTambo"
        Me.gbxTambo.Size = New System.Drawing.Size(55, 152)
        Me.gbxTambo.TabIndex = 112
        Me.gbxTambo.TabStop = False
        '
        'btnIngresar_Tambo
        '
        Me.btnIngresar_Tambo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar_Tambo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar_Tambo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar_Tambo.ForeColor = System.Drawing.Color.Black
        Me.btnIngresar_Tambo.Location = New System.Drawing.Point(7, 12)
        Me.btnIngresar_Tambo.Name = "btnIngresar_Tambo"
        Me.btnIngresar_Tambo.Size = New System.Drawing.Size(42, 29)
        Me.btnIngresar_Tambo.TabIndex = 7
        Me.btnIngresar_Tambo.Text = "+"
        Me.btnIngresar_Tambo.UseVisualStyleBackColor = True
        '
        'btnEliminar_Tambo
        '
        Me.btnEliminar_Tambo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar_Tambo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar_Tambo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar_Tambo.Location = New System.Drawing.Point(6, 47)
        Me.btnEliminar_Tambo.Name = "btnEliminar_Tambo"
        Me.btnEliminar_Tambo.Size = New System.Drawing.Size(43, 29)
        Me.btnEliminar_Tambo.TabIndex = 8
        Me.btnEliminar_Tambo.Text = "-"
        Me.btnEliminar_Tambo.UseVisualStyleBackColor = True
        '
        'btnConsultar_Tambo
        '
        Me.btnConsultar_Tambo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar_Tambo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultar_Tambo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar_Tambo.Location = New System.Drawing.Point(7, 82)
        Me.btnConsultar_Tambo.Name = "btnConsultar_Tambo"
        Me.btnConsultar_Tambo.Size = New System.Drawing.Size(42, 29)
        Me.btnConsultar_Tambo.TabIndex = 9
        Me.btnConsultar_Tambo.Text = "?"
        Me.btnConsultar_Tambo.UseVisualStyleBackColor = True
        '
        'btnModificar_Tambo
        '
        Me.btnModificar_Tambo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_Tambo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Tambo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Tambo.Location = New System.Drawing.Point(6, 117)
        Me.btnModificar_Tambo.Name = "btnModificar_Tambo"
        Me.btnModificar_Tambo.Size = New System.Drawing.Size(43, 29)
        Me.btnModificar_Tambo.TabIndex = 10
        Me.btnModificar_Tambo.Text = "+/-"
        Me.btnModificar_Tambo.UseVisualStyleBackColor = True
        '
        'gbxAnimal
        '
        Me.gbxAnimal.Controls.Add(Me.btnIngresar_Animal)
        Me.gbxAnimal.Controls.Add(Me.btnEliminar_Animal)
        Me.gbxAnimal.Controls.Add(Me.btnConsultar_Animal)
        Me.gbxAnimal.Controls.Add(Me.btnModificar_Animal)
        Me.gbxAnimal.Location = New System.Drawing.Point(211, 264)
        Me.gbxAnimal.Name = "gbxAnimal"
        Me.gbxAnimal.Size = New System.Drawing.Size(55, 152)
        Me.gbxAnimal.TabIndex = 111
        Me.gbxAnimal.TabStop = False
        '
        'btnConsultar_Animal
        '
        Me.btnConsultar_Animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar_Animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultar_Animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar_Animal.Location = New System.Drawing.Point(7, 82)
        Me.btnConsultar_Animal.Name = "btnConsultar_Animal"
        Me.btnConsultar_Animal.Size = New System.Drawing.Size(42, 29)
        Me.btnConsultar_Animal.TabIndex = 9
        Me.btnConsultar_Animal.Text = "?"
        Me.btnConsultar_Animal.UseVisualStyleBackColor = True
        '
        'btnModificar_Animal
        '
        Me.btnModificar_Animal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_Animal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificar_Animal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_Animal.Location = New System.Drawing.Point(6, 117)
        Me.btnModificar_Animal.Name = "btnModificar_Animal"
        Me.btnModificar_Animal.Size = New System.Drawing.Size(43, 29)
        Me.btnModificar_Animal.TabIndex = 10
        Me.btnModificar_Animal.Text = "+/-"
        Me.btnModificar_Animal.UseVisualStyleBackColor = True
        '
        'pbxSalir
        '
        Me.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxSalir.Image = CType(resources.GetObject("pbxSalir.Image"), System.Drawing.Image)
        Me.pbxSalir.Location = New System.Drawing.Point(666, 438)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(131, 121)
        Me.pbxSalir.TabIndex = 6
        Me.pbxSalir.TabStop = False
        '
        'pbxClima
        '
        Me.pbxClima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxClima.Image = CType(resources.GetObject("pbxClima.Image"), System.Drawing.Image)
        Me.pbxClima.Location = New System.Drawing.Point(553, 96)
        Me.pbxClima.Name = "pbxClima"
        Me.pbxClima.Size = New System.Drawing.Size(131, 127)
        Me.pbxClima.TabIndex = 5
        Me.pbxClima.TabStop = False
        '
        'pbxPersonal
        '
        Me.pbxPersonal.Image = CType(resources.GetObject("pbxPersonal.Image"), System.Drawing.Image)
        Me.pbxPersonal.Location = New System.Drawing.Point(330, 285)
        Me.pbxPersonal.Name = "pbxPersonal"
        Me.pbxPersonal.Size = New System.Drawing.Size(131, 129)
        Me.pbxPersonal.TabIndex = 4
        Me.pbxPersonal.TabStop = False
        '
        'pbxAlimento
        '
        Me.pbxAlimento.Image = CType(resources.GetObject("pbxAlimento.Image"), System.Drawing.Image)
        Me.pbxAlimento.Location = New System.Drawing.Point(330, 96)
        Me.pbxAlimento.Name = "pbxAlimento"
        Me.pbxAlimento.Size = New System.Drawing.Size(131, 135)
        Me.pbxAlimento.TabIndex = 3
        Me.pbxAlimento.TabStop = False
        '
        'pbxOrdenie
        '
        Me.pbxOrdenie.Image = CType(resources.GetObject("pbxOrdenie.Image"), System.Drawing.Image)
        Me.pbxOrdenie.Location = New System.Drawing.Point(74, 85)
        Me.pbxOrdenie.Name = "pbxOrdenie"
        Me.pbxOrdenie.Size = New System.Drawing.Size(131, 129)
        Me.pbxOrdenie.TabIndex = 2
        Me.pbxOrdenie.TabStop = False
        '
        'pbxTambo
        '
        Me.pbxTambo.Image = CType(resources.GetObject("pbxTambo.Image"), System.Drawing.Image)
        Me.pbxTambo.Location = New System.Drawing.Point(578, 279)
        Me.pbxTambo.Name = "pbxTambo"
        Me.pbxTambo.Size = New System.Drawing.Size(131, 135)
        Me.pbxTambo.TabIndex = 1
        Me.pbxTambo.TabStop = False
        '
        'pbxAnimal
        '
        Me.pbxAnimal.Image = CType(resources.GetObject("pbxAnimal.Image"), System.Drawing.Image)
        Me.pbxAnimal.Location = New System.Drawing.Point(74, 281)
        Me.pbxAnimal.Name = "pbxAnimal"
        Me.pbxAnimal.Size = New System.Drawing.Size(131, 129)
        Me.pbxAnimal.TabIndex = 0
        Me.pbxAnimal.TabStop = False
        '
        'frmComienzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(832, 574)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmComienzo"
        Me.Text = "COWARE"
        Me.pnlMain.ResumeLayout(False)
        CType(Me.pbxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPersonal.ResumeLayout(False)
        Me.gbxOrdenie.ResumeLayout(False)
        Me.gbxAlimento.ResumeLayout(False)
        Me.gbxTambo.ResumeLayout(False)
        Me.gbxAnimal.ResumeLayout(False)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxClima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAlimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOrdenie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTambo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxTambo As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar_Animal As System.Windows.Forms.Button
    Friend WithEvents btnIngresar_Animal As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents btnModificar_Animal As System.Windows.Forms.Button
    Friend WithEvents btnConsultar_Animal As System.Windows.Forms.Button
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxClima As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPersonal As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAlimento As System.Windows.Forms.PictureBox
    Friend WithEvents pbxOrdenie As System.Windows.Forms.PictureBox
    Friend WithEvents pbxTambo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAnimal As System.Windows.Forms.PictureBox
    Friend WithEvents pbxVenta As System.Windows.Forms.PictureBox
    Friend WithEvents gbxPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar_Personal As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Personal As System.Windows.Forms.Button
    Friend WithEvents btnConsultar_Personal As System.Windows.Forms.Button
    Friend WithEvents btnModificar_Personal As System.Windows.Forms.Button
    Friend WithEvents gbxOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar_Ordenie As System.Windows.Forms.Button
    Friend WithEvents gbxAlimento As System.Windows.Forms.GroupBox
    Friend WithEvents btnOtrogar_Alimento As System.Windows.Forms.Button
    Friend WithEvents btnAlmacenar_Alimento As System.Windows.Forms.Button
    Friend WithEvents btnIngresar_Alimento As System.Windows.Forms.Button
    Friend WithEvents gbxTambo As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar_Tambo As System.Windows.Forms.Button
    Friend WithEvents btnEliminar_Tambo As System.Windows.Forms.Button
    Friend WithEvents btnConsultar_Tambo As System.Windows.Forms.Button
    Friend WithEvents btnModificar_Tambo As System.Windows.Forms.Button
    Friend WithEvents gbxAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents btnControl_animal As System.Windows.Forms.Button
    Friend WithEvents btnConfiguracion_ordenie As System.Windows.Forms.Button
    Friend WithEvents btnLote_animal As System.Windows.Forms.Button
    Friend WithEvents btnEnlistar As System.Windows.Forms.Button
    Friend WithEvents cbxEnlistar As System.Windows.Forms.ComboBox
    Friend WithEvents pbxClose As System.Windows.Forms.PictureBox
    Friend WithEvents pbxMini As System.Windows.Forms.PictureBox

End Class
