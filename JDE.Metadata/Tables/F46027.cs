using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46027 - .
/// </summary>
public class F46027 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AVSRUL.
        /// </summary>
        public const string AVSRUL = "AVSRUL";

        /// <summary>
        /// AVSEQ.
        /// </summary>
        public const string AVSEQ = "AVSEQ";

        /// <summary>
        /// AVMCU.
        /// </summary>
        public const string AVMCU = "AVMCU";

        /// <summary>
        /// AVLOCN.
        /// </summary>
        public const string AVLOCN = "AVLOCN";

        /// <summary>
        /// AVWSQP.
        /// </summary>
        public const string AVWSQP = "AVWSQP";

        /// <summary>
        /// AVUCUB.
        /// </summary>
        public const string AVUCUB = "AVUCUB";

        /// <summary>
        /// AVVCUD.
        /// </summary>
        public const string AVVCUD = "AVVCUD";

        /// <summary>
        /// AVLOCS.
        /// </summary>
        public const string AVLOCS = "AVLOCS";

        /// <summary>
        /// AVURAT.
        /// </summary>
        public const string AVURAT = "AVURAT";

        /// <summary>
        /// AVURAB.
        /// </summary>
        public const string AVURAB = "AVURAB";

        /// <summary>
        /// AVURRF.
        /// </summary>
        public const string AVURRF = "AVURRF";

        /// <summary>
        /// AVIUSE.
        /// </summary>
        public const string AVIUSE = "AVIUSE";

        /// <summary>
        /// AVUSER.
        /// </summary>
        public const string AVUSER = "AVUSER";

        /// <summary>
        /// AVPID.
        /// </summary>
        public const string AVPID = "AVPID";

        /// <summary>
        /// AVJOBN.
        /// </summary>
        public const string AVJOBN = "AVJOBN";

        /// <summary>
        /// AVUPMJ.
        /// </summary>
        public const string AVUPMJ = "AVUPMJ";

        /// <summary>
        /// AVTDAY.
        /// </summary>
        public const string AVTDAY = "AVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46027";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AVSRUL", "AVSRUL", JdeDataType.String, 12, true, true),
        new JdeField("AVSEQ", "AVSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("AVMCU", "AVMCU", JdeDataType.String, 24, true, true),
        new JdeField("AVLOCN", "AVLOCN", JdeDataType.String, 40, true, true),
        new JdeField("AVWSQP", "AVWSQP", JdeDataType.Numeric),
        new JdeField("AVUCUB", "AVUCUB", JdeDataType.Numeric),
        new JdeField("AVVCUD", "AVVCUD", JdeDataType.Numeric),
        new JdeField("AVLOCS", "AVLOCS", JdeDataType.String, 2),
        new JdeField("AVURAT", "AVURAT", JdeDataType.Numeric),
        new JdeField("AVURAB", "AVURAB", JdeDataType.Numeric),
        new JdeField("AVURRF", "AVURRF", JdeDataType.String, 30),
        new JdeField("AVIUSE", "AVIUSE", JdeDataType.String, 2),
        new JdeField("AVUSER", "AVUSER", JdeDataType.String, 20),
        new JdeField("AVPID", "AVPID", JdeDataType.String, 20),
        new JdeField("AVJOBN", "AVJOBN", JdeDataType.String, 20),
        new JdeField("AVUPMJ", "AVUPMJ", JdeDataType.Numeric),
        new JdeField("AVTDAY", "AVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46027_0", "Primary Key on AVMCU, AVLOCN, AVSRUL, AVSEQ", new[] { "AVMCU", "AVLOCN", "AVSRUL", "AVSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46027_2", "Index on AVMCU, AVSRUL, AVSEQ, AVWSQP, AVLOCN", new[] { "AVMCU", "AVSRUL", "AVSEQ", "AVWSQP", "AVLOCN" }),
        new JdeIndex("F46027_3", "Index on AVMCU, AVSRUL, AVSEQ, AVUCUB, AVWSQP, AVLOCN", new[] { "AVMCU", "AVSRUL", "AVSEQ", "AVUCUB", "AVWSQP", "AVLOCN" }),
        new JdeIndex("F46027_4", "Index on AVMCU, AVSRUL, AVSEQ, SYS_NC00018$, AVWSQP, AVLOCN", new[] { "AVMCU", "AVSRUL", "AVSEQ", "SYS_NC00018$", "AVWSQP", "AVLOCN" }),
        new JdeIndex("F46027_5", "Index on AVMCU, AVSRUL, AVUCUB, AVLOCS, AVSEQ", new[] { "AVMCU", "AVSRUL", "AVUCUB", "AVLOCS", "AVSEQ" })
    };
}
