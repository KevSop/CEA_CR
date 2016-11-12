using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CEA_CR.PlatForm.Utils
{
    public class HttpDataService
    {
        public List<CurrentCourseResponse> GetCurrentCourse(string classRoomId)
        {
            List<CurrentCourseResponse> result = new List<CurrentCourseResponse>();
            string responseJson = HttpHelper.GetHttpResponse(string.Format(ConfigStatic.GetCurrentCourseUrl, ConfigStatic.userName, ConfigStatic.password, classRoomId));
            result = JsonConvert.DeserializeObject<List<CurrentCourseResponse>>(responseJson);
            return result;
        }
        public List<CourseScheduleResponse> GetCourseSchedule(string identityCard, string month, string userType, string pageNumber)
        {
            List<CourseScheduleResponse> result = new List<CourseScheduleResponse>();
            string responseJson = HttpHelper.GetHttpResponse(string.Format(ConfigStatic.GetCourseScheduleUrl, ConfigStatic.userName, ConfigStatic.password, identityCard, month, userType, pageNumber));
            result = JsonConvert.DeserializeObject<List<CourseScheduleResponse>>(responseJson);
            return result;
        }
    }

    public class CurrentCourseResponse
    {
        public string courseId { get; set; }
        public string courseName { get; set; }
        public string classId { get; set; }
        public string className { get; set; }
        public string time { get; set; }
    }

    public class CourseScheduleResponse
    {
        public string t_date { get; set; }
        public string courseId { get; set; }
        public string courseName { get; set; }
        public string classId { get; set; }
        public string className { get; set; }
        public string time { get; set; }
        public string place { get; set; }
    }
}
