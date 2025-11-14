using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B110 - .
/// </summary>
public class F31B110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MBWUMBID.
        /// </summary>
        public const string MBWUMBID = "MBWUMBID";

        /// <summary>
        /// MBWUMBDES.
        /// </summary>
        public const string MBWUMBDES = "MBWUMBDES";

        /// <summary>
        /// MBWUMBBATP.
        /// </summary>
        public const string MBWUMBBATP = "MBWUMBBATP";

        /// <summary>
        /// MBBATP.
        /// </summary>
        public const string MBBATP = "MBBATP";

        /// <summary>
        /// MBWUMBBATV.
        /// </summary>
        public const string MBWUMBBATV = "MBWUMBBATV";

        /// <summary>
        /// MBBATV.
        /// </summary>
        public const string MBBATV = "MBBATV";

        /// <summary>
        /// MBWUMBMCU.
        /// </summary>
        public const string MBWUMBMCU = "MBWUMBMCU";

        /// <summary>
        /// MBMCU.
        /// </summary>
        public const string MBMCU = "MBMCU";

        /// <summary>
        /// MBWUMBBID.
        /// </summary>
        public const string MBWUMBBID = "MBWUMBBID";

        /// <summary>
        /// MBBARID.
        /// </summary>
        public const string MBBARID = "MBBARID";

        /// <summary>
        /// MBWUMBCONO.
        /// </summary>
        public const string MBWUMBCONO = "MBWUMBCONO";

        /// <summary>
        /// MBBARCN.
        /// </summary>
        public const string MBBARCN = "MBBARCN";

        /// <summary>
        /// MBWUMBAGE.
        /// </summary>
        public const string MBWUMBAGE = "MBWUMBAGE";

        /// <summary>
        /// MBRKNUM.
        /// </summary>
        public const string MBRKNUM = "MBRKNUM";

        /// <summary>
        /// MBWUMBLOCN.
        /// </summary>
        public const string MBWUMBLOCN = "MBWUMBLOCN";

        /// <summary>
        /// MBLOCN.
        /// </summary>
        public const string MBLOCN = "MBLOCN";

        /// <summary>
        /// MBWUMBOC.
        /// </summary>
        public const string MBWUMBOC = "MBWUMBOC";

        /// <summary>
        /// MBCTRO.
        /// </summary>
        public const string MBCTRO = "MBCTRO";

        /// <summary>
        /// MBWUMBCS.
        /// </summary>
        public const string MBWUMBCS = "MBWUMBCS";

        /// <summary>
        /// MBBCST.
        /// </summary>
        public const string MBBCST = "MBBCST";

        /// <summary>
        /// MBWUMBOYR.
        /// </summary>
        public const string MBWUMBOYR = "MBWUMBOYR";

        /// <summary>
        /// MBOYRC.
        /// </summary>
        public const string MBOYRC = "MBOYRC";

        /// <summary>
        /// MBWUMBCON.
        /// </summary>
        public const string MBWUMBCON = "MBWUMBCON";

        /// <summary>
        /// MBBARCO.
        /// </summary>
        public const string MBBARCO = "MBBARCO";

        /// <summary>
        /// MBWUMBPOWN.
        /// </summary>
        public const string MBWUMBPOWN = "MBWUMBPOWN";

        /// <summary>
        /// MBPOWN.
        /// </summary>
        public const string MBPOWN = "MBPOWN";

        /// <summary>
        /// MBWUMBPFOR.
        /// </summary>
        public const string MBWUMBPFOR = "MBWUMBPFOR";

        /// <summary>
        /// MBFORES.
        /// </summary>
        public const string MBFORES = "MBFORES";

        /// <summary>
        /// MBWUMBTSLV.
        /// </summary>
        public const string MBWUMBTSLV = "MBWUMBTSLV";

        /// <summary>
        /// MBTLEV.
        /// </summary>
        public const string MBTLEV = "MBTLEV";

        /// <summary>
        /// MBWUMBCC1.
        /// </summary>
        public const string MBWUMBCC1 = "MBWUMBCC1";

        /// <summary>
        /// MBSCTM.
        /// </summary>
        public const string MBSCTM = "MBSCTM";

        /// <summary>
        /// MBWUMBCC2.
        /// </summary>
        public const string MBWUMBCC2 = "MBWUMBCC2";

        /// <summary>
        /// MBSDRM.
        /// </summary>
        public const string MBSDRM = "MBSDRM";

        /// <summary>
        /// MBWUMBCC3.
        /// </summary>
        public const string MBWUMBCC3 = "MBWUMBCC3";

        /// <summary>
        /// MBSBDM.
        /// </summary>
        public const string MBSBDM = "MBSBDM";

        /// <summary>
        /// MBWUMBCC4.
        /// </summary>
        public const string MBWUMBCC4 = "MBWUMBCC4";

        /// <summary>
        /// MBSDRL.
        /// </summary>
        public const string MBSDRL = "MBSDRL";

        /// <summary>
        /// MBWUMBCC5.
        /// </summary>
        public const string MBWUMBCC5 = "MBWUMBCC5";

        /// <summary>
        /// MBINFO.
        /// </summary>
        public const string MBINFO = "MBINFO";

        /// <summary>
        /// MBWUMBAVL.
        /// </summary>
        public const string MBWUMBAVL = "MBWUMBAVL";

        /// <summary>
        /// MBBAVC.
        /// </summary>
        public const string MBBAVC = "MBBAVC";

        /// <summary>
        /// MBWUMBADR.
        /// </summary>
        public const string MBWUMBADR = "MBWUMBADR";

        /// <summary>
        /// MBAJRS.
        /// </summary>
        public const string MBAJRS = "MBAJRS";

        /// <summary>
        /// MBWUMBOOS.
        /// </summary>
        public const string MBWUMBOOS = "MBWUMBOOS";

        /// <summary>
        /// MBDAOS.
        /// </summary>
        public const string MBDAOS = "MBDAOS";

        /// <summary>
        /// MBWUMBVS.
        /// </summary>
        public const string MBWUMBVS = "MBWUMBVS";

        /// <summary>
        /// MBBVST.
        /// </summary>
        public const string MBBVST = "MBBVST";

        /// <summary>
        /// MBWUMBRN.
        /// </summary>
        public const string MBWUMBRN = "MBWUMBRN";

        /// <summary>
        /// MBRKNMR.
        /// </summary>
        public const string MBRKNMR = "MBRKNMR";

        /// <summary>
        /// MBWUMBSHV.
        /// </summary>
        public const string MBWUMBSHV = "MBWUMBSHV";

        /// <summary>
        /// MBSHAV.
        /// </summary>
        public const string MBSHAV = "MBSHAV";

        /// <summary>
        /// MBWUMBDSHV.
        /// </summary>
        public const string MBWUMBDSHV = "MBWUMBDSHV";

        /// <summary>
        /// MBSHAVD.
        /// </summary>
        public const string MBSHAVD = "MBSHAVD";

        /// <summary>
        /// MBWUMBTRWK.
        /// </summary>
        public const string MBWUMBTRWK = "MBWUMBTRWK";

        /// <summary>
        /// MBTSTR.
        /// </summary>
        public const string MBTSTR = "MBTSTR";

        /// <summary>
        /// MBWUMBDFU.
        /// </summary>
        public const string MBWUMBDFU = "MBWUMBDFU";

        /// <summary>
        /// MBDAFU.
        /// </summary>
        public const string MBDAFU = "MBDAFU";

        /// <summary>
        /// MBWUMBNU.
        /// </summary>
        public const string MBWUMBNU = "MBWUMBNU";

        /// <summary>
        /// MBNXUSE.
        /// </summary>
        public const string MBNXUSE = "MBNXUSE";

        /// <summary>
        /// MBWUMBNFLL.
        /// </summary>
        public const string MBWUMBNFLL = "MBWUMBNFLL";

        /// <summary>
        /// MBNUMFL.
        /// </summary>
        public const string MBNUMFL = "MBNUMFL";

        /// <summary>
        /// MBWUMBTMET.
        /// </summary>
        public const string MBWUMBTMET = "MBWUMBTMET";

        /// <summary>
        /// MBMTDLT.
        /// </summary>
        public const string MBMTDLT = "MBMTDLT";

        /// <summary>
        /// MBWUMBDT.
        /// </summary>
        public const string MBWUMBDT = "MBWUMBDT";

        /// <summary>
        /// MBDALT.
        /// </summary>
        public const string MBDALT = "MBDALT";

        /// <summary>
        /// MBWUMBDS.
        /// </summary>
        public const string MBWUMBDS = "MBWUMBDS";

        /// <summary>
        /// MBDALS.
        /// </summary>
        public const string MBDALS = "MBDALS";

        /// <summary>
        /// MBWUMBCOM.
        /// </summary>
        public const string MBWUMBCOM = "MBWUMBCOM";

        /// <summary>
        /// MBGECM.
        /// </summary>
        public const string MBGECM = "MBGECM";

        /// <summary>
        /// MBWUMBCSTG.
        /// </summary>
        public const string MBWUMBCSTG = "MBWUMBCSTG";

        /// <summary>
        /// MBWCG.
        /// </summary>
        public const string MBWCG = "MBWCG";

        /// <summary>
        /// MBWUMBOWN.
        /// </summary>
        public const string MBWUMBOWN = "MBWUMBOWN";

        /// <summary>
        /// MBBOWN.
        /// </summary>
        public const string MBBOWN = "MBBOWN";

        /// <summary>
        /// MBWUMBLF.
        /// </summary>
        public const string MBWUMBLF = "MBWUMBLF";

        /// <summary>
        /// MBLEAS.
        /// </summary>
        public const string MBLEAS = "MBLEAS";

        /// <summary>
        /// MBWUMBLT.
        /// </summary>
        public const string MBWUMBLT = "MBWUMBLT";

        /// <summary>
        /// MBLESTM.
        /// </summary>
        public const string MBLESTM = "MBLESTM";

        /// <summary>
        /// MBWUMBLD.
        /// </summary>
        public const string MBWUMBLD = "MBWUMBLD";

        /// <summary>
        /// MBLESDT.
        /// </summary>
        public const string MBLESDT = "MBLESDT";

        /// <summary>
        /// MBWUMBLDOC.
        /// </summary>
        public const string MBWUMBLDOC = "MBWUMBLDOC";

        /// <summary>
        /// MBLESDN.
        /// </summary>
        public const string MBLESDN = "MBLESDN";

        /// <summary>
        /// MBWUMBLCOM.
        /// </summary>
        public const string MBWUMBLCOM = "MBWUMBLCOM";

        /// <summary>
        /// MBLESCO.
        /// </summary>
        public const string MBLESCO = "MBLESCO";

        /// <summary>
        /// MBWUMBLCNM.
        /// </summary>
        public const string MBWUMBLCNM = "MBWUMBLCNM";

        /// <summary>
        /// MBLESCN.
        /// </summary>
        public const string MBLESCN = "MBLESCN";

        /// <summary>
        /// MBWUMBIFL.
        /// </summary>
        public const string MBWUMBIFL = "MBWUMBIFL";

        /// <summary>
        /// MBINSF.
        /// </summary>
        public const string MBINSF = "MBINSF";

        /// <summary>
        /// MBFCAP.
        /// </summary>
        public const string MBFCAP = "MBFCAP";

        /// <summary>
        /// MBTOCAP.
        /// </summary>
        public const string MBTOCAP = "MBTOCAP";

        /// <summary>
        /// MBBCUOM.
        /// </summary>
        public const string MBBCUOM = "MBBCUOM";

        /// <summary>
        /// MBWUMBUCD.
        /// </summary>
        public const string MBWUMBUCD = "MBWUMBUCD";

        /// <summary>
        /// MBWCD.
        /// </summary>
        public const string MBWCD = "MBWCD";

        /// <summary>
        /// MBWUMBUDT.
        /// </summary>
        public const string MBWUMBUDT = "MBWUMBUDT";

        /// <summary>
        /// MBWMDT.
        /// </summary>
        public const string MBWMDT = "MBWMDT";

        /// <summary>
        /// MBWUMBUNB.
        /// </summary>
        public const string MBWUMBUNB = "MBWUMBUNB";

        /// <summary>
        /// MBWAB.
        /// </summary>
        public const string MBWAB = "MBWAB";

        /// <summary>
        /// MBWUMBUNM.
        /// </summary>
        public const string MBWUMBUNM = "MBWUMBUNM";

        /// <summary>
        /// MBWNUM.
        /// </summary>
        public const string MBWNUM = "MBWNUM";

        /// <summary>
        /// MBWUMBURF.
        /// </summary>
        public const string MBWUMBURF = "MBWUMBURF";

        /// <summary>
        /// MBWRF.
        /// </summary>
        public const string MBWRF = "MBWRF";

        /// <summary>
        /// MBURCD.
        /// </summary>
        public const string MBURCD = "MBURCD";

        /// <summary>
        /// MBURDT.
        /// </summary>
        public const string MBURDT = "MBURDT";

        /// <summary>
        /// MBURAT.
        /// </summary>
        public const string MBURAT = "MBURAT";

        /// <summary>
        /// MBURRF.
        /// </summary>
        public const string MBURRF = "MBURRF";

        /// <summary>
        /// MBURAB.
        /// </summary>
        public const string MBURAB = "MBURAB";

        /// <summary>
        /// MBUSER.
        /// </summary>
        public const string MBUSER = "MBUSER";

        /// <summary>
        /// MBPID.
        /// </summary>
        public const string MBPID = "MBPID";

        /// <summary>
        /// MBJOBN.
        /// </summary>
        public const string MBJOBN = "MBJOBN";

        /// <summary>
        /// MBUPMJ.
        /// </summary>
        public const string MBUPMJ = "MBUPMJ";

        /// <summary>
        /// MBUPMT.
        /// </summary>
        public const string MBUPMT = "MBUPMT";

        /// <summary>
        /// MBWCTRO.
        /// </summary>
        public const string MBWCTRO = "MBWCTRO";
    }

    /// <inheritdoc />
    public override string TableName => "F31B110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MBWUMBID", "MBWUMBID", JdeDataType.Numeric, null, true, true),
        new JdeField("MBWUMBDES", "MBWUMBDES", JdeDataType.String, 80),
        new JdeField("MBWUMBBATP", "MBWUMBBATP", JdeDataType.String, 2),
        new JdeField("MBBATP", "MBBATP", JdeDataType.String, 8),
        new JdeField("MBWUMBBATV", "MBWUMBBATV", JdeDataType.String, 2),
        new JdeField("MBBATV", "MBBATV", JdeDataType.String, 4),
        new JdeField("MBWUMBMCU", "MBWUMBMCU", JdeDataType.String, 2),
        new JdeField("MBMCU", "MBMCU", JdeDataType.String, 24),
        new JdeField("MBWUMBBID", "MBWUMBBID", JdeDataType.String, 2),
        new JdeField("MBBARID", "MBBARID", JdeDataType.String, 60),
        new JdeField("MBWUMBCONO", "MBWUMBCONO", JdeDataType.String, 2),
        new JdeField("MBBARCN", "MBBARCN", JdeDataType.Numeric),
        new JdeField("MBWUMBAGE", "MBWUMBAGE", JdeDataType.String, 2),
        new JdeField("MBRKNUM", "MBRKNUM", JdeDataType.Numeric),
        new JdeField("MBWUMBLOCN", "MBWUMBLOCN", JdeDataType.String, 2),
        new JdeField("MBLOCN", "MBLOCN", JdeDataType.String, 40),
        new JdeField("MBWUMBOC", "MBWUMBOC", JdeDataType.String, 2),
        new JdeField("MBCTRO", "MBCTRO", JdeDataType.String, 6),
        new JdeField("MBWUMBCS", "MBWUMBCS", JdeDataType.String, 2),
        new JdeField("MBBCST", "MBBCST", JdeDataType.String, 20),
        new JdeField("MBWUMBOYR", "MBWUMBOYR", JdeDataType.String, 2),
        new JdeField("MBOYRC", "MBOYRC", JdeDataType.Numeric),
        new JdeField("MBWUMBCON", "MBWUMBCON", JdeDataType.String, 2),
        new JdeField("MBBARCO", "MBBARCO", JdeDataType.String, 2),
        new JdeField("MBWUMBPOWN", "MBWUMBPOWN", JdeDataType.String, 2),
        new JdeField("MBPOWN", "MBPOWN", JdeDataType.Numeric),
        new JdeField("MBWUMBPFOR", "MBWUMBPFOR", JdeDataType.String, 2),
        new JdeField("MBFORES", "MBFORES", JdeDataType.String, 16),
        new JdeField("MBWUMBTSLV", "MBWUMBTSLV", JdeDataType.String, 2),
        new JdeField("MBTLEV", "MBTLEV", JdeDataType.String, 6),
        new JdeField("MBWUMBCC1", "MBWUMBCC1", JdeDataType.String, 2),
        new JdeField("MBSCTM", "MBSCTM", JdeDataType.String, 20),
        new JdeField("MBWUMBCC2", "MBWUMBCC2", JdeDataType.String, 2),
        new JdeField("MBSDRM", "MBSDRM", JdeDataType.String, 20),
        new JdeField("MBWUMBCC3", "MBWUMBCC3", JdeDataType.String, 2),
        new JdeField("MBSBDM", "MBSBDM", JdeDataType.String, 20),
        new JdeField("MBWUMBCC4", "MBWUMBCC4", JdeDataType.String, 2),
        new JdeField("MBSDRL", "MBSDRL", JdeDataType.String, 40),
        new JdeField("MBWUMBCC5", "MBWUMBCC5", JdeDataType.String, 2),
        new JdeField("MBINFO", "MBINFO", JdeDataType.String, 20),
        new JdeField("MBWUMBAVL", "MBWUMBAVL", JdeDataType.String, 2),
        new JdeField("MBBAVC", "MBBAVC", JdeDataType.String, 8),
        new JdeField("MBWUMBADR", "MBWUMBADR", JdeDataType.String, 2),
        new JdeField("MBAJRS", "MBAJRS", JdeDataType.String, 40),
        new JdeField("MBWUMBOOS", "MBWUMBOOS", JdeDataType.String, 2),
        new JdeField("MBDAOS", "MBDAOS", JdeDataType.Numeric),
        new JdeField("MBWUMBVS", "MBWUMBVS", JdeDataType.String, 2),
        new JdeField("MBBVST", "MBBVST", JdeDataType.String, 6),
        new JdeField("MBWUMBRN", "MBWUMBRN", JdeDataType.String, 2),
        new JdeField("MBRKNMR", "MBRKNMR", JdeDataType.String, 40),
        new JdeField("MBWUMBSHV", "MBWUMBSHV", JdeDataType.String, 2),
        new JdeField("MBSHAV", "MBSHAV", JdeDataType.String, 2),
        new JdeField("MBWUMBDSHV", "MBWUMBDSHV", JdeDataType.String, 2),
        new JdeField("MBSHAVD", "MBSHAVD", JdeDataType.Numeric),
        new JdeField("MBWUMBTRWK", "MBWUMBTRWK", JdeDataType.String, 2),
        new JdeField("MBTSTR", "MBTSTR", JdeDataType.String, 2),
        new JdeField("MBWUMBDFU", "MBWUMBDFU", JdeDataType.String, 2),
        new JdeField("MBDAFU", "MBDAFU", JdeDataType.Numeric),
        new JdeField("MBWUMBNU", "MBWUMBNU", JdeDataType.String, 2),
        new JdeField("MBNXUSE", "MBNXUSE", JdeDataType.String, 8),
        new JdeField("MBWUMBNFLL", "MBWUMBNFLL", JdeDataType.String, 2),
        new JdeField("MBNUMFL", "MBNUMFL", JdeDataType.Numeric),
        new JdeField("MBWUMBTMET", "MBWUMBTMET", JdeDataType.String, 2),
        new JdeField("MBMTDLT", "MBMTDLT", JdeDataType.String, 16),
        new JdeField("MBWUMBDT", "MBWUMBDT", JdeDataType.String, 2),
        new JdeField("MBDALT", "MBDALT", JdeDataType.Numeric),
        new JdeField("MBWUMBDS", "MBWUMBDS", JdeDataType.String, 2),
        new JdeField("MBDALS", "MBDALS", JdeDataType.Numeric),
        new JdeField("MBWUMBCOM", "MBWUMBCOM", JdeDataType.String, 2),
        new JdeField("MBGECM", "MBGECM", JdeDataType.String, 80),
        new JdeField("MBWUMBCSTG", "MBWUMBCSTG", JdeDataType.String, 2),
        new JdeField("MBWCG", "MBWCG", JdeDataType.String, 24),
        new JdeField("MBWUMBOWN", "MBWUMBOWN", JdeDataType.String, 2),
        new JdeField("MBBOWN", "MBBOWN", JdeDataType.Numeric),
        new JdeField("MBWUMBLF", "MBWUMBLF", JdeDataType.String, 2),
        new JdeField("MBLEAS", "MBLEAS", JdeDataType.String, 2),
        new JdeField("MBWUMBLT", "MBWUMBLT", JdeDataType.String, 2),
        new JdeField("MBLESTM", "MBLESTM", JdeDataType.Numeric),
        new JdeField("MBWUMBLD", "MBWUMBLD", JdeDataType.String, 2),
        new JdeField("MBLESDT", "MBLESDT", JdeDataType.Numeric),
        new JdeField("MBWUMBLDOC", "MBWUMBLDOC", JdeDataType.String, 2),
        new JdeField("MBLESDN", "MBLESDN", JdeDataType.Numeric),
        new JdeField("MBWUMBLCOM", "MBWUMBLCOM", JdeDataType.String, 2),
        new JdeField("MBLESCO", "MBLESCO", JdeDataType.Numeric),
        new JdeField("MBWUMBLCNM", "MBWUMBLCNM", JdeDataType.String, 2),
        new JdeField("MBLESCN", "MBLESCN", JdeDataType.String, 60),
        new JdeField("MBWUMBIFL", "MBWUMBIFL", JdeDataType.String, 2),
        new JdeField("MBINSF", "MBINSF", JdeDataType.String, 2),
        new JdeField("MBFCAP", "MBFCAP", JdeDataType.Numeric),
        new JdeField("MBTOCAP", "MBTOCAP", JdeDataType.Numeric),
        new JdeField("MBBCUOM", "MBBCUOM", JdeDataType.String, 4),
        new JdeField("MBWUMBUCD", "MBWUMBUCD", JdeDataType.String, 2),
        new JdeField("MBWCD", "MBWCD", JdeDataType.String, 6),
        new JdeField("MBWUMBUDT", "MBWUMBUDT", JdeDataType.String, 2),
        new JdeField("MBWMDT", "MBWMDT", JdeDataType.Numeric),
        new JdeField("MBWUMBUNB", "MBWUMBUNB", JdeDataType.String, 2),
        new JdeField("MBWAB", "MBWAB", JdeDataType.Numeric),
        new JdeField("MBWUMBUNM", "MBWUMBUNM", JdeDataType.String, 2),
        new JdeField("MBWNUM", "MBWNUM", JdeDataType.Numeric),
        new JdeField("MBWUMBURF", "MBWUMBURF", JdeDataType.String, 2),
        new JdeField("MBWRF", "MBWRF", JdeDataType.String, 60),
        new JdeField("MBURCD", "MBURCD", JdeDataType.String, 4),
        new JdeField("MBURDT", "MBURDT", JdeDataType.Numeric),
        new JdeField("MBURAT", "MBURAT", JdeDataType.Numeric),
        new JdeField("MBURRF", "MBURRF", JdeDataType.String, 30),
        new JdeField("MBURAB", "MBURAB", JdeDataType.Numeric),
        new JdeField("MBUSER", "MBUSER", JdeDataType.String, 20),
        new JdeField("MBPID", "MBPID", JdeDataType.String, 20),
        new JdeField("MBJOBN", "MBJOBN", JdeDataType.String, 20),
        new JdeField("MBUPMJ", "MBUPMJ", JdeDataType.Numeric),
        new JdeField("MBUPMT", "MBUPMT", JdeDataType.Numeric),
        new JdeField("MBWCTRO", "MBWCTRO", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B110_0", "Primary Key on MBWUMBID", new[] { "MBWUMBID" }, isUnique: true, isPrimaryKey: true)
    };
}
