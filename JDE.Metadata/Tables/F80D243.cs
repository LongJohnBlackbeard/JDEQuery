using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D243 - .
/// </summary>
public class F80D243 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCPRDJ.
        /// </summary>
        public const string BCPRDJ = "BCPRDJ";

        /// <summary>
        /// BCEMCU.
        /// </summary>
        public const string BCEMCU = "BCEMCU";

        /// <summary>
        /// BCITM.
        /// </summary>
        public const string BCITM = "BCITM";

        /// <summary>
        /// BCBCKV.
        /// </summary>
        public const string BCBCKV = "BCBCKV";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCMKEY.
        /// </summary>
        public const string BCMKEY = "BCMKEY";

        /// <summary>
        /// BCUTIME.
        /// </summary>
        public const string BCUTIME = "BCUTIME";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D243";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCPRDJ", "BCPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BCEMCU", "BCEMCU", JdeDataType.String, 24, true, true),
        new JdeField("BCITM", "BCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BCBCKV", "BCBCKV", JdeDataType.Numeric),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCMKEY", "BCMKEY", JdeDataType.String, 30),
        new JdeField("BCUTIME", "BCUTIME", JdeDataType.Date),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D243_0", "Primary Key on BCPRDJ, BCEMCU, BCITM", new[] { "BCPRDJ", "BCEMCU", "BCITM" }, isUnique: true, isPrimaryKey: true)
    };
}
