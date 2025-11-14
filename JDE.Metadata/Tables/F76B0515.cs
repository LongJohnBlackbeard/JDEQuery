using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0515 - .
/// </summary>
public class F76B0515 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCO.
        /// </summary>
        public const string CSCO = "CSCO";

        /// <summary>
        /// CSB76AN8O.
        /// </summary>
        public const string CSB76AN8O = "CSB76AN8O";

        /// <summary>
        /// CSB76AN8A.
        /// </summary>
        public const string CSB76AN8A = "CSB76AN8A";

        /// <summary>
        /// CSB76AN8R.
        /// </summary>
        public const string CSB76AN8R = "CSB76AN8R";

        /// <summary>
        /// CSB76VLCO.
        /// </summary>
        public const string CSB76VLCO = "CSB76VLCO";

        /// <summary>
        /// CSB76VLCR.
        /// </summary>
        public const string CSB76VLCR = "CSB76VLCR";

        /// <summary>
        /// CSB76COPU.
        /// </summary>
        public const string CSB76COPU = "CSB76COPU";

        /// <summary>
        /// CSB76ITIN.
        /// </summary>
        public const string CSB76ITIN = "CSB76ITIN";

        /// <summary>
        /// CSB76ICBO.
        /// </summary>
        public const string CSB76ICBO = "CSB76ICBO";

        /// <summary>
        /// CSB76CCNU.
        /// </summary>
        public const string CSB76CCNU = "CSB76CCNU";

        /// <summary>
        /// CSB76BCRC.
        /// </summary>
        public const string CSB76BCRC = "CSB76BCRC";

        /// <summary>
        /// CSTYC.
        /// </summary>
        public const string CSTYC = "CSTYC";

        /// <summary>
        /// CSB76BMFU.
        /// </summary>
        public const string CSB76BMFU = "CSB76BMFU";

        /// <summary>
        /// CSB76BANCC.
        /// </summary>
        public const string CSB76BANCC = "CSB76BANCC";

        /// <summary>
        /// CSURCD.
        /// </summary>
        public const string CSURCD = "CSURCD";

        /// <summary>
        /// CSURDT.
        /// </summary>
        public const string CSURDT = "CSURDT";

        /// <summary>
        /// CSURAT.
        /// </summary>
        public const string CSURAT = "CSURAT";

        /// <summary>
        /// CSURAB.
        /// </summary>
        public const string CSURAB = "CSURAB";

        /// <summary>
        /// CSURRF.
        /// </summary>
        public const string CSURRF = "CSURRF";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0515";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true),
        new JdeField("CSB76AN8O", "CSB76AN8O", JdeDataType.Numeric),
        new JdeField("CSB76AN8A", "CSB76AN8A", JdeDataType.Numeric),
        new JdeField("CSB76AN8R", "CSB76AN8R", JdeDataType.Numeric),
        new JdeField("CSB76VLCO", "CSB76VLCO", JdeDataType.String, 6),
        new JdeField("CSB76VLCR", "CSB76VLCR", JdeDataType.String, 6),
        new JdeField("CSB76COPU", "CSB76COPU", JdeDataType.String, 6),
        new JdeField("CSB76ITIN", "CSB76ITIN", JdeDataType.String, 2),
        new JdeField("CSB76ICBO", "CSB76ICBO", JdeDataType.String, 2),
        new JdeField("CSB76CCNU", "CSB76CCNU", JdeDataType.Numeric),
        new JdeField("CSB76BCRC", "CSB76BCRC", JdeDataType.String, 22),
        new JdeField("CSTYC", "CSTYC", JdeDataType.String, 2),
        new JdeField("CSB76BMFU", "CSB76BMFU", JdeDataType.String, 24),
        new JdeField("CSB76BANCC", "CSB76BANCC", JdeDataType.Numeric),
        new JdeField("CSURCD", "CSURCD", JdeDataType.String, 4),
        new JdeField("CSURDT", "CSURDT", JdeDataType.Numeric),
        new JdeField("CSURAT", "CSURAT", JdeDataType.Numeric),
        new JdeField("CSURAB", "CSURAB", JdeDataType.Numeric),
        new JdeField("CSURRF", "CSURRF", JdeDataType.String, 30),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0515_0", "Primary Key on CSCO", new[] { "CSCO" }, isUnique: true, isPrimaryKey: true)
    };
}
