using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4822H - .
/// </summary>
public class F4822H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHDOCO.
        /// </summary>
        public const string IHDOCO = "IHDOCO";

        /// <summary>
        /// IHDCTO.
        /// </summary>
        public const string IHDCTO = "IHDCTO";

        /// <summary>
        /// IHKCOO.
        /// </summary>
        public const string IHKCOO = "IHKCOO";

        /// <summary>
        /// IHPCTN.
        /// </summary>
        public const string IHPCTN = "IHPCTN";

        /// <summary>
        /// IHPCTT.
        /// </summary>
        public const string IHPCTT = "IHPCTT";

        /// <summary>
        /// IHPCKO.
        /// </summary>
        public const string IHPCKO = "IHPCKO";

        /// <summary>
        /// IHAPPL.
        /// </summary>
        public const string IHAPPL = "IHAPPL";

        /// <summary>
        /// IHADJN.
        /// </summary>
        public const string IHADJN = "IHADJN";

        /// <summary>
        /// IHCOCH.
        /// </summary>
        public const string IHCOCH = "IHCOCH";

        /// <summary>
        /// IHLNID.
        /// </summary>
        public const string IHLNID = "IHLNID";

        /// <summary>
        /// IHOPIM.
        /// </summary>
        public const string IHOPIM = "IHOPIM";

        /// <summary>
        /// IHPRTP.
        /// </summary>
        public const string IHPRTP = "IHPRTP";

        /// <summary>
        /// IHBLSP.
        /// </summary>
        public const string IHBLSP = "IHBLSP";

        /// <summary>
        /// IHAN8O.
        /// </summary>
        public const string IHAN8O = "IHAN8O";

        /// <summary>
        /// IHAN8J.
        /// </summary>
        public const string IHAN8J = "IHAN8J";

        /// <summary>
        /// IHPTC.
        /// </summary>
        public const string IHPTC = "IHPTC";

        /// <summary>
        /// IHCO.
        /// </summary>
        public const string IHCO = "IHCO";

        /// <summary>
        /// IHMCU.
        /// </summary>
        public const string IHMCU = "IHMCU";

        /// <summary>
        /// IHSBL.
        /// </summary>
        public const string IHSBL = "IHSBL";

        /// <summary>
        /// IHSBLT.
        /// </summary>
        public const string IHSBLT = "IHSBLT";

        /// <summary>
        /// IHGLC.
        /// </summary>
        public const string IHGLC = "IHGLC";

        /// <summary>
        /// IHBTFR.
        /// </summary>
        public const string IHBTFR = "IHBTFR";

        /// <summary>
        /// IHBTDT.
        /// </summary>
        public const string IHBTDT = "IHBTDT";

        /// <summary>
        /// IHDGL.
        /// </summary>
        public const string IHDGL = "IHDGL";

        /// <summary>
        /// IHDDJ.
        /// </summary>
        public const string IHDDJ = "IHDDJ";

        /// <summary>
        /// IHDSVJ.
        /// </summary>
        public const string IHDSVJ = "IHDSVJ";

        /// <summary>
        /// IHICU.
        /// </summary>
        public const string IHICU = "IHICU";

        /// <summary>
        /// IHDOCZ.
        /// </summary>
        public const string IHDOCZ = "IHDOCZ";

        /// <summary>
        /// IHDCTI.
        /// </summary>
        public const string IHDCTI = "IHDCTI";

        /// <summary>
        /// IHKCOI.
        /// </summary>
        public const string IHKCOI = "IHKCOI";

        /// <summary>
        /// IHSFX.
        /// </summary>
        public const string IHSFX = "IHSFX";

        /// <summary>
        /// IHAPDT.
        /// </summary>
        public const string IHAPDT = "IHAPDT";

        /// <summary>
        /// IHAPPO.
        /// </summary>
        public const string IHAPPO = "IHAPPO";

        /// <summary>
        /// IHVOID.
        /// </summary>
        public const string IHVOID = "IHVOID";

        /// <summary>
        /// IHINVF.
        /// </summary>
        public const string IHINVF = "IHINVF";

        /// <summary>
        /// IHINTY.
        /// </summary>
        public const string IHINTY = "IHINTY";

        /// <summary>
        /// IHU.
        /// </summary>
        public const string IHU = "IHU";

        /// <summary>
        /// IHUM.
        /// </summary>
        public const string IHUM = "IHUM";

        /// <summary>
        /// IHUP.
        /// </summary>
        public const string IHUP = "IHUP";

        /// <summary>
        /// IHFUP.
        /// </summary>
        public const string IHFUP = "IHFUP";

        /// <summary>
        /// IHPUHP.
        /// </summary>
        public const string IHPUHP = "IHPUHP";

        /// <summary>
        /// IHAA.
        /// </summary>
        public const string IHAA = "IHAA";

        /// <summary>
        /// IHACR.
        /// </summary>
        public const string IHACR = "IHACR";

        /// <summary>
        /// IHTHPD.
        /// </summary>
        public const string IHTHPD = "IHTHPD";

        /// <summary>
        /// IHFHPD.
        /// </summary>
        public const string IHFHPD = "IHFHPD";

        /// <summary>
        /// IHRTHP.
        /// </summary>
        public const string IHRTHP = "IHRTHP";

        /// <summary>
        /// IHPTHP.
        /// </summary>
        public const string IHPTHP = "IHPTHP";

        /// <summary>
        /// IHFTHP.
        /// </summary>
        public const string IHFTHP = "IHFTHP";

        /// <summary>
        /// IHTXA1.
        /// </summary>
        public const string IHTXA1 = "IHTXA1";

        /// <summary>
        /// IHEXR1.
        /// </summary>
        public const string IHEXR1 = "IHEXR1";

        /// <summary>
        /// IHSTAM.
        /// </summary>
        public const string IHSTAM = "IHSTAM";

        /// <summary>
        /// IHCTAM.
        /// </summary>
        public const string IHCTAM = "IHCTAM";

        /// <summary>
        /// IHPTAM.
        /// </summary>
        public const string IHPTAM = "IHPTAM";

        /// <summary>
        /// IHFPTA.
        /// </summary>
        public const string IHFPTA = "IHFPTA";

        /// <summary>
        /// IHATXA.
        /// </summary>
        public const string IHATXA = "IHATXA";

        /// <summary>
        /// IHCTXA.
        /// </summary>
        public const string IHCTXA = "IHCTXA";

        /// <summary>
        /// IHPATX.
        /// </summary>
        public const string IHPATX = "IHPATX";

        /// <summary>
        /// IHFATX.
        /// </summary>
        public const string IHFATX = "IHFATX";

        /// <summary>
        /// IHATXN.
        /// </summary>
        public const string IHATXN = "IHATXN";

        /// <summary>
        /// IHCTXN.
        /// </summary>
        public const string IHCTXN = "IHCTXN";

        /// <summary>
        /// IHRTRE.
        /// </summary>
        public const string IHRTRE = "IHRTRE";

        /// <summary>
        /// IHRGLC.
        /// </summary>
        public const string IHRGLC = "IHRGLC";

        /// <summary>
        /// IHPRET.
        /// </summary>
        public const string IHPRET = "IHPRET";

        /// <summary>
        /// IHRTNR.
        /// </summary>
        public const string IHRTNR = "IHRTNR";

        /// <summary>
        /// IHRCTL.
        /// </summary>
        public const string IHRCTL = "IHRCTL";

        /// <summary>
        /// IHRTNG.
        /// </summary>
        public const string IHRTNG = "IHRTNG";

        /// <summary>
        /// IHFTNG.
        /// </summary>
        public const string IHFTNG = "IHFTNG";

        /// <summary>
        /// IHRTNP.
        /// </summary>
        public const string IHRTNP = "IHRTNP";

        /// <summary>
        /// IHFTNP.
        /// </summary>
        public const string IHFTNP = "IHFTNP";

        /// <summary>
        /// IHDDTR.
        /// </summary>
        public const string IHDDTR = "IHDDTR";

        /// <summary>
        /// IHFDTR.
        /// </summary>
        public const string IHFDTR = "IHFDTR";

        /// <summary>
        /// IHSTML.
        /// </summary>
        public const string IHSTML = "IHSTML";

        /// <summary>
        /// IHFTML.
        /// </summary>
        public const string IHFTML = "IHFTML";

        /// <summary>
        /// IHPSMA.
        /// </summary>
        public const string IHPSMA = "IHPSMA";

        /// <summary>
        /// IHFSMA.
        /// </summary>
        public const string IHFSMA = "IHFSMA";

        /// <summary>
        /// IHRTN1.
        /// </summary>
        public const string IHRTN1 = "IHRTN1";

        /// <summary>
        /// IHSMRT.
        /// </summary>
        public const string IHSMRT = "IHSMRT";

        /// <summary>
        /// IHSMRF.
        /// </summary>
        public const string IHSMRF = "IHSMRF";

        /// <summary>
        /// IHSMRP.
        /// </summary>
        public const string IHSMRP = "IHSMRP";

        /// <summary>
        /// IHSMPF.
        /// </summary>
        public const string IHSMPF = "IHSMPF";

        /// <summary>
        /// IHTLAB.
        /// </summary>
        public const string IHTLAB = "IHTLAB";

        /// <summary>
        /// IHFLAB.
        /// </summary>
        public const string IHFLAB = "IHFLAB";

        /// <summary>
        /// IHTBUR.
        /// </summary>
        public const string IHTBUR = "IHTBUR";

        /// <summary>
        /// IHFBUR.
        /// </summary>
        public const string IHFBUR = "IHFBUR";

        /// <summary>
        /// IHADSC.
        /// </summary>
        public const string IHADSC = "IHADSC";

        /// <summary>
        /// IHCDS.
        /// </summary>
        public const string IHCDS = "IHCDS";

        /// <summary>
        /// IHCRRM.
        /// </summary>
        public const string IHCRRM = "IHCRRM";

        /// <summary>
        /// IHCRCD.
        /// </summary>
        public const string IHCRCD = "IHCRCD";

        /// <summary>
        /// IHCRCF.
        /// </summary>
        public const string IHCRCF = "IHCRCF";

        /// <summary>
        /// IHCRR.
        /// </summary>
        public const string IHCRR = "IHCRR";

        /// <summary>
        /// IHCRRD.
        /// </summary>
        public const string IHCRRD = "IHCRRD";

        /// <summary>
        /// IHRMK.
        /// </summary>
        public const string IHRMK = "IHRMK";

        /// <summary>
        /// IHMIVL.
        /// </summary>
        public const string IHMIVL = "IHMIVL";

        /// <summary>
        /// IHMISM.
        /// </summary>
        public const string IHMISM = "IHMISM";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHJOBN.
        /// </summary>
        public const string IHJOBN = "IHJOBN";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHMUPM.
        /// </summary>
        public const string IHMUPM = "IHMUPM";

        /// <summary>
        /// IHUPMT.
        /// </summary>
        public const string IHUPMT = "IHUPMT";

        /// <summary>
        /// IHVGCSF.
        /// </summary>
        public const string IHVGCSF = "IHVGCSF";

        /// <summary>
        /// IHVGCOA.
        /// </summary>
        public const string IHVGCOA = "IHVGCOA";

        /// <summary>
        /// IHVVTY.
        /// </summary>
        public const string IHVVTY = "IHVVTY";

        /// <summary>
        /// IHVVTC.
        /// </summary>
        public const string IHVVTC = "IHVVTC";

        /// <summary>
        /// IHPYWP.
        /// </summary>
        public const string IHPYWP = "IHPYWP";

        /// <summary>
        /// IHDTIPTF.
        /// </summary>
        public const string IHDTIPTF = "IHDTIPTF";

        /// <summary>
        /// IHDTIPTT.
        /// </summary>
        public const string IHDTIPTT = "IHDTIPTT";

        /// <summary>
        /// IHDTFPTF.
        /// </summary>
        public const string IHDTFPTF = "IHDTFPTF";

        /// <summary>
        /// IHDTFPTT.
        /// </summary>
        public const string IHDTFPTT = "IHDTFPTT";

        /// <summary>
        /// IHCLNU.
        /// </summary>
        public const string IHCLNU = "IHCLNU";

        /// <summary>
        /// IHCLTT.
        /// </summary>
        public const string IHCLTT = "IHCLTT";

        /// <summary>
        /// IHCLKO.
        /// </summary>
        public const string IHCLKO = "IHCLKO";

        /// <summary>
        /// IHGCSC.
        /// </summary>
        public const string IHGCSC = "IHGCSC";

        /// <summary>
        /// IHUKID.
        /// </summary>
        public const string IHUKID = "IHUKID";

        /// <summary>
        /// IHRETD.
        /// </summary>
        public const string IHRETD = "IHRETD";

        /// <summary>
        /// IHFRETD.
        /// </summary>
        public const string IHFRETD = "IHFRETD";
    }

    /// <inheritdoc />
    public override string TableName => "F4822H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHDOCO", "IHDOCO", JdeDataType.Numeric),
        new JdeField("IHDCTO", "IHDCTO", JdeDataType.String, 4),
        new JdeField("IHKCOO", "IHKCOO", JdeDataType.String, 10),
        new JdeField("IHPCTN", "IHPCTN", JdeDataType.Numeric),
        new JdeField("IHPCTT", "IHPCTT", JdeDataType.String, 4),
        new JdeField("IHPCKO", "IHPCKO", JdeDataType.String, 10),
        new JdeField("IHAPPL", "IHAPPL", JdeDataType.Numeric),
        new JdeField("IHADJN", "IHADJN", JdeDataType.Numeric),
        new JdeField("IHCOCH", "IHCOCH", JdeDataType.String, 6),
        new JdeField("IHLNID", "IHLNID", JdeDataType.Numeric),
        new JdeField("IHOPIM", "IHOPIM", JdeDataType.String, 30),
        new JdeField("IHPRTP", "IHPRTP", JdeDataType.String, 2),
        new JdeField("IHBLSP", "IHBLSP", JdeDataType.String, 2),
        new JdeField("IHAN8O", "IHAN8O", JdeDataType.Numeric),
        new JdeField("IHAN8J", "IHAN8J", JdeDataType.Numeric),
        new JdeField("IHPTC", "IHPTC", JdeDataType.String, 6),
        new JdeField("IHCO", "IHCO", JdeDataType.String, 10),
        new JdeField("IHMCU", "IHMCU", JdeDataType.String, 24),
        new JdeField("IHSBL", "IHSBL", JdeDataType.String, 16),
        new JdeField("IHSBLT", "IHSBLT", JdeDataType.String, 2),
        new JdeField("IHGLC", "IHGLC", JdeDataType.String, 8),
        new JdeField("IHBTFR", "IHBTFR", JdeDataType.Numeric),
        new JdeField("IHBTDT", "IHBTDT", JdeDataType.Numeric),
        new JdeField("IHDGL", "IHDGL", JdeDataType.Numeric),
        new JdeField("IHDDJ", "IHDDJ", JdeDataType.Numeric),
        new JdeField("IHDSVJ", "IHDSVJ", JdeDataType.Numeric),
        new JdeField("IHICU", "IHICU", JdeDataType.Numeric),
        new JdeField("IHDOCZ", "IHDOCZ", JdeDataType.Numeric),
        new JdeField("IHDCTI", "IHDCTI", JdeDataType.String, 4),
        new JdeField("IHKCOI", "IHKCOI", JdeDataType.String, 10),
        new JdeField("IHSFX", "IHSFX", JdeDataType.String, 6),
        new JdeField("IHAPDT", "IHAPDT", JdeDataType.Numeric),
        new JdeField("IHAPPO", "IHAPPO", JdeDataType.String, 2),
        new JdeField("IHVOID", "IHVOID", JdeDataType.String, 2),
        new JdeField("IHINVF", "IHINVF", JdeDataType.String, 20),
        new JdeField("IHINTY", "IHINTY", JdeDataType.String, 2),
        new JdeField("IHU", "IHU", JdeDataType.Numeric),
        new JdeField("IHUM", "IHUM", JdeDataType.String, 4),
        new JdeField("IHUP", "IHUP", JdeDataType.Numeric),
        new JdeField("IHFUP", "IHFUP", JdeDataType.Numeric),
        new JdeField("IHPUHP", "IHPUHP", JdeDataType.Numeric),
        new JdeField("IHAA", "IHAA", JdeDataType.Numeric),
        new JdeField("IHACR", "IHACR", JdeDataType.Numeric),
        new JdeField("IHTHPD", "IHTHPD", JdeDataType.Numeric),
        new JdeField("IHFHPD", "IHFHPD", JdeDataType.Numeric),
        new JdeField("IHRTHP", "IHRTHP", JdeDataType.Numeric),
        new JdeField("IHPTHP", "IHPTHP", JdeDataType.Numeric),
        new JdeField("IHFTHP", "IHFTHP", JdeDataType.Numeric),
        new JdeField("IHTXA1", "IHTXA1", JdeDataType.String, 20),
        new JdeField("IHEXR1", "IHEXR1", JdeDataType.String, 4),
        new JdeField("IHSTAM", "IHSTAM", JdeDataType.Numeric),
        new JdeField("IHCTAM", "IHCTAM", JdeDataType.Numeric),
        new JdeField("IHPTAM", "IHPTAM", JdeDataType.Numeric),
        new JdeField("IHFPTA", "IHFPTA", JdeDataType.Numeric),
        new JdeField("IHATXA", "IHATXA", JdeDataType.Numeric),
        new JdeField("IHCTXA", "IHCTXA", JdeDataType.Numeric),
        new JdeField("IHPATX", "IHPATX", JdeDataType.Numeric),
        new JdeField("IHFATX", "IHFATX", JdeDataType.Numeric),
        new JdeField("IHATXN", "IHATXN", JdeDataType.Numeric),
        new JdeField("IHCTXN", "IHCTXN", JdeDataType.Numeric),
        new JdeField("IHRTRE", "IHRTRE", JdeDataType.String, 2),
        new JdeField("IHRGLC", "IHRGLC", JdeDataType.String, 8),
        new JdeField("IHPRET", "IHPRET", JdeDataType.Numeric),
        new JdeField("IHRTNR", "IHRTNR", JdeDataType.String, 6),
        new JdeField("IHRCTL", "IHRCTL", JdeDataType.String, 2),
        new JdeField("IHRTNG", "IHRTNG", JdeDataType.Numeric),
        new JdeField("IHFTNG", "IHFTNG", JdeDataType.Numeric),
        new JdeField("IHRTNP", "IHRTNP", JdeDataType.Numeric),
        new JdeField("IHFTNP", "IHFTNP", JdeDataType.Numeric),
        new JdeField("IHDDTR", "IHDDTR", JdeDataType.Numeric),
        new JdeField("IHFDTR", "IHFDTR", JdeDataType.Numeric),
        new JdeField("IHSTML", "IHSTML", JdeDataType.Numeric),
        new JdeField("IHFTML", "IHFTML", JdeDataType.Numeric),
        new JdeField("IHPSMA", "IHPSMA", JdeDataType.Numeric),
        new JdeField("IHFSMA", "IHFSMA", JdeDataType.Numeric),
        new JdeField("IHRTN1", "IHRTN1", JdeDataType.String, 6),
        new JdeField("IHSMRT", "IHSMRT", JdeDataType.Numeric),
        new JdeField("IHSMRF", "IHSMRF", JdeDataType.Numeric),
        new JdeField("IHSMRP", "IHSMRP", JdeDataType.Numeric),
        new JdeField("IHSMPF", "IHSMPF", JdeDataType.Numeric),
        new JdeField("IHTLAB", "IHTLAB", JdeDataType.Numeric),
        new JdeField("IHFLAB", "IHFLAB", JdeDataType.Numeric),
        new JdeField("IHTBUR", "IHTBUR", JdeDataType.Numeric),
        new JdeField("IHFBUR", "IHFBUR", JdeDataType.Numeric),
        new JdeField("IHADSC", "IHADSC", JdeDataType.Numeric),
        new JdeField("IHCDS", "IHCDS", JdeDataType.Numeric),
        new JdeField("IHCRRM", "IHCRRM", JdeDataType.String, 2),
        new JdeField("IHCRCD", "IHCRCD", JdeDataType.String, 6),
        new JdeField("IHCRCF", "IHCRCF", JdeDataType.String, 6),
        new JdeField("IHCRR", "IHCRR", JdeDataType.Numeric),
        new JdeField("IHCRRD", "IHCRRD", JdeDataType.Numeric),
        new JdeField("IHRMK", "IHRMK", JdeDataType.String, 60),
        new JdeField("IHMIVL", "IHMIVL", JdeDataType.String, 2),
        new JdeField("IHMISM", "IHMISM", JdeDataType.String, 2),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHJOBN", "IHJOBN", JdeDataType.String, 20),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHMUPM", "IHMUPM", JdeDataType.Numeric),
        new JdeField("IHUPMT", "IHUPMT", JdeDataType.Numeric),
        new JdeField("IHVGCSF", "IHVGCSF", JdeDataType.String, 20),
        new JdeField("IHVGCOA", "IHVGCOA", JdeDataType.String, 20),
        new JdeField("IHVVTY", "IHVVTY", JdeDataType.String, 12),
        new JdeField("IHVVTC", "IHVVTC", JdeDataType.String, 20),
        new JdeField("IHPYWP", "IHPYWP", JdeDataType.String, 2),
        new JdeField("IHDTIPTF", "IHDTIPTF", JdeDataType.Numeric),
        new JdeField("IHDTIPTT", "IHDTIPTT", JdeDataType.Numeric),
        new JdeField("IHDTFPTF", "IHDTFPTF", JdeDataType.Numeric),
        new JdeField("IHDTFPTT", "IHDTFPTT", JdeDataType.Numeric),
        new JdeField("IHCLNU", "IHCLNU", JdeDataType.Numeric),
        new JdeField("IHCLTT", "IHCLTT", JdeDataType.String, 4),
        new JdeField("IHCLKO", "IHCLKO", JdeDataType.String, 10),
        new JdeField("IHGCSC", "IHGCSC", JdeDataType.String, 2),
        new JdeField("IHUKID", "IHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IHRETD", "IHRETD", JdeDataType.Numeric),
        new JdeField("IHFRETD", "IHFRETD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4822H_0", "Primary Key on IHUKID", new[] { "IHUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
