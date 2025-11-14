using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I611 - .
/// </summary>
public class F75I611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTDOC.
        /// </summary>
        public const string TTDOC = "TTDOC";

        /// <summary>
        /// TTDCT.
        /// </summary>
        public const string TTDCT = "TTDCT";

        /// <summary>
        /// TTKCO.
        /// </summary>
        public const string TTKCO = "TTKCO";

        /// <summary>
        /// TTSFX.
        /// </summary>
        public const string TTSFX = "TTSFX";

        /// <summary>
        /// TTPYID.
        /// </summary>
        public const string TTPYID = "TTPYID";

        /// <summary>
        /// TTRC5.
        /// </summary>
        public const string TTRC5 = "TTRC5";

        /// <summary>
        /// TTITM.
        /// </summary>
        public const string TTITM = "TTITM";

        /// <summary>
        /// TTLITM.
        /// </summary>
        public const string TTLITM = "TTLITM";

        /// <summary>
        /// TTCKNU.
        /// </summary>
        public const string TTCKNU = "TTCKNU";

        /// <summary>
        /// TTDGJ.
        /// </summary>
        public const string TTDGJ = "TTDGJ";

        /// <summary>
        /// TTDMTJ.
        /// </summary>
        public const string TTDMTJ = "TTDMTJ";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTALPH.
        /// </summary>
        public const string TTALPH = "TTALPH";

        /// <summary>
        /// TTANI.
        /// </summary>
        public const string TTANI = "TTANI";

        /// <summary>
        /// TTICU.
        /// </summary>
        public const string TTICU = "TTICU";

        /// <summary>
        /// TTICUT.
        /// </summary>
        public const string TTICUT = "TTICUT";

        /// <summary>
        /// TTDICJ.
        /// </summary>
        public const string TTDICJ = "TTDICJ";

        /// <summary>
        /// TTCKAM.
        /// </summary>
        public const string TTCKAM = "TTCKAM";

        /// <summary>
        /// TTI75TOT.
        /// </summary>
        public const string TTI75TOT = "TTI75TOT";

        /// <summary>
        /// TTI75SURC.
        /// </summary>
        public const string TTI75SURC = "TTI75SURC";

        /// <summary>
        /// TTI75CESS.
        /// </summary>
        public const string TTI75CESS = "TTI75CESS";

        /// <summary>
        /// TTAEXP.
        /// </summary>
        public const string TTAEXP = "TTAEXP";

        /// <summary>
        /// TTI75TTR.
        /// </summary>
        public const string TTI75TTR = "TTI75TTR";

        /// <summary>
        /// TTI75TSUR.
        /// </summary>
        public const string TTI75TSUR = "TTI75TSUR";

        /// <summary>
        /// TTI75CESR.
        /// </summary>
        public const string TTI75CESR = "TTI75CESR";

        /// <summary>
        /// TTI75TCS1.
        /// </summary>
        public const string TTI75TCS1 = "TTI75TCS1";

        /// <summary>
        /// TTI75TCS2.
        /// </summary>
        public const string TTI75TCS2 = "TTI75TCS2";

        /// <summary>
        /// TTBCRC.
        /// </summary>
        public const string TTBCRC = "TTBCRC";

        /// <summary>
        /// TTMCU.
        /// </summary>
        public const string TTMCU = "TTMCU";

        /// <summary>
        /// TTCO.
        /// </summary>
        public const string TTCO = "TTCO";

        /// <summary>
        /// TTI75PYD.
        /// </summary>
        public const string TTI75PYD = "TTI75PYD";

        /// <summary>
        /// TTI75ICC.
        /// </summary>
        public const string TTI75ICC = "TTI75ICC";

        /// <summary>
        /// TTEV01.
        /// </summary>
        public const string TTEV01 = "TTEV01";

        /// <summary>
        /// TTI75VNBR.
        /// </summary>
        public const string TTI75VNBR = "TTI75VNBR";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTDOC", "TTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCT", "TTDCT", JdeDataType.String, 4, true, true),
        new JdeField("TTKCO", "TTKCO", JdeDataType.String, 10, true, true),
        new JdeField("TTSFX", "TTSFX", JdeDataType.String, 6, true, true),
        new JdeField("TTPYID", "TTPYID", JdeDataType.Numeric),
        new JdeField("TTRC5", "TTRC5", JdeDataType.Numeric),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric),
        new JdeField("TTLITM", "TTLITM", JdeDataType.String, 50),
        new JdeField("TTCKNU", "TTCKNU", JdeDataType.String, 50),
        new JdeField("TTDGJ", "TTDGJ", JdeDataType.Numeric),
        new JdeField("TTDMTJ", "TTDMTJ", JdeDataType.Numeric),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric),
        new JdeField("TTALPH", "TTALPH", JdeDataType.String, 80),
        new JdeField("TTANI", "TTANI", JdeDataType.String, 58),
        new JdeField("TTICU", "TTICU", JdeDataType.Numeric),
        new JdeField("TTICUT", "TTICUT", JdeDataType.String, 4),
        new JdeField("TTDICJ", "TTDICJ", JdeDataType.Numeric),
        new JdeField("TTCKAM", "TTCKAM", JdeDataType.Numeric),
        new JdeField("TTI75TOT", "TTI75TOT", JdeDataType.Numeric),
        new JdeField("TTI75SURC", "TTI75SURC", JdeDataType.Numeric),
        new JdeField("TTI75CESS", "TTI75CESS", JdeDataType.Numeric),
        new JdeField("TTAEXP", "TTAEXP", JdeDataType.Numeric),
        new JdeField("TTI75TTR", "TTI75TTR", JdeDataType.Numeric),
        new JdeField("TTI75TSUR", "TTI75TSUR", JdeDataType.Numeric),
        new JdeField("TTI75CESR", "TTI75CESR", JdeDataType.Numeric),
        new JdeField("TTI75TCS1", "TTI75TCS1", JdeDataType.Numeric),
        new JdeField("TTI75TCS2", "TTI75TCS2", JdeDataType.Numeric),
        new JdeField("TTBCRC", "TTBCRC", JdeDataType.String, 6),
        new JdeField("TTMCU", "TTMCU", JdeDataType.String, 24),
        new JdeField("TTCO", "TTCO", JdeDataType.String, 10),
        new JdeField("TTI75PYD", "TTI75PYD", JdeDataType.Numeric),
        new JdeField("TTI75ICC", "TTI75ICC", JdeDataType.String, 2),
        new JdeField("TTEV01", "TTEV01", JdeDataType.String, 2),
        new JdeField("TTI75VNBR", "TTI75VNBR", JdeDataType.Numeric),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I611_0", "Primary Key on TTDOC, TTDCT, TTKCO, TTSFX", new[] { "TTDOC", "TTDCT", "TTKCO", "TTSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I611_2", "Index on TTPYID, TTRC5", new[] { "TTPYID", "TTRC5" }),
        new JdeIndex("F75I611_3", "Index on TTDMTJ, TTAN8, TTCO, TTMCU", new[] { "TTDMTJ", "TTAN8", "TTCO", "TTMCU" }),
        new JdeIndex("F75I611_4", "Index on TTAN8, TTCO, TTMCU, TTI75ICC, TTEV01", new[] { "TTAN8", "TTCO", "TTMCU", "TTI75ICC", "TTEV01" })
    };
}
