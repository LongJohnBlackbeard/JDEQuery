using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B472 - .
/// </summary>
public class F76B472 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDBDFLAY.
        /// </summary>
        public const string DDBDFLAY = "DDBDFLAY";

        /// <summary>
        /// DDDRIN.
        /// </summary>
        public const string DDDRIN = "DDDRIN";

        /// <summary>
        /// DDEDTY.
        /// </summary>
        public const string DDEDTY = "DDEDTY";

        /// <summary>
        /// DDSQ#.
        /// </summary>
        public const string DDSQ_ = "DDSQ#";

        /// <summary>
        /// DDBDFLBLT.
        /// </summary>
        public const string DDBDFLBLT = "DDBDFLBLT";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDUPMT.
        /// </summary>
        public const string DDUPMT = "DDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B472";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDBDFLAY", "DDBDFLAY", JdeDataType.String, 20, true, true),
        new JdeField("DDDRIN", "DDDRIN", JdeDataType.String, 2, true, true),
        new JdeField("DDEDTY", "DDEDTY", JdeDataType.String, 2, true, true),
        new JdeField("DDSQ#", "DDSQ#", JdeDataType.String, 6, true, true),
        new JdeField("DDBDFLBLT", "DDBDFLBLT", JdeDataType.Numeric),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDUPMT", "DDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B472_0", "Primary Key on DDBDFLAY, DDDRIN, DDEDTY, DDSQ#", new[] { "DDBDFLAY", "DDDRIN", "DDEDTY", "DDSQ#" }, isUnique: true, isPrimaryKey: true)
    };
}
