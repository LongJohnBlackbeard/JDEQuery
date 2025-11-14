using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A395 - .
/// </summary>
public class F76A395 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AADCT.
        /// </summary>
        public const string AADCT = "AADCT";

        /// <summary>
        /// AADCTO.
        /// </summary>
        public const string AADCTO = "AADCTO";

        /// <summary>
        /// AAANUM.
        /// </summary>
        public const string AAANUM = "AAANUM";

        /// <summary>
        /// AATORG.
        /// </summary>
        public const string AATORG = "AATORG";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A395";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AADCT", "AADCT", JdeDataType.String, 4, true, true),
        new JdeField("AADCTO", "AADCTO", JdeDataType.String, 4, true, true),
        new JdeField("AAANUM", "AAANUM", JdeDataType.Numeric),
        new JdeField("AATORG", "AATORG", JdeDataType.String, 20),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A395_0", "Primary Key on AADCT, AADCTO", new[] { "AADCT", "AADCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
