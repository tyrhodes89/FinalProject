Public Class AdjustmentLog
    Public adjustmentLogTransactionNumber As String 'PK
    Public userId As String 'Users FK
    Public itemCode As String 'Inventory FK
    Public adjustmentTypeId As String 'AdjustmentType FK
End Class
