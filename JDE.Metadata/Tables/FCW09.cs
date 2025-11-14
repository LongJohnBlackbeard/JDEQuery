using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW09 - .
/// </summary>
public class FCW09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WRC9ITM.
        /// </summary>
        public const string WRC9ITM = "WRC9ITM";

        /// <summary>
        /// WREV01.
        /// </summary>
        public const string WREV01 = "WREV01";

        /// <summary>
        /// WRLITM.
        /// </summary>
        public const string WRLITM = "WRLITM";

        /// <summary>
        /// WRAITM.
        /// </summary>
        public const string WRAITM = "WRAITM";

        /// <summary>
        /// WRDSC1.
        /// </summary>
        public const string WRDSC1 = "WRDSC1";

        /// <summary>
        /// WRDSC2.
        /// </summary>
        public const string WRDSC2 = "WRDSC2";

        /// <summary>
        /// WRSRTX.
        /// </summary>
        public const string WRSRTX = "WRSRTX";

        /// <summary>
        /// WRSTKT.
        /// </summary>
        public const string WRSTKT = "WRSTKT";

        /// <summary>
        /// WRGLPT.
        /// </summary>
        public const string WRGLPT = "WRGLPT";

        /// <summary>
        /// WRLNTY.
        /// </summary>
        public const string WRLNTY = "WRLNTY";

        /// <summary>
        /// WRBPFG.
        /// </summary>
        public const string WRBPFG = "WRBPFG";

        /// <summary>
        /// WRANPL.
        /// </summary>
        public const string WRANPL = "WRANPL";

        /// <summary>
        /// WRBUYR.
        /// </summary>
        public const string WRBUYR = "WRBUYR";

        /// <summary>
        /// WRSRNR.
        /// </summary>
        public const string WRSRNR = "WRSRNR";

        /// <summary>
        /// WRBACK.
        /// </summary>
        public const string WRBACK = "WRBACK";

        /// <summary>
        /// WRCKAV.
        /// </summary>
        public const string WRCKAV = "WRCKAV";

        /// <summary>
        /// WRCLEV.
        /// </summary>
        public const string WRCLEV = "WRCLEV";

        /// <summary>
        /// WRPLEV.
        /// </summary>
        public const string WRPLEV = "WRPLEV";

        /// <summary>
        /// WRPPLV.
        /// </summary>
        public const string WRPPLV = "WRPPLV";

        /// <summary>
        /// WRPMTH.
        /// </summary>
        public const string WRPMTH = "WRPMTH";

        /// <summary>
        /// WRLOTS.
        /// </summary>
        public const string WRLOTS = "WRLOTS";

        /// <summary>
        /// WRSRCE.
        /// </summary>
        public const string WRSRCE = "WRSRCE";

        /// <summary>
        /// WRCMGL.
        /// </summary>
        public const string WRCMGL = "WRCMGL";

        /// <summary>
        /// WRINMG.
        /// </summary>
        public const string WRINMG = "WRINMG";

        /// <summary>
        /// WRIFLA.
        /// </summary>
        public const string WRIFLA = "WRIFLA";

        /// <summary>
        /// WRTFLA.
        /// </summary>
        public const string WRTFLA = "WRTFLA";

        /// <summary>
        /// WRPRGR.
        /// </summary>
        public const string WRPRGR = "WRPRGR";

        /// <summary>
        /// WRRPRC.
        /// </summary>
        public const string WRRPRC = "WRRPRC";

        /// <summary>
        /// WRORPR.
        /// </summary>
        public const string WRORPR = "WRORPR";

        /// <summary>
        /// WRSLD.
        /// </summary>
        public const string WRSLD = "WRSLD";

        /// <summary>
        /// WRDSGP.
        /// </summary>
        public const string WRDSGP = "WRDSGP";

        /// <summary>
        /// WRABCS.
        /// </summary>
        public const string WRABCS = "WRABCS";

        /// <summary>
        /// WRABCM.
        /// </summary>
        public const string WRABCM = "WRABCM";

        /// <summary>
        /// WRABCI.
        /// </summary>
        public const string WRABCI = "WRABCI";

        /// <summary>
        /// WRUOM1.
        /// </summary>
        public const string WRUOM1 = "WRUOM1";

        /// <summary>
        /// WRUOM2.
        /// </summary>
        public const string WRUOM2 = "WRUOM2";

        /// <summary>
        /// WRUOM3.
        /// </summary>
        public const string WRUOM3 = "WRUOM3";

        /// <summary>
        /// WRUOM4.
        /// </summary>
        public const string WRUOM4 = "WRUOM4";

        /// <summary>
        /// WRUOM6.
        /// </summary>
        public const string WRUOM6 = "WRUOM6";

        /// <summary>
        /// WRUOM8.
        /// </summary>
        public const string WRUOM8 = "WRUOM8";

        /// <summary>
        /// WRUOM9.
        /// </summary>
        public const string WRUOM9 = "WRUOM9";

        /// <summary>
        /// WRUWUM.
        /// </summary>
        public const string WRUWUM = "WRUWUM";

        /// <summary>
        /// WRUVM1.
        /// </summary>
        public const string WRUVM1 = "WRUVM1";

        /// <summary>
        /// WRCMETH.
        /// </summary>
        public const string WRCMETH = "WRCMETH";

        /// <summary>
        /// WRXDCK.
        /// </summary>
        public const string WRXDCK = "WRXDCK";

        /// <summary>
        /// WRDUAL.
        /// </summary>
        public const string WRDUAL = "WRDUAL";

        /// <summary>
        /// WRDPPO.
        /// </summary>
        public const string WRDPPO = "WRDPPO";

        /// <summary>
        /// WRDLTL.
        /// </summary>
        public const string WRDLTL = "WRDLTL";

        /// <summary>
        /// WRCMDM.
        /// </summary>
        public const string WRCMDM = "WRCMDM";

        /// <summary>
        /// WRLECM.
        /// </summary>
        public const string WRLECM = "WRLECM";

        /// <summary>
        /// WRBBDD.
        /// </summary>
        public const string WRBBDD = "WRBBDD";

        /// <summary>
        /// WRSBDD.
        /// </summary>
        public const string WRSBDD = "WRSBDD";

        /// <summary>
        /// WRLEDD.
        /// </summary>
        public const string WRLEDD = "WRLEDD";

        /// <summary>
        /// WRPEFD.
        /// </summary>
        public const string WRPEFD = "WRPEFD";

        /// <summary>
        /// WRU1DD.
        /// </summary>
        public const string WRU1DD = "WRU1DD";

        /// <summary>
        /// WRU2DD.
        /// </summary>
        public const string WRU2DD = "WRU2DD";

        /// <summary>
        /// WRU3DD.
        /// </summary>
        public const string WRU3DD = "WRU3DD";

        /// <summary>
        /// WRU4DD.
        /// </summary>
        public const string WRU4DD = "WRU4DD";

        /// <summary>
        /// WRU5DD.
        /// </summary>
        public const string WRU5DD = "WRU5DD";

        /// <summary>
        /// WRSCPSELL.
        /// </summary>
        public const string WRSCPSELL = "WRSCPSELL";

        /// <summary>
        /// WRAPSC.
        /// </summary>
        public const string WRAPSC = "WRAPSC";

        /// <summary>
        /// WRCOORE.
        /// </summary>
        public const string WRCOORE = "WRCOORE";

        /// <summary>
        /// WRPNYN.
        /// </summary>
        public const string WRPNYN = "WRPNYN";
    }

    /// <inheritdoc />
    public override string TableName => "FCW09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WRC9ITM", "WRC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WREV01", "WREV01", JdeDataType.String, 2, true, true),
        new JdeField("WRLITM", "WRLITM", JdeDataType.String, 50),
        new JdeField("WRAITM", "WRAITM", JdeDataType.String, 50),
        new JdeField("WRDSC1", "WRDSC1", JdeDataType.String, 60),
        new JdeField("WRDSC2", "WRDSC2", JdeDataType.String, 60),
        new JdeField("WRSRTX", "WRSRTX", JdeDataType.String, 60),
        new JdeField("WRSTKT", "WRSTKT", JdeDataType.String, 2),
        new JdeField("WRGLPT", "WRGLPT", JdeDataType.String, 8),
        new JdeField("WRLNTY", "WRLNTY", JdeDataType.String, 4),
        new JdeField("WRBPFG", "WRBPFG", JdeDataType.String, 2),
        new JdeField("WRANPL", "WRANPL", JdeDataType.Numeric),
        new JdeField("WRBUYR", "WRBUYR", JdeDataType.Numeric),
        new JdeField("WRSRNR", "WRSRNR", JdeDataType.String, 2),
        new JdeField("WRBACK", "WRBACK", JdeDataType.String, 2),
        new JdeField("WRCKAV", "WRCKAV", JdeDataType.String, 2),
        new JdeField("WRCLEV", "WRCLEV", JdeDataType.String, 2),
        new JdeField("WRPLEV", "WRPLEV", JdeDataType.String, 2),
        new JdeField("WRPPLV", "WRPPLV", JdeDataType.String, 2),
        new JdeField("WRPMTH", "WRPMTH", JdeDataType.String, 2),
        new JdeField("WRLOTS", "WRLOTS", JdeDataType.String, 2),
        new JdeField("WRSRCE", "WRSRCE", JdeDataType.String, 2),
        new JdeField("WRCMGL", "WRCMGL", JdeDataType.String, 2),
        new JdeField("WRINMG", "WRINMG", JdeDataType.String, 20),
        new JdeField("WRIFLA", "WRIFLA", JdeDataType.String, 4),
        new JdeField("WRTFLA", "WRTFLA", JdeDataType.String, 4),
        new JdeField("WRPRGR", "WRPRGR", JdeDataType.String, 16),
        new JdeField("WRRPRC", "WRRPRC", JdeDataType.String, 16),
        new JdeField("WRORPR", "WRORPR", JdeDataType.String, 16),
        new JdeField("WRSLD", "WRSLD", JdeDataType.Numeric),
        new JdeField("WRDSGP", "WRDSGP", JdeDataType.String, 6),
        new JdeField("WRABCS", "WRABCS", JdeDataType.String, 2),
        new JdeField("WRABCM", "WRABCM", JdeDataType.String, 2),
        new JdeField("WRABCI", "WRABCI", JdeDataType.String, 2),
        new JdeField("WRUOM1", "WRUOM1", JdeDataType.String, 4),
        new JdeField("WRUOM2", "WRUOM2", JdeDataType.String, 4),
        new JdeField("WRUOM3", "WRUOM3", JdeDataType.String, 4),
        new JdeField("WRUOM4", "WRUOM4", JdeDataType.String, 4),
        new JdeField("WRUOM6", "WRUOM6", JdeDataType.String, 4),
        new JdeField("WRUOM8", "WRUOM8", JdeDataType.String, 4),
        new JdeField("WRUOM9", "WRUOM9", JdeDataType.String, 4),
        new JdeField("WRUWUM", "WRUWUM", JdeDataType.String, 4),
        new JdeField("WRUVM1", "WRUVM1", JdeDataType.String, 4),
        new JdeField("WRCMETH", "WRCMETH", JdeDataType.String, 2),
        new JdeField("WRXDCK", "WRXDCK", JdeDataType.String, 2),
        new JdeField("WRDUAL", "WRDUAL", JdeDataType.String, 2),
        new JdeField("WRDPPO", "WRDPPO", JdeDataType.String, 2),
        new JdeField("WRDLTL", "WRDLTL", JdeDataType.Numeric),
        new JdeField("WRCMDM", "WRCMDM", JdeDataType.String, 2),
        new JdeField("WRLECM", "WRLECM", JdeDataType.String, 2),
        new JdeField("WRBBDD", "WRBBDD", JdeDataType.Numeric),
        new JdeField("WRSBDD", "WRSBDD", JdeDataType.Numeric),
        new JdeField("WRLEDD", "WRLEDD", JdeDataType.Numeric),
        new JdeField("WRPEFD", "WRPEFD", JdeDataType.Numeric),
        new JdeField("WRU1DD", "WRU1DD", JdeDataType.Numeric),
        new JdeField("WRU2DD", "WRU2DD", JdeDataType.Numeric),
        new JdeField("WRU3DD", "WRU3DD", JdeDataType.Numeric),
        new JdeField("WRU4DD", "WRU4DD", JdeDataType.Numeric),
        new JdeField("WRU5DD", "WRU5DD", JdeDataType.Numeric),
        new JdeField("WRSCPSELL", "WRSCPSELL", JdeDataType.String, 2),
        new JdeField("WRAPSC", "WRAPSC", JdeDataType.String, 2),
        new JdeField("WRCOORE", "WRCOORE", JdeDataType.String, 2),
        new JdeField("WRPNYN", "WRPNYN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW09_0", "Primary Key on WRC9ITM, WREV01", new[] { "WRC9ITM", "WREV01" }, isUnique: true, isPrimaryKey: true)
    };
}
