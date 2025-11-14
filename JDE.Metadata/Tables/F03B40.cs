using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B40 - .
/// </summary>
public class F03B40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBDCID.
        /// </summary>
        public const string RBDCID = "RBDCID";

        /// <summary>
        /// RBCLTY.
        /// </summary>
        public const string RBCLTY = "RBCLTY";

        /// <summary>
        /// RBPSDD.
        /// </summary>
        public const string RBPSDD = "RBPSDD";

        /// <summary>
        /// RBDDOA.
        /// </summary>
        public const string RBDDOA = "RBDDOA";

        /// <summary>
        /// RBDDA.
        /// </summary>
        public const string RBDDA = "RBDDA";

        /// <summary>
        /// RBFDOA.
        /// </summary>
        public const string RBFDOA = "RBFDOA";

        /// <summary>
        /// RBFDA.
        /// </summary>
        public const string RBFDA = "RBFDA";

        /// <summary>
        /// RBTDOA.
        /// </summary>
        public const string RBTDOA = "RBTDOA";

        /// <summary>
        /// RBTDA.
        /// </summary>
        public const string RBTDA = "RBTDA";

        /// <summary>
        /// RBDDEX.
        /// </summary>
        public const string RBDDEX = "RBDDEX";

        /// <summary>
        /// RBDDDO.
        /// </summary>
        public const string RBDDDO = "RBDDDO";

        /// <summary>
        /// RBDDTI.
        /// </summary>
        public const string RBDDTI = "RBDDTI";

        /// <summary>
        /// RBMAN8.
        /// </summary>
        public const string RBMAN8 = "RBMAN8";

        /// <summary>
        /// RBODOC.
        /// </summary>
        public const string RBODOC = "RBODOC";

        /// <summary>
        /// RBODCT.
        /// </summary>
        public const string RBODCT = "RBODCT";

        /// <summary>
        /// RBOSFX.
        /// </summary>
        public const string RBOSFX = "RBOSFX";

        /// <summary>
        /// RBOKCO.
        /// </summary>
        public const string RBOKCO = "RBOKCO";

        /// <summary>
        /// RBGDOC.
        /// </summary>
        public const string RBGDOC = "RBGDOC";

        /// <summary>
        /// RBGDCT.
        /// </summary>
        public const string RBGDCT = "RBGDCT";

        /// <summary>
        /// RBGSFX.
        /// </summary>
        public const string RBGSFX = "RBGSFX";

        /// <summary>
        /// RBGKCO.
        /// </summary>
        public const string RBGKCO = "RBGKCO";

        /// <summary>
        /// RBPYID.
        /// </summary>
        public const string RBPYID = "RBPYID";

        /// <summary>
        /// RBRC5.
        /// </summary>
        public const string RBRC5 = "RBRC5";

        /// <summary>
        /// RBVR01.
        /// </summary>
        public const string RBVR01 = "RBVR01";

        /// <summary>
        /// RBCO.
        /// </summary>
        public const string RBCO = "RBCO";

        /// <summary>
        /// RBTCRC.
        /// </summary>
        public const string RBTCRC = "RBTCRC";

        /// <summary>
        /// RBCRCD.
        /// </summary>
        public const string RBCRCD = "RBCRCD";

        /// <summary>
        /// RBBCRC.
        /// </summary>
        public const string RBBCRC = "RBBCRC";

        /// <summary>
        /// RBCRRM.
        /// </summary>
        public const string RBCRRM = "RBCRRM";

        /// <summary>
        /// RBNFVD.
        /// </summary>
        public const string RBNFVD = "RBNFVD";

        /// <summary>
        /// RBVRE.
        /// </summary>
        public const string RBVRE = "RBVRE";

        /// <summary>
        /// RBAN8.
        /// </summary>
        public const string RBAN8 = "RBAN8";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBPID.
        /// </summary>
        public const string RBPID = "RBPID";

        /// <summary>
        /// RBJOBN.
        /// </summary>
        public const string RBJOBN = "RBJOBN";

        /// <summary>
        /// RBUPMJ.
        /// </summary>
        public const string RBUPMJ = "RBUPMJ";

        /// <summary>
        /// RBUPMT.
        /// </summary>
        public const string RBUPMT = "RBUPMT";

        /// <summary>
        /// RBSHPN.
        /// </summary>
        public const string RBSHPN = "RBSHPN";

        /// <summary>
        /// RBSMIFL.
        /// </summary>
        public const string RBSMIFL = "RBSMIFL";
    }

    /// <inheritdoc />
    public override string TableName => "F03B40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBDCID", "RBDCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RBCLTY", "RBCLTY", JdeDataType.String, 4),
        new JdeField("RBPSDD", "RBPSDD", JdeDataType.String, 4),
        new JdeField("RBDDOA", "RBDDOA", JdeDataType.Numeric),
        new JdeField("RBDDA", "RBDDA", JdeDataType.Numeric),
        new JdeField("RBFDOA", "RBFDOA", JdeDataType.Numeric),
        new JdeField("RBFDA", "RBFDA", JdeDataType.Numeric),
        new JdeField("RBTDOA", "RBTDOA", JdeDataType.Numeric),
        new JdeField("RBTDA", "RBTDA", JdeDataType.Numeric),
        new JdeField("RBDDEX", "RBDDEX", JdeDataType.String, 4),
        new JdeField("RBDDDO", "RBDDDO", JdeDataType.Numeric),
        new JdeField("RBDDTI", "RBDDTI", JdeDataType.Numeric),
        new JdeField("RBMAN8", "RBMAN8", JdeDataType.Numeric),
        new JdeField("RBODOC", "RBODOC", JdeDataType.Numeric),
        new JdeField("RBODCT", "RBODCT", JdeDataType.String, 4),
        new JdeField("RBOSFX", "RBOSFX", JdeDataType.String, 6),
        new JdeField("RBOKCO", "RBOKCO", JdeDataType.String, 10),
        new JdeField("RBGDOC", "RBGDOC", JdeDataType.Numeric),
        new JdeField("RBGDCT", "RBGDCT", JdeDataType.String, 4),
        new JdeField("RBGSFX", "RBGSFX", JdeDataType.String, 6),
        new JdeField("RBGKCO", "RBGKCO", JdeDataType.String, 10),
        new JdeField("RBPYID", "RBPYID", JdeDataType.Numeric),
        new JdeField("RBRC5", "RBRC5", JdeDataType.Numeric),
        new JdeField("RBVR01", "RBVR01", JdeDataType.String, 50),
        new JdeField("RBCO", "RBCO", JdeDataType.String, 10),
        new JdeField("RBTCRC", "RBTCRC", JdeDataType.String, 6),
        new JdeField("RBCRCD", "RBCRCD", JdeDataType.String, 6),
        new JdeField("RBBCRC", "RBBCRC", JdeDataType.String, 6),
        new JdeField("RBCRRM", "RBCRRM", JdeDataType.String, 2),
        new JdeField("RBNFVD", "RBNFVD", JdeDataType.String, 2),
        new JdeField("RBVRE", "RBVRE", JdeDataType.String, 6),
        new JdeField("RBAN8", "RBAN8", JdeDataType.Numeric),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBUPMT", "RBUPMT", JdeDataType.Numeric),
        new JdeField("RBSHPN", "RBSHPN", JdeDataType.Numeric),
        new JdeField("RBSMIFL", "RBSMIFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B40_0", "Primary Key on RBDCID", new[] { "RBDCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B40_5", "Index on RBPYID, RBRC5, RBDCID", new[] { "RBPYID", "RBRC5", "RBDCID" })
    };
}
