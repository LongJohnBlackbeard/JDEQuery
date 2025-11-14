using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06931 - .
/// </summary>
public class F06931 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3WTAB.
        /// </summary>
        public const string J3WTAB = "J3WTAB";

        /// <summary>
        /// J3EXA.
        /// </summary>
        public const string J3EXA = "J3EXA";

        /// <summary>
        /// J3TARA.
        /// </summary>
        public const string J3TARA = "J3TARA";

        /// <summary>
        /// J3PFRQ.
        /// </summary>
        public const string J3PFRQ = "J3PFRQ";

        /// <summary>
        /// J3EFTB.
        /// </summary>
        public const string J3EFTB = "J3EFTB";

        /// <summary>
        /// J3EFTE.
        /// </summary>
        public const string J3EFTE = "J3EFTE";

        /// <summary>
        /// J3WGDB.
        /// </summary>
        public const string J3WGDB = "J3WGDB";

        /// <summary>
        /// J3WGDE.
        /// </summary>
        public const string J3WGDE = "J3WGDE";

        /// <summary>
        /// J3RTAM.
        /// </summary>
        public const string J3RTAM = "J3RTAM";

        /// <summary>
        /// J3WAMH.
        /// </summary>
        public const string J3WAMH = "J3WAMH";
    }

    /// <inheritdoc />
    public override string TableName => "F06931";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3WTAB", "J3WTAB", JdeDataType.String, 10, true, true),
        new JdeField("J3EXA", "J3EXA", JdeDataType.String, 60),
        new JdeField("J3TARA", "J3TARA", JdeDataType.String, 20, true, true),
        new JdeField("J3PFRQ", "J3PFRQ", JdeDataType.String, 2, true, true),
        new JdeField("J3EFTB", "J3EFTB", JdeDataType.Numeric),
        new JdeField("J3EFTE", "J3EFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("J3WGDB", "J3WGDB", JdeDataType.Numeric),
        new JdeField("J3WGDE", "J3WGDE", JdeDataType.Numeric, null, true, true),
        new JdeField("J3RTAM", "J3RTAM", JdeDataType.Numeric),
        new JdeField("J3WAMH", "J3WAMH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06931_0", "Primary Key on J3WTAB, J3TARA, J3PFRQ, J3EFTE, J3WGDE", new[] { "J3WTAB", "J3TARA", "J3PFRQ", "J3EFTE", "J3WGDE" }, isUnique: true, isPrimaryKey: true)
    };
}
