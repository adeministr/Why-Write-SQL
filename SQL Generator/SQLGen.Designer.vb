﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sequence = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContainerPane = New System.Windows.Forms.Panel()
        Me.ActionGroup = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Create = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CheckGroup = New System.Windows.Forms.GroupBox()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.Check_Type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Check_String = New System.Windows.Forms.TextBox()
        Me.Check_Position = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConstraintGroup = New System.Windows.Forms.GroupBox()
        Me.ForCheck = New System.Windows.Forms.CheckBox()
        Me.Unique = New System.Windows.Forms.CheckBox()
        Me.NotNull = New System.Windows.Forms.CheckBox()
        Me.PrimCheck = New System.Windows.Forms.CheckBox()
        Me.ReferenceGroup = New System.Windows.Forms.GroupBox()
        Me.OnDeleteAction = New System.Windows.Forms.ComboBox()
        Me.OnUpdateAction = New System.Windows.Forms.ComboBox()
        Me.OnDeleteBox = New System.Windows.Forms.CheckBox()
        Me.OnUpdateBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceBox = New System.Windows.Forms.CheckBox()
        Me.ReferenceText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CreateButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NewTableField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PrimaryGroup = New System.Windows.Forms.GroupBox()
        Me.PrimaryKeys = New System.Windows.Forms.TextBox()
        Me.ForeignKeyGroup = New System.Windows.Forms.GroupBox()
        Me.ForeignKeys = New System.Windows.Forms.TextBox()
        Me.FieldGroup = New System.Windows.Forms.GroupBox()
        Me.Precision = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FieldSize = New System.Windows.Forms.NumericUpDown()
        Me.Scale_ = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FieldType = New System.Windows.Forms.ComboBox()
        Me.FieldField = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Add_Foreign_Key_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.CompleteTable_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Add_Field_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Add_Primary_Key_Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PrimaryKeyGroup = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OperationsPanel = New System.Windows.Forms.Panel()
        Me.Act_Create_Table = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Update = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Act_Drop = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContainerPane.SuspendLayout()
        Me.ActionGroup.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CheckGroup.SuspendLayout()
        Me.ConstraintGroup.SuspendLayout()
        Me.ReferenceGroup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PrimaryGroup.SuspendLayout()
        Me.ForeignKeyGroup.SuspendLayout()
        Me.FieldGroup.SuspendLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scale_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PrimaryKeyGroup.SuspendLayout()
        Me.OperationsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 6)
        Me.GroupBox1.Controls.Add(Me.Sequence)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(467, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.GroupBox1, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(694, 771)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command Sequence"
        '
        'Sequence
        '
        Me.Sequence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sequence.FormattingEnabled = True
        Me.Sequence.HorizontalScrollbar = True
        Me.Sequence.ItemHeight = 15
        Me.Sequence.Location = New System.Drawing.Point(3, 16)
        Me.Sequence.Name = "Sequence"
        Me.Sequence.ScrollAlwaysVisible = True
        Me.Sequence.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Sequence.Size = New System.Drawing.Size(688, 752)
        Me.Sequence.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ContainerPane, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OperationsPanel, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 777)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ContainerPane
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.ContainerPane, 4)
        Me.ContainerPane.Controls.Add(Me.ActionGroup)
        Me.ContainerPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContainerPane.Location = New System.Drawing.Point(3, 80)
        Me.ContainerPane.Name = "ContainerPane"
        Me.TableLayoutPanel1.SetRowSpan(Me.ContainerPane, 9)
        Me.ContainerPane.Size = New System.Drawing.Size(458, 694)
        Me.ContainerPane.TabIndex = 0
        '
        'ActionGroup
        '
        Me.ActionGroup.Controls.Add(Me.TableLayoutPanel2)
        Me.ActionGroup.Controls.Add(Me.PrimaryKeyGroup)
        Me.ActionGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionGroup.Location = New System.Drawing.Point(0, 0)
        Me.ActionGroup.Name = "ActionGroup"
        Me.ActionGroup.Size = New System.Drawing.Size(458, 694)
        Me.ActionGroup.TabIndex = 6
        Me.ActionGroup.TabStop = False
        Me.ActionGroup.Text = "Action"
        Me.ActionGroup.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(452, 675)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Create)
        Me.Panel1.Controls.Add(Me.CheckGroup)
        Me.Panel1.Controls.Add(Me.ConstraintGroup)
        Me.Panel1.Controls.Add(Me.ReferenceGroup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 227)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel2.SetRowSpan(Me.Panel1, 6)
        Me.Panel1.Size = New System.Drawing.Size(446, 330)
        Me.Panel1.TabIndex = 9
        '
        'Create
        '
        Me.Create.AutoSize = True
        Me.Create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Create.Depth = 0
        Me.Create.Location = New System.Drawing.Point(17, 288)
        Me.Create.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Create.MouseState = MaterialSkin.MouseState.HOVER
        Me.Create.Name = "Create"
        Me.Create.Primary = False
        Me.Create.Size = New System.Drawing.Size(48, 36)
        Me.Create.TabIndex = 68
        Me.Create.Text = "Done"
        Me.Create.UseVisualStyleBackColor = True
        '
        'CheckGroup
        '
        Me.CheckGroup.Controls.Add(Me.CheckBox)
        Me.CheckGroup.Controls.Add(Me.Check_Type)
        Me.CheckGroup.Controls.Add(Me.Label5)
        Me.CheckGroup.Controls.Add(Me.Check_String)
        Me.CheckGroup.Controls.Add(Me.Check_Position)
        Me.CheckGroup.Controls.Add(Me.Label6)
        Me.CheckGroup.Location = New System.Drawing.Point(4, 118)
        Me.CheckGroup.Name = "CheckGroup"
        Me.CheckGroup.Size = New System.Drawing.Size(442, 167)
        Me.CheckGroup.TabIndex = 2
        Me.CheckGroup.TabStop = False
        Me.CheckGroup.Text = "Check"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(13, 32)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox.TabIndex = 56
        Me.CheckBox.Text = "CheckBox1"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'Check_Type
        '
        Me.Check_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Check_Type.Enabled = False
        Me.Check_Type.FormattingEnabled = True
        Me.Check_Type.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Check_Type.Items.AddRange(New Object() {"None", "Like", "Predefied", "Numeric/Logical Expresion/Other"})
        Me.Check_Type.Location = New System.Drawing.Point(69, 32)
        Me.Check_Type.Name = "Check_Type"
        Me.Check_Type.Size = New System.Drawing.Size(156, 21)
        Me.Check_Type.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(66, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Check Type"
        '
        'Check_String
        '
        Me.Check_String.Enabled = False
        Me.Check_String.Location = New System.Drawing.Point(6, 57)
        Me.Check_String.Multiline = True
        Me.Check_String.Name = "Check_String"
        Me.Check_String.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Check_String.Size = New System.Drawing.Size(427, 98)
        Me.Check_String.TabIndex = 53
        Me.Check_String.WordWrap = False
        '
        'Check_Position
        '
        Me.Check_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Check_Position.Enabled = False
        Me.Check_Position.FormattingEnabled = True
        Me.Check_Position.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Check_Position.Items.AddRange(New Object() {"Before Any", "After Any", "Between Any", "Other/Specific"})
        Me.Check_Position.Location = New System.Drawing.Point(258, 32)
        Me.Check_Position.Name = "Check_Position"
        Me.Check_Position.Size = New System.Drawing.Size(156, 21)
        Me.Check_Position.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(255, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "String Position"
        '
        'ConstraintGroup
        '
        Me.ConstraintGroup.Controls.Add(Me.ForCheck)
        Me.ConstraintGroup.Controls.Add(Me.Unique)
        Me.ConstraintGroup.Controls.Add(Me.NotNull)
        Me.ConstraintGroup.Controls.Add(Me.PrimCheck)
        Me.ConstraintGroup.Location = New System.Drawing.Point(335, 3)
        Me.ConstraintGroup.Name = "ConstraintGroup"
        Me.ConstraintGroup.Size = New System.Drawing.Size(108, 109)
        Me.ConstraintGroup.TabIndex = 64
        Me.ConstraintGroup.TabStop = False
        Me.ConstraintGroup.Text = "Constraints"
        '
        'ForCheck
        '
        Me.ForCheck.AutoSize = True
        Me.ForCheck.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ForCheck.Location = New System.Drawing.Point(3, 42)
        Me.ForCheck.Name = "ForCheck"
        Me.ForCheck.Size = New System.Drawing.Size(98, 17)
        Me.ForCheck.TabIndex = 58
        Me.ForCheck.Text = "FOREIGN KEY"
        Me.ForCheck.UseVisualStyleBackColor = True
        '
        'Unique
        '
        Me.Unique.AutoSize = True
        Me.Unique.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Unique.Location = New System.Drawing.Point(3, 90)
        Me.Unique.Name = "Unique"
        Me.Unique.Size = New System.Drawing.Size(68, 17)
        Me.Unique.TabIndex = 57
        Me.Unique.Text = "UNIQUE"
        Me.Unique.UseVisualStyleBackColor = True
        '
        'NotNull
        '
        Me.NotNull.AutoSize = True
        Me.NotNull.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NotNull.Location = New System.Drawing.Point(3, 67)
        Me.NotNull.Name = "NotNull"
        Me.NotNull.Size = New System.Drawing.Size(80, 17)
        Me.NotNull.TabIndex = 54
        Me.NotNull.Text = "NOT NULL"
        Me.NotNull.UseVisualStyleBackColor = True
        '
        'PrimCheck
        '
        Me.PrimCheck.AutoSize = True
        Me.PrimCheck.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PrimCheck.Location = New System.Drawing.Point(3, 19)
        Me.PrimCheck.Name = "PrimCheck"
        Me.PrimCheck.Size = New System.Drawing.Size(99, 17)
        Me.PrimCheck.TabIndex = 44
        Me.PrimCheck.Text = "PRIMARY KEY"
        Me.PrimCheck.UseVisualStyleBackColor = True
        '
        'ReferenceGroup
        '
        Me.ReferenceGroup.Controls.Add(Me.OnDeleteAction)
        Me.ReferenceGroup.Controls.Add(Me.OnUpdateAction)
        Me.ReferenceGroup.Controls.Add(Me.OnDeleteBox)
        Me.ReferenceGroup.Controls.Add(Me.OnUpdateBox)
        Me.ReferenceGroup.Controls.Add(Me.ReferenceBox)
        Me.ReferenceGroup.Controls.Add(Me.ReferenceText)
        Me.ReferenceGroup.Enabled = False
        Me.ReferenceGroup.Location = New System.Drawing.Point(3, 3)
        Me.ReferenceGroup.Name = "ReferenceGroup"
        Me.ReferenceGroup.Size = New System.Drawing.Size(326, 109)
        Me.ReferenceGroup.TabIndex = 58
        Me.ReferenceGroup.TabStop = False
        Me.ReferenceGroup.Text = "Referential"
        '
        'OnDeleteAction
        '
        Me.OnDeleteAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnDeleteAction.Enabled = False
        Me.OnDeleteAction.FormattingEnabled = True
        Me.OnDeleteAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnDeleteAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnDeleteAction.Location = New System.Drawing.Point(87, 82)
        Me.OnDeleteAction.Name = "OnDeleteAction"
        Me.OnDeleteAction.Size = New System.Drawing.Size(124, 21)
        Me.OnDeleteAction.TabIndex = 61
        '
        'OnUpdateAction
        '
        Me.OnUpdateAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OnUpdateAction.Enabled = False
        Me.OnUpdateAction.FormattingEnabled = True
        Me.OnUpdateAction.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.OnUpdateAction.Items.AddRange(New Object() {"CASCADE", "SET NULL", "SET DEFAULT", "NO ACTION"})
        Me.OnUpdateAction.Location = New System.Drawing.Point(87, 47)
        Me.OnUpdateAction.Name = "OnUpdateAction"
        Me.OnUpdateAction.Size = New System.Drawing.Size(124, 21)
        Me.OnUpdateAction.TabIndex = 60
        '
        'OnDeleteBox
        '
        Me.OnDeleteBox.AutoSize = True
        Me.OnDeleteBox.Enabled = False
        Me.OnDeleteBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnDeleteBox.Location = New System.Drawing.Point(7, 84)
        Me.OnDeleteBox.Name = "OnDeleteBox"
        Me.OnDeleteBox.Size = New System.Drawing.Size(74, 17)
        Me.OnDeleteBox.TabIndex = 59
        Me.OnDeleteBox.Text = "On Delete"
        Me.OnDeleteBox.UseVisualStyleBackColor = True
        '
        'OnUpdateBox
        '
        Me.OnUpdateBox.AutoSize = True
        Me.OnUpdateBox.Enabled = False
        Me.OnUpdateBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.OnUpdateBox.Location = New System.Drawing.Point(7, 51)
        Me.OnUpdateBox.Name = "OnUpdateBox"
        Me.OnUpdateBox.Size = New System.Drawing.Size(78, 17)
        Me.OnUpdateBox.TabIndex = 57
        Me.OnUpdateBox.Text = "On Update"
        Me.OnUpdateBox.UseVisualStyleBackColor = True
        '
        'ReferenceBox
        '
        Me.ReferenceBox.AutoSize = True
        Me.ReferenceBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ReferenceBox.Location = New System.Drawing.Point(6, 19)
        Me.ReferenceBox.Name = "ReferenceBox"
        Me.ReferenceBox.Size = New System.Drawing.Size(81, 17)
        Me.ReferenceBox.TabIndex = 54
        Me.ReferenceBox.Text = "References"
        Me.ReferenceBox.UseVisualStyleBackColor = True
        '
        'ReferenceText
        '
        Me.ReferenceText.Enabled = False
        Me.ReferenceText.Location = New System.Drawing.Point(87, 16)
        Me.ReferenceText.Name = "ReferenceText"
        Me.ReferenceText.Size = New System.Drawing.Size(153, 20)
        Me.ReferenceText.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CreateButton)
        Me.Panel2.Controls.Add(Me.NewTableField)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 50)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(161, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Enter Table Name"
        '
        'CreateButton
        '
        Me.CreateButton.AutoSize = True
        Me.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CreateButton.Depth = 0
        Me.CreateButton.Location = New System.Drawing.Point(378, 14)
        Me.CreateButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CreateButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Primary = False
        Me.CreateButton.Size = New System.Drawing.Size(62, 36)
        Me.CreateButton.TabIndex = 39
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'NewTableField
        '
        Me.NewTableField.Depth = 0
        Me.NewTableField.Hint = ""
        Me.NewTableField.Location = New System.Drawing.Point(10, 24)
        Me.NewTableField.MouseState = MaterialSkin.MouseState.HOVER
        Me.NewTableField.Name = "NewTableField"
        Me.NewTableField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewTableField.SelectedText = ""
        Me.NewTableField.SelectionLength = 0
        Me.NewTableField.SelectionStart = 0
        Me.NewTableField.Size = New System.Drawing.Size(354, 23)
        Me.NewTableField.TabIndex = 37
        Me.NewTableField.UseSystemPasswordChar = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PrimaryGroup)
        Me.Panel3.Controls.Add(Me.ForeignKeyGroup)
        Me.Panel3.Controls.Add(Me.FieldGroup)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 115)
        Me.Panel3.Name = "Panel3"
        Me.TableLayoutPanel2.SetRowSpan(Me.Panel3, 2)
        Me.Panel3.Size = New System.Drawing.Size(446, 106)
        Me.Panel3.TabIndex = 10
        '
        'PrimaryGroup
        '
        Me.PrimaryGroup.Controls.Add(Me.PrimaryKeys)
        Me.PrimaryGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrimaryGroup.Location = New System.Drawing.Point(0, 0)
        Me.PrimaryGroup.Name = "PrimaryGroup"
        Me.PrimaryGroup.Size = New System.Drawing.Size(446, 106)
        Me.PrimaryGroup.TabIndex = 9
        Me.PrimaryGroup.TabStop = False
        Me.PrimaryGroup.Text = "Add Primary Key"
        '
        'PrimaryKeys
        '
        Me.PrimaryKeys.Location = New System.Drawing.Point(6, 20)
        Me.PrimaryKeys.Multiline = True
        Me.PrimaryKeys.Name = "PrimaryKeys"
        Me.PrimaryKeys.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PrimaryKeys.Size = New System.Drawing.Size(434, 80)
        Me.PrimaryKeys.TabIndex = 54
        Me.PrimaryKeys.WordWrap = False
        '
        'ForeignKeyGroup
        '
        Me.ForeignKeyGroup.Controls.Add(Me.ForeignKeys)
        Me.ForeignKeyGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeignKeyGroup.Location = New System.Drawing.Point(0, 0)
        Me.ForeignKeyGroup.Name = "ForeignKeyGroup"
        Me.ForeignKeyGroup.Size = New System.Drawing.Size(446, 106)
        Me.ForeignKeyGroup.TabIndex = 8
        Me.ForeignKeyGroup.TabStop = False
        Me.ForeignKeyGroup.Text = "Add Foreign Key"
        '
        'ForeignKeys
        '
        Me.ForeignKeys.Location = New System.Drawing.Point(6, 20)
        Me.ForeignKeys.Multiline = True
        Me.ForeignKeys.Name = "ForeignKeys"
        Me.ForeignKeys.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ForeignKeys.Size = New System.Drawing.Size(434, 80)
        Me.ForeignKeys.TabIndex = 54
        Me.ForeignKeys.WordWrap = False
        '
        'FieldGroup
        '
        Me.FieldGroup.Controls.Add(Me.Precision)
        Me.FieldGroup.Controls.Add(Me.Label4)
        Me.FieldGroup.Controls.Add(Me.FieldSize)
        Me.FieldGroup.Controls.Add(Me.Scale_)
        Me.FieldGroup.Controls.Add(Me.Label3)
        Me.FieldGroup.Controls.Add(Me.Label8)
        Me.FieldGroup.Controls.Add(Me.FieldType)
        Me.FieldGroup.Controls.Add(Me.FieldField)
        Me.FieldGroup.Controls.Add(Me.Label2)
        Me.FieldGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldGroup.Location = New System.Drawing.Point(0, 0)
        Me.FieldGroup.Name = "FieldGroup"
        Me.FieldGroup.Size = New System.Drawing.Size(446, 106)
        Me.FieldGroup.TabIndex = 7
        Me.FieldGroup.TabStop = False
        Me.FieldGroup.Text = "Add Field"
        '
        'Precision
        '
        Me.Precision.Location = New System.Drawing.Point(297, 81)
        Me.Precision.Name = "Precision"
        Me.Precision.Size = New System.Drawing.Size(41, 20)
        Me.Precision.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(188, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Size"
        '
        'FieldSize
        '
        Me.FieldSize.Enabled = False
        Me.FieldSize.Location = New System.Drawing.Point(170, 81)
        Me.FieldSize.Name = "FieldSize"
        Me.FieldSize.Size = New System.Drawing.Size(85, 20)
        Me.FieldSize.TabIndex = 46
        '
        'Scale_
        '
        Me.Scale_.Location = New System.Drawing.Point(344, 81)
        Me.Scale_.Name = "Scale_"
        Me.Scale_.Size = New System.Drawing.Size(41, 20)
        Me.Scale_.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(50, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(294, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "(Presision , Scale)"
        '
        'FieldType
        '
        Me.FieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldType.FormattingEnabled = True
        Me.FieldType.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.FieldType.Items.AddRange(New Object() {"CHAR", "VARCHAR", "BIT", "INTEGER", "SMALLINT", "DECIMAL", "NUMERIC", "REAL", "FLOAT", "DATE", "TIME"})
        Me.FieldType.Location = New System.Drawing.Point(6, 79)
        Me.FieldType.Name = "FieldType"
        Me.FieldType.Size = New System.Drawing.Size(129, 21)
        Me.FieldType.TabIndex = 42
        '
        'FieldField
        '
        Me.FieldField.Depth = 0
        Me.FieldField.Hint = ""
        Me.FieldField.Location = New System.Drawing.Point(8, 29)
        Me.FieldField.MouseState = MaterialSkin.MouseState.HOVER
        Me.FieldField.Name = "FieldField"
        Me.FieldField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FieldField.SelectedText = ""
        Me.FieldField.SelectionLength = 0
        Me.FieldField.SelectionStart = 0
        Me.FieldField.Size = New System.Drawing.Size(432, 23)
        Me.FieldField.TabIndex = 41
        Me.FieldField.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(166, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Enter Field Name"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Add_Foreign_Key_Button)
        Me.Panel4.Controls.Add(Me.CompleteTable_Button)
        Me.Panel4.Controls.Add(Me.Add_Field_Button)
        Me.Panel4.Controls.Add(Me.Add_Primary_Key_Button)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(446, 50)
        Me.Panel4.TabIndex = 11
        '
        'Add_Foreign_Key_Button
        '
        Me.Add_Foreign_Key_Button.AutoSize = True
        Me.Add_Foreign_Key_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Foreign_Key_Button.Depth = 0
        Me.Add_Foreign_Key_Button.Enabled = False
        Me.Add_Foreign_Key_Button.Location = New System.Drawing.Point(220, 8)
        Me.Add_Foreign_Key_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Foreign_Key_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Foreign_Key_Button.Name = "Add_Foreign_Key_Button"
        Me.Add_Foreign_Key_Button.Primary = False
        Me.Add_Foreign_Key_Button.Size = New System.Drawing.Size(127, 36)
        Me.Add_Foreign_Key_Button.TabIndex = 67
        Me.Add_Foreign_Key_Button.Text = "Add Foreign Key"
        Me.Add_Foreign_Key_Button.UseVisualStyleBackColor = True
        '
        'CompleteTable_Button
        '
        Me.CompleteTable_Button.AutoSize = True
        Me.CompleteTable_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CompleteTable_Button.Depth = 0
        Me.CompleteTable_Button.Location = New System.Drawing.Point(358, 8)
        Me.CompleteTable_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CompleteTable_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.CompleteTable_Button.Name = "CompleteTable_Button"
        Me.CompleteTable_Button.Primary = False
        Me.CompleteTable_Button.Size = New System.Drawing.Size(82, 36)
        Me.CompleteTable_Button.TabIndex = 67
        Me.CompleteTable_Button.Text = "Complete"
        Me.CompleteTable_Button.UseVisualStyleBackColor = True
        '
        'Add_Field_Button
        '
        Me.Add_Field_Button.AutoSize = True
        Me.Add_Field_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Field_Button.Depth = 0
        Me.Add_Field_Button.Enabled = False
        Me.Add_Field_Button.Location = New System.Drawing.Point(10, 8)
        Me.Add_Field_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Field_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Field_Button.Name = "Add_Field_Button"
        Me.Add_Field_Button.Primary = False
        Me.Add_Field_Button.Size = New System.Drawing.Size(78, 36)
        Me.Add_Field_Button.TabIndex = 66
        Me.Add_Field_Button.Text = "Add Field"
        Me.Add_Field_Button.UseVisualStyleBackColor = True
        '
        'Add_Primary_Key_Button
        '
        Me.Add_Primary_Key_Button.AutoSize = True
        Me.Add_Primary_Key_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Add_Primary_Key_Button.Depth = 0
        Me.Add_Primary_Key_Button.Enabled = False
        Me.Add_Primary_Key_Button.Location = New System.Drawing.Point(94, 8)
        Me.Add_Primary_Key_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Add_Primary_Key_Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Add_Primary_Key_Button.Name = "Add_Primary_Key_Button"
        Me.Add_Primary_Key_Button.Primary = False
        Me.Add_Primary_Key_Button.Size = New System.Drawing.Size(121, 36)
        Me.Add_Primary_Key_Button.TabIndex = 65
        Me.Add_Primary_Key_Button.Text = "Add Primay Key"
        Me.Add_Primary_Key_Button.UseVisualStyleBackColor = True
        '
        'PrimaryKeyGroup
        '
        Me.PrimaryKeyGroup.Controls.Add(Me.TextBox1)
        Me.PrimaryKeyGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrimaryKeyGroup.Location = New System.Drawing.Point(3, 16)
        Me.PrimaryKeyGroup.Name = "PrimaryKeyGroup"
        Me.PrimaryKeyGroup.Size = New System.Drawing.Size(452, 675)
        Me.PrimaryKeyGroup.TabIndex = 7
        Me.PrimaryKeyGroup.TabStop = False
        Me.PrimaryKeyGroup.Text = "Add Primary Key"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(8, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(432, 80)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.WordWrap = False
        '
        'OperationsPanel
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.OperationsPanel, 4)
        Me.OperationsPanel.Controls.Add(Me.Act_Create_Table)
        Me.OperationsPanel.Controls.Add(Me.Act_Update)
        Me.OperationsPanel.Controls.Add(Me.Act_Drop)
        Me.OperationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperationsPanel.Location = New System.Drawing.Point(3, 3)
        Me.OperationsPanel.Name = "OperationsPanel"
        Me.OperationsPanel.Size = New System.Drawing.Size(458, 71)
        Me.OperationsPanel.TabIndex = 6
        '
        'Act_Create_Table
        '
        Me.Act_Create_Table.AutoSize = True
        Me.Act_Create_Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Create_Table.BackColor = System.Drawing.Color.White
        Me.Act_Create_Table.Depth = 0
        Me.Act_Create_Table.Location = New System.Drawing.Point(3, 0)
        Me.Act_Create_Table.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Create_Table.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Create_Table.Name = "Act_Create_Table"
        Me.Act_Create_Table.Primary = False
        Me.Act_Create_Table.Size = New System.Drawing.Size(107, 36)
        Me.Act_Create_Table.TabIndex = 0
        Me.Act_Create_Table.Text = "Create Table"
        Me.Act_Create_Table.UseVisualStyleBackColor = False
        '
        'Act_Update
        '
        Me.Act_Update.AutoSize = True
        Me.Act_Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Update.BackColor = System.Drawing.Color.White
        Me.Act_Update.Depth = 0
        Me.Act_Update.Location = New System.Drawing.Point(118, 0)
        Me.Act_Update.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Update.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Update.Name = "Act_Update"
        Me.Act_Update.Primary = False
        Me.Act_Update.Size = New System.Drawing.Size(109, 36)
        Me.Act_Update.TabIndex = 4
        Me.Act_Update.Text = "Update Table"
        Me.Act_Update.UseVisualStyleBackColor = False
        '
        'Act_Drop
        '
        Me.Act_Drop.AutoSize = True
        Me.Act_Drop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Act_Drop.BackColor = System.Drawing.Color.White
        Me.Act_Drop.Depth = 0
        Me.Act_Drop.Location = New System.Drawing.Point(235, 0)
        Me.Act_Drop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Act_Drop.MouseState = MaterialSkin.MouseState.HOVER
        Me.Act_Drop.Name = "Act_Drop"
        Me.Act_Drop.Primary = False
        Me.Act_Drop.Size = New System.Drawing.Size(105, 36)
        Me.Act_Drop.TabIndex = 3
        Me.Act_Drop.Text = "Delete Table"
        Me.Act_Drop.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1164, 773)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Home"
        Me.Text = "SQL Data Definiton Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContainerPane.ResumeLayout(False)
        Me.ActionGroup.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CheckGroup.ResumeLayout(False)
        Me.CheckGroup.PerformLayout()
        Me.ConstraintGroup.ResumeLayout(False)
        Me.ConstraintGroup.PerformLayout()
        Me.ReferenceGroup.ResumeLayout(False)
        Me.ReferenceGroup.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PrimaryGroup.ResumeLayout(False)
        Me.PrimaryGroup.PerformLayout()
        Me.ForeignKeyGroup.ResumeLayout(False)
        Me.ForeignKeyGroup.PerformLayout()
        Me.FieldGroup.ResumeLayout(False)
        Me.FieldGroup.PerformLayout()
        CType(Me.Precision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FieldSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scale_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PrimaryKeyGroup.ResumeLayout(False)
        Me.PrimaryKeyGroup.PerformLayout()
        Me.OperationsPanel.ResumeLayout(False)
        Me.OperationsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Sequence As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ContainerPane As Panel
    Friend WithEvents ActionGroup As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckGroup As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Check_String As TextBox
    Friend WithEvents Check_Position As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ConstraintGroup As GroupBox
    Friend WithEvents Unique As CheckBox
    Friend WithEvents NotNull As CheckBox
    Friend WithEvents PrimCheck As CheckBox
    Friend WithEvents ReferenceGroup As GroupBox
    Friend WithEvents OnDeleteAction As ComboBox
    Friend WithEvents OnUpdateAction As ComboBox
    Friend WithEvents OnDeleteBox As CheckBox
    Friend WithEvents OnUpdateBox As CheckBox
    Friend WithEvents ReferenceBox As CheckBox
    Friend WithEvents ReferenceText As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NewTableField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents OperationsPanel As Panel
    Friend WithEvents Act_Create_Table As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Update As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Act_Drop As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents CompleteTable_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Add_Field_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Add_Primary_Key_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PrimaryKeyGroup As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PrimaryGroup As GroupBox
    Friend WithEvents PrimaryKeys As TextBox
    Friend WithEvents ForeignKeyGroup As GroupBox
    Friend WithEvents ForeignKeys As TextBox
    Friend WithEvents FieldGroup As GroupBox
    Friend WithEvents Precision As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents FieldSize As NumericUpDown
    Friend WithEvents Scale_ As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FieldType As ComboBox
    Friend WithEvents FieldField As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Add_Foreign_Key_Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Create As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Check_Type As ComboBox
    Friend WithEvents ForCheck As CheckBox
    Friend WithEvents CheckBox As CheckBox
End Class
