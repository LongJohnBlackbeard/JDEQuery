using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B18 - .
/// </summary>
public class F76B18 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCBCLF.
        /// </summary>
        public const string FCBCLF = "FCBCLF";

        /// <summary>
        /// FCITM.
        /// </summary>
        public const string FCITM = "FCITM";

        /// <summary>
        /// FCBINM.
        /// </summary>
        public const string FCBINM = "FCBINM";

        /// <summary>
        /// FCBFIP.
        /// </summary>
        public const string FCBFIP = "FCBFIP";

        /// <summary>
        /// FCBFII.
        /// </summary>
        public const string FCBFII = "FCBFII";

        /// <summary>
        /// FCTXR1.
        /// </summary>
        public const string FCTXR1 = "FCTXR1";

        /// <summary>
        /// FCTXR2.
        /// </summary>
        public const string FCTXR2 = "FCTXR2";

        /// <summary>
        /// FCF1T.
        /// </summary>
        public const string FCF1T = "FCF1T";

        /// <summary>
        /// FCF2A.
        /// </summary>
        public const string FCF2A = "FCF2A";

        /// <summary>
        /// FCTORG.
        /// </summary>
        public const string FCTORG = "FCTORG";

        /// <summary>
        /// FCTDAY.
        /// </summary>
        public const string FCTDAY = "FCTDAY";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76B18";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCBCLF", "FCBCLF", JdeDataType.String, 20, true, true),
        new JdeField("FCITM", "FCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FCBINM", "FCBINM", JdeDataType.String, 20),
        new JdeField("FCBFIP", "FCBFIP", JdeDataType.String, 2),
        new JdeField("FCBFII", "FCBFII", JdeDataType.String, 2),
        new JdeField("FCTXR1", "FCTXR1", JdeDataType.Numeric),
        new JdeField("FCTXR2", "FCTXR2", JdeDataType.Numeric),
        new JdeField("FCF1T", "FCF1T", JdeDataType.String, 60),
        new JdeField("FCF2A", "FCF2A", JdeDataType.Numeric),
        new JdeField("FCTORG", "FCTORG", JdeDataType.String, 20),
        new JdeField("FCTDAY", "FCTDAY", JdeDataType.Numeric),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B18_0", "Primary Key on FCBCLF, FCITM", new[] { "FCBCLF", "FCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
