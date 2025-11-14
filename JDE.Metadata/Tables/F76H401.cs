using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H401 - .
/// </summary>
public class F76H401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPKCO.
        /// </summary>
        public const string DPKCO = "DPKCO";

        /// <summary>
        /// DPDCT.
        /// </summary>
        public const string DPDCT = "DPDCT";

        /// <summary>
        /// DPDOC.
        /// </summary>
        public const string DPDOC = "DPDOC";

        /// <summary>
        /// DPH76VOID.
        /// </summary>
        public const string DPH76VOID = "DPH76VOID";

        /// <summary>
        /// DPH76LEDT.
        /// </summary>
        public const string DPH76LEDT = "DPH76LEDT";

        /// <summary>
        /// DPH76VPR.
        /// </summary>
        public const string DPH76VPR = "DPH76VPR";

        /// <summary>
        /// DPH76WH.
        /// </summary>
        public const string DPH76WH = "DPH76WH";

        /// <summary>
        /// DPH76WNBR.
        /// </summary>
        public const string DPH76WNBR = "DPH76WNBR";

        /// <summary>
        /// DPH76FUA.
        /// </summary>
        public const string DPH76FUA = "DPH76FUA";

        /// <summary>
        /// DPH76FUC.
        /// </summary>
        public const string DPH76FUC = "DPH76FUC";

        /// <summary>
        /// DPH76FUD.
        /// </summary>
        public const string DPH76FUD = "DPH76FUD";

        /// <summary>
        /// DPH76FUF.
        /// </summary>
        public const string DPH76FUF = "DPH76FUF";

        /// <summary>
        /// DPH76FUR.
        /// </summary>
        public const string DPH76FUR = "DPH76FUR";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPUPMT.
        /// </summary>
        public const string DPUPMT = "DPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPKCO", "DPKCO", JdeDataType.String, 10, true, true),
        new JdeField("DPDCT", "DPDCT", JdeDataType.String, 4, true, true),
        new JdeField("DPDOC", "DPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DPH76VOID", "DPH76VOID", JdeDataType.String, 2, true, true),
        new JdeField("DPH76LEDT", "DPH76LEDT", JdeDataType.String, 6),
        new JdeField("DPH76VPR", "DPH76VPR", JdeDataType.String, 2),
        new JdeField("DPH76WH", "DPH76WH", JdeDataType.String, 2),
        new JdeField("DPH76WNBR", "DPH76WNBR", JdeDataType.Numeric),
        new JdeField("DPH76FUA", "DPH76FUA", JdeDataType.Numeric),
        new JdeField("DPH76FUC", "DPH76FUC", JdeDataType.String, 20),
        new JdeField("DPH76FUD", "DPH76FUD", JdeDataType.Numeric),
        new JdeField("DPH76FUF", "DPH76FUF", JdeDataType.String, 2),
        new JdeField("DPH76FUR", "DPH76FUR", JdeDataType.String, 30),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPUPMT", "DPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H401_0", "Primary Key on DPKCO, DPDCT, DPDOC, DPH76VOID", new[] { "DPKCO", "DPDCT", "DPDOC", "DPH76VOID" }, isUnique: true, isPrimaryKey: true)
    };
}
