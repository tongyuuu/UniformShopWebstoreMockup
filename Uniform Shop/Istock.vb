Public Class Istock
    Private Sub Iback_Click(sender As Object, e As EventArgs) Handles Iback.Click
        Homepage.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creation of dropdown menu for accessing different forms'
        CreateMenu()
    End Sub

    Public Sub CreateMenu()
        Dim menuStrip1 As New MenuStrip
        Dim toolStripFileMenuItem As New ToolStripMenuItem("File")
        Dim gopictures As New ToolStripMenuItem("Pictures")
        Dim exitMenuItem As New ToolStripMenuItem("Exit")
        Dim stockout As New ToolStripMenuItem("Outgoing stock")
        Dim stockin As New ToolStripMenuItem("Incoming stock")
        Dim stocktol As New ToolStripMenuItem("Total stock")
        toolStripFileMenuItem.DropDownItems.Add(stocktol)
        toolStripFileMenuItem.DropDownItems.Add(gopictures)
        toolStripFileMenuItem.DropDownItems.Add(stockin)
        toolStripFileMenuItem.DropDownItems.Add(stockout)
        toolStripFileMenuItem.DropDownItems.Add(exitMenuItem)
        menuStrip1.Items.Add(toolStripFileMenuItem)
        Me.Controls.Add(menuStrip1)
        Me.MainMenuStrip = menuStrip1
        AddHandler exitMenuItem.Click, AddressOf Me.exitMenuItem_Click
        AddHandler gopictures.Click, AddressOf Me.gopictures_Click
        AddHandler stockout.Click, AddressOf Me.stockout_Click
        AddHandler stockin.Click, AddressOf Me.stockin_Click
        AddHandler stocktol.Click, AddressOf Me.stocktol_Click
    End Sub

    Private Sub exitMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub gopictures_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Pstock.Show()
        Me.Close()
    End Sub
    Private Sub stockout_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Ostock.Show()
        Me.Close()
    End Sub
    Private Sub stockin_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub
    Private Sub stocktol_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Stock.Show()
        Me.Close()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        'updating the amount of stock after stock is received'
        MsgBox("Stock Updated!")
        If items.SelectedIndex = 0 Then
            Stock.stock1.Text = Int(quanstock.Text) + Int(Stock.stock1.Text)
        End If
        If items.SelectedIndex = 1 Then
            Stock.stock2.Text = Int(quanstock.Text) + Int(Stock.stock2.Text)
        End If
        If items.SelectedIndex = 2 Then
            Stock.stock3.Text = Int(quanstock.Text) + Int(Stock.stock3.Text)
        End If
        If items.SelectedIndex = 3 Then
            Stock.stock4.Text = Int(quanstock.Text) + Int(Stock.stock4.Text)
        End If
        If items.SelectedIndex = 4 Then
            Stock.stock5.Text = Int(quanstock.Text) + Int(Stock.stock5.Text)
        End If
        If items.SelectedIndex = 5 Then
            Stock.stock6.Text = Int(quanstock.Text) + Int(Stock.stock6.Text)
        End If
        If items.SelectedIndex = 6 Then
            Stock.stock7.Text = Int(quanstock.Text) + Int(Stock.stock7.Text)
        End If
        If items.SelectedIndex = 7 Then
            Stock.stock8.Text = Int(quanstock.Text) + Int(Stock.stock8.Text)
        End If
        If items.SelectedIndex = 8 Then
            Stock.stock9.Text = Int(quanstock.Text) + Int(Stock.stock9.Text)
        End If
        If items.SelectedIndex = 9 Then
            Stock.stock10.Text = Int(quanstock.Text) + Int(Stock.stock10.Text)
        End If
        If items.SelectedIndex = 10 Then
            Stock.stock11.Text = Int(quanstock.Text) + Int(Stock.stock11.Text)
        End If
        If items.SelectedIndex = 11 Then
            Stock.stock12.Text = Int(quanstock.Text) + Int(Stock.stock12.Text)
        End If
        If items.SelectedIndex = 12 Then
            Stock.stock13.Text = Int(quanstock.Text) + Int(Stock.stock13.Text)
        End If
        If items.SelectedIndex = 13 Then
            Stock.stock14.Text = Int(quanstock.Text) + Int(Stock.stock14.Text)
        End If
        If items.SelectedIndex = 14 Then
            Stock.stock15.Text = Int(quanstock.Text) + Int(Stock.stock15.Text)
        End If
        If items.SelectedIndex = 15 Then
            Stock.stock16.Text = Int(quanstock.Text) + Int(Stock.stock16.Text)
        End If
    End Sub


End Class

