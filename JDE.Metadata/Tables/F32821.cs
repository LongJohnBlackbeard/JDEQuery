using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32821 - .
/// </summary>
public class F32821 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLTBLC.
        /// </summary>
        public const string RLTBLC = "RLTBLC";

        /// <summary>
        /// RLMCU.
        /// </summary>
        public const string RLMCU = "RLMCU";

        /// <summary>
        /// RLRTBT.
        /// </summary>
        public const string RLRTBT = "RLRTBT";

        /// <summary>
        /// RLKIT.
        /// </summary>
        public const string RLKIT = "RLKIT";

        /// <summary>
        /// RLBSEQ.
        /// </summary>
        public const string RLBSEQ = "RLBSEQ";

        /// <summary>
        /// RLEFFF.
        /// </summary>
        public const string RLEFFF = "RLEFFF";

        /// <summary>
        /// RLEFFT.
        /// </summary>
        public const string RLEFFT = "RLEFFT";

        /// <summary>
        /// RLPEL.
        /// </summary>
        public const string RLPEL = "RLPEL";

        /// <summary>
        /// RLURCD.
        /// </summary>
        public const string RLURCD = "RLURCD";

        /// <summary>
        /// RLURDT.
        /// </summary>
        public const string RLURDT = "RLURDT";

        /// <summary>
        /// RLURAT.
        /// </summary>
        public const string RLURAT = "RLURAT";

        /// <summary>
        /// RLURAB.
        /// </summary>
        public const string RLURAB = "RLURAB";

        /// <summary>
        /// RLURRF.
        /// </summary>
        public const string RLURRF = "RLURRF";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLTDAY.
        /// </summary>
        public const string RLTDAY = "RLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32821";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLTBLC", "RLTBLC", JdeDataType.String, 20, true, true),
        new JdeField("RLMCU", "RLMCU", JdeDataType.String, 24, true, true),
        new JdeField("RLRTBT", "RLRTBT", JdeDataType.String, 2, true, true),
        new JdeField("RLKIT", "RLKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("RLBSEQ", "RLBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RLEFFF", "RLEFFF", JdeDataType.Numeric),
        new JdeField("RLEFFT", "RLEFFT", JdeDataType.Numeric),
        new JdeField("RLPEL", "RLPEL", JdeDataType.Numeric),
        new JdeField("RLURCD", "RLURCD", JdeDataType.String, 4),
        new JdeField("RLURDT", "RLURDT", JdeDataType.Numeric),
        new JdeField("RLURAT", "RLURAT", JdeDataType.Numeric),
        new JdeField("RLURAB", "RLURAB", JdeDataType.Numeric),
        new JdeField("RLURRF", "RLURRF", JdeDataType.String, 30),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLTDAY", "RLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32821_0", "Primary Key on RLTBLC, RLMCU, RLRTBT, RLKIT, RLBSEQ", new[] { "RLTBLC", "RLMCU", "RLRTBT", "RLKIT", "RLBSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
