Public Class Receivables
    Public receivablesTransactionNumber As String 'PK
    Public quantity As String
    Public timeStamp As String
    Public vendorName As String
    Public invoiceNumber As String
    Public bpcCard As String
    Public objectCode As String
    Public itemCode As String 'Inventory FK
    Public userId As String 'Users FK
    Public warehouseCode As String 'Warehouse FK
    Public freightTransactionNumber As String 'Freight FK
    Public vendorCode As String 'Vendor FK
End Class
