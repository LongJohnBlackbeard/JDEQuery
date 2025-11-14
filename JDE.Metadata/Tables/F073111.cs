using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F073111 - .
/// </summary>
public class F073111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AAACTVTYP.
        /// </summary>
        public const string AAACTVTYP = "AAACTVTYP";

        /// <summary>
        /// AAPDBA.
        /// </summary>
        public const string AAPDBA = "AAPDBA";

        /// <summary>
        /// AALTTP.
        /// </summary>
        public const string AALTTP = "AALTTP";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAMKEY.
        /// </summary>
        public const string AAMKEY = "AAMKEY";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";
    }

    /// <inheritdoc />
    public override string TableName => "F073111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AAACTVTYP", "AAACTVTYP", JdeDataType.String, 82, true, true),
        new JdeField("AAPDBA", "AAPDBA", JdeDataType.Numeric),
        new JdeField("AALTTP", "AALTTP", JdeDataType.String, 4),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAMKEY", "AAMKEY", JdeDataType.String, 30),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F073111_0", "Primary Key on AAACTVTYP", new[] { "AAACTVTYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F073111_2", "Index on AAPDBA", new[] { "AAPDBA" })
    };
}
