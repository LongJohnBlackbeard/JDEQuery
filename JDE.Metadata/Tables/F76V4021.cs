using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4021 - .
/// </summary>
public class F76V4021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTCO.
        /// </summary>
        public const string WTCO = "WTCO";

        /// <summary>
        /// WTV76ISLR.
        /// </summary>
        public const string WTV76ISLR = "WTV76ISLR";

        /// <summary>
        /// WTV76ISFC.
        /// </summary>
        public const string WTV76ISFC = "WTV76ISFC";

        /// <summary>
        /// WTV76MIIS.
        /// </summary>
        public const string WTV76MIIS = "WTV76MIIS";

        /// <summary>
        /// WTEFTJ.
        /// </summary>
        public const string WTEFTJ = "WTEFTJ";

        /// <summary>
        /// WTV76ISWF.
        /// </summary>
        public const string WTV76ISWF = "WTV76ISWF";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTCO", "WTCO", JdeDataType.String, 10, true, true),
        new JdeField("WTV76ISLR", "WTV76ISLR", JdeDataType.String, 6, true, true),
        new JdeField("WTV76ISFC", "WTV76ISFC", JdeDataType.String, 2, true, true),
        new JdeField("WTV76MIIS", "WTV76MIIS", JdeDataType.Numeric, null, true, true),
        new JdeField("WTEFTJ", "WTEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WTV76ISWF", "WTV76ISWF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4021_0", "Primary Key on WTCO, WTV76ISLR, WTV76ISFC, WTV76MIIS, WTEFTJ", new[] { "WTCO", "WTV76ISLR", "WTV76ISFC", "WTV76MIIS", "WTEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
