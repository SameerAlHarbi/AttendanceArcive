namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_VAC_TYPE
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal VTID { get; set; }

        [Required]
        [StringLength(3)]
        public string VTCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string VTNAME { get; set; }

        [Column(TypeName = "text")]
        public string VTDESC { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }
    }
}
