using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1212 - .
/// </summary>
public class F1212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FYNUMB.
        /// </summary>
        public const string FYNUMB = "FYNUMB";

        /// <summary>
        /// FYAAID.
        /// </summary>
        public const string FYAAID = "FYAAID";

        /// <summary>
        /// FYEFTB.
        /// </summary>
        public const string FYEFTB = "FYEFTB";

        /// <summary>
        /// FYEFTE.
        /// </summary>
        public const string FYEFTE = "FYEFTE";

        /// <summary>
        /// FYUPMJ.
        /// </summary>
        public const string FYUPMJ = "FYUPMJ";

        /// <summary>
        /// FYUSER.
        /// </summary>
        public const string FYUSER = "FYUSER";

        /// <summary>
        /// FYPID.
        /// </summary>
        public const string FYPID = "FYPID";

        /// <summary>
        /// FYJOBN.
        /// </summary>
        public const string FYJOBN = "FYJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FYNUMB", "FYNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FYAAID", "FYAAID", JdeDataType.Numeric, null, true, true),
        new JdeField("FYEFTB", "FYEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("FYEFTE", "FYEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("FYUPMJ", "FYUPMJ", JdeDataType.Numeric),
        new JdeField("FYUSER", "FYUSER", JdeDataType.String, 20),
        new JdeField("FYPID", "FYPID", JdeDataType.String, 20),
        new JdeField("FYJOBN", "FYJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1212_0", "Primary Key on FYNUMB, FYAAID, FYEFTB, FYEFTE", new[] { "FYNUMB", "FYAAID", "FYEFTB", "FYEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1212_2", "Index on FYNUMB, SYS_NC00009$, SYS_NC00010$", new[] { "FYNUMB", "SYS_NC00009$", "SYS_NC00010$" }),
        new JdeIndex("F1212_3", "Index on FYAAID, SYS_NC00009$, SYS_NC00010$", new[] { "FYAAID", "SYS_NC00009$", "SYS_NC00010$" })
    };
}
