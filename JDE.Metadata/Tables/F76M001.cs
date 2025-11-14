using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M001 - .
/// </summary>
public class F76M001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLM76LCON.
        /// </summary>
        public const string WLM76LCON = "WLM76LCON";

        /// <summary>
        /// WLDESC.
        /// </summary>
        public const string WLDESC = "WLDESC";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLUPMT.
        /// </summary>
        public const string WLUPMT = "WLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLM76LCON", "WLM76LCON", JdeDataType.String, 6, true, true),
        new JdeField("WLDESC", "WLDESC", JdeDataType.String, 60),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLUPMT", "WLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M001_0", "Primary Key on WLM76LCON", new[] { "WLM76LCON" }, isUnique: true, isPrimaryKey: true)
    };
}
