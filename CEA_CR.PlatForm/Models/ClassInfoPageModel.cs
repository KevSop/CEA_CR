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
    public class ClassInfoVModel : NotificationObject
    {
        public ClassInfo tbClassInfo { get; set; }

        public string ClassRoom { get; set; }

        public string TeacherName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    //页面对象
    public class ClassInfoPageModel : ObservableCollection<ClassInfoVModel>
    {
        private static object _threadLock = new Object();

        private static ClassInfoPageModel _classInfoPageModelInstance = null;
        public static ClassInfoPageModel classInfoPageModelInstance
        {
            get
            {
                lock (_threadLock)
                    if (_classInfoPageModelInstance == null)
                        _classInfoPageModelInstance = new ClassInfoPageModel();
                return _classInfoPageModelInstance;
            }
        }

        public ClassInfoPageModel()
        {
            List<ClassInfoVModel> list = new List<ClassInfoVModel>();
            for (int i = 1; i < 101; i++)
            {
                list.Add(new ClassInfoVModel { ClassRoom = "教室" + i.ToString(), StartTime = "2016-10-10 09:00", EndTime = "2016-10-10 11:00", TeacherName = "老师" + i.ToString(), tbClassInfo = new ClassInfo { Name = "课程" + i.ToString() } });

            }
            ResetData(list);
        }

        //这里注入所有数据
        public void ResetData(List<ClassInfoVModel> list)
        {
            ClearItems();
            foreach (var item in list)
            {
                Add(item);
            }
        }
    }
}
