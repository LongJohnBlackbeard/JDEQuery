using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20106 - .
/// </summary>
public class F20106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMEXPTYPE.
        /// </summary>
        public const string EMEXPTYPE = "EMEXPTYPE";

        /// <summary>
        /// EMSTYL.
        /// </summary>
        public const string EMSTYL = "EMSTYL";

        /// <summary>
        /// EMOBJ.
        /// </summary>
        public const string EMOBJ = "EMOBJ";

        /// <summary>
        /// EMSUB.
        /// </summary>
        public const string EMSUB = "EMSUB";

        /// <summary>
        /// EMUNALOBJ.
        /// </summary>
        public const string EMUNALOBJ = "EMUNALOBJ";

        /// <summary>
        /// EMUNALSUB.
        /// </summary>
        public const string EMUNALSUB = "EMUNALSUB";
    }

    /// <inheritdoc />
    public override string TableName => "F20106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMEXPTYPE", "EMEXPTYPE", JdeDataType.String, 8, true, true),
        new JdeField("EMSTYL", "EMSTYL", JdeDataType.String, 4, true, true),
        new JdeField("EMOBJ", "EMOBJ", JdeDataType.String, 12),
        new JdeField("EMSUB", "EMSUB", JdeDataType.String, 16),
        new JdeField("EMUNALOBJ", "EMUNALOBJ", JdeDataType.String, 12),
        new JdeField("EMUNALSUB", "EMUNALSUB", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20106_0", "Primary Key on EMEXPTYPE, EMSTYL", new[] { "EMEXPTYPE", "EMSTYL" }, isUnique: true, isPrimaryKey: true)
    };
}
