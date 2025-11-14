using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G150 - .
/// </summary>
public class F40G150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPWVID.
        /// </summary>
        public const string CPWVID = "CPWVID";

        /// <summary>
        /// CPWTNUM.
        /// </summary>
        public const string CPWTNUM = "CPWTNUM";

        /// <summary>
        /// CPWASDT.
        /// </summary>
        public const string CPWASDT = "CPWASDT";

        /// <summary>
        /// CPITM.
        /// </summary>
        public const string CPITM = "CPITM";

        /// <summary>
        /// CPBLACT.
        /// </summary>
        public const string CPBLACT = "CPBLACT";

        /// <summary>
        /// CPMATYP.
        /// </summary>
        public const string CPMATYP = "CPMATYP";

        /// <summary>
        /// CPMCU.
        /// </summary>
        public const string CPMCU = "CPMCU";

        /// <summary>
        /// CPWCFGID.
        /// </summary>
        public const string CPWCFGID = "CPWCFGID";

        /// <summary>
        /// CPTPCD.
        /// </summary>
        public const string CPTPCD = "CPTPCD";

        /// <summary>
        /// CPSPAFLG.
        /// </summary>
        public const string CPSPAFLG = "CPSPAFLG";

        /// <summary>
        /// CPBLUID.
        /// </summary>
        public const string CPBLUID = "CPBLUID";

        /// <summary>
        /// CPBLSCD2.
        /// </summary>
        public const string CPBLSCD2 = "CPBLSCD2";

        /// <summary>
        /// CPHARPER.
        /// </summary>
        public const string CPHARPER = "CPHARPER";

        /// <summary>
        /// CPHARSFX.
        /// </summary>
        public const string CPHARSFX = "CPHARSFX";

        /// <summary>
        /// CPVARID.
        /// </summary>
        public const string CPVARID = "CPVARID";

        /// <summary>
        /// CPVARCODE.
        /// </summary>
        public const string CPVARCODE = "CPVARCODE";

        /// <summary>
        /// CPVARLNAME.
        /// </summary>
        public const string CPVARLNAME = "CPVARLNAME";

        /// <summary>
        /// CPGDISTR.
        /// </summary>
        public const string CPGDISTR = "CPGDISTR";

        /// <summary>
        /// CPAN8V.
        /// </summary>
        public const string CPAN8V = "CPAN8V";

        /// <summary>
        /// CPPURCHCAT.
        /// </summary>
        public const string CPPURCHCAT = "CPPURCHCAT";

        /// <summary>
        /// CPCRPRDTL.
        /// </summary>
        public const string CPCRPRDTL = "CPCRPRDTL";

        /// <summary>
        /// CPRESELL.
        /// </summary>
        public const string CPRESELL = "CPRESELL";

        /// <summary>
        /// CPREPURCH.
        /// </summary>
        public const string CPREPURCH = "CPREPURCH";

        /// <summary>
        /// CPEXTCRUSH.
        /// </summary>
        public const string CPEXTCRUSH = "CPEXTCRUSH";

        /// <summary>
        /// CPCRUSHSVC.
        /// </summary>
        public const string CPCRUSHSVC = "CPCRUSHSVC";

        /// <summary>
        /// CPQTRC.
        /// </summary>
        public const string CPQTRC = "CPQTRC";

        /// <summary>
        /// CPWVUM.
        /// </summary>
        public const string CPWVUM = "CPWVUM";

        /// <summary>
        /// CPPURERQ.
        /// </summary>
        public const string CPPURERQ = "CPPURERQ";

        /// <summary>
        /// CPNMFRVAL.
        /// </summary>
        public const string CPNMFRVAL = "CPNMFRVAL";

        /// <summary>
        /// CPAN8.
        /// </summary>
        public const string CPAN8 = "CPAN8";

        /// <summary>
        /// CPSPASPR.
        /// </summary>
        public const string CPSPASPR = "CPSPASPR";

        /// <summary>
        /// CPUOM.
        /// </summary>
        public const string CPUOM = "CPUOM";

        /// <summary>
        /// CPCDQTRC.
        /// </summary>
        public const string CPCDQTRC = "CPCDQTRC";

        /// <summary>
        /// CPCDWVUM.
        /// </summary>
        public const string CPCDWVUM = "CPCDWVUM";

        /// <summary>
        /// CPCDNFRVAL.
        /// </summary>
        public const string CPCDNFRVAL = "CPCDNFRVAL";

        /// <summary>
        /// CPPDQTRC.
        /// </summary>
        public const string CPPDQTRC = "CPPDQTRC";

        /// <summary>
        /// CPPDWVUM.
        /// </summary>
        public const string CPPDWVUM = "CPPDWVUM";

        /// <summary>
        /// CPPDPRQTRC.
        /// </summary>
        public const string CPPDPRQTRC = "CPPDPRQTRC";

        /// <summary>
        /// CPNONRRQTY.
        /// </summary>
        public const string CPNONRRQTY = "CPNONRRQTY";

        /// <summary>
        /// CPPURENRRQ.
        /// </summary>
        public const string CPPURENRRQ = "CPPURENRRQ";

        /// <summary>
        /// CPUPRC.
        /// </summary>
        public const string CPUPRC = "CPUPRC";

        /// <summary>
        /// CPUOM3.
        /// </summary>
        public const string CPUOM3 = "CPUOM3";

        /// <summary>
        /// CPAMIN.
        /// </summary>
        public const string CPAMIN = "CPAMIN";

        /// <summary>
        /// CPAMAX.
        /// </summary>
        public const string CPAMAX = "CPAMAX";

        /// <summary>
        /// CPADJUPRC.
        /// </summary>
        public const string CPADJUPRC = "CPADJUPRC";

        /// <summary>
        /// CPALQTRG.
        /// </summary>
        public const string CPALQTRG = "CPALQTRG";

        /// <summary>
        /// CPALMIN.
        /// </summary>
        public const string CPALMIN = "CPALMIN";

        /// <summary>
        /// CPALMAX.
        /// </summary>
        public const string CPALMAX = "CPALMAX";

        /// <summary>
        /// CPAREC.
        /// </summary>
        public const string CPAREC = "CPAREC";

        /// <summary>
        /// CPAPTD.
        /// </summary>
        public const string CPAPTD = "CPAPTD";

        /// <summary>
        /// CPPDFRVAL.
        /// </summary>
        public const string CPPDFRVAL = "CPPDFRVAL";

        /// <summary>
        /// CPDSTLMRQ.
        /// </summary>
        public const string CPDSTLMRQ = "CPDSTLMRQ";

        /// <summary>
        /// CPDMWVUM.
        /// </summary>
        public const string CPDMWVUM = "CPDMWVUM";

        /// <summary>
        /// CPPUREDMRQ.
        /// </summary>
        public const string CPPUREDMRQ = "CPPUREDMRQ";

        /// <summary>
        /// CPDMPDAREC.
        /// </summary>
        public const string CPDMPDAREC = "CPDMPDAREC";

        /// <summary>
        /// CPDMPDAPDT.
        /// </summary>
        public const string CPDMPDAPDT = "CPDMPDAPDT";

        /// <summary>
        /// CPDMPDRVAL.
        /// </summary>
        public const string CPDMPDRVAL = "CPDMPDRVAL";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPTORG.
        /// </summary>
        public const string CPTORG = "CPTORG";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPMKEY.
        /// </summary>
        public const string CPMKEY = "CPMKEY";

        /// <summary>
        /// CPUUPMJ.
        /// </summary>
        public const string CPUUPMJ = "CPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPWVID", "CPWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPWTNUM", "CPWTNUM", JdeDataType.String, 60),
        new JdeField("CPWASDT", "CPWASDT", JdeDataType.Date),
        new JdeField("CPITM", "CPITM", JdeDataType.Numeric),
        new JdeField("CPBLACT", "CPBLACT", JdeDataType.String, 2),
        new JdeField("CPMATYP", "CPMATYP", JdeDataType.String, 8),
        new JdeField("CPMCU", "CPMCU", JdeDataType.String, 24),
        new JdeField("CPWCFGID", "CPWCFGID", JdeDataType.Numeric),
        new JdeField("CPTPCD", "CPTPCD", JdeDataType.String, 2),
        new JdeField("CPSPAFLG", "CPSPAFLG", JdeDataType.String, 2),
        new JdeField("CPBLUID", "CPBLUID", JdeDataType.Numeric),
        new JdeField("CPBLSCD2", "CPBLSCD2", JdeDataType.String, 20),
        new JdeField("CPHARPER", "CPHARPER", JdeDataType.String, 12),
        new JdeField("CPHARSFX", "CPHARSFX", JdeDataType.String, 20),
        new JdeField("CPVARID", "CPVARID", JdeDataType.Numeric),
        new JdeField("CPVARCODE", "CPVARCODE", JdeDataType.String, 10),
        new JdeField("CPVARLNAME", "CPVARLNAME", JdeDataType.String, 60),
        new JdeField("CPGDISTR", "CPGDISTR", JdeDataType.String, 20),
        new JdeField("CPAN8V", "CPAN8V", JdeDataType.Numeric),
        new JdeField("CPPURCHCAT", "CPPURCHCAT", JdeDataType.String, 2),
        new JdeField("CPCRPRDTL", "CPCRPRDTL", JdeDataType.String, 2),
        new JdeField("CPRESELL", "CPRESELL", JdeDataType.String, 2),
        new JdeField("CPREPURCH", "CPREPURCH", JdeDataType.String, 2),
        new JdeField("CPEXTCRUSH", "CPEXTCRUSH", JdeDataType.String, 2),
        new JdeField("CPCRUSHSVC", "CPCRUSHSVC", JdeDataType.String, 2),
        new JdeField("CPQTRC", "CPQTRC", JdeDataType.Numeric),
        new JdeField("CPWVUM", "CPWVUM", JdeDataType.String, 6),
        new JdeField("CPPURERQ", "CPPURERQ", JdeDataType.Numeric),
        new JdeField("CPNMFRVAL", "CPNMFRVAL", JdeDataType.Numeric),
        new JdeField("CPAN8", "CPAN8", JdeDataType.Numeric),
        new JdeField("CPSPASPR", "CPSPASPR", JdeDataType.Numeric),
        new JdeField("CPUOM", "CPUOM", JdeDataType.String, 4),
        new JdeField("CPCDQTRC", "CPCDQTRC", JdeDataType.Numeric),
        new JdeField("CPCDWVUM", "CPCDWVUM", JdeDataType.String, 6),
        new JdeField("CPCDNFRVAL", "CPCDNFRVAL", JdeDataType.Numeric),
        new JdeField("CPPDQTRC", "CPPDQTRC", JdeDataType.Numeric),
        new JdeField("CPPDWVUM", "CPPDWVUM", JdeDataType.String, 6),
        new JdeField("CPPDPRQTRC", "CPPDPRQTRC", JdeDataType.Numeric),
        new JdeField("CPNONRRQTY", "CPNONRRQTY", JdeDataType.Numeric),
        new JdeField("CPPURENRRQ", "CPPURENRRQ", JdeDataType.Numeric),
        new JdeField("CPUPRC", "CPUPRC", JdeDataType.Numeric),
        new JdeField("CPUOM3", "CPUOM3", JdeDataType.String, 4),
        new JdeField("CPAMIN", "CPAMIN", JdeDataType.String, 30),
        new JdeField("CPAMAX", "CPAMAX", JdeDataType.String, 30),
        new JdeField("CPADJUPRC", "CPADJUPRC", JdeDataType.Numeric),
        new JdeField("CPALQTRG", "CPALQTRG", JdeDataType.String, 30),
        new JdeField("CPALMIN", "CPALMIN", JdeDataType.String, 30),
        new JdeField("CPALMAX", "CPALMAX", JdeDataType.String, 30),
        new JdeField("CPAREC", "CPAREC", JdeDataType.Numeric),
        new JdeField("CPAPTD", "CPAPTD", JdeDataType.Numeric),
        new JdeField("CPPDFRVAL", "CPPDFRVAL", JdeDataType.Numeric),
        new JdeField("CPDSTLMRQ", "CPDSTLMRQ", JdeDataType.Numeric),
        new JdeField("CPDMWVUM", "CPDMWVUM", JdeDataType.String, 6),
        new JdeField("CPPUREDMRQ", "CPPUREDMRQ", JdeDataType.Numeric),
        new JdeField("CPDMPDAREC", "CPDMPDAREC", JdeDataType.Numeric),
        new JdeField("CPDMPDAPDT", "CPDMPDAPDT", JdeDataType.Numeric),
        new JdeField("CPDMPDRVAL", "CPDMPDRVAL", JdeDataType.Numeric),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPTORG", "CPTORG", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPMKEY", "CPMKEY", JdeDataType.String, 30),
        new JdeField("CPUUPMJ", "CPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G150_0", "Primary Key on CPWVID", new[] { "CPWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G150_2", "Index on CPVARLNAME, CPGDISTR, CPWVID", new[] { "CPVARLNAME", "CPGDISTR", "CPWVID" }),
        new JdeIndex("F40G150_3", "Index on CPVARID, CPGDISTR, CPUPRC, CPAMIN, CPAMAX, CPADJUPRC, CPALQTRG, CPALMIN, CPALMAX", new[] { "CPVARID", "CPGDISTR", "CPUPRC", "CPAMIN", "CPAMAX", "CPADJUPRC", "CPALQTRG", "CPALMIN", "CPALMAX" })
    };
}
