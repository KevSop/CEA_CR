using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
    public class V_MenuReplace : NotificationObject
    {
        private string mDetailNo;

        public string MDetailNo
        {
            get { return mDetailNo; }
            set { mDetailNo = value; }
        }
        private string packageNo;

        public string PackageNo
        {
            get { return packageNo; }
            set { packageNo = value; }
        }
        private string replaceNo;

        public string ReplaceNo
        {
            get { return replaceNo; }
            set { replaceNo = value; }
        }

        private string menuName;

        public string MenuName
        {
            get { return menuName; }
            set { menuName = value; }
        }

        private float salePrice;

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

    }
}
