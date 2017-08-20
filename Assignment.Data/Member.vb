Public Class Member

    Private nameValue As String
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property



    Private lastNameValue As String
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property


    Private genderValue As String
    Public Property Gender() As String
        Get
            Return genderValue
        End Get
        Set(ByVal value As String)
            genderValue = value
        End Set
    End Property


    Private membershipValue As String
    Public Property MembershipNumber() As String
        Get
            Return membershipValue
        End Get
        Set(ByVal value As String)
            membershipValue = value
        End Set
    End Property


    Private dateOfBirthValue As DateTime
    Public Property DateOfBirth() As DateTime
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As DateTime)
            dateOfBirthValue = value
        End Set
    End Property


End Class
