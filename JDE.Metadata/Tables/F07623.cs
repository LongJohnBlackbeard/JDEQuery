using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07623 - .
/// </summary>
public class F07623 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L3AN8.
        /// </summary>
        public const string L3AN8 = "L3AN8";

        /// <summary>
        /// L3RKID.
        /// </summary>
        public const string L3RKID = "L3RKID";

        /// <summary>
        /// L3LNID.
        /// </summary>
        public const string L3LNID = "L3LNID";

        /// <summary>
        /// L3PRTR.
        /// </summary>
        public const string L3PRTR = "L3PRTR";

        /// <summary>
        /// L3LVST.
        /// </summary>
        public const string L3LVST = "L3LVST";

        /// <summary>
        /// L3LRDT.
        /// </summary>
        public const string L3LRDT = "L3LRDT";

        /// <summary>
        /// L3LTTP.
        /// </summary>
        public const string L3LTTP = "L3LTTP";

        /// <summary>
        /// L3LVBD.
        /// </summary>
        public const string L3LVBD = "L3LVBD";

        /// <summary>
        /// L3LVED.
        /// </summary>
        public const string L3LVED = "L3LVED";

        /// <summary>
        /// L3DW.
        /// </summary>
        public const string L3DW = "L3DW";

        /// <summary>
        /// L3LDUR.
        /// </summary>
        public const string L3LDUR = "L3LDUR";

        /// <summary>
        /// L3LVSP.
        /// </summary>
        public const string L3LVSP = "L3LVSP";

        /// <summary>
        /// L3FACA.
        /// </summary>
        public const string L3FACA = "L3FACA";

        /// <summary>
        /// L3LVTK.
        /// </summary>
        public const string L3LVTK = "L3LVTK";

        /// <summary>
        /// L3LVRM.
        /// </summary>
        public const string L3LVRM = "L3LVRM";

        /// <summary>
        /// L3RQCP.
        /// </summary>
        public const string L3RQCP = "L3RQCP";

        /// <summary>
        /// L3USER.
        /// </summary>
        public const string L3USER = "L3USER";

        /// <summary>
        /// L3PID.
        /// </summary>
        public const string L3PID = "L3PID";

        /// <summary>
        /// L3JOBN.
        /// </summary>
        public const string L3JOBN = "L3JOBN";

        /// <summary>
        /// L3UPMJ.
        /// </summary>
        public const string L3UPMJ = "L3UPMJ";

        /// <summary>
        /// L3UPMT.
        /// </summary>
        public const string L3UPMT = "L3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07623";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L3AN8", "L3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("L3RKID", "L3RKID", JdeDataType.Numeric, null, true, true),
        new JdeField("L3LNID", "L3LNID", JdeDataType.Numeric),
        new JdeField("L3PRTR", "L3PRTR", JdeDataType.Numeric),
        new JdeField("L3LVST", "L3LVST", JdeDataType.String, 2),
        new JdeField("L3LRDT", "L3LRDT", JdeDataType.Numeric),
        new JdeField("L3LTTP", "L3LTTP", JdeDataType.String, 4),
        new JdeField("L3LVBD", "L3LVBD", JdeDataType.Numeric),
        new JdeField("L3LVED", "L3LVED", JdeDataType.Numeric),
        new JdeField("L3DW", "L3DW", JdeDataType.String, 2),
        new JdeField("L3LDUR", "L3LDUR", JdeDataType.Numeric),
        new JdeField("L3LVSP", "L3LVSP", JdeDataType.Numeric),
        new JdeField("L3FACA", "L3FACA", JdeDataType.Numeric),
        new JdeField("L3LVTK", "L3LVTK", JdeDataType.Numeric),
        new JdeField("L3LVRM", "L3LVRM", JdeDataType.Numeric),
        new JdeField("L3RQCP", "L3RQCP", JdeDataType.String, 2),
        new JdeField("L3USER", "L3USER", JdeDataType.String, 20),
        new JdeField("L3PID", "L3PID", JdeDataType.String, 20),
        new JdeField("L3JOBN", "L3JOBN", JdeDataType.String, 20),
        new JdeField("L3UPMJ", "L3UPMJ", JdeDataType.Numeric),
        new JdeField("L3UPMT", "L3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07623_0", "Primary Key on L3AN8, L3RKID", new[] { "L3AN8", "L3RKID" }, isUnique: true, isPrimaryKey: true)
    };
}
