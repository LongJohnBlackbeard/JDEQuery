using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA141 - .
/// </summary>
public class F90CA141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSCFGSID.
        /// </summary>
        public const string TSCFGSID = "TSCFGSID";

        /// <summary>
        /// TSTERRID.
        /// </summary>
        public const string TSTERRID = "TSTERRID";

        /// <summary>
        /// TSDESC.
        /// </summary>
        public const string TSDESC = "TSDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSCFGSID", "TSCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("TSTERRID", "TSTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TSDESC", "TSDESC", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA141_0", "Primary Key on TSCFGSID, TSTERRID", new[] { "TSCFGSID", "TSTERRID" }, isUnique: true, isPrimaryKey: true)
    };
}
