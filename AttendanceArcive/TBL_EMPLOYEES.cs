namespace AttendanceArcive
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_EMPLOYEES
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EPID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DPID { get; set; }

        [Required]
        [StringLength(100)]
        public string EPCODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EPNAME { get; set; }

        public DateTime? EPJOIN_DATE { get; set; }

        public DateTime? EPBIRTH_DATE { get; set; }

        [StringLength(100)]
        public string EPNATIONALITY { get; set; }

        [StringLength(100)]
        public string EPJOB { get; set; }

        [StringLength(100)]
        public string EPNATIONAL_ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EPSTATUS { get; set; }

        [Column(TypeName = "image")]
        public byte[] EPPHOTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPACTIVE { get; set; }

        public DateTime SYS_DATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_USER { get; set; }

        public DateTime? SYS_UPDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SYS_EDIT { get; set; }

        [StringLength(100)]
        public string EPPHONE { get; set; }

        [StringLength(100)]
        public string EPMOBILE { get; set; }

        [StringLength(100)]
        public string EPEMAIL { get; set; }

        [Column(TypeName = "text")]
        public string EPADDRESS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_SAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_SUN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_MON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_TUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_WED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_THS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_OD_FRI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_WEB_ACTIVE { get; set; }

        [StringLength(100)]
        public string EP_WEB_USER { get; set; }

        [StringLength(100)]
        public string EP_WEB_PASS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EP_NOTIFICATION { get; set; }
    }
}
