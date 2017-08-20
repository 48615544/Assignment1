Imports Assignment.Data
Imports Assignment.Business

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim member = New Member()
            Dim bussineLogic = New BusinessLayer()
            member.Name = txtName.Text
            member.LastName = txtSurname.Text
            member.DateOfBirth = dtpDOB.Value
            Dim gender As String = ""
            If (rdbFemale.Checked) Then
                gender = "Female"
            End If
            If (rdbMale.Checked) Then
                gender = "Male"
            End If

            If String.IsNullOrEmpty(gender) Or String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtSurname.Text) Then
                MessageBox.Show("Please enter all fields")
                Return
            End If
            member.Gender = gender
            Dim saveResult = bussineLogic.SaveMember(member, Application.StartupPath)
            If Not saveResult.ToLower().Contains("error") Then
                MessageBox.Show("Member regsitered successfully, membership number " + saveResult)
                txtName.Text = txtSurname.Text = ""

            Else
                MessageBox.Show(saveResult)
            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
        End Try
    End Sub
End Class