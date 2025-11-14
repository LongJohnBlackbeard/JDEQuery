using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B105 - .
/// </summary>
public class F76B105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QCFCO.
        /// </summary>
        public const string QCFCO = "QCFCO";

        /// <summary>
        /// QCBRAGNR.
        /// </summary>
        public const string QCBRAGNR = "QCBRAGNR";

        /// <summary>
        /// QCBCGC.
        /// </summary>
        public const string QCBCGC = "QCBCGC";

        /// <summary>
        /// QCBRAEST.
        /// </summary>
        public const string QCBRAEST = "QCBRAEST";

        /// <summary>
        /// QCBRADLJ.
        /// </summary>
        public const string QCBRADLJ = "QCBRADLJ";

        /// <summary>
        /// QCBRAUFE.
        /// </summary>
        public const string QCBRAUFE = "QCBRAUFE";

        /// <summary>
        /// QCADDS.
        /// </summary>
        public const string QCADDS = "QCADDS";

        /// <summary>
        /// QCBRABCO.
        /// </summary>
        public const string QCBRABCO = "QCBRABCO";

        /// <summary>
        /// QCBRAAGC.
        /// </summary>
        public const string QCBRAAGC = "QCBRAAGC";

        /// <summary>
        /// QCBRADEJ.
        /// </summary>
        public const string QCBRADEJ = "QCBRADEJ";

        /// <summary>
        /// QCPRIC.
        /// </summary>
        public const string QCPRIC = "QCPRIC";

        /// <summary>
        /// QCBRAMFG.
        /// </summary>
        public const string QCBRAMFG = "QCBRAMFG";

        /// <summary>
        /// QCBRAAFG.
        /// </summary>
        public const string QCBRAAFG = "QCBRAAFG";

        /// <summary>
        /// QCDSC1.
        /// </summary>
        public const string QCDSC1 = "QCDSC1";

        /// <summary>
        /// QCBRGNRE.
        /// </summary>
        public const string QCBRGNRE = "QCBRGNRE";
    }

    /// <inheritdoc />
    public override string TableName => "F76B105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QCFCO", "QCFCO", JdeDataType.String, 10, true, true),
        new JdeField("QCBRAGNR", "QCBRAGNR", JdeDataType.Numeric),
        new JdeField("QCBCGC", "QCBCGC", JdeDataType.String, 30),
        new JdeField("QCBRAEST", "QCBRAEST", JdeDataType.String, 40),
        new JdeField("QCBRADLJ", "QCBRADLJ", JdeDataType.Numeric),
        new JdeField("QCBRAUFE", "QCBRAUFE", JdeDataType.String, 6),
        new JdeField("QCADDS", "QCADDS", JdeDataType.String, 6),
        new JdeField("QCBRABCO", "QCBRABCO", JdeDataType.Numeric),
        new JdeField("QCBRAAGC", "QCBRAAGC", JdeDataType.Numeric),
        new JdeField("QCBRADEJ", "QCBRADEJ", JdeDataType.Numeric),
        new JdeField("QCPRIC", "QCPRIC", JdeDataType.Numeric),
        new JdeField("QCBRAMFG", "QCBRAMFG", JdeDataType.Numeric),
        new JdeField("QCBRAAFG", "QCBRAAFG", JdeDataType.Numeric),
        new JdeField("QCDSC1", "QCDSC1", JdeDataType.String, 60),
        new JdeField("QCBRGNRE", "QCBRGNRE", JdeDataType.String, 40, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B105_0", "Primary Key on QCFCO, QCBRGNRE", new[] { "QCFCO", "QCBRGNRE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B105_2", "Index on QCBRADLJ", new[] { "QCBRADLJ" })
    };
}
