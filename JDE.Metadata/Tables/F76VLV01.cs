using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VLV01 - .
/// </summary>
public class F76VLV01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMTXA1.
        /// </summary>
        public const string IMTXA1 = "IMTXA1";

        /// <summary>
        /// IMTXR1.
        /// </summary>
        public const string IMTXR1 = "IMTXR1";

        /// <summary>
        /// IMTAXA.
        /// </summary>
        public const string IMTAXA = "IMTAXA";

        /// <summary>
        /// IMSTAM.
        /// </summary>
        public const string IMSTAM = "IMSTAM";

        /// <summary>
        /// IMATXA.
        /// </summary>
        public const string IMATXA = "IMATXA";
    }

    /// <inheritdoc />
    public override string TableName => "F76VLV01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMTXA1", "IMTXA1", JdeDataType.String, 20, true, true),
        new JdeField("IMTXR1", "IMTXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("IMTAXA", "IMTAXA", JdeDataType.String, 60),
        new JdeField("IMSTAM", "IMSTAM", JdeDataType.Numeric),
        new JdeField("IMATXA", "IMATXA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VLV01_0", "Primary Key on IMTXA1, IMTXR1", new[] { "IMTXA1", "IMTXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
