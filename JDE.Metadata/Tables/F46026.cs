using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46026 - .
/// </summary>
public class F46026 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACMCU.
        /// </summary>
        public const string ACMCU = "ACMCU";

        /// <summary>
        /// ACLOCN.
        /// </summary>
        public const string ACLOCN = "ACLOCN";

        /// <summary>
        /// ACEQTY.
        /// </summary>
        public const string ACEQTY = "ACEQTY";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACTDAY.
        /// </summary>
        public const string ACTDAY = "ACTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46026";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACMCU", "ACMCU", JdeDataType.String, 24, true, true),
        new JdeField("ACLOCN", "ACLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ACEQTY", "ACEQTY", JdeDataType.String, 10, true, true),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACTDAY", "ACTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46026_0", "Primary Key on ACMCU, ACLOCN, ACEQTY", new[] { "ACMCU", "ACLOCN", "ACEQTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46026_2", "Index on ACMCU, ACLOCN", new[] { "ACMCU", "ACLOCN" })
    };
}
