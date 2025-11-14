using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T20 - .
/// </summary>
public class F49T20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSOTDOMAIN.
        /// </summary>
        public const string SSOTDOMAIN = "SSOTDOMAIN";

        /// <summary>
        /// SSOTBSHPN.
        /// </summary>
        public const string SSOTBSHPN = "SSOTBSHPN";

        /// <summary>
        /// SSTRMNUM.
        /// </summary>
        public const string SSTRMNUM = "SSTRMNUM";

        /// <summary>
        /// SSOTSHPUNT.
        /// </summary>
        public const string SSOTSHPUNT = "SSOTSHPUNT";

        /// <summary>
        /// SSOTRSHUNT.
        /// </summary>
        public const string SSOTRSHUNT = "SSOTRSHUNT";

        /// <summary>
        /// SSOTORDRLN.
        /// </summary>
        public const string SSOTORDRLN = "SSOTORDRLN";

        /// <summary>
        /// SSOTORDRLS.
        /// </summary>
        public const string SSOTORDRLS = "SSOTORDRLS";

        /// <summary>
        /// SSOTSTPSEQ.
        /// </summary>
        public const string SSOTSTPSEQ = "SSOTSTPSEQ";

        /// <summary>
        /// SSDATETIME.
        /// </summary>
        public const string SSDATETIME = "SSDATETIME";

        /// <summary>
        /// SSPDDJ.
        /// </summary>
        public const string SSPDDJ = "SSPDDJ";

        /// <summary>
        /// SSPDTT.
        /// </summary>
        public const string SSPDTT = "SSPDTT";

        /// <summary>
        /// SSPPDJ.
        /// </summary>
        public const string SSPPDJ = "SSPPDJ";

        /// <summary>
        /// SSPMDT.
        /// </summary>
        public const string SSPMDT = "SSPMDT";

        /// <summary>
        /// SSRSDJ.
        /// </summary>
        public const string SSRSDJ = "SSRSDJ";

        /// <summary>
        /// SSRSDT.
        /// </summary>
        public const string SSRSDT = "SSRSDT";

        /// <summary>
        /// SSSOQS.
        /// </summary>
        public const string SSSOQS = "SSSOQS";

        /// <summary>
        /// SSOTPKGITM.
        /// </summary>
        public const string SSOTPKGITM = "SSOTPKGITM";

        /// <summary>
        /// SSUOM.
        /// </summary>
        public const string SSUOM = "SSUOM";

        /// <summary>
        /// SSOTOLSOQS.
        /// </summary>
        public const string SSOTOLSOQS = "SSOTOLSOQS";

        /// <summary>
        /// SSOTCARDOM.
        /// </summary>
        public const string SSOTCARDOM = "SSOTCARDOM";

        /// <summary>
        /// SSCARS.
        /// </summary>
        public const string SSCARS = "SSCARS";

        /// <summary>
        /// SSOTMOTDOM.
        /// </summary>
        public const string SSOTMOTDOM = "SSOTMOTDOM";

        /// <summary>
        /// SSMOT.
        /// </summary>
        public const string SSMOT = "SSMOT";

        /// <summary>
        /// SSOTEQUIP.
        /// </summary>
        public const string SSOTEQUIP = "SSOTEQUIP";

        /// <summary>
        /// SSSCAC.
        /// </summary>
        public const string SSSCAC = "SSSCAC";

        /// <summary>
        /// SSOTSSHPN.
        /// </summary>
        public const string SSOTSSHPN = "SSOTSSHPN";

        /// <summary>
        /// SSOTOTLAMT.
        /// </summary>
        public const string SSOTOTLAMT = "SSOTOTLAMT";

        /// <summary>
        /// SSCRCD.
        /// </summary>
        public const string SSCRCD = "SSCRCD";

        /// <summary>
        /// SSOTSHPDEL.
        /// </summary>
        public const string SSOTSHPDEL = "SSOTSHPDEL";

        /// <summary>
        /// SSOTSHPSTS.
        /// </summary>
        public const string SSOTSHPSTS = "SSOTSHPSTS";

        /// <summary>
        /// SSOTERRFLG.
        /// </summary>
        public const string SSOTERRFLG = "SSOTERRFLG";

        /// <summary>
        /// SSITWT.
        /// </summary>
        public const string SSITWT = "SSITWT";

        /// <summary>
        /// SSITVL.
        /// </summary>
        public const string SSITVL = "SSITVL";

        /// <summary>
        /// SSWUOM.
        /// </summary>
        public const string SSWUOM = "SSWUOM";

        /// <summary>
        /// SSVUOM.
        /// </summary>
        public const string SSVUOM = "SSVUOM";

        /// <summary>
        /// SSURCD.
        /// </summary>
        public const string SSURCD = "SSURCD";

        /// <summary>
        /// SSURDT.
        /// </summary>
        public const string SSURDT = "SSURDT";

        /// <summary>
        /// SSURRF.
        /// </summary>
        public const string SSURRF = "SSURRF";

        /// <summary>
        /// SSURAT.
        /// </summary>
        public const string SSURAT = "SSURAT";

        /// <summary>
        /// SSURAB.
        /// </summary>
        public const string SSURAB = "SSURAB";

        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";

        /// <summary>
        /// SSTORG.
        /// </summary>
        public const string SSTORG = "SSTORG";

        /// <summary>
        /// SSJOBN.
        /// </summary>
        public const string SSJOBN = "SSJOBN";

        /// <summary>
        /// SSUUPMJ.
        /// </summary>
        public const string SSUUPMJ = "SSUUPMJ";

        /// <summary>
        /// SSOTE1REF1.
        /// </summary>
        public const string SSOTE1REF1 = "SSOTE1REF1";

        /// <summary>
        /// SSOTE1REF2.
        /// </summary>
        public const string SSOTE1REF2 = "SSOTE1REF2";

        /// <summary>
        /// SSOTE1REF3.
        /// </summary>
        public const string SSOTE1REF3 = "SSOTE1REF3";

        /// <summary>
        /// SSOTCHAR1.
        /// </summary>
        public const string SSOTCHAR1 = "SSOTCHAR1";

        /// <summary>
        /// SSOTCHAR2.
        /// </summary>
        public const string SSOTCHAR2 = "SSOTCHAR2";

        /// <summary>
        /// SSOTCHAR3.
        /// </summary>
        public const string SSOTCHAR3 = "SSOTCHAR3";

        /// <summary>
        /// SSOTMATH1.
        /// </summary>
        public const string SSOTMATH1 = "SSOTMATH1";

        /// <summary>
        /// SSOTMATH2.
        /// </summary>
        public const string SSOTMATH2 = "SSOTMATH2";

        /// <summary>
        /// SSOTMATH3.
        /// </summary>
        public const string SSOTMATH3 = "SSOTMATH3";
    }

    /// <inheritdoc />
    public override string TableName => "F49T20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSOTDOMAIN", "SSOTDOMAIN", JdeDataType.String, 100, true, true),
        new JdeField("SSOTBSHPN", "SSOTBSHPN", JdeDataType.String, 100, true, true),
        new JdeField("SSTRMNUM", "SSTRMNUM", JdeDataType.String, 22, true, true),
        new JdeField("SSOTSHPUNT", "SSOTSHPUNT", JdeDataType.String, 100, true, true),
        new JdeField("SSOTRSHUNT", "SSOTRSHUNT", JdeDataType.String, 100, true, true),
        new JdeField("SSOTORDRLN", "SSOTORDRLN", JdeDataType.String, 100, true, true),
        new JdeField("SSOTORDRLS", "SSOTORDRLS", JdeDataType.String, 100),
        new JdeField("SSOTSTPSEQ", "SSOTSTPSEQ", JdeDataType.Numeric),
        new JdeField("SSDATETIME", "SSDATETIME", JdeDataType.String, 52),
        new JdeField("SSPDDJ", "SSPDDJ", JdeDataType.Numeric),
        new JdeField("SSPDTT", "SSPDTT", JdeDataType.Numeric),
        new JdeField("SSPPDJ", "SSPPDJ", JdeDataType.Numeric),
        new JdeField("SSPMDT", "SSPMDT", JdeDataType.Numeric),
        new JdeField("SSRSDJ", "SSRSDJ", JdeDataType.Numeric),
        new JdeField("SSRSDT", "SSRSDT", JdeDataType.Numeric),
        new JdeField("SSSOQS", "SSSOQS", JdeDataType.Numeric),
        new JdeField("SSOTPKGITM", "SSOTPKGITM", JdeDataType.String, 100),
        new JdeField("SSUOM", "SSUOM", JdeDataType.String, 4),
        new JdeField("SSOTOLSOQS", "SSOTOLSOQS", JdeDataType.Numeric),
        new JdeField("SSOTCARDOM", "SSOTCARDOM", JdeDataType.String, 100),
        new JdeField("SSCARS", "SSCARS", JdeDataType.Numeric),
        new JdeField("SSOTMOTDOM", "SSOTMOTDOM", JdeDataType.String, 100),
        new JdeField("SSMOT", "SSMOT", JdeDataType.String, 6),
        new JdeField("SSOTEQUIP", "SSOTEQUIP", JdeDataType.String, 100),
        new JdeField("SSSCAC", "SSSCAC", JdeDataType.String, 8),
        new JdeField("SSOTSSHPN", "SSOTSSHPN", JdeDataType.String, 100),
        new JdeField("SSOTOTLAMT", "SSOTOTLAMT", JdeDataType.Numeric),
        new JdeField("SSCRCD", "SSCRCD", JdeDataType.String, 6),
        new JdeField("SSOTSHPDEL", "SSOTSHPDEL", JdeDataType.String, 2),
        new JdeField("SSOTSHPSTS", "SSOTSHPSTS", JdeDataType.String, 100),
        new JdeField("SSOTERRFLG", "SSOTERRFLG", JdeDataType.String, 2),
        new JdeField("SSITWT", "SSITWT", JdeDataType.Numeric),
        new JdeField("SSITVL", "SSITVL", JdeDataType.Numeric),
        new JdeField("SSWUOM", "SSWUOM", JdeDataType.String, 4),
        new JdeField("SSVUOM", "SSVUOM", JdeDataType.String, 4),
        new JdeField("SSURCD", "SSURCD", JdeDataType.String, 4),
        new JdeField("SSURDT", "SSURDT", JdeDataType.Numeric),
        new JdeField("SSURRF", "SSURRF", JdeDataType.String, 30),
        new JdeField("SSURAT", "SSURAT", JdeDataType.Numeric),
        new JdeField("SSURAB", "SSURAB", JdeDataType.Numeric),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSTORG", "SSTORG", JdeDataType.String, 20),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSUUPMJ", "SSUUPMJ", JdeDataType.Date),
        new JdeField("SSOTE1REF1", "SSOTE1REF1", JdeDataType.String, 100),
        new JdeField("SSOTE1REF2", "SSOTE1REF2", JdeDataType.String, 100),
        new JdeField("SSOTE1REF3", "SSOTE1REF3", JdeDataType.String, 100),
        new JdeField("SSOTCHAR1", "SSOTCHAR1", JdeDataType.String, 2),
        new JdeField("SSOTCHAR2", "SSOTCHAR2", JdeDataType.String, 2),
        new JdeField("SSOTCHAR3", "SSOTCHAR3", JdeDataType.String, 2),
        new JdeField("SSOTMATH1", "SSOTMATH1", JdeDataType.Numeric),
        new JdeField("SSOTMATH2", "SSOTMATH2", JdeDataType.Numeric),
        new JdeField("SSOTMATH3", "SSOTMATH3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T20_0", "Primary Key on SSOTDOMAIN, SSOTBSHPN, SSTRMNUM, SSOTSHPUNT, SSOTRSHUNT, SSOTORDRLN", new[] { "SSOTDOMAIN", "SSOTBSHPN", "SSTRMNUM", "SSOTSHPUNT", "SSOTRSHUNT", "SSOTORDRLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T20_2", "Index on SSOTDOMAIN, SSOTBSHPN, SSTRMNUM, SSDATETIME, SSOTORDRLS, SSOTERRFLG", new[] { "SSOTDOMAIN", "SSOTBSHPN", "SSTRMNUM", "SSDATETIME", "SSOTORDRLS", "SSOTERRFLG" }),
        new JdeIndex("F49T20_3", "Index on SSOTDOMAIN, SSOTBSHPN, SSTRMNUM, SSOTERRFLG", new[] { "SSOTDOMAIN", "SSOTBSHPN", "SSTRMNUM", "SSOTERRFLG" })
    };
}
