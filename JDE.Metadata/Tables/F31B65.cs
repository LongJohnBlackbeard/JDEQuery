using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B65 - .
/// </summary>
public class F31B65 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHWOPID.
        /// </summary>
        public const string OHWOPID = "OHWOPID";

        /// <summary>
        /// OHWOPN.
        /// </summary>
        public const string OHWOPN = "OHWOPN";

        /// <summary>
        /// OHWDC.
        /// </summary>
        public const string OHWDC = "OHWDC";

        /// <summary>
        /// OHMMCU.
        /// </summary>
        public const string OHMMCU = "OHMMCU";

        /// <summary>
        /// OHWDOCO.
        /// </summary>
        public const string OHWDOCO = "OHWDOCO";

        /// <summary>
        /// OHWCFGID.
        /// </summary>
        public const string OHWCFGID = "OHWCFGID";

        /// <summary>
        /// OHWOPST.
        /// </summary>
        public const string OHWOPST = "OHWOPST";

        /// <summary>
        /// OHWCRTR.
        /// </summary>
        public const string OHWCRTR = "OHWCRTR";

        /// <summary>
        /// OHWOPYL.
        /// </summary>
        public const string OHWOPYL = "OHWOPYL";

        /// <summary>
        /// OHWSDT.
        /// </summary>
        public const string OHWSDT = "OHWSDT";

        /// <summary>
        /// OHWEDT.
        /// </summary>
        public const string OHWEDT = "OHWEDT";

        /// <summary>
        /// OHWDUR.
        /// </summary>
        public const string OHWDUR = "OHWDUR";

        /// <summary>
        /// OHWUOMT.
        /// </summary>
        public const string OHWUOMT = "OHWUOMT";

        /// <summary>
        /// OHWASDT.
        /// </summary>
        public const string OHWASDT = "OHWASDT";

        /// <summary>
        /// OHWAEDT.
        /// </summary>
        public const string OHWAEDT = "OHWAEDT";

        /// <summary>
        /// OHWADUR.
        /// </summary>
        public const string OHWADUR = "OHWADUR";

        /// <summary>
        /// OHINSTMET.
        /// </summary>
        public const string OHINSTMET = "OHINSTMET";

        /// <summary>
        /// OHDISTMET.
        /// </summary>
        public const string OHDISTMET = "OHDISTMET";

        /// <summary>
        /// OHWPSD.
        /// </summary>
        public const string OHWPSD = "OHWPSD";

        /// <summary>
        /// OHWPAD.
        /// </summary>
        public const string OHWPAD = "OHWPAD";

        /// <summary>
        /// OHWSBDV.
        /// </summary>
        public const string OHWSBDV = "OHWSBDV";

        /// <summary>
        /// OHWH1.
        /// </summary>
        public const string OHWH1 = "OHWH1";

        /// <summary>
        /// OHWH2.
        /// </summary>
        public const string OHWH2 = "OHWH2";

        /// <summary>
        /// OHWH3.
        /// </summary>
        public const string OHWH3 = "OHWH3";

        /// <summary>
        /// OHWH4.
        /// </summary>
        public const string OHWH4 = "OHWH4";

        /// <summary>
        /// OHWH5.
        /// </summary>
        public const string OHWH5 = "OHWH5";

        /// <summary>
        /// OHEAURST1.
        /// </summary>
        public const string OHEAURST1 = "OHEAURST1";

        /// <summary>
        /// OHEAURST2.
        /// </summary>
        public const string OHEAURST2 = "OHEAURST2";

        /// <summary>
        /// OHEAURST3.
        /// </summary>
        public const string OHEAURST3 = "OHEAURST3";

        /// <summary>
        /// OHEAURST4.
        /// </summary>
        public const string OHEAURST4 = "OHEAURST4";

        /// <summary>
        /// OHEAURST5.
        /// </summary>
        public const string OHEAURST5 = "OHEAURST5";

        /// <summary>
        /// OHWSD.
        /// </summary>
        public const string OHWSD = "OHWSD";

        /// <summary>
        /// OHWALOP.
        /// </summary>
        public const string OHWALOP = "OHWALOP";

        /// <summary>
        /// OHWCDT.
        /// </summary>
        public const string OHWCDT = "OHWCDT";

        /// <summary>
        /// OHWRI.
        /// </summary>
        public const string OHWRI = "OHWRI";

        /// <summary>
        /// OHWSRC.
        /// </summary>
        public const string OHWSRC = "OHWSRC";

        /// <summary>
        /// OHWOPRC.
        /// </summary>
        public const string OHWOPRC = "OHWOPRC";

        /// <summary>
        /// OHWTOGL.
        /// </summary>
        public const string OHWTOGL = "OHWTOGL";

        /// <summary>
        /// OHWTSGL.
        /// </summary>
        public const string OHWTSGL = "OHWTSGL";

        /// <summary>
        /// OHWTMQ.
        /// </summary>
        public const string OHWTMQ = "OHWTMQ";

        /// <summary>
        /// OHWPOPID.
        /// </summary>
        public const string OHWPOPID = "OHWPOPID";

        /// <summary>
        /// OHWRLOPF.
        /// </summary>
        public const string OHWRLOPF = "OHWRLOPF";

        /// <summary>
        /// OHWOPRVF.
        /// </summary>
        public const string OHWOPRVF = "OHWOPRVF";

        /// <summary>
        /// OHWSGTCHGF.
        /// </summary>
        public const string OHWSGTCHGF = "OHWSGTCHGF";

        /// <summary>
        /// OHWJOBN.
        /// </summary>
        public const string OHWJOBN = "OHWJOBN";

        /// <summary>
        /// OHWTI.
        /// </summary>
        public const string OHWTI = "OHWTI";

        /// <summary>
        /// OHWEID.
        /// </summary>
        public const string OHWEID = "OHWEID";

        /// <summary>
        /// OHWAB.
        /// </summary>
        public const string OHWAB = "OHWAB";

        /// <summary>
        /// OHWMDT.
        /// </summary>
        public const string OHWMDT = "OHWMDT";

        /// <summary>
        /// OHWNUM.
        /// </summary>
        public const string OHWNUM = "OHWNUM";

        /// <summary>
        /// OHWCD.
        /// </summary>
        public const string OHWCD = "OHWCD";

        /// <summary>
        /// OHWRF.
        /// </summary>
        public const string OHWRF = "OHWRF";

        /// <summary>
        /// OHUSER.
        /// </summary>
        public const string OHUSER = "OHUSER";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";

        /// <summary>
        /// OHJOBN.
        /// </summary>
        public const string OHJOBN = "OHJOBN";

        /// <summary>
        /// OHUPMJ.
        /// </summary>
        public const string OHUPMJ = "OHUPMJ";

        /// <summary>
        /// OHTDAY.
        /// </summary>
        public const string OHTDAY = "OHTDAY";

        /// <summary>
        /// OHCMATYPE.
        /// </summary>
        public const string OHCMATYPE = "OHCMATYPE";

        /// <summary>
        /// OHWAWOR.
        /// </summary>
        public const string OHWAWOR = "OHWAWOR";

        /// <summary>
        /// OHDGL.
        /// </summary>
        public const string OHDGL = "OHDGL";

        /// <summary>
        /// OHWADDORC.
        /// </summary>
        public const string OHWADDORC = "OHWADDORC";

        /// <summary>
        /// OHWADDCRC.
        /// </summary>
        public const string OHWADDCRC = "OHWADDCRC";

        /// <summary>
        /// OHWTBID.
        /// </summary>
        public const string OHWTBID = "OHWTBID";

        /// <summary>
        /// OHPRCPTF.
        /// </summary>
        public const string OHPRCPTF = "OHPRCPTF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B65";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHWOPID", "OHWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OHWOPN", "OHWOPN", JdeDataType.Numeric),
        new JdeField("OHWDC", "OHWDC", JdeDataType.Numeric),
        new JdeField("OHMMCU", "OHMMCU", JdeDataType.String, 24),
        new JdeField("OHWDOCO", "OHWDOCO", JdeDataType.Numeric),
        new JdeField("OHWCFGID", "OHWCFGID", JdeDataType.Numeric),
        new JdeField("OHWOPST", "OHWOPST", JdeDataType.String, 20),
        new JdeField("OHWCRTR", "OHWCRTR", JdeDataType.Numeric),
        new JdeField("OHWOPYL", "OHWOPYL", JdeDataType.Numeric),
        new JdeField("OHWSDT", "OHWSDT", JdeDataType.Date),
        new JdeField("OHWEDT", "OHWEDT", JdeDataType.Date),
        new JdeField("OHWDUR", "OHWDUR", JdeDataType.Numeric),
        new JdeField("OHWUOMT", "OHWUOMT", JdeDataType.String, 2),
        new JdeField("OHWASDT", "OHWASDT", JdeDataType.Date),
        new JdeField("OHWAEDT", "OHWAEDT", JdeDataType.Date),
        new JdeField("OHWADUR", "OHWADUR", JdeDataType.Numeric),
        new JdeField("OHINSTMET", "OHINSTMET", JdeDataType.String, 2),
        new JdeField("OHDISTMET", "OHDISTMET", JdeDataType.String, 2),
        new JdeField("OHWPSD", "OHWPSD", JdeDataType.String, 2),
        new JdeField("OHWPAD", "OHWPAD", JdeDataType.String, 2),
        new JdeField("OHWSBDV", "OHWSBDV", JdeDataType.String, 2),
        new JdeField("OHWH1", "OHWH1", JdeDataType.String, 20),
        new JdeField("OHWH2", "OHWH2", JdeDataType.String, 20),
        new JdeField("OHWH3", "OHWH3", JdeDataType.String, 20),
        new JdeField("OHWH4", "OHWH4", JdeDataType.String, 20),
        new JdeField("OHWH5", "OHWH5", JdeDataType.String, 20),
        new JdeField("OHEAURST1", "OHEAURST1", JdeDataType.String, 10),
        new JdeField("OHEAURST2", "OHEAURST2", JdeDataType.String, 10),
        new JdeField("OHEAURST3", "OHEAURST3", JdeDataType.String, 30),
        new JdeField("OHEAURST4", "OHEAURST4", JdeDataType.String, 30),
        new JdeField("OHEAURST5", "OHEAURST5", JdeDataType.String, 30),
        new JdeField("OHWSD", "OHWSD", JdeDataType.String, 60),
        new JdeField("OHWALOP", "OHWALOP", JdeDataType.String, 40),
        new JdeField("OHWCDT", "OHWCDT", JdeDataType.Date),
        new JdeField("OHWRI", "OHWRI", JdeDataType.String, 2),
        new JdeField("OHWSRC", "OHWSRC", JdeDataType.String, 60),
        new JdeField("OHWOPRC", "OHWOPRC", JdeDataType.String, 60),
        new JdeField("OHWTOGL", "OHWTOGL", JdeDataType.Numeric),
        new JdeField("OHWTSGL", "OHWTSGL", JdeDataType.Numeric),
        new JdeField("OHWTMQ", "OHWTMQ", JdeDataType.Numeric),
        new JdeField("OHWPOPID", "OHWPOPID", JdeDataType.Numeric),
        new JdeField("OHWRLOPF", "OHWRLOPF", JdeDataType.String, 2),
        new JdeField("OHWOPRVF", "OHWOPRVF", JdeDataType.String, 2),
        new JdeField("OHWSGTCHGF", "OHWSGTCHGF", JdeDataType.String, 2),
        new JdeField("OHWJOBN", "OHWJOBN", JdeDataType.Numeric),
        new JdeField("OHWTI", "OHWTI", JdeDataType.String, 2),
        new JdeField("OHWEID", "OHWEID", JdeDataType.String, 20),
        new JdeField("OHWAB", "OHWAB", JdeDataType.Numeric),
        new JdeField("OHWMDT", "OHWMDT", JdeDataType.Numeric),
        new JdeField("OHWNUM", "OHWNUM", JdeDataType.Numeric),
        new JdeField("OHWCD", "OHWCD", JdeDataType.String, 6),
        new JdeField("OHWRF", "OHWRF", JdeDataType.String, 60),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHJOBN", "OHJOBN", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHTDAY", "OHTDAY", JdeDataType.Numeric),
        new JdeField("OHCMATYPE", "OHCMATYPE", JdeDataType.String, 8),
        new JdeField("OHWAWOR", "OHWAWOR", JdeDataType.String, 40),
        new JdeField("OHDGL", "OHDGL", JdeDataType.Numeric),
        new JdeField("OHWADDORC", "OHWADDORC", JdeDataType.String, 60),
        new JdeField("OHWADDCRC", "OHWADDCRC", JdeDataType.String, 60),
        new JdeField("OHWTBID", "OHWTBID", JdeDataType.Numeric),
        new JdeField("OHPRCPTF", "OHPRCPTF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B65_0", "Primary Key on OHWOPID", new[] { "OHWOPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B65_2", "Index on SYS_NC00065$", new[] { "SYS_NC00065$" }),
        new JdeIndex("F31B65_3", "Index on OHWDC", new[] { "OHWDC" }),
        new JdeIndex("F31B65_4", "Index on OHWJOBN, OHWOPID", new[] { "OHWJOBN", "OHWOPID" }),
        new JdeIndex("F31B65_5", "Index on OHWPOPID, OHWOPID", new[] { "OHWPOPID", "OHWOPID" }),
        new JdeIndex("F31B65_6", "Index on OHWDOCO, OHWOPID", new[] { "OHWDOCO", "OHWOPID" }),
        new JdeIndex("F31B65_7", "Index on OHWDOCO, OHMMCU, OHWASDT, OHWOPID", new[] { "OHWDOCO", "OHMMCU", "OHWASDT", "OHWOPID" }),
        new JdeIndex("F31B65_8", "Index on OHMMCU, SYS_NC00065$", new[] { "OHMMCU", "SYS_NC00065$" })
    };
}
