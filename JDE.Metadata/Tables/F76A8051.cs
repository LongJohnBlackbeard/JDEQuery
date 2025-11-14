using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8051 - .
/// </summary>
public class F76A8051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PECO.
        /// </summary>
        public const string PECO = "PECO";

        /// <summary>
        /// PEEFR1.
        /// </summary>
        public const string PEEFR1 = "PEEFR1";

        /// <summary>
        /// PEFLG1.
        /// </summary>
        public const string PEFLG1 = "PEFLG1";

        /// <summary>
        /// PEGLIE.
        /// </summary>
        public const string PEGLIE = "PEGLIE";

        /// <summary>
        /// PEAPTT.
        /// </summary>
        public const string PEAPTT = "PEAPTT";

        /// <summary>
        /// PEAC01.
        /// </summary>
        public const string PEAC01 = "PEAC01";

        /// <summary>
        /// PEAC02.
        /// </summary>
        public const string PEAC02 = "PEAC02";

        /// <summary>
        /// PEAC03.
        /// </summary>
        public const string PEAC03 = "PEAC03";

        /// <summary>
        /// PEAC04.
        /// </summary>
        public const string PEAC04 = "PEAC04";

        /// <summary>
        /// PEAC05.
        /// </summary>
        public const string PEAC05 = "PEAC05";

        /// <summary>
        /// PEURCD.
        /// </summary>
        public const string PEURCD = "PEURCD";

        /// <summary>
        /// PEURDT.
        /// </summary>
        public const string PEURDT = "PEURDT";

        /// <summary>
        /// PEURAT.
        /// </summary>
        public const string PEURAT = "PEURAT";

        /// <summary>
        /// PEURAB.
        /// </summary>
        public const string PEURAB = "PEURAB";

        /// <summary>
        /// PEURRF.
        /// </summary>
        public const string PEURRF = "PEURRF";

        /// <summary>
        /// PETORG.
        /// </summary>
        public const string PETORG = "PETORG";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PETDAY.
        /// </summary>
        public const string PETDAY = "PETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PECO", "PECO", JdeDataType.String, 10, true, true),
        new JdeField("PEEFR1", "PEEFR1", JdeDataType.String, 2),
        new JdeField("PEFLG1", "PEFLG1", JdeDataType.String, 2),
        new JdeField("PEGLIE", "PEGLIE", JdeDataType.String, 2),
        new JdeField("PEAPTT", "PEAPTT", JdeDataType.String, 2),
        new JdeField("PEAC01", "PEAC01", JdeDataType.String, 6),
        new JdeField("PEAC02", "PEAC02", JdeDataType.String, 6),
        new JdeField("PEAC03", "PEAC03", JdeDataType.String, 6),
        new JdeField("PEAC04", "PEAC04", JdeDataType.String, 6),
        new JdeField("PEAC05", "PEAC05", JdeDataType.String, 6),
        new JdeField("PEURCD", "PEURCD", JdeDataType.String, 4),
        new JdeField("PEURDT", "PEURDT", JdeDataType.Numeric),
        new JdeField("PEURAT", "PEURAT", JdeDataType.Numeric),
        new JdeField("PEURAB", "PEURAB", JdeDataType.Numeric),
        new JdeField("PEURRF", "PEURRF", JdeDataType.String, 30),
        new JdeField("PETORG", "PETORG", JdeDataType.String, 20),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PETDAY", "PETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8051_0", "Primary Key on PECO", new[] { "PECO" }, isUnique: true, isPrimaryKey: true)
    };
}
