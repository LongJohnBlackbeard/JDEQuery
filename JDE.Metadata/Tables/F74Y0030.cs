using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y0030 - .
/// </summary>
public class F74Y0030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTUKID.
        /// </summary>
        public const string BTUKID = "BTUKID";

        /// <summary>
        /// BTY74CDC.
        /// </summary>
        public const string BTY74CDC = "BTY74CDC";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTJOBN.
        /// </summary>
        public const string BTJOBN = "BTJOBN";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTUPMT.
        /// </summary>
        public const string BTUPMT = "BTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y0030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTUKID", "BTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BTY74CDC", "BTY74CDC", JdeDataType.String, 32),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTJOBN", "BTJOBN", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTUPMT", "BTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y0030_0", "Primary Key on BTUKID", new[] { "BTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
