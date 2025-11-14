using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P030 - .
/// </summary>
public class F76P030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSTXA1.
        /// </summary>
        public const string TSTXA1 = "TSTXA1";

        /// <summary>
        /// TSP76TCC.
        /// </summary>
        public const string TSP76TCC = "TSP76TCC";

        /// <summary>
        /// TSP76NTCC.
        /// </summary>
        public const string TSP76NTCC = "TSP76NTCC";

        /// <summary>
        /// TSP76TVC.
        /// </summary>
        public const string TSP76TVC = "TSP76TVC";

        /// <summary>
        /// TSP76NTVC.
        /// </summary>
        public const string TSP76NTVC = "TSP76NTVC";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSTXA1", "TSTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TSP76TCC", "TSP76TCC", JdeDataType.Numeric),
        new JdeField("TSP76NTCC", "TSP76NTCC", JdeDataType.Numeric),
        new JdeField("TSP76TVC", "TSP76TVC", JdeDataType.Numeric),
        new JdeField("TSP76NTVC", "TSP76NTVC", JdeDataType.Numeric),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P030_0", "Primary Key on TSTXA1", new[] { "TSTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
