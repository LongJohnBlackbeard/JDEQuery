using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F089101 - .
/// </summary>
public class F089101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J2PAN8.
        /// </summary>
        public const string J2PAN8 = "J2PAN8";

        /// <summary>
        /// J2QE1.
        /// </summary>
        public const string J2QE1 = "J2QE1";

        /// <summary>
        /// J2QD1.
        /// </summary>
        public const string J2QD1 = "J2QD1";

        /// <summary>
        /// J2CPTY.
        /// </summary>
        public const string J2CPTY = "J2CPTY";

        /// <summary>
        /// J2QE2.
        /// </summary>
        public const string J2QE2 = "J2QE2";

        /// <summary>
        /// J2QD2.
        /// </summary>
        public const string J2QD2 = "J2QD2";

        /// <summary>
        /// J2QDM2.
        /// </summary>
        public const string J2QDM2 = "J2QDM2";

        /// <summary>
        /// J2CVP2.
        /// </summary>
        public const string J2CVP2 = "J2CVP2";

        /// <summary>
        /// J2RPA8.
        /// </summary>
        public const string J2RPA8 = "J2RPA8";

        /// <summary>
        /// J2DWV.
        /// </summary>
        public const string J2DWV = "J2DWV";

        /// <summary>
        /// J2DCST.
        /// </summary>
        public const string J2DCST = "J2DCST";

        /// <summary>
        /// J2DCX.
        /// </summary>
        public const string J2DCX = "J2DCX";

        /// <summary>
        /// J2DTC.
        /// </summary>
        public const string J2DTC = "J2DTC";

        /// <summary>
        /// J2TRSC.
        /// </summary>
        public const string J2TRSC = "J2TRSC";

        /// <summary>
        /// J2DTRA.
        /// </summary>
        public const string J2DTRA = "J2DTRA";

        /// <summary>
        /// J2DTER.
        /// </summary>
        public const string J2DTER = "J2DTER";

        /// <summary>
        /// J2DTWR.
        /// </summary>
        public const string J2DTWR = "J2DTWR";

        /// <summary>
        /// J2DTDV.
        /// </summary>
        public const string J2DTDV = "J2DTDV";

        /// <summary>
        /// J2DTMR.
        /// </summary>
        public const string J2DTMR = "J2DTMR";

        /// <summary>
        /// J2DTNL.
        /// </summary>
        public const string J2DTNL = "J2DTNL";

        /// <summary>
        /// J2AN8.
        /// </summary>
        public const string J2AN8 = "J2AN8";

        /// <summary>
        /// J2AN82.
        /// </summary>
        public const string J2AN82 = "J2AN82";

        /// <summary>
        /// J2USER.
        /// </summary>
        public const string J2USER = "J2USER";

        /// <summary>
        /// J2EAP.
        /// </summary>
        public const string J2EAP = "J2EAP";

        /// <summary>
        /// J2MACH.
        /// </summary>
        public const string J2MACH = "J2MACH";

        /// <summary>
        /// J2UPMJ.
        /// </summary>
        public const string J2UPMJ = "J2UPMJ";

        /// <summary>
        /// J2UPMT.
        /// </summary>
        public const string J2UPMT = "J2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F089101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J2PAN8", "J2PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J2QE1", "J2QE1", JdeDataType.String, 4, true, true),
        new JdeField("J2QD1", "J2QD1", JdeDataType.Numeric, null, true, true),
        new JdeField("J2CPTY", "J2CPTY", JdeDataType.String, 2),
        new JdeField("J2QE2", "J2QE2", JdeDataType.String, 4, true, true),
        new JdeField("J2QD2", "J2QD2", JdeDataType.Numeric, null, true, true),
        new JdeField("J2QDM2", "J2QDM2", JdeDataType.Numeric),
        new JdeField("J2CVP2", "J2CVP2", JdeDataType.Numeric),
        new JdeField("J2RPA8", "J2RPA8", JdeDataType.Numeric),
        new JdeField("J2DWV", "J2DWV", JdeDataType.Numeric),
        new JdeField("J2DCST", "J2DCST", JdeDataType.Numeric),
        new JdeField("J2DCX", "J2DCX", JdeDataType.Numeric),
        new JdeField("J2DTC", "J2DTC", JdeDataType.Numeric),
        new JdeField("J2TRSC", "J2TRSC", JdeDataType.String, 4),
        new JdeField("J2DTRA", "J2DTRA", JdeDataType.Numeric),
        new JdeField("J2DTER", "J2DTER", JdeDataType.Numeric),
        new JdeField("J2DTWR", "J2DTWR", JdeDataType.Numeric),
        new JdeField("J2DTDV", "J2DTDV", JdeDataType.Numeric),
        new JdeField("J2DTMR", "J2DTMR", JdeDataType.Numeric),
        new JdeField("J2DTNL", "J2DTNL", JdeDataType.Numeric),
        new JdeField("J2AN8", "J2AN8", JdeDataType.Numeric),
        new JdeField("J2AN82", "J2AN82", JdeDataType.Numeric),
        new JdeField("J2USER", "J2USER", JdeDataType.String, 20),
        new JdeField("J2EAP", "J2EAP", JdeDataType.String, 20),
        new JdeField("J2MACH", "J2MACH", JdeDataType.String, 24),
        new JdeField("J2UPMJ", "J2UPMJ", JdeDataType.Numeric),
        new JdeField("J2UPMT", "J2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F089101_0", "Primary Key on J2PAN8, J2QE1, J2QD1, J2QE2, J2QD2", new[] { "J2PAN8", "J2QE1", "J2QD1", "J2QE2", "J2QD2" }, isUnique: true, isPrimaryKey: true)
    };
}
