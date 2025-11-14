using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B415 - .
/// </summary>
public class F76B415 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSKCO.
        /// </summary>
        public const string CSKCO = "CSKCO";

        /// <summary>
        /// CSDOC.
        /// </summary>
        public const string CSDOC = "CSDOC";

        /// <summary>
        /// CSDCT.
        /// </summary>
        public const string CSDCT = "CSDCT";

        /// <summary>
        /// CSSFX.
        /// </summary>
        public const string CSSFX = "CSSFX";

        /// <summary>
        /// CSSFXE.
        /// </summary>
        public const string CSSFXE = "CSSFXE";

        /// <summary>
        /// CSB76CTYC.
        /// </summary>
        public const string CSB76CTYC = "CSB76CTYC";

        /// <summary>
        /// CSB76SVTC.
        /// </summary>
        public const string CSB76SVTC = "CSB76SVTC";

        /// <summary>
        /// CSBRTXTP.
        /// </summary>
        public const string CSBRTXTP = "CSBRTXTP";

        /// <summary>
        /// CSB76SFCP.
        /// </summary>
        public const string CSB76SFCP = "CSB76SFCP";

        /// <summary>
        /// CSB76SENC.
        /// </summary>
        public const string CSB76SENC = "CSB76SENC";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

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
    public override string TableName => "F76B415";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSKCO", "CSKCO", JdeDataType.String, 10, true, true),
        new JdeField("CSDOC", "CSDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CSDCT", "CSDCT", JdeDataType.String, 4, true, true),
        new JdeField("CSSFX", "CSSFX", JdeDataType.String, 6, true, true),
        new JdeField("CSSFXE", "CSSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("CSB76CTYC", "CSB76CTYC", JdeDataType.String, 20),
        new JdeField("CSB76SVTC", "CSB76SVTC", JdeDataType.String, 20),
        new JdeField("CSBRTXTP", "CSBRTXTP", JdeDataType.String, 4),
        new JdeField("CSB76SFCP", "CSB76SFCP", JdeDataType.String, 60),
        new JdeField("CSB76SENC", "CSB76SENC", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B415_0", "Primary Key on CSKCO, CSDOC, CSDCT, CSSFX, CSSFXE", new[] { "CSKCO", "CSDOC", "CSDCT", "CSSFX", "CSSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
