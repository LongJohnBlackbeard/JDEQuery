using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0415 - .
/// </summary>
public class F0415 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KJSQID.
        /// </summary>
        public const string KJSQID = "KJSQID";

        /// <summary>
        /// KJDL01.
        /// </summary>
        public const string KJDL01 = "KJDL01";

        /// <summary>
        /// KJSQ1.
        /// </summary>
        public const string KJSQ1 = "KJSQ1";

        /// <summary>
        /// KJSAD1.
        /// </summary>
        public const string KJSAD1 = "KJSAD1";

        /// <summary>
        /// KJSQ2.
        /// </summary>
        public const string KJSQ2 = "KJSQ2";

        /// <summary>
        /// KJSAD2.
        /// </summary>
        public const string KJSAD2 = "KJSAD2";

        /// <summary>
        /// KJSQ3.
        /// </summary>
        public const string KJSQ3 = "KJSQ3";

        /// <summary>
        /// KJSAD3.
        /// </summary>
        public const string KJSAD3 = "KJSAD3";

        /// <summary>
        /// KJSQ4.
        /// </summary>
        public const string KJSQ4 = "KJSQ4";

        /// <summary>
        /// KJSAD4.
        /// </summary>
        public const string KJSAD4 = "KJSAD4";

        /// <summary>
        /// KJSQ5.
        /// </summary>
        public const string KJSQ5 = "KJSQ5";

        /// <summary>
        /// KJSAD5.
        /// </summary>
        public const string KJSAD5 = "KJSAD5";

        /// <summary>
        /// KJSQ6.
        /// </summary>
        public const string KJSQ6 = "KJSQ6";

        /// <summary>
        /// KJSAD6.
        /// </summary>
        public const string KJSAD6 = "KJSAD6";
    }

    /// <inheritdoc />
    public override string TableName => "F0415";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KJSQID", "KJSQID", JdeDataType.String, 20, true, true),
        new JdeField("KJDL01", "KJDL01", JdeDataType.String, 60),
        new JdeField("KJSQ1", "KJSQ1", JdeDataType.String, 8),
        new JdeField("KJSAD1", "KJSAD1", JdeDataType.String, 2),
        new JdeField("KJSQ2", "KJSQ2", JdeDataType.String, 8),
        new JdeField("KJSAD2", "KJSAD2", JdeDataType.String, 2),
        new JdeField("KJSQ3", "KJSQ3", JdeDataType.String, 8),
        new JdeField("KJSAD3", "KJSAD3", JdeDataType.String, 2),
        new JdeField("KJSQ4", "KJSQ4", JdeDataType.String, 8),
        new JdeField("KJSAD4", "KJSAD4", JdeDataType.String, 2),
        new JdeField("KJSQ5", "KJSQ5", JdeDataType.String, 8),
        new JdeField("KJSAD5", "KJSAD5", JdeDataType.String, 2),
        new JdeField("KJSQ6", "KJSQ6", JdeDataType.String, 8),
        new JdeField("KJSAD6", "KJSAD6", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0415_0", "Primary Key on KJSQID", new[] { "KJSQID" }, isUnique: true, isPrimaryKey: true)
    };
}
