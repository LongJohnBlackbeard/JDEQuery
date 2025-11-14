using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4801Z2 - .
/// </summary>
public class F4801Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSEDUS.
        /// </summary>
        public const string WSEDUS = "WSEDUS";

        /// <summary>
        /// WSEDBT.
        /// </summary>
        public const string WSEDBT = "WSEDBT";

        /// <summary>
        /// WSEDTN.
        /// </summary>
        public const string WSEDTN = "WSEDTN";

        /// <summary>
        /// WSEDLN.
        /// </summary>
        public const string WSEDLN = "WSEDLN";

        /// <summary>
        /// WSEDCT.
        /// </summary>
        public const string WSEDCT = "WSEDCT";

        /// <summary>
        /// WSTYTN.
        /// </summary>
        public const string WSTYTN = "WSTYTN";

        /// <summary>
        /// WSEDFT.
        /// </summary>
        public const string WSEDFT = "WSEDFT";

        /// <summary>
        /// WSEDDT.
        /// </summary>
        public const string WSEDDT = "WSEDDT";

        /// <summary>
        /// WSDRIN.
        /// </summary>
        public const string WSDRIN = "WSDRIN";

        /// <summary>
        /// WSEDDL.
        /// </summary>
        public const string WSEDDL = "WSEDDL";

        /// <summary>
        /// WSEDSP.
        /// </summary>
        public const string WSEDSP = "WSEDSP";

        /// <summary>
        /// WSPNID.
        /// </summary>
        public const string WSPNID = "WSPNID";

        /// <summary>
        /// WSTNAC.
        /// </summary>
        public const string WSTNAC = "WSTNAC";

        /// <summary>
        /// WSDCTO.
        /// </summary>
        public const string WSDCTO = "WSDCTO";

        /// <summary>
        /// WSRCD.
        /// </summary>
        public const string WSRCD = "WSRCD";

        /// <summary>
        /// WSDGL.
        /// </summary>
        public const string WSDGL = "WSDGL";

        /// <summary>
        /// WSLOTS.
        /// </summary>
        public const string WSLOTS = "WSLOTS";

        /// <summary>
        /// WSEXPR.
        /// </summary>
        public const string WSEXPR = "WSEXPR";

        /// <summary>
        /// WSLOT1.
        /// </summary>
        public const string WSLOT1 = "WSLOT1";

        /// <summary>
        /// WSLOT2.
        /// </summary>
        public const string WSLOT2 = "WSLOT2";

        /// <summary>
        /// WSDOCO.
        /// </summary>
        public const string WSDOCO = "WSDOCO";

        /// <summary>
        /// WSSFXO.
        /// </summary>
        public const string WSSFXO = "WSSFXO";

        /// <summary>
        /// WSRCTO.
        /// </summary>
        public const string WSRCTO = "WSRCTO";

        /// <summary>
        /// WSRORN.
        /// </summary>
        public const string WSRORN = "WSRORN";

        /// <summary>
        /// WSLNID.
        /// </summary>
        public const string WSLNID = "WSLNID";

        /// <summary>
        /// WSPTWO.
        /// </summary>
        public const string WSPTWO = "WSPTWO";

        /// <summary>
        /// WSPARS.
        /// </summary>
        public const string WSPARS = "WSPARS";

        /// <summary>
        /// WSTYPS.
        /// </summary>
        public const string WSTYPS = "WSTYPS";

        /// <summary>
        /// WSPRTS.
        /// </summary>
        public const string WSPRTS = "WSPRTS";

        /// <summary>
        /// WSDL01.
        /// </summary>
        public const string WSDL01 = "WSDL01";

        /// <summary>
        /// WSSTCM.
        /// </summary>
        public const string WSSTCM = "WSSTCM";

        /// <summary>
        /// WSCO.
        /// </summary>
        public const string WSCO = "WSCO";

        /// <summary>
        /// WSMCU.
        /// </summary>
        public const string WSMCU = "WSMCU";

        /// <summary>
        /// WSMMCU.
        /// </summary>
        public const string WSMMCU = "WSMMCU";

        /// <summary>
        /// WSLOCN.
        /// </summary>
        public const string WSLOCN = "WSLOCN";

        /// <summary>
        /// WSAISL.
        /// </summary>
        public const string WSAISL = "WSAISL";

        /// <summary>
        /// WSBIN.
        /// </summary>
        public const string WSBIN = "WSBIN";

        /// <summary>
        /// WSSRST.
        /// </summary>
        public const string WSSRST = "WSSRST";

        /// <summary>
        /// WSDCG.
        /// </summary>
        public const string WSDCG = "WSDCG";

        /// <summary>
        /// WSSUB.
        /// </summary>
        public const string WSSUB = "WSSUB";

        /// <summary>
        /// WSAN8.
        /// </summary>
        public const string WSAN8 = "WSAN8";

        /// <summary>
        /// WSANO.
        /// </summary>
        public const string WSANO = "WSANO";

        /// <summary>
        /// WSANSA.
        /// </summary>
        public const string WSANSA = "WSANSA";

        /// <summary>
        /// WSANPA.
        /// </summary>
        public const string WSANPA = "WSANPA";

        /// <summary>
        /// WSANP.
        /// </summary>
        public const string WSANP = "WSANP";

        /// <summary>
        /// WSDPL.
        /// </summary>
        public const string WSDPL = "WSDPL";

        /// <summary>
        /// WSANT.
        /// </summary>
        public const string WSANT = "WSANT";

        /// <summary>
        /// WSNAN8.
        /// </summary>
        public const string WSNAN8 = "WSNAN8";

        /// <summary>
        /// WSTRDJ.
        /// </summary>
        public const string WSTRDJ = "WSTRDJ";

        /// <summary>
        /// WSSTRT.
        /// </summary>
        public const string WSSTRT = "WSSTRT";

        /// <summary>
        /// WSDRQJ.
        /// </summary>
        public const string WSDRQJ = "WSDRQJ";

        /// <summary>
        /// WSSTRX.
        /// </summary>
        public const string WSSTRX = "WSSTRX";

        /// <summary>
        /// WSDAP.
        /// </summary>
        public const string WSDAP = "WSDAP";

        /// <summary>
        /// WSDAT.
        /// </summary>
        public const string WSDAT = "WSDAT";

        /// <summary>
        /// WSPPDT.
        /// </summary>
        public const string WSPPDT = "WSPPDT";

        /// <summary>
        /// WSWR01.
        /// </summary>
        public const string WSWR01 = "WSWR01";

        /// <summary>
        /// WSWR02.
        /// </summary>
        public const string WSWR02 = "WSWR02";

        /// <summary>
        /// WSWR03.
        /// </summary>
        public const string WSWR03 = "WSWR03";

        /// <summary>
        /// WSWR04.
        /// </summary>
        public const string WSWR04 = "WSWR04";

        /// <summary>
        /// WSWR05.
        /// </summary>
        public const string WSWR05 = "WSWR05";

        /// <summary>
        /// WSWR06.
        /// </summary>
        public const string WSWR06 = "WSWR06";

        /// <summary>
        /// WSWR07.
        /// </summary>
        public const string WSWR07 = "WSWR07";

        /// <summary>
        /// WSWR08.
        /// </summary>
        public const string WSWR08 = "WSWR08";

        /// <summary>
        /// WSWR09.
        /// </summary>
        public const string WSWR09 = "WSWR09";

        /// <summary>
        /// WSWR10.
        /// </summary>
        public const string WSWR10 = "WSWR10";

        /// <summary>
        /// WSVR01.
        /// </summary>
        public const string WSVR01 = "WSVR01";

        /// <summary>
        /// WSVR02.
        /// </summary>
        public const string WSVR02 = "WSVR02";

        /// <summary>
        /// WSAMTO.
        /// </summary>
        public const string WSAMTO = "WSAMTO";

        /// <summary>
        /// WSSETC.
        /// </summary>
        public const string WSSETC = "WSSETC";

        /// <summary>
        /// WSBRT.
        /// </summary>
        public const string WSBRT = "WSBRT";

        /// <summary>
        /// WSPAYT.
        /// </summary>
        public const string WSPAYT = "WSPAYT";

        /// <summary>
        /// WSAMTC.
        /// </summary>
        public const string WSAMTC = "WSAMTC";

        /// <summary>
        /// WSHRSO.
        /// </summary>
        public const string WSHRSO = "WSHRSO";

        /// <summary>
        /// WSHRSC.
        /// </summary>
        public const string WSHRSC = "WSHRSC";

        /// <summary>
        /// WSAMTA.
        /// </summary>
        public const string WSAMTA = "WSAMTA";

        /// <summary>
        /// WSHRSA.
        /// </summary>
        public const string WSHRSA = "WSHRSA";

        /// <summary>
        /// WSITM.
        /// </summary>
        public const string WSITM = "WSITM";

        /// <summary>
        /// WSAITM.
        /// </summary>
        public const string WSAITM = "WSAITM";

        /// <summary>
        /// WSLITM.
        /// </summary>
        public const string WSLITM = "WSLITM";

        /// <summary>
        /// WSNUMB.
        /// </summary>
        public const string WSNUMB = "WSNUMB";

        /// <summary>
        /// WSAPID.
        /// </summary>
        public const string WSAPID = "WSAPID";

        /// <summary>
        /// WSUORG.
        /// </summary>
        public const string WSUORG = "WSUORG";

        /// <summary>
        /// WSSOBK.
        /// </summary>
        public const string WSSOBK = "WSSOBK";

        /// <summary>
        /// WSSOCN.
        /// </summary>
        public const string WSSOCN = "WSSOCN";

        /// <summary>
        /// WSSOQS.
        /// </summary>
        public const string WSSOQS = "WSSOQS";

        /// <summary>
        /// WSQTYT.
        /// </summary>
        public const string WSQTYT = "WSQTYT";

        /// <summary>
        /// WSUOM.
        /// </summary>
        public const string WSUOM = "WSUOM";

        /// <summary>
        /// WSSHNO.
        /// </summary>
        public const string WSSHNO = "WSSHNO";

        /// <summary>
        /// WSPBTM.
        /// </summary>
        public const string WSPBTM = "WSPBTM";

        /// <summary>
        /// WSTBM.
        /// </summary>
        public const string WSTBM = "WSTBM";

        /// <summary>
        /// WSTRT.
        /// </summary>
        public const string WSTRT = "WSTRT";

        /// <summary>
        /// WSSHTY.
        /// </summary>
        public const string WSSHTY = "WSSHTY";

        /// <summary>
        /// WSPEC.
        /// </summary>
        public const string WSPEC = "WSPEC";

        /// <summary>
        /// WSPPFG.
        /// </summary>
        public const string WSPPFG = "WSPPFG";

        /// <summary>
        /// WSBM.
        /// </summary>
        public const string WSBM = "WSBM";

        /// <summary>
        /// WSRTG.
        /// </summary>
        public const string WSRTG = "WSRTG";

        /// <summary>
        /// WSSPRT.
        /// </summary>
        public const string WSSPRT = "WSSPRT";

        /// <summary>
        /// WSUNCD.
        /// </summary>
        public const string WSUNCD = "WSUNCD";

        /// <summary>
        /// WSINDC.
        /// </summary>
        public const string WSINDC = "WSINDC";

        /// <summary>
        /// WSRESC.
        /// </summary>
        public const string WSRESC = "WSRESC";

        /// <summary>
        /// WSMOH.
        /// </summary>
        public const string WSMOH = "WSMOH";

        /// <summary>
        /// WSTDT.
        /// </summary>
        public const string WSTDT = "WSTDT";

        /// <summary>
        /// WSPOU.
        /// </summary>
        public const string WSPOU = "WSPOU";

        /// <summary>
        /// WSPC.
        /// </summary>
        public const string WSPC = "WSPC";

        /// <summary>
        /// WSLTLV.
        /// </summary>
        public const string WSLTLV = "WSLTLV";

        /// <summary>
        /// WSLTCM.
        /// </summary>
        public const string WSLTCM = "WSLTCM";

        /// <summary>
        /// WSCTS1.
        /// </summary>
        public const string WSCTS1 = "WSCTS1";

        /// <summary>
        /// WSLOTN.
        /// </summary>
        public const string WSLOTN = "WSLOTN";

        /// <summary>
        /// WSLOTP.
        /// </summary>
        public const string WSLOTP = "WSLOTP";

        /// <summary>
        /// WSLOTG.
        /// </summary>
        public const string WSLOTG = "WSLOTG";

        /// <summary>
        /// WSRAT1.
        /// </summary>
        public const string WSRAT1 = "WSRAT1";

        /// <summary>
        /// WSRAT2.
        /// </summary>
        public const string WSRAT2 = "WSRAT2";

        /// <summary>
        /// WSDCT.
        /// </summary>
        public const string WSDCT = "WSDCT";

        /// <summary>
        /// WSSBLI.
        /// </summary>
        public const string WSSBLI = "WSSBLI";

        /// <summary>
        /// WSRKCO.
        /// </summary>
        public const string WSRKCO = "WSRKCO";

        /// <summary>
        /// WSBREV.
        /// </summary>
        public const string WSBREV = "WSBREV";

        /// <summary>
        /// WSRREV.
        /// </summary>
        public const string WSRREV = "WSRREV";

        /// <summary>
        /// WSDRWC.
        /// </summary>
        public const string WSDRWC = "WSDRWC";

        /// <summary>
        /// WSRTCH.
        /// </summary>
        public const string WSRTCH = "WSRTCH";

        /// <summary>
        /// WSPNRQ.
        /// </summary>
        public const string WSPNRQ = "WSPNRQ";

        /// <summary>
        /// WSREAS.
        /// </summary>
        public const string WSREAS = "WSREAS";

        /// <summary>
        /// WSPHSE.
        /// </summary>
        public const string WSPHSE = "WSPHSE";

        /// <summary>
        /// WSXDSP.
        /// </summary>
        public const string WSXDSP = "WSXDSP";

        /// <summary>
        /// WSBOMC.
        /// </summary>
        public const string WSBOMC = "WSBOMC";

        /// <summary>
        /// WSAAID.
        /// </summary>
        public const string WSAAID = "WSAAID";

        /// <summary>
        /// WSNTST.
        /// </summary>
        public const string WSNTST = "WSNTST";

        /// <summary>
        /// WSXRTO.
        /// </summary>
        public const string WSXRTO = "WSXRTO";

        /// <summary>
        /// WSESDN.
        /// </summary>
        public const string WSESDN = "WSESDN";

        /// <summary>
        /// WSACDN.
        /// </summary>
        public const string WSACDN = "WSACDN";

        /// <summary>
        /// WSSAID.
        /// </summary>
        public const string WSSAID = "WSSAID";

        /// <summary>
        /// WSMPOS.
        /// </summary>
        public const string WSMPOS = "WSMPOS";

        /// <summary>
        /// WSAPRT.
        /// </summary>
        public const string WSAPRT = "WSAPRT";

        /// <summary>
        /// WSAMLC.
        /// </summary>
        public const string WSAMLC = "WSAMLC";

        /// <summary>
        /// WSAMMC.
        /// </summary>
        public const string WSAMMC = "WSAMMC";

        /// <summary>
        /// WSAMOT.
        /// </summary>
        public const string WSAMOT = "WSAMOT";

        /// <summary>
        /// WSLBAM.
        /// </summary>
        public const string WSLBAM = "WSLBAM";

        /// <summary>
        /// WSMTAM.
        /// </summary>
        public const string WSMTAM = "WSMTAM";

        /// <summary>
        /// WSURCD.
        /// </summary>
        public const string WSURCD = "WSURCD";

        /// <summary>
        /// WSURDT.
        /// </summary>
        public const string WSURDT = "WSURDT";

        /// <summary>
        /// WSURAT.
        /// </summary>
        public const string WSURAT = "WSURAT";

        /// <summary>
        /// WSURAB.
        /// </summary>
        public const string WSURAB = "WSURAB";

        /// <summary>
        /// WSURRF.
        /// </summary>
        public const string WSURRF = "WSURRF";

        /// <summary>
        /// WSTORG.
        /// </summary>
        public const string WSTORG = "WSTORG";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSTDAY.
        /// </summary>
        public const string WSTDAY = "WSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4801Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSEDUS", "WSEDUS", JdeDataType.String, 20, true, true),
        new JdeField("WSEDBT", "WSEDBT", JdeDataType.String, 30, true, true),
        new JdeField("WSEDTN", "WSEDTN", JdeDataType.String, 44, true, true),
        new JdeField("WSEDLN", "WSEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WSEDCT", "WSEDCT", JdeDataType.String, 4),
        new JdeField("WSTYTN", "WSTYTN", JdeDataType.String, 16),
        new JdeField("WSEDFT", "WSEDFT", JdeDataType.String, 20),
        new JdeField("WSEDDT", "WSEDDT", JdeDataType.Numeric),
        new JdeField("WSDRIN", "WSDRIN", JdeDataType.String, 2),
        new JdeField("WSEDDL", "WSEDDL", JdeDataType.Numeric),
        new JdeField("WSEDSP", "WSEDSP", JdeDataType.String, 2),
        new JdeField("WSPNID", "WSPNID", JdeDataType.String, 30),
        new JdeField("WSTNAC", "WSTNAC", JdeDataType.String, 4),
        new JdeField("WSDCTO", "WSDCTO", JdeDataType.String, 4),
        new JdeField("WSRCD", "WSRCD", JdeDataType.String, 6),
        new JdeField("WSDGL", "WSDGL", JdeDataType.Numeric),
        new JdeField("WSLOTS", "WSLOTS", JdeDataType.String, 2),
        new JdeField("WSEXPR", "WSEXPR", JdeDataType.Numeric),
        new JdeField("WSLOT1", "WSLOT1", JdeDataType.String, 60),
        new JdeField("WSLOT2", "WSLOT2", JdeDataType.String, 60),
        new JdeField("WSDOCO", "WSDOCO", JdeDataType.Numeric),
        new JdeField("WSSFXO", "WSSFXO", JdeDataType.String, 6),
        new JdeField("WSRCTO", "WSRCTO", JdeDataType.String, 4),
        new JdeField("WSRORN", "WSRORN", JdeDataType.String, 16),
        new JdeField("WSLNID", "WSLNID", JdeDataType.Numeric),
        new JdeField("WSPTWO", "WSPTWO", JdeDataType.Numeric),
        new JdeField("WSPARS", "WSPARS", JdeDataType.String, 16),
        new JdeField("WSTYPS", "WSTYPS", JdeDataType.String, 2),
        new JdeField("WSPRTS", "WSPRTS", JdeDataType.String, 2),
        new JdeField("WSDL01", "WSDL01", JdeDataType.String, 60),
        new JdeField("WSSTCM", "WSSTCM", JdeDataType.String, 60),
        new JdeField("WSCO", "WSCO", JdeDataType.String, 10),
        new JdeField("WSMCU", "WSMCU", JdeDataType.String, 24),
        new JdeField("WSMMCU", "WSMMCU", JdeDataType.String, 24),
        new JdeField("WSLOCN", "WSLOCN", JdeDataType.String, 40),
        new JdeField("WSAISL", "WSAISL", JdeDataType.String, 16),
        new JdeField("WSBIN", "WSBIN", JdeDataType.String, 16),
        new JdeField("WSSRST", "WSSRST", JdeDataType.String, 4),
        new JdeField("WSDCG", "WSDCG", JdeDataType.Numeric),
        new JdeField("WSSUB", "WSSUB", JdeDataType.String, 16),
        new JdeField("WSAN8", "WSAN8", JdeDataType.Numeric),
        new JdeField("WSANO", "WSANO", JdeDataType.Numeric),
        new JdeField("WSANSA", "WSANSA", JdeDataType.Numeric),
        new JdeField("WSANPA", "WSANPA", JdeDataType.Numeric),
        new JdeField("WSANP", "WSANP", JdeDataType.Numeric),
        new JdeField("WSDPL", "WSDPL", JdeDataType.Numeric),
        new JdeField("WSANT", "WSANT", JdeDataType.Numeric),
        new JdeField("WSNAN8", "WSNAN8", JdeDataType.Numeric),
        new JdeField("WSTRDJ", "WSTRDJ", JdeDataType.Numeric),
        new JdeField("WSSTRT", "WSSTRT", JdeDataType.Numeric),
        new JdeField("WSDRQJ", "WSDRQJ", JdeDataType.Numeric),
        new JdeField("WSSTRX", "WSSTRX", JdeDataType.Numeric),
        new JdeField("WSDAP", "WSDAP", JdeDataType.Numeric),
        new JdeField("WSDAT", "WSDAT", JdeDataType.Numeric),
        new JdeField("WSPPDT", "WSPPDT", JdeDataType.Numeric),
        new JdeField("WSWR01", "WSWR01", JdeDataType.String, 8),
        new JdeField("WSWR02", "WSWR02", JdeDataType.String, 6),
        new JdeField("WSWR03", "WSWR03", JdeDataType.String, 6),
        new JdeField("WSWR04", "WSWR04", JdeDataType.String, 6),
        new JdeField("WSWR05", "WSWR05", JdeDataType.String, 6),
        new JdeField("WSWR06", "WSWR06", JdeDataType.String, 6),
        new JdeField("WSWR07", "WSWR07", JdeDataType.String, 6),
        new JdeField("WSWR08", "WSWR08", JdeDataType.String, 6),
        new JdeField("WSWR09", "WSWR09", JdeDataType.String, 6),
        new JdeField("WSWR10", "WSWR10", JdeDataType.String, 6),
        new JdeField("WSVR01", "WSVR01", JdeDataType.String, 50),
        new JdeField("WSVR02", "WSVR02", JdeDataType.String, 50),
        new JdeField("WSAMTO", "WSAMTO", JdeDataType.Numeric),
        new JdeField("WSSETC", "WSSETC", JdeDataType.Numeric),
        new JdeField("WSBRT", "WSBRT", JdeDataType.Numeric),
        new JdeField("WSPAYT", "WSPAYT", JdeDataType.String, 10),
        new JdeField("WSAMTC", "WSAMTC", JdeDataType.Numeric),
        new JdeField("WSHRSO", "WSHRSO", JdeDataType.Numeric),
        new JdeField("WSHRSC", "WSHRSC", JdeDataType.Numeric),
        new JdeField("WSAMTA", "WSAMTA", JdeDataType.Numeric),
        new JdeField("WSHRSA", "WSHRSA", JdeDataType.Numeric),
        new JdeField("WSITM", "WSITM", JdeDataType.Numeric),
        new JdeField("WSAITM", "WSAITM", JdeDataType.String, 50),
        new JdeField("WSLITM", "WSLITM", JdeDataType.String, 50),
        new JdeField("WSNUMB", "WSNUMB", JdeDataType.Numeric),
        new JdeField("WSAPID", "WSAPID", JdeDataType.String, 24),
        new JdeField("WSUORG", "WSUORG", JdeDataType.Numeric),
        new JdeField("WSSOBK", "WSSOBK", JdeDataType.Numeric),
        new JdeField("WSSOCN", "WSSOCN", JdeDataType.Numeric),
        new JdeField("WSSOQS", "WSSOQS", JdeDataType.Numeric),
        new JdeField("WSQTYT", "WSQTYT", JdeDataType.Numeric),
        new JdeField("WSUOM", "WSUOM", JdeDataType.String, 4),
        new JdeField("WSSHNO", "WSSHNO", JdeDataType.String, 20),
        new JdeField("WSPBTM", "WSPBTM", JdeDataType.Numeric),
        new JdeField("WSTBM", "WSTBM", JdeDataType.String, 6),
        new JdeField("WSTRT", "WSTRT", JdeDataType.String, 6),
        new JdeField("WSSHTY", "WSSHTY", JdeDataType.String, 2),
        new JdeField("WSPEC", "WSPEC", JdeDataType.String, 2),
        new JdeField("WSPPFG", "WSPPFG", JdeDataType.String, 2),
        new JdeField("WSBM", "WSBM", JdeDataType.String, 2),
        new JdeField("WSRTG", "WSRTG", JdeDataType.String, 2),
        new JdeField("WSSPRT", "WSSPRT", JdeDataType.String, 2),
        new JdeField("WSUNCD", "WSUNCD", JdeDataType.String, 2),
        new JdeField("WSINDC", "WSINDC", JdeDataType.String, 2),
        new JdeField("WSRESC", "WSRESC", JdeDataType.Numeric),
        new JdeField("WSMOH", "WSMOH", JdeDataType.Numeric),
        new JdeField("WSTDT", "WSTDT", JdeDataType.Numeric),
        new JdeField("WSPOU", "WSPOU", JdeDataType.Numeric),
        new JdeField("WSPC", "WSPC", JdeDataType.Numeric),
        new JdeField("WSLTLV", "WSLTLV", JdeDataType.Numeric),
        new JdeField("WSLTCM", "WSLTCM", JdeDataType.Numeric),
        new JdeField("WSCTS1", "WSCTS1", JdeDataType.Numeric),
        new JdeField("WSLOTN", "WSLOTN", JdeDataType.String, 60),
        new JdeField("WSLOTP", "WSLOTP", JdeDataType.Numeric),
        new JdeField("WSLOTG", "WSLOTG", JdeDataType.String, 6),
        new JdeField("WSRAT1", "WSRAT1", JdeDataType.Numeric),
        new JdeField("WSRAT2", "WSRAT2", JdeDataType.Numeric),
        new JdeField("WSDCT", "WSDCT", JdeDataType.String, 4),
        new JdeField("WSSBLI", "WSSBLI", JdeDataType.String, 2),
        new JdeField("WSRKCO", "WSRKCO", JdeDataType.String, 10),
        new JdeField("WSBREV", "WSBREV", JdeDataType.String, 6),
        new JdeField("WSRREV", "WSRREV", JdeDataType.String, 6),
        new JdeField("WSDRWC", "WSDRWC", JdeDataType.String, 2),
        new JdeField("WSRTCH", "WSRTCH", JdeDataType.String, 2),
        new JdeField("WSPNRQ", "WSPNRQ", JdeDataType.String, 2),
        new JdeField("WSREAS", "WSREAS", JdeDataType.String, 4),
        new JdeField("WSPHSE", "WSPHSE", JdeDataType.String, 6),
        new JdeField("WSXDSP", "WSXDSP", JdeDataType.String, 6),
        new JdeField("WSBOMC", "WSBOMC", JdeDataType.String, 2),
        new JdeField("WSAAID", "WSAAID", JdeDataType.Numeric),
        new JdeField("WSNTST", "WSNTST", JdeDataType.String, 4),
        new JdeField("WSXRTO", "WSXRTO", JdeDataType.Numeric),
        new JdeField("WSESDN", "WSESDN", JdeDataType.Numeric),
        new JdeField("WSACDN", "WSACDN", JdeDataType.Numeric),
        new JdeField("WSSAID", "WSSAID", JdeDataType.Numeric),
        new JdeField("WSMPOS", "WSMPOS", JdeDataType.Numeric),
        new JdeField("WSAPRT", "WSAPRT", JdeDataType.String, 6),
        new JdeField("WSAMLC", "WSAMLC", JdeDataType.Numeric),
        new JdeField("WSAMMC", "WSAMMC", JdeDataType.Numeric),
        new JdeField("WSAMOT", "WSAMOT", JdeDataType.Numeric),
        new JdeField("WSLBAM", "WSLBAM", JdeDataType.Numeric),
        new JdeField("WSMTAM", "WSMTAM", JdeDataType.Numeric),
        new JdeField("WSURCD", "WSURCD", JdeDataType.String, 4),
        new JdeField("WSURDT", "WSURDT", JdeDataType.Numeric),
        new JdeField("WSURAT", "WSURAT", JdeDataType.Numeric),
        new JdeField("WSURAB", "WSURAB", JdeDataType.Numeric),
        new JdeField("WSURRF", "WSURRF", JdeDataType.String, 30),
        new JdeField("WSTORG", "WSTORG", JdeDataType.String, 20),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSTDAY", "WSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4801Z2_0", "Primary Key on WSEDUS, WSEDBT, WSEDTN, WSEDLN", new[] { "WSEDUS", "WSEDBT", "WSEDTN", "WSEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4801Z2_2", "Index on WSDOCO, WSEDLN, WSTYTN, WSTNAC, WSDRIN, WSEDDL", new[] { "WSDOCO", "WSEDLN", "WSTYTN", "WSTNAC", "WSDRIN", "WSEDDL" })
    };
}
