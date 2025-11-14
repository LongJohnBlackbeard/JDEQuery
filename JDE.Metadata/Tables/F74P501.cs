using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P501 - .
/// </summary>
public class F74P501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VRP74JPKID.
        /// </summary>
        public const string VRP74JPKID = "VRP74JPKID";

        /// <summary>
        /// VRP74JPKE.
        /// </summary>
        public const string VRP74JPKE = "VRP74JPKE";

        /// <summary>
        /// VRP74STR.
        /// </summary>
        public const string VRP74STR = "VRP74STR";

        /// <summary>
        /// VRDATF01.
        /// </summary>
        public const string VRDATF01 = "VRDATF01";

        /// <summary>
        /// VRDEPFUT2.
        /// </summary>
        public const string VRDEPFUT2 = "VRDEPFUT2";

        /// <summary>
        /// VRACTFU1.
        /// </summary>
        public const string VRACTFU1 = "VRACTFU1";

        /// <summary>
        /// VRFLAG.
        /// </summary>
        public const string VRFLAG = "VRFLAG";

        /// <summary>
        /// VRUSER.
        /// </summary>
        public const string VRUSER = "VRUSER";

        /// <summary>
        /// VRPID.
        /// </summary>
        public const string VRPID = "VRPID";

        /// <summary>
        /// VRJOBN.
        /// </summary>
        public const string VRJOBN = "VRJOBN";

        /// <summary>
        /// VRUPMJ.
        /// </summary>
        public const string VRUPMJ = "VRUPMJ";

        /// <summary>
        /// VRUPMT.
        /// </summary>
        public const string VRUPMT = "VRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VRP74JPKID", "VRP74JPKID", JdeDataType.Numeric, null, true, true),
        new JdeField("VRP74JPKE", "VRP74JPKE", JdeDataType.String, 60),
        new JdeField("VRP74STR", "VRP74STR", JdeDataType.String, 60),
        new JdeField("VRDATF01", "VRDATF01", JdeDataType.Numeric),
        new JdeField("VRDEPFUT2", "VRDEPFUT2", JdeDataType.String, 60),
        new JdeField("VRACTFU1", "VRACTFU1", JdeDataType.String, 2),
        new JdeField("VRFLAG", "VRFLAG", JdeDataType.String, 2),
        new JdeField("VRUSER", "VRUSER", JdeDataType.String, 20),
        new JdeField("VRPID", "VRPID", JdeDataType.String, 20),
        new JdeField("VRJOBN", "VRJOBN", JdeDataType.String, 20),
        new JdeField("VRUPMJ", "VRUPMJ", JdeDataType.Numeric),
        new JdeField("VRUPMT", "VRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P501_0", "Primary Key on VRP74JPKID", new[] { "VRP74JPKID" }, isUnique: true, isPrimaryKey: true)
    };
}
