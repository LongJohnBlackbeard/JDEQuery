using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1310Z1 - .
/// </summary>
public class F1310Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBEDUS.
        /// </summary>
        public const string CBEDUS = "CBEDUS";

        /// <summary>
        /// CBEDBT.
        /// </summary>
        public const string CBEDBT = "CBEDBT";

        /// <summary>
        /// CBEDTN.
        /// </summary>
        public const string CBEDTN = "CBEDTN";

        /// <summary>
        /// CBEDLN.
        /// </summary>
        public const string CBEDLN = "CBEDLN";

        /// <summary>
        /// CBEDCT.
        /// </summary>
        public const string CBEDCT = "CBEDCT";

        /// <summary>
        /// CBTYTN.
        /// </summary>
        public const string CBTYTN = "CBTYTN";

        /// <summary>
        /// CBEDFT.
        /// </summary>
        public const string CBEDFT = "CBEDFT";

        /// <summary>
        /// CBEDDT.
        /// </summary>
        public const string CBEDDT = "CBEDDT";

        /// <summary>
        /// CBDRIN.
        /// </summary>
        public const string CBDRIN = "CBDRIN";

        /// <summary>
        /// CBEDDL.
        /// </summary>
        public const string CBEDDL = "CBEDDL";

        /// <summary>
        /// CBEDSP.
        /// </summary>
        public const string CBEDSP = "CBEDSP";

        /// <summary>
        /// CBPNID.
        /// </summary>
        public const string CBPNID = "CBPNID";

        /// <summary>
        /// CBTNAC.
        /// </summary>
        public const string CBTNAC = "CBTNAC";

        /// <summary>
        /// CBUKID.
        /// </summary>
        public const string CBUKID = "CBUKID";

        /// <summary>
        /// CBNUMB.
        /// </summary>
        public const string CBNUMB = "CBNUMB";

        /// <summary>
        /// CBAPID.
        /// </summary>
        public const string CBAPID = "CBAPID";

        /// <summary>
        /// CBASID.
        /// </summary>
        public const string CBASID = "CBASID";

        /// <summary>
        /// CBPRODM.
        /// </summary>
        public const string CBPRODM = "CBPRODM";

        /// <summary>
        /// CBMELC.
        /// </summary>
        public const string CBMELC = "CBMELC";

        /// <summary>
        /// CBAN8.
        /// </summary>
        public const string CBAN8 = "CBAN8";

        /// <summary>
        /// CBLANO.
        /// </summary>
        public const string CBLANO = "CBLANO";

        /// <summary>
        /// CBLOC.
        /// </summary>
        public const string CBLOC = "CBLOC";

        /// <summary>
        /// CBEQST.
        /// </summary>
        public const string CBEQST = "CBEQST";

        /// <summary>
        /// CBTYRP.
        /// </summary>
        public const string CBTYRP = "CBTYRP";

        /// <summary>
        /// CBSRVT.
        /// </summary>
        public const string CBSRVT = "CBSRVT";

        /// <summary>
        /// CBDOCO.
        /// </summary>
        public const string CBDOCO = "CBDOCO";

        /// <summary>
        /// CBDL01.
        /// </summary>
        public const string CBDL01 = "CBDL01";

        /// <summary>
        /// CBEVTDT.
        /// </summary>
        public const string CBEVTDT = "CBEVTDT";

        /// <summary>
        /// CBEVTTM.
        /// </summary>
        public const string CBEVTTM = "CBEVTTM";

        /// <summary>
        /// CBEVTUTC.
        /// </summary>
        public const string CBEVTUTC = "CBEVTUTC";

        /// <summary>
        /// CBTIMEZONES.
        /// </summary>
        public const string CBTIMEZONES = "CBTIMEZONES";

        /// <summary>
        /// CBDSAVNAME.
        /// </summary>
        public const string CBDSAVNAME = "CBDSAVNAME";

        /// <summary>
        /// CBQTST.
        /// </summary>
        public const string CBQTST = "CBQTST";

        /// <summary>
        /// CBQSPC.
        /// </summary>
        public const string CBQSPC = "CBQSPC";

        /// <summary>
        /// CBDSC1.
        /// </summary>
        public const string CBDSC1 = "CBDSC1";

        /// <summary>
        /// CBQVAL.
        /// </summary>
        public const string CBQVAL = "CBQVAL";

        /// <summary>
        /// CBQPF.
        /// </summary>
        public const string CBQPF = "CBQPF";

        /// <summary>
        /// CBTOVR.
        /// </summary>
        public const string CBTOVR = "CBTOVR";

        /// <summary>
        /// CBANO.
        /// </summary>
        public const string CBANO = "CBANO";

        /// <summary>
        /// CBPDFL.
        /// </summary>
        public const string CBPDFL = "CBPDFL";

        /// <summary>
        /// CBDQLT.
        /// </summary>
        public const string CBDQLT = "CBDQLT";

        /// <summary>
        /// CBPNST.
        /// </summary>
        public const string CBPNST = "CBPNST";

        /// <summary>
        /// CBPMUKID.
        /// </summary>
        public const string CBPMUKID = "CBPMUKID";

        /// <summary>
        /// CBWONA.
        /// </summary>
        public const string CBWONA = "CBWONA";

        /// <summary>
        /// CBSNDN.
        /// </summary>
        public const string CBSNDN = "CBSNDN";

        /// <summary>
        /// CBNOTR.
        /// </summary>
        public const string CBNOTR = "CBNOTR";

        /// <summary>
        /// CBNSTT.
        /// </summary>
        public const string CBNSTT = "CBNSTT";

        /// <summary>
        /// CBASTC.
        /// </summary>
        public const string CBASTC = "CBASTC";

        /// <summary>
        /// CBSNDV.
        /// </summary>
        public const string CBSNDV = "CBSNDV";

        /// <summary>
        /// CBINVR.
        /// </summary>
        public const string CBINVR = "CBINVR";

        /// <summary>
        /// CBISTT.
        /// </summary>
        public const string CBISTT = "CBISTT";

        /// <summary>
        /// CBIVCP.
        /// </summary>
        public const string CBIVCP = "CBIVCP";

        /// <summary>
        /// CBISSUE.
        /// </summary>
        public const string CBISSUE = "CBISSUE";

        /// <summary>
        /// CBSEST.
        /// </summary>
        public const string CBSEST = "CBSEST";

        /// <summary>
        /// CBSCHSTTIME.
        /// </summary>
        public const string CBSCHSTTIME = "CBSCHSTTIME";

        /// <summary>
        /// CBVR01.
        /// </summary>
        public const string CBVR01 = "CBVR01";

        /// <summary>
        /// CBVR02.
        /// </summary>
        public const string CBVR02 = "CBVR02";

        /// <summary>
        /// CBWHO2.
        /// </summary>
        public const string CBWHO2 = "CBWHO2";

        /// <summary>
        /// CBAR1.
        /// </summary>
        public const string CBAR1 = "CBAR1";

        /// <summary>
        /// CBPHN1.
        /// </summary>
        public const string CBPHN1 = "CBPHN1";

        /// <summary>
        /// CBADD1.
        /// </summary>
        public const string CBADD1 = "CBADD1";

        /// <summary>
        /// CBADD2.
        /// </summary>
        public const string CBADD2 = "CBADD2";

        /// <summary>
        /// CBADD3.
        /// </summary>
        public const string CBADD3 = "CBADD3";

        /// <summary>
        /// CBADD4.
        /// </summary>
        public const string CBADD4 = "CBADD4";

        /// <summary>
        /// CBCTY1.
        /// </summary>
        public const string CBCTY1 = "CBCTY1";

        /// <summary>
        /// CBADDS.
        /// </summary>
        public const string CBADDS = "CBADDS";

        /// <summary>
        /// CBADDZ.
        /// </summary>
        public const string CBADDZ = "CBADDZ";

        /// <summary>
        /// CBCOUN.
        /// </summary>
        public const string CBCOUN = "CBCOUN";

        /// <summary>
        /// CBCTR.
        /// </summary>
        public const string CBCTR = "CBCTR";

        /// <summary>
        /// CBURAB.
        /// </summary>
        public const string CBURAB = "CBURAB";

        /// <summary>
        /// CBURAT.
        /// </summary>
        public const string CBURAT = "CBURAT";

        /// <summary>
        /// CBURCD.
        /// </summary>
        public const string CBURCD = "CBURCD";

        /// <summary>
        /// CBURDT.
        /// </summary>
        public const string CBURDT = "CBURDT";

        /// <summary>
        /// CBURRF.
        /// </summary>
        public const string CBURRF = "CBURRF";

        /// <summary>
        /// CBCBURCH1.
        /// </summary>
        public const string CBCBURCH1 = "CBCBURCH1";

        /// <summary>
        /// CBCBURCH2.
        /// </summary>
        public const string CBCBURCH2 = "CBCBURCH2";

        /// <summary>
        /// CBCBURDT1.
        /// </summary>
        public const string CBCBURDT1 = "CBCBURDT1";

        /// <summary>
        /// CBCBURDT2.
        /// </summary>
        public const string CBCBURDT2 = "CBCBURDT2";

        /// <summary>
        /// CBCBURMN1.
        /// </summary>
        public const string CBCBURMN1 = "CBCBURMN1";

        /// <summary>
        /// CBCBURMN2.
        /// </summary>
        public const string CBCBURMN2 = "CBCBURMN2";

        /// <summary>
        /// CBCBURAB1.
        /// </summary>
        public const string CBCBURAB1 = "CBCBURAB1";

        /// <summary>
        /// CBCBURAB2.
        /// </summary>
        public const string CBCBURAB2 = "CBCBURAB2";

        /// <summary>
        /// CBCBURST1.
        /// </summary>
        public const string CBCBURST1 = "CBCBURST1";

        /// <summary>
        /// CBCBURST2.
        /// </summary>
        public const string CBCBURST2 = "CBCBURST2";

        /// <summary>
        /// CBCBURST3.
        /// </summary>
        public const string CBCBURST3 = "CBCBURST3";

        /// <summary>
        /// CBCBURST4.
        /// </summary>
        public const string CBCBURST4 = "CBCBURST4";

        /// <summary>
        /// CBCBURST5.
        /// </summary>
        public const string CBCBURST5 = "CBCBURST5";

        /// <summary>
        /// CBCBURST6.
        /// </summary>
        public const string CBCBURST6 = "CBCBURST6";

        /// <summary>
        /// CBCBURST7.
        /// </summary>
        public const string CBCBURST7 = "CBCBURST7";

        /// <summary>
        /// CBCBURST8.
        /// </summary>
        public const string CBCBURST8 = "CBCBURST8";

        /// <summary>
        /// CBCBURST9.
        /// </summary>
        public const string CBCBURST9 = "CBCBURST9";

        /// <summary>
        /// CBCBURST0.
        /// </summary>
        public const string CBCBURST0 = "CBCBURST0";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBMKEY.
        /// </summary>
        public const string CBMKEY = "CBMKEY";

        /// <summary>
        /// CBUPMJ.
        /// </summary>
        public const string CBUPMJ = "CBUPMJ";

        /// <summary>
        /// CBUPMT.
        /// </summary>
        public const string CBUPMT = "CBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1310Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBEDUS", "CBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("CBEDBT", "CBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("CBEDTN", "CBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("CBEDLN", "CBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CBEDCT", "CBEDCT", JdeDataType.String, 4),
        new JdeField("CBTYTN", "CBTYTN", JdeDataType.String, 16),
        new JdeField("CBEDFT", "CBEDFT", JdeDataType.String, 20),
        new JdeField("CBEDDT", "CBEDDT", JdeDataType.Numeric),
        new JdeField("CBDRIN", "CBDRIN", JdeDataType.String, 2),
        new JdeField("CBEDDL", "CBEDDL", JdeDataType.Numeric),
        new JdeField("CBEDSP", "CBEDSP", JdeDataType.String, 2),
        new JdeField("CBPNID", "CBPNID", JdeDataType.String, 30),
        new JdeField("CBTNAC", "CBTNAC", JdeDataType.String, 4),
        new JdeField("CBUKID", "CBUKID", JdeDataType.Numeric),
        new JdeField("CBNUMB", "CBNUMB", JdeDataType.Numeric),
        new JdeField("CBAPID", "CBAPID", JdeDataType.String, 24),
        new JdeField("CBASID", "CBASID", JdeDataType.String, 50),
        new JdeField("CBPRODM", "CBPRODM", JdeDataType.String, 16),
        new JdeField("CBMELC", "CBMELC", JdeDataType.String, 20),
        new JdeField("CBAN8", "CBAN8", JdeDataType.Numeric),
        new JdeField("CBLANO", "CBLANO", JdeDataType.Numeric),
        new JdeField("CBLOC", "CBLOC", JdeDataType.String, 24),
        new JdeField("CBEQST", "CBEQST", JdeDataType.String, 4),
        new JdeField("CBTYRP", "CBTYRP", JdeDataType.String, 2),
        new JdeField("CBSRVT", "CBSRVT", JdeDataType.String, 16),
        new JdeField("CBDOCO", "CBDOCO", JdeDataType.Numeric),
        new JdeField("CBDL01", "CBDL01", JdeDataType.String, 60),
        new JdeField("CBEVTDT", "CBEVTDT", JdeDataType.Numeric),
        new JdeField("CBEVTTM", "CBEVTTM", JdeDataType.Numeric),
        new JdeField("CBEVTUTC", "CBEVTUTC", JdeDataType.Numeric),
        new JdeField("CBTIMEZONES", "CBTIMEZONES", JdeDataType.String, 4),
        new JdeField("CBDSAVNAME", "CBDSAVNAME", JdeDataType.String, 20),
        new JdeField("CBQTST", "CBQTST", JdeDataType.String, 50),
        new JdeField("CBQSPC", "CBQSPC", JdeDataType.String, 50),
        new JdeField("CBDSC1", "CBDSC1", JdeDataType.String, 60),
        new JdeField("CBQVAL", "CBQVAL", JdeDataType.String, 30),
        new JdeField("CBQPF", "CBQPF", JdeDataType.String, 2),
        new JdeField("CBTOVR", "CBTOVR", JdeDataType.String, 2),
        new JdeField("CBANO", "CBANO", JdeDataType.Numeric),
        new JdeField("CBPDFL", "CBPDFL", JdeDataType.String, 2),
        new JdeField("CBDQLT", "CBDQLT", JdeDataType.String, 2),
        new JdeField("CBPNST", "CBPNST", JdeDataType.Numeric),
        new JdeField("CBPMUKID", "CBPMUKID", JdeDataType.Numeric),
        new JdeField("CBWONA", "CBWONA", JdeDataType.Numeric),
        new JdeField("CBSNDN", "CBSNDN", JdeDataType.String, 2),
        new JdeField("CBNOTR", "CBNOTR", JdeDataType.Numeric),
        new JdeField("CBNSTT", "CBNSTT", JdeDataType.String, 6),
        new JdeField("CBASTC", "CBASTC", JdeDataType.String, 2),
        new JdeField("CBSNDV", "CBSNDV", JdeDataType.String, 2),
        new JdeField("CBINVR", "CBINVR", JdeDataType.Numeric),
        new JdeField("CBISTT", "CBISTT", JdeDataType.String, 6),
        new JdeField("CBIVCP", "CBIVCP", JdeDataType.String, 2),
        new JdeField("CBISSUE", "CBISSUE", JdeDataType.String, 160),
        new JdeField("CBSEST", "CBSEST", JdeDataType.Numeric),
        new JdeField("CBSCHSTTIME", "CBSCHSTTIME", JdeDataType.Numeric),
        new JdeField("CBVR01", "CBVR01", JdeDataType.String, 50),
        new JdeField("CBVR02", "CBVR02", JdeDataType.String, 50),
        new JdeField("CBWHO2", "CBWHO2", JdeDataType.String, 80),
        new JdeField("CBAR1", "CBAR1", JdeDataType.String, 12),
        new JdeField("CBPHN1", "CBPHN1", JdeDataType.String, 40),
        new JdeField("CBADD1", "CBADD1", JdeDataType.String, 80),
        new JdeField("CBADD2", "CBADD2", JdeDataType.String, 80),
        new JdeField("CBADD3", "CBADD3", JdeDataType.String, 80),
        new JdeField("CBADD4", "CBADD4", JdeDataType.String, 80),
        new JdeField("CBCTY1", "CBCTY1", JdeDataType.String, 50),
        new JdeField("CBADDS", "CBADDS", JdeDataType.String, 6),
        new JdeField("CBADDZ", "CBADDZ", JdeDataType.String, 24),
        new JdeField("CBCOUN", "CBCOUN", JdeDataType.String, 50),
        new JdeField("CBCTR", "CBCTR", JdeDataType.String, 6),
        new JdeField("CBURAB", "CBURAB", JdeDataType.Numeric),
        new JdeField("CBURAT", "CBURAT", JdeDataType.Numeric),
        new JdeField("CBURCD", "CBURCD", JdeDataType.String, 4),
        new JdeField("CBURDT", "CBURDT", JdeDataType.Numeric),
        new JdeField("CBURRF", "CBURRF", JdeDataType.String, 30),
        new JdeField("CBCBURCH1", "CBCBURCH1", JdeDataType.String, 2),
        new JdeField("CBCBURCH2", "CBCBURCH2", JdeDataType.String, 2),
        new JdeField("CBCBURDT1", "CBCBURDT1", JdeDataType.Numeric),
        new JdeField("CBCBURDT2", "CBCBURDT2", JdeDataType.Numeric),
        new JdeField("CBCBURMN1", "CBCBURMN1", JdeDataType.Numeric),
        new JdeField("CBCBURMN2", "CBCBURMN2", JdeDataType.Numeric),
        new JdeField("CBCBURAB1", "CBCBURAB1", JdeDataType.Numeric),
        new JdeField("CBCBURAB2", "CBCBURAB2", JdeDataType.Numeric),
        new JdeField("CBCBURST1", "CBCBURST1", JdeDataType.String, 10),
        new JdeField("CBCBURST2", "CBCBURST2", JdeDataType.String, 10),
        new JdeField("CBCBURST3", "CBCBURST3", JdeDataType.String, 30),
        new JdeField("CBCBURST4", "CBCBURST4", JdeDataType.String, 30),
        new JdeField("CBCBURST5", "CBCBURST5", JdeDataType.String, 60),
        new JdeField("CBCBURST6", "CBCBURST6", JdeDataType.String, 60),
        new JdeField("CBCBURST7", "CBCBURST7", JdeDataType.String, 60),
        new JdeField("CBCBURST8", "CBCBURST8", JdeDataType.String, 160),
        new JdeField("CBCBURST9", "CBCBURST9", JdeDataType.String, 160),
        new JdeField("CBCBURST0", "CBCBURST0", JdeDataType.String, 160),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBMKEY", "CBMKEY", JdeDataType.String, 30),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBUPMT", "CBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1310Z1_0", "Primary Key on CBEDUS, CBEDBT, CBEDTN, CBEDLN", new[] { "CBEDUS", "CBEDBT", "CBEDTN", "CBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
