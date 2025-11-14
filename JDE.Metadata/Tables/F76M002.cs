using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M002 - .
/// </summary>
public class F76M002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCM76WCON.
        /// </summary>
        public const string WCM76WCON = "WCM76WCON";

        /// <summary>
        /// WCDESC.
        /// </summary>
        public const string WCDESC = "WCDESC";

        /// <summary>
        /// WCM76LCON.
        /// </summary>
        public const string WCM76LCON = "WCM76LCON";

        /// <summary>
        /// WCM76WHTP.
        /// </summary>
        public const string WCM76WHTP = "WCM76WHTP";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCM76WCON", "WCM76WCON", JdeDataType.String, 6, true, true),
        new JdeField("WCDESC", "WCDESC", JdeDataType.String, 60),
        new JdeField("WCM76LCON", "WCM76LCON", JdeDataType.String, 6),
        new JdeField("WCM76WHTP", "WCM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M002_0", "Primary Key on WCM76WCON, WCM76WHTP", new[] { "WCM76WCON", "WCM76WHTP" }, isUnique: true, isPrimaryKey: true)
    };
}
