Imports System.IO
Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PrintPreviewToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripButton.Click
        Dim ChildForm As New frmSearch
        ChildForm.MdiParent = Me
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDb()
        Dim ChildForm As New frmSearch
        ChildForm.MdiParent = Me
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Function CreateDb()
        Dim filePath As String = String.Format("{0}\Data\Data.txt", Application.StartupPath)
        If Not File.Exists(filePath) Then
            File.CreateText(filePath)
        End If
    End Function

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        Dim ChildForm As New frmSearch
        ChildForm.MdiParent = Me
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim ChildForm1 As New MainForm

        ChildForm1.MdiParent = Me
        ChildForm1.WindowState = FormWindowState.Maximized
        ChildForm1.Show()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles ntsbMember.Click
        Dim ChildForm As New MainForm

        ChildForm.MdiParent = Me
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub
End Class
