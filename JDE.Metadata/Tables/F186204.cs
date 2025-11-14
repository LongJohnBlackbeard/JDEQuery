using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186204 - .
/// </summary>
public class F186204 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGLRSEGID.
        /// </summary>
        public const string CGLRSEGID = "CGLRSEGID";

        /// <summary>
        /// CGLRSEGCID.
        /// </summary>
        public const string CGLRSEGCID = "CGLRSEGCID";

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
    public override string TableName => "F186204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGLRSEGID", "CGLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CGLRSEGCID", "CGLRSEGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CGUSER", "CGUSER", JdeDataType.String, 20),
        new JdeField("CGPID", "CGPID", JdeDataType.String, 20),
        new JdeField("CGJOBN", "CGJOBN", JdeDataType.String, 20),
        new JdeField("CGUPMJ", "CGUPMJ", JdeDataType.Numeric),
        new JdeField("CGTDAY", "CGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186204_0", "Primary Key on CGLRSEGID, CGLRSEGCID", new[] { "CGLRSEGID", "CGLRSEGCID" }, isUnique: true, isPrimaryKey: true)
    };
}
