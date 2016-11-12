using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using System.ComponentModel;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using System.Collections.ObjectModel;
using System.Collections;
using System.Xml.Linq;
using CEA_CR.Data.Entity;
using CEA_CR.PlatForm.Utils;

namespace CEA_CR.PlatForm.Models
{
    //原始库里的对象转换成前台要看的对象
    public class ClassRoomInfoVModel : NotificationObject
    {
        public ClassRoomInfo tbClassRoomInfo { get; set; }
        public string CourseName { get; set; }

        public string TeacherName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    //页面对象
    public class ClassRoomInfoPageModel : ObservableCollection<ClassRoomInfoVModel>
    {
        private static object _threadLock = new Object();

        private static ClassRoomInfoPageModel _classRoomInfoPageModelInstance = null;
        public static ClassRoomInfoPageModel classRoomInfoPageModelInstance
        {
            get
            {
                lock (_threadLock)
                    if (_classRoomInfoPageModelInstance == null)
                        _classRoomInfoPageModelInstance = new ClassRoomInfoPageModel();
                return _classRoomInfoPageModelInstance;
            }
        }

        public ClassRoomInfoPageModel()
        {
            List<ClassRoomInfoVModel> list = new List<ClassRoomInfoVModel>();
            //此处查询所有 Mark todo
            for (int i = 1; i < 101; i++)
            {
                list.Add(new ClassRoomInfoVModel { CourseName = "课程" + i.ToString(), StartTime = "2016-10-10 09:00", EndTime = "2016-10-10 11:00", TeacherName = "老师" + i.ToString(), tbClassRoomInfo = new ClassRoomInfo { Name = "教室" + i.ToString() } });

            }
            ResetData(list);
        }

        //这里注入所有数据
        public void ResetData(List<ClassRoomInfoVModel> list)
        {
            ClearItems();
            foreach (var item in list)
            {
                Add(item);
            }
        }
    }
}
