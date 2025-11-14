using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0715 - .
/// </summary>
public class F76B0715 : JdeTable
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
        /// CSB76AN8A.
        /// </summary>
        public const string CSB76AN8A = "CSB76AN8A";

        /// <summary>
        /// CSB76BCRC.
        /// </summary>
        public const string CSB76BCRC = "CSB76BCRC";

        /// <summary>
        /// CSB76VLCO.
        /// </summary>
        public const string CSB76VLCO = "CSB76VLCO";

        /// <summary>
        /// CSB76CCNU.
        /// </summary>
        public const string CSB76CCNU = "CSB76CCNU";

        /// <summary>
        /// CSB76AN8C.
        /// </summary>
        public const string CSB76AN8C = "CSB76AN8C";

        /// <summary>
        /// CSB76FPTY.
        /// </summary>
        public const string CSB76FPTY = "CSB76FPTY";

        /// <summary>
        /// CSB76ACCO.
        /// </summary>
        public const string CSB76ACCO = "CSB76ACCO";

        /// <summary>
        /// CSTYC.
        /// </summary>
        public const string CSTYC = "CSTYC";

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
    public override string TableName => "F76B0715";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true),
        new JdeField("CSB76AN8A", "CSB76AN8A", JdeDataType.Numeric),
        new JdeField("CSB76BCRC", "CSB76BCRC", JdeDataType.String, 22),
        new JdeField("CSB76VLCO", "CSB76VLCO", JdeDataType.String, 6),
        new JdeField("CSB76CCNU", "CSB76CCNU", JdeDataType.Numeric),
        new JdeField("CSB76AN8C", "CSB76AN8C", JdeDataType.Numeric),
        new JdeField("CSB76FPTY", "CSB76FPTY", JdeDataType.String, 2),
        new JdeField("CSB76ACCO", "CSB76ACCO", JdeDataType.String, 2),
        new JdeField("CSTYC", "CSTYC", JdeDataType.String, 2),
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
        new JdeIndex("F76B0715_0", "Primary Key on CSCO", new[] { "CSCO" }, isUnique: true, isPrimaryKey: true)
    };
}
