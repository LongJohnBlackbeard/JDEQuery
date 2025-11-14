using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069162 - .
/// </summary>
public class F069162 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHJBCD.
        /// </summary>
        public const string JHJBCD = "JHJBCD";

        /// <summary>
        /// JHJBST.
        /// </summary>
        public const string JHJBST = "JHJBST";

        /// <summary>
        /// JHUN.
        /// </summary>
        public const string JHUN = "JHUN";

        /// <summary>
        /// JHITM.
        /// </summary>
        public const string JHITM = "JHITM";

        /// <summary>
        /// JHUM.
        /// </summary>
        public const string JHUM = "JHUM";
    }

    /// <inheritdoc />
    public override string TableName => "F069162";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHJBCD", "JHJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JHJBST", "JHJBST", JdeDataType.String, 8, true, true),
        new JdeField("JHUN", "JHUN", JdeDataType.String, 12, true, true),
        new JdeField("JHITM", "JHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("JHUM", "JHUM", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069162_0", "Primary Key on JHJBCD, JHJBST, JHUN, JHITM, JHUM", new[] { "JHJBCD", "JHJBST", "JHUN", "JHITM", "JHUM" }, isUnique: true, isPrimaryKey: true)
    };
}
