Public Class Contact
    Public contactId As String 'PK
    Public firstName As String
    Public lastName As String
    Public phoneNumber As String
    Public faxNumber As String
    Public streetAddress As String
    Public city As String
    Public state As String
    Public zip As String
    Public vendorCode As String
    Public customerNumber As String 'Customer FK
End Class
