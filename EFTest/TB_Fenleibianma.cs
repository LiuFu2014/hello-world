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
    
    public partial class TB_Fenleibianma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Fenleibianma()
        {
            this.TB_Components = new HashSet<TB_Components>();
            this.TB_Supplier = new HashSet<TB_Supplier>();
        }
    
        public string Fenleibianma { get; set; }
        public string Fenleimingchen { get; set; }
        public int Edit { get; set; }
        public System.DateTime EditTime { get; set; }
        public int Class { get; set; }
        public string Remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Components> TB_Components { get; set; }
        public virtual TB_User TB_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Supplier> TB_Supplier { get; set; }
    }
}
