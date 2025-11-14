using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01090 - .
/// </summary>
public class F01090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1TYDT.
        /// </summary>
        public const string A1TYDT = "A1TYDT";

        /// <summary>
        /// A1AT1.
        /// </summary>
        public const string A1AT1 = "A1AT1";

        /// <summary>
        /// A1DSPM.
        /// </summary>
        public const string A1DSPM = "A1DSPM";

        /// <summary>
        /// A1DL01.
        /// </summary>
        public const string A1DL01 = "A1DL01";

        /// <summary>
        /// A1SY.
        /// </summary>
        public const string A1SY = "A1SY";

        /// <summary>
        /// A1RT.
        /// </summary>
        public const string A1RT = "A1RT";

        /// <summary>
        /// A1GDC1.
        /// </summary>
        public const string A1GDC1 = "A1GDC1";

        /// <summary>
        /// A1GDC2.
        /// </summary>
        public const string A1GDC2 = "A1GDC2";

        /// <summary>
        /// A1GDC3.
        /// </summary>
        public const string A1GDC3 = "A1GDC3";

        /// <summary>
        /// A1GDC4.
        /// </summary>
        public const string A1GDC4 = "A1GDC4";

        /// <summary>
        /// A1FILE.
        /// </summary>
        public const string A1FILE = "A1FILE";

        /// <summary>
        /// A1CLS.
        /// </summary>
        public const string A1CLS = "A1CLS";

        /// <summary>
        /// A1PGM.
        /// </summary>
        public const string A1PGM = "A1PGM";

        /// <summary>
        /// A1VERS.
        /// </summary>
        public const string A1VERS = "A1VERS";

        /// <summary>
        /// A1DSS5.
        /// </summary>
        public const string A1DSS5 = "A1DSS5";

        /// <summary>
        /// A1PGMG.
        /// </summary>
        public const string A1PGMG = "A1PGMG";
    }

    /// <inheritdoc />
    public override string TableName => "F01090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1TYDT", "A1TYDT", JdeDataType.String, 4, true, true),
        new JdeField("A1AT1", "A1AT1", JdeDataType.String, 6, true, true),
        new JdeField("A1DSPM", "A1DSPM", JdeDataType.String, 2),
        new JdeField("A1DL01", "A1DL01", JdeDataType.String, 60),
        new JdeField("A1SY", "A1SY", JdeDataType.String, 8),
        new JdeField("A1RT", "A1RT", JdeDataType.String, 4),
        new JdeField("A1GDC1", "A1GDC1", JdeDataType.String, 20),
        new JdeField("A1GDC2", "A1GDC2", JdeDataType.String, 20),
        new JdeField("A1GDC3", "A1GDC3", JdeDataType.String, 60),
        new JdeField("A1GDC4", "A1GDC4", JdeDataType.String, 60),
        new JdeField("A1FILE", "A1FILE", JdeDataType.String, 20),
        new JdeField("A1CLS", "A1CLS", JdeDataType.String, 8),
        new JdeField("A1PGM", "A1PGM", JdeDataType.String, 20),
        new JdeField("A1VERS", "A1VERS", JdeDataType.String, 20),
        new JdeField("A1DSS5", "A1DSS5", JdeDataType.Numeric),
        new JdeField("A1PGMG", "A1PGMG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01090_0", "Primary Key on A1TYDT, A1AT1", new[] { "A1TYDT", "A1AT1" }, isUnique: true, isPrimaryKey: true)
    };
}
