using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G05H - .
/// </summary>
public class F52G05H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHDOCO.
        /// </summary>
        public const string AHDOCO = "AHDOCO";

        /// <summary>
        /// AHDCTO.
        /// </summary>
        public const string AHDCTO = "AHDCTO";

        /// <summary>
        /// AHKCOO.
        /// </summary>
        public const string AHKCOO = "AHKCOO";

        /// <summary>
        /// AHDOCZ.
        /// </summary>
        public const string AHDOCZ = "AHDOCZ";

        /// <summary>
        /// AHDCTI.
        /// </summary>
        public const string AHDCTI = "AHDCTI";

        /// <summary>
        /// AHKCOI.
        /// </summary>
        public const string AHKCOI = "AHKCOI";

        /// <summary>
        /// AHGACRN.
        /// </summary>
        public const string AHGACRN = "AHGACRN";

        /// <summary>
        /// AHAPPL.
        /// </summary>
        public const string AHAPPL = "AHAPPL";

        /// <summary>
        /// AHADJN.
        /// </summary>
        public const string AHADJN = "AHADJN";

        /// <summary>
        /// AHDI.
        /// </summary>
        public const string AHDI = "AHDI";

        /// <summary>
        /// AHDGL.
        /// </summary>
        public const string AHDGL = "AHDGL";

        /// <summary>
        /// AHDL01.
        /// </summary>
        public const string AHDL01 = "AHDL01";

        /// <summary>
        /// AHACRNG.
        /// </summary>
        public const string AHACRNG = "AHACRNG";

        /// <summary>
        /// AHSEQ.
        /// </summary>
        public const string AHSEQ = "AHSEQ";

        /// <summary>
        /// AHBAME.
        /// </summary>
        public const string AHBAME = "AHBAME";

        /// <summary>
        /// AHPCTACRN.
        /// </summary>
        public const string AHPCTACRN = "AHPCTACRN";

        /// <summary>
        /// AHFNDAM.
        /// </summary>
        public const string AHFNDAM = "AHFNDAM";

        /// <summary>
        /// AHCBAM.
        /// </summary>
        public const string AHCBAM = "AHCBAM";

        /// <summary>
        /// AHCBLT.
        /// </summary>
        public const string AHCBLT = "AHCBLT";

        /// <summary>
        /// AHCRCD.
        /// </summary>
        public const string AHCRCD = "AHCRCD";

        /// <summary>
        /// AHFFND.
        /// </summary>
        public const string AHFFND = "AHFFND";

        /// <summary>
        /// AHFCBA.
        /// </summary>
        public const string AHFCBA = "AHFCBA";

        /// <summary>
        /// AHFCUA.
        /// </summary>
        public const string AHFCUA = "AHFCUA";

        /// <summary>
        /// AHCRCF.
        /// </summary>
        public const string AHCRCF = "AHCRCF";

        /// <summary>
        /// AHCRRM.
        /// </summary>
        public const string AHCRRM = "AHCRRM";

        /// <summary>
        /// AHEXDA.
        /// </summary>
        public const string AHEXDA = "AHEXDA";

        /// <summary>
        /// AHACAT1.
        /// </summary>
        public const string AHACAT1 = "AHACAT1";

        /// <summary>
        /// AHACAT2.
        /// </summary>
        public const string AHACAT2 = "AHACAT2";

        /// <summary>
        /// AHACAT3.
        /// </summary>
        public const string AHACAT3 = "AHACAT3";

        /// <summary>
        /// AHACAT4.
        /// </summary>
        public const string AHACAT4 = "AHACAT4";

        /// <summary>
        /// AHACAT5.
        /// </summary>
        public const string AHACAT5 = "AHACAT5";

        /// <summary>
        /// AHUSD1.
        /// </summary>
        public const string AHUSD1 = "AHUSD1";

        /// <summary>
        /// AHUSD2.
        /// </summary>
        public const string AHUSD2 = "AHUSD2";

        /// <summary>
        /// AHUSD3.
        /// </summary>
        public const string AHUSD3 = "AHUSD3";

        /// <summary>
        /// AHUSD4.
        /// </summary>
        public const string AHUSD4 = "AHUSD4";

        /// <summary>
        /// AHUSD5.
        /// </summary>
        public const string AHUSD5 = "AHUSD5";

        /// <summary>
        /// AHPCTN.
        /// </summary>
        public const string AHPCTN = "AHPCTN";

        /// <summary>
        /// AHPCTT.
        /// </summary>
        public const string AHPCTT = "AHPCTT";

        /// <summary>
        /// AHPCKO.
        /// </summary>
        public const string AHPCKO = "AHPCKO";

        /// <summary>
        /// AHVOID.
        /// </summary>
        public const string AHVOID = "AHVOID";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G05H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHDOCO", "AHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AHDCTO", "AHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AHKCOO", "AHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AHDOCZ", "AHDOCZ", JdeDataType.Numeric, null, true, true),
        new JdeField("AHDCTI", "AHDCTI", JdeDataType.String, 4, true, true),
        new JdeField("AHKCOI", "AHKCOI", JdeDataType.String, 10, true, true),
        new JdeField("AHGACRN", "AHGACRN", JdeDataType.String, 60, true, true),
        new JdeField("AHAPPL", "AHAPPL", JdeDataType.Numeric),
        new JdeField("AHADJN", "AHADJN", JdeDataType.Numeric),
        new JdeField("AHDI", "AHDI", JdeDataType.Numeric),
        new JdeField("AHDGL", "AHDGL", JdeDataType.Numeric),
        new JdeField("AHDL01", "AHDL01", JdeDataType.String, 60),
        new JdeField("AHACRNG", "AHACRNG", JdeDataType.String, 12),
        new JdeField("AHSEQ", "AHSEQ", JdeDataType.Numeric),
        new JdeField("AHBAME", "AHBAME", JdeDataType.String, 2),
        new JdeField("AHPCTACRN", "AHPCTACRN", JdeDataType.Numeric),
        new JdeField("AHFNDAM", "AHFNDAM", JdeDataType.Numeric),
        new JdeField("AHCBAM", "AHCBAM", JdeDataType.Numeric),
        new JdeField("AHCBLT", "AHCBLT", JdeDataType.Numeric),
        new JdeField("AHCRCD", "AHCRCD", JdeDataType.String, 6),
        new JdeField("AHFFND", "AHFFND", JdeDataType.Numeric),
        new JdeField("AHFCBA", "AHFCBA", JdeDataType.Numeric),
        new JdeField("AHFCUA", "AHFCUA", JdeDataType.Numeric),
        new JdeField("AHCRCF", "AHCRCF", JdeDataType.String, 6),
        new JdeField("AHCRRM", "AHCRRM", JdeDataType.String, 2),
        new JdeField("AHEXDA", "AHEXDA", JdeDataType.Numeric),
        new JdeField("AHACAT1", "AHACAT1", JdeDataType.String, 20),
        new JdeField("AHACAT2", "AHACAT2", JdeDataType.String, 20),
        new JdeField("AHACAT3", "AHACAT3", JdeDataType.String, 20),
        new JdeField("AHACAT4", "AHACAT4", JdeDataType.String, 20),
        new JdeField("AHACAT5", "AHACAT5", JdeDataType.String, 20),
        new JdeField("AHUSD1", "AHUSD1", JdeDataType.Numeric),
        new JdeField("AHUSD2", "AHUSD2", JdeDataType.Numeric),
        new JdeField("AHUSD3", "AHUSD3", JdeDataType.Numeric),
        new JdeField("AHUSD4", "AHUSD4", JdeDataType.Numeric),
        new JdeField("AHUSD5", "AHUSD5", JdeDataType.Numeric),
        new JdeField("AHPCTN", "AHPCTN", JdeDataType.Numeric),
        new JdeField("AHPCTT", "AHPCTT", JdeDataType.String, 4),
        new JdeField("AHPCKO", "AHPCKO", JdeDataType.String, 10),
        new JdeField("AHVOID", "AHVOID", JdeDataType.String, 2),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G05H_0", "Primary Key on AHDOCO, AHDCTO, AHKCOO, AHDOCZ, AHDCTI, AHKCOI, AHGACRN", new[] { "AHDOCO", "AHDCTO", "AHKCOO", "AHDOCZ", "AHDCTI", "AHKCOI", "AHGACRN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G05H_2", "Index on AHDOCO, AHDOCZ", new[] { "AHDOCO", "AHDOCZ" }),
        new JdeIndex("F52G05H_3", "Index on AHDOCZ, AHBAME, AHDOCO, AHSEQ", new[] { "AHDOCZ", "AHBAME", "AHDOCO", "AHSEQ" })
    };
}
