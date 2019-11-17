namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMP_SHIFT
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ESID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPID { get; set; }

        [Required]
        [StringLength(3)]
        public string ESCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ESNAME { get; set; }

        [Column(TypeName = "text")]
        public string ESDESC { get; set; }

        public DateTime ESSTART { get; set; }

        public DateTime ESEND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESLENGTH { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESISNIGHT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESALLOW_START { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESALLOW_END { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

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
        public decimal? ESCALC_GAPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESCALC_OT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESGAPS_START { get; set; }
    }
}
