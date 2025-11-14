using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48164 - .
/// </summary>
public class F48164 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KBUKID.
        /// </summary>
        public const string KBUKID = "KBUKID";

        /// <summary>
        /// KBKNLT.
        /// </summary>
        public const string KBKNLT = "KBKNLT";

        /// <summary>
        /// KBSRCHF.
        /// </summary>
        public const string KBSRCHF = "KBSRCHF";

        /// <summary>
        /// KBKBAPF.
        /// </summary>
        public const string KBKBAPF = "KBKBAPF";

        /// <summary>
        /// KBDOCO.
        /// </summary>
        public const string KBDOCO = "KBDOCO";

        /// <summary>
        /// KBDCTO.
        /// </summary>
        public const string KBDCTO = "KBDCTO";

        /// <summary>
        /// KBDS01.
        /// </summary>
        public const string KBDS01 = "KBDS01";

        /// <summary>
        /// KBKBTNM.
        /// </summary>
        public const string KBKBTNM = "KBKBTNM";

        /// <summary>
        /// KBKBID1.
        /// </summary>
        public const string KBKBID1 = "KBKBID1";

        /// <summary>
        /// KBKBID2.
        /// </summary>
        public const string KBKBID2 = "KBKBID2";

        /// <summary>
        /// KBKBID3.
        /// </summary>
        public const string KBKBID3 = "KBKBID3";

        /// <summary>
        /// KBKBID4.
        /// </summary>
        public const string KBKBID4 = "KBKBID4";

        /// <summary>
        /// KBKBID5.
        /// </summary>
        public const string KBKBID5 = "KBKBID5";

        /// <summary>
        /// KBURAB.
        /// </summary>
        public const string KBURAB = "KBURAB";

        /// <summary>
        /// KBURAT.
        /// </summary>
        public const string KBURAT = "KBURAT";

        /// <summary>
        /// KBURCD.
        /// </summary>
        public const string KBURCD = "KBURCD";

        /// <summary>
        /// KBURDT.
        /// </summary>
        public const string KBURDT = "KBURDT";

        /// <summary>
        /// KBURRF.
        /// </summary>
        public const string KBURRF = "KBURRF";

        /// <summary>
        /// KBCRTU.
        /// </summary>
        public const string KBCRTU = "KBCRTU";

        /// <summary>
        /// KBCADT.
        /// </summary>
        public const string KBCADT = "KBCADT";

        /// <summary>
        /// KBUSER.
        /// </summary>
        public const string KBUSER = "KBUSER";

        /// <summary>
        /// KBUPMJ.
        /// </summary>
        public const string KBUPMJ = "KBUPMJ";

        /// <summary>
        /// KBJOBN.
        /// </summary>
        public const string KBJOBN = "KBJOBN";

        /// <summary>
        /// KBPID.
        /// </summary>
        public const string KBPID = "KBPID";

        /// <summary>
        /// KBUPMT.
        /// </summary>
        public const string KBUPMT = "KBUPMT";

        /// <summary>
        /// KBDS02.
        /// </summary>
        public const string KBDS02 = "KBDS02";

        /// <summary>
        /// KBDS03.
        /// </summary>
        public const string KBDS03 = "KBDS03";

        /// <summary>
        /// KBITM.
        /// </summary>
        public const string KBITM = "KBITM";

        /// <summary>
        /// KBPRODF.
        /// </summary>
        public const string KBPRODF = "KBPRODF";

        /// <summary>
        /// KBPRODM.
        /// </summary>
        public const string KBPRODM = "KBPRODM";

        /// <summary>
        /// KBENV.
        /// </summary>
        public const string KBENV = "KBENV";

        /// <summary>
        /// KBPRODC.
        /// </summary>
        public const string KBPRODC = "KBPRODC";

        /// <summary>
        /// KBKNLTD.
        /// </summary>
        public const string KBKNLTD = "KBKNLTD";

        /// <summary>
        /// KBFAILCD.
        /// </summary>
        public const string KBFAILCD = "KBFAILCD";

        /// <summary>
        /// KBNUMB.
        /// </summary>
        public const string KBNUMB = "KBNUMB";

        /// <summary>
        /// KBUK02.
        /// </summary>
        public const string KBUK02 = "KBUK02";

        /// <summary>
        /// KBKBID6.
        /// </summary>
        public const string KBKBID6 = "KBKBID6";

        /// <summary>
        /// KBKBID7.
        /// </summary>
        public const string KBKBID7 = "KBKBID7";

        /// <summary>
        /// KBKIT.
        /// </summary>
        public const string KBKIT = "KBKIT";

        /// <summary>
        /// KBMMCU.
        /// </summary>
        public const string KBMMCU = "KBMMCU";

        /// <summary>
        /// KBTBM.
        /// </summary>
        public const string KBTBM = "KBTBM";

        /// <summary>
        /// KBTRT.
        /// </summary>
        public const string KBTRT = "KBTRT";

        /// <summary>
        /// KBVMRS31.
        /// </summary>
        public const string KBVMRS31 = "KBVMRS31";

        /// <summary>
        /// KBVMRS32.
        /// </summary>
        public const string KBVMRS32 = "KBVMRS32";

        /// <summary>
        /// KBVMRS33.
        /// </summary>
        public const string KBVMRS33 = "KBVMRS33";
    }

    /// <inheritdoc />
    public override string TableName => "F48164";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KBUKID", "KBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("KBKNLT", "KBKNLT", JdeDataType.String, 2),
        new JdeField("KBSRCHF", "KBSRCHF", JdeDataType.String, 2),
        new JdeField("KBKBAPF", "KBKBAPF", JdeDataType.String, 2),
        new JdeField("KBDOCO", "KBDOCO", JdeDataType.Numeric),
        new JdeField("KBDCTO", "KBDCTO", JdeDataType.String, 4),
        new JdeField("KBDS01", "KBDS01", JdeDataType.String, 160),
        new JdeField("KBKBTNM", "KBKBTNM", JdeDataType.String, 30),
        new JdeField("KBKBID1", "KBKBID1", JdeDataType.Numeric),
        new JdeField("KBKBID2", "KBKBID2", JdeDataType.Numeric),
        new JdeField("KBKBID3", "KBKBID3", JdeDataType.Numeric),
        new JdeField("KBKBID4", "KBKBID4", JdeDataType.Numeric),
        new JdeField("KBKBID5", "KBKBID5", JdeDataType.Numeric),
        new JdeField("KBURAB", "KBURAB", JdeDataType.Numeric),
        new JdeField("KBURAT", "KBURAT", JdeDataType.Numeric),
        new JdeField("KBURCD", "KBURCD", JdeDataType.String, 4),
        new JdeField("KBURDT", "KBURDT", JdeDataType.Numeric),
        new JdeField("KBURRF", "KBURRF", JdeDataType.String, 30),
        new JdeField("KBCRTU", "KBCRTU", JdeDataType.String, 20),
        new JdeField("KBCADT", "KBCADT", JdeDataType.Numeric),
        new JdeField("KBUSER", "KBUSER", JdeDataType.String, 20),
        new JdeField("KBUPMJ", "KBUPMJ", JdeDataType.Numeric),
        new JdeField("KBJOBN", "KBJOBN", JdeDataType.String, 20),
        new JdeField("KBPID", "KBPID", JdeDataType.String, 20),
        new JdeField("KBUPMT", "KBUPMT", JdeDataType.Numeric),
        new JdeField("KBDS02", "KBDS02", JdeDataType.String, 160),
        new JdeField("KBDS03", "KBDS03", JdeDataType.String, 160),
        new JdeField("KBITM", "KBITM", JdeDataType.Numeric),
        new JdeField("KBPRODF", "KBPRODF", JdeDataType.String, 16),
        new JdeField("KBPRODM", "KBPRODM", JdeDataType.String, 16),
        new JdeField("KBENV", "KBENV", JdeDataType.String, 20),
        new JdeField("KBPRODC", "KBPRODC", JdeDataType.String, 20),
        new JdeField("KBKNLTD", "KBKNLTD", JdeDataType.String, 20),
        new JdeField("KBFAILCD", "KBFAILCD", JdeDataType.String, 16),
        new JdeField("KBNUMB", "KBNUMB", JdeDataType.Numeric),
        new JdeField("KBUK02", "KBUK02", JdeDataType.Numeric),
        new JdeField("KBKBID6", "KBKBID6", JdeDataType.Numeric),
        new JdeField("KBKBID7", "KBKBID7", JdeDataType.Numeric),
        new JdeField("KBKIT", "KBKIT", JdeDataType.Numeric),
        new JdeField("KBMMCU", "KBMMCU", JdeDataType.String, 24),
        new JdeField("KBTBM", "KBTBM", JdeDataType.String, 6),
        new JdeField("KBTRT", "KBTRT", JdeDataType.String, 6),
        new JdeField("KBVMRS31", "KBVMRS31", JdeDataType.String, 4),
        new JdeField("KBVMRS32", "KBVMRS32", JdeDataType.String, 16),
        new JdeField("KBVMRS33", "KBVMRS33", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48164_0", "Primary Key on KBUKID", new[] { "KBUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48164_2", "Index on KBKBTNM", new[] { "KBKBTNM" }),
        new JdeIndex("F48164_3", "Index on KBDOCO, KBSRCHF, KBKNLT", new[] { "KBDOCO", "KBSRCHF", "KBKNLT" }),
        new JdeIndex("F48164_4", "Index on KBKNLT, KBKBAPF, KBNUMB, KBITM, KBPRODF, KBPRODM, KBPRODC, KBENV", new[] { "KBKNLT", "KBKBAPF", "KBNUMB", "KBITM", "KBPRODF", "KBPRODM", "KBPRODC", "KBENV" })
    };
}
