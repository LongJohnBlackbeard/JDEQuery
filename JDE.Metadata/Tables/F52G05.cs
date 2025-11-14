using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G05 - .
/// </summary>
public class F52G05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADDOCO.
        /// </summary>
        public const string ADDOCO = "ADDOCO";

        /// <summary>
        /// ADDCTO.
        /// </summary>
        public const string ADDCTO = "ADDCTO";

        /// <summary>
        /// ADKCOO.
        /// </summary>
        public const string ADKCOO = "ADKCOO";

        /// <summary>
        /// ADGACRN.
        /// </summary>
        public const string ADGACRN = "ADGACRN";

        /// <summary>
        /// ADDL01.
        /// </summary>
        public const string ADDL01 = "ADDL01";

        /// <summary>
        /// ADACRNG.
        /// </summary>
        public const string ADACRNG = "ADACRNG";

        /// <summary>
        /// ADSEQ.
        /// </summary>
        public const string ADSEQ = "ADSEQ";

        /// <summary>
        /// ADBAME.
        /// </summary>
        public const string ADBAME = "ADBAME";

        /// <summary>
        /// ADFNDAM.
        /// </summary>
        public const string ADFNDAM = "ADFNDAM";

        /// <summary>
        /// ADCBAM.
        /// </summary>
        public const string ADCBAM = "ADCBAM";

        /// <summary>
        /// ADCBLT.
        /// </summary>
        public const string ADCBLT = "ADCBLT";

        /// <summary>
        /// ADCRCD.
        /// </summary>
        public const string ADCRCD = "ADCRCD";

        /// <summary>
        /// ADFFND.
        /// </summary>
        public const string ADFFND = "ADFFND";

        /// <summary>
        /// ADFCBA.
        /// </summary>
        public const string ADFCBA = "ADFCBA";

        /// <summary>
        /// ADFCUA.
        /// </summary>
        public const string ADFCUA = "ADFCUA";

        /// <summary>
        /// ADCRCF.
        /// </summary>
        public const string ADCRCF = "ADCRCF";

        /// <summary>
        /// ADCRRM.
        /// </summary>
        public const string ADCRRM = "ADCRRM";

        /// <summary>
        /// ADACIA.
        /// </summary>
        public const string ADACIA = "ADACIA";

        /// <summary>
        /// ADEXDA.
        /// </summary>
        public const string ADEXDA = "ADEXDA";

        /// <summary>
        /// ADACAT1.
        /// </summary>
        public const string ADACAT1 = "ADACAT1";

        /// <summary>
        /// ADACAT2.
        /// </summary>
        public const string ADACAT2 = "ADACAT2";

        /// <summary>
        /// ADACAT3.
        /// </summary>
        public const string ADACAT3 = "ADACAT3";

        /// <summary>
        /// ADACAT4.
        /// </summary>
        public const string ADACAT4 = "ADACAT4";

        /// <summary>
        /// ADACAT5.
        /// </summary>
        public const string ADACAT5 = "ADACAT5";

        /// <summary>
        /// ADUSD1.
        /// </summary>
        public const string ADUSD1 = "ADUSD1";

        /// <summary>
        /// ADUSD2.
        /// </summary>
        public const string ADUSD2 = "ADUSD2";

        /// <summary>
        /// ADUSD3.
        /// </summary>
        public const string ADUSD3 = "ADUSD3";

        /// <summary>
        /// ADUSD4.
        /// </summary>
        public const string ADUSD4 = "ADUSD4";

        /// <summary>
        /// ADUSD5.
        /// </summary>
        public const string ADUSD5 = "ADUSD5";

        /// <summary>
        /// ADICU.
        /// </summary>
        public const string ADICU = "ADICU";

        /// <summary>
        /// ADDOCZ.
        /// </summary>
        public const string ADDOCZ = "ADDOCZ";

        /// <summary>
        /// ADDCTI.
        /// </summary>
        public const string ADDCTI = "ADDCTI";

        /// <summary>
        /// ADKCOI.
        /// </summary>
        public const string ADKCOI = "ADKCOI";

        /// <summary>
        /// ADAPPL.
        /// </summary>
        public const string ADAPPL = "ADAPPL";

        /// <summary>
        /// ADADJN.
        /// </summary>
        public const string ADADJN = "ADADJN";

        /// <summary>
        /// ADPCTN.
        /// </summary>
        public const string ADPCTN = "ADPCTN";

        /// <summary>
        /// ADPCTT.
        /// </summary>
        public const string ADPCTT = "ADPCTT";

        /// <summary>
        /// ADPCKO.
        /// </summary>
        public const string ADPCKO = "ADPCKO";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADPCTACRN.
        /// </summary>
        public const string ADPCTACRN = "ADPCTACRN";
    }

    /// <inheritdoc />
    public override string TableName => "F52G05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADDOCO", "ADDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ADDCTO", "ADDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ADKCOO", "ADKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ADGACRN", "ADGACRN", JdeDataType.String, 60, true, true),
        new JdeField("ADDL01", "ADDL01", JdeDataType.String, 60),
        new JdeField("ADACRNG", "ADACRNG", JdeDataType.String, 12),
        new JdeField("ADSEQ", "ADSEQ", JdeDataType.Numeric),
        new JdeField("ADBAME", "ADBAME", JdeDataType.String, 2),
        new JdeField("ADFNDAM", "ADFNDAM", JdeDataType.Numeric),
        new JdeField("ADCBAM", "ADCBAM", JdeDataType.Numeric),
        new JdeField("ADCBLT", "ADCBLT", JdeDataType.Numeric),
        new JdeField("ADCRCD", "ADCRCD", JdeDataType.String, 6),
        new JdeField("ADFFND", "ADFFND", JdeDataType.Numeric),
        new JdeField("ADFCBA", "ADFCBA", JdeDataType.Numeric),
        new JdeField("ADFCUA", "ADFCUA", JdeDataType.Numeric),
        new JdeField("ADCRCF", "ADCRCF", JdeDataType.String, 6),
        new JdeField("ADCRRM", "ADCRRM", JdeDataType.String, 2),
        new JdeField("ADACIA", "ADACIA", JdeDataType.String, 2),
        new JdeField("ADEXDA", "ADEXDA", JdeDataType.Numeric),
        new JdeField("ADACAT1", "ADACAT1", JdeDataType.String, 20),
        new JdeField("ADACAT2", "ADACAT2", JdeDataType.String, 20),
        new JdeField("ADACAT3", "ADACAT3", JdeDataType.String, 20),
        new JdeField("ADACAT4", "ADACAT4", JdeDataType.String, 20),
        new JdeField("ADACAT5", "ADACAT5", JdeDataType.String, 20),
        new JdeField("ADUSD1", "ADUSD1", JdeDataType.Numeric),
        new JdeField("ADUSD2", "ADUSD2", JdeDataType.Numeric),
        new JdeField("ADUSD3", "ADUSD3", JdeDataType.Numeric),
        new JdeField("ADUSD4", "ADUSD4", JdeDataType.Numeric),
        new JdeField("ADUSD5", "ADUSD5", JdeDataType.Numeric),
        new JdeField("ADICU", "ADICU", JdeDataType.Numeric),
        new JdeField("ADDOCZ", "ADDOCZ", JdeDataType.Numeric),
        new JdeField("ADDCTI", "ADDCTI", JdeDataType.String, 4),
        new JdeField("ADKCOI", "ADKCOI", JdeDataType.String, 10),
        new JdeField("ADAPPL", "ADAPPL", JdeDataType.Numeric),
        new JdeField("ADADJN", "ADADJN", JdeDataType.Numeric),
        new JdeField("ADPCTN", "ADPCTN", JdeDataType.Numeric),
        new JdeField("ADPCTT", "ADPCTT", JdeDataType.String, 4),
        new JdeField("ADPCKO", "ADPCKO", JdeDataType.String, 10),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADPCTACRN", "ADPCTACRN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G05_0", "Primary Key on ADDOCO, ADDCTO, ADKCOO, ADGACRN", new[] { "ADDOCO", "ADDCTO", "ADKCOO", "ADGACRN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G05_2", "Index on ADDOCO, ADDCTO, ADKCOO, ADACIA, ADBAME, ADSEQ", new[] { "ADDOCO", "ADDCTO", "ADKCOO", "ADACIA", "ADBAME", "ADSEQ" }),
        new JdeIndex("F52G05_3", "Index on ADDOCO, ADDCTO, ADKCOO, ADACIA, ADBAME, SYS_NC00045$", new[] { "ADDOCO", "ADDCTO", "ADKCOO", "ADACIA", "ADBAME", "SYS_NC00045$" }),
        new JdeIndex("F52G05_4", "Index on ADDOCO, ADDCTO, ADKCOO, ADACIA, ADBAME, ADPCTACRN", new[] { "ADDOCO", "ADDCTO", "ADKCOO", "ADACIA", "ADBAME", "ADPCTACRN" }),
        new JdeIndex("F52G05_5", "Index on ADICU", new[] { "ADICU" }),
        new JdeIndex("F52G05_6", "Index on ADDOCZ, ADDCTI, ADKCOI", new[] { "ADDOCZ", "ADDCTI", "ADKCOI" }),
        new JdeIndex("F52G05_7", "Index on ADDOCO, ADDCTO, ADKCOO, ADAPPL", new[] { "ADDOCO", "ADDCTO", "ADKCOO", "ADAPPL" }),
        new JdeIndex("F52G05_8", "Index on ADDOCZ, ADDOCO, ADBAME, ADSEQ", new[] { "ADDOCZ", "ADDOCO", "ADBAME", "ADSEQ" })
    };
}
