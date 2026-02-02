Imports System
Imports DevExpress.Xpo

Namespace Northwind

    <Persistent("Customers")>
    Public Class Customer
        Inherits XPLiteObject

        <Key>
        Public CustomerID As String

        Public CompanyName As String

        Public ContactTitle As String

        <Association("CustomerOrders", GetType(Order))>
        Public ReadOnly Property Orders As XPCollection
            Get
                Return GetCollection("Orders")
            End Get
        End Property
    End Class

    <Persistent("Orders")>
    Public Class Order
        Inherits XPLiteObject

        <Key>
        Public OrderID As Integer

        Public ShippedDate As Date

        <Persistent("CustomerID"), Association("CustomerOrders")>
        Public Customer As Customer

        <Persistent("EmployeeID"), Association("EmployeeOrders")>
        Public Employee As Employee

        Public ShipName As String
    End Class

    <Persistent("Employees")>
    Public Class Employee
        Inherits XPLiteObject

        <Key>
        Public EmployeeID As Integer

        Public FirstName As String

        Public LastName As String

        <Association("EmployeeOrders", GetType(Order))>
        Public ReadOnly Property Orders As XPCollection
            Get
                Return GetCollection("Orders")
            End Get
        End Property

        <PersistentAlias("[<Customer>][[<Order>][Customer = ^.This && Employee = ^.^.This]].Count()")>
        Public ReadOnly Property DistinctCustomerCount As Integer
            Get
                Return Convert.ToInt32(EvaluateAlias("DistinctCustomerCount"))
            End Get
        End Property
    End Class
End Namespace
