namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMP_DUTY
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EDID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPID { get; set; }

        [Required]
        [StringLength(100)]
        public string EDNAME { get; set; }

        [Column(TypeName = "text")]
        public string EDDESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EDTYPE { get; set; }

        public DateTime? EDFROM { get; set; }

        public DateTime? EDTO { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EDCODE { get; set; }
    }
}
