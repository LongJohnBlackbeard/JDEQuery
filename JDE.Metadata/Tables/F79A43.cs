using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A43 - .
/// </summary>
public class F79A43 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KL79AGKLID.
        /// </summary>
        public const string KL79AGKLID = "KL79AGKLID";

        /// <summary>
        /// KL79AGKPID.
        /// </summary>
        public const string KL79AGKPID = "KL79AGKPID";

        /// <summary>
        /// KL79AKLTY.
        /// </summary>
        public const string KL79AKLTY = "KL79AKLTY";

        /// <summary>
        /// KL79AGESID.
        /// </summary>
        public const string KL79AGESID = "KL79AGESID";

        /// <summary>
        /// KLPID.
        /// </summary>
        public const string KLPID = "KLPID";

        /// <summary>
        /// KLUSER.
        /// </summary>
        public const string KLUSER = "KLUSER";

        /// <summary>
        /// KLJOBN.
        /// </summary>
        public const string KLJOBN = "KLJOBN";

        /// <summary>
        /// KLUPMJ.
        /// </summary>
        public const string KLUPMJ = "KLUPMJ";

        /// <summary>
        /// KLTDAY.
        /// </summary>
        public const string KLTDAY = "KLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A43";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KL79AGKLID", "KL79AGKLID", JdeDataType.Numeric, null, true, true),
        new JdeField("KL79AGKPID", "KL79AGKPID", JdeDataType.Numeric),
        new JdeField("KL79AKLTY", "KL79AKLTY", JdeDataType.String, 20),
        new JdeField("KL79AGESID", "KL79AGESID", JdeDataType.Numeric),
        new JdeField("KLPID", "KLPID", JdeDataType.String, 20),
        new JdeField("KLUSER", "KLUSER", JdeDataType.String, 20),
        new JdeField("KLJOBN", "KLJOBN", JdeDataType.String, 20),
        new JdeField("KLUPMJ", "KLUPMJ", JdeDataType.Numeric),
        new JdeField("KLTDAY", "KLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A43_0", "Primary Key on KL79AGKLID", new[] { "KL79AGKLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A43_2", "Index on KL79AGKPID, KL79AKLTY", new[] { "KL79AGKPID", "KL79AKLTY" })
    };
}
