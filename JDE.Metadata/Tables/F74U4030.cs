using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4030 - .
/// </summary>
public class F74U4030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VDKCO.
        /// </summary>
        public const string VDKCO = "VDKCO";

        /// <summary>
        /// VDDOC.
        /// </summary>
        public const string VDDOC = "VDDOC";

        /// <summary>
        /// VDDCT.
        /// </summary>
        public const string VDDCT = "VDDCT";

        /// <summary>
        /// VDSFX.
        /// </summary>
        public const string VDSFX = "VDSFX";

        /// <summary>
        /// VDSFXE.
        /// </summary>
        public const string VDSFXE = "VDSFXE";

        /// <summary>
        /// VDU74LAN8.
        /// </summary>
        public const string VDU74LAN8 = "VDU74LAN8";

        /// <summary>
        /// VDU74SCVN.
        /// </summary>
        public const string VDU74SCVN = "VDU74SCVN";

        /// <summary>
        /// VDU74SCMF.
        /// </summary>
        public const string VDU74SCMF = "VDU74SCMF";

        /// <summary>
        /// VDU74SCDV.
        /// </summary>
        public const string VDU74SCDV = "VDU74SCDV";

        /// <summary>
        /// VDPCWH.
        /// </summary>
        public const string VDPCWH = "VDPCWH";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDUPMT.
        /// </summary>
        public const string VDUPMT = "VDUPMT";

        /// <summary>
        /// VDJOBN.
        /// </summary>
        public const string VDJOBN = "VDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VDKCO", "VDKCO", JdeDataType.String, 10, true, true),
        new JdeField("VDDOC", "VDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VDDCT", "VDDCT", JdeDataType.String, 4, true, true),
        new JdeField("VDSFX", "VDSFX", JdeDataType.String, 6, true, true),
        new JdeField("VDSFXE", "VDSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("VDU74LAN8", "VDU74LAN8", JdeDataType.Numeric),
        new JdeField("VDU74SCVN", "VDU74SCVN", JdeDataType.String, 26),
        new JdeField("VDU74SCMF", "VDU74SCMF", JdeDataType.String, 2),
        new JdeField("VDU74SCDV", "VDU74SCDV", JdeDataType.Numeric),
        new JdeField("VDPCWH", "VDPCWH", JdeDataType.Numeric),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDUPMT", "VDUPMT", JdeDataType.Numeric),
        new JdeField("VDJOBN", "VDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4030_0", "Primary Key on VDKCO, VDDOC, VDDCT, VDSFX, VDSFXE", new[] { "VDKCO", "VDDOC", "VDDCT", "VDSFX", "VDSFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
