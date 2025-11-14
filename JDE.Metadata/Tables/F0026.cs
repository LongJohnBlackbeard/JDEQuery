using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0026 - .
/// </summary>
public class F0026 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLCO.
        /// </summary>
        public const string CLCO = "CLCO";

        /// <summary>
        /// CLDTPW.
        /// </summary>
        public const string CLDTPW = "CLDTPW";

        /// <summary>
        /// CLDFW.
        /// </summary>
        public const string CLDFW = "CLDFW";

        /// <summary>
        /// CLCALW.
        /// </summary>
        public const string CLCALW = "CLCALW";

        /// <summary>
        /// CLPNK.
        /// </summary>
        public const string CLPNK = "CLPNK";

        /// <summary>
        /// CLDJM.
        /// </summary>
        public const string CLDJM = "CLDJM";

        /// <summary>
        /// CLDJW.
        /// </summary>
        public const string CLDJW = "CLDJW";

        /// <summary>
        /// CLFMO.
        /// </summary>
        public const string CLFMO = "CLFMO";

        /// <summary>
        /// CLBAT.
        /// </summary>
        public const string CLBAT = "CLBAT";

        /// <summary>
        /// CLCGT.
        /// </summary>
        public const string CLCGT = "CLCGT";

        /// <summary>
        /// CLJCP.
        /// </summary>
        public const string CLJCP = "CLJCP";

        /// <summary>
        /// CLCMTR.
        /// </summary>
        public const string CLCMTR = "CLCMTR";

        /// <summary>
        /// CLCMTT.
        /// </summary>
        public const string CLCMTT = "CLCMTT";

        /// <summary>
        /// CLJCF1.
        /// </summary>
        public const string CLJCF1 = "CLJCF1";

        /// <summary>
        /// CLJCF2.
        /// </summary>
        public const string CLJCF2 = "CLJCF2";

        /// <summary>
        /// CLJCF3.
        /// </summary>
        public const string CLJCF3 = "CLJCF3";

        /// <summary>
        /// CLJCF4.
        /// </summary>
        public const string CLJCF4 = "CLJCF4";

        /// <summary>
        /// CLJCF5.
        /// </summary>
        public const string CLJCF5 = "CLJCF5";
    }

    /// <inheritdoc />
    public override string TableName => "F0026";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLCO", "CLCO", JdeDataType.String, 10, true, true),
        new JdeField("CLDTPW", "CLDTPW", JdeDataType.String, 2),
        new JdeField("CLDFW", "CLDFW", JdeDataType.Numeric),
        new JdeField("CLCALW", "CLCALW", JdeDataType.String, 4),
        new JdeField("CLPNK", "CLPNK", JdeDataType.Numeric),
        new JdeField("CLDJM", "CLDJM", JdeDataType.Numeric),
        new JdeField("CLDJW", "CLDJW", JdeDataType.Numeric),
        new JdeField("CLFMO", "CLFMO", JdeDataType.String, 2),
        new JdeField("CLBAT", "CLBAT", JdeDataType.String, 2),
        new JdeField("CLCGT", "CLCGT", JdeDataType.String, 2),
        new JdeField("CLJCP", "CLJCP", JdeDataType.String, 2),
        new JdeField("CLCMTR", "CLCMTR", JdeDataType.String, 2),
        new JdeField("CLCMTT", "CLCMTT", JdeDataType.String, 2),
        new JdeField("CLJCF1", "CLJCF1", JdeDataType.String, 2),
        new JdeField("CLJCF2", "CLJCF2", JdeDataType.String, 2),
        new JdeField("CLJCF3", "CLJCF3", JdeDataType.String, 2),
        new JdeField("CLJCF4", "CLJCF4", JdeDataType.String, 2),
        new JdeField("CLJCF5", "CLJCF5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0026_0", "Primary Key on CLCO", new[] { "CLCO" }, isUnique: true, isPrimaryKey: true)
    };
}
