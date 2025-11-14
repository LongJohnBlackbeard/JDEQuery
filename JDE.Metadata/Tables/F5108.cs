using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5108 - .
/// </summary>
public class F5108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDMCU.
        /// </summary>
        public const string MDMCU = "MDMCU";

        /// <summary>
        /// MDBSCT.
        /// </summary>
        public const string MDBSCT = "MDBSCT";

        /// <summary>
        /// MDBSFY.
        /// </summary>
        public const string MDBSFY = "MDBSFY";

        /// <summary>
        /// MDBTCT.
        /// </summary>
        public const string MDBTCT = "MDBTCT";

        /// <summary>
        /// MDBTFY.
        /// </summary>
        public const string MDBTFY = "MDBTFY";

        /// <summary>
        /// MDRCS1.
        /// </summary>
        public const string MDRCS1 = "MDRCS1";

        /// <summary>
        /// MDRCS2.
        /// </summary>
        public const string MDRCS2 = "MDRCS2";

        /// <summary>
        /// MDRCS3.
        /// </summary>
        public const string MDRCS3 = "MDRCS3";

        /// <summary>
        /// MDJCF6.
        /// </summary>
        public const string MDJCF6 = "MDJCF6";

        /// <summary>
        /// MDJCF7.
        /// </summary>
        public const string MDJCF7 = "MDJCF7";

        /// <summary>
        /// MDJCF8.
        /// </summary>
        public const string MDJCF8 = "MDJCF8";

        /// <summary>
        /// MDJCF9.
        /// </summary>
        public const string MDJCF9 = "MDJCF9";

        /// <summary>
        /// MDJCF0.
        /// </summary>
        public const string MDJCF0 = "MDJCF0";
    }

    /// <inheritdoc />
    public override string TableName => "F5108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDMCU", "MDMCU", JdeDataType.String, 24, true, true),
        new JdeField("MDBSCT", "MDBSCT", JdeDataType.Numeric),
        new JdeField("MDBSFY", "MDBSFY", JdeDataType.Numeric),
        new JdeField("MDBTCT", "MDBTCT", JdeDataType.Numeric),
        new JdeField("MDBTFY", "MDBTFY", JdeDataType.Numeric),
        new JdeField("MDRCS1", "MDRCS1", JdeDataType.String, 6),
        new JdeField("MDRCS2", "MDRCS2", JdeDataType.String, 6),
        new JdeField("MDRCS3", "MDRCS3", JdeDataType.String, 6),
        new JdeField("MDJCF6", "MDJCF6", JdeDataType.String, 2),
        new JdeField("MDJCF7", "MDJCF7", JdeDataType.String, 2),
        new JdeField("MDJCF8", "MDJCF8", JdeDataType.String, 2),
        new JdeField("MDJCF9", "MDJCF9", JdeDataType.String, 2),
        new JdeField("MDJCF0", "MDJCF0", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5108_0", "Primary Key on MDMCU", new[] { "MDMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
