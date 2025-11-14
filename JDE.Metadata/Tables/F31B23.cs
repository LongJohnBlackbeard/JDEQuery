using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B23 - .
/// </summary>
public class F31B23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRGLPT.
        /// </summary>
        public const string CRGLPT = "CRGLPT";

        /// <summary>
        /// CRWCG.
        /// </summary>
        public const string CRWCG = "CRWCG";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRGLPT", "CRGLPT", JdeDataType.String, 8, true, true),
        new JdeField("CRWCG", "CRWCG", JdeDataType.String, 24),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B23_0", "Primary Key on CRGLPT", new[] { "CRGLPT" }, isUnique: true, isPrimaryKey: true)
    };
}
