using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T013 - .
/// </summary>
public class F75T013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EACO.
        /// </summary>
        public const string EACO = "EACO";

        /// <summary>
        /// EA75TDSI.
        /// </summary>
        public const string EA75TDSI = "EA75TDSI";

        /// <summary>
        /// EAAID.
        /// </summary>
        public const string EAAID = "EAAID";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EATDAY.
        /// </summary>
        public const string EATDAY = "EATDAY";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75T013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EACO", "EACO", JdeDataType.String, 10, true, true),
        new JdeField("EA75TDSI", "EA75TDSI", JdeDataType.String, 10, true, true),
        new JdeField("EAAID", "EAAID", JdeDataType.String, 16, true, true),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EATDAY", "EATDAY", JdeDataType.Numeric),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T013_0", "Primary Key on EACO, EA75TDSI, EAAID", new[] { "EACO", "EA75TDSI", "EAAID" }, isUnique: true, isPrimaryKey: true)
    };
}
