using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H1007 - .
/// </summary>
public class F74H1007 : JdeTable
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
        /// TSITM.
        /// </summary>
        public const string TSITM = "TSITM";

        /// <summary>
        /// TS74HVFC.
        /// </summary>
        public const string TS74HVFC = "TS74HVFC";

        /// <summary>
        /// TSH74PEUC.
        /// </summary>
        public const string TSH74PEUC = "TSH74PEUC";

        /// <summary>
        /// TS74HVFV.
        /// </summary>
        public const string TS74HVFV = "TS74HVFV";

        /// <summary>
        /// TS74HTSC.
        /// </summary>
        public const string TS74HTSC = "TS74HTSC";

        /// <summary>
        /// TSH74VCC.
        /// </summary>
        public const string TSH74VCC = "TSH74VCC";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

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
    public override string TableName => "F74H1007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSTXA1", "TSTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TSITM", "TSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TS74HVFC", "TS74HVFC", JdeDataType.String, 20),
        new JdeField("TSH74PEUC", "TSH74PEUC", JdeDataType.String, 2),
        new JdeField("TS74HVFV", "TS74HVFV", JdeDataType.String, 20),
        new JdeField("TS74HTSC", "TS74HTSC", JdeDataType.String, 20),
        new JdeField("TSH74VCC", "TSH74VCC", JdeDataType.String, 2),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H1007_0", "Primary Key on TSTXA1, TSITM", new[] { "TSTXA1", "TSITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H1007_1", "Unique Index on TSTXA1, TSITM, TS74HVFC, TS74HVFV, TSH74PEUC", new[] { "TSTXA1", "TSITM", "TS74HVFC", "TS74HVFV", "TSH74PEUC" }, isUnique: true),
        new JdeIndex("F74H1007_2", "Index on TS74HTSC", new[] { "TS74HTSC" }),
        new JdeIndex("F74H1007_3", "Index on TSTXA1, TSITM, TSH74VCC, TS74HVFC", new[] { "TSTXA1", "TSITM", "TSH74VCC", "TS74HVFC" })
    };
}
