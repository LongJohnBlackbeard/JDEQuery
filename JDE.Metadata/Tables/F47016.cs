using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47016 - .
/// </summary>
public class F47016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDTY.
        /// </summary>
        public const string SYEDTY = "SYEDTY";

        /// <summary>
        /// SYEDSQ.
        /// </summary>
        public const string SYEDSQ = "SYEDSQ";

        /// <summary>
        /// SYEKCO.
        /// </summary>
        public const string SYEKCO = "SYEKCO";

        /// <summary>
        /// SYEDOC.
        /// </summary>
        public const string SYEDOC = "SYEDOC";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDST.
        /// </summary>
        public const string SYEDST = "SYEDST";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYEDER.
        /// </summary>
        public const string SYEDER = "SYEDER";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTPUR.
        /// </summary>
        public const string SYTPUR = "SYTPUR";

        /// <summary>
        /// SYKCOO.
        /// </summary>
        public const string SYKCOO = "SYKCOO";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYSFXO.
        /// </summary>
        public const string SYSFXO = "SYSFXO";

        /// <summary>
        /// SYMCU.
        /// </summary>
        public const string SYMCU = "SYMCU";

        /// <summary>
        /// SYOKCO.
        /// </summary>
        public const string SYOKCO = "SYOKCO";

        /// <summary>
        /// SYOORN.
        /// </summary>
        public const string SYOORN = "SYOORN";

        /// <summary>
        /// SYOCTO.
        /// </summary>
        public const string SYOCTO = "SYOCTO";

        /// <summary>
        /// SYRKCO.
        /// </summary>
        public const string SYRKCO = "SYRKCO";

        /// <summary>
        /// SYRORN.
        /// </summary>
        public const string SYRORN = "SYRORN";

        /// <summary>
        /// SYRCTO.
        /// </summary>
        public const string SYRCTO = "SYRCTO";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYSHAN.
        /// </summary>
        public const string SYSHAN = "SYSHAN";

        /// <summary>
        /// SYDRQJ.
        /// </summary>
        public const string SYDRQJ = "SYDRQJ";

        /// <summary>
        /// SYTRDJ.
        /// </summary>
        public const string SYTRDJ = "SYTRDJ";

        /// <summary>
        /// SYPDDJ.
        /// </summary>
        public const string SYPDDJ = "SYPDDJ";

        /// <summary>
        /// SYOPDJ.
        /// </summary>
        public const string SYOPDJ = "SYOPDJ";

        /// <summary>
        /// SYADDJ.
        /// </summary>
        public const string SYADDJ = "SYADDJ";

        /// <summary>
        /// SYCNDJ.
        /// </summary>
        public const string SYCNDJ = "SYCNDJ";

        /// <summary>
        /// SYPEFJ.
        /// </summary>
        public const string SYPEFJ = "SYPEFJ";

        /// <summary>
        /// SYPPDJ.
        /// </summary>
        public const string SYPPDJ = "SYPPDJ";

        /// <summary>
        /// SYPSDJ.
        /// </summary>
        public const string SYPSDJ = "SYPSDJ";

        /// <summary>
        /// SYVR01.
        /// </summary>
        public const string SYVR01 = "SYVR01";

        /// <summary>
        /// SYVR02.
        /// </summary>
        public const string SYVR02 = "SYVR02";

        /// <summary>
        /// SYDEL1.
        /// </summary>
        public const string SYDEL1 = "SYDEL1";

        /// <summary>
        /// SYDEL2.
        /// </summary>
        public const string SYDEL2 = "SYDEL2";

        /// <summary>
        /// SYRMK.
        /// </summary>
        public const string SYRMK = "SYRMK";

        /// <summary>
        /// SYDESC.
        /// </summary>
        public const string SYDESC = "SYDESC";

        /// <summary>
        /// SYINMG.
        /// </summary>
        public const string SYINMG = "SYINMG";

        /// <summary>
        /// SYASN.
        /// </summary>
        public const string SYASN = "SYASN";

        /// <summary>
        /// SYPRGP.
        /// </summary>
        public const string SYPRGP = "SYPRGP";

        /// <summary>
        /// SYPTC.
        /// </summary>
        public const string SYPTC = "SYPTC";

        /// <summary>
        /// SYEXR1.
        /// </summary>
        public const string SYEXR1 = "SYEXR1";

        /// <summary>
        /// SYTXA1.
        /// </summary>
        public const string SYTXA1 = "SYTXA1";

        /// <summary>
        /// SYTXCT.
        /// </summary>
        public const string SYTXCT = "SYTXCT";

        /// <summary>
        /// SYATXT.
        /// </summary>
        public const string SYATXT = "SYATXT";

        /// <summary>
        /// SYHOLD.
        /// </summary>
        public const string SYHOLD = "SYHOLD";

        /// <summary>
        /// SYINVC.
        /// </summary>
        public const string SYINVC = "SYINVC";

        /// <summary>
        /// SYNTR.
        /// </summary>
        public const string SYNTR = "SYNTR";

        /// <summary>
        /// SYCNID.
        /// </summary>
        public const string SYCNID = "SYCNID";

        /// <summary>
        /// SYFRTH.
        /// </summary>
        public const string SYFRTH = "SYFRTH";

        /// <summary>
        /// SYZON.
        /// </summary>
        public const string SYZON = "SYZON";

        /// <summary>
        /// SYANBY.
        /// </summary>
        public const string SYANBY = "SYANBY";

        /// <summary>
        /// SYANCR.
        /// </summary>
        public const string SYANCR = "SYANCR";

        /// <summary>
        /// SYMOT.
        /// </summary>
        public const string SYMOT = "SYMOT";

        /// <summary>
        /// SYCOT.
        /// </summary>
        public const string SYCOT = "SYCOT";

        /// <summary>
        /// SYRCD.
        /// </summary>
        public const string SYRCD = "SYRCD";

        /// <summary>
        /// SYFRTC.
        /// </summary>
        public const string SYFRTC = "SYFRTC";

        /// <summary>
        /// SYFUF1.
        /// </summary>
        public const string SYFUF1 = "SYFUF1";

        /// <summary>
        /// SYFUF2.
        /// </summary>
        public const string SYFUF2 = "SYFUF2";

        /// <summary>
        /// SYOTOT.
        /// </summary>
        public const string SYOTOT = "SYOTOT";

        /// <summary>
        /// SYPCRT.
        /// </summary>
        public const string SYPCRT = "SYPCRT";

        /// <summary>
        /// SYRTNR.
        /// </summary>
        public const string SYRTNR = "SYRTNR";

        /// <summary>
        /// SYWUMD.
        /// </summary>
        public const string SYWUMD = "SYWUMD";

        /// <summary>
        /// SYVUMD.
        /// </summary>
        public const string SYVUMD = "SYVUMD";

        /// <summary>
        /// SYPURG.
        /// </summary>
        public const string SYPURG = "SYPURG";

        /// <summary>
        /// SYLGCT.
        /// </summary>
        public const string SYLGCT = "SYLGCT";

        /// <summary>
        /// SYPROM.
        /// </summary>
        public const string SYPROM = "SYPROM";

        /// <summary>
        /// SYMATY.
        /// </summary>
        public const string SYMATY = "SYMATY";

        /// <summary>
        /// SYOSTS.
        /// </summary>
        public const string SYOSTS = "SYOSTS";

        /// <summary>
        /// SYAVCH.
        /// </summary>
        public const string SYAVCH = "SYAVCH";

        /// <summary>
        /// SYPRPY.
        /// </summary>
        public const string SYPRPY = "SYPRPY";

        /// <summary>
        /// SYCRMD.
        /// </summary>
        public const string SYCRMD = "SYCRMD";

        /// <summary>
        /// SYPRP5.
        /// </summary>
        public const string SYPRP5 = "SYPRP5";

        /// <summary>
        /// SYARTG.
        /// </summary>
        public const string SYARTG = "SYARTG";

        /// <summary>
        /// SYCORD.
        /// </summary>
        public const string SYCORD = "SYCORD";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRR.
        /// </summary>
        public const string SYCRR = "SYCRR";

        /// <summary>
        /// SYLNGP.
        /// </summary>
        public const string SYLNGP = "SYLNGP";

        /// <summary>
        /// SYFAP.
        /// </summary>
        public const string SYFAP = "SYFAP";

        /// <summary>
        /// SYORBY.
        /// </summary>
        public const string SYORBY = "SYORBY";

        /// <summary>
        /// SYTKBY.
        /// </summary>
        public const string SYTKBY = "SYTKBY";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYRSHT.
        /// </summary>
        public const string SYRSHT = "SYRSHT";

        /// <summary>
        /// SYPXDM.
        /// </summary>
        public const string SYPXDM = "SYPXDM";

        /// <summary>
        /// SYPXDD.
        /// </summary>
        public const string SYPXDD = "SYPXDD";

        /// <summary>
        /// SYNDTP.
        /// </summary>
        public const string SYNDTP = "SYNDTP";

        /// <summary>
        /// SYDRQT.
        /// </summary>
        public const string SYDRQT = "SYDRQT";

        /// <summary>
        /// SYDCP.
        /// </summary>
        public const string SYDCP = "SYDCP";

        /// <summary>
        /// SYDCD.
        /// </summary>
        public const string SYDCD = "SYDCD";

        /// <summary>
        /// SYBTAN.
        /// </summary>
        public const string SYBTAN = "SYBTAN";

        /// <summary>
        /// SYBCRC.
        /// </summary>
        public const string SYBCRC = "SYBCRC";

        /// <summary>
        /// SYACKT.
        /// </summary>
        public const string SYACKT = "SYACKT";

        /// <summary>
        /// SYVR03.
        /// </summary>
        public const string SYVR03 = "SYVR03";

        /// <summary>
        /// SYMKFR.
        /// </summary>
        public const string SYMKFR = "SYMKFR";

        /// <summary>
        /// SYPOHP01.
        /// </summary>
        public const string SYPOHP01 = "SYPOHP01";

        /// <summary>
        /// SYPOHP02.
        /// </summary>
        public const string SYPOHP02 = "SYPOHP02";

        /// <summary>
        /// SYPOHP03.
        /// </summary>
        public const string SYPOHP03 = "SYPOHP03";

        /// <summary>
        /// SYPOHP04.
        /// </summary>
        public const string SYPOHP04 = "SYPOHP04";

        /// <summary>
        /// SYPOHP05.
        /// </summary>
        public const string SYPOHP05 = "SYPOHP05";

        /// <summary>
        /// SYPOHP06.
        /// </summary>
        public const string SYPOHP06 = "SYPOHP06";

        /// <summary>
        /// SYPOHP07.
        /// </summary>
        public const string SYPOHP07 = "SYPOHP07";

        /// <summary>
        /// SYPOHP08.
        /// </summary>
        public const string SYPOHP08 = "SYPOHP08";

        /// <summary>
        /// SYPOHP09.
        /// </summary>
        public const string SYPOHP09 = "SYPOHP09";

        /// <summary>
        /// SYPOHP10.
        /// </summary>
        public const string SYPOHP10 = "SYPOHP10";

        /// <summary>
        /// SYPOHP11.
        /// </summary>
        public const string SYPOHP11 = "SYPOHP11";

        /// <summary>
        /// SYPOHP12.
        /// </summary>
        public const string SYPOHP12 = "SYPOHP12";

        /// <summary>
        /// SYPOHC01.
        /// </summary>
        public const string SYPOHC01 = "SYPOHC01";

        /// <summary>
        /// SYPOHC02.
        /// </summary>
        public const string SYPOHC02 = "SYPOHC02";

        /// <summary>
        /// SYPOHC03.
        /// </summary>
        public const string SYPOHC03 = "SYPOHC03";

        /// <summary>
        /// SYPOHC04.
        /// </summary>
        public const string SYPOHC04 = "SYPOHC04";

        /// <summary>
        /// SYPOHC05.
        /// </summary>
        public const string SYPOHC05 = "SYPOHC05";

        /// <summary>
        /// SYPOHC06.
        /// </summary>
        public const string SYPOHC06 = "SYPOHC06";

        /// <summary>
        /// SYPOHC07.
        /// </summary>
        public const string SYPOHC07 = "SYPOHC07";

        /// <summary>
        /// SYPOHC08.
        /// </summary>
        public const string SYPOHC08 = "SYPOHC08";

        /// <summary>
        /// SYPOHC09.
        /// </summary>
        public const string SYPOHC09 = "SYPOHC09";

        /// <summary>
        /// SYPOHC10.
        /// </summary>
        public const string SYPOHC10 = "SYPOHC10";

        /// <summary>
        /// SYPOHC11.
        /// </summary>
        public const string SYPOHC11 = "SYPOHC11";

        /// <summary>
        /// SYPOHC12.
        /// </summary>
        public const string SYPOHC12 = "SYPOHC12";

        /// <summary>
        /// SYPOHD01.
        /// </summary>
        public const string SYPOHD01 = "SYPOHD01";

        /// <summary>
        /// SYPOHD02.
        /// </summary>
        public const string SYPOHD02 = "SYPOHD02";

        /// <summary>
        /// SYPOHAB01.
        /// </summary>
        public const string SYPOHAB01 = "SYPOHAB01";

        /// <summary>
        /// SYPOHAB02.
        /// </summary>
        public const string SYPOHAB02 = "SYPOHAB02";

        /// <summary>
        /// SYPOHP13.
        /// </summary>
        public const string SYPOHP13 = "SYPOHP13";

        /// <summary>
        /// SYPOHU01.
        /// </summary>
        public const string SYPOHU01 = "SYPOHU01";

        /// <summary>
        /// SYPOHU02.
        /// </summary>
        public const string SYPOHU02 = "SYPOHU02";

        /// <summary>
        /// SYRETI.
        /// </summary>
        public const string SYRETI = "SYRETI";

        /// <summary>
        /// SYCLASS01.
        /// </summary>
        public const string SYCLASS01 = "SYCLASS01";

        /// <summary>
        /// SYCLASS02.
        /// </summary>
        public const string SYCLASS02 = "SYCLASS02";

        /// <summary>
        /// SYCLASS03.
        /// </summary>
        public const string SYCLASS03 = "SYCLASS03";

        /// <summary>
        /// SYCLASS04.
        /// </summary>
        public const string SYCLASS04 = "SYCLASS04";

        /// <summary>
        /// SYCLASS05.
        /// </summary>
        public const string SYCLASS05 = "SYCLASS05";

        /// <summary>
        /// SYGAN8.
        /// </summary>
        public const string SYGAN8 = "SYGAN8";

        /// <summary>
        /// SYGSHAN.
        /// </summary>
        public const string SYGSHAN = "SYGSHAN";

        /// <summary>
        /// SYGCARS.
        /// </summary>
        public const string SYGCARS = "SYGCARS";

        /// <summary>
        /// SYGMKFR.
        /// </summary>
        public const string SYGMKFR = "SYGMKFR";
    }

    /// <inheritdoc />
    public override string TableName => "F47016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDTY", "SYEDTY", JdeDataType.String, 2),
        new JdeField("SYEDSQ", "SYEDSQ", JdeDataType.Numeric),
        new JdeField("SYEKCO", "SYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SYEDOC", "SYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric),
        new JdeField("SYEDST", "SYEDST", JdeDataType.String, 12),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYEDER", "SYEDER", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTPUR", "SYTPUR", JdeDataType.String, 4),
        new JdeField("SYKCOO", "SYKCOO", JdeDataType.String, 10),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYSFXO", "SYSFXO", JdeDataType.String, 6),
        new JdeField("SYMCU", "SYMCU", JdeDataType.String, 24),
        new JdeField("SYOKCO", "SYOKCO", JdeDataType.String, 10),
        new JdeField("SYOORN", "SYOORN", JdeDataType.String, 16),
        new JdeField("SYOCTO", "SYOCTO", JdeDataType.String, 4),
        new JdeField("SYRKCO", "SYRKCO", JdeDataType.String, 10),
        new JdeField("SYRORN", "SYRORN", JdeDataType.String, 16),
        new JdeField("SYRCTO", "SYRCTO", JdeDataType.String, 4),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYSHAN", "SYSHAN", JdeDataType.Numeric),
        new JdeField("SYDRQJ", "SYDRQJ", JdeDataType.Numeric),
        new JdeField("SYTRDJ", "SYTRDJ", JdeDataType.Numeric),
        new JdeField("SYPDDJ", "SYPDDJ", JdeDataType.Numeric),
        new JdeField("SYOPDJ", "SYOPDJ", JdeDataType.Numeric),
        new JdeField("SYADDJ", "SYADDJ", JdeDataType.Numeric),
        new JdeField("SYCNDJ", "SYCNDJ", JdeDataType.Numeric),
        new JdeField("SYPEFJ", "SYPEFJ", JdeDataType.Numeric),
        new JdeField("SYPPDJ", "SYPPDJ", JdeDataType.Numeric),
        new JdeField("SYPSDJ", "SYPSDJ", JdeDataType.Numeric),
        new JdeField("SYVR01", "SYVR01", JdeDataType.String, 50),
        new JdeField("SYVR02", "SYVR02", JdeDataType.String, 50),
        new JdeField("SYDEL1", "SYDEL1", JdeDataType.String, 60),
        new JdeField("SYDEL2", "SYDEL2", JdeDataType.String, 60),
        new JdeField("SYRMK", "SYRMK", JdeDataType.String, 60),
        new JdeField("SYDESC", "SYDESC", JdeDataType.String, 60),
        new JdeField("SYINMG", "SYINMG", JdeDataType.String, 20),
        new JdeField("SYASN", "SYASN", JdeDataType.String, 16),
        new JdeField("SYPRGP", "SYPRGP", JdeDataType.String, 16),
        new JdeField("SYPTC", "SYPTC", JdeDataType.String, 6),
        new JdeField("SYEXR1", "SYEXR1", JdeDataType.String, 4),
        new JdeField("SYTXA1", "SYTXA1", JdeDataType.String, 20),
        new JdeField("SYTXCT", "SYTXCT", JdeDataType.String, 40),
        new JdeField("SYATXT", "SYATXT", JdeDataType.String, 2),
        new JdeField("SYHOLD", "SYHOLD", JdeDataType.String, 4),
        new JdeField("SYINVC", "SYINVC", JdeDataType.Numeric),
        new JdeField("SYNTR", "SYNTR", JdeDataType.String, 4),
        new JdeField("SYCNID", "SYCNID", JdeDataType.String, 40),
        new JdeField("SYFRTH", "SYFRTH", JdeDataType.String, 6),
        new JdeField("SYZON", "SYZON", JdeDataType.String, 6),
        new JdeField("SYANBY", "SYANBY", JdeDataType.Numeric),
        new JdeField("SYANCR", "SYANCR", JdeDataType.Numeric),
        new JdeField("SYMOT", "SYMOT", JdeDataType.String, 6),
        new JdeField("SYCOT", "SYCOT", JdeDataType.String, 6),
        new JdeField("SYRCD", "SYRCD", JdeDataType.String, 6),
        new JdeField("SYFRTC", "SYFRTC", JdeDataType.String, 2),
        new JdeField("SYFUF1", "SYFUF1", JdeDataType.String, 2),
        new JdeField("SYFUF2", "SYFUF2", JdeDataType.String, 2),
        new JdeField("SYOTOT", "SYOTOT", JdeDataType.Numeric),
        new JdeField("SYPCRT", "SYPCRT", JdeDataType.Numeric),
        new JdeField("SYRTNR", "SYRTNR", JdeDataType.String, 6),
        new JdeField("SYWUMD", "SYWUMD", JdeDataType.String, 4),
        new JdeField("SYVUMD", "SYVUMD", JdeDataType.String, 4),
        new JdeField("SYPURG", "SYPURG", JdeDataType.String, 2),
        new JdeField("SYLGCT", "SYLGCT", JdeDataType.String, 2),
        new JdeField("SYPROM", "SYPROM", JdeDataType.String, 2),
        new JdeField("SYMATY", "SYMATY", JdeDataType.String, 2),
        new JdeField("SYOSTS", "SYOSTS", JdeDataType.String, 2),
        new JdeField("SYAVCH", "SYAVCH", JdeDataType.String, 2),
        new JdeField("SYPRPY", "SYPRPY", JdeDataType.String, 2),
        new JdeField("SYCRMD", "SYCRMD", JdeDataType.String, 2),
        new JdeField("SYPRP5", "SYPRP5", JdeDataType.String, 6),
        new JdeField("SYARTG", "SYARTG", JdeDataType.String, 24),
        new JdeField("SYCORD", "SYCORD", JdeDataType.Numeric),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRR", "SYCRR", JdeDataType.Numeric),
        new JdeField("SYLNGP", "SYLNGP", JdeDataType.String, 4),
        new JdeField("SYFAP", "SYFAP", JdeDataType.Numeric),
        new JdeField("SYORBY", "SYORBY", JdeDataType.String, 20),
        new JdeField("SYTKBY", "SYTKBY", JdeDataType.String, 20),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYRSHT", "SYRSHT", JdeDataType.Numeric),
        new JdeField("SYPXDM", "SYPXDM", JdeDataType.Numeric),
        new JdeField("SYPXDD", "SYPXDD", JdeDataType.Numeric),
        new JdeField("SYNDTP", "SYNDTP", JdeDataType.Numeric),
        new JdeField("SYDRQT", "SYDRQT", JdeDataType.Numeric),
        new JdeField("SYDCP", "SYDCP", JdeDataType.Numeric),
        new JdeField("SYDCD", "SYDCD", JdeDataType.Numeric),
        new JdeField("SYBTAN", "SYBTAN", JdeDataType.Numeric),
        new JdeField("SYBCRC", "SYBCRC", JdeDataType.String, 6),
        new JdeField("SYACKT", "SYACKT", JdeDataType.String, 4),
        new JdeField("SYVR03", "SYVR03", JdeDataType.String, 50),
        new JdeField("SYMKFR", "SYMKFR", JdeDataType.Numeric),
        new JdeField("SYPOHP01", "SYPOHP01", JdeDataType.String, 2),
        new JdeField("SYPOHP02", "SYPOHP02", JdeDataType.String, 2),
        new JdeField("SYPOHP03", "SYPOHP03", JdeDataType.String, 2),
        new JdeField("SYPOHP04", "SYPOHP04", JdeDataType.String, 2),
        new JdeField("SYPOHP05", "SYPOHP05", JdeDataType.String, 2),
        new JdeField("SYPOHP06", "SYPOHP06", JdeDataType.String, 2),
        new JdeField("SYPOHP07", "SYPOHP07", JdeDataType.String, 2),
        new JdeField("SYPOHP08", "SYPOHP08", JdeDataType.String, 2),
        new JdeField("SYPOHP09", "SYPOHP09", JdeDataType.String, 2),
        new JdeField("SYPOHP10", "SYPOHP10", JdeDataType.String, 2),
        new JdeField("SYPOHP11", "SYPOHP11", JdeDataType.String, 2),
        new JdeField("SYPOHP12", "SYPOHP12", JdeDataType.String, 2),
        new JdeField("SYPOHC01", "SYPOHC01", JdeDataType.String, 6),
        new JdeField("SYPOHC02", "SYPOHC02", JdeDataType.String, 6),
        new JdeField("SYPOHC03", "SYPOHC03", JdeDataType.String, 6),
        new JdeField("SYPOHC04", "SYPOHC04", JdeDataType.String, 6),
        new JdeField("SYPOHC05", "SYPOHC05", JdeDataType.String, 6),
        new JdeField("SYPOHC06", "SYPOHC06", JdeDataType.String, 6),
        new JdeField("SYPOHC07", "SYPOHC07", JdeDataType.String, 20),
        new JdeField("SYPOHC08", "SYPOHC08", JdeDataType.String, 20),
        new JdeField("SYPOHC09", "SYPOHC09", JdeDataType.String, 20),
        new JdeField("SYPOHC10", "SYPOHC10", JdeDataType.String, 20),
        new JdeField("SYPOHC11", "SYPOHC11", JdeDataType.String, 20),
        new JdeField("SYPOHC12", "SYPOHC12", JdeDataType.String, 20),
        new JdeField("SYPOHD01", "SYPOHD01", JdeDataType.Numeric),
        new JdeField("SYPOHD02", "SYPOHD02", JdeDataType.Numeric),
        new JdeField("SYPOHAB01", "SYPOHAB01", JdeDataType.Numeric),
        new JdeField("SYPOHAB02", "SYPOHAB02", JdeDataType.Numeric),
        new JdeField("SYPOHP13", "SYPOHP13", JdeDataType.String, 60),
        new JdeField("SYPOHU01", "SYPOHU01", JdeDataType.Date),
        new JdeField("SYPOHU02", "SYPOHU02", JdeDataType.Date),
        new JdeField("SYRETI", "SYRETI", JdeDataType.String, 2),
        new JdeField("SYCLASS01", "SYCLASS01", JdeDataType.String, 6),
        new JdeField("SYCLASS02", "SYCLASS02", JdeDataType.String, 6),
        new JdeField("SYCLASS03", "SYCLASS03", JdeDataType.String, 6),
        new JdeField("SYCLASS04", "SYCLASS04", JdeDataType.String, 6),
        new JdeField("SYCLASS05", "SYCLASS05", JdeDataType.String, 6),
        new JdeField("SYGAN8", "SYGAN8", JdeDataType.Numeric),
        new JdeField("SYGSHAN", "SYGSHAN", JdeDataType.Numeric),
        new JdeField("SYGCARS", "SYGCARS", JdeDataType.Numeric),
        new JdeField("SYGMKFR", "SYGMKFR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47016_0", "Primary Key on SYEDOC, SYEDCT, SYEKCO", new[] { "SYEDOC", "SYEDCT", "SYEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
