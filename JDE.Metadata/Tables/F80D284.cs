using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D284 - .
/// </summary>
public class F80D284 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ORPRDJ.
        /// </summary>
        public const string ORPRDJ = "ORPRDJ";

        /// <summary>
        /// ORMCU.
        /// </summary>
        public const string ORMCU = "ORMCU";

        /// <summary>
        /// ORROC.
        /// </summary>
        public const string ORROC = "ORROC";

        /// <summary>
        /// OROIC.
        /// </summary>
        public const string OROIC = "OROIC";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORMKEY.
        /// </summary>
        public const string ORMKEY = "ORMKEY";

        /// <summary>
        /// ORUTIME.
        /// </summary>
        public const string ORUTIME = "ORUTIME";

        /// <summary>
        /// ORURCD.
        /// </summary>
        public const string ORURCD = "ORURCD";

        /// <summary>
        /// ORURDT.
        /// </summary>
        public const string ORURDT = "ORURDT";

        /// <summary>
        /// ORURAT.
        /// </summary>
        public const string ORURAT = "ORURAT";

        /// <summary>
        /// ORURAB.
        /// </summary>
        public const string ORURAB = "ORURAB";

        /// <summary>
        /// ORURRF.
        /// </summary>
        public const string ORURRF = "ORURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D284";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ORPRDJ", "ORPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ORMCU", "ORMCU", JdeDataType.String, 24, true, true),
        new JdeField("ORROC", "ORROC", JdeDataType.Numeric),
        new JdeField("OROIC", "OROIC", JdeDataType.Numeric),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORMKEY", "ORMKEY", JdeDataType.String, 30),
        new JdeField("ORUTIME", "ORUTIME", JdeDataType.Date),
        new JdeField("ORURCD", "ORURCD", JdeDataType.String, 4),
        new JdeField("ORURDT", "ORURDT", JdeDataType.Numeric),
        new JdeField("ORURAT", "ORURAT", JdeDataType.Numeric),
        new JdeField("ORURAB", "ORURAB", JdeDataType.Numeric),
        new JdeField("ORURRF", "ORURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D284_0", "Primary Key on ORPRDJ, ORMCU", new[] { "ORPRDJ", "ORMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
