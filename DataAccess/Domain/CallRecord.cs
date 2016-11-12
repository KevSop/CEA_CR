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
	public sealed class CallRecord
	{
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private string _telno; 
		private string _teltype; 
		private string _createuser; 
		private DateTime _createtime; 
		private string _remark; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public CallRecord()
		{
			_id = 0; 
			_telno = null; 
			_teltype = null; 
			_createuser = null; 
			_createtime = new DateTime(); 
			_remark = null; 
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
		public string TelNo
		{
			get { return _telno; }
			set	
			{
				if( value!= null && value.Length > 11)
					throw new ArgumentOutOfRangeException("Invalid value for TelNo", value, value.ToString());
				
				_isChanged |= (_telno != value); _telno = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string TelType
		{
			get { return _teltype; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for TelType", value, value.ToString());
				
				_isChanged |= (_teltype != value); _teltype = value;
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
		public string Remark
		{
			get { return _remark; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Remark", value, value.ToString());
				
				_isChanged |= (_remark != value); _remark = value;
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
