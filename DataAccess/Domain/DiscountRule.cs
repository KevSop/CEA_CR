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
    public sealed class DiscountRule : NotificationObject
	{
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private string _ruleno; 
		private string _discountno; 
		private float _minmoney; 
		private float _maxmoney; 
		private long _mincount; 
		private long _maxcount; 
		private float _discount; 
		private string _createuser; 
		private DateTime _createtime; 
		private string _upduser; 
		private DateTime _updtime; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public DiscountRule()
		{
			_id = 0; 
			_ruleno = null; 
			_discountno = null; 
			_minmoney = 0; 
			_maxmoney = 0; 
			_mincount = 0; 
			_maxcount = 0; 
			_discount = 0; 
			_createuser = null;
            _createtime = DateTime.Now; 
			_upduser = null;
            _updtime = DateTime.Now; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public long Id
		{
			get { return _id; }
            set { _isChanged |= (_id != value); _id = value; RaisePropertyChanged("Id"); }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string RuleNo
		{
			get { return _ruleno; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for RuleNo", value, value.ToString());

                _isChanged |= (_ruleno != value); _ruleno = value; RaisePropertyChanged("RuleNo");
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string DiscountNo
		{
			get { return _discountno; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for DiscountNo", value, value.ToString());

                _isChanged |= (_discountno != value); _discountno = value; RaisePropertyChanged("DiscountNo");
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float MinMoney
		{
			get { return _minmoney; }
            set { _isChanged |= (_minmoney != value); _minmoney = value; RaisePropertyChanged("MinMoney"); }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float MaxMoney
		{
			get { return _maxmoney; }
            set { _isChanged |= (_maxmoney != value); _maxmoney = value; RaisePropertyChanged("MaxMoney"); }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long MinCount
		{
			get { return _mincount; }
            set { _isChanged |= (_mincount != value); _mincount = value; RaisePropertyChanged("MinCount"); }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long MaxCount
		{
			get { return _maxcount; }
            set { _isChanged |= (_maxcount != value); _maxcount = value; RaisePropertyChanged("MaxCount"); }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public float Discount
		{
			get { return _discount; }
            set { _isChanged |= (_discount != value); _discount = value; RaisePropertyChanged("Discount"); }
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

                _isChanged |= (_createuser != value); _createuser = value; RaisePropertyChanged("CreateUser");
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateTime
		{
			get { return _createtime; }
            set { _isChanged |= (_createtime != value); _createtime = value; RaisePropertyChanged("CreateTime"); }
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

                _isChanged |= (_upduser != value); _upduser = value; RaisePropertyChanged("UpdUser");
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime UpdTime
		{
			get { return _updtime; }
            set { _isChanged |= (_updtime != value); _updtime = value; RaisePropertyChanged("UpdTime"); }
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