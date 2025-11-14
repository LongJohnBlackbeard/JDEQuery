using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D311 - .
/// </summary>
public class F80D311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIALERTINS.
        /// </summary>
        public const string AIALERTINS = "AIALERTINS";

        /// <summary>
        /// AIALERT.
        /// </summary>
        public const string AIALERT = "AIALERT";

        /// <summary>
        /// AIDL01.
        /// </summary>
        public const string AIDL01 = "AIDL01";

        /// <summary>
        /// AIALERTAV.
        /// </summary>
        public const string AIALERTAV = "AIALERTAV";

        /// <summary>
        /// AIALERTSTS.
        /// </summary>
        public const string AIALERTSTS = "AIALERTSTS";

        /// <summary>
        /// AIURCD.
        /// </summary>
        public const string AIURCD = "AIURCD";

        /// <summary>
        /// AIURDT.
        /// </summary>
        public const string AIURDT = "AIURDT";

        /// <summary>
        /// AIURAT.
        /// </summary>
        public const string AIURAT = "AIURAT";

        /// <summary>
        /// AIURAB.
        /// </summary>
        public const string AIURAB = "AIURAB";

        /// <summary>
        /// AIURRF.
        /// </summary>
        public const string AIURRF = "AIURRF";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIMKEY.
        /// </summary>
        public const string AIMKEY = "AIMKEY";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIUUPMJ.
        /// </summary>
        public const string AIUUPMJ = "AIUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIALERTINS", "AIALERTINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AIALERT", "AIALERT", JdeDataType.Numeric),
        new JdeField("AIDL01", "AIDL01", JdeDataType.String, 60),
        new JdeField("AIALERTAV", "AIALERTAV", JdeDataType.String, 400),
        new JdeField("AIALERTSTS", "AIALERTSTS", JdeDataType.String, 2),
        new JdeField("AIURCD", "AIURCD", JdeDataType.String, 4),
        new JdeField("AIURDT", "AIURDT", JdeDataType.Numeric),
        new JdeField("AIURAT", "AIURAT", JdeDataType.Numeric),
        new JdeField("AIURAB", "AIURAB", JdeDataType.Numeric),
        new JdeField("AIURRF", "AIURRF", JdeDataType.String, 30),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIMKEY", "AIMKEY", JdeDataType.String, 30),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIUUPMJ", "AIUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D311_0", "Primary Key on AIALERTINS", new[] { "AIALERTINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D311_2", "Index on AIALERT, AIALERTAV", new[] { "AIALERT", "AIALERTAV" }),
        new JdeIndex("F80D311_3", "Index on AIALERT, AIALERTAV, AIALERTSTS", new[] { "AIALERT", "AIALERTAV", "AIALERTSTS" })
    };
}
