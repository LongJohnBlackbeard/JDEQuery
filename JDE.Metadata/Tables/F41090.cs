using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41090 - .
/// </summary>
public class F41090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T1DSDB.
        /// </summary>
        public const string T1DSDB = "T1DSDB";

        /// <summary>
        /// T1TYDB.
        /// </summary>
        public const string T1TYDB = "T1TYDB";

        /// <summary>
        /// T1DSPM.
        /// </summary>
        public const string T1DSPM = "T1DSPM";

        /// <summary>
        /// T1DL01.
        /// </summary>
        public const string T1DL01 = "T1DL01";

        /// <summary>
        /// T1SY.
        /// </summary>
        public const string T1SY = "T1SY";

        /// <summary>
        /// T1RT.
        /// </summary>
        public const string T1RT = "T1RT";

        /// <summary>
        /// T1GDC1.
        /// </summary>
        public const string T1GDC1 = "T1GDC1";

        /// <summary>
        /// T1GDC2.
        /// </summary>
        public const string T1GDC2 = "T1GDC2";

        /// <summary>
        /// T1GDC3.
        /// </summary>
        public const string T1GDC3 = "T1GDC3";

        /// <summary>
        /// T1GDC4.
        /// </summary>
        public const string T1GDC4 = "T1GDC4";

        /// <summary>
        /// T1FILE.
        /// </summary>
        public const string T1FILE = "T1FILE";

        /// <summary>
        /// T1CLSI.
        /// </summary>
        public const string T1CLSI = "T1CLSI";

        /// <summary>
        /// T1PGM.
        /// </summary>
        public const string T1PGM = "T1PGM";

        /// <summary>
        /// T1VERS.
        /// </summary>
        public const string T1VERS = "T1VERS";

        /// <summary>
        /// T1DSS5.
        /// </summary>
        public const string T1DSS5 = "T1DSS5";

        /// <summary>
        /// T1PGMG.
        /// </summary>
        public const string T1PGMG = "T1PGMG";

        /// <summary>
        /// T1USER.
        /// </summary>
        public const string T1USER = "T1USER";

        /// <summary>
        /// T1PID.
        /// </summary>
        public const string T1PID = "T1PID";

        /// <summary>
        /// T1JOBN.
        /// </summary>
        public const string T1JOBN = "T1JOBN";

        /// <summary>
        /// T1UPMJ.
        /// </summary>
        public const string T1UPMJ = "T1UPMJ";

        /// <summary>
        /// T1TDAY.
        /// </summary>
        public const string T1TDAY = "T1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T1DSDB", "T1DSDB", JdeDataType.String, 2, true, true),
        new JdeField("T1TYDB", "T1TYDB", JdeDataType.String, 4, true, true),
        new JdeField("T1DSPM", "T1DSPM", JdeDataType.String, 2),
        new JdeField("T1DL01", "T1DL01", JdeDataType.String, 60),
        new JdeField("T1SY", "T1SY", JdeDataType.String, 8),
        new JdeField("T1RT", "T1RT", JdeDataType.String, 4),
        new JdeField("T1GDC1", "T1GDC1", JdeDataType.String, 20),
        new JdeField("T1GDC2", "T1GDC2", JdeDataType.String, 20),
        new JdeField("T1GDC3", "T1GDC3", JdeDataType.String, 60),
        new JdeField("T1GDC4", "T1GDC4", JdeDataType.String, 60),
        new JdeField("T1FILE", "T1FILE", JdeDataType.String, 20),
        new JdeField("T1CLSI", "T1CLSI", JdeDataType.String, 8),
        new JdeField("T1PGM", "T1PGM", JdeDataType.String, 20),
        new JdeField("T1VERS", "T1VERS", JdeDataType.String, 20),
        new JdeField("T1DSS5", "T1DSS5", JdeDataType.Numeric),
        new JdeField("T1PGMG", "T1PGMG", JdeDataType.String, 20),
        new JdeField("T1USER", "T1USER", JdeDataType.String, 20),
        new JdeField("T1PID", "T1PID", JdeDataType.String, 20),
        new JdeField("T1JOBN", "T1JOBN", JdeDataType.String, 20),
        new JdeField("T1UPMJ", "T1UPMJ", JdeDataType.Numeric),
        new JdeField("T1TDAY", "T1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41090_0", "Primary Key on T1DSDB, T1TYDB", new[] { "T1DSDB", "T1TYDB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41090_2", "Index on T1CLSI, T1TYDB", new[] { "T1CLSI", "T1TYDB" })
    };
}
