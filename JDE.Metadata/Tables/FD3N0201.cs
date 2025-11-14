using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0201 - .
/// </summary>
public class FD3N0201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESNUMR.
        /// </summary>
        public const string ESNUMR = "ESNUMR";

        /// <summary>
        /// ESAN8.
        /// </summary>
        public const string ESAN8 = "ESAN8";

        /// <summary>
        /// ESEMPLNAME.
        /// </summary>
        public const string ESEMPLNAME = "ESEMPLNAME";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESNUMR", "ESNUMR", JdeDataType.Numeric, null, true, true),
        new JdeField("ESAN8", "ESAN8", JdeDataType.Numeric),
        new JdeField("ESEMPLNAME", "ESEMPLNAME", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0201_0", "Primary Key on ESNUMR", new[] { "ESNUMR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N0201_1", "Unique Index on ESAN8", new[] { "ESAN8" }, isUnique: true)
    };
}
