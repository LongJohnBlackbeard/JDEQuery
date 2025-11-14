using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4012 - .
/// </summary>
public class F76B4012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VPKCO.
        /// </summary>
        public const string VPKCO = "VPKCO";

        /// <summary>
        /// VPDCT.
        /// </summary>
        public const string VPDCT = "VPDCT";

        /// <summary>
        /// VPDOC.
        /// </summary>
        public const string VPDOC = "VPDOC";

        /// <summary>
        /// VPB76ISS.
        /// </summary>
        public const string VPB76ISS = "VPB76ISS";

        /// <summary>
        /// VPB76INSS.
        /// </summary>
        public const string VPB76INSS = "VPB76INSS";

        /// <summary>
        /// VPB76VMYN.
        /// </summary>
        public const string VPB76VMYN = "VPB76VMYN";

        /// <summary>
        /// VPB76FUN.
        /// </summary>
        public const string VPB76FUN = "VPB76FUN";

        /// <summary>
        /// VPB76MXMN.
        /// </summary>
        public const string VPB76MXMN = "VPB76MXMN";

        /// <summary>
        /// VPB76MISS.
        /// </summary>
        public const string VPB76MISS = "VPB76MISS";

        /// <summary>
        /// VPB76MFUN.
        /// </summary>
        public const string VPB76MFUN = "VPB76MFUN";

        /// <summary>
        /// VPUSER.
        /// </summary>
        public const string VPUSER = "VPUSER";

        /// <summary>
        /// VPPID.
        /// </summary>
        public const string VPPID = "VPPID";

        /// <summary>
        /// VPJOBN.
        /// </summary>
        public const string VPJOBN = "VPJOBN";

        /// <summary>
        /// VPUPMJ.
        /// </summary>
        public const string VPUPMJ = "VPUPMJ";

        /// <summary>
        /// VPUPMT.
        /// </summary>
        public const string VPUPMT = "VPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VPKCO", "VPKCO", JdeDataType.String, 10, true, true),
        new JdeField("VPDCT", "VPDCT", JdeDataType.String, 4, true, true),
        new JdeField("VPDOC", "VPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VPB76ISS", "VPB76ISS", JdeDataType.String, 2),
        new JdeField("VPB76INSS", "VPB76INSS", JdeDataType.String, 2),
        new JdeField("VPB76VMYN", "VPB76VMYN", JdeDataType.String, 2),
        new JdeField("VPB76FUN", "VPB76FUN", JdeDataType.String, 2),
        new JdeField("VPB76MXMN", "VPB76MXMN", JdeDataType.Numeric),
        new JdeField("VPB76MISS", "VPB76MISS", JdeDataType.String, 2),
        new JdeField("VPB76MFUN", "VPB76MFUN", JdeDataType.String, 2),
        new JdeField("VPUSER", "VPUSER", JdeDataType.String, 20),
        new JdeField("VPPID", "VPPID", JdeDataType.String, 20),
        new JdeField("VPJOBN", "VPJOBN", JdeDataType.String, 20),
        new JdeField("VPUPMJ", "VPUPMJ", JdeDataType.Numeric),
        new JdeField("VPUPMT", "VPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4012_0", "Primary Key on VPKCO, VPDCT, VPDOC", new[] { "VPKCO", "VPDCT", "VPDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
