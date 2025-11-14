using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D701 - .
/// </summary>
public class F80D701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTPRDJ.
        /// </summary>
        public const string UTPRDJ = "UTPRDJ";

        /// <summary>
        /// UTMCU.
        /// </summary>
        public const string UTMCU = "UTMCU";

        /// <summary>
        /// UTUARAP.
        /// </summary>
        public const string UTUARAP = "UTUARAP";

        /// <summary>
        /// UTUAPAG.
        /// </summary>
        public const string UTUAPAG = "UTUAPAG";

        /// <summary>
        /// UTUSER.
        /// </summary>
        public const string UTUSER = "UTUSER";

        /// <summary>
        /// UTPID.
        /// </summary>
        public const string UTPID = "UTPID";

        /// <summary>
        /// UTMKEY.
        /// </summary>
        public const string UTMKEY = "UTMKEY";

        /// <summary>
        /// UTUTIME.
        /// </summary>
        public const string UTUTIME = "UTUTIME";

        /// <summary>
        /// UTURCD.
        /// </summary>
        public const string UTURCD = "UTURCD";

        /// <summary>
        /// UTURDT.
        /// </summary>
        public const string UTURDT = "UTURDT";

        /// <summary>
        /// UTURAT.
        /// </summary>
        public const string UTURAT = "UTURAT";

        /// <summary>
        /// UTURAB.
        /// </summary>
        public const string UTURAB = "UTURAB";

        /// <summary>
        /// UTURRF.
        /// </summary>
        public const string UTURRF = "UTURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTPRDJ", "UTPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("UTMCU", "UTMCU", JdeDataType.String, 24, true, true),
        new JdeField("UTUARAP", "UTUARAP", JdeDataType.Numeric),
        new JdeField("UTUAPAG", "UTUAPAG", JdeDataType.Numeric),
        new JdeField("UTUSER", "UTUSER", JdeDataType.String, 20),
        new JdeField("UTPID", "UTPID", JdeDataType.String, 20),
        new JdeField("UTMKEY", "UTMKEY", JdeDataType.String, 30),
        new JdeField("UTUTIME", "UTUTIME", JdeDataType.Date),
        new JdeField("UTURCD", "UTURCD", JdeDataType.String, 4),
        new JdeField("UTURDT", "UTURDT", JdeDataType.Numeric),
        new JdeField("UTURAT", "UTURAT", JdeDataType.Numeric),
        new JdeField("UTURAB", "UTURAB", JdeDataType.Numeric),
        new JdeField("UTURRF", "UTURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D701_0", "Primary Key on UTPRDJ, UTMCU", new[] { "UTPRDJ", "UTMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
