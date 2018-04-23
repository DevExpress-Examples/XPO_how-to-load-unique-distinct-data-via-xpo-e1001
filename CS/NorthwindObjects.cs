namespace Northwind {
    using System;
    using DevExpress.Xpo;
    
    
	[Persistent("Customers")]
	public class Customer : XPLiteObject {
		[Key]
		public string CustomerID;
		public string CompanyName;
		public string ContactTitle;

		[Association("CustomerOrders", typeof(Order))]
		public XPCollection Orders {
			get {
				return GetCollection("Orders");
			}
		}
	}

	[Persistent("Orders")]
	public class Order : XPLiteObject {
		[Key]
		public int OrderID;
		public DateTime ShippedDate;
		
		[Persistent("CustomerID"), Association("CustomerOrders")]
		public Customer Customer;

		[Persistent("EmployeeID"), Association("EmployeeOrders")]
		public Employee Employee;

        public string ShipName;
 	}

	[Persistent("Employees")]
	public class Employee : XPLiteObject {
		[Key]
		public int EmployeeID;
		public string FirstName;
		public string LastName;

		[Association("EmployeeOrders", typeof(Order))]
		public XPCollection Orders {
			get {
				return GetCollection("Orders");
			}
		}
	}
}
