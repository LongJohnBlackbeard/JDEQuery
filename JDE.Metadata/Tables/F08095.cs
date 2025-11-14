using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08095 - .
/// </summary>
public class F08095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J9TYPP.
        /// </summary>
        public const string J9TYPP = "J9TYPP";

        /// <summary>
        /// J9TYRC.
        /// </summary>
        public const string J9TYRC = "J9TYRC";

        /// <summary>
        /// J9CVL1.
        /// </summary>
        public const string J9CVL1 = "J9CVL1";

        /// <summary>
        /// J9CVL2.
        /// </summary>
        public const string J9CVL2 = "J9CVL2";

        /// <summary>
        /// J9CVL3.
        /// </summary>
        public const string J9CVL3 = "J9CVL3";

        /// <summary>
        /// J9CVL4.
        /// </summary>
        public const string J9CVL4 = "J9CVL4";

        /// <summary>
        /// J9CVL5.
        /// </summary>
        public const string J9CVL5 = "J9CVL5";

        /// <summary>
        /// J9CVL6.
        /// </summary>
        public const string J9CVL6 = "J9CVL6";

        /// <summary>
        /// J9CVL7.
        /// </summary>
        public const string J9CVL7 = "J9CVL7";

        /// <summary>
        /// J9CVL8.
        /// </summary>
        public const string J9CVL8 = "J9CVL8";

        /// <summary>
        /// J9MOV1.
        /// </summary>
        public const string J9MOV1 = "J9MOV1";

        /// <summary>
        /// J9MOV2.
        /// </summary>
        public const string J9MOV2 = "J9MOV2";

        /// <summary>
        /// J9MOV3.
        /// </summary>
        public const string J9MOV3 = "J9MOV3";

        /// <summary>
        /// J9MOV5.
        /// </summary>
        public const string J9MOV5 = "J9MOV5";

        /// <summary>
        /// J9MOV6.
        /// </summary>
        public const string J9MOV6 = "J9MOV6";

        /// <summary>
        /// J9MOV7.
        /// </summary>
        public const string J9MOV7 = "J9MOV7";

        /// <summary>
        /// J9MOV8.
        /// </summary>
        public const string J9MOV8 = "J9MOV8";
    }

    /// <inheritdoc />
    public override string TableName => "F08095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J9TYPP", "J9TYPP", JdeDataType.String, 10, true, true),
        new JdeField("J9TYRC", "J9TYRC", JdeDataType.String, 4, true, true),
        new JdeField("J9CVL1", "J9CVL1", JdeDataType.String, 2),
        new JdeField("J9CVL2", "J9CVL2", JdeDataType.String, 2),
        new JdeField("J9CVL3", "J9CVL3", JdeDataType.String, 2),
        new JdeField("J9CVL4", "J9CVL4", JdeDataType.String, 2),
        new JdeField("J9CVL5", "J9CVL5", JdeDataType.String, 2),
        new JdeField("J9CVL6", "J9CVL6", JdeDataType.String, 2),
        new JdeField("J9CVL7", "J9CVL7", JdeDataType.String, 2),
        new JdeField("J9CVL8", "J9CVL8", JdeDataType.String, 2),
        new JdeField("J9MOV1", "J9MOV1", JdeDataType.String, 2),
        new JdeField("J9MOV2", "J9MOV2", JdeDataType.String, 2),
        new JdeField("J9MOV3", "J9MOV3", JdeDataType.String, 2),
        new JdeField("J9MOV5", "J9MOV5", JdeDataType.String, 2),
        new JdeField("J9MOV6", "J9MOV6", JdeDataType.String, 2),
        new JdeField("J9MOV7", "J9MOV7", JdeDataType.String, 2),
        new JdeField("J9MOV8", "J9MOV8", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08095_0", "Primary Key on J9TYPP, J9TYRC", new[] { "J9TYPP", "J9TYRC" }, isUnique: true, isPrimaryKey: true)
    };
}
