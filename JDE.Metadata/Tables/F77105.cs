using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77105 - .
/// </summary>
public class F77105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSYEID.
        /// </summary>
        public const string LSYEID = "LSYEID";

        /// <summary>
        /// LSTAXYR.
        /// </summary>
        public const string LSTAXYR = "LSTAXYR";

        /// <summary>
        /// LSEIER.
        /// </summary>
        public const string LSEIER = "LSEIER";

        /// <summary>
        /// LSCPPE.
        /// </summary>
        public const string LSCPPE = "LSCPPE";
    }

    /// <inheritdoc />
    public override string TableName => "F77105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSYEID", "LSYEID", JdeDataType.String, 20, true, true),
        new JdeField("LSTAXYR", "LSTAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("LSEIER", "LSEIER", JdeDataType.Numeric),
        new JdeField("LSCPPE", "LSCPPE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77105_0", "Primary Key on LSYEID, LSTAXYR", new[] { "LSYEID", "LSTAXYR" }, isUnique: true, isPrimaryKey: true)
    };
}
