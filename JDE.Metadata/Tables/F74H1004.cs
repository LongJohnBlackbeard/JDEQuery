using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H1004 - .
/// </summary>
public class F74H1004 : JdeTable
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
        /// VD74HVBID.
        /// </summary>
        public const string VD74HVBID = "VD74HVBID";

        /// <summary>
        /// VD74HVDID.
        /// </summary>
        public const string VD74HVDID = "VD74HVDID";

        /// <summary>
        /// VD74HVDST.
        /// </summary>
        public const string VD74HVDST = "VD74HVDST";

        /// <summary>
        /// VDTXA1.
        /// </summary>
        public const string VDTXA1 = "VDTXA1";

        /// <summary>
        /// VDTXR1.
        /// </summary>
        public const string VDTXR1 = "VDTXR1";

        /// <summary>
        /// VDITM.
        /// </summary>
        public const string VDITM = "VDITM";

        /// <summary>
        /// VDATXA.
        /// </summary>
        public const string VDATXA = "VDATXA";

        /// <summary>
        /// VDSTAM.
        /// </summary>
        public const string VDSTAM = "VDSTAM";

        /// <summary>
        /// VDCO.
        /// </summary>
        public const string VDCO = "VDCO";

        /// <summary>
        /// VDJOBN.
        /// </summary>
        public const string VDJOBN = "VDJOBN";

        /// <summary>
        /// VDPID.
        /// </summary>
        public const string VDPID = "VDPID";

        /// <summary>
        /// VDUSER.
        /// </summary>
        public const string VDUSER = "VDUSER";

        /// <summary>
        /// VDUPMJ.
        /// </summary>
        public const string VDUPMJ = "VDUPMJ";

        /// <summary>
        /// VDUPMT.
        /// </summary>
        public const string VDUPMT = "VDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74H1004";

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
        new JdeField("VD74HVBID", "VD74HVBID", JdeDataType.Numeric),
        new JdeField("VD74HVDID", "VD74HVDID", JdeDataType.Numeric),
        new JdeField("VD74HVDST", "VD74HVDST", JdeDataType.String, 6),
        new JdeField("VDTXA1", "VDTXA1", JdeDataType.String, 20),
        new JdeField("VDTXR1", "VDTXR1", JdeDataType.Numeric),
        new JdeField("VDITM", "VDITM", JdeDataType.Numeric),
        new JdeField("VDATXA", "VDATXA", JdeDataType.Numeric),
        new JdeField("VDSTAM", "VDSTAM", JdeDataType.Numeric),
        new JdeField("VDCO", "VDCO", JdeDataType.String, 10),
        new JdeField("VDJOBN", "VDJOBN", JdeDataType.String, 20),
        new JdeField("VDPID", "VDPID", JdeDataType.String, 20),
        new JdeField("VDUSER", "VDUSER", JdeDataType.String, 20),
        new JdeField("VDUPMJ", "VDUPMJ", JdeDataType.Numeric),
        new JdeField("VDUPMT", "VDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H1004_0", "Primary Key on VDKCO, VDDOC, VDDCT, VDSFX, VDSFXE", new[] { "VDKCO", "VDDOC", "VDDCT", "VDSFX", "VDSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H1004_2", "Index on VD74HVBID", new[] { "VD74HVBID" }),
        new JdeIndex("F74H1004_3", "Index on VD74HVDID, VDTXA1", new[] { "VD74HVDID", "VDTXA1" })
    };
}
