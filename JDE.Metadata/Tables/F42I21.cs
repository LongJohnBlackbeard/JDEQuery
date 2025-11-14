using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I21 - .
/// </summary>
public class F42I21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODDMCT.
        /// </summary>
        public const string ODDMCT = "ODDMCT";

        /// <summary>
        /// ODDMCS.
        /// </summary>
        public const string ODDMCS = "ODDMCS";

        /// <summary>
        /// ODSEQ.
        /// </summary>
        public const string ODSEQ = "ODSEQ";

        /// <summary>
        /// ODAGTP.
        /// </summary>
        public const string ODAGTP = "ODAGTP";

        /// <summary>
        /// ODCYNUM.
        /// </summary>
        public const string ODCYNUM = "ODCYNUM";

        /// <summary>
        /// ODITM.
        /// </summary>
        public const string ODITM = "ODITM";

        /// <summary>
        /// ODLITM.
        /// </summary>
        public const string ODLITM = "ODLITM";

        /// <summary>
        /// ODAN8.
        /// </summary>
        public const string ODAN8 = "ODAN8";

        /// <summary>
        /// ODSHAN.
        /// </summary>
        public const string ODSHAN = "ODSHAN";

        /// <summary>
        /// ODMCU.
        /// </summary>
        public const string ODMCU = "ODMCU";

        /// <summary>
        /// ODLOCN.
        /// </summary>
        public const string ODLOCN = "ODLOCN";

        /// <summary>
        /// ODOLTY.
        /// </summary>
        public const string ODOLTY = "ODOLTY";

        /// <summary>
        /// ODLOTN.
        /// </summary>
        public const string ODLOTN = "ODLOTN";

        /// <summary>
        /// ODTQOH.
        /// </summary>
        public const string ODTQOH = "ODTQOH";

        /// <summary>
        /// ODSQOH.
        /// </summary>
        public const string ODSQOH = "ODSQOH";

        /// <summary>
        /// ODTAOH.
        /// </summary>
        public const string ODTAOH = "ODTAOH";

        /// <summary>
        /// ODTQCT.
        /// </summary>
        public const string ODTQCT = "ODTQCT";

        /// <summary>
        /// ODSQCT.
        /// </summary>
        public const string ODSQCT = "ODSQCT";

        /// <summary>
        /// ODTACT.
        /// </summary>
        public const string ODTACT = "ODTACT";

        /// <summary>
        /// ODUNCS.
        /// </summary>
        public const string ODUNCS = "ODUNCS";

        /// <summary>
        /// ODUOM1.
        /// </summary>
        public const string ODUOM1 = "ODUOM1";

        /// <summary>
        /// ODUOM2.
        /// </summary>
        public const string ODUOM2 = "ODUOM2";

        /// <summary>
        /// ODCNTJ.
        /// </summary>
        public const string ODCNTJ = "ODCNTJ";

        /// <summary>
        /// ODCNTB.
        /// </summary>
        public const string ODCNTB = "ODCNTB";

        /// <summary>
        /// ODACTCD.
        /// </summary>
        public const string ODACTCD = "ODACTCD";

        /// <summary>
        /// ODKITS.
        /// </summary>
        public const string ODKITS = "ODKITS";

        /// <summary>
        /// ODKITID.
        /// </summary>
        public const string ODKITID = "ODKITID";

        /// <summary>
        /// ODKITDIRTY.
        /// </summary>
        public const string ODKITDIRTY = "ODKITDIRTY";

        /// <summary>
        /// ODRLIT.
        /// </summary>
        public const string ODRLIT = "ODRLIT";

        /// <summary>
        /// ODKTLN.
        /// </summary>
        public const string ODKTLN = "ODKTLN";

        /// <summary>
        /// ODCPNT.
        /// </summary>
        public const string ODCPNT = "ODCPNT";

        /// <summary>
        /// ODRKIT.
        /// </summary>
        public const string ODRKIT = "ODRKIT";

        /// <summary>
        /// ODKTP.
        /// </summary>
        public const string ODKTP = "ODKTP";

        /// <summary>
        /// ODFUCHAR31.
        /// </summary>
        public const string ODFUCHAR31 = "ODFUCHAR31";

        /// <summary>
        /// ODFUCHAR32.
        /// </summary>
        public const string ODFUCHAR32 = "ODFUCHAR32";

        /// <summary>
        /// ODFUCHAR33.
        /// </summary>
        public const string ODFUCHAR33 = "ODFUCHAR33";

        /// <summary>
        /// ODFUNUM31.
        /// </summary>
        public const string ODFUNUM31 = "ODFUNUM31";

        /// <summary>
        /// ODFUNUM32.
        /// </summary>
        public const string ODFUNUM32 = "ODFUNUM32";

        /// <summary>
        /// ODFUNUM33.
        /// </summary>
        public const string ODFUNUM33 = "ODFUNUM33";

        /// <summary>
        /// ODFUTSTR31.
        /// </summary>
        public const string ODFUTSTR31 = "ODFUTSTR31";

        /// <summary>
        /// ODFUTSTR32.
        /// </summary>
        public const string ODFUTSTR32 = "ODFUTSTR32";

        /// <summary>
        /// ODFUTSTR33.
        /// </summary>
        public const string ODFUTSTR33 = "ODFUTSTR33";

        /// <summary>
        /// ODFUDT51.
        /// </summary>
        public const string ODFUDT51 = "ODFUDT51";

        /// <summary>
        /// ODFUDT52.
        /// </summary>
        public const string ODFUDT52 = "ODFUDT52";

        /// <summary>
        /// ODFUDT53.
        /// </summary>
        public const string ODFUDT53 = "ODFUDT53";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODJOBN.
        /// </summary>
        public const string ODJOBN = "ODJOBN";

        /// <summary>
        /// ODUPMJ.
        /// </summary>
        public const string ODUPMJ = "ODUPMJ";

        /// <summary>
        /// ODTDAY.
        /// </summary>
        public const string ODTDAY = "ODTDAY";

        /// <summary>
        /// ODURAT.
        /// </summary>
        public const string ODURAT = "ODURAT";

        /// <summary>
        /// ODURCD.
        /// </summary>
        public const string ODURCD = "ODURCD";

        /// <summary>
        /// ODURDT.
        /// </summary>
        public const string ODURDT = "ODURDT";

        /// <summary>
        /// ODURAB.
        /// </summary>
        public const string ODURAB = "ODURAB";

        /// <summary>
        /// ODURRF.
        /// </summary>
        public const string ODURRF = "ODURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODDMCT", "ODDMCT", JdeDataType.String, 24, true, true),
        new JdeField("ODDMCS", "ODDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("ODSEQ", "ODSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ODAGTP", "ODAGTP", JdeDataType.String, 6),
        new JdeField("ODCYNUM", "ODCYNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("ODITM", "ODITM", JdeDataType.Numeric),
        new JdeField("ODLITM", "ODLITM", JdeDataType.String, 50, true, true),
        new JdeField("ODAN8", "ODAN8", JdeDataType.Numeric),
        new JdeField("ODSHAN", "ODSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("ODMCU", "ODMCU", JdeDataType.String, 24, true, true),
        new JdeField("ODLOCN", "ODLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ODOLTY", "ODOLTY", JdeDataType.String, 6),
        new JdeField("ODLOTN", "ODLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ODTQOH", "ODTQOH", JdeDataType.Numeric),
        new JdeField("ODSQOH", "ODSQOH", JdeDataType.Numeric),
        new JdeField("ODTAOH", "ODTAOH", JdeDataType.Numeric),
        new JdeField("ODTQCT", "ODTQCT", JdeDataType.Numeric),
        new JdeField("ODSQCT", "ODSQCT", JdeDataType.Numeric),
        new JdeField("ODTACT", "ODTACT", JdeDataType.Numeric),
        new JdeField("ODUNCS", "ODUNCS", JdeDataType.Numeric),
        new JdeField("ODUOM1", "ODUOM1", JdeDataType.String, 4),
        new JdeField("ODUOM2", "ODUOM2", JdeDataType.String, 4),
        new JdeField("ODCNTJ", "ODCNTJ", JdeDataType.Numeric),
        new JdeField("ODCNTB", "ODCNTB", JdeDataType.String, 20),
        new JdeField("ODACTCD", "ODACTCD", JdeDataType.Numeric),
        new JdeField("ODKITS", "ODKITS", JdeDataType.String, 2),
        new JdeField("ODKITID", "ODKITID", JdeDataType.Numeric),
        new JdeField("ODKITDIRTY", "ODKITDIRTY", JdeDataType.String, 2),
        new JdeField("ODRLIT", "ODRLIT", JdeDataType.String, 16),
        new JdeField("ODKTLN", "ODKTLN", JdeDataType.Numeric),
        new JdeField("ODCPNT", "ODCPNT", JdeDataType.Numeric),
        new JdeField("ODRKIT", "ODRKIT", JdeDataType.Numeric),
        new JdeField("ODKTP", "ODKTP", JdeDataType.Numeric),
        new JdeField("ODFUCHAR31", "ODFUCHAR31", JdeDataType.String, 2),
        new JdeField("ODFUCHAR32", "ODFUCHAR32", JdeDataType.String, 2),
        new JdeField("ODFUCHAR33", "ODFUCHAR33", JdeDataType.String, 2),
        new JdeField("ODFUNUM31", "ODFUNUM31", JdeDataType.Numeric),
        new JdeField("ODFUNUM32", "ODFUNUM32", JdeDataType.Numeric),
        new JdeField("ODFUNUM33", "ODFUNUM33", JdeDataType.Numeric),
        new JdeField("ODFUTSTR31", "ODFUTSTR31", JdeDataType.String, 100),
        new JdeField("ODFUTSTR32", "ODFUTSTR32", JdeDataType.String, 100),
        new JdeField("ODFUTSTR33", "ODFUTSTR33", JdeDataType.String, 100),
        new JdeField("ODFUDT51", "ODFUDT51", JdeDataType.Numeric),
        new JdeField("ODFUDT52", "ODFUDT52", JdeDataType.Numeric),
        new JdeField("ODFUDT53", "ODFUDT53", JdeDataType.Numeric),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODJOBN", "ODJOBN", JdeDataType.String, 20),
        new JdeField("ODUPMJ", "ODUPMJ", JdeDataType.Numeric),
        new JdeField("ODTDAY", "ODTDAY", JdeDataType.Numeric),
        new JdeField("ODURAT", "ODURAT", JdeDataType.Numeric),
        new JdeField("ODURCD", "ODURCD", JdeDataType.String, 4),
        new JdeField("ODURDT", "ODURDT", JdeDataType.Numeric),
        new JdeField("ODURAB", "ODURAB", JdeDataType.Numeric),
        new JdeField("ODURRF", "ODURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I21_0", "Primary Key on ODCYNUM, ODLITM, ODMCU, ODLOCN, ODLOTN, ODDMCT, ODDMCS, ODSEQ, ODSHAN", new[] { "ODCYNUM", "ODLITM", "ODMCU", "ODLOCN", "ODLOTN", "ODDMCT", "ODDMCS", "ODSEQ", "ODSHAN" }, isUnique: true, isPrimaryKey: true)
    };
}
