using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74030 - .
/// </summary>
public class F74030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BAIBAB.
        /// </summary>
        public const string BAIBAB = "BAIBAB";

        /// <summary>
        /// BAIBAC.
        /// </summary>
        public const string BAIBAC = "BAIBAC";

        /// <summary>
        /// BAIBCA.
        /// </summary>
        public const string BAIBCA = "BAIBCA";

        /// <summary>
        /// BAIBCC.
        /// </summary>
        public const string BAIBCC = "BAIBCC";

        /// <summary>
        /// BAIBCL.
        /// </summary>
        public const string BAIBCL = "BAIBCL";

        /// <summary>
        /// BAIBNO.
        /// </summary>
        public const string BAIBNO = "BAIBNO";

        /// <summary>
        /// BAIBIN.
        /// </summary>
        public const string BAIBIN = "BAIBIN";

        /// <summary>
        /// BAIBLO.
        /// </summary>
        public const string BAIBLO = "BAIBLO";

        /// <summary>
        /// BAIBCP.
        /// </summary>
        public const string BAIBCP = "BAIBCP";

        /// <summary>
        /// BAIBCO.
        /// </summary>
        public const string BAIBCO = "BAIBCO";

        /// <summary>
        /// BAADDS.
        /// </summary>
        public const string BAADDS = "BAADDS";

        /// <summary>
        /// BADL01.
        /// </summary>
        public const string BADL01 = "BADL01";
    }

    /// <inheritdoc />
    public override string TableName => "F74030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BAIBAB", "BAIBAB", JdeDataType.String, 10, true, true),
        new JdeField("BAIBAC", "BAIBAC", JdeDataType.Numeric),
        new JdeField("BAIBCA", "BAIBCA", JdeDataType.String, 10, true, true),
        new JdeField("BAIBCC", "BAIBCC", JdeDataType.Numeric),
        new JdeField("BAIBCL", "BAIBCL", JdeDataType.String, 10),
        new JdeField("BAIBNO", "BAIBNO", JdeDataType.String, 160),
        new JdeField("BAIBIN", "BAIBIN", JdeDataType.String, 160),
        new JdeField("BAIBLO", "BAIBLO", JdeDataType.String, 160),
        new JdeField("BAIBCP", "BAIBCP", JdeDataType.Numeric),
        new JdeField("BAIBCO", "BAIBCO", JdeDataType.String, 160),
        new JdeField("BAADDS", "BAADDS", JdeDataType.String, 6),
        new JdeField("BADL01", "BADL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74030_0", "Primary Key on BAIBAB, BAIBCA", new[] { "BAIBAB", "BAIBCA" }, isUnique: true, isPrimaryKey: true)
    };
}
