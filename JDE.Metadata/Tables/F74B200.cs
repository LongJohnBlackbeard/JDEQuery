using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74B200 - .
/// </summary>
public class F74B200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTAN8.
        /// </summary>
        public const string VTAN8 = "VTAN8";

        /// <summary>
        /// VTALPH.
        /// </summary>
        public const string VTALPH = "VTALPH";

        /// <summary>
        /// VTADD1.
        /// </summary>
        public const string VTADD1 = "VTADD1";

        /// <summary>
        /// VTADDZ.
        /// </summary>
        public const string VTADDZ = "VTADDZ";

        /// <summary>
        /// VTCTY1.
        /// </summary>
        public const string VTCTY1 = "VTCTY1";

        /// <summary>
        /// VTTAX.
        /// </summary>
        public const string VTTAX = "VTTAX";

        /// <summary>
        /// VTSTAM.
        /// </summary>
        public const string VTSTAM = "VTSTAM";

        /// <summary>
        /// VTATXA.
        /// </summary>
        public const string VTATXA = "VTATXA";

        /// <summary>
        /// VTCRCD.
        /// </summary>
        public const string VTCRCD = "VTCRCD";

        /// <summary>
        /// VTTX1.
        /// </summary>
        public const string VTTX1 = "VTTX1";

        /// <summary>
        /// VTCO.
        /// </summary>
        public const string VTCO = "VTCO";

        /// <summary>
        /// VTLMEM.
        /// </summary>
        public const string VTLMEM = "VTLMEM";

        /// <summary>
        /// VTB74PRCP.
        /// </summary>
        public const string VTB74PRCP = "VTB74PRCP";
    }

    /// <inheritdoc />
    public override string TableName => "F74B200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTAN8", "VTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VTALPH", "VTALPH", JdeDataType.String, 80),
        new JdeField("VTADD1", "VTADD1", JdeDataType.String, 80),
        new JdeField("VTADDZ", "VTADDZ", JdeDataType.String, 24),
        new JdeField("VTCTY1", "VTCTY1", JdeDataType.String, 50),
        new JdeField("VTTAX", "VTTAX", JdeDataType.String, 40),
        new JdeField("VTSTAM", "VTSTAM", JdeDataType.Numeric),
        new JdeField("VTATXA", "VTATXA", JdeDataType.Numeric),
        new JdeField("VTCRCD", "VTCRCD", JdeDataType.String, 6),
        new JdeField("VTTX1", "VTTX1", JdeDataType.String, 32),
        new JdeField("VTCO", "VTCO", JdeDataType.String, 10),
        new JdeField("VTLMEM", "VTLMEM", JdeDataType.String, 12, true, true),
        new JdeField("VTB74PRCP", "VTB74PRCP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74B200_0", "Primary Key on VTLMEM, VTAN8", new[] { "VTLMEM", "VTAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
