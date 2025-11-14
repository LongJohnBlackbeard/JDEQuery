using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09621 - .
/// </summary>
public class F09621 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSBAN.
        /// </summary>
        public const string GSBAN = "GSBAN";

        /// <summary>
        /// GSTRANT.
        /// </summary>
        public const string GSTRANT = "GSTRANT";

        /// <summary>
        /// GSAID.
        /// </summary>
        public const string GSAID = "GSAID";

        /// <summary>
        /// GSSTRN.
        /// </summary>
        public const string GSSTRN = "GSSTRN";

        /// <summary>
        /// GSEFI.
        /// </summary>
        public const string GSEFI = "GSEFI";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSMCU.
        /// </summary>
        public const string GSMCU = "GSMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F09621";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSBAN", "GSBAN", JdeDataType.String, 58, true, true),
        new JdeField("GSTRANT", "GSTRANT", JdeDataType.String, 8),
        new JdeField("GSAID", "GSAID", JdeDataType.String, 16),
        new JdeField("GSSTRN", "GSSTRN", JdeDataType.String, 6),
        new JdeField("GSEFI", "GSEFI", JdeDataType.String, 12),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSMCU", "GSMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09621_0", "Primary Key on GSBAN", new[] { "GSBAN" }, isUnique: true, isPrimaryKey: true)
    };
}
