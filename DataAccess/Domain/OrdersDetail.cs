/*
insert license info here
*/
using System;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Domain
{
    /// <summary>
    ///	Generated by MyGeneration using the IBatis Object Mapping template
    /// </summary>
    [Serializable]
    public sealed class OrdersDetail : NotificationObject
    {
       #region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private string _transno; 
		private string _ordersno; 
		private string _menucode; 
		private string _menuname; 
		private float _menuprice; 
		private long _sendcount; 
		private float _totalmoney; 
		private float _discountmoney; 
		private float _paymoney; 
		private string _payway; 
		private string _set1_value; 
		private string _set2_value; 
		private string _set3_value; 
		private string _set4_value; 
		private string _saleunit; 
		private string _createuser; 
		private DateTime _createtime; 
		private string _upduser; 
		private DateTime _updtime; 
		private string _mainitemsno; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public OrdersDetail()
		{
			_id = 0; 
			_transno = null; 
			_ordersno = null; 
			_menucode = null; 
			_menuname = null; 
			_menuprice = 0; 
			_sendcount = 0; 
			_totalmoney = 0; 
			_discountmoney = 0; 
			_paymoney = 0; 
			_payway = null; 
			_set1_value = null; 
			_set2_value = null; 
			_set3_value = null; 
			_set4_value = null; 
			_saleunit = null; 
			_createuser = null; 
			_createtime = new DateTime(); 
			_upduser = null; 
			_updtime = new DateTime(); 
			_mainitemsno = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public long Id
		{
			get { return _id; }
			set { _isChanged |= (_id != value); _id = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string TransNo
		{
			get { return _transno; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for TransNo", value, value.ToString());
				
				_isChanged |= (_transno != value); _transno = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string OrdersNo
		{
			get { return _ordersno; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for OrdersNo", value, value.ToString());
				
				_isChanged |= (_ordersno != value); _ordersno = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string MenuCode
		{
			get { return _menucode; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for MenuCode", value, value.ToString());
				
				_isChanged |= (_menucode != value); _menucode = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string MenuName
		{
			get { return _menuname; }
			set	
			{
				if( value!= null && value.Length > 15)
					throw new ArgumentOutOfRangeException("Invalid value for MenuName", value, value.ToString());
				
				_isChanged |= (_menuname != value); _menuname = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float MenuPrice
		{
			get { return _menuprice; }
			set { _isChanged |= (_menuprice != value); _menuprice = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long SendCount
		{
			get { return _sendcount; }
			set { _isChanged |= (_sendcount != value); _sendcount = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float TotalMoney
		{
			get { return _totalmoney; }
			set { _isChanged |= (_totalmoney != value); _totalmoney = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float DiscountMoney
		{
			get { return _discountmoney; }
			set { _isChanged |= (_discountmoney != value); _discountmoney = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float PayMoney
		{
			get { return _paymoney; }
			set { _isChanged |= (_paymoney != value); _paymoney = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string PayWay
		{
			get { return _payway; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for PayWay", value, value.ToString());
				
				_isChanged |= (_payway != value); _payway = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Set1Value
		{
			get { return _set1_value; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Set1Value", value, value.ToString());
				
				_isChanged |= (_set1_value != value); _set1_value = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Set2Value
		{
			get { return _set2_value; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Set2Value", value, value.ToString());
				
				_isChanged |= (_set2_value != value); _set2_value = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Set3Value
		{
			get { return _set3_value; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Set3Value", value, value.ToString());
				
				_isChanged |= (_set3_value != value); _set3_value = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Set4Value
		{
			get { return _set4_value; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Set4Value", value, value.ToString());
				
				_isChanged |= (_set4_value != value); _set4_value = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string SaleUnit
		{
			get { return _saleunit; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for SaleUnit", value, value.ToString());
				
				_isChanged |= (_saleunit != value); _saleunit = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string CreateUser
		{
			get { return _createuser; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for CreateUser", value, value.ToString());
				
				_isChanged |= (_createuser != value); _createuser = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateTime
		{
			get { return _createtime; }
			set { _isChanged |= (_createtime != value); _createtime = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string UpdUser
		{
			get { return _upduser; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for UpdUser", value, value.ToString());
				
				_isChanged |= (_upduser != value); _upduser = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime UpdTime
		{
			get { return _updtime; }
			set { _isChanged |= (_updtime != value); _updtime = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string MainItemsNo
		{
			get { return _mainitemsno; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for MainItemsNo", value, value.ToString());
				
				_isChanged |= (_mainitemsno != value); _mainitemsno = value;
			}
		}
			
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public bool IsChanged
		{
			get { return _isChanged; }
		}
		
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public bool IsDeleted
		{
			get { return _isDeleted; }
		}
		
		#endregion 
		
		
		#region Public Functions
		
		/// <summary>
		/// mark the item as deleted
		/// </summary>
		public void MarkAsDeleted()
		{
			_isDeleted = true;
			_isChanged = true;
		}
		
		#endregion
		
	}
}
