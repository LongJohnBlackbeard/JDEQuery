using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021A - .
/// </summary>
public class F41021A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LIITM.
        /// </summary>
        public const string LIITM = "LIITM";

        /// <summary>
        /// LIMCU.
        /// </summary>
        public const string LIMCU = "LIMCU";

        /// <summary>
        /// LILOCN.
        /// </summary>
        public const string LILOCN = "LILOCN";

        /// <summary>
        /// LILOTN.
        /// </summary>
        public const string LILOTN = "LILOTN";

        /// <summary>
        /// LICSID.
        /// </summary>
        public const string LICSID = "LICSID";
    }

    /// <inheritdoc />
    public override string TableName => "F41021A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LIITM", "LIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LIMCU", "LIMCU", JdeDataType.String, 24, true, true),
        new JdeField("LILOCN", "LILOCN", JdeDataType.String, 40, true, true),
        new JdeField("LILOTN", "LILOTN", JdeDataType.String, 60, true, true),
        new JdeField("LICSID", "LICSID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021A_0", "Primary Key on LIITM, LIMCU, LILOCN, LILOTN", new[] { "LIITM", "LIMCU", "LILOCN", "LILOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
