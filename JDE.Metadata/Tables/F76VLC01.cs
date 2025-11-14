using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VLC01 - .
/// </summary>
public class F76VLC01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCEXR1.
        /// </summary>
        public const string LCEXR1 = "LCEXR1";

        /// <summary>
        /// LCTXA1.
        /// </summary>
        public const string LCTXA1 = "LCTXA1";

        /// <summary>
        /// LCTAXA.
        /// </summary>
        public const string LCTAXA = "LCTAXA";

        /// <summary>
        /// LCTXR1.
        /// </summary>
        public const string LCTXR1 = "LCTXR1";

        /// <summary>
        /// LCAA.
        /// </summary>
        public const string LCAA = "LCAA";

        /// <summary>
        /// LCAAP.
        /// </summary>
        public const string LCAAP = "LCAAP";

        /// <summary>
        /// LCAG.
        /// </summary>
        public const string LCAG = "LCAG";

        /// <summary>
        /// LCAEXP.
        /// </summary>
        public const string LCAEXP = "LCAEXP";
    }

    /// <inheritdoc />
    public override string TableName => "F76VLC01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCEXR1", "LCEXR1", JdeDataType.String, 4, true, true),
        new JdeField("LCTXA1", "LCTXA1", JdeDataType.String, 20, true, true),
        new JdeField("LCTAXA", "LCTAXA", JdeDataType.String, 60),
        new JdeField("LCTXR1", "LCTXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("LCAA", "LCAA", JdeDataType.Numeric),
        new JdeField("LCAAP", "LCAAP", JdeDataType.Numeric),
        new JdeField("LCAG", "LCAG", JdeDataType.Numeric),
        new JdeField("LCAEXP", "LCAEXP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VLC01_0", "Primary Key on LCEXR1, LCTXA1, LCTXR1", new[] { "LCEXR1", "LCTXA1", "LCTXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
