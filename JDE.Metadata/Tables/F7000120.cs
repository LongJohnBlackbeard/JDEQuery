using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7000120 - .
/// </summary>
public class F7000120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ODK70ADOBN.
        /// </summary>
        public const string ODK70ADOBN = "ODK70ADOBN";

        /// <summary>
        /// ODK70ADTT.
        /// </summary>
        public const string ODK70ADTT = "ODK70ADTT";

        /// <summary>
        /// ODUSER.
        /// </summary>
        public const string ODUSER = "ODUSER";

        /// <summary>
        /// ODPID.
        /// </summary>
        public const string ODPID = "ODPID";

        /// <summary>
        /// ODUPMJ.
        /// </summary>
        public const string ODUPMJ = "ODUPMJ";

        /// <summary>
        /// ODUPMT.
        /// </summary>
        public const string ODUPMT = "ODUPMT";

        /// <summary>
        /// ODJOBN.
        /// </summary>
        public const string ODJOBN = "ODJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F7000120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ODK70ADOBN", "ODK70ADOBN", JdeDataType.String, 20, true, true),
        new JdeField("ODK70ADTT", "ODK70ADTT", JdeDataType.String, 20),
        new JdeField("ODUSER", "ODUSER", JdeDataType.String, 20),
        new JdeField("ODPID", "ODPID", JdeDataType.String, 20),
        new JdeField("ODUPMJ", "ODUPMJ", JdeDataType.Numeric),
        new JdeField("ODUPMT", "ODUPMT", JdeDataType.Numeric),
        new JdeField("ODJOBN", "ODJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7000120_0", "Primary Key on ODK70ADOBN", new[] { "ODK70ADOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
