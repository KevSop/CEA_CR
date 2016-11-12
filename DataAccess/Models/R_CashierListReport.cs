using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class R_CashierListReport : NotificationObject
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
        public float Pay_Money
        {
            get;
            set;
        }

        public float Pay_Card
        {
            get;
            set;
        }
    }
}
