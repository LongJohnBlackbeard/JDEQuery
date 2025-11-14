using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31112T - .
/// </summary>
public class FF31112T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHUKID.
        /// </summary>
        public const string EHUKID = "EHUKID";

        /// <summary>
        /// EHRUNLEX.
        /// </summary>
        public const string EHRUNLEX = "EHRUNLEX";

        /// <summary>
        /// EHRUNMEX.
        /// </summary>
        public const string EHRUNMEX = "EHRUNMEX";

        /// <summary>
        /// EHRUNLCU.
        /// </summary>
        public const string EHRUNLCU = "EHRUNLCU";

        /// <summary>
        /// EHRUNMCU.
        /// </summary>
        public const string EHRUNMCU = "EHRUNMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF31112T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHRUNLEX", "EHRUNLEX", JdeDataType.Numeric),
        new JdeField("EHRUNMEX", "EHRUNMEX", JdeDataType.Numeric),
        new JdeField("EHRUNLCU", "EHRUNLCU", JdeDataType.Numeric),
        new JdeField("EHRUNMCU", "EHRUNMCU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31112T_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
