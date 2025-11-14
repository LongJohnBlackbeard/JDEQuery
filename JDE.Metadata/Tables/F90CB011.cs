using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB011 - .
/// </summary>
public class F90CB011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAADRSID.
        /// </summary>
        public const string LAADRSID = "LAADRSID";

        /// <summary>
        /// LALEADID.
        /// </summary>
        public const string LALEADID = "LALEADID";

        /// <summary>
        /// LASTSUDT.
        /// </summary>
        public const string LASTSUDT = "LASTSUDT";

        /// <summary>
        /// LAACTIND.
        /// </summary>
        public const string LAACTIND = "LAACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAADRSID", "LAADRSID", JdeDataType.Numeric, null, true, true),
        new JdeField("LALEADID", "LALEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LASTSUDT", "LASTSUDT", JdeDataType.Date),
        new JdeField("LAACTIND", "LAACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB011_0", "Primary Key on LAADRSID, LALEADID", new[] { "LAADRSID", "LALEADID" }, isUnique: true, isPrimaryKey: true)
    };
}
