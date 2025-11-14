using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H501S - .
/// </summary>
public class F44H501S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSHBMCUS.
        /// </summary>
        public const string SSHBMCUS = "SSHBMCUS";

        /// <summary>
        /// SSCPHASE.
        /// </summary>
        public const string SSCPHASE = "SSCPHASE";

        /// <summary>
        /// SSCENTYR.
        /// </summary>
        public const string SSCENTYR = "SSCENTYR";

        /// <summary>
        /// SSPTYPE.
        /// </summary>
        public const string SSPTYPE = "SSPTYPE";

        /// <summary>
        /// SSFRP.
        /// </summary>
        public const string SSFRP = "SSFRP";

        /// <summary>
        /// SSHBAREA.
        /// </summary>
        public const string SSHBAREA = "SSHBAREA";

        /// <summary>
        /// SSSSPED.
        /// </summary>
        public const string SSSSPED = "SSSSPED";

        /// <summary>
        /// SSCO.
        /// </summary>
        public const string SSCO = "SSCO";

        /// <summary>
        /// SSTSALES.
        /// </summary>
        public const string SSTSALES = "SSTSALES";

        /// <summary>
        /// SSTCANS.
        /// </summary>
        public const string SSTCANS = "SSTCANS";

        /// <summary>
        /// SSTRANO.
        /// </summary>
        public const string SSTRANO = "SSTRANO";

        /// <summary>
        /// SSTRANI.
        /// </summary>
        public const string SSTRANI = "SSTRANI";

        /// <summary>
        /// SSTCLOSE.
        /// </summary>
        public const string SSTCLOSE = "SSTCLOSE";

        /// <summary>
        /// SSTUNITS.
        /// </summary>
        public const string SSTUNITS = "SSTUNITS";

        /// <summary>
        /// SSTUNITR.
        /// </summary>
        public const string SSTUNITR = "SSTUNITR";

        /// <summary>
        /// SSSAS.
        /// </summary>
        public const string SSSAS = "SSSAS";

        /// <summary>
        /// SSSANS.
        /// </summary>
        public const string SSSANS = "SSSANS";

        /// <summary>
        /// SSUSAS.
        /// </summary>
        public const string SSUSAS = "SSUSAS";

        /// <summary>
        /// SSUSANS.
        /// </summary>
        public const string SSUSANS = "SSUSANS";

        /// <summary>
        /// SSSAC.
        /// </summary>
        public const string SSSAC = "SSSAC";

        /// <summary>
        /// SSSANC.
        /// </summary>
        public const string SSSANC = "SSSANC";

        /// <summary>
        /// SSSTARTS.
        /// </summary>
        public const string SSSTARTS = "SSSTARTS";

        /// <summary>
        /// SSTBKLG.
        /// </summary>
        public const string SSTBKLG = "SSTBKLG";

        /// <summary>
        /// SSTSALER.
        /// </summary>
        public const string SSTSALER = "SSTSALER";

        /// <summary>
        /// SSTCANR.
        /// </summary>
        public const string SSTCANR = "SSTCANR";

        /// <summary>
        /// SSTTROR.
        /// </summary>
        public const string SSTTROR = "SSTTROR";

        /// <summary>
        /// SSTTRIR.
        /// </summary>
        public const string SSTTRIR = "SSTTRIR";

        /// <summary>
        /// SSCLOSER.
        /// </summary>
        public const string SSCLOSER = "SSCLOSER";

        /// <summary>
        /// SSTBKLGR.
        /// </summary>
        public const string SSTBKLGR = "SSTBKLGR";

        /// <summary>
        /// SSTSP.
        /// </summary>
        public const string SSTSP = "SSTSP";

        /// <summary>
        /// SSOPRV1.
        /// </summary>
        public const string SSOPRV1 = "SSOPRV1";

        /// <summary>
        /// SSOPRV2.
        /// </summary>
        public const string SSOPRV2 = "SSOPRV2";

        /// <summary>
        /// SSOPRV3.
        /// </summary>
        public const string SSOPRV3 = "SSOPRV3";

        /// <summary>
        /// SSOPRV4.
        /// </summary>
        public const string SSOPRV4 = "SSOPRV4";

        /// <summary>
        /// SSOPRV5.
        /// </summary>
        public const string SSOPRV5 = "SSOPRV5";

        /// <summary>
        /// SSOPRV6.
        /// </summary>
        public const string SSOPRV6 = "SSOPRV6";

        /// <summary>
        /// SSOPRV7.
        /// </summary>
        public const string SSOPRV7 = "SSOPRV7";

        /// <summary>
        /// SSOPRV8.
        /// </summary>
        public const string SSOPRV8 = "SSOPRV8";

        /// <summary>
        /// SSOPRV9.
        /// </summary>
        public const string SSOPRV9 = "SSOPRV9";

        /// <summary>
        /// SSSABHP.
        /// </summary>
        public const string SSSABHP = "SSSABHP";

        /// <summary>
        /// SSSALP.
        /// </summary>
        public const string SSSALP = "SSSALP";

        /// <summary>
        /// SSSAINC.
        /// </summary>
        public const string SSSAINC = "SSSAINC";

        /// <summary>
        /// SSSAUPG.
        /// </summary>
        public const string SSSAUPG = "SSSAUPG";

        /// <summary>
        /// SSCLBHP.
        /// </summary>
        public const string SSCLBHP = "SSCLBHP";

        /// <summary>
        /// SSCLLP.
        /// </summary>
        public const string SSCLLP = "SSCLLP";

        /// <summary>
        /// SSCLINC.
        /// </summary>
        public const string SSCLINC = "SSCLINC";

        /// <summary>
        /// SSCLUPG.
        /// </summary>
        public const string SSCLUPG = "SSCLUPG";

        /// <summary>
        /// SSTIBHP.
        /// </summary>
        public const string SSTIBHP = "SSTIBHP";

        /// <summary>
        /// SSTILP.
        /// </summary>
        public const string SSTILP = "SSTILP";

        /// <summary>
        /// SSTIINC.
        /// </summary>
        public const string SSTIINC = "SSTIINC";

        /// <summary>
        /// SSTIUPG.
        /// </summary>
        public const string SSTIUPG = "SSTIUPG";

        /// <summary>
        /// SSTOBHP.
        /// </summary>
        public const string SSTOBHP = "SSTOBHP";

        /// <summary>
        /// SSTOLPR.
        /// </summary>
        public const string SSTOLPR = "SSTOLPR";

        /// <summary>
        /// SSTOINC.
        /// </summary>
        public const string SSTOINC = "SSTOINC";

        /// <summary>
        /// SSTOUPG.
        /// </summary>
        public const string SSTOUPG = "SSTOUPG";

        /// <summary>
        /// SSCABHP.
        /// </summary>
        public const string SSCABHP = "SSCABHP";

        /// <summary>
        /// SSCALPR.
        /// </summary>
        public const string SSCALPR = "SSCALPR";

        /// <summary>
        /// SSCAINC.
        /// </summary>
        public const string SSCAINC = "SSCAINC";

        /// <summary>
        /// SSCAUPG.
        /// </summary>
        public const string SSCAUPG = "SSCAUPG";

        /// <summary>
        /// SSUAMT01.
        /// </summary>
        public const string SSUAMT01 = "SSUAMT01";

        /// <summary>
        /// SSUAMT02.
        /// </summary>
        public const string SSUAMT02 = "SSUAMT02";

        /// <summary>
        /// SSUAMT03.
        /// </summary>
        public const string SSUAMT03 = "SSUAMT03";

        /// <summary>
        /// SSUAMT04.
        /// </summary>
        public const string SSUAMT04 = "SSUAMT04";

        /// <summary>
        /// SSUAMT05.
        /// </summary>
        public const string SSUAMT05 = "SSUAMT05";

        /// <summary>
        /// SSUAMT06.
        /// </summary>
        public const string SSUAMT06 = "SSUAMT06";

        /// <summary>
        /// SSUAMT07.
        /// </summary>
        public const string SSUAMT07 = "SSUAMT07";

        /// <summary>
        /// SSUAMT08.
        /// </summary>
        public const string SSUAMT08 = "SSUAMT08";

        /// <summary>
        /// SSUAMT09.
        /// </summary>
        public const string SSUAMT09 = "SSUAMT09";

        /// <summary>
        /// SSUAMT10.
        /// </summary>
        public const string SSUAMT10 = "SSUAMT10";

        /// <summary>
        /// SSUAMT11.
        /// </summary>
        public const string SSUAMT11 = "SSUAMT11";

        /// <summary>
        /// SSUAMT12.
        /// </summary>
        public const string SSUAMT12 = "SSUAMT12";

        /// <summary>
        /// SSUTOT1.
        /// </summary>
        public const string SSUTOT1 = "SSUTOT1";

        /// <summary>
        /// SSUTOT2.
        /// </summary>
        public const string SSUTOT2 = "SSUTOT2";

        /// <summary>
        /// SSUTOT3.
        /// </summary>
        public const string SSUTOT3 = "SSUTOT3";

        /// <summary>
        /// SSUTOT4.
        /// </summary>
        public const string SSUTOT4 = "SSUTOT4";

        /// <summary>
        /// SSUTOT5.
        /// </summary>
        public const string SSUTOT5 = "SSUTOT5";

        /// <summary>
        /// SSUTOT6.
        /// </summary>
        public const string SSUTOT6 = "SSUTOT6";

        /// <summary>
        /// SSUTOT7.
        /// </summary>
        public const string SSUTOT7 = "SSUTOT7";

        /// <summary>
        /// SSUTOT8.
        /// </summary>
        public const string SSUTOT8 = "SSUTOT8";

        /// <summary>
        /// SSUTOT9.
        /// </summary>
        public const string SSUTOT9 = "SSUTOT9";

        /// <summary>
        /// SSUTOT10.
        /// </summary>
        public const string SSUTOT10 = "SSUTOT10";

        /// <summary>
        /// SSF1A.
        /// </summary>
        public const string SSF1A = "SSF1A";

        /// <summary>
        /// SSF2A.
        /// </summary>
        public const string SSF2A = "SSF2A";

        /// <summary>
        /// SSF3A.
        /// </summary>
        public const string SSF3A = "SSF3A";

        /// <summary>
        /// SSF4A.
        /// </summary>
        public const string SSF4A = "SSF4A";

        /// <summary>
        /// SSF5A.
        /// </summary>
        public const string SSF5A = "SSF5A";

        /// <summary>
        /// SSF6A.
        /// </summary>
        public const string SSF6A = "SSF6A";

        /// <summary>
        /// SSFTOT1.
        /// </summary>
        public const string SSFTOT1 = "SSFTOT1";

        /// <summary>
        /// SSFTOT2.
        /// </summary>
        public const string SSFTOT2 = "SSFTOT2";

        /// <summary>
        /// SSFTOT3.
        /// </summary>
        public const string SSFTOT3 = "SSFTOT3";

        /// <summary>
        /// SSFTOT4.
        /// </summary>
        public const string SSFTOT4 = "SSFTOT4";

        /// <summary>
        /// SSFTOT5.
        /// </summary>
        public const string SSFTOT5 = "SSFTOT5";

        /// <summary>
        /// SSFTOT6.
        /// </summary>
        public const string SSFTOT6 = "SSFTOT6";

        /// <summary>
        /// SSCRTU.
        /// </summary>
        public const string SSCRTU = "SSCRTU";

        /// <summary>
        /// SSCRTJ.
        /// </summary>
        public const string SSCRTJ = "SSCRTJ";

        /// <summary>
        /// SSCRTT.
        /// </summary>
        public const string SSCRTT = "SSCRTT";

        /// <summary>
        /// SSWRKSTNID.
        /// </summary>
        public const string SSWRKSTNID = "SSWRKSTNID";

        /// <summary>
        /// SSJPID.
        /// </summary>
        public const string SSJPID = "SSJPID";

        /// <summary>
        /// SSUPMB.
        /// </summary>
        public const string SSUPMB = "SSUPMB";

        /// <summary>
        /// SSUPMJ.
        /// </summary>
        public const string SSUPMJ = "SSUPMJ";

        /// <summary>
        /// SSUPMT.
        /// </summary>
        public const string SSUPMT = "SSUPMT";

        /// <summary>
        /// SSJOBN.
        /// </summary>
        public const string SSJOBN = "SSJOBN";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H501S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSHBMCUS", "SSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SSCPHASE", "SSCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("SSCENTYR", "SSCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SSPTYPE", "SSPTYPE", JdeDataType.String, 2, true, true),
        new JdeField("SSFRP", "SSFRP", JdeDataType.Numeric, null, true, true),
        new JdeField("SSHBAREA", "SSHBAREA", JdeDataType.String, 6),
        new JdeField("SSSSPED", "SSSSPED", JdeDataType.Numeric),
        new JdeField("SSCO", "SSCO", JdeDataType.String, 10),
        new JdeField("SSTSALES", "SSTSALES", JdeDataType.Numeric),
        new JdeField("SSTCANS", "SSTCANS", JdeDataType.Numeric),
        new JdeField("SSTRANO", "SSTRANO", JdeDataType.Numeric),
        new JdeField("SSTRANI", "SSTRANI", JdeDataType.Numeric),
        new JdeField("SSTCLOSE", "SSTCLOSE", JdeDataType.Numeric),
        new JdeField("SSTUNITS", "SSTUNITS", JdeDataType.Numeric),
        new JdeField("SSTUNITR", "SSTUNITR", JdeDataType.Numeric),
        new JdeField("SSSAS", "SSSAS", JdeDataType.Numeric),
        new JdeField("SSSANS", "SSSANS", JdeDataType.Numeric),
        new JdeField("SSUSAS", "SSUSAS", JdeDataType.Numeric),
        new JdeField("SSUSANS", "SSUSANS", JdeDataType.Numeric),
        new JdeField("SSSAC", "SSSAC", JdeDataType.Numeric),
        new JdeField("SSSANC", "SSSANC", JdeDataType.Numeric),
        new JdeField("SSSTARTS", "SSSTARTS", JdeDataType.Numeric),
        new JdeField("SSTBKLG", "SSTBKLG", JdeDataType.Numeric),
        new JdeField("SSTSALER", "SSTSALER", JdeDataType.Numeric),
        new JdeField("SSTCANR", "SSTCANR", JdeDataType.Numeric),
        new JdeField("SSTTROR", "SSTTROR", JdeDataType.Numeric),
        new JdeField("SSTTRIR", "SSTTRIR", JdeDataType.Numeric),
        new JdeField("SSCLOSER", "SSCLOSER", JdeDataType.Numeric),
        new JdeField("SSTBKLGR", "SSTBKLGR", JdeDataType.Numeric),
        new JdeField("SSTSP", "SSTSP", JdeDataType.Numeric),
        new JdeField("SSOPRV1", "SSOPRV1", JdeDataType.Numeric),
        new JdeField("SSOPRV2", "SSOPRV2", JdeDataType.Numeric),
        new JdeField("SSOPRV3", "SSOPRV3", JdeDataType.Numeric),
        new JdeField("SSOPRV4", "SSOPRV4", JdeDataType.Numeric),
        new JdeField("SSOPRV5", "SSOPRV5", JdeDataType.Numeric),
        new JdeField("SSOPRV6", "SSOPRV6", JdeDataType.Numeric),
        new JdeField("SSOPRV7", "SSOPRV7", JdeDataType.Numeric),
        new JdeField("SSOPRV8", "SSOPRV8", JdeDataType.Numeric),
        new JdeField("SSOPRV9", "SSOPRV9", JdeDataType.Numeric),
        new JdeField("SSSABHP", "SSSABHP", JdeDataType.Numeric),
        new JdeField("SSSALP", "SSSALP", JdeDataType.Numeric),
        new JdeField("SSSAINC", "SSSAINC", JdeDataType.Numeric),
        new JdeField("SSSAUPG", "SSSAUPG", JdeDataType.Numeric),
        new JdeField("SSCLBHP", "SSCLBHP", JdeDataType.Numeric),
        new JdeField("SSCLLP", "SSCLLP", JdeDataType.Numeric),
        new JdeField("SSCLINC", "SSCLINC", JdeDataType.Numeric),
        new JdeField("SSCLUPG", "SSCLUPG", JdeDataType.Numeric),
        new JdeField("SSTIBHP", "SSTIBHP", JdeDataType.Numeric),
        new JdeField("SSTILP", "SSTILP", JdeDataType.Numeric),
        new JdeField("SSTIINC", "SSTIINC", JdeDataType.Numeric),
        new JdeField("SSTIUPG", "SSTIUPG", JdeDataType.Numeric),
        new JdeField("SSTOBHP", "SSTOBHP", JdeDataType.Numeric),
        new JdeField("SSTOLPR", "SSTOLPR", JdeDataType.Numeric),
        new JdeField("SSTOINC", "SSTOINC", JdeDataType.Numeric),
        new JdeField("SSTOUPG", "SSTOUPG", JdeDataType.Numeric),
        new JdeField("SSCABHP", "SSCABHP", JdeDataType.Numeric),
        new JdeField("SSCALPR", "SSCALPR", JdeDataType.Numeric),
        new JdeField("SSCAINC", "SSCAINC", JdeDataType.Numeric),
        new JdeField("SSCAUPG", "SSCAUPG", JdeDataType.Numeric),
        new JdeField("SSUAMT01", "SSUAMT01", JdeDataType.Numeric),
        new JdeField("SSUAMT02", "SSUAMT02", JdeDataType.Numeric),
        new JdeField("SSUAMT03", "SSUAMT03", JdeDataType.Numeric),
        new JdeField("SSUAMT04", "SSUAMT04", JdeDataType.Numeric),
        new JdeField("SSUAMT05", "SSUAMT05", JdeDataType.Numeric),
        new JdeField("SSUAMT06", "SSUAMT06", JdeDataType.Numeric),
        new JdeField("SSUAMT07", "SSUAMT07", JdeDataType.Numeric),
        new JdeField("SSUAMT08", "SSUAMT08", JdeDataType.Numeric),
        new JdeField("SSUAMT09", "SSUAMT09", JdeDataType.Numeric),
        new JdeField("SSUAMT10", "SSUAMT10", JdeDataType.Numeric),
        new JdeField("SSUAMT11", "SSUAMT11", JdeDataType.Numeric),
        new JdeField("SSUAMT12", "SSUAMT12", JdeDataType.Numeric),
        new JdeField("SSUTOT1", "SSUTOT1", JdeDataType.Numeric),
        new JdeField("SSUTOT2", "SSUTOT2", JdeDataType.Numeric),
        new JdeField("SSUTOT3", "SSUTOT3", JdeDataType.Numeric),
        new JdeField("SSUTOT4", "SSUTOT4", JdeDataType.Numeric),
        new JdeField("SSUTOT5", "SSUTOT5", JdeDataType.Numeric),
        new JdeField("SSUTOT6", "SSUTOT6", JdeDataType.Numeric),
        new JdeField("SSUTOT7", "SSUTOT7", JdeDataType.Numeric),
        new JdeField("SSUTOT8", "SSUTOT8", JdeDataType.Numeric),
        new JdeField("SSUTOT9", "SSUTOT9", JdeDataType.Numeric),
        new JdeField("SSUTOT10", "SSUTOT10", JdeDataType.Numeric),
        new JdeField("SSF1A", "SSF1A", JdeDataType.Numeric),
        new JdeField("SSF2A", "SSF2A", JdeDataType.Numeric),
        new JdeField("SSF3A", "SSF3A", JdeDataType.Numeric),
        new JdeField("SSF4A", "SSF4A", JdeDataType.Numeric),
        new JdeField("SSF5A", "SSF5A", JdeDataType.Numeric),
        new JdeField("SSF6A", "SSF6A", JdeDataType.Numeric),
        new JdeField("SSFTOT1", "SSFTOT1", JdeDataType.Numeric),
        new JdeField("SSFTOT2", "SSFTOT2", JdeDataType.Numeric),
        new JdeField("SSFTOT3", "SSFTOT3", JdeDataType.Numeric),
        new JdeField("SSFTOT4", "SSFTOT4", JdeDataType.Numeric),
        new JdeField("SSFTOT5", "SSFTOT5", JdeDataType.Numeric),
        new JdeField("SSFTOT6", "SSFTOT6", JdeDataType.Numeric),
        new JdeField("SSCRTU", "SSCRTU", JdeDataType.String, 20),
        new JdeField("SSCRTJ", "SSCRTJ", JdeDataType.Numeric),
        new JdeField("SSCRTT", "SSCRTT", JdeDataType.Numeric),
        new JdeField("SSWRKSTNID", "SSWRKSTNID", JdeDataType.String, 20),
        new JdeField("SSJPID", "SSJPID", JdeDataType.String, 20),
        new JdeField("SSUPMB", "SSUPMB", JdeDataType.String, 20),
        new JdeField("SSUPMJ", "SSUPMJ", JdeDataType.Numeric),
        new JdeField("SSUPMT", "SSUPMT", JdeDataType.Numeric),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H501S_0", "Primary Key on SSHBMCUS, SSCPHASE, SSCENTYR, SSPTYPE, SSFRP", new[] { "SSHBMCUS", "SSCPHASE", "SSCENTYR", "SSPTYPE", "SSFRP" }, isUnique: true, isPrimaryKey: true)
    };
}
