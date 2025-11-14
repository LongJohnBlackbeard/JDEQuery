using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B16 - .
/// </summary>
public class F03B16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVAN8.
        /// </summary>
        public const string RVAN8 = "RVAN8";

        /// <summary>
        /// RVCO.
        /// </summary>
        public const string RVCO = "RVCO";

        /// <summary>
        /// RVCTRY.
        /// </summary>
        public const string RVCTRY = "RVCTRY";

        /// <summary>
        /// RVFY.
        /// </summary>
        public const string RVFY = "RVFY";

        /// <summary>
        /// RVPN.
        /// </summary>
        public const string RVPN = "RVPN";

        /// <summary>
        /// RVEND.
        /// </summary>
        public const string RVEND = "RVEND";

        /// <summary>
        /// RVDAYP.
        /// </summary>
        public const string RVDAYP = "RVDAYP";

        /// <summary>
        /// RVENBL.
        /// </summary>
        public const string RVENBL = "RVENBL";

        /// <summary>
        /// RVDLBL.
        /// </summary>
        public const string RVDLBL = "RVDLBL";

        /// <summary>
        /// RVAHB.
        /// </summary>
        public const string RVAHB = "RVAHB";

        /// <summary>
        /// RVDHBJ.
        /// </summary>
        public const string RVDHBJ = "RVDHBJ";

        /// <summary>
        /// RVDSO.
        /// </summary>
        public const string RVDSO = "RVDSO";

        /// <summary>
        /// RVBDSO.
        /// </summary>
        public const string RVBDSO = "RVBDSO";

        /// <summary>
        /// RVDDSO.
        /// </summary>
        public const string RVDDSO = "RVDDSO";

        /// <summary>
        /// RVAVDL.
        /// </summary>
        public const string RVAVDL = "RVAVDL";

        /// <summary>
        /// RVAVDN.
        /// </summary>
        public const string RVAVDN = "RVAVDN";

        /// <summary>
        /// RVAG.
        /// </summary>
        public const string RVAG = "RVAG";

        /// <summary>
        /// RVNINV.
        /// </summary>
        public const string RVNINV = "RVNINV";

        /// <summary>
        /// RVSAG.
        /// </summary>
        public const string RVSAG = "RVSAG";

        /// <summary>
        /// RVCREE.
        /// </summary>
        public const string RVCREE = "RVCREE";

        /// <summary>
        /// RVADSC.
        /// </summary>
        public const string RVADSC = "RVADSC";

        /// <summary>
        /// RVDFEE.
        /// </summary>
        public const string RVDFEE = "RVDFEE";

        /// <summary>
        /// RVECBA.
        /// </summary>
        public const string RVECBA = "RVECBA";

        /// <summary>
        /// RVNCB.
        /// </summary>
        public const string RVNCB = "RVNCB";

        /// <summary>
        /// RVPAAP.
        /// </summary>
        public const string RVPAAP = "RVPAAP";

        /// <summary>
        /// RVADSA.
        /// </summary>
        public const string RVADSA = "RVADSA";

        /// <summary>
        /// RVEDSC.
        /// </summary>
        public const string RVEDSC = "RVEDSC";

        /// <summary>
        /// RVUDSC.
        /// </summary>
        public const string RVUDSC = "RVUDSC";

        /// <summary>
        /// RVNINP.
        /// </summary>
        public const string RVNINP = "RVNINP";

        /// <summary>
        /// RVAIPL.
        /// </summary>
        public const string RVAIPL = "RVAIPL";

        /// <summary>
        /// RVNIPL.
        /// </summary>
        public const string RVNIPL = "RVNIPL";

        /// <summary>
        /// RVDDCA.
        /// </summary>
        public const string RVDDCA = "RVDDCA";

        /// <summary>
        /// RVDDCN.
        /// </summary>
        public const string RVDDCN = "RVDDCN";

        /// <summary>
        /// RVMWO.
        /// </summary>
        public const string RVMWO = "RVMWO";

        /// <summary>
        /// RVTAWO.
        /// </summary>
        public const string RVTAWO = "RVTAWO";

        /// <summary>
        /// RVBDBT.
        /// </summary>
        public const string RVBDBT = "RVBDBT";

        /// <summary>
        /// RVANSF.
        /// </summary>
        public const string RVANSF = "RVANSF";

        /// <summary>
        /// RVNNSF.
        /// </summary>
        public const string RVNNSF = "RVNNSF";

        /// <summary>
        /// RVRHB.
        /// </summary>
        public const string RVRHB = "RVRHB";

        /// <summary>
        /// RVCLMG.
        /// </summary>
        public const string RVCLMG = "RVCLMG";

        /// <summary>
        /// RVCMGR.
        /// </summary>
        public const string RVCMGR = "RVCMGR";

        /// <summary>
        /// RVRBAL.
        /// </summary>
        public const string RVRBAL = "RVRBAL";

        /// <summary>
        /// RVCRCD.
        /// </summary>
        public const string RVCRCD = "RVCRCD";

        /// <summary>
        /// RVFTR.
        /// </summary>
        public const string RVFTR = "RVFTR";

        /// <summary>
        /// RVCURR.
        /// </summary>
        public const string RVCURR = "RVCURR";

        /// <summary>
        /// RVAG1.
        /// </summary>
        public const string RVAG1 = "RVAG1";

        /// <summary>
        /// RVAG2.
        /// </summary>
        public const string RVAG2 = "RVAG2";

        /// <summary>
        /// RVAG3.
        /// </summary>
        public const string RVAG3 = "RVAG3";

        /// <summary>
        /// RVAG4.
        /// </summary>
        public const string RVAG4 = "RVAG4";

        /// <summary>
        /// RVAG5.
        /// </summary>
        public const string RVAG5 = "RVAG5";

        /// <summary>
        /// RVAG6.
        /// </summary>
        public const string RVAG6 = "RVAG6";

        /// <summary>
        /// RVAG7.
        /// </summary>
        public const string RVAG7 = "RVAG7";

        /// <summary>
        /// RVCHGA.
        /// </summary>
        public const string RVCHGA = "RVCHGA";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVUPMT.
        /// </summary>
        public const string RVUPMT = "RVUPMT";

        /// <summary>
        /// RVJOBN.
        /// </summary>
        public const string RVJOBN = "RVJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVAN8", "RVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RVCO", "RVCO", JdeDataType.String, 10, true, true),
        new JdeField("RVCTRY", "RVCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("RVFY", "RVFY", JdeDataType.Numeric, null, true, true),
        new JdeField("RVPN", "RVPN", JdeDataType.Numeric, null, true, true),
        new JdeField("RVEND", "RVEND", JdeDataType.Numeric),
        new JdeField("RVDAYP", "RVDAYP", JdeDataType.Numeric),
        new JdeField("RVENBL", "RVENBL", JdeDataType.Numeric),
        new JdeField("RVDLBL", "RVDLBL", JdeDataType.Numeric),
        new JdeField("RVAHB", "RVAHB", JdeDataType.Numeric),
        new JdeField("RVDHBJ", "RVDHBJ", JdeDataType.Numeric),
        new JdeField("RVDSO", "RVDSO", JdeDataType.Numeric),
        new JdeField("RVBDSO", "RVBDSO", JdeDataType.Numeric),
        new JdeField("RVDDSO", "RVDDSO", JdeDataType.Numeric),
        new JdeField("RVAVDL", "RVAVDL", JdeDataType.Numeric),
        new JdeField("RVAVDN", "RVAVDN", JdeDataType.Numeric),
        new JdeField("RVAG", "RVAG", JdeDataType.Numeric),
        new JdeField("RVNINV", "RVNINV", JdeDataType.Numeric),
        new JdeField("RVSAG", "RVSAG", JdeDataType.Numeric),
        new JdeField("RVCREE", "RVCREE", JdeDataType.Numeric),
        new JdeField("RVADSC", "RVADSC", JdeDataType.Numeric),
        new JdeField("RVDFEE", "RVDFEE", JdeDataType.Numeric),
        new JdeField("RVECBA", "RVECBA", JdeDataType.Numeric),
        new JdeField("RVNCB", "RVNCB", JdeDataType.Numeric),
        new JdeField("RVPAAP", "RVPAAP", JdeDataType.Numeric),
        new JdeField("RVADSA", "RVADSA", JdeDataType.Numeric),
        new JdeField("RVEDSC", "RVEDSC", JdeDataType.Numeric),
        new JdeField("RVUDSC", "RVUDSC", JdeDataType.Numeric),
        new JdeField("RVNINP", "RVNINP", JdeDataType.Numeric),
        new JdeField("RVAIPL", "RVAIPL", JdeDataType.Numeric),
        new JdeField("RVNIPL", "RVNIPL", JdeDataType.Numeric),
        new JdeField("RVDDCA", "RVDDCA", JdeDataType.Numeric),
        new JdeField("RVDDCN", "RVDDCN", JdeDataType.Numeric),
        new JdeField("RVMWO", "RVMWO", JdeDataType.Numeric),
        new JdeField("RVTAWO", "RVTAWO", JdeDataType.Numeric),
        new JdeField("RVBDBT", "RVBDBT", JdeDataType.Numeric),
        new JdeField("RVANSF", "RVANSF", JdeDataType.Numeric),
        new JdeField("RVNNSF", "RVNNSF", JdeDataType.Numeric),
        new JdeField("RVRHB", "RVRHB", JdeDataType.String, 2),
        new JdeField("RVCLMG", "RVCLMG", JdeDataType.String, 20),
        new JdeField("RVCMGR", "RVCMGR", JdeDataType.String, 20),
        new JdeField("RVRBAL", "RVRBAL", JdeDataType.String, 2),
        new JdeField("RVCRCD", "RVCRCD", JdeDataType.String, 6),
        new JdeField("RVFTR", "RVFTR", JdeDataType.Numeric),
        new JdeField("RVCURR", "RVCURR", JdeDataType.Numeric),
        new JdeField("RVAG1", "RVAG1", JdeDataType.Numeric),
        new JdeField("RVAG2", "RVAG2", JdeDataType.Numeric),
        new JdeField("RVAG3", "RVAG3", JdeDataType.Numeric),
        new JdeField("RVAG4", "RVAG4", JdeDataType.Numeric),
        new JdeField("RVAG5", "RVAG5", JdeDataType.Numeric),
        new JdeField("RVAG6", "RVAG6", JdeDataType.Numeric),
        new JdeField("RVAG7", "RVAG7", JdeDataType.Numeric),
        new JdeField("RVCHGA", "RVCHGA", JdeDataType.Numeric),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVUPMT", "RVUPMT", JdeDataType.Numeric),
        new JdeField("RVJOBN", "RVJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B16_0", "Primary Key on RVAN8, RVCO, RVCTRY, RVFY, RVPN", new[] { "RVAN8", "RVCO", "RVCTRY", "RVFY", "RVPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B16_2", "Index on RVAN8, RVCO, SYS_NC00059$, SYS_NC00060$, SYS_NC00061$", new[] { "RVAN8", "RVCO", "SYS_NC00059$", "SYS_NC00060$", "SYS_NC00061$" }),
        new JdeIndex("F03B16_3", "Index on RVRHB", new[] { "RVRHB" }),
        new JdeIndex("F03B16_4", "Index on RVRBAL", new[] { "RVRBAL" })
    };
}
