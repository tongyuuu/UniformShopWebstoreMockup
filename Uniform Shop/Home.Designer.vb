<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.amtstock = New System.Windows.Forms.Button()
        Me.incstock = New System.Windows.Forms.Button()
        Me.outstock = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.logoname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.goal = New System.Windows.Forms.TextBox()
        Me.goalset = New System.Windows.Forms.TextBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'amtstock
        '
        Me.amtstock.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtstock.Location = New System.Drawing.Point(294, 347)
        Me.amtstock.Name = "amtstock"
        Me.amtstock.Size = New System.Drawing.Size(188, 34)
        Me.amtstock.TabIndex = 0
        Me.amtstock.Text = "Amount of Stock"
        Me.amtstock.UseVisualStyleBackColor = True
        '
        'incstock
        '
        Me.incstock.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incstock.Location = New System.Drawing.Point(63, 347)
        Me.incstock.Name = "incstock"
        Me.incstock.Size = New System.Drawing.Size(188, 33)
        Me.incstock.TabIndex = 1
        Me.incstock.Text = "Incoming Stock"
        Me.incstock.UseVisualStyleBackColor = True
        '
        'outstock
        '
        Me.outstock.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outstock.Location = New System.Drawing.Point(523, 347)
        Me.outstock.Name = "outstock"
        Me.outstock.Size = New System.Drawing.Size(188, 34)
        Me.outstock.TabIndex = 2
        Me.outstock.Text = "Outgoing Stock"
        Me.outstock.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(44, 41)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(280, 239)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 3
        Me.Logo.TabStop = False
        '
        'logoname
        '
        Me.logoname.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.logoname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logoname.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoname.Location = New System.Drawing.Point(367, 41)
        Me.logoname.Multiline = True
        Me.logoname.Name = "logoname"
        Me.logoname.ReadOnly = True
        Me.logoname.Size = New System.Drawing.Size(367, 92)
        Me.logoname.TabIndex = 4
        Me.logoname.Text = "NORTH SYDNEY BOYS UNIFORM SHOP"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(367, 139)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(312, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'goal
        '
        Me.goal.BackColor = System.Drawing.SystemColors.Control
        Me.goal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.goal.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goal.Location = New System.Drawing.Point(367, 196)
        Me.goal.Multiline = True
        Me.goal.Name = "goal"
        Me.goal.Size = New System.Drawing.Size(269, 27)
        Me.goal.TabIndex = 6
        Me.goal.Text = "What's your sales goal for today?"
        '
        'goalset
        '
        Me.goalset.Location = New System.Drawing.Point(377, 229)
        Me.goalset.Name = "goalset"
        Me.goalset.Size = New System.Drawing.Size(213, 20)
        Me.goalset.TabIndex = 7
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.goalset)
        Me.Controls.Add(Me.goal)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.logoname)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.outstock)
        Me.Controls.Add(Me.incstock)
        Me.Controls.Add(Me.amtstock)
        Me.Name = "Homepage"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents amtstock As Button
    Friend WithEvents incstock As Button
    Friend WithEvents outstock As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents logoname As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents goalset As TextBox
    Protected WithEvents goal As TextBox
End Class
