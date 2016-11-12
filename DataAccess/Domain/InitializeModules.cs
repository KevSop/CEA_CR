/*
insert license info here
*/
using System;

namespace DataAccess.Domain
{
	/// <summary>
	///	Generated by MyGeneration using the IBatis Object Mapping template
	/// </summary>
	[Serializable]
	public sealed class InitializeModules
	{
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private string _initializeid; 
		private string _moduleno; 
		private long _isenable; 
		private string _createuser; 
		private DateTime _createtime; 
		private string _upduser; 
		private DateTime _updtime; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public InitializeModules()
		{
			_id = 0; 
			_initializeid = null; 
			_moduleno = null; 
			_isenable = 0; 
			_createuser = null; 
			_createtime = new DateTime(); 
			_upduser = null; 
			_updtime = new DateTime(); 
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
		public string Initializeid
		{
			get { return _initializeid; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for Initializeid", value, value.ToString());
				
				_isChanged |= (_initializeid != value); _initializeid = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ModuleNo
		{
			get { return _moduleno; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for ModuleNo", value, value.ToString());
				
				_isChanged |= (_moduleno != value); _moduleno = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long IsEnable
		{
			get { return _isenable; }
			set { _isChanged |= (_isenable != value); _isenable = value; }
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