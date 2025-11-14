using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4301 - .
/// </summary>
public class F4301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHKCOO.
        /// </summary>
        public const string PHKCOO = "PHKCOO";

        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHSFXO.
        /// </summary>
        public const string PHSFXO = "PHSFXO";

        /// <summary>
        /// PHMCU.
        /// </summary>
        public const string PHMCU = "PHMCU";

        /// <summary>
        /// PHOKCO.
        /// </summary>
        public const string PHOKCO = "PHOKCO";

        /// <summary>
        /// PHOORN.
        /// </summary>
        public const string PHOORN = "PHOORN";

        /// <summary>
        /// PHOCTO.
        /// </summary>
        public const string PHOCTO = "PHOCTO";

        /// <summary>
        /// PHRKCO.
        /// </summary>
        public const string PHRKCO = "PHRKCO";

        /// <summary>
        /// PHRORN.
        /// </summary>
        public const string PHRORN = "PHRORN";

        /// <summary>
        /// PHRCTO.
        /// </summary>
        public const string PHRCTO = "PHRCTO";

        /// <summary>
        /// PHAN8.
        /// </summary>
        public const string PHAN8 = "PHAN8";

        /// <summary>
        /// PHSHAN.
        /// </summary>
        public const string PHSHAN = "PHSHAN";

        /// <summary>
        /// PHDRQJ.
        /// </summary>
        public const string PHDRQJ = "PHDRQJ";

        /// <summary>
        /// PHTRDJ.
        /// </summary>
        public const string PHTRDJ = "PHTRDJ";

        /// <summary>
        /// PHPDDJ.
        /// </summary>
        public const string PHPDDJ = "PHPDDJ";

        /// <summary>
        /// PHOPDJ.
        /// </summary>
        public const string PHOPDJ = "PHOPDJ";

        /// <summary>
        /// PHADDJ.
        /// </summary>
        public const string PHADDJ = "PHADDJ";

        /// <summary>
        /// PHCNDJ.
        /// </summary>
        public const string PHCNDJ = "PHCNDJ";

        /// <summary>
        /// PHPEFJ.
        /// </summary>
        public const string PHPEFJ = "PHPEFJ";

        /// <summary>
        /// PHPPDJ.
        /// </summary>
        public const string PHPPDJ = "PHPPDJ";

        /// <summary>
        /// PHPSDJ.
        /// </summary>
        public const string PHPSDJ = "PHPSDJ";

        /// <summary>
        /// PHVR01.
        /// </summary>
        public const string PHVR01 = "PHVR01";

        /// <summary>
        /// PHVR02.
        /// </summary>
        public const string PHVR02 = "PHVR02";

        /// <summary>
        /// PHDEL1.
        /// </summary>
        public const string PHDEL1 = "PHDEL1";

        /// <summary>
        /// PHDEL2.
        /// </summary>
        public const string PHDEL2 = "PHDEL2";

        /// <summary>
        /// PHRMK.
        /// </summary>
        public const string PHRMK = "PHRMK";

        /// <summary>
        /// PHDESC.
        /// </summary>
        public const string PHDESC = "PHDESC";

        /// <summary>
        /// PHINMG.
        /// </summary>
        public const string PHINMG = "PHINMG";

        /// <summary>
        /// PHASN.
        /// </summary>
        public const string PHASN = "PHASN";

        /// <summary>
        /// PHPRGP.
        /// </summary>
        public const string PHPRGP = "PHPRGP";

        /// <summary>
        /// PHPTC.
        /// </summary>
        public const string PHPTC = "PHPTC";

        /// <summary>
        /// PHEXR1.
        /// </summary>
        public const string PHEXR1 = "PHEXR1";

        /// <summary>
        /// PHTXA1.
        /// </summary>
        public const string PHTXA1 = "PHTXA1";

        /// <summary>
        /// PHTXCT.
        /// </summary>
        public const string PHTXCT = "PHTXCT";

        /// <summary>
        /// PHHOLD.
        /// </summary>
        public const string PHHOLD = "PHHOLD";

        /// <summary>
        /// PHATXT.
        /// </summary>
        public const string PHATXT = "PHATXT";

        /// <summary>
        /// PHINVC.
        /// </summary>
        public const string PHINVC = "PHINVC";

        /// <summary>
        /// PHNTR.
        /// </summary>
        public const string PHNTR = "PHNTR";

        /// <summary>
        /// PHCNID.
        /// </summary>
        public const string PHCNID = "PHCNID";

        /// <summary>
        /// PHFRTH.
        /// </summary>
        public const string PHFRTH = "PHFRTH";

        /// <summary>
        /// PHZON.
        /// </summary>
        public const string PHZON = "PHZON";

        /// <summary>
        /// PHANBY.
        /// </summary>
        public const string PHANBY = "PHANBY";

        /// <summary>
        /// PHANCR.
        /// </summary>
        public const string PHANCR = "PHANCR";

        /// <summary>
        /// PHMOT.
        /// </summary>
        public const string PHMOT = "PHMOT";

        /// <summary>
        /// PHCOT.
        /// </summary>
        public const string PHCOT = "PHCOT";

        /// <summary>
        /// PHRCD.
        /// </summary>
        public const string PHRCD = "PHRCD";

        /// <summary>
        /// PHFRTC.
        /// </summary>
        public const string PHFRTC = "PHFRTC";

        /// <summary>
        /// PHFUF1.
        /// </summary>
        public const string PHFUF1 = "PHFUF1";

        /// <summary>
        /// PHFUF2.
        /// </summary>
        public const string PHFUF2 = "PHFUF2";

        /// <summary>
        /// PHOTOT.
        /// </summary>
        public const string PHOTOT = "PHOTOT";

        /// <summary>
        /// PHPCRT.
        /// </summary>
        public const string PHPCRT = "PHPCRT";

        /// <summary>
        /// PHRTNR.
        /// </summary>
        public const string PHRTNR = "PHRTNR";

        /// <summary>
        /// PHWUMD.
        /// </summary>
        public const string PHWUMD = "PHWUMD";

        /// <summary>
        /// PHVUMD.
        /// </summary>
        public const string PHVUMD = "PHVUMD";

        /// <summary>
        /// PHPURG.
        /// </summary>
        public const string PHPURG = "PHPURG";

        /// <summary>
        /// PHLGCT.
        /// </summary>
        public const string PHLGCT = "PHLGCT";

        /// <summary>
        /// PHPROM.
        /// </summary>
        public const string PHPROM = "PHPROM";

        /// <summary>
        /// PHMATY.
        /// </summary>
        public const string PHMATY = "PHMATY";

        /// <summary>
        /// PHOSTS.
        /// </summary>
        public const string PHOSTS = "PHOSTS";

        /// <summary>
        /// PHAVCH.
        /// </summary>
        public const string PHAVCH = "PHAVCH";

        /// <summary>
        /// PHPRPY.
        /// </summary>
        public const string PHPRPY = "PHPRPY";

        /// <summary>
        /// PHCRMD.
        /// </summary>
        public const string PHCRMD = "PHCRMD";

        /// <summary>
        /// PHPRP5.
        /// </summary>
        public const string PHPRP5 = "PHPRP5";

        /// <summary>
        /// PHARTG.
        /// </summary>
        public const string PHARTG = "PHARTG";

        /// <summary>
        /// PHCORD.
        /// </summary>
        public const string PHCORD = "PHCORD";

        /// <summary>
        /// PHCRRM.
        /// </summary>
        public const string PHCRRM = "PHCRRM";

        /// <summary>
        /// PHCRCD.
        /// </summary>
        public const string PHCRCD = "PHCRCD";

        /// <summary>
        /// PHCRR.
        /// </summary>
        public const string PHCRR = "PHCRR";

        /// <summary>
        /// PHLNGP.
        /// </summary>
        public const string PHLNGP = "PHLNGP";

        /// <summary>
        /// PHFAP.
        /// </summary>
        public const string PHFAP = "PHFAP";

        /// <summary>
        /// PHORBY.
        /// </summary>
        public const string PHORBY = "PHORBY";

        /// <summary>
        /// PHTKBY.
        /// </summary>
        public const string PHTKBY = "PHTKBY";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHTDAY.
        /// </summary>
        public const string PHTDAY = "PHTDAY";

        /// <summary>
        /// PHRSHT.
        /// </summary>
        public const string PHRSHT = "PHRSHT";

        /// <summary>
        /// PHDRQT.
        /// </summary>
        public const string PHDRQT = "PHDRQT";

        /// <summary>
        /// PHDOC1.
        /// </summary>
        public const string PHDOC1 = "PHDOC1";

        /// <summary>
        /// PHDCT4.
        /// </summary>
        public const string PHDCT4 = "PHDCT4";

        /// <summary>
        /// PHBCRC.
        /// </summary>
        public const string PHBCRC = "PHBCRC";

        /// <summary>
        /// PHMKFR.
        /// </summary>
        public const string PHMKFR = "PHMKFR";

        /// <summary>
        /// PHPOHP01.
        /// </summary>
        public const string PHPOHP01 = "PHPOHP01";

        /// <summary>
        /// PHPOHP02.
        /// </summary>
        public const string PHPOHP02 = "PHPOHP02";

        /// <summary>
        /// PHPOHP03.
        /// </summary>
        public const string PHPOHP03 = "PHPOHP03";

        /// <summary>
        /// PHPOHP04.
        /// </summary>
        public const string PHPOHP04 = "PHPOHP04";

        /// <summary>
        /// PHPOHP05.
        /// </summary>
        public const string PHPOHP05 = "PHPOHP05";

        /// <summary>
        /// PHPOHP06.
        /// </summary>
        public const string PHPOHP06 = "PHPOHP06";

        /// <summary>
        /// PHPOHP07.
        /// </summary>
        public const string PHPOHP07 = "PHPOHP07";

        /// <summary>
        /// PHPOHP08.
        /// </summary>
        public const string PHPOHP08 = "PHPOHP08";

        /// <summary>
        /// PHPOHP09.
        /// </summary>
        public const string PHPOHP09 = "PHPOHP09";

        /// <summary>
        /// PHPOHP10.
        /// </summary>
        public const string PHPOHP10 = "PHPOHP10";

        /// <summary>
        /// PHPOHP11.
        /// </summary>
        public const string PHPOHP11 = "PHPOHP11";

        /// <summary>
        /// PHPOHP12.
        /// </summary>
        public const string PHPOHP12 = "PHPOHP12";

        /// <summary>
        /// PHPOHC01.
        /// </summary>
        public const string PHPOHC01 = "PHPOHC01";

        /// <summary>
        /// PHPOHC02.
        /// </summary>
        public const string PHPOHC02 = "PHPOHC02";

        /// <summary>
        /// PHPOHC03.
        /// </summary>
        public const string PHPOHC03 = "PHPOHC03";

        /// <summary>
        /// PHPOHC04.
        /// </summary>
        public const string PHPOHC04 = "PHPOHC04";

        /// <summary>
        /// PHPOHC05.
        /// </summary>
        public const string PHPOHC05 = "PHPOHC05";

        /// <summary>
        /// PHPOHC06.
        /// </summary>
        public const string PHPOHC06 = "PHPOHC06";

        /// <summary>
        /// PHPOHC07.
        /// </summary>
        public const string PHPOHC07 = "PHPOHC07";

        /// <summary>
        /// PHPOHC08.
        /// </summary>
        public const string PHPOHC08 = "PHPOHC08";

        /// <summary>
        /// PHPOHC09.
        /// </summary>
        public const string PHPOHC09 = "PHPOHC09";

        /// <summary>
        /// PHPOHC10.
        /// </summary>
        public const string PHPOHC10 = "PHPOHC10";

        /// <summary>
        /// PHPOHC11.
        /// </summary>
        public const string PHPOHC11 = "PHPOHC11";

        /// <summary>
        /// PHPOHC12.
        /// </summary>
        public const string PHPOHC12 = "PHPOHC12";

        /// <summary>
        /// PHPOHD01.
        /// </summary>
        public const string PHPOHD01 = "PHPOHD01";

        /// <summary>
        /// PHPOHD02.
        /// </summary>
        public const string PHPOHD02 = "PHPOHD02";

        /// <summary>
        /// PHPOHAB01.
        /// </summary>
        public const string PHPOHAB01 = "PHPOHAB01";

        /// <summary>
        /// PHPOHAB02.
        /// </summary>
        public const string PHPOHAB02 = "PHPOHAB02";

        /// <summary>
        /// PHCUKID.
        /// </summary>
        public const string PHCUKID = "PHCUKID";

        /// <summary>
        /// PHPOHP13.
        /// </summary>
        public const string PHPOHP13 = "PHPOHP13";

        /// <summary>
        /// PHPOHU01.
        /// </summary>
        public const string PHPOHU01 = "PHPOHU01";

        /// <summary>
        /// PHPOHU02.
        /// </summary>
        public const string PHPOHU02 = "PHPOHU02";

        /// <summary>
        /// PHRETI.
        /// </summary>
        public const string PHRETI = "PHRETI";

        /// <summary>
        /// PHCLASS01.
        /// </summary>
        public const string PHCLASS01 = "PHCLASS01";

        /// <summary>
        /// PHCLASS02.
        /// </summary>
        public const string PHCLASS02 = "PHCLASS02";

        /// <summary>
        /// PHCLASS03.
        /// </summary>
        public const string PHCLASS03 = "PHCLASS03";

        /// <summary>
        /// PHCLASS04.
        /// </summary>
        public const string PHCLASS04 = "PHCLASS04";

        /// <summary>
        /// PHCLASS05.
        /// </summary>
        public const string PHCLASS05 = "PHCLASS05";
    }

    /// <inheritdoc />
    public override string TableName => "F4301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHKCOO", "PHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PHSFXO", "PHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PHMCU", "PHMCU", JdeDataType.String, 24),
        new JdeField("PHOKCO", "PHOKCO", JdeDataType.String, 10),
        new JdeField("PHOORN", "PHOORN", JdeDataType.String, 16),
        new JdeField("PHOCTO", "PHOCTO", JdeDataType.String, 4),
        new JdeField("PHRKCO", "PHRKCO", JdeDataType.String, 10),
        new JdeField("PHRORN", "PHRORN", JdeDataType.String, 16),
        new JdeField("PHRCTO", "PHRCTO", JdeDataType.String, 4),
        new JdeField("PHAN8", "PHAN8", JdeDataType.Numeric),
        new JdeField("PHSHAN", "PHSHAN", JdeDataType.Numeric),
        new JdeField("PHDRQJ", "PHDRQJ", JdeDataType.Numeric),
        new JdeField("PHTRDJ", "PHTRDJ", JdeDataType.Numeric),
        new JdeField("PHPDDJ", "PHPDDJ", JdeDataType.Numeric),
        new JdeField("PHOPDJ", "PHOPDJ", JdeDataType.Numeric),
        new JdeField("PHADDJ", "PHADDJ", JdeDataType.Numeric),
        new JdeField("PHCNDJ", "PHCNDJ", JdeDataType.Numeric),
        new JdeField("PHPEFJ", "PHPEFJ", JdeDataType.Numeric),
        new JdeField("PHPPDJ", "PHPPDJ", JdeDataType.Numeric),
        new JdeField("PHPSDJ", "PHPSDJ", JdeDataType.Numeric),
        new JdeField("PHVR01", "PHVR01", JdeDataType.String, 50),
        new JdeField("PHVR02", "PHVR02", JdeDataType.String, 50),
        new JdeField("PHDEL1", "PHDEL1", JdeDataType.String, 60),
        new JdeField("PHDEL2", "PHDEL2", JdeDataType.String, 60),
        new JdeField("PHRMK", "PHRMK", JdeDataType.String, 60),
        new JdeField("PHDESC", "PHDESC", JdeDataType.String, 60),
        new JdeField("PHINMG", "PHINMG", JdeDataType.String, 20),
        new JdeField("PHASN", "PHASN", JdeDataType.String, 16),
        new JdeField("PHPRGP", "PHPRGP", JdeDataType.String, 16),
        new JdeField("PHPTC", "PHPTC", JdeDataType.String, 6),
        new JdeField("PHEXR1", "PHEXR1", JdeDataType.String, 4),
        new JdeField("PHTXA1", "PHTXA1", JdeDataType.String, 20),
        new JdeField("PHTXCT", "PHTXCT", JdeDataType.String, 40),
        new JdeField("PHHOLD", "PHHOLD", JdeDataType.String, 4),
        new JdeField("PHATXT", "PHATXT", JdeDataType.String, 2),
        new JdeField("PHINVC", "PHINVC", JdeDataType.Numeric),
        new JdeField("PHNTR", "PHNTR", JdeDataType.String, 4),
        new JdeField("PHCNID", "PHCNID", JdeDataType.String, 40),
        new JdeField("PHFRTH", "PHFRTH", JdeDataType.String, 6),
        new JdeField("PHZON", "PHZON", JdeDataType.String, 6),
        new JdeField("PHANBY", "PHANBY", JdeDataType.Numeric),
        new JdeField("PHANCR", "PHANCR", JdeDataType.Numeric),
        new JdeField("PHMOT", "PHMOT", JdeDataType.String, 6),
        new JdeField("PHCOT", "PHCOT", JdeDataType.String, 6),
        new JdeField("PHRCD", "PHRCD", JdeDataType.String, 6),
        new JdeField("PHFRTC", "PHFRTC", JdeDataType.String, 2),
        new JdeField("PHFUF1", "PHFUF1", JdeDataType.String, 2),
        new JdeField("PHFUF2", "PHFUF2", JdeDataType.String, 2),
        new JdeField("PHOTOT", "PHOTOT", JdeDataType.Numeric),
        new JdeField("PHPCRT", "PHPCRT", JdeDataType.Numeric),
        new JdeField("PHRTNR", "PHRTNR", JdeDataType.String, 6),
        new JdeField("PHWUMD", "PHWUMD", JdeDataType.String, 4),
        new JdeField("PHVUMD", "PHVUMD", JdeDataType.String, 4),
        new JdeField("PHPURG", "PHPURG", JdeDataType.String, 2),
        new JdeField("PHLGCT", "PHLGCT", JdeDataType.String, 2),
        new JdeField("PHPROM", "PHPROM", JdeDataType.String, 2),
        new JdeField("PHMATY", "PHMATY", JdeDataType.String, 2),
        new JdeField("PHOSTS", "PHOSTS", JdeDataType.String, 2),
        new JdeField("PHAVCH", "PHAVCH", JdeDataType.String, 2),
        new JdeField("PHPRPY", "PHPRPY", JdeDataType.String, 2),
        new JdeField("PHCRMD", "PHCRMD", JdeDataType.String, 2),
        new JdeField("PHPRP5", "PHPRP5", JdeDataType.String, 6),
        new JdeField("PHARTG", "PHARTG", JdeDataType.String, 24),
        new JdeField("PHCORD", "PHCORD", JdeDataType.Numeric),
        new JdeField("PHCRRM", "PHCRRM", JdeDataType.String, 2),
        new JdeField("PHCRCD", "PHCRCD", JdeDataType.String, 6),
        new JdeField("PHCRR", "PHCRR", JdeDataType.Numeric),
        new JdeField("PHLNGP", "PHLNGP", JdeDataType.String, 4),
        new JdeField("PHFAP", "PHFAP", JdeDataType.Numeric),
        new JdeField("PHORBY", "PHORBY", JdeDataType.String, 20),
        new JdeField("PHTKBY", "PHTKBY", JdeDataType.String, 20),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHTDAY", "PHTDAY", JdeDataType.Numeric),
        new JdeField("PHRSHT", "PHRSHT", JdeDataType.Numeric),
        new JdeField("PHDRQT", "PHDRQT", JdeDataType.Numeric),
        new JdeField("PHDOC1", "PHDOC1", JdeDataType.Numeric),
        new JdeField("PHDCT4", "PHDCT4", JdeDataType.String, 4),
        new JdeField("PHBCRC", "PHBCRC", JdeDataType.String, 6),
        new JdeField("PHMKFR", "PHMKFR", JdeDataType.Numeric),
        new JdeField("PHPOHP01", "PHPOHP01", JdeDataType.String, 2),
        new JdeField("PHPOHP02", "PHPOHP02", JdeDataType.String, 2),
        new JdeField("PHPOHP03", "PHPOHP03", JdeDataType.String, 2),
        new JdeField("PHPOHP04", "PHPOHP04", JdeDataType.String, 2),
        new JdeField("PHPOHP05", "PHPOHP05", JdeDataType.String, 2),
        new JdeField("PHPOHP06", "PHPOHP06", JdeDataType.String, 2),
        new JdeField("PHPOHP07", "PHPOHP07", JdeDataType.String, 2),
        new JdeField("PHPOHP08", "PHPOHP08", JdeDataType.String, 2),
        new JdeField("PHPOHP09", "PHPOHP09", JdeDataType.String, 2),
        new JdeField("PHPOHP10", "PHPOHP10", JdeDataType.String, 2),
        new JdeField("PHPOHP11", "PHPOHP11", JdeDataType.String, 2),
        new JdeField("PHPOHP12", "PHPOHP12", JdeDataType.String, 2),
        new JdeField("PHPOHC01", "PHPOHC01", JdeDataType.String, 6),
        new JdeField("PHPOHC02", "PHPOHC02", JdeDataType.String, 6),
        new JdeField("PHPOHC03", "PHPOHC03", JdeDataType.String, 6),
        new JdeField("PHPOHC04", "PHPOHC04", JdeDataType.String, 6),
        new JdeField("PHPOHC05", "PHPOHC05", JdeDataType.String, 6),
        new JdeField("PHPOHC06", "PHPOHC06", JdeDataType.String, 6),
        new JdeField("PHPOHC07", "PHPOHC07", JdeDataType.String, 20),
        new JdeField("PHPOHC08", "PHPOHC08", JdeDataType.String, 20),
        new JdeField("PHPOHC09", "PHPOHC09", JdeDataType.String, 20),
        new JdeField("PHPOHC10", "PHPOHC10", JdeDataType.String, 20),
        new JdeField("PHPOHC11", "PHPOHC11", JdeDataType.String, 20),
        new JdeField("PHPOHC12", "PHPOHC12", JdeDataType.String, 20),
        new JdeField("PHPOHD01", "PHPOHD01", JdeDataType.Numeric),
        new JdeField("PHPOHD02", "PHPOHD02", JdeDataType.Numeric),
        new JdeField("PHPOHAB01", "PHPOHAB01", JdeDataType.Numeric),
        new JdeField("PHPOHAB02", "PHPOHAB02", JdeDataType.Numeric),
        new JdeField("PHCUKID", "PHCUKID", JdeDataType.Numeric),
        new JdeField("PHPOHP13", "PHPOHP13", JdeDataType.String, 60),
        new JdeField("PHPOHU01", "PHPOHU01", JdeDataType.Date),
        new JdeField("PHPOHU02", "PHPOHU02", JdeDataType.Date),
        new JdeField("PHRETI", "PHRETI", JdeDataType.String, 2),
        new JdeField("PHCLASS01", "PHCLASS01", JdeDataType.String, 6),
        new JdeField("PHCLASS02", "PHCLASS02", JdeDataType.String, 6),
        new JdeField("PHCLASS03", "PHCLASS03", JdeDataType.String, 6),
        new JdeField("PHCLASS04", "PHCLASS04", JdeDataType.String, 6),
        new JdeField("PHCLASS05", "PHCLASS05", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4301_0", "Primary Key on PHDOCO, PHDCTO, PHKCOO, PHSFXO", new[] { "PHDOCO", "PHDCTO", "PHKCOO", "PHSFXO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4301_2", "Index on PHKCOO, PHDOCO, PHDCTO", new[] { "PHKCOO", "PHDOCO", "PHDCTO" }),
        new JdeIndex("F4301_3", "Index on PHAN8, PHDCTO, PHVR01", new[] { "PHAN8", "PHDCTO", "PHVR01" }),
        new JdeIndex("F4301_4", "Index on PHAN8, PHDCTO, PHHOLD", new[] { "PHAN8", "PHDCTO", "PHHOLD" }),
        new JdeIndex("F4301_5", "Index on PHAN8, PHDCTO, PHDOCO", new[] { "PHAN8", "PHDCTO", "PHDOCO" }),
        new JdeIndex("F4301_6", "Index on PHRORN, PHRCTO", new[] { "PHRORN", "PHRCTO" })
    };
}
