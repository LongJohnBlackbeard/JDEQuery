using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B21 - .
/// </summary>
public class F31B21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGWCG.
        /// </summary>
        public const string CGWCG = "CGWCG";

        /// <summary>
        /// CGDL01.
        /// </summary>
        public const string CGDL01 = "CGDL01";

        /// <summary>
        /// CGCRCD.
        /// </summary>
        public const string CGCRCD = "CGCRCD";

        /// <summary>
        /// CGUSER.
        /// </summary>
        public const string CGUSER = "CGUSER";

        /// <summary>
        /// CGPID.
        /// </summary>
        public const string CGPID = "CGPID";

        /// <summary>
        /// CGJOBN.
        /// </summary>
        public const string CGJOBN = "CGJOBN";

        /// <summary>
        /// CGUPMJ.
        /// </summary>
        public const string CGUPMJ = "CGUPMJ";

        /// <summary>
        /// CGTDAY.
        /// </summary>
        public const string CGTDAY = "CGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGWCG", "CGWCG", JdeDataType.String, 24, true, true),
        new JdeField("CGDL01", "CGDL01", JdeDataType.String, 60),
        new JdeField("CGCRCD", "CGCRCD", JdeDataType.String, 6),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGTDAY", "CGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B21_0", "Primary Key on CGWCG", new[] { "CGWCG" }, isUnique: true, isPrimaryKey: true)
    };
}
