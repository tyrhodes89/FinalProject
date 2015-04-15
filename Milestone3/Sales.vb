Public Class Sales
    Public salesTransactionNumber As String 'PK
    Public quantity As String
    Public specialJob As String
    Public objectCode As String
    Public timeStamp As String
    Public jobNumber As String
    Public itemCode As String 'Inventory FK
    Public userId As String 'Users FK
End Class
