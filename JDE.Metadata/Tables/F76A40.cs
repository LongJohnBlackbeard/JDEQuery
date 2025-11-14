using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A40 - .
/// </summary>
public class F76A40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCA76TC.
        /// </summary>
        public const string WCA76TC = "WCA76TC";

        /// <summary>
        /// WCPYID.
        /// </summary>
        public const string WCPYID = "WCPYID";

        /// <summary>
        /// WCRC5.
        /// </summary>
        public const string WCRC5 = "WCRC5";

        /// <summary>
        /// WCA76NW.
        /// </summary>
        public const string WCA76NW = "WCA76NW";

        /// <summary>
        /// WCKCO.
        /// </summary>
        public const string WCKCO = "WCKCO";

        /// <summary>
        /// WCDCT.
        /// </summary>
        public const string WCDCT = "WCDCT";

        /// <summary>
        /// WCDOC.
        /// </summary>
        public const string WCDOC = "WCDOC";

        /// <summary>
        /// WCSFX.
        /// </summary>
        public const string WCSFX = "WCSFX";

        /// <summary>
        /// WCSFXE.
        /// </summary>
        public const string WCSFXE = "WCSFXE";

        /// <summary>
        /// WCA76WCN.
        /// </summary>
        public const string WCA76WCN = "WCA76WCN";

        /// <summary>
        /// WCA76BORB.
        /// </summary>
        public const string WCA76BORB = "WCA76BORB";

        /// <summary>
        /// WCA76AA.
        /// </summary>
        public const string WCA76AA = "WCA76AA";

        /// <summary>
        /// WCBCRC.
        /// </summary>
        public const string WCBCRC = "WCBCRC";

        /// <summary>
        /// WCCRCD.
        /// </summary>
        public const string WCCRCD = "WCCRCD";

        /// <summary>
        /// WCA76PN.
        /// </summary>
        public const string WCA76PN = "WCA76PN";

        /// <summary>
        /// WCA76ST.
        /// </summary>
        public const string WCA76ST = "WCA76ST";

        /// <summary>
        /// WCA76AT.
        /// </summary>
        public const string WCA76AT = "WCA76AT";

        /// <summary>
        /// WCPYE.
        /// </summary>
        public const string WCPYE = "WCPYE";

        /// <summary>
        /// WCA76PT.
        /// </summary>
        public const string WCA76PT = "WCA76PT";

        /// <summary>
        /// WCA76FRMC.
        /// </summary>
        public const string WCA76FRMC = "WCA76FRMC";

        /// <summary>
        /// WCA76TXLC.
        /// </summary>
        public const string WCA76TXLC = "WCA76TXLC";

        /// <summary>
        /// WCALGC.
        /// </summary>
        public const string WCALGC = "WCALGC";

        /// <summary>
        /// WCDMTJ.
        /// </summary>
        public const string WCDMTJ = "WCDMTJ";

        /// <summary>
        /// WCA76CED.
        /// </summary>
        public const string WCA76CED = "WCA76CED";

        /// <summary>
        /// WCA76ILC.
        /// </summary>
        public const string WCA76ILC = "WCA76ILC";

        /// <summary>
        /// WCA76WOCN.
        /// </summary>
        public const string WCA76WOCN = "WCA76WOCN";

        /// <summary>
        /// WCA76WT.
        /// </summary>
        public const string WCA76WT = "WCA76WT";

        /// <summary>
        /// WCA76WC.
        /// </summary>
        public const string WCA76WC = "WCA76WC";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCA76TC", "WCA76TC", JdeDataType.Numeric, null, true, true),
        new JdeField("WCPYID", "WCPYID", JdeDataType.Numeric),
        new JdeField("WCRC5", "WCRC5", JdeDataType.Numeric),
        new JdeField("WCA76NW", "WCA76NW", JdeDataType.String, 2),
        new JdeField("WCKCO", "WCKCO", JdeDataType.String, 10),
        new JdeField("WCDCT", "WCDCT", JdeDataType.String, 4),
        new JdeField("WCDOC", "WCDOC", JdeDataType.Numeric),
        new JdeField("WCSFX", "WCSFX", JdeDataType.String, 6),
        new JdeField("WCSFXE", "WCSFXE", JdeDataType.Numeric),
        new JdeField("WCA76WCN", "WCA76WCN", JdeDataType.String, 50),
        new JdeField("WCA76BORB", "WCA76BORB", JdeDataType.Numeric),
        new JdeField("WCA76AA", "WCA76AA", JdeDataType.Numeric),
        new JdeField("WCBCRC", "WCBCRC", JdeDataType.String, 6),
        new JdeField("WCCRCD", "WCCRCD", JdeDataType.String, 6),
        new JdeField("WCA76PN", "WCA76PN", JdeDataType.String, 12),
        new JdeField("WCA76ST", "WCA76ST", JdeDataType.String, 4),
        new JdeField("WCA76AT", "WCA76AT", JdeDataType.String, 40),
        new JdeField("WCPYE", "WCPYE", JdeDataType.Numeric),
        new JdeField("WCA76PT", "WCA76PT", JdeDataType.String, 40),
        new JdeField("WCA76FRMC", "WCA76FRMC", JdeDataType.String, 8),
        new JdeField("WCA76TXLC", "WCA76TXLC", JdeDataType.String, 6),
        new JdeField("WCALGC", "WCALGC", JdeDataType.String, 6),
        new JdeField("WCDMTJ", "WCDMTJ", JdeDataType.Numeric),
        new JdeField("WCA76CED", "WCA76CED", JdeDataType.Numeric),
        new JdeField("WCA76ILC", "WCA76ILC", JdeDataType.Numeric),
        new JdeField("WCA76WOCN", "WCA76WOCN", JdeDataType.String, 50),
        new JdeField("WCA76WT", "WCA76WT", JdeDataType.String, 4),
        new JdeField("WCA76WC", "WCA76WC", JdeDataType.String, 6),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A40_0", "Primary Key on WCA76TC", new[] { "WCA76TC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A40_2", "Index on WCPYID, WCRC5", new[] { "WCPYID", "WCRC5" }),
        new JdeIndex("F76A40_3", "Index on WCKCO, WCDCT, WCDOC", new[] { "WCKCO", "WCDCT", "WCDOC" }),
        new JdeIndex("F76A40_4", "Index on WCPYID, WCA76WC, WCA76WT", new[] { "WCPYID", "WCA76WC", "WCA76WT" }),
        new JdeIndex("F76A40_5", "Index on WCA76TC, WCA76WCN", new[] { "WCA76TC", "WCA76WCN" })
    };
}
