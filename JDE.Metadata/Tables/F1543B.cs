using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1543B - .
/// </summary>
public class F1543B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OASASC.
        /// </summary>
        public const string OASASC = "OASASC";

        /// <summary>
        /// OACTRY.
        /// </summary>
        public const string OACTRY = "OACTRY";

        /// <summary>
        /// OAYR.
        /// </summary>
        public const string OAYR = "OAYR";

        /// <summary>
        /// OARPRD.
        /// </summary>
        public const string OARPRD = "OARPRD";

        /// <summary>
        /// OAMCU.
        /// </summary>
        public const string OAMCU = "OAMCU";

        /// <summary>
        /// OAAN8.
        /// </summary>
        public const string OAAN8 = "OAAN8";

        /// <summary>
        /// OAUNIT.
        /// </summary>
        public const string OAUNIT = "OAUNIT";

        /// <summary>
        /// OADBAN.
        /// </summary>
        public const string OADBAN = "OADBAN";

        /// <summary>
        /// OAPRDC.
        /// </summary>
        public const string OAPRDC = "OAPRDC";

        /// <summary>
        /// OAMCUS.
        /// </summary>
        public const string OAMCUS = "OAMCUS";

        /// <summary>
        /// OACO.
        /// </summary>
        public const string OACO = "OACO";

        /// <summary>
        /// OADOCO.
        /// </summary>
        public const string OADOCO = "OADOCO";

        /// <summary>
        /// OAFLOR.
        /// </summary>
        public const string OAFLOR = "OAFLOR";

        /// <summary>
        /// OAULI.
        /// </summary>
        public const string OAULI = "OAULI";

        /// <summary>
        /// OAULI2.
        /// </summary>
        public const string OAULI2 = "OAULI2";

        /// <summary>
        /// OARM11.
        /// </summary>
        public const string OARM11 = "OARM11";

        /// <summary>
        /// OARM12.
        /// </summary>
        public const string OARM12 = "OARM12";

        /// <summary>
        /// OARM13.
        /// </summary>
        public const string OARM13 = "OARM13";

        /// <summary>
        /// OARM14.
        /// </summary>
        public const string OARM14 = "OARM14";

        /// <summary>
        /// OARM15.
        /// </summary>
        public const string OARM15 = "OARM15";

        /// <summary>
        /// OARM21.
        /// </summary>
        public const string OARM21 = "OARM21";

        /// <summary>
        /// OARM22.
        /// </summary>
        public const string OARM22 = "OARM22";

        /// <summary>
        /// OARM23.
        /// </summary>
        public const string OARM23 = "OARM23";

        /// <summary>
        /// OARM24.
        /// </summary>
        public const string OARM24 = "OARM24";

        /// <summary>
        /// OARM25.
        /// </summary>
        public const string OARM25 = "OARM25";

        /// <summary>
        /// OALSST.
        /// </summary>
        public const string OALSST = "OALSST";

        /// <summary>
        /// OALSET.
        /// </summary>
        public const string OALSET = "OALSET";

        /// <summary>
        /// OAMSTY.
        /// </summary>
        public const string OAMSTY = "OAMSTY";

        /// <summary>
        /// OAMSLY.
        /// </summary>
        public const string OAMSLY = "OAMSLY";

        /// <summary>
        /// OAMSCH.
        /// </summary>
        public const string OAMSCH = "OAMSCH";

        /// <summary>
        /// OAMFTY.
        /// </summary>
        public const string OAMFTY = "OAMFTY";

        /// <summary>
        /// OAMFLY.
        /// </summary>
        public const string OAMFLY = "OAMFLY";

        /// <summary>
        /// OAMFCH.
        /// </summary>
        public const string OAMFCH = "OAMFCH";

        /// <summary>
        /// OAMFPC.
        /// </summary>
        public const string OAMFPC = "OAMFPC";

        /// <summary>
        /// OAQSTY.
        /// </summary>
        public const string OAQSTY = "OAQSTY";

        /// <summary>
        /// OAQSLY.
        /// </summary>
        public const string OAQSLY = "OAQSLY";

        /// <summary>
        /// OAQSCH.
        /// </summary>
        public const string OAQSCH = "OAQSCH";

        /// <summary>
        /// OAQFTY.
        /// </summary>
        public const string OAQFTY = "OAQFTY";

        /// <summary>
        /// OAQFLY.
        /// </summary>
        public const string OAQFLY = "OAQFLY";

        /// <summary>
        /// OAQFCH.
        /// </summary>
        public const string OAQFCH = "OAQFCH";

        /// <summary>
        /// OAQFPC.
        /// </summary>
        public const string OAQFPC = "OAQFPC";

        /// <summary>
        /// OAYSTY.
        /// </summary>
        public const string OAYSTY = "OAYSTY";

        /// <summary>
        /// OAYSLY.
        /// </summary>
        public const string OAYSLY = "OAYSLY";

        /// <summary>
        /// OAYSCH.
        /// </summary>
        public const string OAYSCH = "OAYSCH";

        /// <summary>
        /// OAYFTY.
        /// </summary>
        public const string OAYFTY = "OAYFTY";

        /// <summary>
        /// OAYFLY.
        /// </summary>
        public const string OAYFLY = "OAYFLY";

        /// <summary>
        /// OAYFCH.
        /// </summary>
        public const string OAYFCH = "OAYFCH";

        /// <summary>
        /// OAYFPC.
        /// </summary>
        public const string OAYFPC = "OAYFPC";

        /// <summary>
        /// OASFTY.
        /// </summary>
        public const string OASFTY = "OASFTY";

        /// <summary>
        /// OASFLY.
        /// </summary>
        public const string OASFLY = "OASFLY";

        /// <summary>
        /// OANEMO.
        /// </summary>
        public const string OANEMO = "OANEMO";

        /// <summary>
        /// OANCSF.
        /// </summary>
        public const string OANCSF = "OANCSF";

        /// <summary>
        /// OAACSF.
        /// </summary>
        public const string OAACSF = "OAACSF";

        /// <summary>
        /// OANEMQ.
        /// </summary>
        public const string OANEMQ = "OANEMQ";

        /// <summary>
        /// OANCSQ.
        /// </summary>
        public const string OANCSQ = "OANCSQ";

        /// <summary>
        /// OAACSQ.
        /// </summary>
        public const string OAACSQ = "OAACSQ";

        /// <summary>
        /// OANEMY.
        /// </summary>
        public const string OANEMY = "OANEMY";

        /// <summary>
        /// OANCSY.
        /// </summary>
        public const string OANCSY = "OANCSY";

        /// <summary>
        /// OAACSY.
        /// </summary>
        public const string OAACSY = "OAACSY";

        /// <summary>
        /// OAPYSL.
        /// </summary>
        public const string OAPYSL = "OAPYSL";

        /// <summary>
        /// OARTMS.
        /// </summary>
        public const string OARTMS = "OARTMS";

        /// <summary>
        /// OANEMP.
        /// </summary>
        public const string OANEMP = "OANEMP";

        /// <summary>
        /// OACNTF.
        /// </summary>
        public const string OACNTF = "OACNTF";

        /// <summary>
        /// OACOL1.
        /// </summary>
        public const string OACOL1 = "OACOL1";

        /// <summary>
        /// OACOL2.
        /// </summary>
        public const string OACOL2 = "OACOL2";

        /// <summary>
        /// OAURCD.
        /// </summary>
        public const string OAURCD = "OAURCD";

        /// <summary>
        /// OAURDT.
        /// </summary>
        public const string OAURDT = "OAURDT";

        /// <summary>
        /// OAURAT.
        /// </summary>
        public const string OAURAT = "OAURAT";

        /// <summary>
        /// OAURAB.
        /// </summary>
        public const string OAURAB = "OAURAB";

        /// <summary>
        /// OAURRF.
        /// </summary>
        public const string OAURRF = "OAURRF";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OAUPMT.
        /// </summary>
        public const string OAUPMT = "OAUPMT";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";

        /// <summary>
        /// OACRCD.
        /// </summary>
        public const string OACRCD = "OACRCD";

        /// <summary>
        /// OACRR.
        /// </summary>
        public const string OACRR = "OACRR";

        /// <summary>
        /// OADS40.
        /// </summary>
        public const string OADS40 = "OADS40";

        /// <summary>
        /// OACRRM.
        /// </summary>
        public const string OACRRM = "OACRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F1543B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OASASC", "OASASC", JdeDataType.String, 4, true, true),
        new JdeField("OACTRY", "OACTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OAYR", "OAYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OARPRD", "OARPRD", JdeDataType.Numeric, null, true, true),
        new JdeField("OAMCU", "OAMCU", JdeDataType.String, 24, true, true),
        new JdeField("OAAN8", "OAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OAUNIT", "OAUNIT", JdeDataType.String, 16, true, true),
        new JdeField("OADBAN", "OADBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("OAPRDC", "OAPRDC", JdeDataType.String, 8, true, true),
        new JdeField("OAMCUS", "OAMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OACO", "OACO", JdeDataType.String, 10, true, true),
        new JdeField("OADOCO", "OADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OAFLOR", "OAFLOR", JdeDataType.String, 8, true, true),
        new JdeField("OAULI", "OAULI", JdeDataType.String, 16, true, true),
        new JdeField("OAULI2", "OAULI2", JdeDataType.String, 16, true, true),
        new JdeField("OARM11", "OARM11", JdeDataType.String, 8),
        new JdeField("OARM12", "OARM12", JdeDataType.String, 8),
        new JdeField("OARM13", "OARM13", JdeDataType.String, 8),
        new JdeField("OARM14", "OARM14", JdeDataType.String, 8),
        new JdeField("OARM15", "OARM15", JdeDataType.String, 8),
        new JdeField("OARM21", "OARM21", JdeDataType.String, 8),
        new JdeField("OARM22", "OARM22", JdeDataType.String, 8),
        new JdeField("OARM23", "OARM23", JdeDataType.String, 8),
        new JdeField("OARM24", "OARM24", JdeDataType.String, 8),
        new JdeField("OARM25", "OARM25", JdeDataType.String, 8),
        new JdeField("OALSST", "OALSST", JdeDataType.String, 2),
        new JdeField("OALSET", "OALSET", JdeDataType.String, 4),
        new JdeField("OAMSTY", "OAMSTY", JdeDataType.Numeric),
        new JdeField("OAMSLY", "OAMSLY", JdeDataType.Numeric),
        new JdeField("OAMSCH", "OAMSCH", JdeDataType.Numeric),
        new JdeField("OAMFTY", "OAMFTY", JdeDataType.Numeric),
        new JdeField("OAMFLY", "OAMFLY", JdeDataType.Numeric),
        new JdeField("OAMFCH", "OAMFCH", JdeDataType.Numeric),
        new JdeField("OAMFPC", "OAMFPC", JdeDataType.Numeric),
        new JdeField("OAQSTY", "OAQSTY", JdeDataType.Numeric),
        new JdeField("OAQSLY", "OAQSLY", JdeDataType.Numeric),
        new JdeField("OAQSCH", "OAQSCH", JdeDataType.Numeric),
        new JdeField("OAQFTY", "OAQFTY", JdeDataType.Numeric),
        new JdeField("OAQFLY", "OAQFLY", JdeDataType.Numeric),
        new JdeField("OAQFCH", "OAQFCH", JdeDataType.Numeric),
        new JdeField("OAQFPC", "OAQFPC", JdeDataType.Numeric),
        new JdeField("OAYSTY", "OAYSTY", JdeDataType.Numeric),
        new JdeField("OAYSLY", "OAYSLY", JdeDataType.Numeric),
        new JdeField("OAYSCH", "OAYSCH", JdeDataType.Numeric),
        new JdeField("OAYFTY", "OAYFTY", JdeDataType.Numeric),
        new JdeField("OAYFLY", "OAYFLY", JdeDataType.Numeric),
        new JdeField("OAYFCH", "OAYFCH", JdeDataType.Numeric),
        new JdeField("OAYFPC", "OAYFPC", JdeDataType.Numeric),
        new JdeField("OASFTY", "OASFTY", JdeDataType.Numeric),
        new JdeField("OASFLY", "OASFLY", JdeDataType.Numeric),
        new JdeField("OANEMO", "OANEMO", JdeDataType.Numeric),
        new JdeField("OANCSF", "OANCSF", JdeDataType.Numeric),
        new JdeField("OAACSF", "OAACSF", JdeDataType.Numeric),
        new JdeField("OANEMQ", "OANEMQ", JdeDataType.Numeric),
        new JdeField("OANCSQ", "OANCSQ", JdeDataType.Numeric),
        new JdeField("OAACSQ", "OAACSQ", JdeDataType.Numeric),
        new JdeField("OANEMY", "OANEMY", JdeDataType.Numeric),
        new JdeField("OANCSY", "OANCSY", JdeDataType.Numeric),
        new JdeField("OAACSY", "OAACSY", JdeDataType.Numeric),
        new JdeField("OAPYSL", "OAPYSL", JdeDataType.Numeric),
        new JdeField("OARTMS", "OARTMS", JdeDataType.Numeric),
        new JdeField("OANEMP", "OANEMP", JdeDataType.Numeric),
        new JdeField("OACNTF", "OACNTF", JdeDataType.Numeric),
        new JdeField("OACOL1", "OACOL1", JdeDataType.String, 30),
        new JdeField("OACOL2", "OACOL2", JdeDataType.String, 30),
        new JdeField("OAURCD", "OAURCD", JdeDataType.String, 4),
        new JdeField("OAURDT", "OAURDT", JdeDataType.Numeric),
        new JdeField("OAURAT", "OAURAT", JdeDataType.Numeric),
        new JdeField("OAURAB", "OAURAB", JdeDataType.Numeric),
        new JdeField("OAURRF", "OAURRF", JdeDataType.String, 30),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OAUPMT", "OAUPMT", JdeDataType.Numeric),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20),
        new JdeField("OACRCD", "OACRCD", JdeDataType.String, 6),
        new JdeField("OACRR", "OACRR", JdeDataType.Numeric),
        new JdeField("OADS40", "OADS40", JdeDataType.String, 80, true, true),
        new JdeField("OACRRM", "OACRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1543B_0", "Primary Key on OASASC, OACTRY, OAYR, OARPRD, OACO, OAMCUS, OAMCU, OAFLOR, OAUNIT, OAAN8, OADOCO, OADBAN, OAPRDC, OAULI, OAULI2, OADS40", new[] { "OASASC", "OACTRY", "OAYR", "OARPRD", "OACO", "OAMCUS", "OAMCU", "OAFLOR", "OAUNIT", "OAAN8", "OADOCO", "OADBAN", "OAPRDC", "OAULI", "OAULI2", "OADS40" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1543B_2", "Index on OASASC, OACO, OAMCUS, OAMCU, OAFLOR, OAUNIT, OAAN8, OADBAN, OAPRDC, OAULI, OAULI2, OADS40, OACTRY, OAYR, OARPRD", new[] { "OASASC", "OACO", "OAMCUS", "OAMCU", "OAFLOR", "OAUNIT", "OAAN8", "OADBAN", "OAPRDC", "OAULI", "OAULI2", "OADS40", "OACTRY", "OAYR", "OARPRD" })
    };
}
