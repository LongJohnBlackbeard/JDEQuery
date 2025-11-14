using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4802H - .
/// </summary>
public class F4802H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCDOCO.
        /// </summary>
        public const string WCDOCO = "WCDOCO";

        /// <summary>
        /// WCDCTO.
        /// </summary>
        public const string WCDCTO = "WCDCTO";

        /// <summary>
        /// WCSFXO.
        /// </summary>
        public const string WCSFXO = "WCSFXO";

        /// <summary>
        /// WCTYPR.
        /// </summary>
        public const string WCTYPR = "WCTYPR";

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
        /// WCTDAY.
        /// </summary>
        public const string WCTDAY = "WCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4802H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCDOCO", "WCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDCTO", "WCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WCSFXO", "WCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("WCTYPR", "WCTYPR", JdeDataType.String, 2, true, true),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCTDAY", "WCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4802H_0", "Primary Key on WCDOCO, WCDCTO, WCSFXO, WCTYPR", new[] { "WCDOCO", "WCDCTO", "WCSFXO", "WCTYPR" }, isUnique: true, isPrimaryKey: true)
    };
}
