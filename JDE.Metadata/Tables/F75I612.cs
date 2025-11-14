using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I612 - .
/// </summary>
public class F75I612 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPUKID.
        /// </summary>
        public const string TPUKID = "TPUKID";

        /// <summary>
        /// TPAN8.
        /// </summary>
        public const string TPAN8 = "TPAN8";

        /// <summary>
        /// TPCO.
        /// </summary>
        public const string TPCO = "TPCO";

        /// <summary>
        /// TPMCU.
        /// </summary>
        public const string TPMCU = "TPMCU";

        /// <summary>
        /// TPAREC.
        /// </summary>
        public const string TPAREC = "TPAREC";

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
        /// TPI75APD.
        /// </summary>
        public const string TPI75APD = "TPI75APD";

        /// <summary>
        /// TPI75PYD.
        /// </summary>
        public const string TPI75PYD = "TPI75PYD";

        /// <summary>
        /// TPI75CHQN.
        /// </summary>
        public const string TPI75CHQN = "TPI75CHQN";

        /// <summary>
        /// TPI75BSR.
        /// </summary>
        public const string TPI75BSR = "TPI75BSR";

        /// <summary>
        /// TPI75CHNO.
        /// </summary>
        public const string TPI75CHNO = "TPI75CHNO";

        /// <summary>
        /// TPAID.
        /// </summary>
        public const string TPAID = "TPAID";

        /// <summary>
        /// TPI75VNBR.
        /// </summary>
        public const string TPI75VNBR = "TPI75VNBR";

        /// <summary>
        /// TPI75TAUT.
        /// </summary>
        public const string TPI75TAUT = "TPI75TAUT";

        /// <summary>
        /// TPI75ICC.
        /// </summary>
        public const string TPI75ICC = "TPI75ICC";

        /// <summary>
        /// TPUSER.
        /// </summary>
        public const string TPUSER = "TPUSER";

        /// <summary>
        /// TPPID.
        /// </summary>
        public const string TPPID = "TPPID";

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
        /// TPYSNM.
        /// </summary>
        public const string TPYSNM = "TPYSNM";
    }

    /// <inheritdoc />
    public override string TableName => "F75I612";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPUKID", "TPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPAN8", "TPAN8", JdeDataType.Numeric),
        new JdeField("TPCO", "TPCO", JdeDataType.String, 10),
        new JdeField("TPMCU", "TPMCU", JdeDataType.String, 24),
        new JdeField("TPAREC", "TPAREC", JdeDataType.Numeric),
        new JdeField("TPI75TOT", "TPI75TOT", JdeDataType.Numeric),
        new JdeField("TPI75SURC", "TPI75SURC", JdeDataType.Numeric),
        new JdeField("TPI75CESS", "TPI75CESS", JdeDataType.Numeric),
        new JdeField("TPI75APD", "TPI75APD", JdeDataType.Numeric),
        new JdeField("TPI75PYD", "TPI75PYD", JdeDataType.Numeric),
        new JdeField("TPI75CHQN", "TPI75CHQN", JdeDataType.Numeric),
        new JdeField("TPI75BSR", "TPI75BSR", JdeDataType.Numeric),
        new JdeField("TPI75CHNO", "TPI75CHNO", JdeDataType.String, 120),
        new JdeField("TPAID", "TPAID", JdeDataType.String, 16),
        new JdeField("TPI75VNBR", "TPI75VNBR", JdeDataType.Numeric),
        new JdeField("TPI75TAUT", "TPI75TAUT", JdeDataType.Numeric),
        new JdeField("TPI75ICC", "TPI75ICC", JdeDataType.String, 2),
        new JdeField("TPUSER", "TPUSER", JdeDataType.String, 20),
        new JdeField("TPPID", "TPPID", JdeDataType.String, 20),
        new JdeField("TPUPMJ", "TPUPMJ", JdeDataType.Numeric),
        new JdeField("TPUPMT", "TPUPMT", JdeDataType.Numeric),
        new JdeField("TPJOBN", "TPJOBN", JdeDataType.String, 20),
        new JdeField("TPYSNM", "TPYSNM", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I612_0", "Primary Key on TPUKID", new[] { "TPUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I612_2", "Index on TPAN8, TPCO, TPMCU", new[] { "TPAN8", "TPCO", "TPMCU" })
    };
}
