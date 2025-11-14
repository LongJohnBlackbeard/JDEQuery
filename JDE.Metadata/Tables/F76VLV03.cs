using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VLV03 - .
/// </summary>
public class F76VLV03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IATXA1.
        /// </summary>
        public const string IATXA1 = "IATXA1";

        /// <summary>
        /// IATXR1.
        /// </summary>
        public const string IATXR1 = "IATXR1";

        /// <summary>
        /// IATAXA.
        /// </summary>
        public const string IATAXA = "IATAXA";

        /// <summary>
        /// IASTAM.
        /// </summary>
        public const string IASTAM = "IASTAM";

        /// <summary>
        /// IAATXA.
        /// </summary>
        public const string IAATXA = "IAATXA";
    }

    /// <inheritdoc />
    public override string TableName => "F76VLV03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IATXA1", "IATXA1", JdeDataType.String, 20, true, true),
        new JdeField("IATXR1", "IATXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("IATAXA", "IATAXA", JdeDataType.String, 60),
        new JdeField("IASTAM", "IASTAM", JdeDataType.Numeric),
        new JdeField("IAATXA", "IAATXA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VLV03_0", "Primary Key on IATXA1, IATXR1", new[] { "IATXA1", "IATXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
