//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_UserLoginRight
    {
        public int ID { get; set; }
        public int SecondWorkStationID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> IsUse { get; set; }
        public string Type { get; set; }
    
        public virtual TB_SecondWorkStationInfo TB_SecondWorkStationInfo { get; set; }
        public virtual TB_User TB_User { get; set; }
    }
}
