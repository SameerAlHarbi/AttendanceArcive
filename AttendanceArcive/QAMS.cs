namespace AttendanceArcive
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QAMS : DbContext
    {
        public QAMS()
            : base("name=QAMS")
        {
        }

        public virtual DbSet<TBL_DEPARTMENTS> TBL_DEPARTMENTS { get; set; }
        public virtual DbSet<TBL_EMP_DUTY> TBL_EMP_DUTY { get; set; }
        public virtual DbSet<TBL_EMP_SHIFT> TBL_EMP_SHIFT { get; set; }
        public virtual DbSet<TBL_EMP_TRANS_DTL> TBL_EMP_TRANS_DTL { get; set; }
        public virtual DbSet<TBL_EMP_TRANS_MST> TBL_EMP_TRANS_MST { get; set; }
        public virtual DbSet<TBL_EMP_VACATION> TBL_EMP_VACATION { get; set; }
        public virtual DbSet<TBL_EMPLOYEES> TBL_EMPLOYEES { get; set; }
        public virtual DbSet<TBL_HOLIDAYS> TBL_HOLIDAYS { get; set; }
        public virtual DbSet<TBL_TRANSDUMPS> TBL_TRANSDUMPS { get; set; }
        public virtual DbSet<TBL_VAC_TYPE> TBL_VAC_TYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPPARENT_TYP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPPARENT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.DPDEC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.WGID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_DEPARTMENTS>()
                .Property(e => e.SUID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EDID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EDDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EDTYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_DUTY>()
                .Property(e => e.EDCODE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESLENGTH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESISNIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESALLOW_START)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESALLOW_END)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESALLOW_CROSS_PUNCH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESMAX_BEFORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESMAX_AFTER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESOT_BEFORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESOT_AFTER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESCALC_GAPS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESCALC_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_SHIFT>()
                .Property(e => e.ESGAPS_START)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TMID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDOPERATION)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESISNIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESALLOW_START)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESALLOW_END)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.EDID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.EDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.EDPERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ERID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.XTID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.XTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.XTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ERPERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ERNON_CALC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDIN_TRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDOUT_TRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDEARLY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDLATE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDSTATUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDTOTAL_ABSENT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDTOTAL_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDTOTAL_PERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDCALC_PERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESALLOW_CROSS_PUNCH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESMAX_BEFORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESMAX_AFTER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESOT_BEFORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESOT_AFTER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ERDEDUCT_WORK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ERCALC_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESCALC_GAPS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESCALC_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.ESGAPS_START)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDSHIFT_OT_BEFORE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDSHIFT_OT_AFTER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDTOTAL_GAPS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_DTL>()
                .Property(e => e.TDNOTIFY_DELAY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.DPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EPNOUSED)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.HOID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.HOCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.HONAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EVID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.VTID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.VTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.VTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EOID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EOISPERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EOMAX)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EDID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMSTATUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMSHIFT_PERIOD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_WORK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_DUTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_EXCUSE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMCALC_OT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_GAPS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMCALC_ABSENT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMEARLY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMLATE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMTOTAL_ABSENT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.EPIS_OFFDAY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMNO_CALC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_TRANS_MST>()
                .Property(e => e.TMFULLDAY_ABSENT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.EVID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.VTID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMP_VACATION>()
                .Property(e => e.EVDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.DPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPNATIONALITY)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPJOB)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPNATIONAL_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPSTATUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPACTIVE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPPHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPMOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_SAT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_SUN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_MON)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_TUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_WED)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_THS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_OD_FRI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_WEB_ACTIVE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_WEB_USER)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_WEB_PASS)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_EMPLOYEES>()
                .Property(e => e.EP_NOTIFICATION)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.HOID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.HOCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.HONAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.HODESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_HOLIDAYS>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TREMP_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRTYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRMCH_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRMCH_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRSTAUS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.EPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRACTIVE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRENTRY_TYPE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRLINK_ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TRDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.TMID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.DPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_TRANSDUMPS>()
                .Property(e => e.OriginalSourceTransactionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.VTID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.VTCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.VTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.VTDESC)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.SYS_USER)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TBL_VAC_TYPE>()
                .Property(e => e.SYS_EDIT)
                .HasPrecision(18, 0);
        }
    }
}
