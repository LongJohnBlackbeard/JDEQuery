using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T70W - .
/// </summary>
public class F49T70W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWINT01.
        /// </summary>
        public const string CWINT01 = "CWINT01";

        /// <summary>
        /// CWOTDOMAIN.
        /// </summary>
        public const string CWOTDOMAIN = "CWOTDOMAIN";

        /// <summary>
        /// CWDTAI.
        /// </summary>
        public const string CWDTAI = "CWDTAI";

        /// <summary>
        /// CWSDS1.
        /// </summary>
        public const string CWSDS1 = "CWSDS1";

        /// <summary>
        /// CWAN8.
        /// </summary>
        public const string CWAN8 = "CWAN8";

        /// <summary>
        /// CWALPH.
        /// </summary>
        public const string CWALPH = "CWALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F49T70W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWINT01", "CWINT01", JdeDataType.Numeric, null, true, true),
        new JdeField("CWOTDOMAIN", "CWOTDOMAIN", JdeDataType.String, 100, true, true),
        new JdeField("CWDTAI", "CWDTAI", JdeDataType.String, 20),
        new JdeField("CWSDS1", "CWSDS1", JdeDataType.String, 100),
        new JdeField("CWAN8", "CWAN8", JdeDataType.Numeric),
        new JdeField("CWALPH", "CWALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T70W_0", "Primary Key on CWOTDOMAIN, CWINT01", new[] { "CWOTDOMAIN", "CWINT01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T70W_2", "Index on CWINT01", new[] { "CWINT01" })
    };
}
