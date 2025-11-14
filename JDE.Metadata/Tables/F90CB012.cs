using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB012 - .
/// </summary>
public class F90CB012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LALEADID.
        /// </summary>
        public const string LALEADID = "LALEADID";

        /// <summary>
        /// LAACTVID.
        /// </summary>
        public const string LAACTVID = "LAACTVID";

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
    public override string TableName => "F90CB012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LALEADID", "LALEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LAACTVID", "LAACTVID", JdeDataType.Numeric, null, true, true),
        new JdeField("LASTSUDT", "LASTSUDT", JdeDataType.Date),
        new JdeField("LAACTIND", "LAACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB012_0", "Primary Key on LALEADID, LAACTVID", new[] { "LALEADID", "LAACTVID" }, isUnique: true, isPrimaryKey: true)
    };
}
