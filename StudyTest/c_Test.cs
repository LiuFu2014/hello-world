using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTest
{
    class c_Test
    {
        #region 属性和字段

        public double doubletest { get; set; }
        public string stringtest { get; set; }
        //int inttest;

        #endregion

        #region 方法

        public void Test1() 
        {
            doubletest = 2.0;
            stringtest = "hello";
        }

        public string Test2(string a)
        {
            return a;
        }

        #endregion
    }
}
