using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40941 - .
/// </summary>
public class F40941 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IKPRGR.
        /// </summary>
        public const string IKPRGR = "IKPRGR";

        /// <summary>
        /// IKIGP1.
        /// </summary>
        public const string IKIGP1 = "IKIGP1";

        /// <summary>
        /// IKIGP2.
        /// </summary>
        public const string IKIGP2 = "IKIGP2";

        /// <summary>
        /// IKIGP3.
        /// </summary>
        public const string IKIGP3 = "IKIGP3";

        /// <summary>
        /// IKIGP4.
        /// </summary>
        public const string IKIGP4 = "IKIGP4";

        /// <summary>
        /// IKIGP5.
        /// </summary>
        public const string IKIGP5 = "IKIGP5";

        /// <summary>
        /// IKIGP6.
        /// </summary>
        public const string IKIGP6 = "IKIGP6";

        /// <summary>
        /// IKIGP7.
        /// </summary>
        public const string IKIGP7 = "IKIGP7";

        /// <summary>
        /// IKIGP8.
        /// </summary>
        public const string IKIGP8 = "IKIGP8";

        /// <summary>
        /// IKIGP9.
        /// </summary>
        public const string IKIGP9 = "IKIGP9";

        /// <summary>
        /// IKIGP10.
        /// </summary>
        public const string IKIGP10 = "IKIGP10";

        /// <summary>
        /// IKIGID.
        /// </summary>
        public const string IKIGID = "IKIGID";
    }

    /// <inheritdoc />
    public override string TableName => "F40941";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IKPRGR", "IKPRGR", JdeDataType.String, 16, true, true),
        new JdeField("IKIGP1", "IKIGP1", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP2", "IKIGP2", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP3", "IKIGP3", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP4", "IKIGP4", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP5", "IKIGP5", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP6", "IKIGP6", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP7", "IKIGP7", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP8", "IKIGP8", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP9", "IKIGP9", JdeDataType.String, 12, true, true),
        new JdeField("IKIGP10", "IKIGP10", JdeDataType.String, 12, true, true),
        new JdeField("IKIGID", "IKIGID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40941_0", "Primary Key on IKPRGR, IKIGP1, IKIGP2, IKIGP3, IKIGP4, IKIGP5, IKIGP6, IKIGP7, IKIGP8, IKIGP9, IKIGP10", new[] { "IKPRGR", "IKIGP1", "IKIGP2", "IKIGP3", "IKIGP4", "IKIGP5", "IKIGP6", "IKIGP7", "IKIGP8", "IKIGP9", "IKIGP10" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40941_2", "Index on IKIGID", new[] { "IKIGID" })
    };
}
