using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09525 - .
/// </summary>
public class F09525 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FBBNKAID.
        /// </summary>
        public const string FBBNKAID = "FBBNKAID";

        /// <summary>
        /// FBSRCSYS.
        /// </summary>
        public const string FBSRCSYS = "FBSRCSYS";

        /// <summary>
        /// FBMCU.
        /// </summary>
        public const string FBMCU = "FBMCU";

        /// <summary>
        /// FBOBJ.
        /// </summary>
        public const string FBOBJ = "FBOBJ";

        /// <summary>
        /// FBSUB.
        /// </summary>
        public const string FBSUB = "FBSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F09525";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FBBNKAID", "FBBNKAID", JdeDataType.String, 16, true, true),
        new JdeField("FBSRCSYS", "FBSRCSYS", JdeDataType.String, 8, true, true),
        new JdeField("FBMCU", "FBMCU", JdeDataType.String, 24),
        new JdeField("FBOBJ", "FBOBJ", JdeDataType.String, 12),
        new JdeField("FBSUB", "FBSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09525_0", "Primary Key on FBBNKAID, FBSRCSYS", new[] { "FBBNKAID", "FBSRCSYS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09525_2", "Index on FBSRCSYS, FBMCU, FBOBJ, FBSUB, FBBNKAID", new[] { "FBSRCSYS", "FBMCU", "FBOBJ", "FBSUB", "FBBNKAID" })
    };
}
