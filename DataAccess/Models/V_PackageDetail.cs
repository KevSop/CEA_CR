using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace DataAccess.Models
{
  public  class V_PackageDetail: NotificationObject
    {
        private string detailNo;

        public string DetailNo
        {
            get { return detailNo; }
            set { detailNo = value; }
        }
        private string packageNo;

        public string PackageNo
        {
            get { return packageNo; }
            set { packageNo = value; }
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
        private string menuNo;

        public string MenuNo
        {
            get { return menuNo; }
            set { menuNo = value; }
        }
        private long menuCount;

        public long MenuCount
        {
            get { return menuCount; }
            set { menuCount = value; }
        }
        private string menuType;

        public string MenuType
        {
            get { return menuType; }
            set { menuType = value; }
        }  
        
    }
}
