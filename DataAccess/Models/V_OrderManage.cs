using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using System.Collections;

namespace DataAccess.Models
{
    public class V_OrderManage : NotificationObject
    {
        
        public string V_Phone
        {
            get;
            set;
        }
        public string V_CardNo
        {
            get;
            set;
        }
        public Decimal V_AvgPayMoney
        {
            get;
            set;
        }
        public int V_ID
        {
            get;
            set;
        }
        public string V_ConsumerName
        {
            get;
            set;
        }
        public string  V_SeatNumber
        {
            get;
            set;
        }
        public int V_TotalTime
        {
            get;
            set;
        }
        public int V_SuccessedTime
        {
            get;
            set;
        }
        public int V_CancelTime
        {
            get;
            set;
        }
        public int V_MobileTime
        {
            get;
            set;
        }
        public Decimal V_PayMoney
        {
            get;
            set;
        }
        public DateTime V_FirstOrderTime
        {
            get;
            set;
        }
        public DateTime V_LastOrderTime
        {
            get;
            set;
        }

       
    }
}
