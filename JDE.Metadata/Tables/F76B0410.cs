using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0410 - .
/// </summary>
public class F76B0410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCITM.
        /// </summary>
        public const string FCITM = "FCITM";

        /// <summary>
        /// FCAN8.
        /// </summary>
        public const string FCAN8 = "FCAN8";

        /// <summary>
        /// FCLITM.
        /// </summary>
        public const string FCLITM = "FCLITM";

        /// <summary>
        /// FCB76CI.
        /// </summary>
        public const string FCB76CI = "FCB76CI";

        /// <summary>
        /// FCB76FCI.
        /// </summary>
        public const string FCB76FCI = "FCB76FCI";

        /// <summary>
        /// FCBCLF.
        /// </summary>
        public const string FCBCLF = "FCBCLF";

        /// <summary>
        /// FCB76TIPI.
        /// </summary>
        public const string FCB76TIPI = "FCB76TIPI";

        /// <summary>
        /// FCB76NUM.
        /// </summary>
        public const string FCB76NUM = "FCB76NUM";

        /// <summary>
        /// FCB76AA.
        /// </summary>
        public const string FCB76AA = "FCB76AA";

        /// <summary>
        /// FCB76REF.
        /// </summary>
        public const string FCB76REF = "FCB76REF";

        /// <summary>
        /// FCB76COD.
        /// </summary>
        public const string FCB76COD = "FCB76COD";

        /// <summary>
        /// FCB76DATE.
        /// </summary>
        public const string FCB76DATE = "FCB76DATE";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCUPMJ.
        /// </summary>
        public const string FCUPMJ = "FCUPMJ";

        /// <summary>
        /// FCTDAY.
        /// </summary>
        public const string FCTDAY = "FCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCITM", "FCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FCAN8", "FCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FCLITM", "FCLITM", JdeDataType.String, 50),
        new JdeField("FCB76CI", "FCB76CI", JdeDataType.Numeric),
        new JdeField("FCB76FCI", "FCB76FCI", JdeDataType.String, 100),
        new JdeField("FCBCLF", "FCBCLF", JdeDataType.String, 20),
        new JdeField("FCB76TIPI", "FCB76TIPI", JdeDataType.String, 6),
        new JdeField("FCB76NUM", "FCB76NUM", JdeDataType.Numeric),
        new JdeField("FCB76AA", "FCB76AA", JdeDataType.Numeric),
        new JdeField("FCB76REF", "FCB76REF", JdeDataType.String, 30),
        new JdeField("FCB76COD", "FCB76COD", JdeDataType.String, 4),
        new JdeField("FCB76DATE", "FCB76DATE", JdeDataType.Numeric),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric),
        new JdeField("FCTDAY", "FCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0410_0", "Primary Key on FCITM, FCAN8", new[] { "FCITM", "FCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
