Public Class Stock
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creation of dropdown menu to access other forms'
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
        Istock.Show()
        Me.Close()
    End Sub
    Private Sub stocktol_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub

    Private Sub Sback_Click(sender As Object, e As EventArgs) Handles Sback.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub gopic_Click(sender As Object, e As EventArgs) Handles gopic.Click
        Pstock.Show()
        Me.Hide()
    End Sub


End Class