using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEA_CR.Data.Entity
{
    /// <summary>
    /// 用户对象
    /// </summary>
    [Table("ClassRoomInfo")]
    public class ClassRoomInfo
    {
        public int ClassRoomID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Type { get; set; }
        public int SeatNum { get; set; }
        public string Remark { get; set; }
        public int Valid { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateBy { get; set; }
    }
}
