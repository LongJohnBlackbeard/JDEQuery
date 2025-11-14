using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T80W - .
/// </summary>
public class F49T80W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LWINT01.
        /// </summary>
        public const string LWINT01 = "LWINT01";

        /// <summary>
        /// LWOTDOMAIN.
        /// </summary>
        public const string LWOTDOMAIN = "LWOTDOMAIN";

        /// <summary>
        /// LWDTAI.
        /// </summary>
        public const string LWDTAI = "LWDTAI";

        /// <summary>
        /// LWSDS1.
        /// </summary>
        public const string LWSDS1 = "LWSDS1";

        /// <summary>
        /// LWAN8.
        /// </summary>
        public const string LWAN8 = "LWAN8";

        /// <summary>
        /// LWALPH.
        /// </summary>
        public const string LWALPH = "LWALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F49T80W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LWINT01", "LWINT01", JdeDataType.Numeric, null, true, true),
        new JdeField("LWOTDOMAIN", "LWOTDOMAIN", JdeDataType.String, 100, true, true),
        new JdeField("LWDTAI", "LWDTAI", JdeDataType.String, 20),
        new JdeField("LWSDS1", "LWSDS1", JdeDataType.String, 100),
        new JdeField("LWAN8", "LWAN8", JdeDataType.Numeric),
        new JdeField("LWALPH", "LWALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T80W_0", "Primary Key on LWOTDOMAIN, LWINT01", new[] { "LWOTDOMAIN", "LWINT01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T80W_2", "Index on LWINT01", new[] { "LWINT01" })
    };
}
