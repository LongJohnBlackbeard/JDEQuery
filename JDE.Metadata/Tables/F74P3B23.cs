using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P3B23 - .
/// </summary>
public class F74P3B23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDUKID.
        /// </summary>
        public const string HDUKID = "HDUKID";

        /// <summary>
        /// HDRC5.
        /// </summary>
        public const string HDRC5 = "HDRC5";

        /// <summary>
        /// HDP74DBEG.
        /// </summary>
        public const string HDP74DBEG = "HDP74DBEG";

        /// <summary>
        /// HDP74DFAC.
        /// </summary>
        public const string HDP74DFAC = "HDP74DFAC";

        /// <summary>
        /// HDP74PN.
        /// </summary>
        public const string HDP74PN = "HDP74PN";

        /// <summary>
        /// HDP74BPE.
        /// </summary>
        public const string HDP74BPE = "HDP74BPE";

        /// <summary>
        /// HDP74EPE.
        /// </summary>
        public const string HDP74EPE = "HDP74EPE";

        /// <summary>
        /// HDP74NRUL.
        /// </summary>
        public const string HDP74NRUL = "HDP74NRUL";

        /// <summary>
        /// HDP74FFC.
        /// </summary>
        public const string HDP74FFC = "HDP74FFC";

        /// <summary>
        /// HDP74EFC.
        /// </summary>
        public const string HDP74EFC = "HDP74EFC";

        /// <summary>
        /// HDDAYP.
        /// </summary>
        public const string HDDAYP = "HDDAYP";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDJOBN.
        /// </summary>
        public const string HDJOBN = "HDJOBN";

        /// <summary>
        /// HDPID.
        /// </summary>
        public const string HDPID = "HDPID";

        /// <summary>
        /// HDUPMJ.
        /// </summary>
        public const string HDUPMJ = "HDUPMJ";

        /// <summary>
        /// HDUPMT.
        /// </summary>
        public const string HDUPMT = "HDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P3B23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDUKID", "HDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDRC5", "HDRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("HDP74DBEG", "HDP74DBEG", JdeDataType.String, 2),
        new JdeField("HDP74DFAC", "HDP74DFAC", JdeDataType.String, 2),
        new JdeField("HDP74PN", "HDP74PN", JdeDataType.Numeric),
        new JdeField("HDP74BPE", "HDP74BPE", JdeDataType.Numeric),
        new JdeField("HDP74EPE", "HDP74EPE", JdeDataType.Numeric),
        new JdeField("HDP74NRUL", "HDP74NRUL", JdeDataType.Numeric),
        new JdeField("HDP74FFC", "HDP74FFC", JdeDataType.Numeric),
        new JdeField("HDP74EFC", "HDP74EFC", JdeDataType.Numeric),
        new JdeField("HDDAYP", "HDDAYP", JdeDataType.Numeric),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDJOBN", "HDJOBN", JdeDataType.String, 20),
        new JdeField("HDPID", "HDPID", JdeDataType.String, 20),
        new JdeField("HDUPMJ", "HDUPMJ", JdeDataType.Numeric),
        new JdeField("HDUPMT", "HDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P3B23_0", "Primary Key on HDUKID, HDRC5", new[] { "HDUKID", "HDRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
