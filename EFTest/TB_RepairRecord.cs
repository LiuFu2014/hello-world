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
    
    public partial class TB_RepairRecord
    {
        public int ID { get; set; }
        public int WorkDtlID { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public bool IsScrap { get; set; }
        public Nullable<int> ExceptionID { get; set; }
        public string Remark { get; set; }
    
        public virtual TB_Exception TB_Exception { get; set; }
        public virtual TB_User TB_User { get; set; }
        public virtual TB_WorkDtl TB_WorkDtl { get; set; }
    }
}
