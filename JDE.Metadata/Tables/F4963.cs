using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4963 - .
/// </summary>
public class F4963 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIVMCU.
        /// </summary>
        public const string TIVMCU = "TIVMCU";

        /// <summary>
        /// TILDNM.
        /// </summary>
        public const string TILDNM = "TILDNM";

        /// <summary>
        /// TISHPN.
        /// </summary>
        public const string TISHPN = "TISHPN";

        /// <summary>
        /// TIITM.
        /// </summary>
        public const string TIITM = "TIITM";

        /// <summary>
        /// TILOTN.
        /// </summary>
        public const string TILOTN = "TILOTN";

        /// <summary>
        /// TIAN8.
        /// </summary>
        public const string TIAN8 = "TIAN8";

        /// <summary>
        /// TIVTYP.
        /// </summary>
        public const string TIVTYP = "TIVTYP";

        /// <summary>
        /// TIPVEH.
        /// </summary>
        public const string TIPVEH = "TIPVEH";

        /// <summary>
        /// TIPRLO.
        /// </summary>
        public const string TIPRLO = "TIPRLO";

        /// <summary>
        /// TICARS.
        /// </summary>
        public const string TICARS = "TICARS";

        /// <summary>
        /// TIMOT.
        /// </summary>
        public const string TIMOT = "TIMOT";

        /// <summary>
        /// TIQTYL.
        /// </summary>
        public const string TIQTYL = "TIQTYL";

        /// <summary>
        /// TIUOM1.
        /// </summary>
        public const string TIUOM1 = "TIUOM1";

        /// <summary>
        /// TIECST.
        /// </summary>
        public const string TIECST = "TIECST";

        /// <summary>
        /// TIMCU.
        /// </summary>
        public const string TIMCU = "TIMCU";

        /// <summary>
        /// TILOCN.
        /// </summary>
        public const string TILOCN = "TILOCN";

        /// <summary>
        /// TITEMP.
        /// </summary>
        public const string TITEMP = "TITEMP";

        /// <summary>
        /// TISTPU.
        /// </summary>
        public const string TISTPU = "TISTPU";

        /// <summary>
        /// TIDEND.
        /// </summary>
        public const string TIDEND = "TIDEND";

        /// <summary>
        /// TIDNTP.
        /// </summary>
        public const string TIDNTP = "TIDNTP";

        /// <summary>
        /// TIDETP.
        /// </summary>
        public const string TIDETP = "TIDETP";

        /// <summary>
        /// TIDTPU.
        /// </summary>
        public const string TIDTPU = "TIDTPU";

        /// <summary>
        /// TIVCF.
        /// </summary>
        public const string TIVCF = "TIVCF";

        /// <summary>
        /// TICMOO.
        /// </summary>
        public const string TICMOO = "TICMOO";

        /// <summary>
        /// TIKTFG.
        /// </summary>
        public const string TIKTFG = "TIKTFG";

        /// <summary>
        /// TIBPFG.
        /// </summary>
        public const string TIBPFG = "TIBPFG";

        /// <summary>
        /// TIURCD.
        /// </summary>
        public const string TIURCD = "TIURCD";

        /// <summary>
        /// TIURDT.
        /// </summary>
        public const string TIURDT = "TIURDT";

        /// <summary>
        /// TIURAT.
        /// </summary>
        public const string TIURAT = "TIURAT";

        /// <summary>
        /// TIURAB.
        /// </summary>
        public const string TIURAB = "TIURAB";

        /// <summary>
        /// TIURRF.
        /// </summary>
        public const string TIURRF = "TIURRF";

        /// <summary>
        /// TIUSER.
        /// </summary>
        public const string TIUSER = "TIUSER";

        /// <summary>
        /// TIPID.
        /// </summary>
        public const string TIPID = "TIPID";

        /// <summary>
        /// TIJOBN.
        /// </summary>
        public const string TIJOBN = "TIJOBN";

        /// <summary>
        /// TIUPMJ.
        /// </summary>
        public const string TIUPMJ = "TIUPMJ";

        /// <summary>
        /// TITDAY.
        /// </summary>
        public const string TITDAY = "TITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4963";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIVMCU", "TIVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TILDNM", "TILDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TISHPN", "TISHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("TIITM", "TIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TILOTN", "TILOTN", JdeDataType.String, 60, true, true),
        new JdeField("TIAN8", "TIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TIVTYP", "TIVTYP", JdeDataType.String, 24),
        new JdeField("TIPVEH", "TIPVEH", JdeDataType.String, 24),
        new JdeField("TIPRLO", "TIPRLO", JdeDataType.String, 26),
        new JdeField("TICARS", "TICARS", JdeDataType.Numeric),
        new JdeField("TIMOT", "TIMOT", JdeDataType.String, 6),
        new JdeField("TIQTYL", "TIQTYL", JdeDataType.Numeric),
        new JdeField("TIUOM1", "TIUOM1", JdeDataType.String, 4),
        new JdeField("TIECST", "TIECST", JdeDataType.Numeric),
        new JdeField("TIMCU", "TIMCU", JdeDataType.String, 24),
        new JdeField("TILOCN", "TILOCN", JdeDataType.String, 40),
        new JdeField("TITEMP", "TITEMP", JdeDataType.Numeric),
        new JdeField("TISTPU", "TISTPU", JdeDataType.String, 2),
        new JdeField("TIDEND", "TIDEND", JdeDataType.Numeric),
        new JdeField("TIDNTP", "TIDNTP", JdeDataType.String, 2),
        new JdeField("TIDETP", "TIDETP", JdeDataType.Numeric),
        new JdeField("TIDTPU", "TIDTPU", JdeDataType.String, 2),
        new JdeField("TIVCF", "TIVCF", JdeDataType.Numeric),
        new JdeField("TICMOO", "TICMOO", JdeDataType.String, 2),
        new JdeField("TIKTFG", "TIKTFG", JdeDataType.String, 2),
        new JdeField("TIBPFG", "TIBPFG", JdeDataType.String, 2),
        new JdeField("TIURCD", "TIURCD", JdeDataType.String, 4),
        new JdeField("TIURDT", "TIURDT", JdeDataType.Numeric),
        new JdeField("TIURAT", "TIURAT", JdeDataType.Numeric),
        new JdeField("TIURAB", "TIURAB", JdeDataType.Numeric),
        new JdeField("TIURRF", "TIURRF", JdeDataType.String, 30),
        new JdeField("TIUSER", "TIUSER", JdeDataType.String, 20),
        new JdeField("TIPID", "TIPID", JdeDataType.String, 20),
        new JdeField("TIJOBN", "TIJOBN", JdeDataType.String, 20),
        new JdeField("TIUPMJ", "TIUPMJ", JdeDataType.Numeric),
        new JdeField("TITDAY", "TITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4963_0", "Primary Key on TIVMCU, TILDNM, TISHPN, TIITM, TILOTN, TIAN8", new[] { "TIVMCU", "TILDNM", "TISHPN", "TIITM", "TILOTN", "TIAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
