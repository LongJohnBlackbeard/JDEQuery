using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05105 - .
/// </summary>
public class F05105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSSGTYP.
        /// </summary>
        public const string GSSGTYP = "GSSGTYP";

        /// <summary>
        /// GSCMPE.
        /// </summary>
        public const string GSCMPE = "GSCMPE";

        /// <summary>
        /// GSCMPC.
        /// </summary>
        public const string GSCMPC = "GSCMPC";

        /// <summary>
        /// GSSGTXT.
        /// </summary>
        public const string GSSGTXT = "GSSGTXT";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSOTPS.
        /// </summary>
        public const string GSOTPS = "GSOTPS";

        /// <summary>
        /// GSORMCU.
        /// </summary>
        public const string GSORMCU = "GSORMCU";

        /// <summary>
        /// GSJBCD.
        /// </summary>
        public const string GSJBCD = "GSJBCD";

        /// <summary>
        /// GSJBST.
        /// </summary>
        public const string GSJBST = "GSJBST";

        /// <summary>
        /// GSJCC.
        /// </summary>
        public const string GSJCC = "GSJCC";

        /// <summary>
        /// GSSGID.
        /// </summary>
        public const string GSSGID = "GSSGID";
    }

    /// <inheritdoc />
    public override string TableName => "F05105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSSGTYP", "GSSGTYP", JdeDataType.String, 8),
        new JdeField("GSCMPE", "GSCMPE", JdeDataType.String, 6),
        new JdeField("GSCMPC", "GSCMPC", JdeDataType.String, 20),
        new JdeField("GSSGTXT", "GSSGTXT", JdeDataType.String, 1000),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSOTPS", "GSOTPS", JdeDataType.String, 6),
        new JdeField("GSORMCU", "GSORMCU", JdeDataType.String, 24),
        new JdeField("GSJBCD", "GSJBCD", JdeDataType.String, 12),
        new JdeField("GSJBST", "GSJBST", JdeDataType.String, 8),
        new JdeField("GSJCC", "GSJCC", JdeDataType.String, 20),
        new JdeField("GSSGID", "GSSGID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05105_0", "Primary Key on GSSGID", new[] { "GSSGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05105_2", "Unique Index on GSSGTYP, GSOTPS, GSORMCU, GSJBCD, GSJBST, GSJCC, GSCMPE, GSCMPC, SYS_NC00016$", new[] { "GSSGTYP", "GSOTPS", "GSORMCU", "GSJBCD", "GSJBST", "GSJCC", "GSCMPE", "GSCMPC", "SYS_NC00016$" }, isUnique: true),
        new JdeIndex("F05105_4", "Index on GSSGTYP, GSCMPE, GSCMPC, GSSGID", new[] { "GSSGTYP", "GSCMPE", "GSCMPC", "GSSGID" })
    };
}
