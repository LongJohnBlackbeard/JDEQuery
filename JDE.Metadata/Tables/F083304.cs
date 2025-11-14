using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083304 - .
/// </summary>
public class F083304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHBSNM.
        /// </summary>
        public const string AHBSNM = "AHBSNM";

        /// <summary>
        /// AHHDCD.
        /// </summary>
        public const string AHHDCD = "AHHDCD";

        /// <summary>
        /// AHHDTY.
        /// </summary>
        public const string AHHDTY = "AHHDTY";

        /// <summary>
        /// AHSQN.
        /// </summary>
        public const string AHSQN = "AHSQN";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F083304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHBSNM", "AHBSNM", JdeDataType.String, 20, true, true),
        new JdeField("AHHDCD", "AHHDCD", JdeDataType.String, 20, true, true),
        new JdeField("AHHDTY", "AHHDTY", JdeDataType.String, 2, true, true),
        new JdeField("AHSQN", "AHSQN", JdeDataType.Numeric, null, true, true),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083304_0", "Primary Key on AHBSNM, AHHDTY, AHSQN, AHHDCD", new[] { "AHBSNM", "AHHDTY", "AHSQN", "AHHDCD" }, isUnique: true, isPrimaryKey: true)
    };
}
