Imports System.Collections.Generic

Public Class Controller
    Public users As New List(Of Users)
    Public adjLogList As New List(Of AdjustmentLog)
    Public receivables As New List(Of Receivables)
    Public vendors As New List(Of Vendor)
    Public inventory As New List(Of Inventory)
    Public customers As New List(Of Customer)
    Public checkoutLog As New List(Of CheckoutLog)
    Public sales As New List(Of Sales)
    Public warehouse As New List(Of Warehouse)

    'User Functions
    Public Function AddUser()
        Throw New NotImplementedException
    End Function
    Public Function DeleteUser()
        Throw New NotImplementedException
    End Function
    Public Function AdjustUserPermission()
        Throw New NotImplementedException
    End Function

    'Adjustment Log Functions
    Public Function LogAdjustment()
        Throw New NotImplementedException
    End Function

    'Receivables Functions

End Class
