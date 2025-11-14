using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A670 - .
/// </summary>
public class F75A670 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LLAN8.
        /// </summary>
        public const string LLAN8 = "LLAN8";

        /// <summary>
        /// LLLSAC.
        /// </summary>
        public const string LLLSAC = "LLLSAC";

        /// <summary>
        /// LLLSLD.
        /// </summary>
        public const string LLLSLD = "LLLSLD";

        /// <summary>
        /// LLLSLP.
        /// </summary>
        public const string LLLSLP = "LLLSLP";

        /// <summary>
        /// LLPDBA.
        /// </summary>
        public const string LLPDBA = "LLPDBA";
    }

    /// <inheritdoc />
    public override string TableName => "F75A670";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LLAN8", "LLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LLLSAC", "LLLSAC", JdeDataType.Numeric, null, true, true),
        new JdeField("LLLSLD", "LLLSLD", JdeDataType.Numeric),
        new JdeField("LLLSLP", "LLLSLP", JdeDataType.Numeric),
        new JdeField("LLPDBA", "LLPDBA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A670_0", "Primary Key on LLAN8, LLLSAC", new[] { "LLAN8", "LLLSAC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A670_2", "Index on LLAN8, LLPDBA", new[] { "LLAN8", "LLPDBA" })
    };
}
