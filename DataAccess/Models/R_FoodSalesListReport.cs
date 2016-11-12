using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class R_FoodSalesListReport : NotificationObject
    {

        public string MenuCode
        {
            get;
            set;
        }
        public string MenuName
        {
            get;
            set;
        }

        public string SaleUnit
        {
            get;
            set;
        }

        public long SendCount
        {
            get;
            set;
        }

        public float MenuPrice
        {
            get;
            set;
        }
         public float PayMoney
        {
            get;
            set;
        }
    }
}
