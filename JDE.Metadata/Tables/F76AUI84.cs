using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI84 - .
/// </summary>
public class F76AUI84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INHDC.
        /// </summary>
        public const string INHDC = "INHDC";

        /// <summary>
        /// INCO.
        /// </summary>
        public const string INCO = "INCO";

        /// <summary>
        /// INAN8.
        /// </summary>
        public const string INAN8 = "INAN8";

        /// <summary>
        /// INDMTM.
        /// </summary>
        public const string INDMTM = "INDMTM";

        /// <summary>
        /// INDMTY.
        /// </summary>
        public const string INDMTY = "INDMTY";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INHDC", "INHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("INCO", "INCO", JdeDataType.String, 10, true, true),
        new JdeField("INAN8", "INAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("INDMTM", "INDMTM", JdeDataType.Numeric),
        new JdeField("INDMTY", "INDMTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI84_0", "Primary Key on INHDC, INCO, INAN8", new[] { "INHDC", "INCO", "INAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
