Public Class Inventory
    Public ItemCode As String 'PK
    Public ItemName As String
    Public ItemDescription As String
    Public UnitPrice As String
    Public CapitalAsset As String
    Public NotificationQuantity As String
    'No FK

    ReadOnly Property propItemCode() As String
        Get
            Return ItemCode
        End Get
    End Property

End Class
