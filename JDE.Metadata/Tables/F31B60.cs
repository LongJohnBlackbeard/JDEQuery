using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B60 - .
/// </summary>
public class F31B60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTUKID.
        /// </summary>
        public const string OTUKID = "OTUKID";

        /// <summary>
        /// OTPALID.
        /// </summary>
        public const string OTPALID = "OTPALID";

        /// <summary>
        /// OTWVID.
        /// </summary>
        public const string OTWVID = "OTWVID";

        /// <summary>
        /// OTPWOPID.
        /// </summary>
        public const string OTPWOPID = "OTPWOPID";

        /// <summary>
        /// OTOTLID.
        /// </summary>
        public const string OTOTLID = "OTOTLID";

        /// <summary>
        /// OTOLTTF.
        /// </summary>
        public const string OTOLTTF = "OTOLTTF";

        /// <summary>
        /// OTICONCC.
        /// </summary>
        public const string OTICONCC = "OTICONCC";

        /// <summary>
        /// OTMMCU.
        /// </summary>
        public const string OTMMCU = "OTMMCU";

        /// <summary>
        /// OTWBLOTN.
        /// </summary>
        public const string OTWBLOTN = "OTWBLOTN";

        /// <summary>
        /// OTWBLQTY.
        /// </summary>
        public const string OTWBLQTY = "OTWBLQTY";

        /// <summary>
        /// OTLTUOM.
        /// </summary>
        public const string OTLTUOM = "OTLTUOM";

        /// <summary>
        /// OTWBID.
        /// </summary>
        public const string OTWBID = "OTWBID";

        /// <summary>
        /// OTMATYP.
        /// </summary>
        public const string OTMATYP = "OTMATYP";

        /// <summary>
        /// OTWISSC.
        /// </summary>
        public const string OTWISSC = "OTWISSC";

        /// <summary>
        /// OTWALOTN.
        /// </summary>
        public const string OTWALOTN = "OTWALOTN";

        /// <summary>
        /// OTLTQNTY.
        /// </summary>
        public const string OTLTQNTY = "OTLTQNTY";

        /// <summary>
        /// OTALTUOM.
        /// </summary>
        public const string OTALTUOM = "OTALTUOM";

        /// <summary>
        /// OTWABID.
        /// </summary>
        public const string OTWABID = "OTWABID";

        /// <summary>
        /// OTAMATYP.
        /// </summary>
        public const string OTAMATYP = "OTAMATYP";

        /// <summary>
        /// OTAWISSC.
        /// </summary>
        public const string OTAWISSC = "OTAWISSC";

        /// <summary>
        /// OTWOPN.
        /// </summary>
        public const string OTWOPN = "OTWOPN";

        /// <summary>
        /// OTWALOP.
        /// </summary>
        public const string OTWALOP = "OTWALOP";

        /// <summary>
        /// OTWCRTR.
        /// </summary>
        public const string OTWCRTR = "OTWCRTR";

        /// <summary>
        /// OTWH1.
        /// </summary>
        public const string OTWH1 = "OTWH1";

        /// <summary>
        /// OTWH2.
        /// </summary>
        public const string OTWH2 = "OTWH2";

        /// <summary>
        /// OTWH3.
        /// </summary>
        public const string OTWH3 = "OTWH3";

        /// <summary>
        /// OTWH4.
        /// </summary>
        public const string OTWH4 = "OTWH4";

        /// <summary>
        /// OTWH5.
        /// </summary>
        public const string OTWH5 = "OTWH5";

        /// <summary>
        /// OTWASDT.
        /// </summary>
        public const string OTWASDT = "OTWASDT";

        /// <summary>
        /// OTWAEDT.
        /// </summary>
        public const string OTWAEDT = "OTWAEDT";

        /// <summary>
        /// OTWSD.
        /// </summary>
        public const string OTWSD = "OTWSD";

        /// <summary>
        /// OTWOPYL.
        /// </summary>
        public const string OTWOPYL = "OTWOPYL";

        /// <summary>
        /// OTWCFGID.
        /// </summary>
        public const string OTWCFGID = "OTWCFGID";

        /// <summary>
        /// OTWCOPCD.
        /// </summary>
        public const string OTWCOPCD = "OTWCOPCD";

        /// <summary>
        /// OTWBOPID.
        /// </summary>
        public const string OTWBOPID = "OTWBOPID";

        /// <summary>
        /// OTWBOPCD.
        /// </summary>
        public const string OTWBOPCD = "OTWBOPCD";

        /// <summary>
        /// OTWVTY.
        /// </summary>
        public const string OTWVTY = "OTWVTY";

        /// <summary>
        /// OTWVNUM.
        /// </summary>
        public const string OTWVNUM = "OTWVNUM";

        /// <summary>
        /// OTLITM.
        /// </summary>
        public const string OTLITM = "OTLITM";

        /// <summary>
        /// OTITM.
        /// </summary>
        public const string OTITM = "OTITM";

        /// <summary>
        /// OTADDTQ.
        /// </summary>
        public const string OTADDTQ = "OTADDTQ";

        /// <summary>
        /// OTADDTU.
        /// </summary>
        public const string OTADDTU = "OTADDTU";

        /// <summary>
        /// OTLOTN.
        /// </summary>
        public const string OTLOTN = "OTLOTN";

        /// <summary>
        /// OTEV01.
        /// </summary>
        public const string OTEV01 = "OTEV01";

        /// <summary>
        /// OTWTSGL.
        /// </summary>
        public const string OTWTSGL = "OTWTSGL";

        /// <summary>
        /// OTWTOGL.
        /// </summary>
        public const string OTWTOGL = "OTWTOGL";

        /// <summary>
        /// OTWTMQ.
        /// </summary>
        public const string OTWTMQ = "OTWTMQ";

        /// <summary>
        /// OTWFTF.
        /// </summary>
        public const string OTWFTF = "OTWFTF";

        /// <summary>
        /// OTSATTN1.
        /// </summary>
        public const string OTSATTN1 = "OTSATTN1";

        /// <summary>
        /// OTSATTN2.
        /// </summary>
        public const string OTSATTN2 = "OTSATTN2";

        /// <summary>
        /// OTSATTN3.
        /// </summary>
        public const string OTSATTN3 = "OTSATTN3";

        /// <summary>
        /// OTSATTN4.
        /// </summary>
        public const string OTSATTN4 = "OTSATTN4";

        /// <summary>
        /// OTSATTN5.
        /// </summary>
        public const string OTSATTN5 = "OTSATTN5";

        /// <summary>
        /// OTSATTN6.
        /// </summary>
        public const string OTSATTN6 = "OTSATTN6";

        /// <summary>
        /// OTSATTN7.
        /// </summary>
        public const string OTSATTN7 = "OTSATTN7";

        /// <summary>
        /// OTSATTN8.
        /// </summary>
        public const string OTSATTN8 = "OTSATTN8";

        /// <summary>
        /// OTSATTN9.
        /// </summary>
        public const string OTSATTN9 = "OTSATTN9";

        /// <summary>
        /// OTSATTN10.
        /// </summary>
        public const string OTSATTN10 = "OTSATTN10";

        /// <summary>
        /// OTSATTN11.
        /// </summary>
        public const string OTSATTN11 = "OTSATTN11";

        /// <summary>
        /// OTSATTN12.
        /// </summary>
        public const string OTSATTN12 = "OTSATTN12";

        /// <summary>
        /// OTSATTN13.
        /// </summary>
        public const string OTSATTN13 = "OTSATTN13";

        /// <summary>
        /// OTSATTN14.
        /// </summary>
        public const string OTSATTN14 = "OTSATTN14";

        /// <summary>
        /// OTSATTN15.
        /// </summary>
        public const string OTSATTN15 = "OTSATTN15";

        /// <summary>
        /// OTSATTS16.
        /// </summary>
        public const string OTSATTS16 = "OTSATTS16";

        /// <summary>
        /// OTSATTS17.
        /// </summary>
        public const string OTSATTS17 = "OTSATTS17";

        /// <summary>
        /// OTSATTS18.
        /// </summary>
        public const string OTSATTS18 = "OTSATTS18";

        /// <summary>
        /// OTSATTS19.
        /// </summary>
        public const string OTSATTS19 = "OTSATTS19";

        /// <summary>
        /// OTSATTS20.
        /// </summary>
        public const string OTSATTS20 = "OTSATTS20";

        /// <summary>
        /// OTSATTS21.
        /// </summary>
        public const string OTSATTS21 = "OTSATTS21";

        /// <summary>
        /// OTSATTS22.
        /// </summary>
        public const string OTSATTS22 = "OTSATTS22";

        /// <summary>
        /// OTSATTS23.
        /// </summary>
        public const string OTSATTS23 = "OTSATTS23";

        /// <summary>
        /// OTSATTS24.
        /// </summary>
        public const string OTSATTS24 = "OTSATTS24";

        /// <summary>
        /// OTSATTS25.
        /// </summary>
        public const string OTSATTS25 = "OTSATTS25";

        /// <summary>
        /// OTINATTN1.
        /// </summary>
        public const string OTINATTN1 = "OTINATTN1";

        /// <summary>
        /// OTINATTN2.
        /// </summary>
        public const string OTINATTN2 = "OTINATTN2";

        /// <summary>
        /// OTINATTN3.
        /// </summary>
        public const string OTINATTN3 = "OTINATTN3";

        /// <summary>
        /// OTINATTN4.
        /// </summary>
        public const string OTINATTN4 = "OTINATTN4";

        /// <summary>
        /// OTINATTS5.
        /// </summary>
        public const string OTINATTS5 = "OTINATTS5";

        /// <summary>
        /// OTINATTS6.
        /// </summary>
        public const string OTINATTS6 = "OTINATTS6";

        /// <summary>
        /// OTINATTS7.
        /// </summary>
        public const string OTINATTS7 = "OTINATTS7";

        /// <summary>
        /// OTINATTS8.
        /// </summary>
        public const string OTINATTS8 = "OTINATTS8";

        /// <summary>
        /// OTINATTD9.
        /// </summary>
        public const string OTINATTD9 = "OTINATTD9";

        /// <summary>
        /// OTINATTD10.
        /// </summary>
        public const string OTINATTD10 = "OTINATTD10";

        /// <summary>
        /// OTINATTD11.
        /// </summary>
        public const string OTINATTD11 = "OTINATTD11";

        /// <summary>
        /// OTINATTD12.
        /// </summary>
        public const string OTINATTD12 = "OTINATTD12";

        /// <summary>
        /// OTWRF.
        /// </summary>
        public const string OTWRF = "OTWRF";

        /// <summary>
        /// OTWCD.
        /// </summary>
        public const string OTWCD = "OTWCD";

        /// <summary>
        /// OTWAB.
        /// </summary>
        public const string OTWAB = "OTWAB";

        /// <summary>
        /// OTWNUM.
        /// </summary>
        public const string OTWNUM = "OTWNUM";

        /// <summary>
        /// OTWMDT.
        /// </summary>
        public const string OTWMDT = "OTWMDT";

        /// <summary>
        /// OTURCD.
        /// </summary>
        public const string OTURCD = "OTURCD";

        /// <summary>
        /// OTURDT.
        /// </summary>
        public const string OTURDT = "OTURDT";

        /// <summary>
        /// OTURRF.
        /// </summary>
        public const string OTURRF = "OTURRF";

        /// <summary>
        /// OTURAT.
        /// </summary>
        public const string OTURAT = "OTURAT";

        /// <summary>
        /// OTURAB.
        /// </summary>
        public const string OTURAB = "OTURAB";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTJOBN.
        /// </summary>
        public const string OTJOBN = "OTJOBN";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTTDAY.
        /// </summary>
        public const string OTTDAY = "OTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTUKID", "OTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTPALID", "OTPALID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTWVID", "OTWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTPWOPID", "OTPWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTOTLID", "OTOTLID", JdeDataType.Numeric),
        new JdeField("OTOLTTF", "OTOLTTF", JdeDataType.String, 2),
        new JdeField("OTICONCC", "OTICONCC", JdeDataType.String, 20),
        new JdeField("OTMMCU", "OTMMCU", JdeDataType.String, 24),
        new JdeField("OTWBLOTN", "OTWBLOTN", JdeDataType.String, 60),
        new JdeField("OTWBLQTY", "OTWBLQTY", JdeDataType.Numeric),
        new JdeField("OTLTUOM", "OTLTUOM", JdeDataType.String, 6),
        new JdeField("OTWBID", "OTWBID", JdeDataType.String, 60),
        new JdeField("OTMATYP", "OTMATYP", JdeDataType.String, 8),
        new JdeField("OTWISSC", "OTWISSC", JdeDataType.String, 12),
        new JdeField("OTWALOTN", "OTWALOTN", JdeDataType.String, 60),
        new JdeField("OTLTQNTY", "OTLTQNTY", JdeDataType.Numeric),
        new JdeField("OTALTUOM", "OTALTUOM", JdeDataType.String, 6),
        new JdeField("OTWABID", "OTWABID", JdeDataType.String, 60),
        new JdeField("OTAMATYP", "OTAMATYP", JdeDataType.String, 8),
        new JdeField("OTAWISSC", "OTAWISSC", JdeDataType.String, 12),
        new JdeField("OTWOPN", "OTWOPN", JdeDataType.Numeric),
        new JdeField("OTWALOP", "OTWALOP", JdeDataType.String, 40),
        new JdeField("OTWCRTR", "OTWCRTR", JdeDataType.Numeric),
        new JdeField("OTWH1", "OTWH1", JdeDataType.String, 20),
        new JdeField("OTWH2", "OTWH2", JdeDataType.String, 20),
        new JdeField("OTWH3", "OTWH3", JdeDataType.String, 20),
        new JdeField("OTWH4", "OTWH4", JdeDataType.String, 20),
        new JdeField("OTWH5", "OTWH5", JdeDataType.String, 20),
        new JdeField("OTWASDT", "OTWASDT", JdeDataType.Date),
        new JdeField("OTWAEDT", "OTWAEDT", JdeDataType.Date),
        new JdeField("OTWSD", "OTWSD", JdeDataType.String, 60),
        new JdeField("OTWOPYL", "OTWOPYL", JdeDataType.Numeric),
        new JdeField("OTWCFGID", "OTWCFGID", JdeDataType.Numeric),
        new JdeField("OTWCOPCD", "OTWCOPCD", JdeDataType.String, 20),
        new JdeField("OTWBOPID", "OTWBOPID", JdeDataType.Numeric),
        new JdeField("OTWBOPCD", "OTWBOPCD", JdeDataType.String, 20),
        new JdeField("OTWVTY", "OTWVTY", JdeDataType.String, 2),
        new JdeField("OTWVNUM", "OTWVNUM", JdeDataType.String, 60),
        new JdeField("OTLITM", "OTLITM", JdeDataType.String, 50),
        new JdeField("OTITM", "OTITM", JdeDataType.Numeric),
        new JdeField("OTADDTQ", "OTADDTQ", JdeDataType.Numeric),
        new JdeField("OTADDTU", "OTADDTU", JdeDataType.String, 4),
        new JdeField("OTLOTN", "OTLOTN", JdeDataType.String, 60),
        new JdeField("OTEV01", "OTEV01", JdeDataType.String, 2),
        new JdeField("OTWTSGL", "OTWTSGL", JdeDataType.Numeric),
        new JdeField("OTWTOGL", "OTWTOGL", JdeDataType.Numeric),
        new JdeField("OTWTMQ", "OTWTMQ", JdeDataType.Numeric),
        new JdeField("OTWFTF", "OTWFTF", JdeDataType.String, 2),
        new JdeField("OTSATTN1", "OTSATTN1", JdeDataType.Numeric),
        new JdeField("OTSATTN2", "OTSATTN2", JdeDataType.Numeric),
        new JdeField("OTSATTN3", "OTSATTN3", JdeDataType.Numeric),
        new JdeField("OTSATTN4", "OTSATTN4", JdeDataType.Numeric),
        new JdeField("OTSATTN5", "OTSATTN5", JdeDataType.Numeric),
        new JdeField("OTSATTN6", "OTSATTN6", JdeDataType.Numeric),
        new JdeField("OTSATTN7", "OTSATTN7", JdeDataType.Numeric),
        new JdeField("OTSATTN8", "OTSATTN8", JdeDataType.Numeric),
        new JdeField("OTSATTN9", "OTSATTN9", JdeDataType.Numeric),
        new JdeField("OTSATTN10", "OTSATTN10", JdeDataType.Numeric),
        new JdeField("OTSATTN11", "OTSATTN11", JdeDataType.Numeric),
        new JdeField("OTSATTN12", "OTSATTN12", JdeDataType.Numeric),
        new JdeField("OTSATTN13", "OTSATTN13", JdeDataType.Numeric),
        new JdeField("OTSATTN14", "OTSATTN14", JdeDataType.Numeric),
        new JdeField("OTSATTN15", "OTSATTN15", JdeDataType.Numeric),
        new JdeField("OTSATTS16", "OTSATTS16", JdeDataType.String, 40),
        new JdeField("OTSATTS17", "OTSATTS17", JdeDataType.String, 40),
        new JdeField("OTSATTS18", "OTSATTS18", JdeDataType.String, 40),
        new JdeField("OTSATTS19", "OTSATTS19", JdeDataType.String, 40),
        new JdeField("OTSATTS20", "OTSATTS20", JdeDataType.String, 40),
        new JdeField("OTSATTS21", "OTSATTS21", JdeDataType.String, 40),
        new JdeField("OTSATTS22", "OTSATTS22", JdeDataType.String, 40),
        new JdeField("OTSATTS23", "OTSATTS23", JdeDataType.String, 40),
        new JdeField("OTSATTS24", "OTSATTS24", JdeDataType.String, 40),
        new JdeField("OTSATTS25", "OTSATTS25", JdeDataType.String, 40),
        new JdeField("OTINATTN1", "OTINATTN1", JdeDataType.Numeric),
        new JdeField("OTINATTN2", "OTINATTN2", JdeDataType.Numeric),
        new JdeField("OTINATTN3", "OTINATTN3", JdeDataType.Numeric),
        new JdeField("OTINATTN4", "OTINATTN4", JdeDataType.Numeric),
        new JdeField("OTINATTS5", "OTINATTS5", JdeDataType.String, 40),
        new JdeField("OTINATTS6", "OTINATTS6", JdeDataType.String, 40),
        new JdeField("OTINATTS7", "OTINATTS7", JdeDataType.String, 40),
        new JdeField("OTINATTS8", "OTINATTS8", JdeDataType.String, 40),
        new JdeField("OTINATTD9", "OTINATTD9", JdeDataType.Numeric),
        new JdeField("OTINATTD10", "OTINATTD10", JdeDataType.Numeric),
        new JdeField("OTINATTD11", "OTINATTD11", JdeDataType.Numeric),
        new JdeField("OTINATTD12", "OTINATTD12", JdeDataType.Numeric),
        new JdeField("OTWRF", "OTWRF", JdeDataType.String, 60),
        new JdeField("OTWCD", "OTWCD", JdeDataType.String, 6),
        new JdeField("OTWAB", "OTWAB", JdeDataType.Numeric),
        new JdeField("OTWNUM", "OTWNUM", JdeDataType.Numeric),
        new JdeField("OTWMDT", "OTWMDT", JdeDataType.Numeric),
        new JdeField("OTURCD", "OTURCD", JdeDataType.String, 4),
        new JdeField("OTURDT", "OTURDT", JdeDataType.Numeric),
        new JdeField("OTURRF", "OTURRF", JdeDataType.String, 30),
        new JdeField("OTURAT", "OTURAT", JdeDataType.Numeric),
        new JdeField("OTURAB", "OTURAB", JdeDataType.Numeric),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTJOBN", "OTJOBN", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTTDAY", "OTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B60_0", "Primary Key on OTUKID, OTPALID, OTWVID, OTPWOPID", new[] { "OTUKID", "OTPALID", "OTWVID", "OTPWOPID" }, isUnique: true, isPrimaryKey: true)
    };
}
