using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08821 - .
/// </summary>
public class F08821 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YDIGDLT.
        /// </summary>
        public const string YDIGDLT = "YDIGDLT";

        /// <summary>
        /// YDEFT.
        /// </summary>
        public const string YDEFT = "YDEFT";

        /// <summary>
        /// YDR4HL.
        /// </summary>
        public const string YDR4HL = "YDR4HL";

        /// <summary>
        /// YDEFTE.
        /// </summary>
        public const string YDEFTE = "YDEFTE";

        /// <summary>
        /// YDRWFFR.
        /// </summary>
        public const string YDRWFFR = "YDRWFFR";

        /// <summary>
        /// YDRWFT.
        /// </summary>
        public const string YDRWFT = "YDRWFT";

        /// <summary>
        /// YDR1LL.
        /// </summary>
        public const string YDR1LL = "YDR1LL";

        /// <summary>
        /// YDR1HL.
        /// </summary>
        public const string YDR1HL = "YDR1HL";

        /// <summary>
        /// YDR2LL.
        /// </summary>
        public const string YDR2LL = "YDR2LL";

        /// <summary>
        /// YDR2HL.
        /// </summary>
        public const string YDR2HL = "YDR2HL";

        /// <summary>
        /// YDR3LL.
        /// </summary>
        public const string YDR3LL = "YDR3LL";

        /// <summary>
        /// YDR3HL.
        /// </summary>
        public const string YDR3HL = "YDR3HL";

        /// <summary>
        /// YDR4LL.
        /// </summary>
        public const string YDR4LL = "YDR4LL";

        /// <summary>
        /// YDR5LL.
        /// </summary>
        public const string YDR5LL = "YDR5LL";

        /// <summary>
        /// YDR5HL.
        /// </summary>
        public const string YDR5HL = "YDR5HL";

        /// <summary>
        /// YDR6LL.
        /// </summary>
        public const string YDR6LL = "YDR6LL";

        /// <summary>
        /// YDR6HL.
        /// </summary>
        public const string YDR6HL = "YDR6HL";

        /// <summary>
        /// YDUSER.
        /// </summary>
        public const string YDUSER = "YDUSER";

        /// <summary>
        /// YDPID.
        /// </summary>
        public const string YDPID = "YDPID";

        /// <summary>
        /// YDUPMJ.
        /// </summary>
        public const string YDUPMJ = "YDUPMJ";

        /// <summary>
        /// YDUPMT.
        /// </summary>
        public const string YDUPMT = "YDUPMT";

        /// <summary>
        /// YDJOBN.
        /// </summary>
        public const string YDJOBN = "YDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08821";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YDIGDLT", "YDIGDLT", JdeDataType.String, 20, true, true),
        new JdeField("YDEFT", "YDEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("YDR4HL", "YDR4HL", JdeDataType.Numeric),
        new JdeField("YDEFTE", "YDEFTE", JdeDataType.Numeric),
        new JdeField("YDRWFFR", "YDRWFFR", JdeDataType.Numeric, null, true, true),
        new JdeField("YDRWFT", "YDRWFT", JdeDataType.Numeric),
        new JdeField("YDR1LL", "YDR1LL", JdeDataType.Numeric),
        new JdeField("YDR1HL", "YDR1HL", JdeDataType.Numeric),
        new JdeField("YDR2LL", "YDR2LL", JdeDataType.Numeric),
        new JdeField("YDR2HL", "YDR2HL", JdeDataType.Numeric),
        new JdeField("YDR3LL", "YDR3LL", JdeDataType.Numeric),
        new JdeField("YDR3HL", "YDR3HL", JdeDataType.Numeric),
        new JdeField("YDR4LL", "YDR4LL", JdeDataType.Numeric),
        new JdeField("YDR5LL", "YDR5LL", JdeDataType.Numeric),
        new JdeField("YDR5HL", "YDR5HL", JdeDataType.Numeric),
        new JdeField("YDR6LL", "YDR6LL", JdeDataType.Numeric),
        new JdeField("YDR6HL", "YDR6HL", JdeDataType.Numeric),
        new JdeField("YDUSER", "YDUSER", JdeDataType.String, 20),
        new JdeField("YDPID", "YDPID", JdeDataType.String, 20),
        new JdeField("YDUPMJ", "YDUPMJ", JdeDataType.Numeric),
        new JdeField("YDUPMT", "YDUPMT", JdeDataType.Numeric),
        new JdeField("YDJOBN", "YDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08821_0", "Primary Key on YDIGDLT, YDEFT, YDRWFFR", new[] { "YDIGDLT", "YDEFT", "YDRWFFR" }, isUnique: true, isPrimaryKey: true)
    };
}
