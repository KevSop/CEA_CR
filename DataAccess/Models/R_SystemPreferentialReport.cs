using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class R_SystemPreferentialReport : NotificationObject
    {
        public string LoginName
        {
            get;
            set;
        }
        public string OrdersNo
        {
            get;
            set;
        }
        public DateTime CreateTime
        {
            get;
            set;
        }
        
        public string SeatNo
        {
            get;
            set;
        }
        public float TotalMoney
        {
            get;
            set;
        }

        public float DiscountMoney
        {
            get;
            set;
        }
    }


}
