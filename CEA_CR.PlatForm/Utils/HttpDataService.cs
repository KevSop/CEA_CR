using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CEA_CR.PlatForm.Utils
{
    public class HttpDataService
    {
        public List<CurrentCourseResponse> GetCurrentCourse(string classRoomId)
        {
            List<CurrentCourseResponse> result = new List<CurrentCourseResponse>();

            #region 测试数据
            result.Add(new CurrentCourseResponse { classId = "1", className = "2", courseId = "3", courseName = "4", time = "5" });
            result.Add(new CurrentCourseResponse { classId = "11", className = "22", courseId = "33", courseName = "44", time = "55" });
            return result;
            #endregion

            string cacheKey = string.Format("course:{0}", classRoomId);
            result = CacheHelper.CacheManager.Get<List<CurrentCourseResponse>>(cacheKey);
            if (result == null)
            {
                string responseJson = HttpHelper.GetHttpResponse(string.Format(ConfigStatic.GetCurrentCourseUrl, ConfigStatic.userName, ConfigStatic.password, classRoomId));

                if (true)
                {
                    result = JsonConvert.DeserializeObject<List<CurrentCourseResponse>>(responseJson);
                }
                else
                {
                    using (StringReader rdr = new StringReader(responseJson))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CurrentCourseResponse>));
                        result = (List<CurrentCourseResponse>)serializer.Deserialize(rdr);
                    }
                }

                CacheHelper.CacheManager.Set(cacheKey, result, 10);
            }
            return result;

        }
        public List<CourseScheduleResponse> GetCourseSchedule(string identityCard, string month, string userType, string pageNumber)
        {
            List<CourseScheduleResponse> result = new List<CourseScheduleResponse>();
            #region 测试数据
            result.Add(new CourseScheduleResponse { classId = "1", className = "2", courseId = "3", courseName = "4", place = "5", t_date = "6", time = "7" });
            result.Add(new CourseScheduleResponse { classId = "11", className = "22", courseId = "33", courseName = "44", place = "55", t_date = "66", time = "77" });
            return result;
            #endregion

            string cacheKey = string.Format("schedule:{0}-{1}-{2}", identityCard, month, userType);
            result = CacheHelper.CacheManager.Get<List<CourseScheduleResponse>>(cacheKey);
            if (result == null)
            {
                string responseJson = HttpHelper.GetHttpResponse(string.Format(ConfigStatic.GetCourseScheduleUrl, ConfigStatic.userName, ConfigStatic.password, identityCard, month, userType, pageNumber));
                if (true)
                {

                    result = JsonConvert.DeserializeObject<List<CourseScheduleResponse>>(responseJson);
                }
                else
                {
                    using (StringReader rdr = new StringReader(responseJson))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CourseScheduleResponse>));
                        result = (List<CourseScheduleResponse>)serializer.Deserialize(rdr);
                    }

                }
                CacheHelper.CacheManager.Set(cacheKey, result, 10);
            }
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
