using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4908 - .
/// </summary>
public class F4908 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IIITM.
        /// </summary>
        public const string IIITM = "IIITM";

        /// <summary>
        /// IIHSCD.
        /// </summary>
        public const string IIHSCD = "IIHSCD";

        /// <summary>
        /// IIPDCG.
        /// </summary>
        public const string IIPDCG = "IIPDCG";

        /// <summary>
        /// IIPFCT.
        /// </summary>
        public const string IIPFCT = "IIPFCT";

        /// <summary>
        /// IIDMFR.
        /// </summary>
        public const string IIDMFR = "IIDMFR";

        /// <summary>
        /// IIECCN.
        /// </summary>
        public const string IIECCN = "IIECCN";

        /// <summary>
        /// IIUNNA.
        /// </summary>
        public const string IIUNNA = "IIUNNA";

        /// <summary>
        /// IIHZDC.
        /// </summary>
        public const string IIHZDC = "IIHZDC";

        /// <summary>
        /// IIPKGP.
        /// </summary>
        public const string IIPKGP = "IIPKGP";

        /// <summary>
        /// IISRSK.
        /// </summary>
        public const string IISRSK = "IISRSK";

        /// <summary>
        /// IIFPNT.
        /// </summary>
        public const string IIFPNT = "IIFPNT";

        /// <summary>
        /// IISTPU.
        /// </summary>
        public const string IISTPU = "IISTPU";

        /// <summary>
        /// IIPKIN.
        /// </summary>
        public const string IIPKIN = "IIPKIN";

        /// <summary>
        /// IIHZDL.
        /// </summary>
        public const string IIHZDL = "IIHZDL";

        /// <summary>
        /// IINMFI.
        /// </summary>
        public const string IINMFI = "IINMFI";

        /// <summary>
        /// IINMFC.
        /// </summary>
        public const string IINMFC = "IINMFC";

        /// <summary>
        /// IISTCC.
        /// </summary>
        public const string IISTCC = "IISTCC";

        /// <summary>
        /// IIFRT1.
        /// </summary>
        public const string IIFRT1 = "IIFRT1";

        /// <summary>
        /// IIFRT2.
        /// </summary>
        public const string IIFRT2 = "IIFRT2";

        /// <summary>
        /// IIUSER.
        /// </summary>
        public const string IIUSER = "IIUSER";

        /// <summary>
        /// IIPID.
        /// </summary>
        public const string IIPID = "IIPID";

        /// <summary>
        /// IIJOBN.
        /// </summary>
        public const string IIJOBN = "IIJOBN";

        /// <summary>
        /// IIUPMJ.
        /// </summary>
        public const string IIUPMJ = "IIUPMJ";

        /// <summary>
        /// IITDAY.
        /// </summary>
        public const string IITDAY = "IITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4908";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IIITM", "IIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IIHSCD", "IIHSCD", JdeDataType.String, 24),
        new JdeField("IIPDCG", "IIPDCG", JdeDataType.String, 8),
        new JdeField("IIPFCT", "IIPFCT", JdeDataType.String, 2),
        new JdeField("IIDMFR", "IIDMFR", JdeDataType.String, 2),
        new JdeField("IIECCN", "IIECCN", JdeDataType.String, 20),
        new JdeField("IIUNNA", "IIUNNA", JdeDataType.String, 12),
        new JdeField("IIHZDC", "IIHZDC", JdeDataType.String, 6),
        new JdeField("IIPKGP", "IIPKGP", JdeDataType.String, 6),
        new JdeField("IISRSK", "IISRSK", JdeDataType.String, 6),
        new JdeField("IIFPNT", "IIFPNT", JdeDataType.Numeric),
        new JdeField("IISTPU", "IISTPU", JdeDataType.String, 2),
        new JdeField("IIPKIN", "IIPKIN", JdeDataType.String, 8),
        new JdeField("IIHZDL", "IIHZDL", JdeDataType.String, 6),
        new JdeField("IINMFI", "IINMFI", JdeDataType.String, 12),
        new JdeField("IINMFC", "IINMFC", JdeDataType.String, 8),
        new JdeField("IISTCC", "IISTCC", JdeDataType.String, 20),
        new JdeField("IIFRT1", "IIFRT1", JdeDataType.String, 12),
        new JdeField("IIFRT2", "IIFRT2", JdeDataType.String, 12),
        new JdeField("IIUSER", "IIUSER", JdeDataType.String, 20),
        new JdeField("IIPID", "IIPID", JdeDataType.String, 20),
        new JdeField("IIJOBN", "IIJOBN", JdeDataType.String, 20),
        new JdeField("IIUPMJ", "IIUPMJ", JdeDataType.Numeric),
        new JdeField("IITDAY", "IITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4908_0", "Primary Key on IIITM", new[] { "IIITM" }, isUnique: true, isPrimaryKey: true)
    };
}
