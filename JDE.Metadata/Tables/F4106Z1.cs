using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4106Z1 - .
/// </summary>
public class F4106Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZEFTJ.
        /// </summary>
        public const string SZEFTJ = "SZEFTJ";

        /// <summary>
        /// SZEXDJ.
        /// </summary>
        public const string SZEXDJ = "SZEXDJ";

        /// <summary>
        /// SZPRGR.
        /// </summary>
        public const string SZPRGR = "SZPRGR";

        /// <summary>
        /// SZCPGP.
        /// </summary>
        public const string SZCPGP = "SZCPGP";

        /// <summary>
        /// SZPRHN.
        /// </summary>
        public const string SZPRHN = "SZPRHN";

        /// <summary>
        /// SZUPRC.
        /// </summary>
        public const string SZUPRC = "SZUPRC";

        /// <summary>
        /// SZLOTG.
        /// </summary>
        public const string SZLOTG = "SZLOTG";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZACRD.
        /// </summary>
        public const string SZACRD = "SZACRD";

        /// <summary>
        /// SZAPRS.
        /// </summary>
        public const string SZAPRS = "SZAPRS";

        /// <summary>
        /// SZSRP1.
        /// </summary>
        public const string SZSRP1 = "SZSRP1";

        /// <summary>
        /// SZSRP2.
        /// </summary>
        public const string SZSRP2 = "SZSRP2";

        /// <summary>
        /// SZSRP3.
        /// </summary>
        public const string SZSRP3 = "SZSRP3";

        /// <summary>
        /// SZSRP4.
        /// </summary>
        public const string SZSRP4 = "SZSRP4";

        /// <summary>
        /// SZSRP5.
        /// </summary>
        public const string SZSRP5 = "SZSRP5";

        /// <summary>
        /// SZCARS.
        /// </summary>
        public const string SZCARS = "SZCARS";

        /// <summary>
        /// SZPRP1.
        /// </summary>
        public const string SZPRP1 = "SZPRP1";

        /// <summary>
        /// SZPRP2.
        /// </summary>
        public const string SZPRP2 = "SZPRP2";

        /// <summary>
        /// SZPRP3.
        /// </summary>
        public const string SZPRP3 = "SZPRP3";

        /// <summary>
        /// SZPRP4.
        /// </summary>
        public const string SZPRP4 = "SZPRP4";

        /// <summary>
        /// SZPRP5.
        /// </summary>
        public const string SZPRP5 = "SZPRP5";

        /// <summary>
        /// SZCARP.
        /// </summary>
        public const string SZCARP = "SZCARP";

        /// <summary>
        /// SZSHCN.
        /// </summary>
        public const string SZSHCN = "SZSHCN";

        /// <summary>
        /// SZSHCM.
        /// </summary>
        public const string SZSHCM = "SZSHCM";

        /// <summary>
        /// SZCYCL.
        /// </summary>
        public const string SZCYCL = "SZCYCL";

        /// <summary>
        /// SZPRP6.
        /// </summary>
        public const string SZPRP6 = "SZPRP6";

        /// <summary>
        /// SZPRP7.
        /// </summary>
        public const string SZPRP7 = "SZPRP7";

        /// <summary>
        /// SZPRP8.
        /// </summary>
        public const string SZPRP8 = "SZPRP8";

        /// <summary>
        /// SZPRP9.
        /// </summary>
        public const string SZPRP9 = "SZPRP9";

        /// <summary>
        /// SZPRP0.
        /// </summary>
        public const string SZPRP0 = "SZPRP0";

        /// <summary>
        /// SZSRP6.
        /// </summary>
        public const string SZSRP6 = "SZSRP6";

        /// <summary>
        /// SZSRP7.
        /// </summary>
        public const string SZSRP7 = "SZSRP7";

        /// <summary>
        /// SZSRP8.
        /// </summary>
        public const string SZSRP8 = "SZSRP8";

        /// <summary>
        /// SZSRP9.
        /// </summary>
        public const string SZSRP9 = "SZSRP9";

        /// <summary>
        /// SZSRP0.
        /// </summary>
        public const string SZSRP0 = "SZSRP0";

        /// <summary>
        /// SZAC01.
        /// </summary>
        public const string SZAC01 = "SZAC01";

        /// <summary>
        /// SZAC02.
        /// </summary>
        public const string SZAC02 = "SZAC02";

        /// <summary>
        /// SZAC03.
        /// </summary>
        public const string SZAC03 = "SZAC03";

        /// <summary>
        /// SZAC04.
        /// </summary>
        public const string SZAC04 = "SZAC04";

        /// <summary>
        /// SZAC05.
        /// </summary>
        public const string SZAC05 = "SZAC05";

        /// <summary>
        /// SZAC06.
        /// </summary>
        public const string SZAC06 = "SZAC06";

        /// <summary>
        /// SZAC07.
        /// </summary>
        public const string SZAC07 = "SZAC07";

        /// <summary>
        /// SZAC08.
        /// </summary>
        public const string SZAC08 = "SZAC08";

        /// <summary>
        /// SZAC09.
        /// </summary>
        public const string SZAC09 = "SZAC09";

        /// <summary>
        /// SZAC10.
        /// </summary>
        public const string SZAC10 = "SZAC10";

        /// <summary>
        /// SZAC11.
        /// </summary>
        public const string SZAC11 = "SZAC11";

        /// <summary>
        /// SZAC12.
        /// </summary>
        public const string SZAC12 = "SZAC12";

        /// <summary>
        /// SZAC13.
        /// </summary>
        public const string SZAC13 = "SZAC13";

        /// <summary>
        /// SZAC14.
        /// </summary>
        public const string SZAC14 = "SZAC14";

        /// <summary>
        /// SZAC15.
        /// </summary>
        public const string SZAC15 = "SZAC15";

        /// <summary>
        /// SZAC16.
        /// </summary>
        public const string SZAC16 = "SZAC16";

        /// <summary>
        /// SZAC17.
        /// </summary>
        public const string SZAC17 = "SZAC17";

        /// <summary>
        /// SZAC18.
        /// </summary>
        public const string SZAC18 = "SZAC18";

        /// <summary>
        /// SZAC19.
        /// </summary>
        public const string SZAC19 = "SZAC19";

        /// <summary>
        /// SZAC20.
        /// </summary>
        public const string SZAC20 = "SZAC20";

        /// <summary>
        /// SZAC21.
        /// </summary>
        public const string SZAC21 = "SZAC21";

        /// <summary>
        /// SZAC22.
        /// </summary>
        public const string SZAC22 = "SZAC22";

        /// <summary>
        /// SZAC23.
        /// </summary>
        public const string SZAC23 = "SZAC23";

        /// <summary>
        /// SZAC24.
        /// </summary>
        public const string SZAC24 = "SZAC24";

        /// <summary>
        /// SZAC25.
        /// </summary>
        public const string SZAC25 = "SZAC25";

        /// <summary>
        /// SZAC26.
        /// </summary>
        public const string SZAC26 = "SZAC26";

        /// <summary>
        /// SZAC27.
        /// </summary>
        public const string SZAC27 = "SZAC27";

        /// <summary>
        /// SZAC28.
        /// </summary>
        public const string SZAC28 = "SZAC28";

        /// <summary>
        /// SZAC29.
        /// </summary>
        public const string SZAC29 = "SZAC29";

        /// <summary>
        /// SZAC30.
        /// </summary>
        public const string SZAC30 = "SZAC30";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4106Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZEFTJ", "SZEFTJ", JdeDataType.Numeric),
        new JdeField("SZEXDJ", "SZEXDJ", JdeDataType.Numeric),
        new JdeField("SZPRGR", "SZPRGR", JdeDataType.String, 16),
        new JdeField("SZCPGP", "SZCPGP", JdeDataType.String, 16),
        new JdeField("SZPRHN", "SZPRHN", JdeDataType.Numeric),
        new JdeField("SZUPRC", "SZUPRC", JdeDataType.Numeric),
        new JdeField("SZLOTG", "SZLOTG", JdeDataType.String, 6),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZACRD", "SZACRD", JdeDataType.Numeric),
        new JdeField("SZAPRS", "SZAPRS", JdeDataType.String, 2),
        new JdeField("SZSRP1", "SZSRP1", JdeDataType.String, 6),
        new JdeField("SZSRP2", "SZSRP2", JdeDataType.String, 6),
        new JdeField("SZSRP3", "SZSRP3", JdeDataType.String, 6),
        new JdeField("SZSRP4", "SZSRP4", JdeDataType.String, 6),
        new JdeField("SZSRP5", "SZSRP5", JdeDataType.String, 6),
        new JdeField("SZCARS", "SZCARS", JdeDataType.Numeric),
        new JdeField("SZPRP1", "SZPRP1", JdeDataType.String, 6),
        new JdeField("SZPRP2", "SZPRP2", JdeDataType.String, 6),
        new JdeField("SZPRP3", "SZPRP3", JdeDataType.String, 6),
        new JdeField("SZPRP4", "SZPRP4", JdeDataType.String, 6),
        new JdeField("SZPRP5", "SZPRP5", JdeDataType.String, 6),
        new JdeField("SZCARP", "SZCARP", JdeDataType.Numeric),
        new JdeField("SZSHCN", "SZSHCN", JdeDataType.String, 6),
        new JdeField("SZSHCM", "SZSHCM", JdeDataType.String, 6),
        new JdeField("SZCYCL", "SZCYCL", JdeDataType.String, 6),
        new JdeField("SZPRP6", "SZPRP6", JdeDataType.String, 12),
        new JdeField("SZPRP7", "SZPRP7", JdeDataType.String, 12),
        new JdeField("SZPRP8", "SZPRP8", JdeDataType.String, 12),
        new JdeField("SZPRP9", "SZPRP9", JdeDataType.String, 12),
        new JdeField("SZPRP0", "SZPRP0", JdeDataType.String, 12),
        new JdeField("SZSRP6", "SZSRP6", JdeDataType.String, 12),
        new JdeField("SZSRP7", "SZSRP7", JdeDataType.String, 12),
        new JdeField("SZSRP8", "SZSRP8", JdeDataType.String, 12),
        new JdeField("SZSRP9", "SZSRP9", JdeDataType.String, 12),
        new JdeField("SZSRP0", "SZSRP0", JdeDataType.String, 12),
        new JdeField("SZAC01", "SZAC01", JdeDataType.String, 6),
        new JdeField("SZAC02", "SZAC02", JdeDataType.String, 6),
        new JdeField("SZAC03", "SZAC03", JdeDataType.String, 6),
        new JdeField("SZAC04", "SZAC04", JdeDataType.String, 6),
        new JdeField("SZAC05", "SZAC05", JdeDataType.String, 6),
        new JdeField("SZAC06", "SZAC06", JdeDataType.String, 6),
        new JdeField("SZAC07", "SZAC07", JdeDataType.String, 6),
        new JdeField("SZAC08", "SZAC08", JdeDataType.String, 6),
        new JdeField("SZAC09", "SZAC09", JdeDataType.String, 6),
        new JdeField("SZAC10", "SZAC10", JdeDataType.String, 6),
        new JdeField("SZAC11", "SZAC11", JdeDataType.String, 6),
        new JdeField("SZAC12", "SZAC12", JdeDataType.String, 6),
        new JdeField("SZAC13", "SZAC13", JdeDataType.String, 6),
        new JdeField("SZAC14", "SZAC14", JdeDataType.String, 6),
        new JdeField("SZAC15", "SZAC15", JdeDataType.String, 6),
        new JdeField("SZAC16", "SZAC16", JdeDataType.String, 6),
        new JdeField("SZAC17", "SZAC17", JdeDataType.String, 6),
        new JdeField("SZAC18", "SZAC18", JdeDataType.String, 6),
        new JdeField("SZAC19", "SZAC19", JdeDataType.String, 6),
        new JdeField("SZAC20", "SZAC20", JdeDataType.String, 6),
        new JdeField("SZAC21", "SZAC21", JdeDataType.String, 6),
        new JdeField("SZAC22", "SZAC22", JdeDataType.String, 6),
        new JdeField("SZAC23", "SZAC23", JdeDataType.String, 6),
        new JdeField("SZAC24", "SZAC24", JdeDataType.String, 6),
        new JdeField("SZAC25", "SZAC25", JdeDataType.String, 6),
        new JdeField("SZAC26", "SZAC26", JdeDataType.String, 6),
        new JdeField("SZAC27", "SZAC27", JdeDataType.String, 6),
        new JdeField("SZAC28", "SZAC28", JdeDataType.String, 6),
        new JdeField("SZAC29", "SZAC29", JdeDataType.String, 6),
        new JdeField("SZAC30", "SZAC30", JdeDataType.String, 6),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4106Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
