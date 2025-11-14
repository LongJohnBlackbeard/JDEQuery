using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38001 - .
/// </summary>
public class F38001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCCO.
        /// </summary>
        public const string DCCO = "DCCO";

        /// <summary>
        /// DCMCU.
        /// </summary>
        public const string DCMCU = "DCMCU";

        /// <summary>
        /// DCSCH1.
        /// </summary>
        public const string DCSCH1 = "DCSCH1";

        /// <summary>
        /// DCSCH2.
        /// </summary>
        public const string DCSCH2 = "DCSCH2";

        /// <summary>
        /// DCSCH3.
        /// </summary>
        public const string DCSCH3 = "DCSCH3";

        /// <summary>
        /// DCSCH4.
        /// </summary>
        public const string DCSCH4 = "DCSCH4";

        /// <summary>
        /// DCSCH5.
        /// </summary>
        public const string DCSCH5 = "DCSCH5";

        /// <summary>
        /// DCSCH6.
        /// </summary>
        public const string DCSCH6 = "DCSCH6";

        /// <summary>
        /// DCSCH7.
        /// </summary>
        public const string DCSCH7 = "DCSCH7";

        /// <summary>
        /// DCVMF1.
        /// </summary>
        public const string DCVMF1 = "DCVMF1";

        /// <summary>
        /// DCVMF2.
        /// </summary>
        public const string DCVMF2 = "DCVMF2";

        /// <summary>
        /// DCVMF3.
        /// </summary>
        public const string DCVMF3 = "DCVMF3";

        /// <summary>
        /// DCVMF4.
        /// </summary>
        public const string DCVMF4 = "DCVMF4";

        /// <summary>
        /// DCVMF5.
        /// </summary>
        public const string DCVMF5 = "DCVMF5";
    }

    /// <inheritdoc />
    public override string TableName => "F38001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCCO", "DCCO", JdeDataType.String, 10, true, true),
        new JdeField("DCMCU", "DCMCU", JdeDataType.String, 24),
        new JdeField("DCSCH1", "DCSCH1", JdeDataType.String, 2),
        new JdeField("DCSCH2", "DCSCH2", JdeDataType.String, 2),
        new JdeField("DCSCH3", "DCSCH3", JdeDataType.String, 2),
        new JdeField("DCSCH4", "DCSCH4", JdeDataType.String, 2),
        new JdeField("DCSCH5", "DCSCH5", JdeDataType.String, 2),
        new JdeField("DCSCH6", "DCSCH6", JdeDataType.String, 2),
        new JdeField("DCSCH7", "DCSCH7", JdeDataType.String, 2),
        new JdeField("DCVMF1", "DCVMF1", JdeDataType.String, 2),
        new JdeField("DCVMF2", "DCVMF2", JdeDataType.String, 2),
        new JdeField("DCVMF3", "DCVMF3", JdeDataType.String, 2),
        new JdeField("DCVMF4", "DCVMF4", JdeDataType.String, 2),
        new JdeField("DCVMF5", "DCVMF5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38001_0", "Primary Key on DCCO", new[] { "DCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
