using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40315 - .
/// </summary>
public class F40315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PICS15.
        /// </summary>
        public const string PICS15 = "PICS15";

        /// <summary>
        /// PIITM.
        /// </summary>
        public const string PIITM = "PIITM";

        /// <summary>
        /// PIIT15.
        /// </summary>
        public const string PIIT15 = "PIIT15";

        /// <summary>
        /// PIEFTJ.
        /// </summary>
        public const string PIEFTJ = "PIEFTJ";

        /// <summary>
        /// PIEXDJ.
        /// </summary>
        public const string PIEXDJ = "PIEXDJ";

        /// <summary>
        /// PIMNQ.
        /// </summary>
        public const string PIMNQ = "PIMNQ";

        /// <summary>
        /// PIMXQ.
        /// </summary>
        public const string PIMXQ = "PIMXQ";

        /// <summary>
        /// PIUOM.
        /// </summary>
        public const string PIUOM = "PIUOM";

        /// <summary>
        /// PITXID.
        /// </summary>
        public const string PITXID = "PITXID";

        /// <summary>
        /// PISTPR.
        /// </summary>
        public const string PISTPR = "PISTPR";

        /// <summary>
        /// PIOSEQ.
        /// </summary>
        public const string PIOSEQ = "PIOSEQ";

        /// <summary>
        /// PIMCU.
        /// </summary>
        public const string PIMCU = "PIMCU";

        /// <summary>
        /// PIINCY.
        /// </summary>
        public const string PIINCY = "PIINCY";

        /// <summary>
        /// PIURCD.
        /// </summary>
        public const string PIURCD = "PIURCD";

        /// <summary>
        /// PIURDT.
        /// </summary>
        public const string PIURDT = "PIURDT";

        /// <summary>
        /// PIURAT.
        /// </summary>
        public const string PIURAT = "PIURAT";

        /// <summary>
        /// PIURAB.
        /// </summary>
        public const string PIURAB = "PIURAB";

        /// <summary>
        /// PIURRF.
        /// </summary>
        public const string PIURRF = "PIURRF";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PITDAY.
        /// </summary>
        public const string PITDAY = "PITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PICS15", "PICS15", JdeDataType.String, 16, true, true),
        new JdeField("PIITM", "PIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PIIT15", "PIIT15", JdeDataType.String, 16, true, true),
        new JdeField("PIEFTJ", "PIEFTJ", JdeDataType.Numeric),
        new JdeField("PIEXDJ", "PIEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIMNQ", "PIMNQ", JdeDataType.Numeric),
        new JdeField("PIMXQ", "PIMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIUOM", "PIUOM", JdeDataType.String, 4, true, true),
        new JdeField("PITXID", "PITXID", JdeDataType.Numeric),
        new JdeField("PISTPR", "PISTPR", JdeDataType.String, 2),
        new JdeField("PIOSEQ", "PIOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIMCU", "PIMCU", JdeDataType.String, 24),
        new JdeField("PIINCY", "PIINCY", JdeDataType.String, 6),
        new JdeField("PIURCD", "PIURCD", JdeDataType.String, 4),
        new JdeField("PIURDT", "PIURDT", JdeDataType.Numeric),
        new JdeField("PIURAT", "PIURAT", JdeDataType.Numeric),
        new JdeField("PIURAB", "PIURAB", JdeDataType.Numeric),
        new JdeField("PIURRF", "PIURRF", JdeDataType.String, 30),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PITDAY", "PITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40315_0", "Primary Key on PIAN8, PICS15, PIITM, PIIT15, PIEXDJ, PIUOM, PIMXQ, PIOSEQ", new[] { "PIAN8", "PICS15", "PIITM", "PIIT15", "PIEXDJ", "PIUOM", "PIMXQ", "PIOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
