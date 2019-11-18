namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_HOLIDAYS
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal HOID { get; set; }

        [Required]
        [StringLength(3)]
        public string HOCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string HONAME { get; set; }

        public DateTime HOSTART { get; set; }

        public DateTime HOEND { get; set; }

        [Column(TypeName = "text")]
        public string HODESC { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }
    }
}
