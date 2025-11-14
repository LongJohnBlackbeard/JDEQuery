using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B031 - .
/// </summary>
public class F31B031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPBPCO.
        /// </summary>
        public const string BPBPCO = "BPBPCO";

        /// <summary>
        /// BPBATP.
        /// </summary>
        public const string BPBATP = "BPBATP";

        /// <summary>
        /// BPBATV.
        /// </summary>
        public const string BPBATV = "BPBATV";

        /// <summary>
        /// BPMCU.
        /// </summary>
        public const string BPMCU = "BPMCU";

        /// <summary>
        /// BPCTRO.
        /// </summary>
        public const string BPCTRO = "BPCTRO";

        /// <summary>
        /// BPOLOC.
        /// </summary>
        public const string BPOLOC = "BPOLOC";

        /// <summary>
        /// BPSUPL.
        /// </summary>
        public const string BPSUPL = "BPSUPL";

        /// <summary>
        /// BPCPNUM.
        /// </summary>
        public const string BPCPNUM = "BPCPNUM";

        /// <summary>
        /// BPFORES.
        /// </summary>
        public const string BPFORES = "BPFORES";

        /// <summary>
        /// BPTLEV.
        /// </summary>
        public const string BPTLEV = "BPTLEV";

        /// <summary>
        /// BPTSTH.
        /// </summary>
        public const string BPTSTH = "BPTSTH";

        /// <summary>
        /// BPTOCAP.
        /// </summary>
        public const string BPTOCAP = "BPTOCAP";

        /// <summary>
        /// BPBCUOM.
        /// </summary>
        public const string BPBCUOM = "BPBCUOM";

        /// <summary>
        /// BPFCAP.
        /// </summary>
        public const string BPFCAP = "BPFCAP";

        /// <summary>
        /// BPNUMHP.
        /// </summary>
        public const string BPNUMHP = "BPNUMHP";

        /// <summary>
        /// BPGRAIN.
        /// </summary>
        public const string BPGRAIN = "BPGRAIN";

        /// <summary>
        /// BPSCTM.
        /// </summary>
        public const string BPSCTM = "BPSCTM";

        /// <summary>
        /// BPSDRM.
        /// </summary>
        public const string BPSDRM = "BPSDRM";

        /// <summary>
        /// BPSBDM.
        /// </summary>
        public const string BPSBDM = "BPSBDM";

        /// <summary>
        /// BPSDRL.
        /// </summary>
        public const string BPSDRL = "BPSDRL";

        /// <summary>
        /// BPBSMK.
        /// </summary>
        public const string BPBSMK = "BPBSMK";

        /// <summary>
        /// BPBNMS.
        /// </summary>
        public const string BPBNMS = "BPBNMS";

        /// <summary>
        /// BPINSU.
        /// </summary>
        public const string BPINSU = "BPINSU";

        /// <summary>
        /// BPIUOM.
        /// </summary>
        public const string BPIUOM = "BPIUOM";

        /// <summary>
        /// BPINLG.
        /// </summary>
        public const string BPINLG = "BPINLG";

        /// <summary>
        /// BPINWD.
        /// </summary>
        public const string BPINWD = "BPINWD";

        /// <summary>
        /// BPINHG.
        /// </summary>
        public const string BPINHG = "BPINHG";

        /// <summary>
        /// BPINGR.
        /// </summary>
        public const string BPINGR = "BPINGR";

        /// <summary>
        /// BPINQT.
        /// </summary>
        public const string BPINQT = "BPINQT";

        /// <summary>
        /// BPINTS.
        /// </summary>
        public const string BPINTS = "BPINTS";

        /// <summary>
        /// BPINFO.
        /// </summary>
        public const string BPINFO = "BPINFO";

        /// <summary>
        /// BPINMS.
        /// </summary>
        public const string BPINMS = "BPINMS";

        /// <summary>
        /// BPSYAR.
        /// </summary>
        public const string BPSYAR = "BPSYAR";

        /// <summary>
        /// BPINOO.
        /// </summary>
        public const string BPINOO = "BPINOO";

        /// <summary>
        /// BPISAR.
        /// </summary>
        public const string BPISAR = "BPISAR";

        /// <summary>
        /// BPIUMSA.
        /// </summary>
        public const string BPIUMSA = "BPIUMSA";

        /// <summary>
        /// BPISVR.
        /// </summary>
        public const string BPISVR = "BPISVR";

        /// <summary>
        /// BPINSF.
        /// </summary>
        public const string BPINSF = "BPINSF";

        /// <summary>
        /// BPURAT.
        /// </summary>
        public const string BPURAT = "BPURAT";

        /// <summary>
        /// BPURCD.
        /// </summary>
        public const string BPURCD = "BPURCD";

        /// <summary>
        /// BPURDT.
        /// </summary>
        public const string BPURDT = "BPURDT";

        /// <summary>
        /// BPURAB.
        /// </summary>
        public const string BPURAB = "BPURAB";

        /// <summary>
        /// BPURRF.
        /// </summary>
        public const string BPURRF = "BPURRF";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";

        /// <summary>
        /// BPUPMT.
        /// </summary>
        public const string BPUPMT = "BPUPMT";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";

        /// <summary>
        /// BPMKEY.
        /// </summary>
        public const string BPMKEY = "BPMKEY";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPSCDPR.
        /// </summary>
        public const string BPSCDPR = "BPSCDPR";

        /// <summary>
        /// BPITM.
        /// </summary>
        public const string BPITM = "BPITM";

        /// <summary>
        /// BPSTAVT.
        /// </summary>
        public const string BPSTAVT = "BPSTAVT";

        /// <summary>
        /// BPBPDESC.
        /// </summary>
        public const string BPBPDESC = "BPBPDESC";

        /// <summary>
        /// BPBRLCLA.
        /// </summary>
        public const string BPBRLCLA = "BPBRLCLA";

        /// <summary>
        /// BPWCG.
        /// </summary>
        public const string BPWCG = "BPWCG";

        /// <summary>
        /// BPTDAY.
        /// </summary>
        public const string BPTDAY = "BPTDAY";

        /// <summary>
        /// BPCOOP.
        /// </summary>
        public const string BPCOOP = "BPCOOP";

        /// <summary>
        /// BPWCTRO.
        /// </summary>
        public const string BPWCTRO = "BPWCTRO";
    }

    /// <inheritdoc />
    public override string TableName => "F31B031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPBPCO", "BPBPCO", JdeDataType.String, 24, true, true),
        new JdeField("BPBATP", "BPBATP", JdeDataType.String, 8),
        new JdeField("BPBATV", "BPBATV", JdeDataType.String, 4),
        new JdeField("BPMCU", "BPMCU", JdeDataType.String, 24, true, true),
        new JdeField("BPCTRO", "BPCTRO", JdeDataType.String, 6),
        new JdeField("BPOLOC", "BPOLOC", JdeDataType.String, 12),
        new JdeField("BPSUPL", "BPSUPL", JdeDataType.Numeric),
        new JdeField("BPCPNUM", "BPCPNUM", JdeDataType.Numeric),
        new JdeField("BPFORES", "BPFORES", JdeDataType.String, 16),
        new JdeField("BPTLEV", "BPTLEV", JdeDataType.String, 6),
        new JdeField("BPTSTH", "BPTSTH", JdeDataType.String, 2),
        new JdeField("BPTOCAP", "BPTOCAP", JdeDataType.Numeric),
        new JdeField("BPBCUOM", "BPBCUOM", JdeDataType.String, 4),
        new JdeField("BPFCAP", "BPFCAP", JdeDataType.Numeric),
        new JdeField("BPNUMHP", "BPNUMHP", JdeDataType.Numeric),
        new JdeField("BPGRAIN", "BPGRAIN", JdeDataType.String, 6),
        new JdeField("BPSCTM", "BPSCTM", JdeDataType.String, 20),
        new JdeField("BPSDRM", "BPSDRM", JdeDataType.String, 20),
        new JdeField("BPSBDM", "BPSBDM", JdeDataType.String, 20),
        new JdeField("BPSDRL", "BPSDRL", JdeDataType.String, 40),
        new JdeField("BPBSMK", "BPBSMK", JdeDataType.String, 16),
        new JdeField("BPBNMS", "BPBNMS", JdeDataType.Numeric),
        new JdeField("BPINSU", "BPINSU", JdeDataType.Numeric),
        new JdeField("BPIUOM", "BPIUOM", JdeDataType.String, 4),
        new JdeField("BPINLG", "BPINLG", JdeDataType.Numeric),
        new JdeField("BPINWD", "BPINWD", JdeDataType.Numeric),
        new JdeField("BPINHG", "BPINHG", JdeDataType.Numeric),
        new JdeField("BPINGR", "BPINGR", JdeDataType.String, 6),
        new JdeField("BPINQT", "BPINQT", JdeDataType.Numeric),
        new JdeField("BPINTS", "BPINTS", JdeDataType.String, 4),
        new JdeField("BPINFO", "BPINFO", JdeDataType.String, 20),
        new JdeField("BPINMS", "BPINMS", JdeDataType.Numeric),
        new JdeField("BPSYAR", "BPSYAR", JdeDataType.String, 6),
        new JdeField("BPINOO", "BPINOO", JdeDataType.String, 40),
        new JdeField("BPISAR", "BPISAR", JdeDataType.Numeric),
        new JdeField("BPIUMSA", "BPIUMSA", JdeDataType.String, 4),
        new JdeField("BPISVR", "BPISVR", JdeDataType.Numeric),
        new JdeField("BPINSF", "BPINSF", JdeDataType.String, 2),
        new JdeField("BPURAT", "BPURAT", JdeDataType.Numeric),
        new JdeField("BPURCD", "BPURCD", JdeDataType.String, 4),
        new JdeField("BPURDT", "BPURDT", JdeDataType.Numeric),
        new JdeField("BPURAB", "BPURAB", JdeDataType.Numeric),
        new JdeField("BPURRF", "BPURRF", JdeDataType.String, 30),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric),
        new JdeField("BPUPMT", "BPUPMT", JdeDataType.Numeric),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20),
        new JdeField("BPMKEY", "BPMKEY", JdeDataType.String, 30),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPSCDPR", "BPSCDPR", JdeDataType.String, 2),
        new JdeField("BPITM", "BPITM", JdeDataType.Numeric),
        new JdeField("BPSTAVT", "BPSTAVT", JdeDataType.Numeric),
        new JdeField("BPBPDESC", "BPBPDESC", JdeDataType.String, 80),
        new JdeField("BPBRLCLA", "BPBRLCLA", JdeDataType.String, 4),
        new JdeField("BPWCG", "BPWCG", JdeDataType.String, 24),
        new JdeField("BPTDAY", "BPTDAY", JdeDataType.Numeric),
        new JdeField("BPCOOP", "BPCOOP", JdeDataType.String, 6),
        new JdeField("BPWCTRO", "BPWCTRO", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B031_0", "Primary Key on BPBPCO, BPMCU", new[] { "BPBPCO", "BPMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
