using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I06 - .
/// </summary>
public class F42I06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OHDMCT.
        /// </summary>
        public const string OHDMCT = "OHDMCT";

        /// <summary>
        /// OHDMCS.
        /// </summary>
        public const string OHDMCS = "OHDMCS";

        /// <summary>
        /// OHCNUKID.
        /// </summary>
        public const string OHCNUKID = "OHCNUKID";

        /// <summary>
        /// OHDL01.
        /// </summary>
        public const string OHDL01 = "OHDL01";

        /// <summary>
        /// OHDL02.
        /// </summary>
        public const string OHDL02 = "OHDL02";

        /// <summary>
        /// OHDL03.
        /// </summary>
        public const string OHDL03 = "OHDL03";

        /// <summary>
        /// OHMCU.
        /// </summary>
        public const string OHMCU = "OHMCU";

        /// <summary>
        /// OHNWRN.
        /// </summary>
        public const string OHNWRN = "OHNWRN";

        /// <summary>
        /// OHAGRS.
        /// </summary>
        public const string OHAGRS = "OHAGRS";

        /// <summary>
        /// OHCMAN.
        /// </summary>
        public const string OHCMAN = "OHCMAN";

        /// <summary>
        /// OHCADM.
        /// </summary>
        public const string OHCADM = "OHCADM";

        /// <summary>
        /// OHPANM.
        /// </summary>
        public const string OHPANM = "OHPANM";

        /// <summary>
        /// OHCNTD.
        /// </summary>
        public const string OHCNTD = "OHCNTD";

        /// <summary>
        /// OHDMTC.
        /// </summary>
        public const string OHDMTC = "OHDMTC";

        /// <summary>
        /// OHDMPC.
        /// </summary>
        public const string OHDMPC = "OHDMPC";

        /// <summary>
        /// OHDMSC.
        /// </summary>
        public const string OHDMSC = "OHDMSC";

        /// <summary>
        /// OHEFTJ.
        /// </summary>
        public const string OHEFTJ = "OHEFTJ";

        /// <summary>
        /// OHEXDJ.
        /// </summary>
        public const string OHEXDJ = "OHEXDJ";

        /// <summary>
        /// OHAN8.
        /// </summary>
        public const string OHAN8 = "OHAN8";

        /// <summary>
        /// OHAAGM.
        /// </summary>
        public const string OHAAGM = "OHAAGM";

        /// <summary>
        /// OHAAGS.
        /// </summary>
        public const string OHAAGS = "OHAAGS";

        /// <summary>
        /// OHRAGM.
        /// </summary>
        public const string OHRAGM = "OHRAGM";

        /// <summary>
        /// OHRAGS.
        /// </summary>
        public const string OHRAGS = "OHRAGS";

        /// <summary>
        /// OHCAGM.
        /// </summary>
        public const string OHCAGM = "OHCAGM";

        /// <summary>
        /// OHCAGS.
        /// </summary>
        public const string OHCAGS = "OHCAGS";

        /// <summary>
        /// OHPAGM.
        /// </summary>
        public const string OHPAGM = "OHPAGM";

        /// <summary>
        /// OHPAGS.
        /// </summary>
        public const string OHPAGS = "OHPAGS";

        /// <summary>
        /// OHZD01.
        /// </summary>
        public const string OHZD01 = "OHZD01";

        /// <summary>
        /// OHZD02.
        /// </summary>
        public const string OHZD02 = "OHZD02";

        /// <summary>
        /// OHZD03.
        /// </summary>
        public const string OHZD03 = "OHZD03";

        /// <summary>
        /// OHZD04.
        /// </summary>
        public const string OHZD04 = "OHZD04";

        /// <summary>
        /// OHZD05.
        /// </summary>
        public const string OHZD05 = "OHZD05";

        /// <summary>
        /// OHZD06.
        /// </summary>
        public const string OHZD06 = "OHZD06";

        /// <summary>
        /// OHZD07.
        /// </summary>
        public const string OHZD07 = "OHZD07";

        /// <summary>
        /// OHZD08.
        /// </summary>
        public const string OHZD08 = "OHZD08";

        /// <summary>
        /// OHZD09.
        /// </summary>
        public const string OHZD09 = "OHZD09";

        /// <summary>
        /// OHZD10.
        /// </summary>
        public const string OHZD10 = "OHZD10";

        /// <summary>
        /// OHQEDT.
        /// </summary>
        public const string OHQEDT = "OHQEDT";

        /// <summary>
        /// OHCAND.
        /// </summary>
        public const string OHCAND = "OHCAND";

        /// <summary>
        /// OHCANR.
        /// </summary>
        public const string OHCANR = "OHCANR";

        /// <summary>
        /// OHUPGL.
        /// </summary>
        public const string OHUPGL = "OHUPGL";

        /// <summary>
        /// OHPRAS.
        /// </summary>
        public const string OHPRAS = "OHPRAS";

        /// <summary>
        /// OHCMOO.
        /// </summary>
        public const string OHCMOO = "OHCMOO";

        /// <summary>
        /// OHCNQY.
        /// </summary>
        public const string OHCNQY = "OHCNQY";

        /// <summary>
        /// OHTV01.
        /// </summary>
        public const string OHTV01 = "OHTV01";

        /// <summary>
        /// OHTV02.
        /// </summary>
        public const string OHTV02 = "OHTV02";

        /// <summary>
        /// OHTV03.
        /// </summary>
        public const string OHTV03 = "OHTV03";

        /// <summary>
        /// OHURCD.
        /// </summary>
        public const string OHURCD = "OHURCD";

        /// <summary>
        /// OHURDT.
        /// </summary>
        public const string OHURDT = "OHURDT";

        /// <summary>
        /// OHURAT.
        /// </summary>
        public const string OHURAT = "OHURAT";

        /// <summary>
        /// OHURAB.
        /// </summary>
        public const string OHURAB = "OHURAB";

        /// <summary>
        /// OHURRF.
        /// </summary>
        public const string OHURRF = "OHURRF";

        /// <summary>
        /// OHRPQT.
        /// </summary>
        public const string OHRPQT = "OHRPQT";

        /// <summary>
        /// OHQED3.
        /// </summary>
        public const string OHQED3 = "OHQED3";

        /// <summary>
        /// OHQED2.
        /// </summary>
        public const string OHQED2 = "OHQED2";

        /// <summary>
        /// OHAGTP.
        /// </summary>
        public const string OHAGTP = "OHAGTP";

        /// <summary>
        /// OHPOCUST.
        /// </summary>
        public const string OHPOCUST = "OHPOCUST";

        /// <summary>
        /// OHMLNM.
        /// </summary>
        public const string OHMLNM = "OHMLNM";

        /// <summary>
        /// OHACTON.
        /// </summary>
        public const string OHACTON = "OHACTON";

        /// <summary>
        /// OHSQNBR.
        /// </summary>
        public const string OHSQNBR = "OHSQNBR";

        /// <summary>
        /// OHACKLDT.
        /// </summary>
        public const string OHACKLDT = "OHACKLDT";

        /// <summary>
        /// OHRFC1.
        /// </summary>
        public const string OHRFC1 = "OHRFC1";

        /// <summary>
        /// OHRFC2.
        /// </summary>
        public const string OHRFC2 = "OHRFC2";

        /// <summary>
        /// OHRFC3.
        /// </summary>
        public const string OHRFC3 = "OHRFC3";

        /// <summary>
        /// OHRFC4.
        /// </summary>
        public const string OHRFC4 = "OHRFC4";

        /// <summary>
        /// OHFUTCHAR9.
        /// </summary>
        public const string OHFUTCHAR9 = "OHFUTCHAR9";

        /// <summary>
        /// OHFUCHAR1.
        /// </summary>
        public const string OHFUCHAR1 = "OHFUCHAR1";

        /// <summary>
        /// OHFUCHAR2.
        /// </summary>
        public const string OHFUCHAR2 = "OHFUCHAR2";

        /// <summary>
        /// OHFUNUM7.
        /// </summary>
        public const string OHFUNUM7 = "OHFUNUM7";

        /// <summary>
        /// OHFUNUM8.
        /// </summary>
        public const string OHFUNUM8 = "OHFUNUM8";

        /// <summary>
        /// OHFUNUM9.
        /// </summary>
        public const string OHFUNUM9 = "OHFUNUM9";

        /// <summary>
        /// OHFUTSTR7.
        /// </summary>
        public const string OHFUTSTR7 = "OHFUTSTR7";

        /// <summary>
        /// OHFUTSTR8.
        /// </summary>
        public const string OHFUTSTR8 = "OHFUTSTR8";

        /// <summary>
        /// OHFUTSTR9.
        /// </summary>
        public const string OHFUTSTR9 = "OHFUTSTR9";

        /// <summary>
        /// OHFUDT3.
        /// </summary>
        public const string OHFUDT3 = "OHFUDT3";

        /// <summary>
        /// OHFUDT13.
        /// </summary>
        public const string OHFUDT13 = "OHFUDT13";

        /// <summary>
        /// OHFUDT23.
        /// </summary>
        public const string OHFUDT23 = "OHFUDT23";

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
    }

    /// <inheritdoc />
    public override string TableName => "F42I06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OHDMCT", "OHDMCT", JdeDataType.String, 24, true, true),
        new JdeField("OHDMCS", "OHDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("OHCNUKID", "OHCNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OHDL01", "OHDL01", JdeDataType.String, 60),
        new JdeField("OHDL02", "OHDL02", JdeDataType.String, 60),
        new JdeField("OHDL03", "OHDL03", JdeDataType.String, 60),
        new JdeField("OHMCU", "OHMCU", JdeDataType.String, 24),
        new JdeField("OHNWRN", "OHNWRN", JdeDataType.String, 2),
        new JdeField("OHAGRS", "OHAGRS", JdeDataType.String, 2),
        new JdeField("OHCMAN", "OHCMAN", JdeDataType.Numeric),
        new JdeField("OHCADM", "OHCADM", JdeDataType.Numeric),
        new JdeField("OHPANM", "OHPANM", JdeDataType.String, 50),
        new JdeField("OHCNTD", "OHCNTD", JdeDataType.Numeric),
        new JdeField("OHDMTC", "OHDMTC", JdeDataType.String, 2),
        new JdeField("OHDMPC", "OHDMPC", JdeDataType.String, 6),
        new JdeField("OHDMSC", "OHDMSC", JdeDataType.String, 2),
        new JdeField("OHEFTJ", "OHEFTJ", JdeDataType.Numeric),
        new JdeField("OHEXDJ", "OHEXDJ", JdeDataType.Numeric),
        new JdeField("OHAN8", "OHAN8", JdeDataType.Numeric),
        new JdeField("OHAAGM", "OHAAGM", JdeDataType.String, 24),
        new JdeField("OHAAGS", "OHAAGS", JdeDataType.Numeric),
        new JdeField("OHRAGM", "OHRAGM", JdeDataType.String, 24),
        new JdeField("OHRAGS", "OHRAGS", JdeDataType.Numeric),
        new JdeField("OHCAGM", "OHCAGM", JdeDataType.String, 24),
        new JdeField("OHCAGS", "OHCAGS", JdeDataType.Numeric),
        new JdeField("OHPAGM", "OHPAGM", JdeDataType.String, 24),
        new JdeField("OHPAGS", "OHPAGS", JdeDataType.Numeric),
        new JdeField("OHZD01", "OHZD01", JdeDataType.String, 6),
        new JdeField("OHZD02", "OHZD02", JdeDataType.String, 6),
        new JdeField("OHZD03", "OHZD03", JdeDataType.String, 6),
        new JdeField("OHZD04", "OHZD04", JdeDataType.String, 6),
        new JdeField("OHZD05", "OHZD05", JdeDataType.String, 6),
        new JdeField("OHZD06", "OHZD06", JdeDataType.String, 6),
        new JdeField("OHZD07", "OHZD07", JdeDataType.String, 6),
        new JdeField("OHZD08", "OHZD08", JdeDataType.String, 6),
        new JdeField("OHZD09", "OHZD09", JdeDataType.String, 6),
        new JdeField("OHZD10", "OHZD10", JdeDataType.String, 6),
        new JdeField("OHQEDT", "OHQEDT", JdeDataType.String, 2),
        new JdeField("OHCAND", "OHCAND", JdeDataType.Numeric),
        new JdeField("OHCANR", "OHCANR", JdeDataType.String, 6),
        new JdeField("OHUPGL", "OHUPGL", JdeDataType.String, 2),
        new JdeField("OHPRAS", "OHPRAS", JdeDataType.String, 2),
        new JdeField("OHCMOO", "OHCMOO", JdeDataType.String, 2),
        new JdeField("OHCNQY", "OHCNQY", JdeDataType.String, 2),
        new JdeField("OHTV01", "OHTV01", JdeDataType.String, 2),
        new JdeField("OHTV02", "OHTV02", JdeDataType.String, 2),
        new JdeField("OHTV03", "OHTV03", JdeDataType.String, 2),
        new JdeField("OHURCD", "OHURCD", JdeDataType.String, 4),
        new JdeField("OHURDT", "OHURDT", JdeDataType.Numeric),
        new JdeField("OHURAT", "OHURAT", JdeDataType.Numeric),
        new JdeField("OHURAB", "OHURAB", JdeDataType.Numeric),
        new JdeField("OHURRF", "OHURRF", JdeDataType.String, 30),
        new JdeField("OHRPQT", "OHRPQT", JdeDataType.Numeric),
        new JdeField("OHQED3", "OHQED3", JdeDataType.String, 2),
        new JdeField("OHQED2", "OHQED2", JdeDataType.String, 2),
        new JdeField("OHAGTP", "OHAGTP", JdeDataType.String, 6),
        new JdeField("OHPOCUST", "OHPOCUST", JdeDataType.String, 50),
        new JdeField("OHMLNM", "OHMLNM", JdeDataType.String, 80),
        new JdeField("OHACTON", "OHACTON", JdeDataType.String, 2),
        new JdeField("OHSQNBR", "OHSQNBR", JdeDataType.Numeric),
        new JdeField("OHACKLDT", "OHACKLDT", JdeDataType.Date),
        new JdeField("OHRFC1", "OHRFC1", JdeDataType.String, 50),
        new JdeField("OHRFC2", "OHRFC2", JdeDataType.String, 50),
        new JdeField("OHRFC3", "OHRFC3", JdeDataType.String, 50),
        new JdeField("OHRFC4", "OHRFC4", JdeDataType.String, 50),
        new JdeField("OHFUTCHAR9", "OHFUTCHAR9", JdeDataType.String, 2),
        new JdeField("OHFUCHAR1", "OHFUCHAR1", JdeDataType.String, 2),
        new JdeField("OHFUCHAR2", "OHFUCHAR2", JdeDataType.String, 2),
        new JdeField("OHFUNUM7", "OHFUNUM7", JdeDataType.Numeric),
        new JdeField("OHFUNUM8", "OHFUNUM8", JdeDataType.Numeric),
        new JdeField("OHFUNUM9", "OHFUNUM9", JdeDataType.Numeric),
        new JdeField("OHFUTSTR7", "OHFUTSTR7", JdeDataType.String, 100),
        new JdeField("OHFUTSTR8", "OHFUTSTR8", JdeDataType.String, 100),
        new JdeField("OHFUTSTR9", "OHFUTSTR9", JdeDataType.String, 100),
        new JdeField("OHFUDT3", "OHFUDT3", JdeDataType.Numeric),
        new JdeField("OHFUDT13", "OHFUDT13", JdeDataType.Numeric),
        new JdeField("OHFUDT23", "OHFUDT23", JdeDataType.Numeric),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHJOBN", "OHJOBN", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHTDAY", "OHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I06_0", "Primary Key on OHDMCT, OHDMCS, OHCNUKID", new[] { "OHDMCT", "OHDMCS", "OHCNUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
