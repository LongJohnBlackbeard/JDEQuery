using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE03A - .
/// </summary>
public class F90CE03A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSSLTNID.
        /// </summary>
        public const string CSSLTNID = "CSSLTNID";

        /// <summary>
        /// CSITM.
        /// </summary>
        public const string CSITM = "CSITM";

        /// <summary>
        /// CSMATH01.
        /// </summary>
        public const string CSMATH01 = "CSMATH01";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE03A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSSLTNID", "CSSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CSMATH01", "CSMATH01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE03A_0", "Primary Key on CSSLTNID, CSITM", new[] { "CSSLTNID", "CSITM" }, isUnique: true, isPrimaryKey: true)
    };
}
