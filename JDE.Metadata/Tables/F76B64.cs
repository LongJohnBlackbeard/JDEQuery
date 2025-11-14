using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B64 - .
/// </summary>
public class F76B64 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSCO.
        /// </summary>
        public const string BSCO = "BSCO";

        /// <summary>
        /// BSMCU.
        /// </summary>
        public const string BSMCU = "BSMCU";

        /// <summary>
        /// BSOBJ.
        /// </summary>
        public const string BSOBJ = "BSOBJ";

        /// <summary>
        /// BSSUB.
        /// </summary>
        public const string BSSUB = "BSSUB";

        /// <summary>
        /// BSSBL.
        /// </summary>
        public const string BSSBL = "BSSBL";

        /// <summary>
        /// BSBRNCB.
        /// </summary>
        public const string BSBRNCB = "BSBRNCB";

        /// <summary>
        /// BSBRNBP.
        /// </summary>
        public const string BSBRNBP = "BSBRNBP";

        /// <summary>
        /// BSBRTPM.
        /// </summary>
        public const string BSBRTPM = "BSBRTPM";

        /// <summary>
        /// BSDGJ.
        /// </summary>
        public const string BSDGJ = "BSDGJ";

        /// <summary>
        /// BSAA.
        /// </summary>
        public const string BSAA = "BSAA";

        /// <summary>
        /// BSBRQTI.
        /// </summary>
        public const string BSBRQTI = "BSBRQTI";

        /// <summary>
        /// BSBRSIG.
        /// </summary>
        public const string BSBRSIG = "BSBRSIG";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B64";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSCO", "BSCO", JdeDataType.String, 10, true, true),
        new JdeField("BSMCU", "BSMCU", JdeDataType.String, 24),
        new JdeField("BSOBJ", "BSOBJ", JdeDataType.String, 12),
        new JdeField("BSSUB", "BSSUB", JdeDataType.String, 16),
        new JdeField("BSSBL", "BSSBL", JdeDataType.String, 16),
        new JdeField("BSBRNCB", "BSBRNCB", JdeDataType.String, 50, true, true),
        new JdeField("BSBRNBP", "BSBRNBP", JdeDataType.String, 50, true, true),
        new JdeField("BSBRTPM", "BSBRTPM", JdeDataType.Numeric),
        new JdeField("BSDGJ", "BSDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BSAA", "BSAA", JdeDataType.Numeric),
        new JdeField("BSBRQTI", "BSBRQTI", JdeDataType.Numeric),
        new JdeField("BSBRSIG", "BSBRSIG", JdeDataType.String, 16),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B64_0", "Primary Key on BSCO, BSBRNCB, BSBRNBP, BSDGJ", new[] { "BSCO", "BSBRNCB", "BSBRNBP", "BSDGJ" }, isUnique: true, isPrimaryKey: true)
    };
}
