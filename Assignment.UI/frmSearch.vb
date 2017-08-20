Imports Assignment.Data
Imports Assignment.Business

Public Class frmSearch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim businessLogic As BusinessLayer = New BusinessLayer()

            Dim membershipNumber As String = txtSearch.Text
            Dim memberList = businessLogic.SearchMembers(membershipNumber, Application.StartupPath)
            DataGridView1.DataSource = memberList
        Catch ex As Exception
            MessageBox.Show("Error Occurred while searching records")
        End Try
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim businessLogic As BusinessLayer = New BusinessLayer()

        Dim membershipNumber As String = txtSearch.Text
        Dim memberList = businessLogic.SearchMembers(membershipNumber, Application.StartupPath)
        DataGridView1.DataSource = memberList
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class