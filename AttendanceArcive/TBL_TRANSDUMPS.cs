namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_TRANSDUMPS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRID { get; set; }

        public DateTime TRDATE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREMP_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TRTYPE { get; set; }

        [StringLength(100)]
        public string TRMCH_ID { get; set; }

        [StringLength(100)]
        public string TRMCH_DESC { get; set; }

        public DateTime? ENT_SYSDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TRSTAUS { get; set; }

        public DateTime? TRACTION_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRACTIVE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRENTRY_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRLINK_ID { get; set; }

        [StringLength(100)]
        public string TRDESC { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TMID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OriginalSourceTransactionId { get; set; }
    }
}
