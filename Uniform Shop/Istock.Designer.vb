<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Istock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Istock))
        Me.Iback = New System.Windows.Forms.Button()
        Me.truckgif = New System.Windows.Forms.PictureBox()
        Me.stoarrive = New System.Windows.Forms.TextBox()
        Me.items = New System.Windows.Forms.ComboBox()
        Me.quanstock = New System.Windows.Forms.TextBox()
        Me.update = New System.Windows.Forms.Button()
        CType(Me.truckgif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Iback
        '
        Me.Iback.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iback.Location = New System.Drawing.Point(86, 420)
        Me.Iback.Name = "Iback"
        Me.Iback.Size = New System.Drawing.Size(189, 36)
        Me.Iback.TabIndex = 2
        Me.Iback.Text = "Back to home"
        Me.Iback.UseVisualStyleBackColor = True
        '
        'truckgif
        '
        Me.truckgif.Image = CType(resources.GetObject("truckgif.Image"), System.Drawing.Image)
        Me.truckgif.Location = New System.Drawing.Point(86, 155)
        Me.truckgif.Name = "truckgif"
        Me.truckgif.Size = New System.Drawing.Size(209, 187)
        Me.truckgif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.truckgif.TabIndex = 3
        Me.truckgif.TabStop = False
        '
        'stoarrive
        '
        Me.stoarrive.BackColor = System.Drawing.SystemColors.Control
        Me.stoarrive.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stoarrive.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stoarrive.Location = New System.Drawing.Point(379, 182)
        Me.stoarrive.Multiline = True
        Me.stoarrive.Name = "stoarrive"
        Me.stoarrive.Size = New System.Drawing.Size(394, 39)
        Me.stoarrive.TabIndex = 4
        Me.stoarrive.Text = "Choose type of stock and state quantity:"
        '
        'items
        '
        Me.items.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items.FormattingEnabled = True
        Me.items.Items.AddRange(New Object() {"White short sleeve shirt, embroidered school crest", "White long sleeved shirt", "Navy shorts with adjustible side tabs", "Navy wool, blend jumper with embroidered school crest", "Mild grey trousers with pleated front", "Black leather belt with silver buckle", "Navy cap with embroidered ""NSBHS"" logo", "Sports top with burgundy panels, gold details and embrodiered school crest", "Dark blue sports shorts", "Dark blue track pants", "White socks with cotton blend", "Grey socks with cotton blend", "Junior tie", "Senior tie", "Navy blazer with emroidered pocket", "Dark blue school bag"})
        Me.items.Location = New System.Drawing.Point(379, 239)
        Me.items.Name = "items"
        Me.items.Size = New System.Drawing.Size(291, 27)
        Me.items.TabIndex = 5
        Me.items.Text = "Please select item"
        '
        'quanstock
        '
        Me.quanstock.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quanstock.Location = New System.Drawing.Point(694, 227)
        Me.quanstock.Multiline = True
        Me.quanstock.Name = "quanstock"
        Me.quanstock.Size = New System.Drawing.Size(111, 55)
        Me.quanstock.TabIndex = 6
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(443, 292)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(227, 33)
        Me.update.TabIndex = 7
        Me.update.Text = "Update Stock"
        Me.update.UseVisualStyleBackColor = True
        '
        'Istock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 547)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.quanstock)
        Me.Controls.Add(Me.items)
        Me.Controls.Add(Me.stoarrive)
        Me.Controls.Add(Me.truckgif)
        Me.Controls.Add(Me.Iback)
        Me.Name = "Istock"
        Me.Text = "Istock"
        CType(Me.truckgif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Iback As Button
    Friend WithEvents truckgif As PictureBox
    Friend WithEvents stoarrive As TextBox
    Friend WithEvents items As ComboBox
    Friend WithEvents quanstock As TextBox
    Friend WithEvents update As Button
End Class
