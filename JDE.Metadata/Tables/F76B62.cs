using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B62 - .
/// </summary>
public class F76B62 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BICO.
        /// </summary>
        public const string BICO = "BICO";

        /// <summary>
        /// BIUPMJ.
        /// </summary>
        public const string BIUPMJ = "BIUPMJ";

        /// <summary>
        /// BIBRNCB.
        /// </summary>
        public const string BIBRNCB = "BIBRNCB";

        /// <summary>
        /// BIBRDSB.
        /// </summary>
        public const string BIBRDSB = "BIBRDSB";

        /// <summary>
        /// BIBRNBP.
        /// </summary>
        public const string BIBRNBP = "BIBRNBP";

        /// <summary>
        /// BIMCU.
        /// </summary>
        public const string BIMCU = "BIMCU";

        /// <summary>
        /// BIBRCD#.
        /// </summary>
        public const string BIBRCD_ = "BIBRCD#";

        /// <summary>
        /// BIDAJ.
        /// </summary>
        public const string BIDAJ = "BIDAJ";

        /// <summary>
        /// BIBRTPD.
        /// </summary>
        public const string BIBRTPD = "BIBRTPD";

        /// <summary>
        /// BIBRNDA.
        /// </summary>
        public const string BIBRNDA = "BIBRNDA";

        /// <summary>
        /// BIBRNSR.
        /// </summary>
        public const string BIBRNSR = "BIBRNSR";

        /// <summary>
        /// BIBRCSB.
        /// </summary>
        public const string BIBRCSB = "BIBRCSB";

        /// <summary>
        /// BIBRVAB.
        /// </summary>
        public const string BIBRVAB = "BIBRVAB";

        /// <summary>
        /// BIBRQTI.
        /// </summary>
        public const string BIBRQTI = "BIBRQTI";

        /// <summary>
        /// BIBRSIG.
        /// </summary>
        public const string BIBRSIG = "BIBRSIG";

        /// <summary>
        /// BIBRNAL.
        /// </summary>
        public const string BIBRNAL = "BIBRNAL";

        /// <summary>
        /// BIBRTDA.
        /// </summary>
        public const string BIBRTDA = "BIBRTDA";

        /// <summary>
        /// BIBRDIC.
        /// </summary>
        public const string BIBRDIC = "BIBRDIC";

        /// <summary>
        /// BIBRDID.
        /// </summary>
        public const string BIBRDID = "BIBRDID";

        /// <summary>
        /// BIBRDBX.
        /// </summary>
        public const string BIBRDBX = "BIBRDBX";

        /// <summary>
        /// BIAMCU.
        /// </summary>
        public const string BIAMCU = "BIAMCU";

        /// <summary>
        /// BIAOBJ.
        /// </summary>
        public const string BIAOBJ = "BIAOBJ";

        /// <summary>
        /// BIASUB.
        /// </summary>
        public const string BIASUB = "BIASUB";

        /// <summary>
        /// BIASBL.
        /// </summary>
        public const string BIASBL = "BIASBL";

        /// <summary>
        /// BIDMCU.
        /// </summary>
        public const string BIDMCU = "BIDMCU";

        /// <summary>
        /// BIDOBJ.
        /// </summary>
        public const string BIDOBJ = "BIDOBJ";

        /// <summary>
        /// BIDSUB.
        /// </summary>
        public const string BIDSUB = "BIDSUB";

        /// <summary>
        /// BITSBL.
        /// </summary>
        public const string BITSBL = "BITSBL";

        /// <summary>
        /// BIUSER.
        /// </summary>
        public const string BIUSER = "BIUSER";

        /// <summary>
        /// BIPID.
        /// </summary>
        public const string BIPID = "BIPID";

        /// <summary>
        /// BIJOBN.
        /// </summary>
        public const string BIJOBN = "BIJOBN";

        /// <summary>
        /// BIBRUPMJ.
        /// </summary>
        public const string BIBRUPMJ = "BIBRUPMJ";

        /// <summary>
        /// BIUPMT.
        /// </summary>
        public const string BIUPMT = "BIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B62";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BICO", "BICO", JdeDataType.String, 10, true, true),
        new JdeField("BIUPMJ", "BIUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BIBRNCB", "BIBRNCB", JdeDataType.String, 50, true, true),
        new JdeField("BIBRDSB", "BIBRDSB", JdeDataType.String, 90),
        new JdeField("BIBRNBP", "BIBRNBP", JdeDataType.String, 50, true, true),
        new JdeField("BIMCU", "BIMCU", JdeDataType.String, 24),
        new JdeField("BIBRCD#", "BIBRCD#", JdeDataType.String, 24),
        new JdeField("BIDAJ", "BIDAJ", JdeDataType.Numeric),
        new JdeField("BIBRTPD", "BIBRTPD", JdeDataType.String, 6),
        new JdeField("BIBRNDA", "BIBRNDA", JdeDataType.String, 24),
        new JdeField("BIBRNSR", "BIBRNSR", JdeDataType.String, 24),
        new JdeField("BIBRCSB", "BIBRCSB", JdeDataType.String, 6),
        new JdeField("BIBRVAB", "BIBRVAB", JdeDataType.Numeric),
        new JdeField("BIBRQTI", "BIBRQTI", JdeDataType.Numeric),
        new JdeField("BIBRSIG", "BIBRSIG", JdeDataType.String, 16),
        new JdeField("BIBRNAL", "BIBRNAL", JdeDataType.String, 24),
        new JdeField("BIBRTDA", "BIBRTDA", JdeDataType.Numeric),
        new JdeField("BIBRDIC", "BIBRDIC", JdeDataType.Numeric),
        new JdeField("BIBRDID", "BIBRDID", JdeDataType.Numeric),
        new JdeField("BIBRDBX", "BIBRDBX", JdeDataType.Numeric),
        new JdeField("BIAMCU", "BIAMCU", JdeDataType.String, 24),
        new JdeField("BIAOBJ", "BIAOBJ", JdeDataType.String, 12),
        new JdeField("BIASUB", "BIASUB", JdeDataType.String, 16),
        new JdeField("BIASBL", "BIASBL", JdeDataType.String, 16),
        new JdeField("BIDMCU", "BIDMCU", JdeDataType.String, 24),
        new JdeField("BIDOBJ", "BIDOBJ", JdeDataType.String, 12),
        new JdeField("BIDSUB", "BIDSUB", JdeDataType.String, 16),
        new JdeField("BITSBL", "BITSBL", JdeDataType.String, 16),
        new JdeField("BIUSER", "BIUSER", JdeDataType.String, 20),
        new JdeField("BIPID", "BIPID", JdeDataType.String, 20),
        new JdeField("BIJOBN", "BIJOBN", JdeDataType.String, 20),
        new JdeField("BIBRUPMJ", "BIBRUPMJ", JdeDataType.Numeric),
        new JdeField("BIUPMT", "BIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B62_0", "Primary Key on BICO, BIBRNCB, BIBRNBP, BIUPMJ", new[] { "BICO", "BIBRNCB", "BIBRNBP", "BIUPMJ" }, isUnique: true, isPrimaryKey: true)
    };
}
