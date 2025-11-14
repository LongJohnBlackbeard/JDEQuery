using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4953 - .
/// </summary>
public class F4953 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RGRRUL.
        /// </summary>
        public const string RGRRUL = "RGRRUL";

        /// <summary>
        /// RGSQNR.
        /// </summary>
        public const string RGSQNR = "RGSQNR";

        /// <summary>
        /// RGUSER.
        /// </summary>
        public const string RGUSER = "RGUSER";

        /// <summary>
        /// RGPID.
        /// </summary>
        public const string RGPID = "RGPID";

        /// <summary>
        /// RGJOBN.
        /// </summary>
        public const string RGJOBN = "RGJOBN";

        /// <summary>
        /// RGUPMJ.
        /// </summary>
        public const string RGUPMJ = "RGUPMJ";

        /// <summary>
        /// RGTDAY.
        /// </summary>
        public const string RGTDAY = "RGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4953";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RGRRUL", "RGRRUL", JdeDataType.String, 4, true, true),
        new JdeField("RGSQNR", "RGSQNR", JdeDataType.Numeric),
        new JdeField("RGUSER", "RGUSER", JdeDataType.String, 20),
        new JdeField("RGPID", "RGPID", JdeDataType.String, 20),
        new JdeField("RGJOBN", "RGJOBN", JdeDataType.String, 20),
        new JdeField("RGUPMJ", "RGUPMJ", JdeDataType.Numeric),
        new JdeField("RGTDAY", "RGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4953_0", "Primary Key on RGRRUL", new[] { "RGRRUL" }, isUnique: true, isPrimaryKey: true)
    };
}
