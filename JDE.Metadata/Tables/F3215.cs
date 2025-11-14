using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3215 - .
/// </summary>
public class F3215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCFGID.
        /// </summary>
        public const string CCCFGID = "CCCFGID";

        /// <summary>
        /// CCCFGCID.
        /// </summary>
        public const string CCCFGCID = "CCCFGCID";

        /// <summary>
        /// CCCFGPID.
        /// </summary>
        public const string CCCFGPID = "CCCFGPID";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCDSC1.
        /// </summary>
        public const string CCDSC1 = "CCDSC1";

        /// <summary>
        /// CCQNTY.
        /// </summary>
        public const string CCQNTY = "CCQNTY";

        /// <summary>
        /// CCUOM.
        /// </summary>
        public const string CCUOM = "CCUOM";

        /// <summary>
        /// CCFOVQ.
        /// </summary>
        public const string CCFOVQ = "CCFOVQ";

        /// <summary>
        /// CCATMU.
        /// </summary>
        public const string CCATMU = "CCATMU";

        /// <summary>
        /// CCSO03.
        /// </summary>
        public const string CCSO03 = "CCSO03";

        /// <summary>
        /// CCLNTY.
        /// </summary>
        public const string CCLNTY = "CCLNTY";

        /// <summary>
        /// CCKIT.
        /// </summary>
        public const string CCKIT = "CCKIT";

        /// <summary>
        /// CCUITM.
        /// </summary>
        public const string CCUITM = "CCUITM";

        /// <summary>
        /// CCCFGSID.
        /// </summary>
        public const string CCCFGSID = "CCCFGSID";

        /// <summary>
        /// CCCOMM.
        /// </summary>
        public const string CCCOMM = "CCCOMM";

        /// <summary>
        /// CCLOCN.
        /// </summary>
        public const string CCLOCN = "CCLOCN";

        /// <summary>
        /// CCLOTN.
        /// </summary>
        public const string CCLOTN = "CCLOTN";

        /// <summary>
        /// CCSY.
        /// </summary>
        public const string CCSY = "CCSY";

        /// <summary>
        /// CCECST.
        /// </summary>
        public const string CCECST = "CCECST";

        /// <summary>
        /// CCFEC.
        /// </summary>
        public const string CCFEC = "CCFEC";

        /// <summary>
        /// CCAEXP.
        /// </summary>
        public const string CCAEXP = "CCAEXP";

        /// <summary>
        /// CCFEA.
        /// </summary>
        public const string CCFEA = "CCFEA";

        /// <summary>
        /// CCSOCF.
        /// </summary>
        public const string CCSOCF = "CCSOCF";

        /// <summary>
        /// CCWADL.
        /// </summary>
        public const string CCWADL = "CCWADL";

        /// <summary>
        /// CCCIDN.
        /// </summary>
        public const string CCCIDN = "CCCIDN";

        /// <summary>
        /// CCITC.
        /// </summary>
        public const string CCITC = "CCITC";

        /// <summary>
        /// CCOPSQ.
        /// </summary>
        public const string CCOPSQ = "CCOPSQ";

        /// <summary>
        /// CCATOT.
        /// </summary>
        public const string CCATOT = "CCATOT";

        /// <summary>
        /// CCATO#.
        /// </summary>
        public const string CCATO_ = "CCATO#";

        /// <summary>
        /// CCATOS.
        /// </summary>
        public const string CCATOS = "CCATOS";

        /// <summary>
        /// CCPDDJ.
        /// </summary>
        public const string CCPDDJ = "CCPDDJ";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURAT.
        /// </summary>
        public const string CCURAT = "CCURAT";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";

        /// <summary>
        /// CCRULUKID.
        /// </summary>
        public const string CCRULUKID = "CCRULUKID";

        /// <summary>
        /// CCRUKIDLIN.
        /// </summary>
        public const string CCRUKIDLIN = "CCRUKIDLIN";
    }

    /// <inheritdoc />
    public override string TableName => "F3215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCFGID", "CCCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCFGCID", "CCCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCFGPID", "CCCFGPID", JdeDataType.Numeric),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24),
        new JdeField("CCDSC1", "CCDSC1", JdeDataType.String, 60),
        new JdeField("CCQNTY", "CCQNTY", JdeDataType.Numeric),
        new JdeField("CCUOM", "CCUOM", JdeDataType.String, 4),
        new JdeField("CCFOVQ", "CCFOVQ", JdeDataType.String, 2),
        new JdeField("CCATMU", "CCATMU", JdeDataType.Numeric),
        new JdeField("CCSO03", "CCSO03", JdeDataType.String, 2),
        new JdeField("CCLNTY", "CCLNTY", JdeDataType.String, 4),
        new JdeField("CCKIT", "CCKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("CCUITM", "CCUITM", JdeDataType.String, 52),
        new JdeField("CCCFGSID", "CCCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("CCCOMM", "CCCOMM", JdeDataType.String, 2),
        new JdeField("CCLOCN", "CCLOCN", JdeDataType.String, 40),
        new JdeField("CCLOTN", "CCLOTN", JdeDataType.String, 60),
        new JdeField("CCSY", "CCSY", JdeDataType.String, 8),
        new JdeField("CCECST", "CCECST", JdeDataType.Numeric),
        new JdeField("CCFEC", "CCFEC", JdeDataType.Numeric),
        new JdeField("CCAEXP", "CCAEXP", JdeDataType.Numeric),
        new JdeField("CCFEA", "CCFEA", JdeDataType.Numeric),
        new JdeField("CCSOCF", "CCSOCF", JdeDataType.String, 2),
        new JdeField("CCWADL", "CCWADL", JdeDataType.String, 2),
        new JdeField("CCCIDN", "CCCIDN", JdeDataType.String, 2),
        new JdeField("CCITC", "CCITC", JdeDataType.String, 2),
        new JdeField("CCOPSQ", "CCOPSQ", JdeDataType.Numeric),
        new JdeField("CCATOT", "CCATOT", JdeDataType.String, 2),
        new JdeField("CCATO#", "CCATO#", JdeDataType.Numeric),
        new JdeField("CCATOS", "CCATOS", JdeDataType.Numeric),
        new JdeField("CCPDDJ", "CCPDDJ", JdeDataType.Numeric),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURAT", "CCURAT", JdeDataType.Numeric),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric),
        new JdeField("CCRULUKID", "CCRULUKID", JdeDataType.Numeric),
        new JdeField("CCRUKIDLIN", "CCRUKIDLIN", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3215_0", "Primary Key on CCCFGID, CCCFGCID, CCKIT, CCCFGSID", new[] { "CCCFGID", "CCCFGCID", "CCKIT", "CCCFGSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3215_10", "Index on CCCFGID, CCCFGPID, CCSOCF", new[] { "CCCFGID", "CCCFGPID", "CCSOCF" }),
        new JdeIndex("F3215_2", "Index on CCCFGID, CCCFGPID, CCCFGCID", new[] { "CCCFGID", "CCCFGPID", "CCCFGCID" }),
        new JdeIndex("F3215_3", "Index on CCCFGID, CCKIT, CCCFGSID, CCCFGCID", new[] { "CCCFGID", "CCKIT", "CCCFGSID", "CCCFGCID" }),
        new JdeIndex("F3215_4", "Index on CCCFGID, CCCOMM, CCMCU, CCLOCN, CCLOTN", new[] { "CCCFGID", "CCCOMM", "CCMCU", "CCLOCN", "CCLOTN" }),
        new JdeIndex("F3215_5", "Index on CCKIT, CCCFGSID, CCLOCN, CCLOTN", new[] { "CCKIT", "CCCFGSID", "CCLOCN", "CCLOTN" }),
        new JdeIndex("F3215_6", "Index on CCKIT, CCMCU, CCCFGSID, CCLOCN, CCLOTN", new[] { "CCKIT", "CCMCU", "CCCFGSID", "CCLOCN", "CCLOTN" }),
        new JdeIndex("F3215_7", "Index on CCITM, CCSY, CCCFGID", new[] { "CCITM", "CCSY", "CCCFGID" }),
        new JdeIndex("F3215_8", "Index on CCCFGID, CCCFGSID", new[] { "CCCFGID", "CCCFGSID" }),
        new JdeIndex("F3215_9", "Index on CCCFGID, CCITM, CCMCU, CCATOT, CCATO#, CCATOS, CCCFGCID", new[] { "CCCFGID", "CCITM", "CCMCU", "CCATOT", "CCATO#", "CCATOS", "CCCFGCID" })
    };
}
