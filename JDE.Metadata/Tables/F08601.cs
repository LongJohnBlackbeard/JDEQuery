using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08601 - .
/// </summary>
public class F08601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HLCASE.
        /// </summary>
        public const string HLCASE = "HLCASE";

        /// <summary>
        /// HLCSTS.
        /// </summary>
        public const string HLCSTS = "HLCSTS";

        /// <summary>
        /// HLOSH.
        /// </summary>
        public const string HLOSH = "HLOSH";

        /// <summary>
        /// HLAN8.
        /// </summary>
        public const string HLAN8 = "HLAN8";

        /// <summary>
        /// HLJBCD.
        /// </summary>
        public const string HLJBCD = "HLJBCD";

        /// <summary>
        /// HLJBST.
        /// </summary>
        public const string HLJBST = "HLJBST";

        /// <summary>
        /// HLWCMP.
        /// </summary>
        public const string HLWCMP = "HLWCMP";

        /// <summary>
        /// HLWET.
        /// </summary>
        public const string HLWET = "HLWET";

        /// <summary>
        /// HLHMCO.
        /// </summary>
        public const string HLHMCO = "HLHMCO";

        /// <summary>
        /// HLHMCU.
        /// </summary>
        public const string HLHMCU = "HLHMCU";

        /// <summary>
        /// HLANPA.
        /// </summary>
        public const string HLANPA = "HLANPA";

        /// <summary>
        /// HLXAN8.
        /// </summary>
        public const string HLXAN8 = "HLXAN8";

        /// <summary>
        /// HLDIJ.
        /// </summary>
        public const string HLDIJ = "HLDIJ";

        /// <summary>
        /// HLTMAC.
        /// </summary>
        public const string HLTMAC = "HLTMAC";

        /// <summary>
        /// HLWKD.
        /// </summary>
        public const string HLWKD = "HLWKD";

        /// <summary>
        /// HLDRP.
        /// </summary>
        public const string HLDRP = "HLDRP";

        /// <summary>
        /// HLDCLO.
        /// </summary>
        public const string HLDCLO = "HLDCLO";

        /// <summary>
        /// HLDSIJ.
        /// </summary>
        public const string HLDSIJ = "HLDSIJ";

        /// <summary>
        /// HLIR.
        /// </summary>
        public const string HLIR = "HLIR";

        /// <summary>
        /// HLRSWA.
        /// </summary>
        public const string HLRSWA = "HLRSWA";

        /// <summary>
        /// HLDYSA.
        /// </summary>
        public const string HLDYSA = "HLDYSA";

        /// <summary>
        /// HLNDWA.
        /// </summary>
        public const string HLNDWA = "HLNDWA";

        /// <summary>
        /// HLNDAW.
        /// </summary>
        public const string HLNDAW = "HLNDAW";

        /// <summary>
        /// HLDDEC.
        /// </summary>
        public const string HLDDEC = "HLDDEC";

        /// <summary>
        /// HLDRT.
        /// </summary>
        public const string HLDRT = "HLDRT";

        /// <summary>
        /// HLESTB.
        /// </summary>
        public const string HLESTB = "HLESTB";

        /// <summary>
        /// HLCSFX.
        /// </summary>
        public const string HLCSFX = "HLCSFX";

        /// <summary>
        /// HLHH01.
        /// </summary>
        public const string HLHH01 = "HLHH01";

        /// <summary>
        /// HLHH02.
        /// </summary>
        public const string HLHH02 = "HLHH02";

        /// <summary>
        /// HLHH03.
        /// </summary>
        public const string HLHH03 = "HLHH03";

        /// <summary>
        /// HLHH04.
        /// </summary>
        public const string HLHH04 = "HLHH04";

        /// <summary>
        /// HLHH05.
        /// </summary>
        public const string HLHH05 = "HLHH05";

        /// <summary>
        /// HLHH06.
        /// </summary>
        public const string HLHH06 = "HLHH06";

        /// <summary>
        /// HLHH07.
        /// </summary>
        public const string HLHH07 = "HLHH07";

        /// <summary>
        /// HLHH08.
        /// </summary>
        public const string HLHH08 = "HLHH08";

        /// <summary>
        /// HLHH09.
        /// </summary>
        public const string HLHH09 = "HLHH09";

        /// <summary>
        /// HLHH10.
        /// </summary>
        public const string HLHH10 = "HLHH10";

        /// <summary>
        /// HLHH11.
        /// </summary>
        public const string HLHH11 = "HLHH11";

        /// <summary>
        /// HLHH12.
        /// </summary>
        public const string HLHH12 = "HLHH12";

        /// <summary>
        /// HLHH13.
        /// </summary>
        public const string HLHH13 = "HLHH13";

        /// <summary>
        /// HLHH14.
        /// </summary>
        public const string HLHH14 = "HLHH14";

        /// <summary>
        /// HLHH15.
        /// </summary>
        public const string HLHH15 = "HLHH15";

        /// <summary>
        /// HLCTR.
        /// </summary>
        public const string HLCTR = "HLCTR";

        /// <summary>
        /// HLONPRM.
        /// </summary>
        public const string HLONPRM = "HLONPRM";

        /// <summary>
        /// HLUSER.
        /// </summary>
        public const string HLUSER = "HLUSER";

        /// <summary>
        /// HLPID.
        /// </summary>
        public const string HLPID = "HLPID";

        /// <summary>
        /// HLUPMJ.
        /// </summary>
        public const string HLUPMJ = "HLUPMJ";

        /// <summary>
        /// HLJOBN.
        /// </summary>
        public const string HLJOBN = "HLJOBN";

        /// <summary>
        /// HLHHOSH.
        /// </summary>
        public const string HLHHOSH = "HLHHOSH";

        /// <summary>
        /// HLHHAGE.
        /// </summary>
        public const string HLHHAGE = "HLHHAGE";

        /// <summary>
        /// HLHHU18.
        /// </summary>
        public const string HLHHU18 = "HLHHU18";

        /// <summary>
        /// HLDOB.
        /// </summary>
        public const string HLDOB = "HLDOB";

        /// <summary>
        /// HLHHEMT.
        /// </summary>
        public const string HLHHEMT = "HLHHEMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HLCASE", "HLCASE", JdeDataType.Numeric, null, true, true),
        new JdeField("HLCSTS", "HLCSTS", JdeDataType.String, 4),
        new JdeField("HLOSH", "HLOSH", JdeDataType.String, 2),
        new JdeField("HLAN8", "HLAN8", JdeDataType.Numeric),
        new JdeField("HLJBCD", "HLJBCD", JdeDataType.String, 12),
        new JdeField("HLJBST", "HLJBST", JdeDataType.String, 8),
        new JdeField("HLWCMP", "HLWCMP", JdeDataType.String, 8),
        new JdeField("HLWET", "HLWET", JdeDataType.String, 2),
        new JdeField("HLHMCO", "HLHMCO", JdeDataType.String, 10),
        new JdeField("HLHMCU", "HLHMCU", JdeDataType.String, 24),
        new JdeField("HLANPA", "HLANPA", JdeDataType.Numeric),
        new JdeField("HLXAN8", "HLXAN8", JdeDataType.Numeric),
        new JdeField("HLDIJ", "HLDIJ", JdeDataType.Numeric),
        new JdeField("HLTMAC", "HLTMAC", JdeDataType.Numeric),
        new JdeField("HLWKD", "HLWKD", JdeDataType.String, 2),
        new JdeField("HLDRP", "HLDRP", JdeDataType.Numeric),
        new JdeField("HLDCLO", "HLDCLO", JdeDataType.Numeric),
        new JdeField("HLDSIJ", "HLDSIJ", JdeDataType.String, 80),
        new JdeField("HLIR", "HLIR", JdeDataType.String, 4),
        new JdeField("HLRSWA", "HLRSWA", JdeDataType.String, 2),
        new JdeField("HLDYSA", "HLDYSA", JdeDataType.String, 2),
        new JdeField("HLNDWA", "HLNDWA", JdeDataType.Numeric),
        new JdeField("HLNDAW", "HLNDAW", JdeDataType.Numeric),
        new JdeField("HLDDEC", "HLDDEC", JdeDataType.Numeric),
        new JdeField("HLDRT", "HLDRT", JdeDataType.Numeric),
        new JdeField("HLESTB", "HLESTB", JdeDataType.Numeric),
        new JdeField("HLCSFX", "HLCSFX", JdeDataType.Numeric),
        new JdeField("HLHH01", "HLHH01", JdeDataType.String, 6),
        new JdeField("HLHH02", "HLHH02", JdeDataType.String, 6),
        new JdeField("HLHH03", "HLHH03", JdeDataType.String, 6),
        new JdeField("HLHH04", "HLHH04", JdeDataType.String, 6),
        new JdeField("HLHH05", "HLHH05", JdeDataType.String, 6),
        new JdeField("HLHH06", "HLHH06", JdeDataType.String, 6),
        new JdeField("HLHH07", "HLHH07", JdeDataType.String, 6),
        new JdeField("HLHH08", "HLHH08", JdeDataType.String, 6),
        new JdeField("HLHH09", "HLHH09", JdeDataType.String, 6),
        new JdeField("HLHH10", "HLHH10", JdeDataType.String, 6),
        new JdeField("HLHH11", "HLHH11", JdeDataType.String, 6),
        new JdeField("HLHH12", "HLHH12", JdeDataType.String, 6),
        new JdeField("HLHH13", "HLHH13", JdeDataType.String, 6),
        new JdeField("HLHH14", "HLHH14", JdeDataType.String, 6),
        new JdeField("HLHH15", "HLHH15", JdeDataType.String, 6),
        new JdeField("HLCTR", "HLCTR", JdeDataType.String, 6),
        new JdeField("HLONPRM", "HLONPRM", JdeDataType.String, 2),
        new JdeField("HLUSER", "HLUSER", JdeDataType.String, 20),
        new JdeField("HLPID", "HLPID", JdeDataType.String, 20),
        new JdeField("HLUPMJ", "HLUPMJ", JdeDataType.Numeric),
        new JdeField("HLJOBN", "HLJOBN", JdeDataType.String, 20),
        new JdeField("HLHHOSH", "HLHHOSH", JdeDataType.String, 2),
        new JdeField("HLHHAGE", "HLHHAGE", JdeDataType.Numeric),
        new JdeField("HLHHU18", "HLHHU18", JdeDataType.String, 2),
        new JdeField("HLDOB", "HLDOB", JdeDataType.Numeric),
        new JdeField("HLHHEMT", "HLHHEMT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08601_0", "Primary Key on HLCASE", new[] { "HLCASE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08601_2", "Index on HLAN8, SYS_NC00054$", new[] { "HLAN8", "SYS_NC00054$" }),
        new JdeIndex("F08601_3", "Index on SYS_NC00054$, HLTMAC", new[] { "SYS_NC00054$", "HLTMAC" }),
        new JdeIndex("F08601_4", "Index on HLESTB, HLCASE", new[] { "HLESTB", "HLCASE" }),
        new JdeIndex("F08601_5", "Index on HLHMCU, HLCASE", new[] { "HLHMCU", "HLCASE" }),
        new JdeIndex("F08601_6", "Index on HLOSH, HLDIJ, HLESTB", new[] { "HLOSH", "HLDIJ", "HLESTB" })
    };
}
