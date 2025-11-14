using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A1244 - .
/// </summary>
public class F76A1244 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FQCO.
        /// </summary>
        public const string FQCO = "FQCO";

        /// <summary>
        /// FQR015.
        /// </summary>
        public const string FQR015 = "FQR015";

        /// <summary>
        /// FQMCU.
        /// </summary>
        public const string FQMCU = "FQMCU";

        /// <summary>
        /// FQAN01.
        /// </summary>
        public const string FQAN01 = "FQAN01";

        /// <summary>
        /// FQAN02.
        /// </summary>
        public const string FQAN02 = "FQAN02";

        /// <summary>
        /// FQAN03.
        /// </summary>
        public const string FQAN03 = "FQAN03";

        /// <summary>
        /// FQAN04.
        /// </summary>
        public const string FQAN04 = "FQAN04";

        /// <summary>
        /// FQAN05.
        /// </summary>
        public const string FQAN05 = "FQAN05";

        /// <summary>
        /// FQAN06.
        /// </summary>
        public const string FQAN06 = "FQAN06";

        /// <summary>
        /// FQAN07.
        /// </summary>
        public const string FQAN07 = "FQAN07";

        /// <summary>
        /// FQAN08.
        /// </summary>
        public const string FQAN08 = "FQAN08";

        /// <summary>
        /// FQAN09.
        /// </summary>
        public const string FQAN09 = "FQAN09";

        /// <summary>
        /// FQAN10.
        /// </summary>
        public const string FQAN10 = "FQAN10";
    }

    /// <inheritdoc />
    public override string TableName => "F76A1244";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FQCO", "FQCO", JdeDataType.String, 10, true, true),
        new JdeField("FQR015", "FQR015", JdeDataType.String, 6, true, true),
        new JdeField("FQMCU", "FQMCU", JdeDataType.String, 24, true, true),
        new JdeField("FQAN01", "FQAN01", JdeDataType.Numeric),
        new JdeField("FQAN02", "FQAN02", JdeDataType.Numeric),
        new JdeField("FQAN03", "FQAN03", JdeDataType.Numeric),
        new JdeField("FQAN04", "FQAN04", JdeDataType.Numeric),
        new JdeField("FQAN05", "FQAN05", JdeDataType.Numeric),
        new JdeField("FQAN06", "FQAN06", JdeDataType.Numeric),
        new JdeField("FQAN07", "FQAN07", JdeDataType.Numeric),
        new JdeField("FQAN08", "FQAN08", JdeDataType.Numeric),
        new JdeField("FQAN09", "FQAN09", JdeDataType.Numeric),
        new JdeField("FQAN10", "FQAN10", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A1244_0", "Primary Key on FQCO, FQR015, FQMCU", new[] { "FQCO", "FQR015", "FQMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
