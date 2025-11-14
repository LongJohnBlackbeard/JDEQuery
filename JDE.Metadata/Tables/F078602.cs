using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078602 - .
/// </summary>
public class F078602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSW2RF.
        /// </summary>
        public const string RSW2RF = "RSW2RF";

        /// <summary>
        /// RSUKID.
        /// </summary>
        public const string RSUKID = "RSUKID";

        /// <summary>
        /// RSIDYE.
        /// </summary>
        public const string RSIDYE = "RSIDYE";

        /// <summary>
        /// RSDTEY.
        /// </summary>
        public const string RSDTEY = "RSDTEY";

        /// <summary>
        /// RSSCOD.
        /// </summary>
        public const string RSSCOD = "RSSCOD";
    }

    /// <inheritdoc />
    public override string TableName => "F078602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSW2RF", "RSW2RF", JdeDataType.String, 550),
        new JdeField("RSUKID", "RSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RSIDYE", "RSIDYE", JdeDataType.String, 20, true, true),
        new JdeField("RSDTEY", "RSDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("RSSCOD", "RSSCOD", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078602_0", "Primary Key on RSUKID, RSIDYE, RSDTEY, RSSCOD", new[] { "RSUKID", "RSIDYE", "RSDTEY", "RSSCOD" }, isUnique: true, isPrimaryKey: true)
    };
}
