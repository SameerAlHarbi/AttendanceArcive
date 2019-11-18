namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMP_TRANS_DTL
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TDID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TMID { get; set; }

        public DateTime? TDDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TDOPERATION { get; set; }

        public DateTime TDSTART { get; set; }

        public DateTime TDEND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESID { get; set; }

        [StringLength(100)]
        public string ESCODE { get; set; }

        [StringLength(100)]
        public string ESNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESISNIGHT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESALLOW_START { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESALLOW_END { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EDID { get; set; }

        [StringLength(100)]
        public string EDNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EDPERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ERID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XTID { get; set; }

        [StringLength(100)]
        public string XTCODE { get; set; }

        [StringLength(100)]
        public string XTNAME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ERPERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ERNON_CALC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDIN_TRID { get; set; }

        public DateTime? TDPUNCH_IN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDOUT_TRID { get; set; }

        public DateTime? TDPUNCH_OUT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDEARLY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDLATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDSTATUS { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDTOTAL_ABSENT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDTOTAL_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDTOTAL_PERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDCALC_PERIOD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESALLOW_CROSS_PUNCH { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESMAX_BEFORE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESMAX_AFTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESOT_BEFORE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESOT_AFTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ERDEDUCT_WORK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ERCALC_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESCALC_GAPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESCALC_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESGAPS_START { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDSHIFT_OT_BEFORE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDSHIFT_OT_AFTER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDTOTAL_GAPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TDNOTIFY_DELAY { get; set; }

        public virtual TBL_EMP_TRANS_MST TBL_EMP_TRANS_MST { get; set; }
    }
}
