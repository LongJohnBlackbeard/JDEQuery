using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0112 - .
/// </summary>
public class F76B0112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAB76AUPER.
        /// </summary>
        public const string AAB76AUPER = "AAB76AUPER";

        /// <summary>
        /// AAB76APERS.
        /// </summary>
        public const string AAB76APERS = "AAB76APERS";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAB76AUPER", "AAB76AUPER", JdeDataType.Numeric, null, true, true),
        new JdeField("AAB76APERS", "AAB76APERS", JdeDataType.Numeric, null, true, true),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0112_0", "Primary Key on AAB76APERS, AAB76AUPER", new[] { "AAB76APERS", "AAB76AUPER" }, isUnique: true, isPrimaryKey: true)
    };
}
