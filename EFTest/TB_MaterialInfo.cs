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
    
    public partial class TB_MaterialInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MaterialInfo()
        {
            this.TB_ProductionPlan = new HashSet<TB_ProductionPlan>();
            this.TB_ProductionPlanFromERP = new HashSet<TB_ProductionPlanFromERP>();
            this.TB_WorkDtl = new HashSet<TB_WorkDtl>();
            this.TB_WorkTime = new HashSet<TB_WorkTime>();
        }
    
        public string TypeCode { get; set; }
        public string MaterialName { get; set; }
        public int ProcessRouteMID { get; set; }
        public int WorkTimeMConn { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public bool Audit { get; set; }
        public Nullable<int> AuditEditor { get; set; }
        public byte[] Photo { get; set; }
        public string Dinghuobianhao { get; set; }
        public string Peitaochuangjia { get; set; }
        public string Zhusai { get; set; }
        public string Chuyoufa { get; set; }
        public string Yuxingcheng { get; set; }
        public string Mohehouzhuangbenggai { get; set; }
        public string Shiyantaitiaoshi { get; set; }
        public string Zhuanghuiyoudiancifa { get; set; }
        public string Zhuangfujian { get; set; }
        public string Remark { get; set; }
        public string BQMohehouzhuanggaiban { get; set; }
        public string BQShuyoubeng { get; set; }
        public string BQShuyoubengzhijia { get; set; }
        public string BQZhuanghougaiban { get; set; }
        public string BQTingchelaxianzhijia { get; set; }
        public string BQShigaoyajinzuohumao { get; set; }
        public string Class { get; set; }
        public string Gongkuang1 { get; set; }
        public string Qiya1 { get; set; }
        public string Zhuangsu1 { get; set; }
        public string Pingjunyouliang1 { get; set; }
        public string Junyundu1 { get; set; }
        public string Neiya1 { get; set; }
        public string Tiqianxingcheng1 { get; set; }
        public string Huiyouliang1 { get; set; }
        public string BQCiganxingchen1 { get; set; }
        public string BQRemark1 { get; set; }
        public string Gongkuang2 { get; set; }
        public string Qiya2 { get; set; }
        public string Zhuangsu2 { get; set; }
        public string Pingjunyouliang2 { get; set; }
        public string Junyundu2 { get; set; }
        public string Neiya2 { get; set; }
        public string Tiqianxingcheng2 { get; set; }
        public string Huiyouliang2 { get; set; }
        public string BQCiganxingchen2 { get; set; }
        public string BQRemark2 { get; set; }
        public string Gongkuang3 { get; set; }
        public string Qiya3 { get; set; }
        public string Zhuangsu3 { get; set; }
        public string Pingjunyouliang3 { get; set; }
        public string Junyundu3 { get; set; }
        public string Neiya3 { get; set; }
        public string Tiqianxingcheng3 { get; set; }
        public string Huiyouliang3 { get; set; }
        public string BQCiganxingchen3 { get; set; }
        public string BQRemark3 { get; set; }
        public string Gongkuang4 { get; set; }
        public string Qiya4 { get; set; }
        public string Zhuangsu4 { get; set; }
        public string Pingjunyouliang4 { get; set; }
        public string Junyundu4 { get; set; }
        public string Neiya4 { get; set; }
        public string Tiqianxingcheng4 { get; set; }
        public string Huiyouliang4 { get; set; }
        public string BQCiganxingchen4 { get; set; }
        public string BQRemark4 { get; set; }
        public string Gongkuang5 { get; set; }
        public string Qiya5 { get; set; }
        public string Zhuangsu5 { get; set; }
        public string Pingjunyouliang5 { get; set; }
        public string Junyundu5 { get; set; }
        public string Neiya5 { get; set; }
        public string Tiqianxingcheng5 { get; set; }
        public string Huiyouliang5 { get; set; }
        public string BQCiganxingchen5 { get; set; }
        public string BQRemark5 { get; set; }
        public string Gongkuang6 { get; set; }
        public string Qiya6 { get; set; }
        public string Zhuangsu6 { get; set; }
        public string Pingjunyouliang6 { get; set; }
        public string Junyundu6 { get; set; }
        public string Neiya6 { get; set; }
        public string Tiqianxingcheng6 { get; set; }
        public string Huiyouliang6 { get; set; }
        public string BQCiganxingchen6 { get; set; }
        public string BQRemark6 { get; set; }
        public string Gongkuang7 { get; set; }
        public string Qiya7 { get; set; }
        public string Zhuangsu7 { get; set; }
        public string Pingjunyouliang7 { get; set; }
        public string Junyundu7 { get; set; }
        public string Neiya7 { get; set; }
        public string Tiqianxingcheng7 { get; set; }
        public string Huiyouliang7 { get; set; }
        public string BQCiganxingchen7 { get; set; }
        public string BQRemark7 { get; set; }
        public string Gongkuang8 { get; set; }
        public string Qiya8 { get; set; }
        public string Zhuangsu8 { get; set; }
        public string Pingjunyouliang8 { get; set; }
        public string Junyundu8 { get; set; }
        public string Neiya8 { get; set; }
        public string Tiqianxingcheng8 { get; set; }
        public string Huiyouliang8 { get; set; }
        public string BQCiganxingchen8 { get; set; }
        public string BQRemark8 { get; set; }
        public string Gongkuang9 { get; set; }
        public string Qiya9 { get; set; }
        public string Zhuangsu9 { get; set; }
        public string Pingjunyouliang9 { get; set; }
        public string Junyundu9 { get; set; }
        public string Neiya9 { get; set; }
        public string Tiqianxingcheng9 { get; set; }
        public string Huiyouliang9 { get; set; }
        public string BQCiganxingchen9 { get; set; }
        public string BQRemark9 { get; set; }
        public string Gongkuang10 { get; set; }
        public string Qiya10 { get; set; }
        public string Zhuangsu10 { get; set; }
        public string Pingjunyouliang10 { get; set; }
        public string Junyundu10 { get; set; }
        public string Neiya10 { get; set; }
        public string Tiqianxingcheng10 { get; set; }
        public string Huiyouliang10 { get; set; }
        public string BQCiganxingchen10 { get; set; }
        public string BQRemark10 { get; set; }
        public string Gongkuang11 { get; set; }
        public string Qiya11 { get; set; }
        public string Zhuangsu11 { get; set; }
        public string Pingjunyouliang11 { get; set; }
        public string Junyundu11 { get; set; }
        public string Neiya11 { get; set; }
        public string Tiqianxingcheng11 { get; set; }
        public string Huiyouliang11 { get; set; }
        public string BQCiganxingchen11 { get; set; }
        public string BQRemark11 { get; set; }
        public string Gongkuang12 { get; set; }
        public string Qiya12 { get; set; }
        public string Zhuangsu12 { get; set; }
        public string Pingjunyouliang12 { get; set; }
        public string Junyundu12 { get; set; }
        public string Neiya12 { get; set; }
        public string Tiqianxingcheng12 { get; set; }
        public string Huiyouliang12 { get; set; }
        public string BQCiganxingchen12 { get; set; }
        public string BQRemark12 { get; set; }
        public string Gongkuang13 { get; set; }
        public string Qiya13 { get; set; }
        public string Zhuangsu13 { get; set; }
        public string Pingjunyouliang13 { get; set; }
        public string Junyundu13 { get; set; }
        public string Neiya13 { get; set; }
        public string Tiqianxingcheng13 { get; set; }
        public string Huiyouliang13 { get; set; }
        public string BQCiganxingchen13 { get; set; }
        public string BQRemark13 { get; set; }
        public string Gongkuang14 { get; set; }
        public string Qiya14 { get; set; }
        public string Zhuangsu14 { get; set; }
        public string Pingjunyouliang14 { get; set; }
        public string Junyundu14 { get; set; }
        public string Neiya14 { get; set; }
        public string Tiqianxingcheng14 { get; set; }
        public string Huiyouliang14 { get; set; }
        public string BQCiganxingchen14 { get; set; }
        public string BQRemark14 { get; set; }
        public string Gongkuang15 { get; set; }
        public string Qiya15 { get; set; }
        public string Zhuangsu15 { get; set; }
        public string Pingjunyouliang15 { get; set; }
        public string Junyundu15 { get; set; }
        public string Neiya15 { get; set; }
        public string Tiqianxingcheng15 { get; set; }
        public string Huiyouliang15 { get; set; }
        public string BQCiganxingchen15 { get; set; }
        public string BQRemark15 { get; set; }
        public string Gongkuang16 { get; set; }
        public string Qiya16 { get; set; }
        public string Zhuangsu16 { get; set; }
        public string Pingjunyouliang16 { get; set; }
        public string Junyundu16 { get; set; }
        public string Neiya16 { get; set; }
        public string Tiqianxingcheng16 { get; set; }
        public string Huiyouliang16 { get; set; }
        public string BQCiganxingchen16 { get; set; }
        public string BQRemark16 { get; set; }
        public string BQJiaozhengzhuangsu { get; set; }
        public Nullable<int> MatCommonConn { get; set; }
        public string Com3 { get; set; }
        public string Com4 { get; set; }
        public string Com5 { get; set; }
        public string Com6 { get; set; }
        public string Com7 { get; set; }
        public string Com8 { get; set; }
        public string Com9 { get; set; }
        public string Com10 { get; set; }
        public string Com11 { get; set; }
        public string Com12 { get; set; }
        public string Com13 { get; set; }
        public string Com14 { get; set; }
        public string Com15 { get; set; }
        public string Com16 { get; set; }
        public string Com17 { get; set; }
        public string Com18 { get; set; }
        public string Com19 { get; set; }
        public string Com20 { get; set; }
        public string Com21 { get; set; }
        public string Com22 { get; set; }
        public string Com23 { get; set; }
        public string Com24 { get; set; }
        public string Com25 { get; set; }
        public string Com26 { get; set; }
        public string Com27 { get; set; }
        public string Com28 { get; set; }
        public string Com29 { get; set; }
        public string Com30 { get; set; }
        public string Com31 { get; set; }
        public string Com32 { get; set; }
        public string Com33 { get; set; }
        public string Com34 { get; set; }
        public string Com35 { get; set; }
        public string Com36 { get; set; }
        public string Com37 { get; set; }
        public string Com38 { get; set; }
        public string Com39 { get; set; }
        public string Com40 { get; set; }
        public string Com41 { get; set; }
        public string Com42 { get; set; }
        public string Com43 { get; set; }
        public string Com44 { get; set; }
        public string Com45 { get; set; }
        public string Com46 { get; set; }
        public string Com47 { get; set; }
        public string Com48 { get; set; }
        public string Com49 { get; set; }
        public string Com50 { get; set; }
        public string Com51 { get; set; }
        public string Com52 { get; set; }
        public string Com53 { get; set; }
        public string Com54 { get; set; }
        public string Com55 { get; set; }
        public string Com56 { get; set; }
        public string Com57 { get; set; }
        public string Com58 { get; set; }
        public string Com59 { get; set; }
        public string Com60 { get; set; }
        public string Com61 { get; set; }
        public string Com62 { get; set; }
        public string Com63 { get; set; }
        public string Com64 { get; set; }
        public string Com65 { get; set; }
        public string Com66 { get; set; }
        public string Com67 { get; set; }
        public string Com68 { get; set; }
        public string Com69 { get; set; }
        public string Com70 { get; set; }
        public string Com71 { get; set; }
        public string Com72 { get; set; }
        public string Com73 { get; set; }
        public string Com74 { get; set; }
        public string Com75 { get; set; }
        public string Com76 { get; set; }
        public string Com77 { get; set; }
        public string Com78 { get; set; }
        public string Com79 { get; set; }
        public string Com80 { get; set; }
        public string Com81 { get; set; }
        public string Com82 { get; set; }
        public string Com83 { get; set; }
        public string Com84 { get; set; }
        public string Com85 { get; set; }
        public string Com86 { get; set; }
        public string Com87 { get; set; }
        public string Com88 { get; set; }
        public string Com89 { get; set; }
        public string Com90 { get; set; }
        public string Com91 { get; set; }
        public string Com92 { get; set; }
        public string Com93 { get; set; }
        public string Com94 { get; set; }
        public string Com95 { get; set; }
        public string Com96 { get; set; }
        public string Com97 { get; set; }
        public string Com98 { get; set; }
        public string Com99 { get; set; }
        public string Com100 { get; set; }
        public string Com101 { get; set; }
        public string Com102 { get; set; }
        public string Com103 { get; set; }
        public string Com104 { get; set; }
        public string Com105 { get; set; }
        public string Com106 { get; set; }
        public string Com107 { get; set; }
        public string Com108 { get; set; }
        public string Com109 { get; set; }
        public string Com110 { get; set; }
        public string Com111 { get; set; }
        public string Com112 { get; set; }
        public string Com113 { get; set; }
        public string Com114 { get; set; }
        public string Com115 { get; set; }
        public string Com116 { get; set; }
        public string Com117 { get; set; }
        public string Com118 { get; set; }
        public string Com119 { get; set; }
        public string Com120 { get; set; }
        public string Com121 { get; set; }
        public string Com122 { get; set; }
        public string Com123 { get; set; }
        public string Com124 { get; set; }
        public string Com125 { get; set; }
        public string Com126 { get; set; }
        public string Com127 { get; set; }
        public string Com128 { get; set; }
        public string Com129 { get; set; }
        public byte[] ComImage1 { get; set; }
        public byte[] ComImage2 { get; set; }
        public byte[] ComImage3 { get; set; }
    
        public virtual TB_CommonTypeConfigM TB_CommonTypeConfigM { get; set; }
        public virtual TB_ProcessRouteM TB_ProcessRouteM { get; set; }
        public virtual TB_User TB_User { get; set; }
        public virtual TB_User TB_User1 { get; set; }
        public virtual TB_WorkTimeM TB_WorkTimeM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ProductionPlan> TB_ProductionPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ProductionPlanFromERP> TB_ProductionPlanFromERP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkDtl> TB_WorkDtl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_WorkTime> TB_WorkTime { get; set; }
    }
}
