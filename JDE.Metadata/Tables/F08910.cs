using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08910 - .
/// </summary>
public class F08910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J1PAN8.
        /// </summary>
        public const string J1PAN8 = "J1PAN8";

        /// <summary>
        /// J1QE1.
        /// </summary>
        public const string J1QE1 = "J1QE1";

        /// <summary>
        /// J1QD1.
        /// </summary>
        public const string J1QD1 = "J1QD1";

        /// <summary>
        /// J1AN8.
        /// </summary>
        public const string J1AN8 = "J1AN8";

        /// <summary>
        /// J1RPA8.
        /// </summary>
        public const string J1RPA8 = "J1RPA8";

        /// <summary>
        /// J1DCLS.
        /// </summary>
        public const string J1DCLS = "J1DCLS";

        /// <summary>
        /// J1QDM1.
        /// </summary>
        public const string J1QDM1 = "J1QDM1";

        /// <summary>
        /// J1DCE.
        /// </summary>
        public const string J1DCE = "J1DCE";

        /// <summary>
        /// J1DEXP.
        /// </summary>
        public const string J1DEXP = "J1DEXP";

        /// <summary>
        /// J1DCST.
        /// </summary>
        public const string J1DCST = "J1DCST";

        /// <summary>
        /// J1DCX.
        /// </summary>
        public const string J1DCX = "J1DCX";

        /// <summary>
        /// J1DWV.
        /// </summary>
        public const string J1DWV = "J1DWV";

        /// <summary>
        /// J1DTC.
        /// </summary>
        public const string J1DTC = "J1DTC";

        /// <summary>
        /// J1TRSC.
        /// </summary>
        public const string J1TRSC = "J1TRSC";

        /// <summary>
        /// J1CVP.
        /// </summary>
        public const string J1CVP = "J1CVP";

        /// <summary>
        /// J1NPX.
        /// </summary>
        public const string J1NPX = "J1NPX";

        /// <summary>
        /// J1DTMI.
        /// </summary>
        public const string J1DTMI = "J1DTMI";

        /// <summary>
        /// J1DT.
        /// </summary>
        public const string J1DT = "J1DT";

        /// <summary>
        /// J1TRS.
        /// </summary>
        public const string J1TRS = "J1TRS";

        /// <summary>
        /// J1DTRA.
        /// </summary>
        public const string J1DTRA = "J1DTRA";

        /// <summary>
        /// J1DTER.
        /// </summary>
        public const string J1DTER = "J1DTER";

        /// <summary>
        /// J1DTNL.
        /// </summary>
        public const string J1DTNL = "J1DTNL";

        /// <summary>
        /// J1SKDH.
        /// </summary>
        public const string J1SKDH = "J1SKDH";

        /// <summary>
        /// J1UN.
        /// </summary>
        public const string J1UN = "J1UN";

        /// <summary>
        /// J1RTDT.
        /// </summary>
        public const string J1RTDT = "J1RTDT";

        /// <summary>
        /// J1AN82.
        /// </summary>
        public const string J1AN82 = "J1AN82";

        /// <summary>
        /// J1HMCU.
        /// </summary>
        public const string J1HMCU = "J1HMCU";

        /// <summary>
        /// J1HMCO.
        /// </summary>
        public const string J1HMCO = "J1HMCO";

        /// <summary>
        /// J1JBCD.
        /// </summary>
        public const string J1JBCD = "J1JBCD";

        /// <summary>
        /// J1JBST.
        /// </summary>
        public const string J1JBST = "J1JBST";

        /// <summary>
        /// J1SAL.
        /// </summary>
        public const string J1SAL = "J1SAL";

        /// <summary>
        /// J1MCU.
        /// </summary>
        public const string J1MCU = "J1MCU";

        /// <summary>
        /// J1TARR.
        /// </summary>
        public const string J1TARR = "J1TARR";

        /// <summary>
        /// J1DTWR.
        /// </summary>
        public const string J1DTWR = "J1DTWR";

        /// <summary>
        /// J1DIVC.
        /// </summary>
        public const string J1DIVC = "J1DIVC";

        /// <summary>
        /// J1DTDH.
        /// </summary>
        public const string J1DTDH = "J1DTDH";

        /// <summary>
        /// J1DTNR.
        /// </summary>
        public const string J1DTNR = "J1DTNR";

        /// <summary>
        /// J1DTMR.
        /// </summary>
        public const string J1DTMR = "J1DTMR";

        /// <summary>
        /// J1DTOD.
        /// </summary>
        public const string J1DTOD = "J1DTOD";

        /// <summary>
        /// J1DTOB.
        /// </summary>
        public const string J1DTOB = "J1DTOB";

        /// <summary>
        /// J1DTET.
        /// </summary>
        public const string J1DTET = "J1DTET";

        /// <summary>
        /// J1USER.
        /// </summary>
        public const string J1USER = "J1USER";

        /// <summary>
        /// J1EAP.
        /// </summary>
        public const string J1EAP = "J1EAP";

        /// <summary>
        /// J1MACH.
        /// </summary>
        public const string J1MACH = "J1MACH";

        /// <summary>
        /// J1UPMJ.
        /// </summary>
        public const string J1UPMJ = "J1UPMJ";

        /// <summary>
        /// J1UPMT.
        /// </summary>
        public const string J1UPMT = "J1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J1PAN8", "J1PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J1QE1", "J1QE1", JdeDataType.String, 4, true, true),
        new JdeField("J1QD1", "J1QD1", JdeDataType.Numeric, null, true, true),
        new JdeField("J1AN8", "J1AN8", JdeDataType.Numeric),
        new JdeField("J1RPA8", "J1RPA8", JdeDataType.Numeric),
        new JdeField("J1DCLS", "J1DCLS", JdeDataType.Numeric),
        new JdeField("J1QDM1", "J1QDM1", JdeDataType.Numeric),
        new JdeField("J1DCE", "J1DCE", JdeDataType.Numeric),
        new JdeField("J1DEXP", "J1DEXP", JdeDataType.Numeric),
        new JdeField("J1DCST", "J1DCST", JdeDataType.Numeric),
        new JdeField("J1DCX", "J1DCX", JdeDataType.Numeric),
        new JdeField("J1DWV", "J1DWV", JdeDataType.Numeric),
        new JdeField("J1DTC", "J1DTC", JdeDataType.Numeric),
        new JdeField("J1TRSC", "J1TRSC", JdeDataType.String, 4),
        new JdeField("J1CVP", "J1CVP", JdeDataType.Numeric),
        new JdeField("J1NPX", "J1NPX", JdeDataType.Numeric),
        new JdeField("J1DTMI", "J1DTMI", JdeDataType.Numeric),
        new JdeField("J1DT", "J1DT", JdeDataType.Numeric),
        new JdeField("J1TRS", "J1TRS", JdeDataType.String, 6),
        new JdeField("J1DTRA", "J1DTRA", JdeDataType.Numeric),
        new JdeField("J1DTER", "J1DTER", JdeDataType.Numeric),
        new JdeField("J1DTNL", "J1DTNL", JdeDataType.Numeric),
        new JdeField("J1SKDH", "J1SKDH", JdeDataType.Numeric),
        new JdeField("J1UN", "J1UN", JdeDataType.String, 12),
        new JdeField("J1RTDT", "J1RTDT", JdeDataType.Numeric),
        new JdeField("J1AN82", "J1AN82", JdeDataType.Numeric),
        new JdeField("J1HMCU", "J1HMCU", JdeDataType.String, 24),
        new JdeField("J1HMCO", "J1HMCO", JdeDataType.String, 10),
        new JdeField("J1JBCD", "J1JBCD", JdeDataType.String, 12),
        new JdeField("J1JBST", "J1JBST", JdeDataType.String, 8),
        new JdeField("J1SAL", "J1SAL", JdeDataType.Numeric),
        new JdeField("J1MCU", "J1MCU", JdeDataType.String, 24),
        new JdeField("J1TARR", "J1TARR", JdeDataType.String, 20),
        new JdeField("J1DTWR", "J1DTWR", JdeDataType.Numeric),
        new JdeField("J1DIVC", "J1DIVC", JdeDataType.String, 12),
        new JdeField("J1DTDH", "J1DTDH", JdeDataType.Numeric),
        new JdeField("J1DTNR", "J1DTNR", JdeDataType.Numeric),
        new JdeField("J1DTMR", "J1DTMR", JdeDataType.Numeric),
        new JdeField("J1DTOD", "J1DTOD", JdeDataType.Numeric),
        new JdeField("J1DTOB", "J1DTOB", JdeDataType.Numeric),
        new JdeField("J1DTET", "J1DTET", JdeDataType.Numeric),
        new JdeField("J1USER", "J1USER", JdeDataType.String, 20),
        new JdeField("J1EAP", "J1EAP", JdeDataType.String, 20),
        new JdeField("J1MACH", "J1MACH", JdeDataType.String, 24),
        new JdeField("J1UPMJ", "J1UPMJ", JdeDataType.Numeric),
        new JdeField("J1UPMT", "J1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08910_0", "Primary Key on J1PAN8, J1QE1, J1QD1", new[] { "J1PAN8", "J1QE1", "J1QD1" }, isUnique: true, isPrimaryKey: true)
    };
}
