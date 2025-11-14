using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43UI50H - .
/// </summary>
public class F43UI50H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PASEQ.
        /// </summary>
        public const string PASEQ = "PASEQ";

        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PADCTO.
        /// </summary>
        public const string PADCTO = "PADCTO";

        /// <summary>
        /// PAKCOO.
        /// </summary>
        public const string PAKCOO = "PAKCOO";

        /// <summary>
        /// PASFXO.
        /// </summary>
        public const string PASFXO = "PASFXO";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PASHAN.
        /// </summary>
        public const string PASHAN = "PASHAN";

        /// <summary>
        /// PAAN8.
        /// </summary>
        public const string PAAN8 = "PAAN8";

        /// <summary>
        /// PAMLNM.
        /// </summary>
        public const string PAMLNM = "PAMLNM";

        /// <summary>
        /// PATAD1.
        /// </summary>
        public const string PATAD1 = "PATAD1";

        /// <summary>
        /// PATAD2.
        /// </summary>
        public const string PATAD2 = "PATAD2";

        /// <summary>
        /// PATAD3.
        /// </summary>
        public const string PATAD3 = "PATAD3";

        /// <summary>
        /// PATAD4.
        /// </summary>
        public const string PATAD4 = "PATAD4";

        /// <summary>
        /// PATAD5.
        /// </summary>
        public const string PATAD5 = "PATAD5";

        /// <summary>
        /// PATAD6.
        /// </summary>
        public const string PATAD6 = "PATAD6";

        /// <summary>
        /// PAQ064.
        /// </summary>
        public const string PAQ064 = "PAQ064";

        /// <summary>
        /// PAMLN1.
        /// </summary>
        public const string PAMLN1 = "PAMLN1";

        /// <summary>
        /// PAPAD1.
        /// </summary>
        public const string PAPAD1 = "PAPAD1";

        /// <summary>
        /// PAPAD2.
        /// </summary>
        public const string PAPAD2 = "PAPAD2";

        /// <summary>
        /// PAPAD3.
        /// </summary>
        public const string PAPAD3 = "PAPAD3";

        /// <summary>
        /// PAPAD4.
        /// </summary>
        public const string PAPAD4 = "PAPAD4";

        /// <summary>
        /// PAPAD5.
        /// </summary>
        public const string PAPAD5 = "PAPAD5";

        /// <summary>
        /// PAPAD6.
        /// </summary>
        public const string PAPAD6 = "PAPAD6";

        /// <summary>
        /// PAQ063.
        /// </summary>
        public const string PAQ063 = "PAQ063";

        /// <summary>
        /// PATRDJ.
        /// </summary>
        public const string PATRDJ = "PATRDJ";

        /// <summary>
        /// PADRQJ.
        /// </summary>
        public const string PADRQJ = "PADRQJ";

        /// <summary>
        /// PAFRTH.
        /// </summary>
        public const string PAFRTH = "PAFRTH";

        /// <summary>
        /// PATKBY.
        /// </summary>
        public const string PATKBY = "PATKBY";

        /// <summary>
        /// PACRCD.
        /// </summary>
        public const string PACRCD = "PACRCD";

        /// <summary>
        /// PADEL1.
        /// </summary>
        public const string PADEL1 = "PADEL1";

        /// <summary>
        /// PADEL2.
        /// </summary>
        public const string PADEL2 = "PADEL2";

        /// <summary>
        /// PACRR.
        /// </summary>
        public const string PACRR = "PACRR";

        /// <summary>
        /// PACRDC.
        /// </summary>
        public const string PACRDC = "PACRDC";

        /// <summary>
        /// PADSC1.
        /// </summary>
        public const string PADSC1 = "PADSC1";

        /// <summary>
        /// PAPTC.
        /// </summary>
        public const string PAPTC = "PAPTC";

        /// <summary>
        /// PAPTD.
        /// </summary>
        public const string PAPTD = "PAPTD";

        /// <summary>
        /// PACORD.
        /// </summary>
        public const string PACORD = "PACORD";

        /// <summary>
        /// PAORBY.
        /// </summary>
        public const string PAORBY = "PAORBY";

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
        /// PAVR01.
        /// </summary>
        public const string PAVR01 = "PAVR01";

        /// <summary>
        /// PAVR02.
        /// </summary>
        public const string PAVR02 = "PAVR02";

        /// <summary>
        /// PARMK.
        /// </summary>
        public const string PARMK = "PARMK";

        /// <summary>
        /// PADESC.
        /// </summary>
        public const string PADESC = "PADESC";

        /// <summary>
        /// PAANBY.
        /// </summary>
        public const string PAANBY = "PAANBY";

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
        /// PATOT1.
        /// </summary>
        public const string PATOT1 = "PATOT1";

        /// <summary>
        /// PAMATH04.
        /// </summary>
        public const string PAMATH04 = "PAMATH04";

        /// <summary>
        /// PATXXT.
        /// </summary>
        public const string PATXXT = "PATXXT";

        /// <summary>
        /// PAOTOT.
        /// </summary>
        public const string PAOTOT = "PAOTOT";

        /// <summary>
        /// PACRRM.
        /// </summary>
        public const string PACRRM = "PACRRM";

        /// <summary>
        /// PAINMG.
        /// </summary>
        public const string PAINMG = "PAINMG";

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
        /// PACTID.
        /// </summary>
        public const string PACTID = "PACTID";

        /// <summary>
        /// PALNPOW.
        /// </summary>
        public const string PALNPOW = "PALNPOW";

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
        /// PAPOHP13.
        /// </summary>
        public const string PAPOHP13 = "PAPOHP13";

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
        /// PAPOHU01.
        /// </summary>
        public const string PAPOHU01 = "PAPOHU01";

        /// <summary>
        /// PAPOHU02.
        /// </summary>
        public const string PAPOHU02 = "PAPOHU02";

        /// <summary>
        /// PAPOHAB01.
        /// </summary>
        public const string PAPOHAB01 = "PAPOHAB01";

        /// <summary>
        /// PAPOHAB02.
        /// </summary>
        public const string PAPOHAB02 = "PAPOHAB02";

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

        /// <summary>
        /// PACLNU.
        /// </summary>
        public const string PACLNU = "PACLNU";

        /// <summary>
        /// PADL01.
        /// </summary>
        public const string PADL01 = "PADL01";

        /// <summary>
        /// PAODCM.
        /// </summary>
        public const string PAODCM = "PAODCM";

        /// <summary>
        /// PAGOVPR.
        /// </summary>
        public const string PAGOVPR = "PAGOVPR";

        /// <summary>
        /// PAFDCL.
        /// </summary>
        public const string PAFDCL = "PAFDCL";
    }

    /// <inheritdoc />
    public override string TableName => "F43UI50H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PASEQ", "PASEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric),
        new JdeField("PADCTO", "PADCTO", JdeDataType.String, 4),
        new JdeField("PAKCOO", "PAKCOO", JdeDataType.String, 10),
        new JdeField("PASFXO", "PASFXO", JdeDataType.String, 6),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24),
        new JdeField("PASHAN", "PASHAN", JdeDataType.Numeric),
        new JdeField("PAAN8", "PAAN8", JdeDataType.Numeric),
        new JdeField("PAMLNM", "PAMLNM", JdeDataType.String, 80),
        new JdeField("PATAD1", "PATAD1", JdeDataType.String, 80),
        new JdeField("PATAD2", "PATAD2", JdeDataType.String, 80),
        new JdeField("PATAD3", "PATAD3", JdeDataType.String, 80),
        new JdeField("PATAD4", "PATAD4", JdeDataType.String, 80),
        new JdeField("PATAD5", "PATAD5", JdeDataType.String, 80),
        new JdeField("PATAD6", "PATAD6", JdeDataType.String, 80),
        new JdeField("PAQ064", "PAQ064", JdeDataType.String, 128),
        new JdeField("PAMLN1", "PAMLN1", JdeDataType.String, 80),
        new JdeField("PAPAD1", "PAPAD1", JdeDataType.String, 80),
        new JdeField("PAPAD2", "PAPAD2", JdeDataType.String, 80),
        new JdeField("PAPAD3", "PAPAD3", JdeDataType.String, 80),
        new JdeField("PAPAD4", "PAPAD4", JdeDataType.String, 80),
        new JdeField("PAPAD5", "PAPAD5", JdeDataType.String, 80),
        new JdeField("PAPAD6", "PAPAD6", JdeDataType.String, 80),
        new JdeField("PAQ063", "PAQ063", JdeDataType.String, 126),
        new JdeField("PATRDJ", "PATRDJ", JdeDataType.Numeric),
        new JdeField("PADRQJ", "PADRQJ", JdeDataType.Numeric),
        new JdeField("PAFRTH", "PAFRTH", JdeDataType.String, 6),
        new JdeField("PATKBY", "PATKBY", JdeDataType.String, 20),
        new JdeField("PACRCD", "PACRCD", JdeDataType.String, 6),
        new JdeField("PADEL1", "PADEL1", JdeDataType.String, 60),
        new JdeField("PADEL2", "PADEL2", JdeDataType.String, 60),
        new JdeField("PACRR", "PACRR", JdeDataType.Numeric),
        new JdeField("PACRDC", "PACRDC", JdeDataType.String, 6),
        new JdeField("PADSC1", "PADSC1", JdeDataType.String, 60),
        new JdeField("PAPTC", "PAPTC", JdeDataType.String, 6),
        new JdeField("PAPTD", "PAPTD", JdeDataType.String, 60),
        new JdeField("PACORD", "PACORD", JdeDataType.Numeric),
        new JdeField("PAORBY", "PAORBY", JdeDataType.String, 20),
        new JdeField("PARKCO", "PARKCO", JdeDataType.String, 10),
        new JdeField("PARORN", "PARORN", JdeDataType.String, 16),
        new JdeField("PARCTO", "PARCTO", JdeDataType.String, 4),
        new JdeField("PAVR01", "PAVR01", JdeDataType.String, 50),
        new JdeField("PAVR02", "PAVR02", JdeDataType.String, 50),
        new JdeField("PARMK", "PARMK", JdeDataType.String, 60),
        new JdeField("PADESC", "PADESC", JdeDataType.String, 60),
        new JdeField("PAANBY", "PAANBY", JdeDataType.Numeric),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PATOT1", "PATOT1", JdeDataType.Numeric),
        new JdeField("PAMATH04", "PAMATH04", JdeDataType.Numeric),
        new JdeField("PATXXT", "PATXXT", JdeDataType.Numeric),
        new JdeField("PAOTOT", "PAOTOT", JdeDataType.Numeric),
        new JdeField("PACRRM", "PACRRM", JdeDataType.String, 2),
        new JdeField("PAINMG", "PAINMG", JdeDataType.String, 20),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PATDAY", "PATDAY", JdeDataType.Numeric),
        new JdeField("PACTID", "PACTID", JdeDataType.String, 30, true, true),
        new JdeField("PALNPOW", "PALNPOW", JdeDataType.String, 4),
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
        new JdeField("PAPOHP13", "PAPOHP13", JdeDataType.String, 60),
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
        new JdeField("PAPOHU01", "PAPOHU01", JdeDataType.Date),
        new JdeField("PAPOHU02", "PAPOHU02", JdeDataType.Date),
        new JdeField("PAPOHAB01", "PAPOHAB01", JdeDataType.Numeric),
        new JdeField("PAPOHAB02", "PAPOHAB02", JdeDataType.Numeric),
        new JdeField("PARETI", "PARETI", JdeDataType.String, 2),
        new JdeField("PACLASS01", "PACLASS01", JdeDataType.String, 6),
        new JdeField("PACLASS02", "PACLASS02", JdeDataType.String, 6),
        new JdeField("PACLASS03", "PACLASS03", JdeDataType.String, 6),
        new JdeField("PACLASS04", "PACLASS04", JdeDataType.String, 6),
        new JdeField("PACLASS05", "PACLASS05", JdeDataType.String, 6),
        new JdeField("PACLNU", "PACLNU", JdeDataType.Numeric),
        new JdeField("PADL01", "PADL01", JdeDataType.String, 60),
        new JdeField("PAODCM", "PAODCM", JdeDataType.String, 50),
        new JdeField("PAGOVPR", "PAGOVPR", JdeDataType.String, 20),
        new JdeField("PAFDCL", "PAFDCL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43UI50H_0", "Primary Key on PAJOBN, PACTID, PASEQ", new[] { "PAJOBN", "PACTID", "PASEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
