using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82102 - .
/// </summary>
public class F82102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1QRYG.
        /// </summary>
        public const string A1QRYG = "A1QRYG";

        /// <summary>
        /// A1QRYN.
        /// </summary>
        public const string A1QRYN = "A1QRYN";

        /// <summary>
        /// A1JNF1.
        /// </summary>
        public const string A1JNF1 = "A1JNF1";

        /// <summary>
        /// A1JNI1.
        /// </summary>
        public const string A1JNI1 = "A1JNI1";

        /// <summary>
        /// A1JNF2.
        /// </summary>
        public const string A1JNF2 = "A1JNF2";

        /// <summary>
        /// A1JNI2.
        /// </summary>
        public const string A1JNI2 = "A1JNI2";

        /// <summary>
        /// A1JNRL.
        /// </summary>
        public const string A1JNRL = "A1JNRL";
    }

    /// <inheritdoc />
    public override string TableName => "F82102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1QRYG", "A1QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A1QRYN", "A1QRYN", JdeDataType.String, 20),
        new JdeField("A1JNF1", "A1JNF1", JdeDataType.String, 20),
        new JdeField("A1JNI1", "A1JNI1", JdeDataType.Numeric),
        new JdeField("A1JNF2", "A1JNF2", JdeDataType.String, 20),
        new JdeField("A1JNI2", "A1JNI2", JdeDataType.Numeric),
        new JdeField("A1JNRL", "A1JNRL", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82102_0", "Primary Key on A1QRYG", new[] { "A1QRYG" }, isUnique: true, isPrimaryKey: true)
    };
}
