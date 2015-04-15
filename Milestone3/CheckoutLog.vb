Public Class CheckoutLog
    Public userId As String 'Composite PK / Users FK
    Public itemCode As String 'Composite PK / Inventory FK
    Public timeStamp As String
    Public itemStatus As Boolean 'If item is available
    Public comments As String
    Public customerNumber As String 'Customer FK
End Class
