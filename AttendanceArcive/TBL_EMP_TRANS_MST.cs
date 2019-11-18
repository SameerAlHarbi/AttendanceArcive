namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMP_TRANS_MST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_EMP_TRANS_MST()
        {
            TBL_EMP_TRANS_DTL = new HashSet<TBL_EMP_TRANS_DTL>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TMID { get; set; }

        public DateTime TMDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DPID { get; set; }

        [StringLength(100)]
        public string EPCODE { get; set; }

        [StringLength(100)]
        public string EPNOUSED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HOID { get; set; }

        [StringLength(100)]
        public string HOCODE { get; set; }

        [StringLength(100)]
        public string HONAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EVID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VTID { get; set; }

        [StringLength(100)]
        public string VTCODE { get; set; }

        [StringLength(100)]
        public string VTNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EOID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EOISPERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EOMAX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EDID { get; set; }

        [StringLength(100)]
        public string EDNAME { get; set; }

        public DateTime? ENT_SYSDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMSTATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMSHIFT_PERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_WORK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_DUTY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_EXCUSE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMCALC_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_GAPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMCALC_ABSENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMEARLY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMLATE { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMTOTAL_ABSENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EPIS_OFFDAY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMNO_CALC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMFULLDAY_ABSENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_EMP_TRANS_DTL> TBL_EMP_TRANS_DTL { get; set; }
    }
}
