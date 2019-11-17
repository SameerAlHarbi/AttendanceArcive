namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_DEPARTMENTS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal DPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DPPARENT_TYP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DPPARENT { get; set; }

        [Required]
        [StringLength(3)]
        public string DPCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DPNAME { get; set; }

        [Column(TypeName = "text")]
        public string DPDEC { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WGID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SUID { get; set; }
    }
}
