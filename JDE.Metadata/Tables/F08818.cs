using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08818 - .
/// </summary>
public class F08818 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YMTRS.
        /// </summary>
        public const string YMTRS = "YMTRS";

        /// <summary>
        /// YMCO.
        /// </summary>
        public const string YMCO = "YMCO";

        /// <summary>
        /// YMHMCU.
        /// </summary>
        public const string YMHMCU = "YMHMCU";

        /// <summary>
        /// YMEFT.
        /// </summary>
        public const string YMEFT = "YMEFT";

        /// <summary>
        /// YMEFTE.
        /// </summary>
        public const string YMEFTE = "YMEFTE";

        /// <summary>
        /// YMBDAI.
        /// </summary>
        public const string YMBDAI = "YMBDAI";

        /// <summary>
        /// YMRRVLC.
        /// </summary>
        public const string YMRRVLC = "YMRRVLC";

        /// <summary>
        /// YMJTCHG.
        /// </summary>
        public const string YMJTCHG = "YMJTCHG";

        /// <summary>
        /// YMXET.
        /// </summary>
        public const string YMXET = "YMXET";

        /// <summary>
        /// YMIGDLT.
        /// </summary>
        public const string YMIGDLT = "YMIGDLT";

        /// <summary>
        /// YMDBPR.
        /// </summary>
        public const string YMDBPR = "YMDBPR";

        /// <summary>
        /// YMALPRF.
        /// </summary>
        public const string YMALPRF = "YMALPRF";

        /// <summary>
        /// YMUSER.
        /// </summary>
        public const string YMUSER = "YMUSER";

        /// <summary>
        /// YMPID.
        /// </summary>
        public const string YMPID = "YMPID";

        /// <summary>
        /// YMUPMJ.
        /// </summary>
        public const string YMUPMJ = "YMUPMJ";

        /// <summary>
        /// YMUPMT.
        /// </summary>
        public const string YMUPMT = "YMUPMT";

        /// <summary>
        /// YMJOBN.
        /// </summary>
        public const string YMJOBN = "YMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08818";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YMTRS", "YMTRS", JdeDataType.String, 6, true, true),
        new JdeField("YMCO", "YMCO", JdeDataType.String, 10, true, true),
        new JdeField("YMHMCU", "YMHMCU", JdeDataType.String, 24, true, true),
        new JdeField("YMEFT", "YMEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("YMEFTE", "YMEFTE", JdeDataType.Numeric),
        new JdeField("YMBDAI", "YMBDAI", JdeDataType.Numeric),
        new JdeField("YMRRVLC", "YMRRVLC", JdeDataType.String, 20),
        new JdeField("YMJTCHG", "YMJTCHG", JdeDataType.String, 2),
        new JdeField("YMXET", "YMXET", JdeDataType.String, 8),
        new JdeField("YMIGDLT", "YMIGDLT", JdeDataType.String, 20),
        new JdeField("YMDBPR", "YMDBPR", JdeDataType.String, 20),
        new JdeField("YMALPRF", "YMALPRF", JdeDataType.String, 2),
        new JdeField("YMUSER", "YMUSER", JdeDataType.String, 20),
        new JdeField("YMPID", "YMPID", JdeDataType.String, 20),
        new JdeField("YMUPMJ", "YMUPMJ", JdeDataType.Numeric),
        new JdeField("YMUPMT", "YMUPMT", JdeDataType.Numeric),
        new JdeField("YMJOBN", "YMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08818_0", "Primary Key on YMTRS, YMCO, YMHMCU, YMEFT", new[] { "YMTRS", "YMCO", "YMHMCU", "YMEFT" }, isUnique: true, isPrimaryKey: true)
    };
}
