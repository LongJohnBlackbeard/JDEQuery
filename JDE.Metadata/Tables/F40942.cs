using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40942 - .
/// </summary>
public class F40942 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CKCPGP.
        /// </summary>
        public const string CKCPGP = "CKCPGP";

        /// <summary>
        /// CKCGP1.
        /// </summary>
        public const string CKCGP1 = "CKCGP1";

        /// <summary>
        /// CKCGP2.
        /// </summary>
        public const string CKCGP2 = "CKCGP2";

        /// <summary>
        /// CKCGP3.
        /// </summary>
        public const string CKCGP3 = "CKCGP3";

        /// <summary>
        /// CKCGP4.
        /// </summary>
        public const string CKCGP4 = "CKCGP4";

        /// <summary>
        /// CKCGP5.
        /// </summary>
        public const string CKCGP5 = "CKCGP5";

        /// <summary>
        /// CKCGP6.
        /// </summary>
        public const string CKCGP6 = "CKCGP6";

        /// <summary>
        /// CKCGP7.
        /// </summary>
        public const string CKCGP7 = "CKCGP7";

        /// <summary>
        /// CKCGP8.
        /// </summary>
        public const string CKCGP8 = "CKCGP8";

        /// <summary>
        /// CKCGP9.
        /// </summary>
        public const string CKCGP9 = "CKCGP9";

        /// <summary>
        /// CKCGP10.
        /// </summary>
        public const string CKCGP10 = "CKCGP10";

        /// <summary>
        /// CKCGID.
        /// </summary>
        public const string CKCGID = "CKCGID";
    }

    /// <inheritdoc />
    public override string TableName => "F40942";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CKCPGP", "CKCPGP", JdeDataType.String, 16, true, true),
        new JdeField("CKCGP1", "CKCGP1", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP2", "CKCGP2", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP3", "CKCGP3", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP4", "CKCGP4", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP5", "CKCGP5", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP6", "CKCGP6", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP7", "CKCGP7", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP8", "CKCGP8", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP9", "CKCGP9", JdeDataType.String, 6, true, true),
        new JdeField("CKCGP10", "CKCGP10", JdeDataType.String, 6, true, true),
        new JdeField("CKCGID", "CKCGID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40942_0", "Primary Key on CKCPGP, CKCGP1, CKCGP2, CKCGP3, CKCGP4, CKCGP5, CKCGP6, CKCGP7, CKCGP8, CKCGP9, CKCGP10", new[] { "CKCPGP", "CKCGP1", "CKCGP2", "CKCGP3", "CKCGP4", "CKCGP5", "CKCGP6", "CKCGP7", "CKCGP8", "CKCGP9", "CKCGP10" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40942_2", "Index on CKCGID", new[] { "CKCGID" })
    };
}
