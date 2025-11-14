using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38010 - .
/// </summary>
public class F38010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DNDMCT.
        /// </summary>
        public const string DNDMCT = "DNDMCT";

        /// <summary>
        /// DNDMCS.
        /// </summary>
        public const string DNDMCS = "DNDMCS";

        /// <summary>
        /// DNDL01.
        /// </summary>
        public const string DNDL01 = "DNDL01";

        /// <summary>
        /// DNDL02.
        /// </summary>
        public const string DNDL02 = "DNDL02";

        /// <summary>
        /// DNDL03.
        /// </summary>
        public const string DNDL03 = "DNDL03";

        /// <summary>
        /// DNMCU.
        /// </summary>
        public const string DNMCU = "DNMCU";

        /// <summary>
        /// DNNWRN.
        /// </summary>
        public const string DNNWRN = "DNNWRN";

        /// <summary>
        /// DNAGRS.
        /// </summary>
        public const string DNAGRS = "DNAGRS";

        /// <summary>
        /// DNCMAN.
        /// </summary>
        public const string DNCMAN = "DNCMAN";

        /// <summary>
        /// DNCADM.
        /// </summary>
        public const string DNCADM = "DNCADM";

        /// <summary>
        /// DNPANM.
        /// </summary>
        public const string DNPANM = "DNPANM";

        /// <summary>
        /// DNCNTD.
        /// </summary>
        public const string DNCNTD = "DNCNTD";

        /// <summary>
        /// DNDMTC.
        /// </summary>
        public const string DNDMTC = "DNDMTC";

        /// <summary>
        /// DNDMPC.
        /// </summary>
        public const string DNDMPC = "DNDMPC";

        /// <summary>
        /// DNDMSC.
        /// </summary>
        public const string DNDMSC = "DNDMSC";

        /// <summary>
        /// DNEFTJ.
        /// </summary>
        public const string DNEFTJ = "DNEFTJ";

        /// <summary>
        /// DNEXDJ.
        /// </summary>
        public const string DNEXDJ = "DNEXDJ";

        /// <summary>
        /// DNAN8.
        /// </summary>
        public const string DNAN8 = "DNAN8";

        /// <summary>
        /// DNAAGM.
        /// </summary>
        public const string DNAAGM = "DNAAGM";

        /// <summary>
        /// DNAAGS.
        /// </summary>
        public const string DNAAGS = "DNAAGS";

        /// <summary>
        /// DNRAGM.
        /// </summary>
        public const string DNRAGM = "DNRAGM";

        /// <summary>
        /// DNRAGS.
        /// </summary>
        public const string DNRAGS = "DNRAGS";

        /// <summary>
        /// DNCAGM.
        /// </summary>
        public const string DNCAGM = "DNCAGM";

        /// <summary>
        /// DNCAGS.
        /// </summary>
        public const string DNCAGS = "DNCAGS";

        /// <summary>
        /// DNPAGM.
        /// </summary>
        public const string DNPAGM = "DNPAGM";

        /// <summary>
        /// DNPAGS.
        /// </summary>
        public const string DNPAGS = "DNPAGS";

        /// <summary>
        /// DNZD01.
        /// </summary>
        public const string DNZD01 = "DNZD01";

        /// <summary>
        /// DNZD02.
        /// </summary>
        public const string DNZD02 = "DNZD02";

        /// <summary>
        /// DNZD03.
        /// </summary>
        public const string DNZD03 = "DNZD03";

        /// <summary>
        /// DNZD04.
        /// </summary>
        public const string DNZD04 = "DNZD04";

        /// <summary>
        /// DNZD05.
        /// </summary>
        public const string DNZD05 = "DNZD05";

        /// <summary>
        /// DNZD06.
        /// </summary>
        public const string DNZD06 = "DNZD06";

        /// <summary>
        /// DNZD07.
        /// </summary>
        public const string DNZD07 = "DNZD07";

        /// <summary>
        /// DNZD08.
        /// </summary>
        public const string DNZD08 = "DNZD08";

        /// <summary>
        /// DNZD09.
        /// </summary>
        public const string DNZD09 = "DNZD09";

        /// <summary>
        /// DNZD10.
        /// </summary>
        public const string DNZD10 = "DNZD10";

        /// <summary>
        /// DNQEDT.
        /// </summary>
        public const string DNQEDT = "DNQEDT";

        /// <summary>
        /// DNCAND.
        /// </summary>
        public const string DNCAND = "DNCAND";

        /// <summary>
        /// DNCANR.
        /// </summary>
        public const string DNCANR = "DNCANR";

        /// <summary>
        /// DNUPGL.
        /// </summary>
        public const string DNUPGL = "DNUPGL";

        /// <summary>
        /// DNPRAS.
        /// </summary>
        public const string DNPRAS = "DNPRAS";

        /// <summary>
        /// DNCMOO.
        /// </summary>
        public const string DNCMOO = "DNCMOO";

        /// <summary>
        /// DNCNQY.
        /// </summary>
        public const string DNCNQY = "DNCNQY";

        /// <summary>
        /// DNTV01.
        /// </summary>
        public const string DNTV01 = "DNTV01";

        /// <summary>
        /// DNTV02.
        /// </summary>
        public const string DNTV02 = "DNTV02";

        /// <summary>
        /// DNTV03.
        /// </summary>
        public const string DNTV03 = "DNTV03";

        /// <summary>
        /// DNURCD.
        /// </summary>
        public const string DNURCD = "DNURCD";

        /// <summary>
        /// DNURDT.
        /// </summary>
        public const string DNURDT = "DNURDT";

        /// <summary>
        /// DNURAT.
        /// </summary>
        public const string DNURAT = "DNURAT";

        /// <summary>
        /// DNURAB.
        /// </summary>
        public const string DNURAB = "DNURAB";

        /// <summary>
        /// DNURRF.
        /// </summary>
        public const string DNURRF = "DNURRF";

        /// <summary>
        /// DNUSER.
        /// </summary>
        public const string DNUSER = "DNUSER";

        /// <summary>
        /// DNPID.
        /// </summary>
        public const string DNPID = "DNPID";

        /// <summary>
        /// DNJOBN.
        /// </summary>
        public const string DNJOBN = "DNJOBN";

        /// <summary>
        /// DNUPMJ.
        /// </summary>
        public const string DNUPMJ = "DNUPMJ";

        /// <summary>
        /// DNTDAY.
        /// </summary>
        public const string DNTDAY = "DNTDAY";

        /// <summary>
        /// DNRPQT.
        /// </summary>
        public const string DNRPQT = "DNRPQT";

        /// <summary>
        /// DNQED3.
        /// </summary>
        public const string DNQED3 = "DNQED3";

        /// <summary>
        /// DNQED2.
        /// </summary>
        public const string DNQED2 = "DNQED2";
    }

    /// <inheritdoc />
    public override string TableName => "F38010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DNDMCT", "DNDMCT", JdeDataType.String, 24, true, true),
        new JdeField("DNDMCS", "DNDMCS", JdeDataType.Numeric, null, true, true),
        new JdeField("DNDL01", "DNDL01", JdeDataType.String, 60),
        new JdeField("DNDL02", "DNDL02", JdeDataType.String, 60),
        new JdeField("DNDL03", "DNDL03", JdeDataType.String, 60),
        new JdeField("DNMCU", "DNMCU", JdeDataType.String, 24),
        new JdeField("DNNWRN", "DNNWRN", JdeDataType.String, 2),
        new JdeField("DNAGRS", "DNAGRS", JdeDataType.String, 2),
        new JdeField("DNCMAN", "DNCMAN", JdeDataType.Numeric),
        new JdeField("DNCADM", "DNCADM", JdeDataType.Numeric),
        new JdeField("DNPANM", "DNPANM", JdeDataType.String, 50),
        new JdeField("DNCNTD", "DNCNTD", JdeDataType.Numeric),
        new JdeField("DNDMTC", "DNDMTC", JdeDataType.String, 2),
        new JdeField("DNDMPC", "DNDMPC", JdeDataType.String, 6),
        new JdeField("DNDMSC", "DNDMSC", JdeDataType.String, 2),
        new JdeField("DNEFTJ", "DNEFTJ", JdeDataType.Numeric),
        new JdeField("DNEXDJ", "DNEXDJ", JdeDataType.Numeric),
        new JdeField("DNAN8", "DNAN8", JdeDataType.Numeric),
        new JdeField("DNAAGM", "DNAAGM", JdeDataType.String, 24),
        new JdeField("DNAAGS", "DNAAGS", JdeDataType.Numeric),
        new JdeField("DNRAGM", "DNRAGM", JdeDataType.String, 24),
        new JdeField("DNRAGS", "DNRAGS", JdeDataType.Numeric),
        new JdeField("DNCAGM", "DNCAGM", JdeDataType.String, 24),
        new JdeField("DNCAGS", "DNCAGS", JdeDataType.Numeric),
        new JdeField("DNPAGM", "DNPAGM", JdeDataType.String, 24),
        new JdeField("DNPAGS", "DNPAGS", JdeDataType.Numeric),
        new JdeField("DNZD01", "DNZD01", JdeDataType.String, 6),
        new JdeField("DNZD02", "DNZD02", JdeDataType.String, 6),
        new JdeField("DNZD03", "DNZD03", JdeDataType.String, 6),
        new JdeField("DNZD04", "DNZD04", JdeDataType.String, 6),
        new JdeField("DNZD05", "DNZD05", JdeDataType.String, 6),
        new JdeField("DNZD06", "DNZD06", JdeDataType.String, 6),
        new JdeField("DNZD07", "DNZD07", JdeDataType.String, 6),
        new JdeField("DNZD08", "DNZD08", JdeDataType.String, 6),
        new JdeField("DNZD09", "DNZD09", JdeDataType.String, 6),
        new JdeField("DNZD10", "DNZD10", JdeDataType.String, 6),
        new JdeField("DNQEDT", "DNQEDT", JdeDataType.String, 2),
        new JdeField("DNCAND", "DNCAND", JdeDataType.Numeric),
        new JdeField("DNCANR", "DNCANR", JdeDataType.String, 6),
        new JdeField("DNUPGL", "DNUPGL", JdeDataType.String, 2),
        new JdeField("DNPRAS", "DNPRAS", JdeDataType.String, 2),
        new JdeField("DNCMOO", "DNCMOO", JdeDataType.String, 2),
        new JdeField("DNCNQY", "DNCNQY", JdeDataType.String, 2),
        new JdeField("DNTV01", "DNTV01", JdeDataType.String, 2),
        new JdeField("DNTV02", "DNTV02", JdeDataType.String, 2),
        new JdeField("DNTV03", "DNTV03", JdeDataType.String, 2),
        new JdeField("DNURCD", "DNURCD", JdeDataType.String, 4),
        new JdeField("DNURDT", "DNURDT", JdeDataType.Numeric),
        new JdeField("DNURAT", "DNURAT", JdeDataType.Numeric),
        new JdeField("DNURAB", "DNURAB", JdeDataType.Numeric),
        new JdeField("DNURRF", "DNURRF", JdeDataType.String, 30),
        new JdeField("DNUSER", "DNUSER", JdeDataType.String, 20),
        new JdeField("DNPID", "DNPID", JdeDataType.String, 20),
        new JdeField("DNJOBN", "DNJOBN", JdeDataType.String, 20),
        new JdeField("DNUPMJ", "DNUPMJ", JdeDataType.Numeric),
        new JdeField("DNTDAY", "DNTDAY", JdeDataType.Numeric),
        new JdeField("DNRPQT", "DNRPQT", JdeDataType.Numeric),
        new JdeField("DNQED3", "DNQED3", JdeDataType.String, 2),
        new JdeField("DNQED2", "DNQED2", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38010_0", "Primary Key on DNDMCT, DNDMCS", new[] { "DNDMCT", "DNDMCS" }, isUnique: true, isPrimaryKey: true)
    };
}
