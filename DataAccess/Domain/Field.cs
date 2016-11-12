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
	public sealed class Field
	{
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private string _key; 
		private string _name; 
		private long _isvalidate; 
		private long _canedit; 
		private string _remark; 
		private string _createuser; 
		private DateTime _createtime; 
		private string _upduser; 
		private DateTime _updtime; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public Field()
		{
			_id = 0; 
			_key = null; 
			_name = null; 
			_isvalidate = 0; 
			_canedit = 0; 
			_remark = null; 
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
		public string Key
		{
			get { return _key; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Key", value, value.ToString());
				
				_isChanged |= (_key != value); _key = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Name
		{
			get { return _name; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				
				_isChanged |= (_name != value); _name = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long IsValidate
		{
			get { return _isvalidate; }
			set { _isChanged |= (_isvalidate != value); _isvalidate = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long CanEdit
		{
			get { return _canedit; }
			set { _isChanged |= (_canedit != value); _canedit = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Remark
		{
			get { return _remark; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Remark", value, value.ToString());
				
				_isChanged |= (_remark != value); _remark = value;
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
