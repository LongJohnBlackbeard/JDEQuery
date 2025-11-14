using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CUI2 - .
/// </summary>
public class F75CUI2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CFUSER.
        /// </summary>
        public const string CFUSER = "CFUSER";

        /// <summary>
        /// CFJOBN.
        /// </summary>
        public const string CFJOBN = "CFJOBN";

        /// <summary>
        /// CFJOBS.
        /// </summary>
        public const string CFJOBS = "CFJOBS";

        /// <summary>
        /// CFWCCV.
        /// </summary>
        public const string CFWCCV = "CFWCCV";

        /// <summary>
        /// CFLT.
        /// </summary>
        public const string CFLT = "CFLT";

        /// <summary>
        /// CFCRCX.
        /// </summary>
        public const string CFCRCX = "CFCRCX";

        /// <summary>
        /// CFWBA1.
        /// </summary>
        public const string CFWBA1 = "CFWBA1";

        /// <summary>
        /// CFWEA1.
        /// </summary>
        public const string CFWEA1 = "CFWEA1";

        /// <summary>
        /// CFWLY1.
        /// </summary>
        public const string CFWLY1 = "CFWLY1";
    }

    /// <inheritdoc />
    public override string TableName => "F75CUI2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CFUSER", "CFUSER", JdeDataType.String, 20, true, true),
        new JdeField("CFJOBN", "CFJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CFJOBS", "CFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CFWCCV", "CFWCCV", JdeDataType.String, 20, true, true),
        new JdeField("CFLT", "CFLT", JdeDataType.String, 4),
        new JdeField("CFCRCX", "CFCRCX", JdeDataType.String, 6),
        new JdeField("CFWBA1", "CFWBA1", JdeDataType.Numeric),
        new JdeField("CFWEA1", "CFWEA1", JdeDataType.Numeric),
        new JdeField("CFWLY1", "CFWLY1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CUI2_0", "Primary Key on CFUSER, CFJOBN, CFJOBS, CFWCCV", new[] { "CFUSER", "CFJOBN", "CFJOBS", "CFWCCV" }, isUnique: true, isPrimaryKey: true)
    };
}
