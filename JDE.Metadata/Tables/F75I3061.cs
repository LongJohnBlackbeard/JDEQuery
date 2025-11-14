using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3061 - .
/// </summary>
public class F75I3061 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECYEXU.
        /// </summary>
        public const string ECYEXU = "ECYEXU";

        /// <summary>
        /// ECI75TXTY.
        /// </summary>
        public const string ECI75TXTY = "ECI75TXTY";

        /// <summary>
        /// ECAID.
        /// </summary>
        public const string ECAID = "ECAID";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3061";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECYEXU", "ECYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("ECI75TXTY", "ECI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("ECAID", "ECAID", JdeDataType.String, 16),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3061_0", "Primary Key on ECYEXU, ECI75TXTY", new[] { "ECYEXU", "ECI75TXTY" }, isUnique: true, isPrimaryKey: true)
    };
}
