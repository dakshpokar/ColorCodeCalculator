<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyInKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyInMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoNotShowInKOrMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BandToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveMultiplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToleranceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveMultTolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveBandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.smhtc = New System.Windows.Forms.LinkLabel()
        Me.Tolerancer = New System.Windows.Forms.Label()
        Me.Multiplication = New System.Windows.Forms.Label()
        Me.Band3 = New System.Windows.Forms.Label()
        Me.Band2 = New System.Windows.Forms.Label()
        Me.band1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.K = New System.Windows.Forms.ToolStripLabel()
        Me.M = New System.Windows.Forms.ToolStripLabel()
        Me.three = New System.Windows.Forms.ToolStripLabel()
        Me.two = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.history = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Tolter = New System.Windows.Forms.TextBox()
        Me.Display = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tol = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Mul = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B1 = New System.Windows.Forms.ComboBox()
        Me.aaa = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Tolerance = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Mult = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Ba3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Ba2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Ba1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(615, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeUnitToolStripMenuItem, Me.BandsToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ChangeUnitToolStripMenuItem
        '
        Me.ChangeUnitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlyInKToolStripMenuItem, Me.OnlyInMToolStripMenuItem, Me.DoNotShowInKOrMToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ChangeUnitToolStripMenuItem.Name = "ChangeUnitToolStripMenuItem"
        Me.ChangeUnitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ChangeUnitToolStripMenuItem.Text = "Change Unit"
        '
        'OnlyInKToolStripMenuItem
        '
        Me.OnlyInKToolStripMenuItem.Name = "OnlyInKToolStripMenuItem"
        Me.OnlyInKToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.OnlyInKToolStripMenuItem.Text = "Only in K"
        '
        'OnlyInMToolStripMenuItem
        '
        Me.OnlyInMToolStripMenuItem.Name = "OnlyInMToolStripMenuItem"
        Me.OnlyInMToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.OnlyInMToolStripMenuItem.Text = "Only in M"
        '
        'DoNotShowInKOrMToolStripMenuItem
        '
        Me.DoNotShowInKOrMToolStripMenuItem.Name = "DoNotShowInKOrMToolStripMenuItem"
        Me.DoNotShowInKOrMToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DoNotShowInKOrMToolStripMenuItem.Text = "Do not show in K or M"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'BandsToolStripMenuItem
        '
        Me.BandsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BandToolStripMenuItem, Me.BandToolStripMenuItem1})
        Me.BandsToolStripMenuItem.Name = "BandsToolStripMenuItem"
        Me.BandsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BandsToolStripMenuItem.Text = "Bands"
        '
        'BandToolStripMenuItem
        '
        Me.BandToolStripMenuItem.Name = "BandToolStripMenuItem"
        Me.BandToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.BandToolStripMenuItem.Text = "2 Bands"
        '
        'BandToolStripMenuItem1
        '
        Me.BandToolStripMenuItem1.Name = "BandToolStripMenuItem1"
        Me.BandToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.BandToolStripMenuItem1.Text = "3 Bands"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.LeaveMultiplierToolStripMenuItem, Me.LeaveToleranceToolStripMenuItem, Me.LeaveMultTolToolStripMenuItem, Me.LeaveBandsToolStripMenuItem})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'LeaveMultiplierToolStripMenuItem
        '
        Me.LeaveMultiplierToolStripMenuItem.Name = "LeaveMultiplierToolStripMenuItem"
        Me.LeaveMultiplierToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LeaveMultiplierToolStripMenuItem.Text = "Leave Multiplier"
        '
        'LeaveToleranceToolStripMenuItem
        '
        Me.LeaveToleranceToolStripMenuItem.Name = "LeaveToleranceToolStripMenuItem"
        Me.LeaveToleranceToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LeaveToleranceToolStripMenuItem.Text = "Leave Tolerance"
        '
        'LeaveMultTolToolStripMenuItem
        '
        Me.LeaveMultTolToolStripMenuItem.Name = "LeaveMultTolToolStripMenuItem"
        Me.LeaveMultTolToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LeaveMultTolToolStripMenuItem.Text = "Leave Mult., Tol"
        '
        'LeaveBandsToolStripMenuItem
        '
        Me.LeaveBandsToolStripMenuItem.Name = "LeaveBandsToolStripMenuItem"
        Me.LeaveBandsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.LeaveBandsToolStripMenuItem.Text = "Leave Bands"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem.Text = "Version 1.1C"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.smhtc)
        Me.Panel1.Controls.Add(Me.Tolerancer)
        Me.Panel1.Controls.Add(Me.Multiplication)
        Me.Panel1.Controls.Add(Me.Band3)
        Me.Panel1.Controls.Add(Me.Band2)
        Me.Panel1.Controls.Add(Me.band1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.Tolter)
        Me.Panel1.Controls.Add(Me.Display)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Tol)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Mul)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.B3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.B2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.B1)
        Me.Panel1.Controls.Add(Me.aaa)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 295)
        Me.Panel1.TabIndex = 2
        '
        'smhtc
        '
        Me.smhtc.AutoSize = True
        Me.smhtc.Location = New System.Drawing.Point(325, 43)
        Me.smhtc.Name = "smhtc"
        Me.smhtc.Size = New System.Drawing.Size(166, 13)
        Me.smhtc.TabIndex = 26
        Me.smhtc.TabStop = True
        Me.smhtc.Text = "Show me how did you calculated!"
        Me.smhtc.Visible = False
        '
        'Tolerancer
        '
        Me.Tolerancer.AutoSize = True
        Me.Tolerancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tolerancer.Location = New System.Drawing.Point(120, 169)
        Me.Tolerancer.Name = "Tolerancer"
        Me.Tolerancer.Size = New System.Drawing.Size(27, 13)
        Me.Tolerancer.TabIndex = 25
        Me.Tolerancer.Text = "N/A"
        Me.Tolerancer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Multiplication
        '
        Me.Multiplication.AutoSize = True
        Me.Multiplication.Location = New System.Drawing.Point(120, 129)
        Me.Multiplication.Name = "Multiplication"
        Me.Multiplication.Size = New System.Drawing.Size(27, 13)
        Me.Multiplication.TabIndex = 24
        Me.Multiplication.Text = "N/A"
        Me.Multiplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Band3
        '
        Me.Band3.AutoSize = True
        Me.Band3.Location = New System.Drawing.Point(120, 89)
        Me.Band3.Name = "Band3"
        Me.Band3.Size = New System.Drawing.Size(27, 13)
        Me.Band3.TabIndex = 23
        Me.Band3.Text = "N/A"
        Me.Band3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Band2
        '
        Me.Band2.AutoSize = True
        Me.Band2.Location = New System.Drawing.Point(120, 49)
        Me.Band2.Name = "Band2"
        Me.Band2.Size = New System.Drawing.Size(27, 13)
        Me.Band2.TabIndex = 22
        Me.Band2.Text = "N/A"
        Me.Band2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'band1
        '
        Me.band1.AutoSize = True
        Me.band1.Location = New System.Drawing.Point(120, 9)
        Me.band1.Name = "band1"
        Me.band1.Size = New System.Drawing.Size(27, 13)
        Me.band1.TabIndex = 21
        Me.band1.Text = "N/A"
        Me.band1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.K, Me.M, Me.three, Me.two, Me.ToolStripLabel2, Me.history, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 270)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(615, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'K
        '
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(42, 22)
        Me.K.Text = "Unit: K"
        Me.K.Visible = False
        '
        'M
        '
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(46, 22)
        Me.M.Text = "Unit: M"
        Me.M.Visible = False
        '
        'three
        '
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(48, 22)
        Me.three.Text = "3 Bands"
        '
        'two
        '
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(48, 22)
        Me.two.Text = "2 Bands"
        Me.two.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel2.Text = "Need Help?"
        '
        'history
        '
        Me.history.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(54, 22)
        Me.history.Text = "Nothing,"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripLabel1.Text = "Performed: "
        '
        'Tolter
        '
        Me.Tolter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tolter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tolter.Location = New System.Drawing.Point(327, 59)
        Me.Tolter.Multiline = True
        Me.Tolter.Name = "Tolter"
        Me.Tolter.Size = New System.Drawing.Size(206, 27)
        Me.Tolter.TabIndex = 19
        '
        'Display
        '
        Me.Display.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.Location = New System.Drawing.Point(327, 16)
        Me.Display.Multiline = True
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(206, 27)
        Me.Display.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(469, 231)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 36)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Clear "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tolerance:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(216, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Resistance:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(15, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tol
        '
        Me.Tol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tol.BackColor = System.Drawing.SystemColors.Window
        Me.Tol.FormattingEnabled = True
        Me.Tol.Items.AddRange(New Object() {"Brown", "Red", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver"})
        Me.Tol.Location = New System.Drawing.Point(15, 185)
        Me.Tol.Name = "Tol"
        Me.Tol.Size = New System.Drawing.Size(131, 21)
        Me.Tol.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tolerance"
        '
        'Mul
        '
        Me.Mul.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mul.BackColor = System.Drawing.SystemColors.Window
        Me.Mul.FormattingEnabled = True
        Me.Mul.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "White", "Gold", "Silver"})
        Me.Mul.Location = New System.Drawing.Point(15, 145)
        Me.Mul.Name = "Mul"
        Me.Mul.Size = New System.Drawing.Size(131, 21)
        Me.Mul.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Multiplier"
        '
        'B3
        '
        Me.B3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B3.BackColor = System.Drawing.SystemColors.Window
        Me.B3.FormattingEnabled = True
        Me.B3.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.B3.Location = New System.Drawing.Point(15, 105)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(131, 21)
        Me.B3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Third Band"
        '
        'B2
        '
        Me.B2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B2.BackColor = System.Drawing.SystemColors.Window
        Me.B2.FormattingEnabled = True
        Me.B2.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.B2.Location = New System.Drawing.Point(15, 65)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(131, 21)
        Me.B2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Second Band"
        '
        'B1
        '
        Me.B1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B1.BackColor = System.Drawing.SystemColors.Window
        Me.B1.FormattingEnabled = True
        Me.B1.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White"})
        Me.B1.Location = New System.Drawing.Point(14, 25)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(132, 21)
        Me.B1.TabIndex = 1
        '
        'aaa
        '
        Me.aaa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aaa.AutoSize = True
        Me.aaa.Location = New System.Drawing.Point(11, 9)
        Me.aaa.Name = "aaa"
        Me.aaa.Size = New System.Drawing.Size(54, 13)
        Me.aaa.TabIndex = 0
        Me.aaa.Text = "First Band"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Tolerance, Me.Mult, Me.Ba3, Me.Ba2, Me.Ba1, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(615, 295)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'Tolerance
        '
        Me.Tolerance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Tolerance.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Tolerance.Location = New System.Drawing.Point(466, 128)
        Me.Tolerance.Name = "Tolerance"
        Me.Tolerance.Size = New System.Drawing.Size(24, 61)
        '
        'Mult
        '
        Me.Mult.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Mult.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Mult.Location = New System.Drawing.Point(423, 128)
        Me.Mult.Name = "Mult"
        Me.Mult.Size = New System.Drawing.Size(24, 61)
        '
        'Ba3
        '
        Me.Ba3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ba3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Ba3.Location = New System.Drawing.Point(342, 129)
        Me.Ba3.Name = "Ba3"
        Me.Ba3.Size = New System.Drawing.Size(24, 61)
        '
        'Ba2
        '
        Me.Ba2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ba2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Ba2.Location = New System.Drawing.Point(305, 128)
        Me.Ba2.Name = "Ba2"
        Me.Ba2.Size = New System.Drawing.Size(24, 61)
        '
        'Ba1
        '
        Me.Ba1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Ba1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Ba1.Location = New System.Drawing.Point(269, 129)
        Me.Ba1.Name = "Ba1"
        Me.Ba1.Size = New System.Drawing.Size(24, 61)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RectangleShape3.FillColor = System.Drawing.Color.Chocolate
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(525, 149)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(64, 18)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RectangleShape2.FillColor = System.Drawing.Color.Chocolate
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(186, 150)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(57, 18)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.FillColor = System.Drawing.Color.Sienna
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(243, 128)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(282, 62)
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 167
        Me.LineShape1.X2 = 167
        Me.LineShape1.Y1 = 1
        Me.LineShape1.Y2 = 269
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 319)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colour Code Calculator v1.1C"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeUnitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlyInKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlyInMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents B1 As System.Windows.Forms.ComboBox
    Friend WithEvents aaa As System.Windows.Forms.Label
    Friend WithEvents Tol As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Mul As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents B2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Tolerance As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Mult As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Ba3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Ba2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Ba1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Display As System.Windows.Forms.TextBox
    Friend WithEvents Tolter As System.Windows.Forms.TextBox
    Friend WithEvents BandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BandToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveMultiplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveToleranceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveMultTolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveBandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents K As System.Windows.Forms.ToolStripLabel
    Friend WithEvents M As System.Windows.Forms.ToolStripLabel
    Friend WithEvents three As System.Windows.Forms.ToolStripLabel
    Friend WithEvents two As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents history As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Tolerancer As System.Windows.Forms.Label
    Friend WithEvents Multiplication As System.Windows.Forms.Label
    Friend WithEvents Band3 As System.Windows.Forms.Label
    Friend WithEvents Band2 As System.Windows.Forms.Label
    Friend WithEvents band1 As System.Windows.Forms.Label
    Friend WithEvents smhtc As System.Windows.Forms.LinkLabel
    Friend WithEvents DoNotShowInKOrMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
