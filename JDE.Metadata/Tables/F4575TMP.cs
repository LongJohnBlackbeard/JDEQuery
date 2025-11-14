using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4575TMP - .
/// </summary>
public class F4575TMP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHPA04.
        /// </summary>
        public const string AHPA04 = "AHPA04";

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
        /// AHSFXO.
        /// </summary>
        public const string AHSFXO = "AHSFXO";

        /// <summary>
        /// AHLNID.
        /// </summary>
        public const string AHLNID = "AHLNID";

        /// <summary>
        /// AHOSEQ.
        /// </summary>
        public const string AHOSEQ = "AHOSEQ";

        /// <summary>
        /// AHASN.
        /// </summary>
        public const string AHASN = "AHASN";

        /// <summary>
        /// AHAST.
        /// </summary>
        public const string AHAST = "AHAST";

        /// <summary>
        /// AHAGTY.
        /// </summary>
        public const string AHAGTY = "AHAGTY";

        /// <summary>
        /// AHANS8.
        /// </summary>
        public const string AHANS8 = "AHANS8";

        /// <summary>
        /// AHMCU.
        /// </summary>
        public const string AHMCU = "AHMCU";

        /// <summary>
        /// AHAN8.
        /// </summary>
        public const string AHAN8 = "AHAN8";

        /// <summary>
        /// AHCPGP.
        /// </summary>
        public const string AHCPGP = "AHCPGP";

        /// <summary>
        /// AHITM.
        /// </summary>
        public const string AHITM = "AHITM";

        /// <summary>
        /// AHPRGR.
        /// </summary>
        public const string AHPRGR = "AHPRGR";

        /// <summary>
        /// AHIGID.
        /// </summary>
        public const string AHIGID = "AHIGID";

        /// <summary>
        /// AHCGID.
        /// </summary>
        public const string AHCGID = "AHCGID";

        /// <summary>
        /// AHCATN.
        /// </summary>
        public const string AHCATN = "AHCATN";

        /// <summary>
        /// AHOGID.
        /// </summary>
        public const string AHOGID = "AHOGID";

        /// <summary>
        /// AHUOM.
        /// </summary>
        public const string AHUOM = "AHUOM";

        /// <summary>
        /// AHMNQ.
        /// </summary>
        public const string AHMNQ = "AHMNQ";

        /// <summary>
        /// AHLEDG.
        /// </summary>
        public const string AHLEDG = "AHLEDG";

        /// <summary>
        /// AHABAS.
        /// </summary>
        public const string AHABAS = "AHABAS";

        /// <summary>
        /// AHUPRC.
        /// </summary>
        public const string AHUPRC = "AHUPRC";

        /// <summary>
        /// AHFUP.
        /// </summary>
        public const string AHFUP = "AHFUP";

        /// <summary>
        /// AHGLC.
        /// </summary>
        public const string AHGLC = "AHGLC";

        /// <summary>
        /// AHSCNT.
        /// </summary>
        public const string AHSCNT = "AHSCNT";

        /// <summary>
        /// AHCLMD.
        /// </summary>
        public const string AHCLMD = "AHCLMD";

        /// <summary>
        /// AHCCF3.
        /// </summary>
        public const string AHCCF3 = "AHCCF3";

        /// <summary>
        /// AHBDCS.
        /// </summary>
        public const string AHBDCS = "AHBDCS";

        /// <summary>
        /// AHBDCL.
        /// </summary>
        public const string AHBDCL = "AHBDCL";

        /// <summary>
        /// AHFVMD.
        /// </summary>
        public const string AHFVMD = "AHFVMD";

        /// <summary>
        /// AHFVTR.
        /// </summary>
        public const string AHFVTR = "AHFVTR";

        /// <summary>
        /// AHFRMN.
        /// </summary>
        public const string AHFRMN = "AHFRMN";

        /// <summary>
        /// AHCRCD.
        /// </summary>
        public const string AHCRCD = "AHCRCD";

        /// <summary>
        /// AHBDCF.
        /// </summary>
        public const string AHBDCF = "AHBDCF";

        /// <summary>
        /// AHQYAP.
        /// </summary>
        public const string AHQYAP = "AHQYAP";

        /// <summary>
        /// AHEFTJ.
        /// </summary>
        public const string AHEFTJ = "AHEFTJ";

        /// <summary>
        /// AHEXDJ.
        /// </summary>
        public const string AHEXDJ = "AHEXDJ";

        /// <summary>
        /// AHICU.
        /// </summary>
        public const string AHICU = "AHICU";

        /// <summary>
        /// AHSLSP.
        /// </summary>
        public const string AHSLSP = "AHSLSP";

        /// <summary>
        /// AHABR1.
        /// </summary>
        public const string AHABR1 = "AHABR1";

        /// <summary>
        /// AHABR2.
        /// </summary>
        public const string AHABR2 = "AHABR2";

        /// <summary>
        /// AHABR3.
        /// </summary>
        public const string AHABR3 = "AHABR3";

        /// <summary>
        /// AHABR4.
        /// </summary>
        public const string AHABR4 = "AHABR4";

        /// <summary>
        /// AHABT1.
        /// </summary>
        public const string AHABT1 = "AHABT1";

        /// <summary>
        /// AHABT2.
        /// </summary>
        public const string AHABT2 = "AHABT2";

        /// <summary>
        /// AHABT3.
        /// </summary>
        public const string AHABT3 = "AHABT3";

        /// <summary>
        /// AHABT4.
        /// </summary>
        public const string AHABT4 = "AHABT4";

        /// <summary>
        /// AHUM.
        /// </summary>
        public const string AHUM = "AHUM";

        /// <summary>
        /// AHSBL.
        /// </summary>
        public const string AHSBL = "AHSBL";

        /// <summary>
        /// AHSBLT.
        /// </summary>
        public const string AHSBLT = "AHSBLT";

        /// <summary>
        /// AHANI.
        /// </summary>
        public const string AHANI = "AHANI";

        /// <summary>
        /// AHDAMD.
        /// </summary>
        public const string AHDAMD = "AHDAMD";

        /// <summary>
        /// AHDAMF.
        /// </summary>
        public const string AHDAMF = "AHDAMF";

        /// <summary>
        /// AHEMCU.
        /// </summary>
        public const string AHEMCU = "AHEMCU";

        /// <summary>
        /// AHCO.
        /// </summary>
        public const string AHCO = "AHCO";

        /// <summary>
        /// AHFLIT.
        /// </summary>
        public const string AHFLIT = "AHFLIT";

        /// <summary>
        /// AHADDJ.
        /// </summary>
        public const string AHADDJ = "AHADDJ";

        /// <summary>
        /// AHLNTY.
        /// </summary>
        public const string AHLNTY = "AHLNTY";

        /// <summary>
        /// AHICUT.
        /// </summary>
        public const string AHICUT = "AHICUT";

        /// <summary>
        /// AHARSN.
        /// </summary>
        public const string AHARSN = "AHARSN";

        /// <summary>
        /// AHACNT.
        /// </summary>
        public const string AHACNT = "AHACNT";

        /// <summary>
        /// AHSBIF.
        /// </summary>
        public const string AHSBIF = "AHSBIF";

        /// <summary>
        /// AHMDED.
        /// </summary>
        public const string AHMDED = "AHMDED";

        /// <summary>
        /// AHPROV.
        /// </summary>
        public const string AHPROV = "AHPROV";

        /// <summary>
        /// AHATID.
        /// </summary>
        public const string AHATID = "AHATID";

        /// <summary>
        /// AHBC01.
        /// </summary>
        public const string AHBC01 = "AHBC01";

        /// <summary>
        /// AHBC02.
        /// </summary>
        public const string AHBC02 = "AHBC02";

        /// <summary>
        /// AHBC03.
        /// </summary>
        public const string AHBC03 = "AHBC03";

        /// <summary>
        /// AHBC04.
        /// </summary>
        public const string AHBC04 = "AHBC04";

        /// <summary>
        /// AHBC05.
        /// </summary>
        public const string AHBC05 = "AHBC05";

        /// <summary>
        /// AHURCD.
        /// </summary>
        public const string AHURCD = "AHURCD";

        /// <summary>
        /// AHURDT.
        /// </summary>
        public const string AHURDT = "AHURDT";

        /// <summary>
        /// AHURAT.
        /// </summary>
        public const string AHURAT = "AHURAT";

        /// <summary>
        /// AHURAB.
        /// </summary>
        public const string AHURAB = "AHURAB";

        /// <summary>
        /// AHURRF.
        /// </summary>
        public const string AHURRF = "AHURRF";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHTDAY.
        /// </summary>
        public const string AHTDAY = "AHTDAY";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHICID.
        /// </summary>
        public const string AHICID = "AHICID";

        /// <summary>
        /// AHEV01.
        /// </summary>
        public const string AHEV01 = "AHEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F4575TMP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHPA04", "AHPA04", JdeDataType.String, 2, true, true),
        new JdeField("AHDOCO", "AHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AHDCTO", "AHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AHKCOO", "AHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AHSFXO", "AHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("AHLNID", "AHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AHOSEQ", "AHOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("AHASN", "AHASN", JdeDataType.String, 16),
        new JdeField("AHAST", "AHAST", JdeDataType.String, 16),
        new JdeField("AHAGTY", "AHAGTY", JdeDataType.String, 4),
        new JdeField("AHANS8", "AHANS8", JdeDataType.Numeric),
        new JdeField("AHMCU", "AHMCU", JdeDataType.String, 24),
        new JdeField("AHAN8", "AHAN8", JdeDataType.Numeric),
        new JdeField("AHCPGP", "AHCPGP", JdeDataType.String, 16),
        new JdeField("AHITM", "AHITM", JdeDataType.Numeric),
        new JdeField("AHPRGR", "AHPRGR", JdeDataType.String, 16),
        new JdeField("AHIGID", "AHIGID", JdeDataType.Numeric),
        new JdeField("AHCGID", "AHCGID", JdeDataType.Numeric),
        new JdeField("AHCATN", "AHCATN", JdeDataType.String, 16),
        new JdeField("AHOGID", "AHOGID", JdeDataType.Numeric),
        new JdeField("AHUOM", "AHUOM", JdeDataType.String, 4),
        new JdeField("AHMNQ", "AHMNQ", JdeDataType.Numeric),
        new JdeField("AHLEDG", "AHLEDG", JdeDataType.String, 4),
        new JdeField("AHABAS", "AHABAS", JdeDataType.String, 2),
        new JdeField("AHUPRC", "AHUPRC", JdeDataType.Numeric),
        new JdeField("AHFUP", "AHFUP", JdeDataType.Numeric),
        new JdeField("AHGLC", "AHGLC", JdeDataType.String, 8),
        new JdeField("AHSCNT", "AHSCNT", JdeDataType.String, 4),
        new JdeField("AHCLMD", "AHCLMD", JdeDataType.String, 2),
        new JdeField("AHCCF3", "AHCCF3", JdeDataType.String, 6),
        new JdeField("AHBDCS", "AHBDCS", JdeDataType.Numeric),
        new JdeField("AHBDCL", "AHBDCL", JdeDataType.String, 2),
        new JdeField("AHFVMD", "AHFVMD", JdeDataType.String, 2),
        new JdeField("AHFVTR", "AHFVTR", JdeDataType.Numeric),
        new JdeField("AHFRMN", "AHFRMN", JdeDataType.String, 20),
        new JdeField("AHCRCD", "AHCRCD", JdeDataType.String, 6),
        new JdeField("AHBDCF", "AHBDCF", JdeDataType.Numeric),
        new JdeField("AHQYAP", "AHQYAP", JdeDataType.Numeric),
        new JdeField("AHEFTJ", "AHEFTJ", JdeDataType.Numeric),
        new JdeField("AHEXDJ", "AHEXDJ", JdeDataType.Numeric),
        new JdeField("AHICU", "AHICU", JdeDataType.Numeric),
        new JdeField("AHSLSP", "AHSLSP", JdeDataType.Numeric),
        new JdeField("AHABR1", "AHABR1", JdeDataType.String, 24),
        new JdeField("AHABR2", "AHABR2", JdeDataType.String, 24),
        new JdeField("AHABR3", "AHABR3", JdeDataType.String, 24),
        new JdeField("AHABR4", "AHABR4", JdeDataType.String, 24),
        new JdeField("AHABT1", "AHABT1", JdeDataType.String, 2),
        new JdeField("AHABT2", "AHABT2", JdeDataType.String, 2),
        new JdeField("AHABT3", "AHABT3", JdeDataType.String, 2),
        new JdeField("AHABT4", "AHABT4", JdeDataType.String, 2),
        new JdeField("AHUM", "AHUM", JdeDataType.String, 4),
        new JdeField("AHSBL", "AHSBL", JdeDataType.String, 16),
        new JdeField("AHSBLT", "AHSBLT", JdeDataType.String, 2),
        new JdeField("AHANI", "AHANI", JdeDataType.String, 58),
        new JdeField("AHDAMD", "AHDAMD", JdeDataType.Numeric),
        new JdeField("AHDAMF", "AHDAMF", JdeDataType.Numeric),
        new JdeField("AHEMCU", "AHEMCU", JdeDataType.String, 24),
        new JdeField("AHCO", "AHCO", JdeDataType.String, 10),
        new JdeField("AHFLIT", "AHFLIT", JdeDataType.Numeric),
        new JdeField("AHADDJ", "AHADDJ", JdeDataType.Numeric),
        new JdeField("AHLNTY", "AHLNTY", JdeDataType.String, 4),
        new JdeField("AHICUT", "AHICUT", JdeDataType.String, 4),
        new JdeField("AHARSN", "AHARSN", JdeDataType.String, 6),
        new JdeField("AHACNT", "AHACNT", JdeDataType.String, 2),
        new JdeField("AHSBIF", "AHSBIF", JdeDataType.String, 2),
        new JdeField("AHMDED", "AHMDED", JdeDataType.String, 2),
        new JdeField("AHPROV", "AHPROV", JdeDataType.String, 2),
        new JdeField("AHATID", "AHATID", JdeDataType.Numeric),
        new JdeField("AHBC01", "AHBC01", JdeDataType.String, 6),
        new JdeField("AHBC02", "AHBC02", JdeDataType.String, 6),
        new JdeField("AHBC03", "AHBC03", JdeDataType.String, 6),
        new JdeField("AHBC04", "AHBC04", JdeDataType.String, 6),
        new JdeField("AHBC05", "AHBC05", JdeDataType.String, 6),
        new JdeField("AHURCD", "AHURCD", JdeDataType.String, 4),
        new JdeField("AHURDT", "AHURDT", JdeDataType.Numeric),
        new JdeField("AHURAT", "AHURAT", JdeDataType.Numeric),
        new JdeField("AHURAB", "AHURAB", JdeDataType.Numeric),
        new JdeField("AHURRF", "AHURRF", JdeDataType.String, 30),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHTDAY", "AHTDAY", JdeDataType.Numeric),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHICID", "AHICID", JdeDataType.Numeric),
        new JdeField("AHEV01", "AHEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4575TMP_0", "Primary Key on AHPA04, AHDOCO, AHDCTO, AHKCOO, AHSFXO, AHLNID, AHOSEQ", new[] { "AHPA04", "AHDOCO", "AHDCTO", "AHKCOO", "AHSFXO", "AHLNID", "AHOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
