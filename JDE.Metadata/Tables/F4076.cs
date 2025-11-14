using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4076 - .
/// </summary>
public class F4076 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FMFRMN.
        /// </summary>
        public const string FMFRMN = "FMFRMN";

        /// <summary>
        /// FMFML.
        /// </summary>
        public const string FMFML = "FMFML";

        /// <summary>
        /// FMAPRS.
        /// </summary>
        public const string FMAPRS = "FMAPRS";

        /// <summary>
        /// FMUSER.
        /// </summary>
        public const string FMUSER = "FMUSER";

        /// <summary>
        /// FMPID.
        /// </summary>
        public const string FMPID = "FMPID";

        /// <summary>
        /// FMJOBN.
        /// </summary>
        public const string FMJOBN = "FMJOBN";

        /// <summary>
        /// FMUPMJ.
        /// </summary>
        public const string FMUPMJ = "FMUPMJ";

        /// <summary>
        /// FMTDAY.
        /// </summary>
        public const string FMTDAY = "FMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4076";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FMFRMN", "FMFRMN", JdeDataType.String, 20, true, true),
        new JdeField("FMFML", "FMFML", JdeDataType.String, 320),
        new JdeField("FMAPRS", "FMAPRS", JdeDataType.String, 2),
        new JdeField("FMUSER", "FMUSER", JdeDataType.String, 20),
        new JdeField("FMPID", "FMPID", JdeDataType.String, 20),
        new JdeField("FMJOBN", "FMJOBN", JdeDataType.String, 20),
        new JdeField("FMUPMJ", "FMUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FMTDAY", "FMTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4076_0", "Primary Key on FMFRMN, FMUPMJ, FMTDAY", new[] { "FMFRMN", "FMUPMJ", "FMTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4076_2", "Index on FMUPMJ", new[] { "FMUPMJ" }),
        new JdeIndex("F4076_3", "Index on FMFRMN, FMPID", new[] { "FMFRMN", "FMPID" })
    };
}
