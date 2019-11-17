namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMP_VACATION
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EVID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VTID { get; set; }

        public DateTime EVFROM { get; set; }

        public DateTime EVTO { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [Column(TypeName = "text")]
        public string EVDESC { get; set; }
    }
}
