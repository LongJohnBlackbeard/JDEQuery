using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R400 - .
/// </summary>
public class F74R400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VRTXA1.
        /// </summary>
        public const string VRTXA1 = "VRTXA1";

        /// <summary>
        /// VRDCT.
        /// </summary>
        public const string VRDCT = "VRDCT";

        /// <summary>
        /// VRR74RLTP.
        /// </summary>
        public const string VRR74RLTP = "VRR74RLTP";

        /// <summary>
        /// VRUSER.
        /// </summary>
        public const string VRUSER = "VRUSER";

        /// <summary>
        /// VRPID.
        /// </summary>
        public const string VRPID = "VRPID";

        /// <summary>
        /// VRUPMJ.
        /// </summary>
        public const string VRUPMJ = "VRUPMJ";

        /// <summary>
        /// VRUPMT.
        /// </summary>
        public const string VRUPMT = "VRUPMT";

        /// <summary>
        /// VRJOBN.
        /// </summary>
        public const string VRJOBN = "VRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VRTXA1", "VRTXA1", JdeDataType.String, 20, true, true),
        new JdeField("VRDCT", "VRDCT", JdeDataType.String, 4, true, true),
        new JdeField("VRR74RLTP", "VRR74RLTP", JdeDataType.String, 2),
        new JdeField("VRUSER", "VRUSER", JdeDataType.String, 20),
        new JdeField("VRPID", "VRPID", JdeDataType.String, 20),
        new JdeField("VRUPMJ", "VRUPMJ", JdeDataType.Numeric),
        new JdeField("VRUPMT", "VRUPMT", JdeDataType.Numeric),
        new JdeField("VRJOBN", "VRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R400_0", "Primary Key on VRTXA1, VRDCT", new[] { "VRTXA1", "VRDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
