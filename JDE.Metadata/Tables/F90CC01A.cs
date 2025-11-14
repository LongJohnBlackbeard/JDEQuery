using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC01A - .
/// </summary>
public class F90CC01A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACAMPEVTID.
        /// </summary>
        public const string CACAMPEVTID = "CACAMPEVTID";

        /// <summary>
        /// CACLLACTID.
        /// </summary>
        public const string CACLLACTID = "CACLLACTID";

        /// <summary>
        /// CASTSUDT.
        /// </summary>
        public const string CASTSUDT = "CASTSUDT";

        /// <summary>
        /// CAACTIND.
        /// </summary>
        public const string CAACTIND = "CAACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC01A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACAMPEVTID", "CACAMPEVTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CACLLACTID", "CACLLACTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CASTSUDT", "CASTSUDT", JdeDataType.Date),
        new JdeField("CAACTIND", "CAACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC01A_0", "Primary Key on CACAMPEVTID, CACLLACTID", new[] { "CACAMPEVTID", "CACLLACTID" }, isUnique: true, isPrimaryKey: true)
    };
}
