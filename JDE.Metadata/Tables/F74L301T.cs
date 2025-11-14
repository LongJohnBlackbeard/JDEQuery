using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L301T - .
/// </summary>
public class F74L301T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LHKCO.
        /// </summary>
        public const string LHKCO = "LHKCO";

        /// <summary>
        /// LHDCT.
        /// </summary>
        public const string LHDCT = "LHDCT";

        /// <summary>
        /// LHDOC.
        /// </summary>
        public const string LHDOC = "LHDOC";

        /// <summary>
        /// LHL74ATCUD.
        /// </summary>
        public const string LHL74ATCUD = "LHL74ATCUD";

        /// <summary>
        /// LHK70QRCD.
        /// </summary>
        public const string LHK70QRCD = "LHK70QRCD";

        /// <summary>
        /// LHUSER.
        /// </summary>
        public const string LHUSER = "LHUSER";

        /// <summary>
        /// LHPID.
        /// </summary>
        public const string LHPID = "LHPID";

        /// <summary>
        /// LHJOBN.
        /// </summary>
        public const string LHJOBN = "LHJOBN";

        /// <summary>
        /// LHUPMJ.
        /// </summary>
        public const string LHUPMJ = "LHUPMJ";

        /// <summary>
        /// LHUPMT.
        /// </summary>
        public const string LHUPMT = "LHUPMT";

        /// <summary>
        /// LHYFUTDT.
        /// </summary>
        public const string LHYFUTDT = "LHYFUTDT";

        /// <summary>
        /// LHFFU4.
        /// </summary>
        public const string LHFFU4 = "LHFFU4";

        /// <summary>
        /// LHFUT3.
        /// </summary>
        public const string LHFUT3 = "LHFUT3";

        /// <summary>
        /// LHX2.
        /// </summary>
        public const string LHX2 = "LHX2";

        /// <summary>
        /// LHFUTCH1.
        /// </summary>
        public const string LHFUTCH1 = "LHFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F74L301T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LHKCO", "LHKCO", JdeDataType.String, 10, true, true),
        new JdeField("LHDCT", "LHDCT", JdeDataType.String, 4, true, true),
        new JdeField("LHDOC", "LHDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LHL74ATCUD", "LHL74ATCUD", JdeDataType.String, 140),
        new JdeField("LHK70QRCD", "LHK70QRCD", JdeDataType.String, 2400),
        new JdeField("LHUSER", "LHUSER", JdeDataType.String, 20),
        new JdeField("LHPID", "LHPID", JdeDataType.String, 20),
        new JdeField("LHJOBN", "LHJOBN", JdeDataType.String, 20),
        new JdeField("LHUPMJ", "LHUPMJ", JdeDataType.Numeric),
        new JdeField("LHUPMT", "LHUPMT", JdeDataType.Numeric),
        new JdeField("LHYFUTDT", "LHYFUTDT", JdeDataType.Numeric),
        new JdeField("LHFFU4", "LHFFU4", JdeDataType.Numeric),
        new JdeField("LHFUT3", "LHFUT3", JdeDataType.String, 60),
        new JdeField("LHX2", "LHX2", JdeDataType.String, 2),
        new JdeField("LHFUTCH1", "LHFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L301T_0", "Primary Key on LHKCO, LHDCT, LHDOC", new[] { "LHKCO", "LHDCT", "LHDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
