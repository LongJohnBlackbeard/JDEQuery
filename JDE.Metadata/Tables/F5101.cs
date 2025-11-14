using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5101 - .
/// </summary>
public class F5101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHMCU.
        /// </summary>
        public const string FHMCU = "FHMCU";

        /// <summary>
        /// FHFORVER.
        /// </summary>
        public const string FHFORVER = "FHFORVER";

        /// <summary>
        /// FHBLDDATE.
        /// </summary>
        public const string FHBLDDATE = "FHBLDDATE";

        /// <summary>
        /// FHFORDESC.
        /// </summary>
        public const string FHFORDESC = "FHFORDESC";

        /// <summary>
        /// FHLCKCODE.
        /// </summary>
        public const string FHLCKCODE = "FHLCKCODE";

        /// <summary>
        /// FHD2J.
        /// </summary>
        public const string FHD2J = "FHD2J";

        /// <summary>
        /// FHD3J.
        /// </summary>
        public const string FHD3J = "FHD3J";

        /// <summary>
        /// FHSUMMARYDET.
        /// </summary>
        public const string FHSUMMARYDET = "FHSUMMARYDET";

        /// <summary>
        /// FHLDA.
        /// </summary>
        public const string FHLDA = "FHLDA";

        /// <summary>
        /// FHCPYFRMVER.
        /// </summary>
        public const string FHCPYFRMVER = "FHCPYFRMVER";

        /// <summary>
        /// FHFST.
        /// </summary>
        public const string FHFST = "FHFST";

        /// <summary>
        /// FHUPMT.
        /// </summary>
        public const string FHUPMT = "FHUPMT";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F5101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHMCU", "FHMCU", JdeDataType.String, 24, true, true),
        new JdeField("FHFORVER", "FHFORVER", JdeDataType.String, 20, true, true),
        new JdeField("FHBLDDATE", "FHBLDDATE", JdeDataType.Numeric),
        new JdeField("FHFORDESC", "FHFORDESC", JdeDataType.String, 60),
        new JdeField("FHLCKCODE", "FHLCKCODE", JdeDataType.String, 2),
        new JdeField("FHD2J", "FHD2J", JdeDataType.Numeric),
        new JdeField("FHD3J", "FHD3J", JdeDataType.Numeric),
        new JdeField("FHSUMMARYDET", "FHSUMMARYDET", JdeDataType.String, 2),
        new JdeField("FHLDA", "FHLDA", JdeDataType.String, 2),
        new JdeField("FHCPYFRMVER", "FHCPYFRMVER", JdeDataType.String, 20),
        new JdeField("FHFST", "FHFST", JdeDataType.String, 2),
        new JdeField("FHUPMT", "FHUPMT", JdeDataType.Numeric),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5101_0", "Primary Key on FHMCU, FHFORVER", new[] { "FHMCU", "FHFORVER" }, isUnique: true, isPrimaryKey: true)
    };
}
