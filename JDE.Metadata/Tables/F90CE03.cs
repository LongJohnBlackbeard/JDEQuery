using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE03 - .
/// </summary>
public class F90CE03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FUPRDCTID.
        /// </summary>
        public const string FUPRDCTID = "FUPRDCTID";

        /// <summary>
        /// FUSLTNID.
        /// </summary>
        public const string FUSLTNID = "FUSLTNID";

        /// <summary>
        /// FUSLVCNT.
        /// </summary>
        public const string FUSLVCNT = "FUSLVCNT";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FUPRDCTID", "FUPRDCTID", JdeDataType.Numeric, null, true, true),
        new JdeField("FUSLTNID", "FUSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FUSLVCNT", "FUSLVCNT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE03_0", "Primary Key on FUPRDCTID, FUSLTNID", new[] { "FUPRDCTID", "FUSLTNID" }, isUnique: true, isPrimaryKey: true)
    };
}
