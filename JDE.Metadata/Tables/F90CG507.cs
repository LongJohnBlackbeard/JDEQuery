using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CG507 - .
/// </summary>
public class F90CG507 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCDOCO.
        /// </summary>
        public const string CCDOCO = "CCDOCO";

        /// <summary>
        /// CCSTAW.
        /// </summary>
        public const string CCSTAW = "CCSTAW";

        /// <summary>
        /// CCWFTYPE.
        /// </summary>
        public const string CCWFTYPE = "CCWFTYPE";

        /// <summary>
        /// CCWFLINEID.
        /// </summary>
        public const string CCWFLINEID = "CCWFLINEID";

        /// <summary>
        /// CCENTDBY.
        /// </summary>
        public const string CCENTDBY = "CCENTDBY";

        /// <summary>
        /// CCEDATE.
        /// </summary>
        public const string CCEDATE = "CCEDATE";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CG507";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCDOCO", "CCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CCSTAW", "CCSTAW", JdeDataType.String, 2, true, true),
        new JdeField("CCWFTYPE", "CCWFTYPE", JdeDataType.String, 4, true, true),
        new JdeField("CCWFLINEID", "CCWFLINEID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCENTDBY", "CCENTDBY", JdeDataType.Numeric),
        new JdeField("CCEDATE", "CCEDATE", JdeDataType.Date),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CG507_0", "Primary Key on CCDOCO, CCWFTYPE, CCWFLINEID, CCSTAW", new[] { "CCDOCO", "CCWFTYPE", "CCWFLINEID", "CCSTAW" }, isUnique: true, isPrimaryKey: true)
    };
}
