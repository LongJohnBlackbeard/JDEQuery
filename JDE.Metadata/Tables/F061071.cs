using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F061071 - .
/// </summary>
public class F061071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J$AN8.
        /// </summary>
        public const string J_AN8 = "J$AN8";

        /// <summary>
        /// J$PDBA.
        /// </summary>
        public const string J_PDBA = "J$PDBA";

        /// <summary>
        /// J$WANO.
        /// </summary>
        public const string J_WANO = "J$WANO";

        /// <summary>
        /// J$WAF1.
        /// </summary>
        public const string J_WAF1 = "J$WAF1";

        /// <summary>
        /// J$WAF2.
        /// </summary>
        public const string J_WAF2 = "J$WAF2";

        /// <summary>
        /// J$WAD1.
        /// </summary>
        public const string J_WAD1 = "J$WAD1";

        /// <summary>
        /// J$WAD2.
        /// </summary>
        public const string J_WAD2 = "J$WAD2";

        /// <summary>
        /// J$PPDL.
        /// </summary>
        public const string J_PPDL = "J$PPDL";

        /// <summary>
        /// J$MDL.
        /// </summary>
        public const string J_MDL = "J$MDL";

        /// <summary>
        /// J$QDL.
        /// </summary>
        public const string J_QDL = "J$QDL";

        /// <summary>
        /// J$ADL.
        /// </summary>
        public const string J_ADL = "J$ADL";

        /// <summary>
        /// J$PDLA.
        /// </summary>
        public const string J_PDLA = "J$PDLA";

        /// <summary>
        /// J$MDLA.
        /// </summary>
        public const string J_MDLA = "J$MDLA";

        /// <summary>
        /// J$QDLA.
        /// </summary>
        public const string J_QDLA = "J$QDLA";

        /// <summary>
        /// J$ADLA.
        /// </summary>
        public const string J_ADLA = "J$ADLA";

        /// <summary>
        /// J$WAF3.
        /// </summary>
        public const string J_WAF3 = "J$WAF3";

        /// <summary>
        /// J$WAD3.
        /// </summary>
        public const string J_WAD3 = "J$WAD3";

        /// <summary>
        /// J$PDLL.
        /// </summary>
        public const string J_PDLL = "J$PDLL";

        /// <summary>
        /// J$MDLL.
        /// </summary>
        public const string J_MDLL = "J$MDLL";

        /// <summary>
        /// J$QDLL.
        /// </summary>
        public const string J_QDLL = "J$QDLL";

        /// <summary>
        /// J$ADLL.
        /// </summary>
        public const string J_ADLL = "J$ADLL";

        /// <summary>
        /// J$WAS1.
        /// </summary>
        public const string J_WAS1 = "J$WAS1";

        /// <summary>
        /// J$LADL.
        /// </summary>
        public const string J_LADL = "J$LADL";
    }

    /// <inheritdoc />
    public override string TableName => "F061071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J$AN8", "J$AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J$PDBA", "J$PDBA", JdeDataType.Numeric),
        new JdeField("J$WANO", "J$WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("J$WAF1", "J$WAF1", JdeDataType.Numeric),
        new JdeField("J$WAF2", "J$WAF2", JdeDataType.Numeric),
        new JdeField("J$WAD1", "J$WAD1", JdeDataType.Numeric),
        new JdeField("J$WAD2", "J$WAD2", JdeDataType.Numeric),
        new JdeField("J$PPDL", "J$PPDL", JdeDataType.Numeric),
        new JdeField("J$MDL", "J$MDL", JdeDataType.Numeric),
        new JdeField("J$QDL", "J$QDL", JdeDataType.Numeric),
        new JdeField("J$ADL", "J$ADL", JdeDataType.Numeric),
        new JdeField("J$PDLA", "J$PDLA", JdeDataType.Numeric),
        new JdeField("J$MDLA", "J$MDLA", JdeDataType.Numeric),
        new JdeField("J$QDLA", "J$QDLA", JdeDataType.Numeric),
        new JdeField("J$ADLA", "J$ADLA", JdeDataType.Numeric),
        new JdeField("J$WAF3", "J$WAF3", JdeDataType.Numeric),
        new JdeField("J$WAD3", "J$WAD3", JdeDataType.Numeric),
        new JdeField("J$PDLL", "J$PDLL", JdeDataType.Numeric),
        new JdeField("J$MDLL", "J$MDLL", JdeDataType.Numeric),
        new JdeField("J$QDLL", "J$QDLL", JdeDataType.Numeric),
        new JdeField("J$ADLL", "J$ADLL", JdeDataType.Numeric),
        new JdeField("J$WAS1", "J$WAS1", JdeDataType.Numeric),
        new JdeField("J$LADL", "J$LADL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F061071_0", "Primary Key on J$AN8, J$WANO", new[] { "J$AN8", "J$WANO" }, isUnique: true, isPrimaryKey: true)
    };
}
