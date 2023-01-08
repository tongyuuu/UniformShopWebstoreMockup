Public Class Ostock
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creation of dropdown menu to access different forms while running program'
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
        Me.Hide()
    End Sub
    Private Sub stockout_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub
    Private Sub stockin_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Istock.Show()
        Me.Hide()
    End Sub
    Private Sub stocktol_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Stock.Show()
        Me.Hide()
    End Sub
    Private Sub Oback_Click(sender As Object, e As EventArgs) Handles Oback.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub prog_TextChanged(sender As Object, e As EventArgs) Handles prog.TextChanged
        'setting the maximum of the progress bar for daily goal'
        If Homepage.goalset.Text = "" Then Return
        If prog.Text = "" Or IsNumeric(prog.Text) <> True Or IsNumeric(Homepage.goalset.Text) <> True Or Homepage.goalset.Text < 0 Then Return
        progbar.Maximum = Int(Homepage.goalset.Text)
        If Int(prog.Text) <= progbar.Maximum Then
            progbar.Value = prog.Text
        Else
            progbar.Value = progbar.Maximum
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'calculating total amount of earnings'
        If IsNumeric(sale1.Text) <> True Or IsNumeric(sale2.Text) <> True Or IsNumeric(sale3.Text) <> True Or IsNumeric(sale4.Text) <> True Or IsNumeric(sale5.Text) <> True Or IsNumeric(sale6.Text) <> True Or IsNumeric(sale7.Text) <> True Or IsNumeric(sale8.Text) <> True Or IsNumeric(sale9.Text) <> True Or IsNumeric(sale10.Text) <> True Or IsNumeric(sale11.Text) <> True Or IsNumeric(sale12.Text) <> True Or IsNumeric(sale13.Text) <> True Or IsNumeric(sale14.Text) <> True Or IsNumeric(sale15.Text) <> True Or IsNumeric(sale16.Text) <> True Then Return
        earn.Text = "$" + Str(Int(sale1.Text) * Int(price1.Text) + Int(sale2.Text) * Int(price2.Text) + Int(sale3.Text) * Int(price3.Text) + Int(sale4.Text) * Int(price4.Text) + Int(sale5.Text) * Int(price5.Text) + Int(sale6.Text) * Int(price6.Text) + Int(sale7.Text) * Int(price7.Text) + Int(sale8.Text) * Int(price8.Text) + Int(sale9.Text) * Int(price9.Text) + Int(sale10.Text) * Int(price10.Text) + Int(sale11.Text) * Int(price11.Text) + Int(sale12.Text) * Int(price12.Text) + Int(sale13.Text) * Int(price13.Text) + Int(sale14.Text) * (price14.Text) + Int(sale15.Text) * Int(price15.Text) + Int(sale16.Text) * Int(price16.Text))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'calcuating total amount of sales'
        If IsNumeric(sale1.Text) <> True Or IsNumeric(sale2.Text) <> True Or IsNumeric(sale3.Text) <> True Or IsNumeric(sale4.Text) <> True Or IsNumeric(sale5.Text) <> True Or IsNumeric(sale6.Text) <> True Or IsNumeric(sale7.Text) <> True Or IsNumeric(sale8.Text) <> True Or IsNumeric(sale9.Text) <> True Or IsNumeric(sale10.Text) <> True Or IsNumeric(sale11.Text) <> True Or IsNumeric(sale12.Text) <> True Or IsNumeric(sale13.Text) <> True Or IsNumeric(sale14.Text) <> True Or IsNumeric(sale15.Text) <> True Or IsNumeric(sale16.Text) <> True Then Return
        prog.Text = Int(sale1.Text) + Int(sale2.Text) + Int(sale3.Text) + Int(sale4.Text) + Int(sale5.Text) + Int(sale6.Text) + Int(sale7.Text) + Int(sale8.Text) + Int(sale9.Text) + Int(sale10.Text) + Int(sale11.Text) + Int(sale12.Text) + Int(sale13.Text) + Int(sale14.Text) + Int(sale15.Text) + Int(sale16.Text)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles update.Click
        'updating amount of stock available after it is sold'
        MsgBox("Stock Updated!")
        If sale16.Text = "" Or IsNumeric(sale16.Text) <> True Or IsNumeric(Stock.stock16.Text) <> True Then Return
        Stock.stock16.Text = Int(Stock.stock16.Text) - Int(sale16.Text)
        If sale15.Text = "" Or IsNumeric(sale15.Text) <> True Or IsNumeric(Stock.stock15.Text) <> True Then Return
        Stock.stock15.Text = Int(Stock.stock15.Text) - Int(sale15.Text)
        If sale14.Text = "" Or IsNumeric(sale14.Text) <> True Or IsNumeric(Stock.stock14.Text) <> True Then Return
        Stock.stock14.Text = Int(Stock.stock14.Text) - Int(sale14.Text)
        If sale13.Text = "" Or IsNumeric(sale13.Text) <> True Or IsNumeric(Stock.stock13.Text) <> True Then Return
        Stock.stock13.Text = Int(Stock.stock13.Text) - Int(sale13.Text)
        If sale12.Text = "" Or IsNumeric(sale12.Text) <> True Or IsNumeric(Stock.stock12.Text) <> True Then Return
        Stock.stock12.Text = Int(Stock.stock12.Text) - Int(sale12.Text)
        If sale11.Text = "" Or IsNumeric(sale11.Text) <> True Or IsNumeric(Stock.stock11.Text) <> True Then Return
        Stock.stock11.Text = Int(Stock.stock11.Text) - Int(sale11.Text)
        If sale10.Text = "" Or IsNumeric(sale10.Text) <> True Or IsNumeric(Stock.stock10.Text) <> True Then Return
        Stock.stock10.Text = Int(Stock.stock10.Text) - Int(sale10.Text)
        If sale9.Text = "" Or IsNumeric(sale9.Text) <> True Or IsNumeric(Stock.stock9.Text) <> True Then Return
        Stock.stock9.Text = Int(Stock.stock9.Text) - Int(sale9.Text)
        If sale8.Text = "" Or IsNumeric(sale8.Text) <> True Or IsNumeric(Stock.stock8.Text) <> True Then Return
        Stock.stock8.Text = Int(Stock.stock8.Text) - Int(sale8.Text)
        If sale7.Text = "" Or IsNumeric(sale7.Text) <> True Or IsNumeric(Stock.stock7.Text) <> True Then Return
        Stock.stock7.Text = Int(Stock.stock7.Text) - Int(sale7.Text)
        If sale6.Text = "" Or IsNumeric(sale6.Text) <> True Or IsNumeric(Stock.stock6.Text) <> True Then Return
        Stock.stock6.Text = Int(Stock.stock6.Text) - Int(sale6.Text)
        If sale5.Text = "" Or IsNumeric(sale5.Text) <> True Or IsNumeric(Stock.stock5.Text) <> True Then Return
        Stock.stock5.Text = Int(Stock.stock5.Text) - Int(sale5.Text)
        If sale4.Text = "" Or IsNumeric(sale4.Text) <> True Or IsNumeric(Stock.stock4.Text) <> True Then Return
        Stock.stock4.Text = Int(Stock.stock4.Text) - Int(sale4.Text)
        If sale3.Text = "" Or IsNumeric(sale3.Text) <> True Or IsNumeric(Stock.stock3.Text) <> True Then Return
        Stock.stock3.Text = Int(Stock.stock3.Text) - Int(sale3.Text)
        If sale2.Text = "" Or IsNumeric(sale2.Text) <> True Or IsNumeric(Stock.stock2.Text) <> True Then Return
        Stock.stock2.Text = Int(Stock.stock2.Text) - Int(sale2.Text)
        If sale1.Text = "" Or IsNumeric(sale1.Text) <> True Or IsNumeric(Stock.stock1.Text) <> True Then Return
        Stock.stock1.Text = Int(Stock.stock1.Text) - Int(sale1.Text)
    End Sub

End Class