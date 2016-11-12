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
    [Table("TeacherInfo")]
    public class TeacherInfo
    {
        public int TeacherID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }

        public string PositionID { get; set; }

        public string PositionName { get; set; }

        public string Sex { get; set; }

        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Valid { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateBy { get; set; }
    }
}
