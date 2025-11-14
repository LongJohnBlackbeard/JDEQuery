using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801T - .
/// </summary>
public class F4801T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WADOCO.
        /// </summary>
        public const string WADOCO = "WADOCO";

        /// <summary>
        /// WALINE.
        /// </summary>
        public const string WALINE = "WALINE";

        /// <summary>
        /// WAMWDH.
        /// </summary>
        public const string WAMWDH = "WAMWDH";

        /// <summary>
        /// WASCSP.
        /// </summary>
        public const string WASCSP = "WASCSP";

        /// <summary>
        /// WASHFT.
        /// </summary>
        public const string WASHFT = "WASHFT";

        /// <summary>
        /// WASRCN.
        /// </summary>
        public const string WASRCN = "WASRCN";

        /// <summary>
        /// WALEDG.
        /// </summary>
        public const string WALEDG = "WALEDG";

        /// <summary>
        /// WACTS4.
        /// </summary>
        public const string WACTS4 = "WACTS4";

        /// <summary>
        /// WACTS7.
        /// </summary>
        public const string WACTS7 = "WACTS7";

        /// <summary>
        /// WACTS8.
        /// </summary>
        public const string WACTS8 = "WACTS8";

        /// <summary>
        /// WAAID.
        /// </summary>
        public const string WAAID = "WAAID";

        /// <summary>
        /// WAALSE.
        /// </summary>
        public const string WAALSE = "WAALSE";

        /// <summary>
        /// WAASID.
        /// </summary>
        public const string WAASID = "WAASID";

        /// <summary>
        /// WAATST.
        /// </summary>
        public const string WAATST = "WAATST";

        /// <summary>
        /// WABSEQ.
        /// </summary>
        public const string WABSEQ = "WABSEQ";

        /// <summary>
        /// WACHPR.
        /// </summary>
        public const string WACHPR = "WACHPR";

        /// <summary>
        /// WACRCD.
        /// </summary>
        public const string WACRCD = "WACRCD";

        /// <summary>
        /// WACRCE.
        /// </summary>
        public const string WACRCE = "WACRCE";

        /// <summary>
        /// WACRCF.
        /// </summary>
        public const string WACRCF = "WACRCF";

        /// <summary>
        /// WAD5J.
        /// </summary>
        public const string WAD5J = "WAD5J";

        /// <summary>
        /// WAD6J.
        /// </summary>
        public const string WAD6J = "WAD6J";

        /// <summary>
        /// WADRAW.
        /// </summary>
        public const string WADRAW = "WADRAW";

        /// <summary>
        /// WADUAL.
        /// </summary>
        public const string WADUAL = "WADUAL";

        /// <summary>
        /// WAMPCE.
        /// </summary>
        public const string WAMPCE = "WAMPCE";

        /// <summary>
        /// WAMPRC.
        /// </summary>
        public const string WAMPRC = "WAMPRC";

        /// <summary>
        /// WAOBJ.
        /// </summary>
        public const string WAOBJ = "WAOBJ";

        /// <summary>
        /// WAOTAM.
        /// </summary>
        public const string WAOTAM = "WAOTAM";

        /// <summary>
        /// WAPRJM.
        /// </summary>
        public const string WAPRJM = "WAPRJM";

        /// <summary>
        /// WAPRRP.
        /// </summary>
        public const string WAPRRP = "WAPRRP";

        /// <summary>
        /// WASHPP.
        /// </summary>
        public const string WASHPP = "WASHPP";

        /// <summary>
        /// WASQOR.
        /// </summary>
        public const string WASQOR = "WASQOR";

        /// <summary>
        /// WASRKF.
        /// </summary>
        public const string WASRKF = "WASRKF";

        /// <summary>
        /// WASRNK.
        /// </summary>
        public const string WASRNK = "WASRNK";

        /// <summary>
        /// WASSOQ.
        /// </summary>
        public const string WASSOQ = "WASSOQ";

        /// <summary>
        /// WATRAF.
        /// </summary>
        public const string WATRAF = "WATRAF";

        /// <summary>
        /// WAUOM2.
        /// </summary>
        public const string WAUOM2 = "WAUOM2";

        /// <summary>
        /// WAWR11.
        /// </summary>
        public const string WAWR11 = "WAWR11";

        /// <summary>
        /// WAWR12.
        /// </summary>
        public const string WAWR12 = "WAWR12";

        /// <summary>
        /// WAWR13.
        /// </summary>
        public const string WAWR13 = "WAWR13";

        /// <summary>
        /// WAWR14.
        /// </summary>
        public const string WAWR14 = "WAWR14";

        /// <summary>
        /// WAWR15.
        /// </summary>
        public const string WAWR15 = "WAWR15";

        /// <summary>
        /// WAWR16.
        /// </summary>
        public const string WAWR16 = "WAWR16";

        /// <summary>
        /// WAWR17.
        /// </summary>
        public const string WAWR17 = "WAWR17";

        /// <summary>
        /// WAWR18.
        /// </summary>
        public const string WAWR18 = "WAWR18";

        /// <summary>
        /// WAWR19.
        /// </summary>
        public const string WAWR19 = "WAWR19";

        /// <summary>
        /// WAWR20.
        /// </summary>
        public const string WAWR20 = "WAWR20";

        /// <summary>
        /// WAJBCD.
        /// </summary>
        public const string WAJBCD = "WAJBCD";

        /// <summary>
        /// WAVFWO.
        /// </summary>
        public const string WAVFWO = "WAVFWO";

        /// <summary>
        /// WAPMTN.
        /// </summary>
        public const string WAPMTN = "WAPMTN";

        /// <summary>
        /// WAISSUE.
        /// </summary>
        public const string WAISSUE = "WAISSUE";

        /// <summary>
        /// WAPRODM.
        /// </summary>
        public const string WAPRODM = "WAPRODM";

        /// <summary>
        /// WAWHO2.
        /// </summary>
        public const string WAWHO2 = "WAWHO2";

        /// <summary>
        /// WAAR1.
        /// </summary>
        public const string WAAR1 = "WAAR1";

        /// <summary>
        /// WAPHN1.
        /// </summary>
        public const string WAPHN1 = "WAPHN1";

        /// <summary>
        /// WATMCO.
        /// </summary>
        public const string WATMCO = "WATMCO";

        /// <summary>
        /// WAMTHPR.
        /// </summary>
        public const string WAMTHPR = "WAMTHPR";

        /// <summary>
        /// WAENTCK.
        /// </summary>
        public const string WAENTCK = "WAENTCK";

        /// <summary>
        /// WARYIN.
        /// </summary>
        public const string WARYIN = "WARYIN";

        /// <summary>
        /// WARSTM.
        /// </summary>
        public const string WARSTM = "WARSTM";

        /// <summary>
        /// WACTR.
        /// </summary>
        public const string WACTR = "WACTR";

        /// <summary>
        /// WAREGION.
        /// </summary>
        public const string WAREGION = "WAREGION";

        /// <summary>
        /// WATXA1.
        /// </summary>
        public const string WATXA1 = "WATXA1";

        /// <summary>
        /// WAEXR1.
        /// </summary>
        public const string WAEXR1 = "WAEXR1";

        /// <summary>
        /// WALNGP.
        /// </summary>
        public const string WALNGP = "WALNGP";

        /// <summary>
        /// WAGLCCV.
        /// </summary>
        public const string WAGLCCV = "WAGLCCV";

        /// <summary>
        /// WAGLCNC.
        /// </summary>
        public const string WAGLCNC = "WAGLCNC";

        /// <summary>
        /// WACOVGR.
        /// </summary>
        public const string WACOVGR = "WACOVGR";

        /// <summary>
        /// WAASN4.
        /// </summary>
        public const string WAASN4 = "WAASN4";

        /// <summary>
        /// WAASN2.
        /// </summary>
        public const string WAASN2 = "WAASN2";

        /// <summary>
        /// WASEST.
        /// </summary>
        public const string WASEST = "WASEST";

        /// <summary>
        /// WASEET.
        /// </summary>
        public const string WASEET = "WASEET";

        /// <summary>
        /// WADSAVNAME.
        /// </summary>
        public const string WADSAVNAME = "WADSAVNAME";

        /// <summary>
        /// WATIMEZONES.
        /// </summary>
        public const string WATIMEZONES = "WATIMEZONES";

        /// <summary>
        /// WAPRODF.
        /// </summary>
        public const string WAPRODF = "WAPRODF";

        /// <summary>
        /// WACSLPRT.
        /// </summary>
        public const string WACSLPRT = "WACSLPRT";

        /// <summary>
        /// WAMCUCSL.
        /// </summary>
        public const string WAMCUCSL = "WAMCUCSL";

        /// <summary>
        /// WARLOT.
        /// </summary>
        public const string WARLOT = "WARLOT";

        /// <summary>
        /// WAFAILCD.
        /// </summary>
        public const string WAFAILCD = "WAFAILCD";

        /// <summary>
        /// WAFAILDT.
        /// </summary>
        public const string WAFAILDT = "WAFAILDT";

        /// <summary>
        /// WAFAILTM.
        /// </summary>
        public const string WAFAILTM = "WAFAILTM";

        /// <summary>
        /// WAREPDT.
        /// </summary>
        public const string WAREPDT = "WAREPDT";

        /// <summary>
        /// WAREPTM.
        /// </summary>
        public const string WAREPTM = "WAREPTM";

        /// <summary>
        /// WAVEND.
        /// </summary>
        public const string WAVEND = "WAVEND";

        /// <summary>
        /// WAAN8AS.
        /// </summary>
        public const string WAAN8AS = "WAAN8AS";

        /// <summary>
        /// WAAN8SRM.
        /// </summary>
        public const string WAAN8SRM = "WAAN8SRM";

        /// <summary>
        /// WASRYN.
        /// </summary>
        public const string WASRYN = "WASRYN";

        /// <summary>
        /// WAENTCKS.
        /// </summary>
        public const string WAENTCKS = "WAENTCKS";

        /// <summary>
        /// WACURBALM1.
        /// </summary>
        public const string WACURBALM1 = "WACURBALM1";

        /// <summary>
        /// WACURBALM2.
        /// </summary>
        public const string WACURBALM2 = "WACURBALM2";

        /// <summary>
        /// WACURBALM3.
        /// </summary>
        public const string WACURBALM3 = "WACURBALM3";

        /// <summary>
        /// WACRDC.
        /// </summary>
        public const string WACRDC = "WACRDC";

        /// <summary>
        /// WACRRM.
        /// </summary>
        public const string WACRRM = "WACRRM";

        /// <summary>
        /// WACRR.
        /// </summary>
        public const string WACRR = "WACRR";

        /// <summary>
        /// WAVMRS31.
        /// </summary>
        public const string WAVMRS31 = "WAVMRS31";

        /// <summary>
        /// WAVMRS32.
        /// </summary>
        public const string WAVMRS32 = "WAVMRS32";

        /// <summary>
        /// WASEQN.
        /// </summary>
        public const string WASEQN = "WASEQN";

        /// <summary>
        /// WAPLMR.
        /// </summary>
        public const string WAPLMR = "WAPLMR";

        /// <summary>
        /// WAPLLB.
        /// </summary>
        public const string WAPLLB = "WAPLLB";

        /// <summary>
        /// WAPLOS.
        /// </summary>
        public const string WAPLOS = "WAPLOS";

        /// <summary>
        /// WABGTC.
        /// </summary>
        public const string WABGTC = "WABGTC";

        /// <summary>
        /// WATOEM.
        /// </summary>
        public const string WATOEM = "WATOEM";

        /// <summary>
        /// WATOPL.
        /// </summary>
        public const string WATOPL = "WATOPL";

        /// <summary>
        /// WAPLSA.
        /// </summary>
        public const string WAPLSA = "WAPLSA";

        /// <summary>
        /// WAPLSU.
        /// </summary>
        public const string WAPLSU = "WAPLSU";

        /// <summary>
        /// WAESSA.
        /// </summary>
        public const string WAESSA = "WAESSA";

        /// <summary>
        /// WAESSU.
        /// </summary>
        public const string WAESSU = "WAESSU";

        /// <summary>
        /// WAACSA.
        /// </summary>
        public const string WAACSA = "WAACSA";

        /// <summary>
        /// WAACSU.
        /// </summary>
        public const string WAACSU = "WAACSU";

        /// <summary>
        /// WAOACM.
        /// </summary>
        public const string WAOACM = "WAOACM";

        /// <summary>
        /// WARACM.
        /// </summary>
        public const string WARACM = "WARACM";

        /// <summary>
        /// WAHPLF.
        /// </summary>
        public const string WAHPLF = "WAHPLF";

        /// <summary>
        /// WAVMRS33.
        /// </summary>
        public const string WAVMRS33 = "WAVMRS33";

        /// <summary>
        /// WASCALL.
        /// </summary>
        public const string WASCALL = "WASCALL";

        /// <summary>
        /// WAISNO.
        /// </summary>
        public const string WAISNO = "WAISNO";

        /// <summary>
        /// WARMTHD.
        /// </summary>
        public const string WARMTHD = "WARMTHD";

        /// <summary>
        /// WADOC.
        /// </summary>
        public const string WADOC = "WADOC";

        /// <summary>
        /// WADCT.
        /// </summary>
        public const string WADCT = "WADCT";

        /// <summary>
        /// WAKCO.
        /// </summary>
        public const string WAKCO = "WAKCO";

        /// <summary>
        /// WACOCH.
        /// </summary>
        public const string WACOCH = "WACOCH";

        /// <summary>
        /// WALNID.
        /// </summary>
        public const string WALNID = "WALNID";

        /// <summary>
        /// WACRTU.
        /// </summary>
        public const string WACRTU = "WACRTU";

        /// <summary>
        /// WAXEVT.
        /// </summary>
        public const string WAXEVT = "WAXEVT";

        /// <summary>
        /// WAMCULT.
        /// </summary>
        public const string WAMCULT = "WAMCULT";

        /// <summary>
        /// WAWSCHF.
        /// </summary>
        public const string WAWSCHF = "WAWSCHF";

        /// <summary>
        /// WADFMDP.
        /// </summary>
        public const string WADFMDP = "WADFMDP";

        /// <summary>
        /// WAPMPN.
        /// </summary>
        public const string WAPMPN = "WAPMPN";

        /// <summary>
        /// WAPNS.
        /// </summary>
        public const string WAPNS = "WAPNS";

        /// <summary>
        /// WAODOC.
        /// </summary>
        public const string WAODOC = "WAODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F4801T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WADOCO", "WADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WALINE", "WALINE", JdeDataType.String, 24),
        new JdeField("WAMWDH", "WAMWDH", JdeDataType.String, 2),
        new JdeField("WASCSP", "WASCSP", JdeDataType.Numeric),
        new JdeField("WASHFT", "WASHFT", JdeDataType.String, 2),
        new JdeField("WASRCN", "WASRCN", JdeDataType.String, 2),
        new JdeField("WALEDG", "WALEDG", JdeDataType.String, 4),
        new JdeField("WACTS4", "WACTS4", JdeDataType.Numeric),
        new JdeField("WACTS7", "WACTS7", JdeDataType.Numeric),
        new JdeField("WACTS8", "WACTS8", JdeDataType.Numeric),
        new JdeField("WAAID", "WAAID", JdeDataType.String, 16),
        new JdeField("WAALSE", "WAALSE", JdeDataType.String, 2),
        new JdeField("WAASID", "WAASID", JdeDataType.String, 50),
        new JdeField("WAATST", "WAATST", JdeDataType.Numeric),
        new JdeField("WABSEQ", "WABSEQ", JdeDataType.Numeric),
        new JdeField("WACHPR", "WACHPR", JdeDataType.String, 2),
        new JdeField("WACRCD", "WACRCD", JdeDataType.String, 6),
        new JdeField("WACRCE", "WACRCE", JdeDataType.String, 6),
        new JdeField("WACRCF", "WACRCF", JdeDataType.String, 6),
        new JdeField("WAD5J", "WAD5J", JdeDataType.Numeric),
        new JdeField("WAD6J", "WAD6J", JdeDataType.Numeric),
        new JdeField("WADRAW", "WADRAW", JdeDataType.String, 40),
        new JdeField("WADUAL", "WADUAL", JdeDataType.String, 2),
        new JdeField("WAMPCE", "WAMPCE", JdeDataType.String, 2),
        new JdeField("WAMPRC", "WAMPRC", JdeDataType.String, 2),
        new JdeField("WAOBJ", "WAOBJ", JdeDataType.String, 12),
        new JdeField("WAOTAM", "WAOTAM", JdeDataType.Numeric),
        new JdeField("WAPRJM", "WAPRJM", JdeDataType.Numeric),
        new JdeField("WAPRRP", "WAPRRP", JdeDataType.String, 2),
        new JdeField("WASHPP", "WASHPP", JdeDataType.String, 2),
        new JdeField("WASQOR", "WASQOR", JdeDataType.Numeric),
        new JdeField("WASRKF", "WASRKF", JdeDataType.String, 2),
        new JdeField("WASRNK", "WASRNK", JdeDataType.Numeric),
        new JdeField("WASSOQ", "WASSOQ", JdeDataType.Numeric),
        new JdeField("WATRAF", "WATRAF", JdeDataType.String, 2),
        new JdeField("WAUOM2", "WAUOM2", JdeDataType.String, 4),
        new JdeField("WAWR11", "WAWR11", JdeDataType.String, 6),
        new JdeField("WAWR12", "WAWR12", JdeDataType.String, 6),
        new JdeField("WAWR13", "WAWR13", JdeDataType.String, 6),
        new JdeField("WAWR14", "WAWR14", JdeDataType.String, 6),
        new JdeField("WAWR15", "WAWR15", JdeDataType.String, 6),
        new JdeField("WAWR16", "WAWR16", JdeDataType.String, 6),
        new JdeField("WAWR17", "WAWR17", JdeDataType.String, 6),
        new JdeField("WAWR18", "WAWR18", JdeDataType.String, 6),
        new JdeField("WAWR19", "WAWR19", JdeDataType.String, 6),
        new JdeField("WAWR20", "WAWR20", JdeDataType.String, 6),
        new JdeField("WAJBCD", "WAJBCD", JdeDataType.String, 12),
        new JdeField("WAVFWO", "WAVFWO", JdeDataType.String, 2),
        new JdeField("WAPMTN", "WAPMTN", JdeDataType.String, 24),
        new JdeField("WAISSUE", "WAISSUE", JdeDataType.String, 160),
        new JdeField("WAPRODM", "WAPRODM", JdeDataType.String, 16),
        new JdeField("WAWHO2", "WAWHO2", JdeDataType.String, 80),
        new JdeField("WAAR1", "WAAR1", JdeDataType.String, 12),
        new JdeField("WAPHN1", "WAPHN1", JdeDataType.String, 40),
        new JdeField("WATMCO", "WATMCO", JdeDataType.Numeric),
        new JdeField("WAMTHPR", "WAMTHPR", JdeDataType.String, 2),
        new JdeField("WAENTCK", "WAENTCK", JdeDataType.String, 6),
        new JdeField("WARYIN", "WARYIN", JdeDataType.String, 2),
        new JdeField("WARSTM", "WARSTM", JdeDataType.Numeric),
        new JdeField("WACTR", "WACTR", JdeDataType.String, 6),
        new JdeField("WAREGION", "WAREGION", JdeDataType.String, 6),
        new JdeField("WATXA1", "WATXA1", JdeDataType.String, 20),
        new JdeField("WAEXR1", "WAEXR1", JdeDataType.String, 4),
        new JdeField("WALNGP", "WALNGP", JdeDataType.String, 4),
        new JdeField("WAGLCCV", "WAGLCCV", JdeDataType.String, 8),
        new JdeField("WAGLCNC", "WAGLCNC", JdeDataType.String, 8),
        new JdeField("WACOVGR", "WACOVGR", JdeDataType.String, 16),
        new JdeField("WAASN4", "WAASN4", JdeDataType.String, 16),
        new JdeField("WAASN2", "WAASN2", JdeDataType.String, 16),
        new JdeField("WASEST", "WASEST", JdeDataType.Numeric),
        new JdeField("WASEET", "WASEET", JdeDataType.Numeric),
        new JdeField("WADSAVNAME", "WADSAVNAME", JdeDataType.String, 20),
        new JdeField("WATIMEZONES", "WATIMEZONES", JdeDataType.String, 4),
        new JdeField("WAPRODF", "WAPRODF", JdeDataType.String, 16),
        new JdeField("WACSLPRT", "WACSLPRT", JdeDataType.Numeric),
        new JdeField("WAMCUCSL", "WAMCUCSL", JdeDataType.String, 24),
        new JdeField("WARLOT", "WARLOT", JdeDataType.String, 60),
        new JdeField("WAFAILCD", "WAFAILCD", JdeDataType.String, 16),
        new JdeField("WAFAILDT", "WAFAILDT", JdeDataType.Numeric),
        new JdeField("WAFAILTM", "WAFAILTM", JdeDataType.Numeric),
        new JdeField("WAREPDT", "WAREPDT", JdeDataType.Numeric),
        new JdeField("WAREPTM", "WAREPTM", JdeDataType.Numeric),
        new JdeField("WAVEND", "WAVEND", JdeDataType.Numeric),
        new JdeField("WAAN8AS", "WAAN8AS", JdeDataType.Numeric),
        new JdeField("WAAN8SRM", "WAAN8SRM", JdeDataType.Numeric),
        new JdeField("WASRYN", "WASRYN", JdeDataType.String, 2),
        new JdeField("WAENTCKS", "WAENTCKS", JdeDataType.String, 6),
        new JdeField("WACURBALM1", "WACURBALM1", JdeDataType.Numeric),
        new JdeField("WACURBALM2", "WACURBALM2", JdeDataType.Numeric),
        new JdeField("WACURBALM3", "WACURBALM3", JdeDataType.Numeric),
        new JdeField("WACRDC", "WACRDC", JdeDataType.String, 6),
        new JdeField("WACRRM", "WACRRM", JdeDataType.String, 2),
        new JdeField("WACRR", "WACRR", JdeDataType.Numeric),
        new JdeField("WAVMRS31", "WAVMRS31", JdeDataType.String, 4),
        new JdeField("WAVMRS32", "WAVMRS32", JdeDataType.String, 16),
        new JdeField("WASEQN", "WASEQN", JdeDataType.Numeric),
        new JdeField("WAPLMR", "WAPLMR", JdeDataType.Numeric),
        new JdeField("WAPLLB", "WAPLLB", JdeDataType.Numeric),
        new JdeField("WAPLOS", "WAPLOS", JdeDataType.Numeric),
        new JdeField("WABGTC", "WABGTC", JdeDataType.Numeric),
        new JdeField("WATOEM", "WATOEM", JdeDataType.Numeric),
        new JdeField("WATOPL", "WATOPL", JdeDataType.Numeric),
        new JdeField("WAPLSA", "WAPLSA", JdeDataType.Numeric),
        new JdeField("WAPLSU", "WAPLSU", JdeDataType.Numeric),
        new JdeField("WAESSA", "WAESSA", JdeDataType.Numeric),
        new JdeField("WAESSU", "WAESSU", JdeDataType.Numeric),
        new JdeField("WAACSA", "WAACSA", JdeDataType.Numeric),
        new JdeField("WAACSU", "WAACSU", JdeDataType.Numeric),
        new JdeField("WAOACM", "WAOACM", JdeDataType.Numeric),
        new JdeField("WARACM", "WARACM", JdeDataType.Numeric),
        new JdeField("WAHPLF", "WAHPLF", JdeDataType.String, 2),
        new JdeField("WAVMRS33", "WAVMRS33", JdeDataType.String, 20),
        new JdeField("WASCALL", "WASCALL", JdeDataType.String, 2),
        new JdeField("WAISNO", "WAISNO", JdeDataType.Numeric),
        new JdeField("WARMTHD", "WARMTHD", JdeDataType.String, 2),
        new JdeField("WADOC", "WADOC", JdeDataType.Numeric),
        new JdeField("WADCT", "WADCT", JdeDataType.String, 4),
        new JdeField("WAKCO", "WAKCO", JdeDataType.String, 10),
        new JdeField("WACOCH", "WACOCH", JdeDataType.String, 6),
        new JdeField("WALNID", "WALNID", JdeDataType.Numeric),
        new JdeField("WACRTU", "WACRTU", JdeDataType.String, 20),
        new JdeField("WAXEVT", "WAXEVT", JdeDataType.String, 2),
        new JdeField("WAMCULT", "WAMCULT", JdeDataType.String, 24),
        new JdeField("WAWSCHF", "WAWSCHF", JdeDataType.String, 2),
        new JdeField("WADFMDP", "WADFMDP", JdeDataType.String, 2),
        new JdeField("WAPMPN", "WAPMPN", JdeDataType.String, 60),
        new JdeField("WAPNS", "WAPNS", JdeDataType.Numeric),
        new JdeField("WAODOC", "WAODOC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801T_0", "Primary Key on WADOCO", new[] { "WADOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801T_2", "Index on WADOCO, WAPRJM", new[] { "WADOCO", "WAPRJM" }),
        new JdeIndex("F4801T_4", "Index on WAPRJM, WASEQN", new[] { "WAPRJM", "WASEQN" }),
        new JdeIndex("F4801T_5", "Index on WAPRODM", new[] { "WAPRODM" }),
        new JdeIndex("F4801T_6", "Index on WAFAILCD", new[] { "WAFAILCD" }),
        new JdeIndex("F4801T_7", "Index on WAPMPN, WAPNS", new[] { "WAPMPN", "WAPNS" })
    };
}
