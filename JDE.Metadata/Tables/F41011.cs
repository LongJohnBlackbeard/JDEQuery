using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41011 - .
/// </summary>
public class F41011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PKITM.
        /// </summary>
        public const string PKITM = "PKITM";

        /// <summary>
        /// PKPDGR.
        /// </summary>
        public const string PKPDGR = "PKPDGR";

        /// <summary>
        /// PKDSGP.
        /// </summary>
        public const string PKDSGP = "PKDSGP";

        /// <summary>
        /// PKDNTB.
        /// </summary>
        public const string PKDNTB = "PKDNTB";

        /// <summary>
        /// PKSTCN.
        /// </summary>
        public const string PKSTCN = "PKSTCN";

        /// <summary>
        /// PKRPTM.
        /// </summary>
        public const string PKRPTM = "PKRPTM";

        /// <summary>
        /// PKRQTC.
        /// </summary>
        public const string PKRQTC = "PKRQTC";

        /// <summary>
        /// PKLPGP.
        /// </summary>
        public const string PKLPGP = "PKLPGP";

        /// <summary>
        /// PKCAVP.
        /// </summary>
        public const string PKCAVP = "PKCAVP";

        /// <summary>
        /// PKDNTY.
        /// </summary>
        public const string PKDNTY = "PKDNTY";

        /// <summary>
        /// PKDNTP.
        /// </summary>
        public const string PKDNTP = "PKDNTP";

        /// <summary>
        /// PKDETP.
        /// </summary>
        public const string PKDETP = "PKDETP";

        /// <summary>
        /// PKDTPU.
        /// </summary>
        public const string PKDTPU = "PKDTPU";

        /// <summary>
        /// PKCOEX.
        /// </summary>
        public const string PKCOEX = "PKCOEX";

        /// <summary>
        /// PKTMMN.
        /// </summary>
        public const string PKTMMN = "PKTMMN";

        /// <summary>
        /// PKTPUM.
        /// </summary>
        public const string PKTPUM = "PKTPUM";

        /// <summary>
        /// PKTMMX.
        /// </summary>
        public const string PKTMMX = "PKTMMX";

        /// <summary>
        /// PKTPUX.
        /// </summary>
        public const string PKTPUX = "PKTPUX";

        /// <summary>
        /// PKDSMN.
        /// </summary>
        public const string PKDSMN = "PKDSMN";

        /// <summary>
        /// PKDNTM.
        /// </summary>
        public const string PKDNTM = "PKDNTM";

        /// <summary>
        /// PKDNMX.
        /// </summary>
        public const string PKDNMX = "PKDNMX";

        /// <summary>
        /// PKDNTX.
        /// </summary>
        public const string PKDNTX = "PKDNTX";

        /// <summary>
        /// PKLPGV.
        /// </summary>
        public const string PKLPGV = "PKLPGV";

        /// <summary>
        /// PKTPU1.
        /// </summary>
        public const string PKTPU1 = "PKTPU1";

        /// <summary>
        /// PKMNVC.
        /// </summary>
        public const string PKMNVC = "PKMNVC";

        /// <summary>
        /// PKMXVC.
        /// </summary>
        public const string PKMXVC = "PKMXVC";

        /// <summary>
        /// PKURCD.
        /// </summary>
        public const string PKURCD = "PKURCD";

        /// <summary>
        /// PKURAT.
        /// </summary>
        public const string PKURAT = "PKURAT";

        /// <summary>
        /// PKURAB.
        /// </summary>
        public const string PKURAB = "PKURAB";

        /// <summary>
        /// PKURRF.
        /// </summary>
        public const string PKURRF = "PKURRF";

        /// <summary>
        /// PKURDT.
        /// </summary>
        public const string PKURDT = "PKURDT";

        /// <summary>
        /// PKUSER.
        /// </summary>
        public const string PKUSER = "PKUSER";

        /// <summary>
        /// PKPID.
        /// </summary>
        public const string PKPID = "PKPID";

        /// <summary>
        /// PKJOBN.
        /// </summary>
        public const string PKJOBN = "PKJOBN";

        /// <summary>
        /// PKUPMJ.
        /// </summary>
        public const string PKUPMJ = "PKUPMJ";

        /// <summary>
        /// PKTDAY.
        /// </summary>
        public const string PKTDAY = "PKTDAY";

        /// <summary>
        /// PKRTOB.
        /// </summary>
        public const string PKRTOB = "PKRTOB";
    }

    /// <inheritdoc />
    public override string TableName => "F41011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PKITM", "PKITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PKPDGR", "PKPDGR", JdeDataType.String, 6),
        new JdeField("PKDSGP", "PKDSGP", JdeDataType.String, 6),
        new JdeField("PKDNTB", "PKDNTB", JdeDataType.String, 8),
        new JdeField("PKSTCN", "PKSTCN", JdeDataType.String, 8),
        new JdeField("PKRPTM", "PKRPTM", JdeDataType.String, 8),
        new JdeField("PKRQTC", "PKRQTC", JdeDataType.String, 2),
        new JdeField("PKLPGP", "PKLPGP", JdeDataType.String, 2),
        new JdeField("PKCAVP", "PKCAVP", JdeDataType.String, 2),
        new JdeField("PKDNTY", "PKDNTY", JdeDataType.Numeric),
        new JdeField("PKDNTP", "PKDNTP", JdeDataType.String, 2),
        new JdeField("PKDETP", "PKDETP", JdeDataType.Numeric),
        new JdeField("PKDTPU", "PKDTPU", JdeDataType.String, 2),
        new JdeField("PKCOEX", "PKCOEX", JdeDataType.Numeric),
        new JdeField("PKTMMN", "PKTMMN", JdeDataType.Numeric),
        new JdeField("PKTPUM", "PKTPUM", JdeDataType.String, 2),
        new JdeField("PKTMMX", "PKTMMX", JdeDataType.Numeric),
        new JdeField("PKTPUX", "PKTPUX", JdeDataType.String, 2),
        new JdeField("PKDSMN", "PKDSMN", JdeDataType.Numeric),
        new JdeField("PKDNTM", "PKDNTM", JdeDataType.String, 2),
        new JdeField("PKDNMX", "PKDNMX", JdeDataType.Numeric),
        new JdeField("PKDNTX", "PKDNTX", JdeDataType.String, 2),
        new JdeField("PKLPGV", "PKLPGV", JdeDataType.Numeric),
        new JdeField("PKTPU1", "PKTPU1", JdeDataType.String, 2),
        new JdeField("PKMNVC", "PKMNVC", JdeDataType.Numeric),
        new JdeField("PKMXVC", "PKMXVC", JdeDataType.Numeric),
        new JdeField("PKURCD", "PKURCD", JdeDataType.String, 4),
        new JdeField("PKURAT", "PKURAT", JdeDataType.Numeric),
        new JdeField("PKURAB", "PKURAB", JdeDataType.Numeric),
        new JdeField("PKURRF", "PKURRF", JdeDataType.String, 30),
        new JdeField("PKURDT", "PKURDT", JdeDataType.Numeric),
        new JdeField("PKUSER", "PKUSER", JdeDataType.String, 20),
        new JdeField("PKPID", "PKPID", JdeDataType.String, 20),
        new JdeField("PKJOBN", "PKJOBN", JdeDataType.String, 20),
        new JdeField("PKUPMJ", "PKUPMJ", JdeDataType.Numeric),
        new JdeField("PKTDAY", "PKTDAY", JdeDataType.Numeric),
        new JdeField("PKRTOB", "PKRTOB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41011_0", "Primary Key on PKITM", new[] { "PKITM" }, isUnique: true, isPrimaryKey: true)
    };
}
