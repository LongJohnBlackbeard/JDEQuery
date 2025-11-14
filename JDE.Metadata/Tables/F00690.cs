using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00690 - .
/// </summary>
public class F00690 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M1TYDA.
        /// </summary>
        public const string M1TYDA = "M1TYDA";

        /// <summary>
        /// M1DSPM.
        /// </summary>
        public const string M1DSPM = "M1DSPM";

        /// <summary>
        /// M1DL01.
        /// </summary>
        public const string M1DL01 = "M1DL01";

        /// <summary>
        /// M1SY.
        /// </summary>
        public const string M1SY = "M1SY";

        /// <summary>
        /// M1RT.
        /// </summary>
        public const string M1RT = "M1RT";

        /// <summary>
        /// M1GDC1.
        /// </summary>
        public const string M1GDC1 = "M1GDC1";

        /// <summary>
        /// M1GDC2.
        /// </summary>
        public const string M1GDC2 = "M1GDC2";

        /// <summary>
        /// M1GDC3.
        /// </summary>
        public const string M1GDC3 = "M1GDC3";

        /// <summary>
        /// M1GDC4.
        /// </summary>
        public const string M1GDC4 = "M1GDC4";
    }

    /// <inheritdoc />
    public override string TableName => "F00690";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M1TYDA", "M1TYDA", JdeDataType.String, 4, true, true),
        new JdeField("M1DSPM", "M1DSPM", JdeDataType.String, 2),
        new JdeField("M1DL01", "M1DL01", JdeDataType.String, 60),
        new JdeField("M1SY", "M1SY", JdeDataType.String, 8),
        new JdeField("M1RT", "M1RT", JdeDataType.String, 4),
        new JdeField("M1GDC1", "M1GDC1", JdeDataType.String, 20),
        new JdeField("M1GDC2", "M1GDC2", JdeDataType.String, 20),
        new JdeField("M1GDC3", "M1GDC3", JdeDataType.String, 60),
        new JdeField("M1GDC4", "M1GDC4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00690_0", "Primary Key on M1TYDA", new[] { "M1TYDA" }, isUnique: true, isPrimaryKey: true)
    };
}
