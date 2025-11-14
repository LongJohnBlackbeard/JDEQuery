using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82196 - .
/// </summary>
public class F82196 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A4FIL1.
        /// </summary>
        public const string A4FIL1 = "A4FIL1";

        /// <summary>
        /// A4LGF.
        /// </summary>
        public const string A4LGF = "A4LGF";

        /// <summary>
        /// A4FIL4.
        /// </summary>
        public const string A4FIL4 = "A4FIL4";

        /// <summary>
        /// A4FILE.
        /// </summary>
        public const string A4FILE = "A4FILE";

        /// <summary>
        /// A4FIL5.
        /// </summary>
        public const string A4FIL5 = "A4FIL5";

        /// <summary>
        /// A4JTFL.
        /// </summary>
        public const string A4JTFL = "A4JTFL";

        /// <summary>
        /// A4FIL6.
        /// </summary>
        public const string A4FIL6 = "A4FIL6";

        /// <summary>
        /// A4JNF1.
        /// </summary>
        public const string A4JNF1 = "A4JNF1";

        /// <summary>
        /// A4JNF2.
        /// </summary>
        public const string A4JNF2 = "A4JNF2";

        /// <summary>
        /// A4FIL7.
        /// </summary>
        public const string A4FIL7 = "A4FIL7";
    }

    /// <inheritdoc />
    public override string TableName => "F82196";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A4FIL1", "A4FIL1", JdeDataType.String, 26),
        new JdeField("A4LGF", "A4LGF", JdeDataType.String, 20, true, true),
        new JdeField("A4FIL4", "A4FIL4", JdeDataType.String, 130),
        new JdeField("A4FILE", "A4FILE", JdeDataType.String, 20),
        new JdeField("A4FIL5", "A4FIL5", JdeDataType.String, 24),
        new JdeField("A4JTFL", "A4JTFL", JdeDataType.String, 20),
        new JdeField("A4FIL6", "A4FIL6", JdeDataType.String, 20),
        new JdeField("A4JNF1", "A4JNF1", JdeDataType.String, 20),
        new JdeField("A4JNF2", "A4JNF2", JdeDataType.String, 20),
        new JdeField("A4FIL7", "A4FIL7", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82196_0", "Primary Key on A4LGF", new[] { "A4LGF" }, isUnique: true, isPrimaryKey: true)
    };
}
