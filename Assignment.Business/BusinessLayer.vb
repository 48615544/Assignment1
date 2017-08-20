
Imports Assignment.Data
Public Class BusinessLayer

    Dim data As DataAccess = New DataAccess()
    Public Function SaveMember(ByVal member As Member, ByVal path As String) As String
        Return data.SaveMember(member, path)
    End Function



    Public Function SearchMembers(ByVal membershipNumber As String, ByVal path As String) As List(Of Member)
        Return data.SearchMembers(membershipNumber, path)
    End Function
End Class
