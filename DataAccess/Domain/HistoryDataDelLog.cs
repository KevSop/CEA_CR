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
	public sealed class HistoryDataDelLog
	{
		#region Private Members
		private bool _isChanged;
		private bool _isDeleted;
		private long _id; 
		private DateTime _starttime; 
		private DateTime _endtime; 
		private long _isdelorderdata; 
		private long _isdelsystemlog; 
		private long _isdelpaydata; 
		private string _operuser; 
		private DateTime _opertime; 
		private string _remark; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public HistoryDataDelLog()
		{
			_id = 0; 
			_starttime = new DateTime(); 
			_endtime = new DateTime(); 
			_isdelorderdata = 0; 
			_isdelsystemlog = 0; 
			_isdelpaydata = 0; 
			_operuser = null; 
			_opertime = new DateTime(); 
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
		public DateTime StartTime
		{
			get { return _starttime; }
			set { _isChanged |= (_starttime != value); _starttime = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime EndTime
		{
			get { return _endtime; }
			set { _isChanged |= (_endtime != value); _endtime = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long IsDelOrderData
		{
			get { return _isdelorderdata; }
			set { _isChanged |= (_isdelorderdata != value); _isdelorderdata = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long IsDelSystemLog
		{
			get { return _isdelsystemlog; }
			set { _isChanged |= (_isdelsystemlog != value); _isdelsystemlog = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public long IsDelPayData
		{
			get { return _isdelpaydata; }
			set { _isChanged |= (_isdelpaydata != value); _isdelpaydata = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string OperUser
		{
			get { return _operuser; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for OperUser", value, value.ToString());
				
				_isChanged |= (_operuser != value); _operuser = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime OperTime
		{
			get { return _opertime; }
			set { _isChanged |= (_opertime != value); _opertime = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Remark
		{
			get { return _remark; }
			set	
			{
				if( value!= null && value.Length > 100)
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