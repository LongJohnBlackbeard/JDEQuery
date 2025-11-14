using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4301Z - .
/// </summary>
public class F4301Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PACTID.
        /// </summary>
        public const string PACTID = "PACTID";

        /// <summary>
        /// PAJOBS.
        /// </summary>
        public const string PAJOBS = "PAJOBS";

        /// <summary>
        /// PAACTN.
        /// </summary>
        public const string PAACTN = "PAACTN";

        /// <summary>
        /// PAEDFL.
        /// </summary>
        public const string PAEDFL = "PAEDFL";

        /// <summary>
        /// PAKCOO.
        /// </summary>
        public const string PAKCOO = "PAKCOO";

        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PADCTO.
        /// </summary>
        public const string PADCTO = "PADCTO";

        /// <summary>
        /// PASFXO.
        /// </summary>
        public const string PASFXO = "PASFXO";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PAOKCO.
        /// </summary>
        public const string PAOKCO = "PAOKCO";

        /// <summary>
        /// PAOORN.
        /// </summary>
        public const string PAOORN = "PAOORN";

        /// <summary>
        /// PAOCTO.
        /// </summary>
        public const string PAOCTO = "PAOCTO";

        /// <summary>
        /// PARKCO.
        /// </summary>
        public const string PARKCO = "PARKCO";

        /// <summary>
        /// PARORN.
        /// </summary>
        public const string PARORN = "PARORN";

        /// <summary>
        /// PARCTO.
        /// </summary>
        public const string PARCTO = "PARCTO";

        /// <summary>
        /// PAAN8.
        /// </summary>
        public const string PAAN8 = "PAAN8";

        /// <summary>
        /// PASHAN.
        /// </summary>
        public const string PASHAN = "PASHAN";

        /// <summary>
        /// PADRQJ.
        /// </summary>
        public const string PADRQJ = "PADRQJ";

        /// <summary>
        /// PATRDJ.
        /// </summary>
        public const string PATRDJ = "PATRDJ";

        /// <summary>
        /// PAPDDJ.
        /// </summary>
        public const string PAPDDJ = "PAPDDJ";

        /// <summary>
        /// PAOPDJ.
        /// </summary>
        public const string PAOPDJ = "PAOPDJ";

        /// <summary>
        /// PAADDJ.
        /// </summary>
        public const string PAADDJ = "PAADDJ";

        /// <summary>
        /// PACNDJ.
        /// </summary>
        public const string PACNDJ = "PACNDJ";

        /// <summary>
        /// PAPEFJ.
        /// </summary>
        public const string PAPEFJ = "PAPEFJ";

        /// <summary>
        /// PAPPDJ.
        /// </summary>
        public const string PAPPDJ = "PAPPDJ";

        /// <summary>
        /// PAPSDJ.
        /// </summary>
        public const string PAPSDJ = "PAPSDJ";

        /// <summary>
        /// PAVR01.
        /// </summary>
        public const string PAVR01 = "PAVR01";

        /// <summary>
        /// PAVR02.
        /// </summary>
        public const string PAVR02 = "PAVR02";

        /// <summary>
        /// PADEL1.
        /// </summary>
        public const string PADEL1 = "PADEL1";

        /// <summary>
        /// PADEL2.
        /// </summary>
        public const string PADEL2 = "PADEL2";

        /// <summary>
        /// PARMK.
        /// </summary>
        public const string PARMK = "PARMK";

        /// <summary>
        /// PADESC.
        /// </summary>
        public const string PADESC = "PADESC";

        /// <summary>
        /// PAINMG.
        /// </summary>
        public const string PAINMG = "PAINMG";

        /// <summary>
        /// PAASN.
        /// </summary>
        public const string PAASN = "PAASN";

        /// <summary>
        /// PAPRGP.
        /// </summary>
        public const string PAPRGP = "PAPRGP";

        /// <summary>
        /// PAPTC.
        /// </summary>
        public const string PAPTC = "PAPTC";

        /// <summary>
        /// PAEXR1.
        /// </summary>
        public const string PAEXR1 = "PAEXR1";

        /// <summary>
        /// PATXA1.
        /// </summary>
        public const string PATXA1 = "PATXA1";

        /// <summary>
        /// PATXCT.
        /// </summary>
        public const string PATXCT = "PATXCT";

        /// <summary>
        /// PAHOLD.
        /// </summary>
        public const string PAHOLD = "PAHOLD";

        /// <summary>
        /// PAATXT.
        /// </summary>
        public const string PAATXT = "PAATXT";

        /// <summary>
        /// PAINVC.
        /// </summary>
        public const string PAINVC = "PAINVC";

        /// <summary>
        /// PANTR.
        /// </summary>
        public const string PANTR = "PANTR";

        /// <summary>
        /// PACNID.
        /// </summary>
        public const string PACNID = "PACNID";

        /// <summary>
        /// PAFRTH.
        /// </summary>
        public const string PAFRTH = "PAFRTH";

        /// <summary>
        /// PAZON.
        /// </summary>
        public const string PAZON = "PAZON";

        /// <summary>
        /// PAANBY.
        /// </summary>
        public const string PAANBY = "PAANBY";

        /// <summary>
        /// PAANCR.
        /// </summary>
        public const string PAANCR = "PAANCR";

        /// <summary>
        /// PAMOT.
        /// </summary>
        public const string PAMOT = "PAMOT";

        /// <summary>
        /// PACOT.
        /// </summary>
        public const string PACOT = "PACOT";

        /// <summary>
        /// PARCD.
        /// </summary>
        public const string PARCD = "PARCD";

        /// <summary>
        /// PAFRTC.
        /// </summary>
        public const string PAFRTC = "PAFRTC";

        /// <summary>
        /// PAFUF1.
        /// </summary>
        public const string PAFUF1 = "PAFUF1";

        /// <summary>
        /// PAFUF2.
        /// </summary>
        public const string PAFUF2 = "PAFUF2";

        /// <summary>
        /// PAOTOT.
        /// </summary>
        public const string PAOTOT = "PAOTOT";

        /// <summary>
        /// PAPCRT.
        /// </summary>
        public const string PAPCRT = "PAPCRT";

        /// <summary>
        /// PARTNR.
        /// </summary>
        public const string PARTNR = "PARTNR";

        /// <summary>
        /// PAWUMD.
        /// </summary>
        public const string PAWUMD = "PAWUMD";

        /// <summary>
        /// PAVUMD.
        /// </summary>
        public const string PAVUMD = "PAVUMD";

        /// <summary>
        /// PAPURG.
        /// </summary>
        public const string PAPURG = "PAPURG";

        /// <summary>
        /// PALGCT.
        /// </summary>
        public const string PALGCT = "PALGCT";

        /// <summary>
        /// PAPROM.
        /// </summary>
        public const string PAPROM = "PAPROM";

        /// <summary>
        /// PAMATY.
        /// </summary>
        public const string PAMATY = "PAMATY";

        /// <summary>
        /// PAOSTS.
        /// </summary>
        public const string PAOSTS = "PAOSTS";

        /// <summary>
        /// PAAVCH.
        /// </summary>
        public const string PAAVCH = "PAAVCH";

        /// <summary>
        /// PAPRPY.
        /// </summary>
        public const string PAPRPY = "PAPRPY";

        /// <summary>
        /// PACRMD.
        /// </summary>
        public const string PACRMD = "PACRMD";

        /// <summary>
        /// PAPRP5.
        /// </summary>
        public const string PAPRP5 = "PAPRP5";

        /// <summary>
        /// PAARTG.
        /// </summary>
        public const string PAARTG = "PAARTG";

        /// <summary>
        /// PACORD.
        /// </summary>
        public const string PACORD = "PACORD";

        /// <summary>
        /// PACRRM.
        /// </summary>
        public const string PACRRM = "PACRRM";

        /// <summary>
        /// PACRCD.
        /// </summary>
        public const string PACRCD = "PACRCD";

        /// <summary>
        /// PACRR.
        /// </summary>
        public const string PACRR = "PACRR";

        /// <summary>
        /// PALNGP.
        /// </summary>
        public const string PALNGP = "PALNGP";

        /// <summary>
        /// PAFAP.
        /// </summary>
        public const string PAFAP = "PAFAP";

        /// <summary>
        /// PAORBY.
        /// </summary>
        public const string PAORBY = "PAORBY";

        /// <summary>
        /// PATKBY.
        /// </summary>
        public const string PATKBY = "PATKBY";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PATDAY.
        /// </summary>
        public const string PATDAY = "PATDAY";

        /// <summary>
        /// PACRDC.
        /// </summary>
        public const string PACRDC = "PACRDC";

        /// <summary>
        /// PAORNN.
        /// </summary>
        public const string PAORNN = "PAORNN";

        /// <summary>
        /// PABUMC.
        /// </summary>
        public const string PABUMC = "PABUMC";

        /// <summary>
        /// PACP06.
        /// </summary>
        public const string PACP06 = "PACP06";

        /// <summary>
        /// PAEDF2.
        /// </summary>
        public const string PAEDF2 = "PAEDF2";

        /// <summary>
        /// PAMINO.
        /// </summary>
        public const string PAMINO = "PAMINO";

        /// <summary>
        /// PAMAXO.
        /// </summary>
        public const string PAMAXO = "PAMAXO";

        /// <summary>
        /// PALNID.
        /// </summary>
        public const string PALNID = "PALNID";

        /// <summary>
        /// PACRCM.
        /// </summary>
        public const string PACRCM = "PACRCM";

        /// <summary>
        /// PATRR1.
        /// </summary>
        public const string PATRR1 = "PATRR1";

        /// <summary>
        /// PATRR2.
        /// </summary>
        public const string PATRR2 = "PATRR2";

        /// <summary>
        /// PAVVTX.
        /// </summary>
        public const string PAVVTX = "PAVVTX";

        /// <summary>
        /// PAPEID.
        /// </summary>
        public const string PAPEID = "PAPEID";

        /// <summary>
        /// PATCID.
        /// </summary>
        public const string PATCID = "PATCID";

        /// <summary>
        /// PADOC1.
        /// </summary>
        public const string PADOC1 = "PADOC1";

        /// <summary>
        /// PADCT4.
        /// </summary>
        public const string PADCT4 = "PADCT4";

        /// <summary>
        /// PAATVF.
        /// </summary>
        public const string PAATVF = "PAATVF";

        /// <summary>
        /// PAPOHP01.
        /// </summary>
        public const string PAPOHP01 = "PAPOHP01";

        /// <summary>
        /// PAPOHP02.
        /// </summary>
        public const string PAPOHP02 = "PAPOHP02";

        /// <summary>
        /// PAPOHP03.
        /// </summary>
        public const string PAPOHP03 = "PAPOHP03";

        /// <summary>
        /// PAPOHP04.
        /// </summary>
        public const string PAPOHP04 = "PAPOHP04";

        /// <summary>
        /// PAPOHP05.
        /// </summary>
        public const string PAPOHP05 = "PAPOHP05";

        /// <summary>
        /// PAPOHP06.
        /// </summary>
        public const string PAPOHP06 = "PAPOHP06";

        /// <summary>
        /// PAPOHP07.
        /// </summary>
        public const string PAPOHP07 = "PAPOHP07";

        /// <summary>
        /// PAPOHP08.
        /// </summary>
        public const string PAPOHP08 = "PAPOHP08";

        /// <summary>
        /// PAPOHP09.
        /// </summary>
        public const string PAPOHP09 = "PAPOHP09";

        /// <summary>
        /// PAPOHP10.
        /// </summary>
        public const string PAPOHP10 = "PAPOHP10";

        /// <summary>
        /// PAPOHP11.
        /// </summary>
        public const string PAPOHP11 = "PAPOHP11";

        /// <summary>
        /// PAPOHP12.
        /// </summary>
        public const string PAPOHP12 = "PAPOHP12";

        /// <summary>
        /// PAPOHC01.
        /// </summary>
        public const string PAPOHC01 = "PAPOHC01";

        /// <summary>
        /// PAPOHC02.
        /// </summary>
        public const string PAPOHC02 = "PAPOHC02";

        /// <summary>
        /// PAPOHC03.
        /// </summary>
        public const string PAPOHC03 = "PAPOHC03";

        /// <summary>
        /// PAPOHC04.
        /// </summary>
        public const string PAPOHC04 = "PAPOHC04";

        /// <summary>
        /// PAPOHC05.
        /// </summary>
        public const string PAPOHC05 = "PAPOHC05";

        /// <summary>
        /// PAPOHC06.
        /// </summary>
        public const string PAPOHC06 = "PAPOHC06";

        /// <summary>
        /// PAPOHC07.
        /// </summary>
        public const string PAPOHC07 = "PAPOHC07";

        /// <summary>
        /// PAPOHC08.
        /// </summary>
        public const string PAPOHC08 = "PAPOHC08";

        /// <summary>
        /// PAPOHC09.
        /// </summary>
        public const string PAPOHC09 = "PAPOHC09";

        /// <summary>
        /// PAPOHC10.
        /// </summary>
        public const string PAPOHC10 = "PAPOHC10";

        /// <summary>
        /// PAPOHC11.
        /// </summary>
        public const string PAPOHC11 = "PAPOHC11";

        /// <summary>
        /// PAPOHC12.
        /// </summary>
        public const string PAPOHC12 = "PAPOHC12";

        /// <summary>
        /// PAPOHD01.
        /// </summary>
        public const string PAPOHD01 = "PAPOHD01";

        /// <summary>
        /// PAPOHD02.
        /// </summary>
        public const string PAPOHD02 = "PAPOHD02";

        /// <summary>
        /// PAPOHAB01.
        /// </summary>
        public const string PAPOHAB01 = "PAPOHAB01";

        /// <summary>
        /// PAPOHAB02.
        /// </summary>
        public const string PAPOHAB02 = "PAPOHAB02";

        /// <summary>
        /// PACUKID.
        /// </summary>
        public const string PACUKID = "PACUKID";

        /// <summary>
        /// PAPOHP13.
        /// </summary>
        public const string PAPOHP13 = "PAPOHP13";

        /// <summary>
        /// PAPOHU01.
        /// </summary>
        public const string PAPOHU01 = "PAPOHU01";

        /// <summary>
        /// PAPOHU02.
        /// </summary>
        public const string PAPOHU02 = "PAPOHU02";

        /// <summary>
        /// PARETI.
        /// </summary>
        public const string PARETI = "PARETI";

        /// <summary>
        /// PACLASS01.
        /// </summary>
        public const string PACLASS01 = "PACLASS01";

        /// <summary>
        /// PACLASS02.
        /// </summary>
        public const string PACLASS02 = "PACLASS02";

        /// <summary>
        /// PACLASS03.
        /// </summary>
        public const string PACLASS03 = "PACLASS03";

        /// <summary>
        /// PACLASS04.
        /// </summary>
        public const string PACLASS04 = "PACLASS04";

        /// <summary>
        /// PACLASS05.
        /// </summary>
        public const string PACLASS05 = "PACLASS05";
    }

    /// <inheritdoc />
    public override string TableName => "F4301Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PACTID", "PACTID", JdeDataType.String, 30, true, true),
        new JdeField("PAJOBS", "PAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PAACTN", "PAACTN", JdeDataType.String, 2),
        new JdeField("PAEDFL", "PAEDFL", JdeDataType.String, 2),
        new JdeField("PAKCOO", "PAKCOO", JdeDataType.String, 10),
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric),
        new JdeField("PADCTO", "PADCTO", JdeDataType.String, 4),
        new JdeField("PASFXO", "PASFXO", JdeDataType.String, 6, true, true),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24),
        new JdeField("PAOKCO", "PAOKCO", JdeDataType.String, 10),
        new JdeField("PAOORN", "PAOORN", JdeDataType.String, 16),
        new JdeField("PAOCTO", "PAOCTO", JdeDataType.String, 4),
        new JdeField("PARKCO", "PARKCO", JdeDataType.String, 10),
        new JdeField("PARORN", "PARORN", JdeDataType.String, 16),
        new JdeField("PARCTO", "PARCTO", JdeDataType.String, 4),
        new JdeField("PAAN8", "PAAN8", JdeDataType.Numeric),
        new JdeField("PASHAN", "PASHAN", JdeDataType.Numeric),
        new JdeField("PADRQJ", "PADRQJ", JdeDataType.Numeric),
        new JdeField("PATRDJ", "PATRDJ", JdeDataType.Numeric),
        new JdeField("PAPDDJ", "PAPDDJ", JdeDataType.Numeric),
        new JdeField("PAOPDJ", "PAOPDJ", JdeDataType.Numeric),
        new JdeField("PAADDJ", "PAADDJ", JdeDataType.Numeric),
        new JdeField("PACNDJ", "PACNDJ", JdeDataType.Numeric),
        new JdeField("PAPEFJ", "PAPEFJ", JdeDataType.Numeric),
        new JdeField("PAPPDJ", "PAPPDJ", JdeDataType.Numeric),
        new JdeField("PAPSDJ", "PAPSDJ", JdeDataType.Numeric),
        new JdeField("PAVR01", "PAVR01", JdeDataType.String, 50),
        new JdeField("PAVR02", "PAVR02", JdeDataType.String, 50),
        new JdeField("PADEL1", "PADEL1", JdeDataType.String, 60),
        new JdeField("PADEL2", "PADEL2", JdeDataType.String, 60),
        new JdeField("PARMK", "PARMK", JdeDataType.String, 60),
        new JdeField("PADESC", "PADESC", JdeDataType.String, 60),
        new JdeField("PAINMG", "PAINMG", JdeDataType.String, 20),
        new JdeField("PAASN", "PAASN", JdeDataType.String, 16),
        new JdeField("PAPRGP", "PAPRGP", JdeDataType.String, 16),
        new JdeField("PAPTC", "PAPTC", JdeDataType.String, 6),
        new JdeField("PAEXR1", "PAEXR1", JdeDataType.String, 4),
        new JdeField("PATXA1", "PATXA1", JdeDataType.String, 20),
        new JdeField("PATXCT", "PATXCT", JdeDataType.String, 40),
        new JdeField("PAHOLD", "PAHOLD", JdeDataType.String, 4),
        new JdeField("PAATXT", "PAATXT", JdeDataType.String, 2),
        new JdeField("PAINVC", "PAINVC", JdeDataType.Numeric),
        new JdeField("PANTR", "PANTR", JdeDataType.String, 4),
        new JdeField("PACNID", "PACNID", JdeDataType.String, 40),
        new JdeField("PAFRTH", "PAFRTH", JdeDataType.String, 6),
        new JdeField("PAZON", "PAZON", JdeDataType.String, 6),
        new JdeField("PAANBY", "PAANBY", JdeDataType.Numeric),
        new JdeField("PAANCR", "PAANCR", JdeDataType.Numeric),
        new JdeField("PAMOT", "PAMOT", JdeDataType.String, 6),
        new JdeField("PACOT", "PACOT", JdeDataType.String, 6),
        new JdeField("PARCD", "PARCD", JdeDataType.String, 6),
        new JdeField("PAFRTC", "PAFRTC", JdeDataType.String, 2),
        new JdeField("PAFUF1", "PAFUF1", JdeDataType.String, 2),
        new JdeField("PAFUF2", "PAFUF2", JdeDataType.String, 2),
        new JdeField("PAOTOT", "PAOTOT", JdeDataType.Numeric),
        new JdeField("PAPCRT", "PAPCRT", JdeDataType.Numeric),
        new JdeField("PARTNR", "PARTNR", JdeDataType.String, 6),
        new JdeField("PAWUMD", "PAWUMD", JdeDataType.String, 4),
        new JdeField("PAVUMD", "PAVUMD", JdeDataType.String, 4),
        new JdeField("PAPURG", "PAPURG", JdeDataType.String, 2),
        new JdeField("PALGCT", "PALGCT", JdeDataType.String, 2),
        new JdeField("PAPROM", "PAPROM", JdeDataType.String, 2),
        new JdeField("PAMATY", "PAMATY", JdeDataType.String, 2),
        new JdeField("PAOSTS", "PAOSTS", JdeDataType.String, 2),
        new JdeField("PAAVCH", "PAAVCH", JdeDataType.String, 2),
        new JdeField("PAPRPY", "PAPRPY", JdeDataType.String, 2),
        new JdeField("PACRMD", "PACRMD", JdeDataType.String, 2),
        new JdeField("PAPRP5", "PAPRP5", JdeDataType.String, 6),
        new JdeField("PAARTG", "PAARTG", JdeDataType.String, 24),
        new JdeField("PACORD", "PACORD", JdeDataType.Numeric),
        new JdeField("PACRRM", "PACRRM", JdeDataType.String, 2),
        new JdeField("PACRCD", "PACRCD", JdeDataType.String, 6),
        new JdeField("PACRR", "PACRR", JdeDataType.Numeric),
        new JdeField("PALNGP", "PALNGP", JdeDataType.String, 4),
        new JdeField("PAFAP", "PAFAP", JdeDataType.Numeric),
        new JdeField("PAORBY", "PAORBY", JdeDataType.String, 20),
        new JdeField("PATKBY", "PATKBY", JdeDataType.String, 20),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PATDAY", "PATDAY", JdeDataType.Numeric),
        new JdeField("PACRDC", "PACRDC", JdeDataType.String, 6),
        new JdeField("PAORNN", "PAORNN", JdeDataType.Numeric),
        new JdeField("PABUMC", "PABUMC", JdeDataType.String, 2),
        new JdeField("PACP06", "PACP06", JdeDataType.String, 2),
        new JdeField("PAEDF2", "PAEDF2", JdeDataType.String, 2),
        new JdeField("PAMINO", "PAMINO", JdeDataType.Numeric),
        new JdeField("PAMAXO", "PAMAXO", JdeDataType.Numeric),
        new JdeField("PALNID", "PALNID", JdeDataType.Numeric),
        new JdeField("PACRCM", "PACRCM", JdeDataType.String, 2),
        new JdeField("PATRR1", "PATRR1", JdeDataType.Numeric),
        new JdeField("PATRR2", "PATRR2", JdeDataType.Numeric),
        new JdeField("PAVVTX", "PAVVTX", JdeDataType.String, 2),
        new JdeField("PAPEID", "PAPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("PATCID", "PATCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PADOC1", "PADOC1", JdeDataType.Numeric),
        new JdeField("PADCT4", "PADCT4", JdeDataType.String, 4),
        new JdeField("PAATVF", "PAATVF", JdeDataType.String, 2),
        new JdeField("PAPOHP01", "PAPOHP01", JdeDataType.String, 2),
        new JdeField("PAPOHP02", "PAPOHP02", JdeDataType.String, 2),
        new JdeField("PAPOHP03", "PAPOHP03", JdeDataType.String, 2),
        new JdeField("PAPOHP04", "PAPOHP04", JdeDataType.String, 2),
        new JdeField("PAPOHP05", "PAPOHP05", JdeDataType.String, 2),
        new JdeField("PAPOHP06", "PAPOHP06", JdeDataType.String, 2),
        new JdeField("PAPOHP07", "PAPOHP07", JdeDataType.String, 2),
        new JdeField("PAPOHP08", "PAPOHP08", JdeDataType.String, 2),
        new JdeField("PAPOHP09", "PAPOHP09", JdeDataType.String, 2),
        new JdeField("PAPOHP10", "PAPOHP10", JdeDataType.String, 2),
        new JdeField("PAPOHP11", "PAPOHP11", JdeDataType.String, 2),
        new JdeField("PAPOHP12", "PAPOHP12", JdeDataType.String, 2),
        new JdeField("PAPOHC01", "PAPOHC01", JdeDataType.String, 6),
        new JdeField("PAPOHC02", "PAPOHC02", JdeDataType.String, 6),
        new JdeField("PAPOHC03", "PAPOHC03", JdeDataType.String, 6),
        new JdeField("PAPOHC04", "PAPOHC04", JdeDataType.String, 6),
        new JdeField("PAPOHC05", "PAPOHC05", JdeDataType.String, 6),
        new JdeField("PAPOHC06", "PAPOHC06", JdeDataType.String, 6),
        new JdeField("PAPOHC07", "PAPOHC07", JdeDataType.String, 20),
        new JdeField("PAPOHC08", "PAPOHC08", JdeDataType.String, 20),
        new JdeField("PAPOHC09", "PAPOHC09", JdeDataType.String, 20),
        new JdeField("PAPOHC10", "PAPOHC10", JdeDataType.String, 20),
        new JdeField("PAPOHC11", "PAPOHC11", JdeDataType.String, 20),
        new JdeField("PAPOHC12", "PAPOHC12", JdeDataType.String, 20),
        new JdeField("PAPOHD01", "PAPOHD01", JdeDataType.Numeric),
        new JdeField("PAPOHD02", "PAPOHD02", JdeDataType.Numeric),
        new JdeField("PAPOHAB01", "PAPOHAB01", JdeDataType.Numeric),
        new JdeField("PAPOHAB02", "PAPOHAB02", JdeDataType.Numeric),
        new JdeField("PACUKID", "PACUKID", JdeDataType.Numeric),
        new JdeField("PAPOHP13", "PAPOHP13", JdeDataType.String, 60),
        new JdeField("PAPOHU01", "PAPOHU01", JdeDataType.Date),
        new JdeField("PAPOHU02", "PAPOHU02", JdeDataType.Date),
        new JdeField("PARETI", "PARETI", JdeDataType.String, 2),
        new JdeField("PACLASS01", "PACLASS01", JdeDataType.String, 6),
        new JdeField("PACLASS02", "PACLASS02", JdeDataType.String, 6),
        new JdeField("PACLASS03", "PACLASS03", JdeDataType.String, 6),
        new JdeField("PACLASS04", "PACLASS04", JdeDataType.String, 6),
        new JdeField("PACLASS05", "PACLASS05", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4301Z_0", "Primary Key on PACTID, PAPEID, PATCID, PAJOBS, PASFXO", new[] { "PACTID", "PAPEID", "PATCID", "PAJOBS", "PASFXO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4301Z_1", "Unique Index on PACTID, PAJOBS, PASFXO", new[] { "PACTID", "PAJOBS", "PASFXO" }, isUnique: true),
        new JdeIndex("F4301Z_2", "Index on PACTID, PAAN8, PACRCD", new[] { "PACTID", "PAAN8", "PACRCD" }),
        new JdeIndex("F4301Z_4", "Index on PACTID, PAPEID, PATCID, PAAN8, PACRCD", new[] { "PACTID", "PAPEID", "PATCID", "PAAN8", "PACRCD" }),
        new JdeIndex("F4301Z_5", "Index on PACTID, PAPEID, PATCID, PAAN8, PACRCD, PADCTO", new[] { "PACTID", "PAPEID", "PATCID", "PAAN8", "PACRCD", "PADCTO" })
    };
}
