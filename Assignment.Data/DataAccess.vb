
Imports System.IO
Imports System.Linq

Public Class DataAccess
    Public Function SaveMember(ByVal member As Member, ByVal path As String) As String
        Try
            Dim membershipNumber As String
            membershipNumber = GenerateRandomString(2) + GenerateRandomInteger(4)
            member.MembershipNumber = membershipNumber
            Dim dataText As String
            dataText = member.Name + "," + member.LastName + "," + member.Gender + "," + member.DateOfBirth.ToString("dd MMM yyyy") + "," + member.MembershipNumber
            Dim filePath As String = String.Format("{0}\Data\Data.txt", path)
            If Not File.Exists(filePath) Then
                Using sw As StreamWriter = File.CreateText(filePath)
                    sw.WriteLine(dataText)
                End Using
            Else
                Using sw As StreamWriter = File.AppendText(filePath)
                    sw.WriteLine(dataText)
                End Using
            End If

            Return membershipNumber
        Catch ex As Exception
            Return "Error : " + ex.Message
        End Try
    End Function

    Public Function SearchMembers(ByVal membershipNumber As String, ByVal path As String) As List(Of Member)
        Dim memberList As List(Of Member) = New List(Of Member)

        Dim filePath As String = String.Format("{0}\Data\Data.txt", path)
            Dim sr As StreamReader = New StreamReader(filePath)
            Dim member As Member = New Member()
            Do While sr.Peek() >= 0

                Dim stringContent = sr.ReadLine()
                Dim arrayData As Array = stringContent.Split(",")
                member.Name = arrayData(0)
                member.LastName = arrayData(1)
                member.Gender = arrayData(2)
                member.DateOfBirth = arrayData(3)
                member.MembershipNumber = arrayData(4)
                If Not String.IsNullOrEmpty(membershipNumber) Then
                    If (member.MembershipNumber.ToLower().Contains(membershipNumber.ToLower())) Then
                        memberList.Add(member)
                    End If
                Else
                    memberList.Add(member)
                End If
            Loop
            sr.Close()

            Return memberList

    End Function

    Public Function GenerateRandomString(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function

    Public Function GenerateRandomInteger(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "0123456789".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function

End Class
