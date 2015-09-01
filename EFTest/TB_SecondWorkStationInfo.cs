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
    
    public partial class TB_SecondWorkStationInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SecondWorkStationInfo()
        {
            this.TB_LoginRecord = new HashSet<TB_LoginRecord>();
            this.TB_PLCBaseAdressInfo = new HashSet<TB_PLCBaseAdressInfo>();
            this.TB_QCRecord = new HashSet<TB_QCRecord>();
            this.TB_ScanRecord = new HashSet<TB_ScanRecord>();
            this.TB_UserLoginRight = new HashSet<TB_UserLoginRight>();
            this.TB_WorkDtl = new HashSet<TB_WorkDtl>();
            this.TB_WorkDtlForEachStation = new HashSet<TB_WorkDtlForEachStation>();
            this.TB_WorkException = new HashSet<TB_WorkException>();
            this.TB_WorkMain = new HashSet<TB_WorkMain>();
            this.TB_WorkMain1 = new HashSet<TB_WorkMain>();
            this.TB_WorkTime = new HashSet<TB_WorkTime>();
            this.TB_WorkTimeBandingInfo = new HashSet<TB_WorkTimeBandingInfo>();
        }
    
        public int ID { get; set; }
        public string SecondWorkStationName { get; set; }
        public string SecondWorkStationCode { get; set; }
        public bool IsUse { get; set; }
        public string WorkStationCode { get; set; }
        public Nullable<int> WorkStationID { get; set; }
        public Nullable<int> No { get; set; }
        public Nullable<int> NoInStopper { get; set; }
        public string AdressCode { get; set; }
        public Nullable<int> AdressID { get; set; }
        public string WorkeTimePerClass { get; set; }
        public string NumberClassPerDay { get; set; }
        public string WorkStationStatus { get; set; }
        public string Remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_LoginRecord> TB_LoginRecord { get; set; }
        public virtual TB_PLCAdressWithWorkStationInfo TB_PLCAdressWithWorkStationInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PLCBaseAdressInfo> TB_PLCBaseAdressInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_QCRecord> TB_QCRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ScanRecord> TB_ScanRecord { get; set; }
        public virtual TB_WorkStationInfo TB_WorkStationInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_UserLoginRight> TB_UserLoginRight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkDtl> TB_WorkDtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkDtlForEachStation> TB_WorkDtlForEachStation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkException> TB_WorkException { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkMain> TB_WorkMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkMain> TB_WorkMain1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkTime> TB_WorkTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkTimeBandingInfo> TB_WorkTimeBandingInfo { get; set; }
    }
}
