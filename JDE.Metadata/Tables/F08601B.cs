using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08601B - .
/// </summary>
public class F08601B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITCASE.
        /// </summary>
        public const string ITCASE = "ITCASE";

        /// <summary>
        /// ITCTR.
        /// </summary>
        public const string ITCTR = "ITCTR";

        /// <summary>
        /// ITEV01.
        /// </summary>
        public const string ITEV01 = "ITEV01";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08601B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITCASE", "ITCASE", JdeDataType.Numeric, null, true, true),
        new JdeField("ITCTR", "ITCTR", JdeDataType.String, 6),
        new JdeField("ITEV01", "ITEV01", JdeDataType.String, 2),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08601B_0", "Primary Key on ITCASE", new[] { "ITCASE" }, isUnique: true, isPrimaryKey: true)
    };
}
