using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82195 - .
/// </summary>
public class F82195 : JdeTable
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
        /// A4FIL2.
        /// </summary>
        public const string A4FIL2 = "A4FIL2";

        /// <summary>
        /// A4FIL3.
        /// </summary>
        public const string A4FIL3 = "A4FIL3";

        /// <summary>
        /// A4FIL9.
        /// </summary>
        public const string A4FIL9 = "A4FIL9";

        /// <summary>
        /// A4FILE.
        /// </summary>
        public const string A4FILE = "A4FILE";

        /// <summary>
        /// A4FIL8.
        /// </summary>
        public const string A4FIL8 = "A4FIL8";

        /// <summary>
        /// A4FILA.
        /// </summary>
        public const string A4FILA = "A4FILA";

        /// <summary>
        /// A4FILB.
        /// </summary>
        public const string A4FILB = "A4FILB";
    }

    /// <inheritdoc />
    public override string TableName => "F82195";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A4FIL1", "A4FIL1", JdeDataType.String, 26),
        new JdeField("A4LGF", "A4LGF", JdeDataType.String, 20, true, true),
        new JdeField("A4FIL2", "A4FIL2", JdeDataType.String, 400),
        new JdeField("A4FIL3", "A4FIL3", JdeDataType.String, 400),
        new JdeField("A4FIL9", "A4FIL9", JdeDataType.String, 140),
        new JdeField("A4FILE", "A4FILE", JdeDataType.String, 20),
        new JdeField("A4FIL8", "A4FIL8", JdeDataType.String, 400),
        new JdeField("A4FILA", "A4FILA", JdeDataType.String, 200),
        new JdeField("A4FILB", "A4FILB", JdeDataType.String, 110)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82195_0", "Primary Key on A4LGF", new[] { "A4LGF" }, isUnique: true, isPrimaryKey: true)
    };
}
