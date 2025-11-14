using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G88 - .
/// </summary>
public class F52G88 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TLIPTLC.
        /// </summary>
        public const string TLIPTLC = "TLIPTLC";

        /// <summary>
        /// TLIPTL.
        /// </summary>
        public const string TLIPTL = "TLIPTL";

        /// <summary>
        /// TLUSER.
        /// </summary>
        public const string TLUSER = "TLUSER";

        /// <summary>
        /// TLPID.
        /// </summary>
        public const string TLPID = "TLPID";

        /// <summary>
        /// TLMKEY.
        /// </summary>
        public const string TLMKEY = "TLMKEY";

        /// <summary>
        /// TLUPMJ.
        /// </summary>
        public const string TLUPMJ = "TLUPMJ";

        /// <summary>
        /// TLUPMT.
        /// </summary>
        public const string TLUPMT = "TLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G88";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TLIPTLC", "TLIPTLC", JdeDataType.String, 8, true, true),
        new JdeField("TLIPTL", "TLIPTL", JdeDataType.String, 200),
        new JdeField("TLUSER", "TLUSER", JdeDataType.String, 20),
        new JdeField("TLPID", "TLPID", JdeDataType.String, 20),
        new JdeField("TLMKEY", "TLMKEY", JdeDataType.String, 30),
        new JdeField("TLUPMJ", "TLUPMJ", JdeDataType.Numeric),
        new JdeField("TLUPMT", "TLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G88_0", "Primary Key on TLIPTLC", new[] { "TLIPTLC" }, isUnique: true, isPrimaryKey: true)
    };
}
