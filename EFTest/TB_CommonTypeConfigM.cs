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
    
    public partial class TB_CommonTypeConfigM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CommonTypeConfigM()
        {
            this.TB_CommonTypeConfigS = new HashSet<TB_CommonTypeConfigS>();
            this.TB_MaterialInfo = new HashSet<TB_MaterialInfo>();
        }
    
        public int ID { get; set; }
        public string CommonTypeConfigName { get; set; }
        public string Remark { get; set; }
        public int Edit { get; set; }
        public System.DateTime EditTime { get; set; }
    
        public virtual TB_User TB_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CommonTypeConfigS> TB_CommonTypeConfigS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_MaterialInfo> TB_MaterialInfo { get; set; }
    }
}
