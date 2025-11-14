using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B73 - .
/// </summary>
public class F31B73 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCWCFGID.
        /// </summary>
        public const string BCWCFGID = "BCWCFGID";

        /// <summary>
        /// BCWBOPCD.
        /// </summary>
        public const string BCWBOPCD = "BCWBOPCD";

        /// <summary>
        /// BCWBDL01.
        /// </summary>
        public const string BCWBDL01 = "BCWBDL01";

        /// <summary>
        /// BCWFVF.
        /// </summary>
        public const string BCWFVF = "BCWFVF";

        /// <summary>
        /// BCWTVF.
        /// </summary>
        public const string BCWTVF = "BCWTVF";

        /// <summary>
        /// BCWFVTY.
        /// </summary>
        public const string BCWFVTY = "BCWFVTY";

        /// <summary>
        /// BCWTVTY.
        /// </summary>
        public const string BCWTVTY = "BCWTVTY";

        /// <summary>
        /// BCWFDVF.
        /// </summary>
        public const string BCWFDVF = "BCWFDVF";

        /// <summary>
        /// BCWTDVF.
        /// </summary>
        public const string BCWTDVF = "BCWTDVF";

        /// <summary>
        /// BCWYLDF.
        /// </summary>
        public const string BCWYLDF = "BCWYLDF";

        /// <summary>
        /// BCWEURF.
        /// </summary>
        public const string BCWEURF = "BCWEURF";

        /// <summary>
        /// BCWOWNF.
        /// </summary>
        public const string BCWOWNF = "BCWOWNF";

        /// <summary>
        /// BCWWISTF.
        /// </summary>
        public const string BCWWISTF = "BCWWISTF";

        /// <summary>
        /// BCWMTTYF.
        /// </summary>
        public const string BCWMTTYF = "BCWMTTYF";

        /// <summary>
        /// BCWBIDF.
        /// </summary>
        public const string BCWBIDF = "BCWBIDF";

        /// <summary>
        /// BCWSTYF.
        /// </summary>
        public const string BCWSTYF = "BCWSTYF";

        /// <summary>
        /// BCWVSTYF.
        /// </summary>
        public const string BCWVSTYF = "BCWVSTYF";

        /// <summary>
        /// BCWLOTCF.
        /// </summary>
        public const string BCWLOTCF = "BCWLOTCF";

        /// <summary>
        /// BCWLOTAF.
        /// </summary>
        public const string BCWLOTAF = "BCWLOTAF";

        /// <summary>
        /// BCWCOMPF.
        /// </summary>
        public const string BCWCOMPF = "BCWCOMPF";

        /// <summary>
        /// BCWACADF.
        /// </summary>
        public const string BCWACADF = "BCWACADF";

        /// <summary>
        /// BCWVWLOT.
        /// </summary>
        public const string BCWVWLOT = "BCWVWLOT";

        /// <summary>
        /// BCWINATF.
        /// </summary>
        public const string BCWINATF = "BCWINATF";

        /// <summary>
        /// BCWOPCF.
        /// </summary>
        public const string BCWOPCF = "BCWOPCF";

        /// <summary>
        /// BCWEQPF.
        /// </summary>
        public const string BCWEQPF = "BCWEQPF";

        /// <summary>
        /// BCWCONF.
        /// </summary>
        public const string BCWCONF = "BCWCONF";

        /// <summary>
        /// BCWHRSF.
        /// </summary>
        public const string BCWHRSF = "BCWHRSF";

        /// <summary>
        /// BCWAVLOC.
        /// </summary>
        public const string BCWAVLOC = "BCWAVLOC";

        /// <summary>
        /// BCWADDF.
        /// </summary>
        public const string BCWADDF = "BCWADDF";

        /// <summary>
        /// BCWBOC01.
        /// </summary>
        public const string BCWBOC01 = "BCWBOC01";

        /// <summary>
        /// BCWBOC02.
        /// </summary>
        public const string BCWBOC02 = "BCWBOC02";

        /// <summary>
        /// BCWBOC03.
        /// </summary>
        public const string BCWBOC03 = "BCWBOC03";

        /// <summary>
        /// BCWBOC04.
        /// </summary>
        public const string BCWBOC04 = "BCWBOC04";

        /// <summary>
        /// BCWBOC05.
        /// </summary>
        public const string BCWBOC05 = "BCWBOC05";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";

        /// <summary>
        /// BCDCT.
        /// </summary>
        public const string BCDCT = "BCDCT";

        /// <summary>
        /// BCWQAOPF.
        /// </summary>
        public const string BCWQAOPF = "BCWQAOPF";

        /// <summary>
        /// BCWRF.
        /// </summary>
        public const string BCWRF = "BCWRF";

        /// <summary>
        /// BCWCD.
        /// </summary>
        public const string BCWCD = "BCWCD";

        /// <summary>
        /// BCWAB.
        /// </summary>
        public const string BCWAB = "BCWAB";

        /// <summary>
        /// BCWNUM.
        /// </summary>
        public const string BCWNUM = "BCWNUM";

        /// <summary>
        /// BCWMDT.
        /// </summary>
        public const string BCWMDT = "BCWMDT";

        /// <summary>
        /// BCWCMCF.
        /// </summary>
        public const string BCWCMCF = "BCWCMCF";

        /// <summary>
        /// BCOTOMF.
        /// </summary>
        public const string BCOTOMF = "BCOTOMF";

        /// <summary>
        /// BCEMPTYOP.
        /// </summary>
        public const string BCEMPTYOP = "BCEMPTYOP";

        /// <summary>
        /// BCVBTUSEF.
        /// </summary>
        public const string BCVBTUSEF = "BCVBTUSEF";

        /// <summary>
        /// BCWOVFL.
        /// </summary>
        public const string BCWOVFL = "BCWOVFL";

        /// <summary>
        /// BCWSRVSFL.
        /// </summary>
        public const string BCWSRVSFL = "BCWSRVSFL";

        /// <summary>
        /// BCWDLOSFL.
        /// </summary>
        public const string BCWDLOSFL = "BCWDLOSFL";

        /// <summary>
        /// BCWSREXFL.
        /// </summary>
        public const string BCWSREXFL = "BCWSREXFL";

        /// <summary>
        /// BCWCLCFL.
        /// </summary>
        public const string BCWCLCFL = "BCWCLCFL";

        /// <summary>
        /// BCWTOPCFL.
        /// </summary>
        public const string BCWTOPCFL = "BCWTOPCFL";

        /// <summary>
        /// BCWOFARM.
        /// </summary>
        public const string BCWOFARM = "BCWOFARM";

        /// <summary>
        /// BCWOSPRAY.
        /// </summary>
        public const string BCWOSPRAY = "BCWOSPRAY";

        /// <summary>
        /// BCWOGROW.
        /// </summary>
        public const string BCWOGROW = "BCWOGROW";

        /// <summary>
        /// BCWADJFLG.
        /// </summary>
        public const string BCWADJFLG = "BCWADJFLG";

        /// <summary>
        /// BCWADMOPF.
        /// </summary>
        public const string BCWADMOPF = "BCWADMOPF";

        /// <summary>
        /// BCWOHARV.
        /// </summary>
        public const string BCWOHARV = "BCWOHARV";
    }

    /// <inheritdoc />
    public override string TableName => "F31B73";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCWCFGID", "BCWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCWBOPCD", "BCWBOPCD", JdeDataType.String, 20),
        new JdeField("BCWBDL01", "BCWBDL01", JdeDataType.String, 60),
        new JdeField("BCWFVF", "BCWFVF", JdeDataType.String, 2),
        new JdeField("BCWTVF", "BCWTVF", JdeDataType.String, 2),
        new JdeField("BCWFVTY", "BCWFVTY", JdeDataType.String, 2),
        new JdeField("BCWTVTY", "BCWTVTY", JdeDataType.String, 2),
        new JdeField("BCWFDVF", "BCWFDVF", JdeDataType.String, 2),
        new JdeField("BCWTDVF", "BCWTDVF", JdeDataType.String, 2),
        new JdeField("BCWYLDF", "BCWYLDF", JdeDataType.String, 2),
        new JdeField("BCWEURF", "BCWEURF", JdeDataType.String, 2),
        new JdeField("BCWOWNF", "BCWOWNF", JdeDataType.String, 2),
        new JdeField("BCWWISTF", "BCWWISTF", JdeDataType.String, 2),
        new JdeField("BCWMTTYF", "BCWMTTYF", JdeDataType.String, 2),
        new JdeField("BCWBIDF", "BCWBIDF", JdeDataType.String, 2),
        new JdeField("BCWSTYF", "BCWSTYF", JdeDataType.String, 2),
        new JdeField("BCWVSTYF", "BCWVSTYF", JdeDataType.String, 2),
        new JdeField("BCWLOTCF", "BCWLOTCF", JdeDataType.String, 2),
        new JdeField("BCWLOTAF", "BCWLOTAF", JdeDataType.String, 2),
        new JdeField("BCWCOMPF", "BCWCOMPF", JdeDataType.String, 2),
        new JdeField("BCWACADF", "BCWACADF", JdeDataType.String, 2),
        new JdeField("BCWVWLOT", "BCWVWLOT", JdeDataType.String, 2),
        new JdeField("BCWINATF", "BCWINATF", JdeDataType.String, 2),
        new JdeField("BCWOPCF", "BCWOPCF", JdeDataType.String, 2),
        new JdeField("BCWEQPF", "BCWEQPF", JdeDataType.String, 2),
        new JdeField("BCWCONF", "BCWCONF", JdeDataType.String, 2),
        new JdeField("BCWHRSF", "BCWHRSF", JdeDataType.String, 2),
        new JdeField("BCWAVLOC", "BCWAVLOC", JdeDataType.String, 2),
        new JdeField("BCWADDF", "BCWADDF", JdeDataType.String, 2),
        new JdeField("BCWBOC01", "BCWBOC01", JdeDataType.String, 20),
        new JdeField("BCWBOC02", "BCWBOC02", JdeDataType.String, 20),
        new JdeField("BCWBOC03", "BCWBOC03", JdeDataType.String, 20),
        new JdeField("BCWBOC04", "BCWBOC04", JdeDataType.String, 20),
        new JdeField("BCWBOC05", "BCWBOC05", JdeDataType.String, 20),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric),
        new JdeField("BCDCT", "BCDCT", JdeDataType.String, 4),
        new JdeField("BCWQAOPF", "BCWQAOPF", JdeDataType.String, 2),
        new JdeField("BCWRF", "BCWRF", JdeDataType.String, 60),
        new JdeField("BCWCD", "BCWCD", JdeDataType.String, 6),
        new JdeField("BCWAB", "BCWAB", JdeDataType.Numeric),
        new JdeField("BCWNUM", "BCWNUM", JdeDataType.Numeric),
        new JdeField("BCWMDT", "BCWMDT", JdeDataType.Numeric),
        new JdeField("BCWCMCF", "BCWCMCF", JdeDataType.String, 2),
        new JdeField("BCOTOMF", "BCOTOMF", JdeDataType.String, 2),
        new JdeField("BCEMPTYOP", "BCEMPTYOP", JdeDataType.String, 2),
        new JdeField("BCVBTUSEF", "BCVBTUSEF", JdeDataType.String, 2),
        new JdeField("BCWOVFL", "BCWOVFL", JdeDataType.String, 2),
        new JdeField("BCWSRVSFL", "BCWSRVSFL", JdeDataType.String, 2),
        new JdeField("BCWDLOSFL", "BCWDLOSFL", JdeDataType.String, 2),
        new JdeField("BCWSREXFL", "BCWSREXFL", JdeDataType.String, 2),
        new JdeField("BCWCLCFL", "BCWCLCFL", JdeDataType.String, 2),
        new JdeField("BCWTOPCFL", "BCWTOPCFL", JdeDataType.String, 2),
        new JdeField("BCWOFARM", "BCWOFARM", JdeDataType.String, 2),
        new JdeField("BCWOSPRAY", "BCWOSPRAY", JdeDataType.String, 2),
        new JdeField("BCWOGROW", "BCWOGROW", JdeDataType.String, 2),
        new JdeField("BCWADJFLG", "BCWADJFLG", JdeDataType.String, 2),
        new JdeField("BCWADMOPF", "BCWADMOPF", JdeDataType.String, 2),
        new JdeField("BCWOHARV", "BCWOHARV", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B73_0", "Primary Key on BCWCFGID", new[] { "BCWCFGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B73_2", "Index on BCWBOPCD", new[] { "BCWBOPCD" })
    };
}
