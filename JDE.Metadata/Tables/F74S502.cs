using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S502 - .
/// </summary>
public class F74S502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDUKID.
        /// </summary>
        public const string SDUKID = "SDUKID";

        /// <summary>
        /// SDCKAM.
        /// </summary>
        public const string SDCKAM = "SDCKAM";

        /// <summary>
        /// SDSTFE.
        /// </summary>
        public const string SDSTFE = "SDSTFE";

        /// <summary>
        /// SDAFEA.
        /// </summary>
        public const string SDAFEA = "SDAFEA";

        /// <summary>
        /// SDFEAT.
        /// </summary>
        public const string SDFEAT = "SDFEAT";
    }

    /// <inheritdoc />
    public override string TableName => "F74S502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDUKID", "SDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDCKAM", "SDCKAM", JdeDataType.Numeric, null, true, true),
        new JdeField("SDSTFE", "SDSTFE", JdeDataType.Numeric),
        new JdeField("SDAFEA", "SDAFEA", JdeDataType.Numeric),
        new JdeField("SDFEAT", "SDFEAT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S502_0", "Primary Key on SDUKID, SDCKAM", new[] { "SDUKID", "SDCKAM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S502_2", "Index on SDUKID, SYS_NC00006$", new[] { "SDUKID", "SYS_NC00006$" })
    };
}
