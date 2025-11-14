using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B07AG - .
/// </summary>
public class F31B07AG : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGWEURAG.
        /// </summary>
        public const string AGWEURAG = "AGWEURAG";

        /// <summary>
        /// AGDL01.
        /// </summary>
        public const string AGDL01 = "AGDL01";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGTDAY.
        /// </summary>
        public const string AGTDAY = "AGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B07AG";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGWEURAG", "AGWEURAG", JdeDataType.String, 24, true, true),
        new JdeField("AGDL01", "AGDL01", JdeDataType.String, 60),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGTDAY", "AGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B07AG_0", "Primary Key on AGWEURAG", new[] { "AGWEURAG" }, isUnique: true, isPrimaryKey: true)
    };
}
