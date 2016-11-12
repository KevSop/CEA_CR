using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class V_OrderManageName : NotificationObject
    {
   
        public int ComId
        {
            get;
            set;
        }
        public string OrderNo
        {
            get;
            set;
        }
        public string ConsumerNo
        {
            get;
            set;
        }
        public string ConsumerName
        {
            get;
            set;
        }
        public string OrderDate
        {
            get;
            set;
        }
        public string ReachTime
        {
            get;
            set;
        }
        public string KeepTime
        {
            get;
            set;
        }
        public string ReceiveTime
        {
            get;
            set;
        }
        public int PeopleCount
        {
            get;
            set;
        }
        public string SeatNumber
        {
            get;
            set;
        }
        public string OrderStatus
        {
            get;
            set;
        }

    }
}
