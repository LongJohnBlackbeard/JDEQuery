using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150123 - .
/// </summary>
public class F150123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NZSFDN.
        /// </summary>
        public const string NZSFDN = "NZSFDN";

        /// <summary>
        /// NZAM01.
        /// </summary>
        public const string NZAM01 = "NZAM01";

        /// <summary>
        /// NZURAB.
        /// </summary>
        public const string NZURAB = "NZURAB";

        /// <summary>
        /// NZURAT.
        /// </summary>
        public const string NZURAT = "NZURAT";

        /// <summary>
        /// NZURCD.
        /// </summary>
        public const string NZURCD = "NZURCD";

        /// <summary>
        /// NZURDT.
        /// </summary>
        public const string NZURDT = "NZURDT";

        /// <summary>
        /// NZURRF.
        /// </summary>
        public const string NZURRF = "NZURRF";

        /// <summary>
        /// NZUPMJ.
        /// </summary>
        public const string NZUPMJ = "NZUPMJ";

        /// <summary>
        /// NZUPMT.
        /// </summary>
        public const string NZUPMT = "NZUPMT";

        /// <summary>
        /// NZUSER.
        /// </summary>
        public const string NZUSER = "NZUSER";

        /// <summary>
        /// NZTORG.
        /// </summary>
        public const string NZTORG = "NZTORG";

        /// <summary>
        /// NZPID.
        /// </summary>
        public const string NZPID = "NZPID";

        /// <summary>
        /// NZENTJ.
        /// </summary>
        public const string NZENTJ = "NZENTJ";

        /// <summary>
        /// NZJOBN.
        /// </summary>
        public const string NZJOBN = "NZJOBN";

        /// <summary>
        /// NZSFAV.
        /// </summary>
        public const string NZSFAV = "NZSFAV";
    }

    /// <inheritdoc />
    public override string TableName => "F150123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NZSFDN", "NZSFDN", JdeDataType.String, 20, true, true),
        new JdeField("NZAM01", "NZAM01", JdeDataType.String, 6, true, true),
        new JdeField("NZURAB", "NZURAB", JdeDataType.Numeric),
        new JdeField("NZURAT", "NZURAT", JdeDataType.Numeric),
        new JdeField("NZURCD", "NZURCD", JdeDataType.String, 4),
        new JdeField("NZURDT", "NZURDT", JdeDataType.Numeric),
        new JdeField("NZURRF", "NZURRF", JdeDataType.String, 30),
        new JdeField("NZUPMJ", "NZUPMJ", JdeDataType.Numeric),
        new JdeField("NZUPMT", "NZUPMT", JdeDataType.Numeric),
        new JdeField("NZUSER", "NZUSER", JdeDataType.String, 20),
        new JdeField("NZTORG", "NZTORG", JdeDataType.String, 20),
        new JdeField("NZPID", "NZPID", JdeDataType.String, 20),
        new JdeField("NZENTJ", "NZENTJ", JdeDataType.Numeric),
        new JdeField("NZJOBN", "NZJOBN", JdeDataType.String, 20),
        new JdeField("NZSFAV", "NZSFAV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150123_0", "Primary Key on NZSFDN, NZAM01", new[] { "NZSFDN", "NZAM01" }, isUnique: true, isPrimaryKey: true)
    };
}
