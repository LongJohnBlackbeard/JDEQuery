using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3109 - .
/// </summary>
public class F3109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPITM.
        /// </summary>
        public const string IPITM = "IPITM";

        /// <summary>
        /// IPLITM.
        /// </summary>
        public const string IPLITM = "IPLITM";

        /// <summary>
        /// IPAITM.
        /// </summary>
        public const string IPAITM = "IPAITM";

        /// <summary>
        /// IPMMCU.
        /// </summary>
        public const string IPMMCU = "IPMMCU";

        /// <summary>
        /// IPLINE.
        /// </summary>
        public const string IPLINE = "IPLINE";

        /// <summary>
        /// IPUOM.
        /// </summary>
        public const string IPUOM = "IPUOM";

        /// <summary>
        /// IPDFVL.
        /// </summary>
        public const string IPDFVL = "IPDFVL";

        /// <summary>
        /// IPSCPR.
        /// </summary>
        public const string IPSCPR = "IPSCPR";

        /// <summary>
        /// IPSCSP.
        /// </summary>
        public const string IPSCSP = "IPSCSP";

        /// <summary>
        /// IPEFFF.
        /// </summary>
        public const string IPEFFF = "IPEFFF";

        /// <summary>
        /// IPEFFT.
        /// </summary>
        public const string IPEFFT = "IPEFFT";

        /// <summary>
        /// IPMWDH.
        /// </summary>
        public const string IPMWDH = "IPMWDH";

        /// <summary>
        /// IPSHFT.
        /// </summary>
        public const string IPSHFT = "IPSHFT";

        /// <summary>
        /// IPRUC.
        /// </summary>
        public const string IPRUC = "IPRUC";

        /// <summary>
        /// IPCAPU.
        /// </summary>
        public const string IPCAPU = "IPCAPU";

        /// <summary>
        /// IPURCD.
        /// </summary>
        public const string IPURCD = "IPURCD";

        /// <summary>
        /// IPURDT.
        /// </summary>
        public const string IPURDT = "IPURDT";

        /// <summary>
        /// IPURAT.
        /// </summary>
        public const string IPURAT = "IPURAT";

        /// <summary>
        /// IPURRF.
        /// </summary>
        public const string IPURRF = "IPURRF";

        /// <summary>
        /// IPURAB.
        /// </summary>
        public const string IPURAB = "IPURAB";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPTDAY.
        /// </summary>
        public const string IPTDAY = "IPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPITM", "IPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IPLITM", "IPLITM", JdeDataType.String, 50),
        new JdeField("IPAITM", "IPAITM", JdeDataType.String, 50),
        new JdeField("IPMMCU", "IPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IPLINE", "IPLINE", JdeDataType.String, 24, true, true),
        new JdeField("IPUOM", "IPUOM", JdeDataType.String, 4),
        new JdeField("IPDFVL", "IPDFVL", JdeDataType.String, 2),
        new JdeField("IPSCPR", "IPSCPR", JdeDataType.String, 6),
        new JdeField("IPSCSP", "IPSCSP", JdeDataType.Numeric),
        new JdeField("IPEFFF", "IPEFFF", JdeDataType.Numeric),
        new JdeField("IPEFFT", "IPEFFT", JdeDataType.Numeric),
        new JdeField("IPMWDH", "IPMWDH", JdeDataType.String, 2),
        new JdeField("IPSHFT", "IPSHFT", JdeDataType.String, 2),
        new JdeField("IPRUC", "IPRUC", JdeDataType.Numeric),
        new JdeField("IPCAPU", "IPCAPU", JdeDataType.String, 4),
        new JdeField("IPURCD", "IPURCD", JdeDataType.String, 4),
        new JdeField("IPURDT", "IPURDT", JdeDataType.Numeric),
        new JdeField("IPURAT", "IPURAT", JdeDataType.Numeric),
        new JdeField("IPURRF", "IPURRF", JdeDataType.String, 30),
        new JdeField("IPURAB", "IPURAB", JdeDataType.Numeric),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPTDAY", "IPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3109_0", "Primary Key on IPITM, IPMMCU, IPLINE", new[] { "IPITM", "IPMMCU", "IPLINE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3109_11", "Index on IPMMCU, IPLINE, IPITM, IPDFVL", new[] { "IPMMCU", "IPLINE", "IPITM", "IPDFVL" }),
        new JdeIndex("F3109_7", "Index on IPITM, IPMMCU, IPDFVL", new[] { "IPITM", "IPMMCU", "IPDFVL" }),
        new JdeIndex("F3109_9", "Index on IPMMCU, IPITM, IPLINE", new[] { "IPMMCU", "IPITM", "IPLINE" })
    };
}
