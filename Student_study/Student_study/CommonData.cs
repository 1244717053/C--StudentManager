using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_study
{
    /// <summary>
    /// 这个类用来存放公共的参数
    /// </summary>
    public static class CommonData
    {
        // 公共参数1,这句话其实可以加到 App.config中去
        public static string SqlName = @"Server=DESKTOP-SSPDAG1;Database=studentDB;Trusted_Connection=True;"; //windows验证

        // 公共参数2，获取年级信息
        public static DataTable GradeInfo = new DataTable();
    }
}
