using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801TZ2 - .
/// </summary>
public class F4801TZ2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WQEDUS.
        /// </summary>
        public const string WQEDUS = "WQEDUS";

        /// <summary>
        /// WQEDBT.
        /// </summary>
        public const string WQEDBT = "WQEDBT";

        /// <summary>
        /// WQEDTN.
        /// </summary>
        public const string WQEDTN = "WQEDTN";

        /// <summary>
        /// WQEDLN.
        /// </summary>
        public const string WQEDLN = "WQEDLN";

        /// <summary>
        /// WQEDCT.
        /// </summary>
        public const string WQEDCT = "WQEDCT";

        /// <summary>
        /// WQTYTN.
        /// </summary>
        public const string WQTYTN = "WQTYTN";

        /// <summary>
        /// WQEDFT.
        /// </summary>
        public const string WQEDFT = "WQEDFT";

        /// <summary>
        /// WQEDDT.
        /// </summary>
        public const string WQEDDT = "WQEDDT";

        /// <summary>
        /// WQDRIN.
        /// </summary>
        public const string WQDRIN = "WQDRIN";

        /// <summary>
        /// WQEDDL.
        /// </summary>
        public const string WQEDDL = "WQEDDL";

        /// <summary>
        /// WQEDSP.
        /// </summary>
        public const string WQEDSP = "WQEDSP";

        /// <summary>
        /// WQPNID.
        /// </summary>
        public const string WQPNID = "WQPNID";

        /// <summary>
        /// WQTNAC.
        /// </summary>
        public const string WQTNAC = "WQTNAC";

        /// <summary>
        /// WQDOCO.
        /// </summary>
        public const string WQDOCO = "WQDOCO";

        /// <summary>
        /// WQLINE.
        /// </summary>
        public const string WQLINE = "WQLINE";

        /// <summary>
        /// WQMWDH.
        /// </summary>
        public const string WQMWDH = "WQMWDH";

        /// <summary>
        /// WQSCSP.
        /// </summary>
        public const string WQSCSP = "WQSCSP";

        /// <summary>
        /// WQSHFT.
        /// </summary>
        public const string WQSHFT = "WQSHFT";

        /// <summary>
        /// WQSRCN.
        /// </summary>
        public const string WQSRCN = "WQSRCN";

        /// <summary>
        /// WQLEDG.
        /// </summary>
        public const string WQLEDG = "WQLEDG";

        /// <summary>
        /// WQCTS4.
        /// </summary>
        public const string WQCTS4 = "WQCTS4";

        /// <summary>
        /// WQCTS7.
        /// </summary>
        public const string WQCTS7 = "WQCTS7";

        /// <summary>
        /// WQCTS8.
        /// </summary>
        public const string WQCTS8 = "WQCTS8";

        /// <summary>
        /// WQAID.
        /// </summary>
        public const string WQAID = "WQAID";

        /// <summary>
        /// WQALSE.
        /// </summary>
        public const string WQALSE = "WQALSE";

        /// <summary>
        /// WQASID.
        /// </summary>
        public const string WQASID = "WQASID";

        /// <summary>
        /// WQATST.
        /// </summary>
        public const string WQATST = "WQATST";

        /// <summary>
        /// WQBSEQ.
        /// </summary>
        public const string WQBSEQ = "WQBSEQ";

        /// <summary>
        /// WQCHPR.
        /// </summary>
        public const string WQCHPR = "WQCHPR";

        /// <summary>
        /// WQCRCD.
        /// </summary>
        public const string WQCRCD = "WQCRCD";

        /// <summary>
        /// WQCRCE.
        /// </summary>
        public const string WQCRCE = "WQCRCE";

        /// <summary>
        /// WQCRCF.
        /// </summary>
        public const string WQCRCF = "WQCRCF";

        /// <summary>
        /// WQD5J.
        /// </summary>
        public const string WQD5J = "WQD5J";

        /// <summary>
        /// WQD6J.
        /// </summary>
        public const string WQD6J = "WQD6J";

        /// <summary>
        /// WQDRAW.
        /// </summary>
        public const string WQDRAW = "WQDRAW";

        /// <summary>
        /// WQDUAL.
        /// </summary>
        public const string WQDUAL = "WQDUAL";

        /// <summary>
        /// WQMPCE.
        /// </summary>
        public const string WQMPCE = "WQMPCE";

        /// <summary>
        /// WQMPRC.
        /// </summary>
        public const string WQMPRC = "WQMPRC";

        /// <summary>
        /// WQOBJ.
        /// </summary>
        public const string WQOBJ = "WQOBJ";

        /// <summary>
        /// WQOTAM.
        /// </summary>
        public const string WQOTAM = "WQOTAM";

        /// <summary>
        /// WQPRJM.
        /// </summary>
        public const string WQPRJM = "WQPRJM";

        /// <summary>
        /// WQPRRP.
        /// </summary>
        public const string WQPRRP = "WQPRRP";

        /// <summary>
        /// WQSHPP.
        /// </summary>
        public const string WQSHPP = "WQSHPP";

        /// <summary>
        /// WQSQOR.
        /// </summary>
        public const string WQSQOR = "WQSQOR";

        /// <summary>
        /// WQSRKF.
        /// </summary>
        public const string WQSRKF = "WQSRKF";

        /// <summary>
        /// WQSRNK.
        /// </summary>
        public const string WQSRNK = "WQSRNK";

        /// <summary>
        /// WQSSOQ.
        /// </summary>
        public const string WQSSOQ = "WQSSOQ";

        /// <summary>
        /// WQTRAF.
        /// </summary>
        public const string WQTRAF = "WQTRAF";

        /// <summary>
        /// WQUOM2.
        /// </summary>
        public const string WQUOM2 = "WQUOM2";

        /// <summary>
        /// WQWR11.
        /// </summary>
        public const string WQWR11 = "WQWR11";

        /// <summary>
        /// WQWR12.
        /// </summary>
        public const string WQWR12 = "WQWR12";

        /// <summary>
        /// WQWR13.
        /// </summary>
        public const string WQWR13 = "WQWR13";

        /// <summary>
        /// WQWR14.
        /// </summary>
        public const string WQWR14 = "WQWR14";

        /// <summary>
        /// WQWR15.
        /// </summary>
        public const string WQWR15 = "WQWR15";

        /// <summary>
        /// WQWR16.
        /// </summary>
        public const string WQWR16 = "WQWR16";

        /// <summary>
        /// WQWR17.
        /// </summary>
        public const string WQWR17 = "WQWR17";

        /// <summary>
        /// WQWR18.
        /// </summary>
        public const string WQWR18 = "WQWR18";

        /// <summary>
        /// WQWR19.
        /// </summary>
        public const string WQWR19 = "WQWR19";

        /// <summary>
        /// WQWR20.
        /// </summary>
        public const string WQWR20 = "WQWR20";

        /// <summary>
        /// WQJBCD.
        /// </summary>
        public const string WQJBCD = "WQJBCD";

        /// <summary>
        /// WQVFWO.
        /// </summary>
        public const string WQVFWO = "WQVFWO";

        /// <summary>
        /// WQPMTN.
        /// </summary>
        public const string WQPMTN = "WQPMTN";

        /// <summary>
        /// WQISSUE.
        /// </summary>
        public const string WQISSUE = "WQISSUE";

        /// <summary>
        /// WQPRODM.
        /// </summary>
        public const string WQPRODM = "WQPRODM";

        /// <summary>
        /// WQWHO2.
        /// </summary>
        public const string WQWHO2 = "WQWHO2";

        /// <summary>
        /// WQAR1.
        /// </summary>
        public const string WQAR1 = "WQAR1";

        /// <summary>
        /// WQPHN1.
        /// </summary>
        public const string WQPHN1 = "WQPHN1";

        /// <summary>
        /// WQTMCO.
        /// </summary>
        public const string WQTMCO = "WQTMCO";

        /// <summary>
        /// WQMTHPR.
        /// </summary>
        public const string WQMTHPR = "WQMTHPR";

        /// <summary>
        /// WQENTCK.
        /// </summary>
        public const string WQENTCK = "WQENTCK";

        /// <summary>
        /// WQRYIN.
        /// </summary>
        public const string WQRYIN = "WQRYIN";

        /// <summary>
        /// WQRSTM.
        /// </summary>
        public const string WQRSTM = "WQRSTM";

        /// <summary>
        /// WQCTR.
        /// </summary>
        public const string WQCTR = "WQCTR";

        /// <summary>
        /// WQREGION.
        /// </summary>
        public const string WQREGION = "WQREGION";

        /// <summary>
        /// WQTXA1.
        /// </summary>
        public const string WQTXA1 = "WQTXA1";

        /// <summary>
        /// WQEXR1.
        /// </summary>
        public const string WQEXR1 = "WQEXR1";

        /// <summary>
        /// WQLNGP.
        /// </summary>
        public const string WQLNGP = "WQLNGP";

        /// <summary>
        /// WQGLCCV.
        /// </summary>
        public const string WQGLCCV = "WQGLCCV";

        /// <summary>
        /// WQGLCNC.
        /// </summary>
        public const string WQGLCNC = "WQGLCNC";

        /// <summary>
        /// WQCOVGR.
        /// </summary>
        public const string WQCOVGR = "WQCOVGR";

        /// <summary>
        /// WQASN4.
        /// </summary>
        public const string WQASN4 = "WQASN4";

        /// <summary>
        /// WQASN2.
        /// </summary>
        public const string WQASN2 = "WQASN2";

        /// <summary>
        /// WQSEST.
        /// </summary>
        public const string WQSEST = "WQSEST";

        /// <summary>
        /// WQSEET.
        /// </summary>
        public const string WQSEET = "WQSEET";

        /// <summary>
        /// WQDSAVNAME.
        /// </summary>
        public const string WQDSAVNAME = "WQDSAVNAME";

        /// <summary>
        /// WQTIMEZONES.
        /// </summary>
        public const string WQTIMEZONES = "WQTIMEZONES";

        /// <summary>
        /// WQPRODF.
        /// </summary>
        public const string WQPRODF = "WQPRODF";

        /// <summary>
        /// WQCSLPRT.
        /// </summary>
        public const string WQCSLPRT = "WQCSLPRT";

        /// <summary>
        /// WQMCUCSL.
        /// </summary>
        public const string WQMCUCSL = "WQMCUCSL";

        /// <summary>
        /// WQRLOT.
        /// </summary>
        public const string WQRLOT = "WQRLOT";

        /// <summary>
        /// WQFAILCD.
        /// </summary>
        public const string WQFAILCD = "WQFAILCD";

        /// <summary>
        /// WQFAILDT.
        /// </summary>
        public const string WQFAILDT = "WQFAILDT";

        /// <summary>
        /// WQFAILTM.
        /// </summary>
        public const string WQFAILTM = "WQFAILTM";

        /// <summary>
        /// WQREPDT.
        /// </summary>
        public const string WQREPDT = "WQREPDT";

        /// <summary>
        /// WQREPTM.
        /// </summary>
        public const string WQREPTM = "WQREPTM";

        /// <summary>
        /// WQVEND.
        /// </summary>
        public const string WQVEND = "WQVEND";

        /// <summary>
        /// WQAN8AS.
        /// </summary>
        public const string WQAN8AS = "WQAN8AS";

        /// <summary>
        /// WQAN8SRM.
        /// </summary>
        public const string WQAN8SRM = "WQAN8SRM";

        /// <summary>
        /// WQSRYN.
        /// </summary>
        public const string WQSRYN = "WQSRYN";

        /// <summary>
        /// WQENTCKS.
        /// </summary>
        public const string WQENTCKS = "WQENTCKS";

        /// <summary>
        /// WQCURBALM1.
        /// </summary>
        public const string WQCURBALM1 = "WQCURBALM1";

        /// <summary>
        /// WQCURBALM2.
        /// </summary>
        public const string WQCURBALM2 = "WQCURBALM2";

        /// <summary>
        /// WQCURBALM3.
        /// </summary>
        public const string WQCURBALM3 = "WQCURBALM3";

        /// <summary>
        /// WQCRDC.
        /// </summary>
        public const string WQCRDC = "WQCRDC";

        /// <summary>
        /// WQCRRM.
        /// </summary>
        public const string WQCRRM = "WQCRRM";

        /// <summary>
        /// WQCRR.
        /// </summary>
        public const string WQCRR = "WQCRR";

        /// <summary>
        /// WQVMRS31.
        /// </summary>
        public const string WQVMRS31 = "WQVMRS31";

        /// <summary>
        /// WQVMRS32.
        /// </summary>
        public const string WQVMRS32 = "WQVMRS32";

        /// <summary>
        /// WQVMRS33.
        /// </summary>
        public const string WQVMRS33 = "WQVMRS33";

        /// <summary>
        /// WQSEQN.
        /// </summary>
        public const string WQSEQN = "WQSEQN";

        /// <summary>
        /// WQPLMR.
        /// </summary>
        public const string WQPLMR = "WQPLMR";

        /// <summary>
        /// WQPLLB.
        /// </summary>
        public const string WQPLLB = "WQPLLB";

        /// <summary>
        /// WQPLOS.
        /// </summary>
        public const string WQPLOS = "WQPLOS";

        /// <summary>
        /// WQBGTC.
        /// </summary>
        public const string WQBGTC = "WQBGTC";

        /// <summary>
        /// WQTOEM.
        /// </summary>
        public const string WQTOEM = "WQTOEM";

        /// <summary>
        /// WQTOPL.
        /// </summary>
        public const string WQTOPL = "WQTOPL";

        /// <summary>
        /// WQPLSA.
        /// </summary>
        public const string WQPLSA = "WQPLSA";

        /// <summary>
        /// WQPLSU.
        /// </summary>
        public const string WQPLSU = "WQPLSU";

        /// <summary>
        /// WQESSA.
        /// </summary>
        public const string WQESSA = "WQESSA";

        /// <summary>
        /// WQESSU.
        /// </summary>
        public const string WQESSU = "WQESSU";

        /// <summary>
        /// WQACSA.
        /// </summary>
        public const string WQACSA = "WQACSA";

        /// <summary>
        /// WQACSU.
        /// </summary>
        public const string WQACSU = "WQACSU";

        /// <summary>
        /// WQOACM.
        /// </summary>
        public const string WQOACM = "WQOACM";

        /// <summary>
        /// WQRACM.
        /// </summary>
        public const string WQRACM = "WQRACM";

        /// <summary>
        /// WQHPLF.
        /// </summary>
        public const string WQHPLF = "WQHPLF";

        /// <summary>
        /// WQSCALL.
        /// </summary>
        public const string WQSCALL = "WQSCALL";

        /// <summary>
        /// WQISNO.
        /// </summary>
        public const string WQISNO = "WQISNO";

        /// <summary>
        /// WQRMTHD.
        /// </summary>
        public const string WQRMTHD = "WQRMTHD";

        /// <summary>
        /// WQDOC.
        /// </summary>
        public const string WQDOC = "WQDOC";

        /// <summary>
        /// WQDCT.
        /// </summary>
        public const string WQDCT = "WQDCT";

        /// <summary>
        /// WQKCO.
        /// </summary>
        public const string WQKCO = "WQKCO";

        /// <summary>
        /// WQCOCH.
        /// </summary>
        public const string WQCOCH = "WQCOCH";

        /// <summary>
        /// WQLNID.
        /// </summary>
        public const string WQLNID = "WQLNID";

        /// <summary>
        /// WQCRTU.
        /// </summary>
        public const string WQCRTU = "WQCRTU";
    }

    /// <inheritdoc />
    public override string TableName => "F4801TZ2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WQEDUS", "WQEDUS", JdeDataType.String, 20, true, true),
        new JdeField("WQEDBT", "WQEDBT", JdeDataType.String, 30, true, true),
        new JdeField("WQEDTN", "WQEDTN", JdeDataType.String, 44, true, true),
        new JdeField("WQEDLN", "WQEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WQEDCT", "WQEDCT", JdeDataType.String, 4),
        new JdeField("WQTYTN", "WQTYTN", JdeDataType.String, 16),
        new JdeField("WQEDFT", "WQEDFT", JdeDataType.String, 20),
        new JdeField("WQEDDT", "WQEDDT", JdeDataType.Numeric),
        new JdeField("WQDRIN", "WQDRIN", JdeDataType.String, 2),
        new JdeField("WQEDDL", "WQEDDL", JdeDataType.Numeric),
        new JdeField("WQEDSP", "WQEDSP", JdeDataType.String, 2),
        new JdeField("WQPNID", "WQPNID", JdeDataType.String, 30),
        new JdeField("WQTNAC", "WQTNAC", JdeDataType.String, 4),
        new JdeField("WQDOCO", "WQDOCO", JdeDataType.Numeric),
        new JdeField("WQLINE", "WQLINE", JdeDataType.String, 24),
        new JdeField("WQMWDH", "WQMWDH", JdeDataType.String, 2),
        new JdeField("WQSCSP", "WQSCSP", JdeDataType.Numeric),
        new JdeField("WQSHFT", "WQSHFT", JdeDataType.String, 2),
        new JdeField("WQSRCN", "WQSRCN", JdeDataType.String, 2),
        new JdeField("WQLEDG", "WQLEDG", JdeDataType.String, 4),
        new JdeField("WQCTS4", "WQCTS4", JdeDataType.Numeric),
        new JdeField("WQCTS7", "WQCTS7", JdeDataType.Numeric),
        new JdeField("WQCTS8", "WQCTS8", JdeDataType.Numeric),
        new JdeField("WQAID", "WQAID", JdeDataType.String, 16),
        new JdeField("WQALSE", "WQALSE", JdeDataType.String, 2),
        new JdeField("WQASID", "WQASID", JdeDataType.String, 50),
        new JdeField("WQATST", "WQATST", JdeDataType.Numeric),
        new JdeField("WQBSEQ", "WQBSEQ", JdeDataType.Numeric),
        new JdeField("WQCHPR", "WQCHPR", JdeDataType.String, 2),
        new JdeField("WQCRCD", "WQCRCD", JdeDataType.String, 6),
        new JdeField("WQCRCE", "WQCRCE", JdeDataType.String, 6),
        new JdeField("WQCRCF", "WQCRCF", JdeDataType.String, 6),
        new JdeField("WQD5J", "WQD5J", JdeDataType.Numeric),
        new JdeField("WQD6J", "WQD6J", JdeDataType.Numeric),
        new JdeField("WQDRAW", "WQDRAW", JdeDataType.String, 40),
        new JdeField("WQDUAL", "WQDUAL", JdeDataType.String, 2),
        new JdeField("WQMPCE", "WQMPCE", JdeDataType.String, 2),
        new JdeField("WQMPRC", "WQMPRC", JdeDataType.String, 2),
        new JdeField("WQOBJ", "WQOBJ", JdeDataType.String, 12),
        new JdeField("WQOTAM", "WQOTAM", JdeDataType.Numeric),
        new JdeField("WQPRJM", "WQPRJM", JdeDataType.Numeric),
        new JdeField("WQPRRP", "WQPRRP", JdeDataType.String, 2),
        new JdeField("WQSHPP", "WQSHPP", JdeDataType.String, 2),
        new JdeField("WQSQOR", "WQSQOR", JdeDataType.Numeric),
        new JdeField("WQSRKF", "WQSRKF", JdeDataType.String, 2),
        new JdeField("WQSRNK", "WQSRNK", JdeDataType.Numeric),
        new JdeField("WQSSOQ", "WQSSOQ", JdeDataType.Numeric),
        new JdeField("WQTRAF", "WQTRAF", JdeDataType.String, 2),
        new JdeField("WQUOM2", "WQUOM2", JdeDataType.String, 4),
        new JdeField("WQWR11", "WQWR11", JdeDataType.String, 6),
        new JdeField("WQWR12", "WQWR12", JdeDataType.String, 6),
        new JdeField("WQWR13", "WQWR13", JdeDataType.String, 6),
        new JdeField("WQWR14", "WQWR14", JdeDataType.String, 6),
        new JdeField("WQWR15", "WQWR15", JdeDataType.String, 6),
        new JdeField("WQWR16", "WQWR16", JdeDataType.String, 6),
        new JdeField("WQWR17", "WQWR17", JdeDataType.String, 6),
        new JdeField("WQWR18", "WQWR18", JdeDataType.String, 6),
        new JdeField("WQWR19", "WQWR19", JdeDataType.String, 6),
        new JdeField("WQWR20", "WQWR20", JdeDataType.String, 6),
        new JdeField("WQJBCD", "WQJBCD", JdeDataType.String, 12),
        new JdeField("WQVFWO", "WQVFWO", JdeDataType.String, 2),
        new JdeField("WQPMTN", "WQPMTN", JdeDataType.String, 24),
        new JdeField("WQISSUE", "WQISSUE", JdeDataType.String, 160),
        new JdeField("WQPRODM", "WQPRODM", JdeDataType.String, 16),
        new JdeField("WQWHO2", "WQWHO2", JdeDataType.String, 80),
        new JdeField("WQAR1", "WQAR1", JdeDataType.String, 12),
        new JdeField("WQPHN1", "WQPHN1", JdeDataType.String, 40),
        new JdeField("WQTMCO", "WQTMCO", JdeDataType.Numeric),
        new JdeField("WQMTHPR", "WQMTHPR", JdeDataType.String, 2),
        new JdeField("WQENTCK", "WQENTCK", JdeDataType.String, 6),
        new JdeField("WQRYIN", "WQRYIN", JdeDataType.String, 2),
        new JdeField("WQRSTM", "WQRSTM", JdeDataType.Numeric),
        new JdeField("WQCTR", "WQCTR", JdeDataType.String, 6),
        new JdeField("WQREGION", "WQREGION", JdeDataType.String, 6),
        new JdeField("WQTXA1", "WQTXA1", JdeDataType.String, 20),
        new JdeField("WQEXR1", "WQEXR1", JdeDataType.String, 4),
        new JdeField("WQLNGP", "WQLNGP", JdeDataType.String, 4),
        new JdeField("WQGLCCV", "WQGLCCV", JdeDataType.String, 8),
        new JdeField("WQGLCNC", "WQGLCNC", JdeDataType.String, 8),
        new JdeField("WQCOVGR", "WQCOVGR", JdeDataType.String, 16),
        new JdeField("WQASN4", "WQASN4", JdeDataType.String, 16),
        new JdeField("WQASN2", "WQASN2", JdeDataType.String, 16),
        new JdeField("WQSEST", "WQSEST", JdeDataType.Numeric),
        new JdeField("WQSEET", "WQSEET", JdeDataType.Numeric),
        new JdeField("WQDSAVNAME", "WQDSAVNAME", JdeDataType.String, 20),
        new JdeField("WQTIMEZONES", "WQTIMEZONES", JdeDataType.String, 4),
        new JdeField("WQPRODF", "WQPRODF", JdeDataType.String, 16),
        new JdeField("WQCSLPRT", "WQCSLPRT", JdeDataType.Numeric),
        new JdeField("WQMCUCSL", "WQMCUCSL", JdeDataType.String, 24),
        new JdeField("WQRLOT", "WQRLOT", JdeDataType.String, 60),
        new JdeField("WQFAILCD", "WQFAILCD", JdeDataType.String, 16),
        new JdeField("WQFAILDT", "WQFAILDT", JdeDataType.Numeric),
        new JdeField("WQFAILTM", "WQFAILTM", JdeDataType.Numeric),
        new JdeField("WQREPDT", "WQREPDT", JdeDataType.Numeric),
        new JdeField("WQREPTM", "WQREPTM", JdeDataType.Numeric),
        new JdeField("WQVEND", "WQVEND", JdeDataType.Numeric),
        new JdeField("WQAN8AS", "WQAN8AS", JdeDataType.Numeric),
        new JdeField("WQAN8SRM", "WQAN8SRM", JdeDataType.Numeric),
        new JdeField("WQSRYN", "WQSRYN", JdeDataType.String, 2),
        new JdeField("WQENTCKS", "WQENTCKS", JdeDataType.String, 6),
        new JdeField("WQCURBALM1", "WQCURBALM1", JdeDataType.Numeric),
        new JdeField("WQCURBALM2", "WQCURBALM2", JdeDataType.Numeric),
        new JdeField("WQCURBALM3", "WQCURBALM3", JdeDataType.Numeric),
        new JdeField("WQCRDC", "WQCRDC", JdeDataType.String, 6),
        new JdeField("WQCRRM", "WQCRRM", JdeDataType.String, 2),
        new JdeField("WQCRR", "WQCRR", JdeDataType.Numeric),
        new JdeField("WQVMRS31", "WQVMRS31", JdeDataType.String, 4),
        new JdeField("WQVMRS32", "WQVMRS32", JdeDataType.String, 16),
        new JdeField("WQVMRS33", "WQVMRS33", JdeDataType.String, 20),
        new JdeField("WQSEQN", "WQSEQN", JdeDataType.Numeric),
        new JdeField("WQPLMR", "WQPLMR", JdeDataType.Numeric),
        new JdeField("WQPLLB", "WQPLLB", JdeDataType.Numeric),
        new JdeField("WQPLOS", "WQPLOS", JdeDataType.Numeric),
        new JdeField("WQBGTC", "WQBGTC", JdeDataType.Numeric),
        new JdeField("WQTOEM", "WQTOEM", JdeDataType.Numeric),
        new JdeField("WQTOPL", "WQTOPL", JdeDataType.Numeric),
        new JdeField("WQPLSA", "WQPLSA", JdeDataType.Numeric),
        new JdeField("WQPLSU", "WQPLSU", JdeDataType.Numeric),
        new JdeField("WQESSA", "WQESSA", JdeDataType.Numeric),
        new JdeField("WQESSU", "WQESSU", JdeDataType.Numeric),
        new JdeField("WQACSA", "WQACSA", JdeDataType.Numeric),
        new JdeField("WQACSU", "WQACSU", JdeDataType.Numeric),
        new JdeField("WQOACM", "WQOACM", JdeDataType.Numeric),
        new JdeField("WQRACM", "WQRACM", JdeDataType.Numeric),
        new JdeField("WQHPLF", "WQHPLF", JdeDataType.String, 2),
        new JdeField("WQSCALL", "WQSCALL", JdeDataType.String, 2),
        new JdeField("WQISNO", "WQISNO", JdeDataType.Numeric),
        new JdeField("WQRMTHD", "WQRMTHD", JdeDataType.String, 2),
        new JdeField("WQDOC", "WQDOC", JdeDataType.Numeric),
        new JdeField("WQDCT", "WQDCT", JdeDataType.String, 4),
        new JdeField("WQKCO", "WQKCO", JdeDataType.String, 10),
        new JdeField("WQCOCH", "WQCOCH", JdeDataType.String, 6),
        new JdeField("WQLNID", "WQLNID", JdeDataType.Numeric),
        new JdeField("WQCRTU", "WQCRTU", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801TZ2_0", "Primary Key on WQEDUS, WQEDBT, WQEDTN, WQEDLN", new[] { "WQEDUS", "WQEDBT", "WQEDTN", "WQEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801TZ2_2", "Index on WQDOCO, WQLINE, WQTYTN, WQTNAC, WQDRIN, WQEDDL", new[] { "WQDOCO", "WQLINE", "WQTYTN", "WQTNAC", "WQDRIN", "WQEDDL" })
    };
}
