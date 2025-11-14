using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE03C - .
/// </summary>
public class F90CE03C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSSLTNID.
        /// </summary>
        public const string WSSLTNID = "WSSLTNID";

        /// <summary>
        /// WSITM.
        /// </summary>
        public const string WSITM = "WSITM";

        /// <summary>
        /// WSMATH01.
        /// </summary>
        public const string WSMATH01 = "WSMATH01";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE03C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSSLTNID", "WSSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSITM", "WSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WSMATH01", "WSMATH01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE03C_0", "Primary Key on WSSLTNID, WSITM", new[] { "WSSLTNID", "WSITM" }, isUnique: true, isPrimaryKey: true)
    };
}
