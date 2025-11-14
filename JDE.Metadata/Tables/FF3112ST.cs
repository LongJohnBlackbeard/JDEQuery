using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF3112ST - .
/// </summary>
public class FF3112ST : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETUKID.
        /// </summary>
        public const string ETUKID = "ETUKID";

        /// <summary>
        /// ETRUNLEX.
        /// </summary>
        public const string ETRUNLEX = "ETRUNLEX";

        /// <summary>
        /// ETRUNMEX.
        /// </summary>
        public const string ETRUNMEX = "ETRUNMEX";

        /// <summary>
        /// ETRUNLCU.
        /// </summary>
        public const string ETRUNLCU = "ETRUNLCU";

        /// <summary>
        /// ETRUNMCU.
        /// </summary>
        public const string ETRUNMCU = "ETRUNMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF3112ST";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETUKID", "ETUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ETRUNLEX", "ETRUNLEX", JdeDataType.Numeric),
        new JdeField("ETRUNMEX", "ETRUNMEX", JdeDataType.Numeric),
        new JdeField("ETRUNLCU", "ETRUNLCU", JdeDataType.Numeric),
        new JdeField("ETRUNMCU", "ETRUNMCU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF3112ST_0", "Primary Key on ETUKID", new[] { "ETUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
