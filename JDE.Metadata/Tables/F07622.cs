using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07622 - .
/// </summary>
public class F07622 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L2AN8.
        /// </summary>
        public const string L2AN8 = "L2AN8";

        /// <summary>
        /// L2RKID.
        /// </summary>
        public const string L2RKID = "L2RKID";

        /// <summary>
        /// L2LNID.
        /// </summary>
        public const string L2LNID = "L2LNID";

        /// <summary>
        /// L2MCRD.
        /// </summary>
        public const string L2MCRD = "L2MCRD";

        /// <summary>
        /// L2NMDR.
        /// </summary>
        public const string L2NMDR = "L2NMDR";

        /// <summary>
        /// L2MEDC.
        /// </summary>
        public const string L2MEDC = "L2MEDC";

        /// <summary>
        /// L2POWF.
        /// </summary>
        public const string L2POWF = "L2POWF";

        /// <summary>
        /// L2OPFN.
        /// </summary>
        public const string L2OPFN = "L2OPFN";

        /// <summary>
        /// L2OPTX.
        /// </summary>
        public const string L2OPTX = "L2OPTX";

        /// <summary>
        /// L2OPAS.
        /// </summary>
        public const string L2OPAS = "L2OPAS";

        /// <summary>
        /// L2USER.
        /// </summary>
        public const string L2USER = "L2USER";

        /// <summary>
        /// L2PID.
        /// </summary>
        public const string L2PID = "L2PID";

        /// <summary>
        /// L2JOBN.
        /// </summary>
        public const string L2JOBN = "L2JOBN";

        /// <summary>
        /// L2UPMJ.
        /// </summary>
        public const string L2UPMJ = "L2UPMJ";

        /// <summary>
        /// L2UPMT.
        /// </summary>
        public const string L2UPMT = "L2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F07622";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L2AN8", "L2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("L2RKID", "L2RKID", JdeDataType.Numeric, null, true, true),
        new JdeField("L2LNID", "L2LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("L2MCRD", "L2MCRD", JdeDataType.Numeric),
        new JdeField("L2NMDR", "L2NMDR", JdeDataType.String, 80),
        new JdeField("L2MEDC", "L2MEDC", JdeDataType.String, 80),
        new JdeField("L2POWF", "L2POWF", JdeDataType.String, 2),
        new JdeField("L2OPFN", "L2OPFN", JdeDataType.String, 2),
        new JdeField("L2OPTX", "L2OPTX", JdeDataType.String, 2),
        new JdeField("L2OPAS", "L2OPAS", JdeDataType.String, 2),
        new JdeField("L2USER", "L2USER", JdeDataType.String, 20),
        new JdeField("L2PID", "L2PID", JdeDataType.String, 20),
        new JdeField("L2JOBN", "L2JOBN", JdeDataType.String, 20),
        new JdeField("L2UPMJ", "L2UPMJ", JdeDataType.Numeric),
        new JdeField("L2UPMT", "L2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07622_0", "Primary Key on L2AN8, L2RKID, L2LNID", new[] { "L2AN8", "L2RKID", "L2LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
