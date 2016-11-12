using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class R_CashierCheckReport : NotificationObject
    {
        public string UserNo
        {
            get;
            set;
        }
        public string LoginName
        {
            get;
            set;
        }
       
        public float PayMoney
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
