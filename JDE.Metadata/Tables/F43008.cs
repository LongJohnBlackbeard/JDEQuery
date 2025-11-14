using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43008 - .
/// </summary>
public class F43008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDCTO.
        /// </summary>
        public const string APDCTO = "APDCTO";

        /// <summary>
        /// APARTG.
        /// </summary>
        public const string APARTG = "APARTG";

        /// <summary>
        /// APDL01.
        /// </summary>
        public const string APDL01 = "APDL01";

        /// <summary>
        /// APALIM.
        /// </summary>
        public const string APALIM = "APALIM";

        /// <summary>
        /// APRPER.
        /// </summary>
        public const string APRPER = "APRPER";

        /// <summary>
        /// APATY.
        /// </summary>
        public const string APATY = "APATY";
    }

    /// <inheritdoc />
    public override string TableName => "F43008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDCTO", "APDCTO", JdeDataType.String, 4, true, true),
        new JdeField("APARTG", "APARTG", JdeDataType.String, 24, true, true),
        new JdeField("APDL01", "APDL01", JdeDataType.String, 60),
        new JdeField("APALIM", "APALIM", JdeDataType.Numeric, null, true, true),
        new JdeField("APRPER", "APRPER", JdeDataType.Numeric, null, true, true),
        new JdeField("APATY", "APATY", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43008_0", "Primary Key on APDCTO, APARTG, APALIM, APRPER, APATY", new[] { "APDCTO", "APARTG", "APALIM", "APRPER", "APATY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43008_3", "Index on APRPER, APDCTO, APARTG, APATY", new[] { "APRPER", "APDCTO", "APARTG", "APATY" }),
        new JdeIndex("F43008_4", "Index on APARTG", new[] { "APARTG" })
    };
}
