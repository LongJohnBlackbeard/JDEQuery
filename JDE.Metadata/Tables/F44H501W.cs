using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H501W - .
/// </summary>
public class F44H501W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSJOBS.
        /// </summary>
        public const string SSJOBS = "SSJOBS";

        /// <summary>
        /// SSPTYPE.
        /// </summary>
        public const string SSPTYPE = "SSPTYPE";

        /// <summary>
        /// SSHBAREA.
        /// </summary>
        public const string SSHBAREA = "SSHBAREA";

        /// <summary>
        /// SSHBMCUS.
        /// </summary>
        public const string SSHBMCUS = "SSHBMCUS";

        /// <summary>
        /// SSCPHASE.
        /// </summary>
        public const string SSCPHASE = "SSCPHASE";

        /// <summary>
        /// SSHBLOT.
        /// </summary>
        public const string SSHBLOT = "SSHBLOT";

        /// <summary>
        /// SSCSSEQ.
        /// </summary>
        public const string SSCSSEQ = "SSCSSEQ";

        /// <summary>
        /// SSDTALVL.
        /// </summary>
        public const string SSDTALVL = "SSDTALVL";

        /// <summary>
        /// SSCO.
        /// </summary>
        public const string SSCO = "SSCO";

        /// <summary>
        /// SSHBSCS.
        /// </summary>
        public const string SSHBSCS = "SSHBSCS";

        /// <summary>
        /// SSMDLHF.
        /// </summary>
        public const string SSMDLHF = "SSMDLHF";

        /// <summary>
        /// SSSDJ.
        /// </summary>
        public const string SSSDJ = "SSSDJ";

        /// <summary>
        /// SSCDJ.
        /// </summary>
        public const string SSCDJ = "SSCDJ";

        /// <summary>
        /// SSEDJ.
        /// </summary>
        public const string SSEDJ = "SSEDJ";

        /// <summary>
        /// SSTEDJ.
        /// </summary>
        public const string SSTEDJ = "SSTEDJ";

        /// <summary>
        /// SSTIDJ.
        /// </summary>
        public const string SSTIDJ = "SSTIDJ";

        /// <summary>
        /// SSLCSJ.
        /// </summary>
        public const string SSLCSJ = "SSLCSJ";

        /// <summary>
        /// SSLCCJ.
        /// </summary>
        public const string SSLCCJ = "SSLCCJ";

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
        /// SSNSAC.
        /// </summary>
        public const string SSNSAC = "SSNSAC";

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
        /// SSHBOPID.
        /// </summary>
        public const string SSHBOPID = "SSHBOPID";

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
    public override string TableName => "F44H501W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSJOBS", "SSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SSPTYPE", "SSPTYPE", JdeDataType.String, 2, true, true),
        new JdeField("SSHBAREA", "SSHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("SSHBMCUS", "SSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SSCPHASE", "SSCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("SSHBLOT", "SSHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("SSCSSEQ", "SSCSSEQ", JdeDataType.String, 6, true, true),
        new JdeField("SSDTALVL", "SSDTALVL", JdeDataType.String, 2, true, true),
        new JdeField("SSCO", "SSCO", JdeDataType.String, 10),
        new JdeField("SSHBSCS", "SSHBSCS", JdeDataType.String, 6),
        new JdeField("SSMDLHF", "SSMDLHF", JdeDataType.String, 2),
        new JdeField("SSSDJ", "SSSDJ", JdeDataType.Numeric),
        new JdeField("SSCDJ", "SSCDJ", JdeDataType.Numeric),
        new JdeField("SSEDJ", "SSEDJ", JdeDataType.Numeric),
        new JdeField("SSTEDJ", "SSTEDJ", JdeDataType.Numeric),
        new JdeField("SSTIDJ", "SSTIDJ", JdeDataType.Numeric),
        new JdeField("SSLCSJ", "SSLCSJ", JdeDataType.Numeric),
        new JdeField("SSLCCJ", "SSLCCJ", JdeDataType.Numeric),
        new JdeField("SSTSALES", "SSTSALES", JdeDataType.Numeric),
        new JdeField("SSTCANS", "SSTCANS", JdeDataType.Numeric),
        new JdeField("SSTRANO", "SSTRANO", JdeDataType.Numeric),
        new JdeField("SSTRANI", "SSTRANI", JdeDataType.Numeric),
        new JdeField("SSTCLOSE", "SSTCLOSE", JdeDataType.Numeric),
        new JdeField("SSTUNITR", "SSTUNITR", JdeDataType.Numeric),
        new JdeField("SSSAS", "SSSAS", JdeDataType.Numeric),
        new JdeField("SSSANS", "SSSANS", JdeDataType.Numeric),
        new JdeField("SSUSAS", "SSUSAS", JdeDataType.Numeric),
        new JdeField("SSUSANS", "SSUSANS", JdeDataType.Numeric),
        new JdeField("SSSAC", "SSSAC", JdeDataType.Numeric),
        new JdeField("SSSANC", "SSSANC", JdeDataType.Numeric),
        new JdeField("SSNSAC", "SSNSAC", JdeDataType.Numeric),
        new JdeField("SSSTARTS", "SSSTARTS", JdeDataType.Numeric),
        new JdeField("SSTBKLG", "SSTBKLG", JdeDataType.Numeric),
        new JdeField("SSTSALER", "SSTSALER", JdeDataType.Numeric),
        new JdeField("SSTCANR", "SSTCANR", JdeDataType.Numeric),
        new JdeField("SSTTROR", "SSTTROR", JdeDataType.Numeric),
        new JdeField("SSTTRIR", "SSTTRIR", JdeDataType.Numeric),
        new JdeField("SSCLOSER", "SSCLOSER", JdeDataType.Numeric),
        new JdeField("SSTBKLGR", "SSTBKLGR", JdeDataType.Numeric),
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
        new JdeField("SSHBOPID", "SSHBOPID", JdeDataType.String, 20),
        new JdeField("SSUPMB", "SSUPMB", JdeDataType.String, 20),
        new JdeField("SSUPMJ", "SSUPMJ", JdeDataType.Numeric),
        new JdeField("SSUPMT", "SSUPMT", JdeDataType.Numeric),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H501W_0", "Primary Key on SSJOBS, SSHBAREA, SSHBMCUS, SSCPHASE, SSHBLOT, SSCSSEQ, SSPTYPE, SSDTALVL", new[] { "SSJOBS", "SSHBAREA", "SSHBMCUS", "SSCPHASE", "SSHBLOT", "SSCSSEQ", "SSPTYPE", "SSDTALVL" }, isUnique: true, isPrimaryKey: true)
    };
}
