using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00090D - .
/// </summary>
public class F00090D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T5SDB.
        /// </summary>
        public const string T5SDB = "T5SDB";

        /// <summary>
        /// T5LNGP.
        /// </summary>
        public const string T5LNGP = "T5LNGP";

        /// <summary>
        /// T5SBD1.
        /// </summary>
        public const string T5SBD1 = "T5SBD1";

        /// <summary>
        /// T5SBD2.
        /// </summary>
        public const string T5SBD2 = "T5SBD2";

        /// <summary>
        /// T5SBD3.
        /// </summary>
        public const string T5SBD3 = "T5SBD3";

        /// <summary>
        /// T5SBD4.
        /// </summary>
        public const string T5SBD4 = "T5SBD4";

        /// <summary>
        /// T5DLMC.
        /// </summary>
        public const string T5DLMC = "T5DLMC";

        /// <summary>
        /// T5DLKC.
        /// </summary>
        public const string T5DLKC = "T5DLKC";
    }

    /// <inheritdoc />
    public override string TableName => "F00090D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T5SDB", "T5SDB", JdeDataType.String, 8, true, true),
        new JdeField("T5LNGP", "T5LNGP", JdeDataType.String, 4, true, true),
        new JdeField("T5SBD1", "T5SBD1", JdeDataType.String, 60),
        new JdeField("T5SBD2", "T5SBD2", JdeDataType.String, 60),
        new JdeField("T5SBD3", "T5SBD3", JdeDataType.String, 60),
        new JdeField("T5SBD4", "T5SBD4", JdeDataType.String, 60),
        new JdeField("T5DLMC", "T5DLMC", JdeDataType.String, 60),
        new JdeField("T5DLKC", "T5DLKC", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00090D_0", "Primary Key on T5SDB, T5LNGP", new[] { "T5SDB", "T5LNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
