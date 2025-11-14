using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I604 - .
/// </summary>
public class F75I604 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPKCOO.
        /// </summary>
        public const string TPKCOO = "TPKCOO";

        /// <summary>
        /// TPAN8.
        /// </summary>
        public const string TPAN8 = "TPAN8";

        /// <summary>
        /// TPMCU.
        /// </summary>
        public const string TPMCU = "TPMCU";

        /// <summary>
        /// TPI75VNBR.
        /// </summary>
        public const string TPI75VNBR = "TPI75VNBR";

        /// <summary>
        /// TPI75TOT.
        /// </summary>
        public const string TPI75TOT = "TPI75TOT";

        /// <summary>
        /// TPI75SURC.
        /// </summary>
        public const string TPI75SURC = "TPI75SURC";

        /// <summary>
        /// TPI75CESS.
        /// </summary>
        public const string TPI75CESS = "TPI75CESS";

        /// <summary>
        /// TPI75TCS1.
        /// </summary>
        public const string TPI75TCS1 = "TPI75TCS1";

        /// <summary>
        /// TPI75TCS2.
        /// </summary>
        public const string TPI75TCS2 = "TPI75TCS2";

        /// <summary>
        /// TPI75CHNO.
        /// </summary>
        public const string TPI75CHNO = "TPI75CHNO";

        /// <summary>
        /// TPI75CHN.
        /// </summary>
        public const string TPI75CHN = "TPI75CHN";

        /// <summary>
        /// TPI75VAM.
        /// </summary>
        public const string TPI75VAM = "TPI75VAM";

        /// <summary>
        /// TPI75BSR.
        /// </summary>
        public const string TPI75BSR = "TPI75BSR";

        /// <summary>
        /// TPAEXP.
        /// </summary>
        public const string TPAEXP = "TPAEXP";

        /// <summary>
        /// TPIVD.
        /// </summary>
        public const string TPIVD = "TPIVD";

        /// <summary>
        /// TPI75PYD.
        /// </summary>
        public const string TPI75PYD = "TPI75PYD";

        /// <summary>
        /// TPI75ICC.
        /// </summary>
        public const string TPI75ICC = "TPI75ICC";

        /// <summary>
        /// TPUPMJ.
        /// </summary>
        public const string TPUPMJ = "TPUPMJ";

        /// <summary>
        /// TPUPMT.
        /// </summary>
        public const string TPUPMT = "TPUPMT";

        /// <summary>
        /// TPJOBN.
        /// </summary>
        public const string TPJOBN = "TPJOBN";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPYSNM.
        /// </summary>
        public const string TPYSNM = "TPYSNM";
    }

    /// <inheritdoc />
    public override string TableName => "F75I604";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPKCOO", "TPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TPAN8", "TPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TPMCU", "TPMCU", JdeDataType.String, 24, true, true),
        new JdeField("TPI75VNBR", "TPI75VNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("TPI75TOT", "TPI75TOT", JdeDataType.Numeric),
        new JdeField("TPI75SURC", "TPI75SURC", JdeDataType.Numeric),
        new JdeField("TPI75CESS", "TPI75CESS", JdeDataType.Numeric),
        new JdeField("TPI75TCS1", "TPI75TCS1", JdeDataType.Numeric),
        new JdeField("TPI75TCS2", "TPI75TCS2", JdeDataType.Numeric),
        new JdeField("TPI75CHNO", "TPI75CHNO", JdeDataType.String, 120),
        new JdeField("TPI75CHN", "TPI75CHN", JdeDataType.Numeric),
        new JdeField("TPI75VAM", "TPI75VAM", JdeDataType.Numeric),
        new JdeField("TPI75BSR", "TPI75BSR", JdeDataType.Numeric),
        new JdeField("TPAEXP", "TPAEXP", JdeDataType.Numeric),
        new JdeField("TPIVD", "TPIVD", JdeDataType.Numeric),
        new JdeField("TPI75PYD", "TPI75PYD", JdeDataType.Numeric),
        new JdeField("TPI75ICC", "TPI75ICC", JdeDataType.String, 2),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPYSNM", "TPYSNM", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I604_0", "Primary Key on TPKCOO, TPMCU, TPAN8, TPI75VNBR", new[] { "TPKCOO", "TPMCU", "TPAN8", "TPI75VNBR" }, isUnique: true, isPrimaryKey: true)
    };
}
