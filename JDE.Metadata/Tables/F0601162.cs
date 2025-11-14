using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0601162 - .
/// </summary>
public class F0601162 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHEFTO.
        /// </summary>
        public const string PHEFTO = "PHEFTO";

        /// <summary>
        /// PHSVER.
        /// </summary>
        public const string PHSVER = "PHSVER";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0601162";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHEFTO", "PHEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSVER", "PHSVER", JdeDataType.String, 20, true, true),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0601162_0", "Primary Key on PHEFTO, PHSVER", new[] { "PHEFTO", "PHSVER" }, isUnique: true, isPrimaryKey: true)
    };
}
