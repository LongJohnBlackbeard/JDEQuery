using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8014 - .
/// </summary>
public class F76A8014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTADGI.
        /// </summary>
        public const string CTADGI = "CTADGI";

        /// <summary>
        /// CTVINV.
        /// </summary>
        public const string CTVINV = "CTVINV";

        /// <summary>
        /// CTDIVJ.
        /// </summary>
        public const string CTDIVJ = "CTDIVJ";

        /// <summary>
        /// CTTAX.
        /// </summary>
        public const string CTTAX = "CTTAX";

        /// <summary>
        /// CTALPH.
        /// </summary>
        public const string CTALPH = "CTALPH";

        /// <summary>
        /// CTSTAM.
        /// </summary>
        public const string CTSTAM = "CTSTAM";

        /// <summary>
        /// CTTX1.
        /// </summary>
        public const string CTTX1 = "CTTX1";

        /// <summary>
        /// CTMLNM.
        /// </summary>
        public const string CTMLNM = "CTMLNM";

        /// <summary>
        /// CTSTA1.
        /// </summary>
        public const string CTSTA1 = "CTSTA1";

        /// <summary>
        /// CTADGI1.
        /// </summary>
        public const string CTADGI1 = "CTADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTADGI", "CTADGI", JdeDataType.String, 4, true, true),
        new JdeField("CTVINV", "CTVINV", JdeDataType.String, 50, true, true),
        new JdeField("CTDIVJ", "CTDIVJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTAX", "CTTAX", JdeDataType.String, 40, true, true),
        new JdeField("CTALPH", "CTALPH", JdeDataType.String, 80),
        new JdeField("CTSTAM", "CTSTAM", JdeDataType.Numeric),
        new JdeField("CTTX1", "CTTX1", JdeDataType.String, 32),
        new JdeField("CTMLNM", "CTMLNM", JdeDataType.String, 80),
        new JdeField("CTSTA1", "CTSTA1", JdeDataType.Numeric),
        new JdeField("CTADGI1", "CTADGI1", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8014_0", "Primary Key on CTADGI1, CTVINV, CTDIVJ, CTTAX, CTADGI", new[] { "CTADGI1", "CTVINV", "CTDIVJ", "CTTAX", "CTADGI" }, isUnique: true, isPrimaryKey: true)
    };
}
