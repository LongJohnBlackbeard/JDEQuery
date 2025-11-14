using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C09Z1 - .
/// </summary>
public class F75C09Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FFJOBS.
        /// </summary>
        public const string FFJOBS = "FFJOBS";

        /// <summary>
        /// FFJOBN.
        /// </summary>
        public const string FFJOBN = "FFJOBN";

        /// <summary>
        /// FFUKID.
        /// </summary>
        public const string FFUKID = "FFUKID";

        /// <summary>
        /// FFVR01.
        /// </summary>
        public const string FFVR01 = "FFVR01";
    }

    /// <inheritdoc />
    public override string TableName => "F75C09Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FFJOBS", "FFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("FFJOBN", "FFJOBN", JdeDataType.String, 20, true, true),
        new JdeField("FFUKID", "FFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FFVR01", "FFVR01", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C09Z1_0", "Primary Key on FFJOBS, FFJOBN, FFUKID", new[] { "FFJOBS", "FFJOBN", "FFUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
