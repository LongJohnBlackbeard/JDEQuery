using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q10 - .
/// </summary>
public class F43Q10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEVNU.
        /// </summary>
        public const string EHEVNU = "EHEVNU";

        /// <summary>
        /// EHDCTO.
        /// </summary>
        public const string EHDCTO = "EHDCTO";

        /// <summary>
        /// EHKCOO.
        /// </summary>
        public const string EHKCOO = "EHKCOO";

        /// <summary>
        /// EHMCU.
        /// </summary>
        public const string EHMCU = "EHMCU";

        /// <summary>
        /// EHEVFT.
        /// </summary>
        public const string EHEVFT = "EHEVFT";

        /// <summary>
        /// EHEVTN.
        /// </summary>
        public const string EHEVTN = "EHEVTN";

        /// <summary>
        /// EHEVST.
        /// </summary>
        public const string EHEVST = "EHEVST";

        /// <summary>
        /// EHEPSX.
        /// </summary>
        public const string EHEPSX = "EHEPSX";

        /// <summary>
        /// EHEVSX.
        /// </summary>
        public const string EHEVSX = "EHEVSX";

        /// <summary>
        /// EHEHW.
        /// </summary>
        public const string EHEHW = "EHEHW";

        /// <summary>
        /// EHEPM.
        /// </summary>
        public const string EHEPM = "EHEPM";

        /// <summary>
        /// EHEETM.
        /// </summary>
        public const string EHEETM = "EHEETM";

        /// <summary>
        /// EHPTC.
        /// </summary>
        public const string EHPTC = "EHPTC";

        /// <summary>
        /// EHABV.
        /// </summary>
        public const string EHABV = "EHABV";

        /// <summary>
        /// EHHSLS.
        /// </summary>
        public const string EHHSLS = "EHHSLS";

        /// <summary>
        /// EHFHSL.
        /// </summary>
        public const string EHFHSL = "EHFHSL";

        /// <summary>
        /// EHCRDC.
        /// </summary>
        public const string EHCRDC = "EHCRDC";

        /// <summary>
        /// EHTX.
        /// </summary>
        public const string EHTX = "EHTX";

        /// <summary>
        /// EHTAX.
        /// </summary>
        public const string EHTAX = "EHTAX";

        /// <summary>
        /// EHOMCU.
        /// </summary>
        public const string EHOMCU = "EHOMCU";

        /// <summary>
        /// EHALKY.
        /// </summary>
        public const string EHALKY = "EHALKY";

        /// <summary>
        /// EHEDITXTS.
        /// </summary>
        public const string EHEDITXTS = "EHEDITXTS";

        /// <summary>
        /// EHOEDT.
        /// </summary>
        public const string EHOEDT = "EHOEDT";

        /// <summary>
        /// EHSEVT.
        /// </summary>
        public const string EHSEVT = "EHSEVT";

        /// <summary>
        /// EHBROAL.
        /// </summary>
        public const string EHBROAL = "EHBROAL";

        /// <summary>
        /// EHMBDA.
        /// </summary>
        public const string EHMBDA = "EHMBDA";

        /// <summary>
        /// EHORBY.
        /// </summary>
        public const string EHORBY = "EHORBY";

        /// <summary>
        /// EHALPH.
        /// </summary>
        public const string EHALPH = "EHALPH";

        /// <summary>
        /// EHPH3.
        /// </summary>
        public const string EHPH3 = "EHPH3";

        /// <summary>
        /// EHEMAL.
        /// </summary>
        public const string EHEMAL = "EHEMAL";

        /// <summary>
        /// EHMCEV.
        /// </summary>
        public const string EHMCEV = "EHMCEV";

        /// <summary>
        /// EHDBQW.
        /// </summary>
        public const string EHDBQW = "EHDBQW";

        /// <summary>
        /// EHDSPB.
        /// </summary>
        public const string EHDSPB = "EHDSPB";

        /// <summary>
        /// EHEDITRESP.
        /// </summary>
        public const string EHEDITRESP = "EHEDITRESP";

        /// <summary>
        /// EHDISABDS.
        /// </summary>
        public const string EHDISABDS = "EHDISABDS";

        /// <summary>
        /// EHSHOWDTLS.
        /// </summary>
        public const string EHSHOWDTLS = "EHSHOWDTLS";

        /// <summary>
        /// EHDISPBID.
        /// </summary>
        public const string EHDISPBID = "EHDISPBID";

        /// <summary>
        /// EHDISPTOTL.
        /// </summary>
        public const string EHDISPTOTL = "EHDISPTOTL";

        /// <summary>
        /// EHDISPQUES.
        /// </summary>
        public const string EHDISPQUES = "EHDISPQUES";

        /// <summary>
        /// EHCCUKID.
        /// </summary>
        public const string EHCCUKID = "EHCCUKID";

        /// <summary>
        /// EHRLQR.
        /// </summary>
        public const string EHRLQR = "EHRLQR";

        /// <summary>
        /// EHSIOB.
        /// </summary>
        public const string EHSIOB = "EHSIOB";

        /// <summary>
        /// EHDISBDHP.
        /// </summary>
        public const string EHDISBDHP = "EHDISBDHP";

        /// <summary>
        /// EHSCREVENT.
        /// </summary>
        public const string EHSCREVENT = "EHSCREVENT";

        /// <summary>
        /// EHBMBSP.
        /// </summary>
        public const string EHBMBSP = "EHBMBSP";

        /// <summary>
        /// EHCBORPO.
        /// </summary>
        public const string EHCBORPO = "EHCBORPO";

        /// <summary>
        /// EHINMG.
        /// </summary>
        public const string EHINMG = "EHINMG";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";

        /// <summary>
        /// EHCMDCDE.
        /// </summary>
        public const string EHCMDCDE = "EHCMDCDE";

        /// <summary>
        /// EHEVDS.
        /// </summary>
        public const string EHEVDS = "EHEVDS";

        /// <summary>
        /// EHAR1.
        /// </summary>
        public const string EHAR1 = "EHAR1";

        /// <summary>
        /// EHSHAN.
        /// </summary>
        public const string EHSHAN = "EHSHAN";

        /// <summary>
        /// EHTQW.
        /// </summary>
        public const string EHTQW = "EHTQW";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEVNU", "EHEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDCTO", "EHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EHKCOO", "EHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EHMCU", "EHMCU", JdeDataType.String, 24),
        new JdeField("EHEVFT", "EHEVFT", JdeDataType.String, 6),
        new JdeField("EHEVTN", "EHEVTN", JdeDataType.String, 50),
        new JdeField("EHEVST", "EHEVST", JdeDataType.String, 4),
        new JdeField("EHEPSX", "EHEPSX", JdeDataType.Date),
        new JdeField("EHEVSX", "EHEVSX", JdeDataType.Date),
        new JdeField("EHEHW", "EHEHW", JdeDataType.Numeric),
        new JdeField("EHEPM", "EHEPM", JdeDataType.String, 4),
        new JdeField("EHEETM", "EHEETM", JdeDataType.Date),
        new JdeField("EHPTC", "EHPTC", JdeDataType.String, 6),
        new JdeField("EHABV", "EHABV", JdeDataType.String, 2),
        new JdeField("EHHSLS", "EHHSLS", JdeDataType.Numeric),
        new JdeField("EHFHSL", "EHFHSL", JdeDataType.String, 2),
        new JdeField("EHCRDC", "EHCRDC", JdeDataType.String, 6),
        new JdeField("EHTX", "EHTX", JdeDataType.String, 2),
        new JdeField("EHTAX", "EHTAX", JdeDataType.String, 40),
        new JdeField("EHOMCU", "EHOMCU", JdeDataType.String, 24),
        new JdeField("EHALKY", "EHALKY", JdeDataType.String, 40),
        new JdeField("EHEDITXTS", "EHEDITXTS", JdeDataType.String, 2),
        new JdeField("EHOEDT", "EHOEDT", JdeDataType.Date),
        new JdeField("EHSEVT", "EHSEVT", JdeDataType.String, 2),
        new JdeField("EHBROAL", "EHBROAL", JdeDataType.String, 2),
        new JdeField("EHMBDA", "EHMBDA", JdeDataType.String, 2),
        new JdeField("EHORBY", "EHORBY", JdeDataType.String, 20),
        new JdeField("EHALPH", "EHALPH", JdeDataType.String, 80),
        new JdeField("EHPH3", "EHPH3", JdeDataType.String, 40),
        new JdeField("EHEMAL", "EHEMAL", JdeDataType.String, 512),
        new JdeField("EHMCEV", "EHMCEV", JdeDataType.String, 2),
        new JdeField("EHDBQW", "EHDBQW", JdeDataType.String, 2),
        new JdeField("EHDSPB", "EHDSPB", JdeDataType.String, 2),
        new JdeField("EHEDITRESP", "EHEDITRESP", JdeDataType.String, 2),
        new JdeField("EHDISABDS", "EHDISABDS", JdeDataType.String, 2),
        new JdeField("EHSHOWDTLS", "EHSHOWDTLS", JdeDataType.String, 2),
        new JdeField("EHDISPBID", "EHDISPBID", JdeDataType.String, 2),
        new JdeField("EHDISPTOTL", "EHDISPTOTL", JdeDataType.String, 2),
        new JdeField("EHDISPQUES", "EHDISPQUES", JdeDataType.String, 2),
        new JdeField("EHCCUKID", "EHCCUKID", JdeDataType.Numeric),
        new JdeField("EHRLQR", "EHRLQR", JdeDataType.String, 2),
        new JdeField("EHSIOB", "EHSIOB", JdeDataType.String, 2),
        new JdeField("EHDISBDHP", "EHDISBDHP", JdeDataType.String, 2),
        new JdeField("EHSCREVENT", "EHSCREVENT", JdeDataType.String, 2),
        new JdeField("EHBMBSP", "EHBMBSP", JdeDataType.String, 2),
        new JdeField("EHCBORPO", "EHCBORPO", JdeDataType.String, 4),
        new JdeField("EHINMG", "EHINMG", JdeDataType.String, 20),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric),
        new JdeField("EHCMDCDE", "EHCMDCDE", JdeDataType.String, 30),
        new JdeField("EHEVDS", "EHEVDS", JdeDataType.String, 110),
        new JdeField("EHAR1", "EHAR1", JdeDataType.String, 12),
        new JdeField("EHSHAN", "EHSHAN", JdeDataType.Numeric),
        new JdeField("EHTQW", "EHTQW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q10_0", "Primary Key on EHEVNU, EHDCTO, EHKCOO", new[] { "EHEVNU", "EHDCTO", "EHKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
