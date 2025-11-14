using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I313T - .
/// </summary>
public class F75I313T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTPYID.
        /// </summary>
        public const string RTPYID = "RTPYID";

        /// <summary>
        /// RTI75TSCT.
        /// </summary>
        public const string RTI75TSCT = "RTI75TSCT";

        /// <summary>
        /// RTI75TSAPF.
        /// </summary>
        public const string RTI75TSAPF = "RTI75TSAPF";

        /// <summary>
        /// RTDOC.
        /// </summary>
        public const string RTDOC = "RTDOC";

        /// <summary>
        /// RTDCT.
        /// </summary>
        public const string RTDCT = "RTDCT";

        /// <summary>
        /// RTKCO.
        /// </summary>
        public const string RTKCO = "RTKCO";

        /// <summary>
        /// RTI75RP.
        /// </summary>
        public const string RTI75RP = "RTI75RP";

        /// <summary>
        /// RTVOD.
        /// </summary>
        public const string RTVOD = "RTVOD";

        /// <summary>
        /// RTI75TSAMT.
        /// </summary>
        public const string RTI75TSAMT = "RTI75TSAMT";

        /// <summary>
        /// RTI75TSRT.
        /// </summary>
        public const string RTI75TSRT = "RTI75TSRT";

        /// <summary>
        /// RTI75TSPLA.
        /// </summary>
        public const string RTI75TSPLA = "RTI75TSPLA";

        /// <summary>
        /// RTI75TSPLR.
        /// </summary>
        public const string RTI75TSPLR = "RTI75TSPLR";

        /// <summary>
        /// RTICU.
        /// </summary>
        public const string RTICU = "RTICU";

        /// <summary>
        /// RTICUT.
        /// </summary>
        public const string RTICUT = "RTICUT";

        /// <summary>
        /// RTPA8.
        /// </summary>
        public const string RTPA8 = "RTPA8";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTYFUTDT.
        /// </summary>
        public const string RTYFUTDT = "RTYFUTDT";

        /// <summary>
        /// RTFFU4.
        /// </summary>
        public const string RTFFU4 = "RTFFU4";

        /// <summary>
        /// RTFUT3.
        /// </summary>
        public const string RTFUT3 = "RTFUT3";

        /// <summary>
        /// RTX2.
        /// </summary>
        public const string RTX2 = "RTX2";

        /// <summary>
        /// RTFUTCH1.
        /// </summary>
        public const string RTFUTCH1 = "RTFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I313T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTPYID", "RTPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTI75TSCT", "RTI75TSCT", JdeDataType.String, 4),
        new JdeField("RTI75TSAPF", "RTI75TSAPF", JdeDataType.String, 2),
        new JdeField("RTDOC", "RTDOC", JdeDataType.Numeric),
        new JdeField("RTDCT", "RTDCT", JdeDataType.String, 4),
        new JdeField("RTKCO", "RTKCO", JdeDataType.String, 10),
        new JdeField("RTI75RP", "RTI75RP", JdeDataType.String, 2),
        new JdeField("RTVOD", "RTVOD", JdeDataType.String, 2),
        new JdeField("RTI75TSAMT", "RTI75TSAMT", JdeDataType.Numeric),
        new JdeField("RTI75TSRT", "RTI75TSRT", JdeDataType.Numeric),
        new JdeField("RTI75TSPLA", "RTI75TSPLA", JdeDataType.Numeric),
        new JdeField("RTI75TSPLR", "RTI75TSPLR", JdeDataType.Numeric),
        new JdeField("RTICU", "RTICU", JdeDataType.Numeric),
        new JdeField("RTICUT", "RTICUT", JdeDataType.String, 4),
        new JdeField("RTPA8", "RTPA8", JdeDataType.Numeric),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTYFUTDT", "RTYFUTDT", JdeDataType.Numeric),
        new JdeField("RTFFU4", "RTFFU4", JdeDataType.Numeric),
        new JdeField("RTFUT3", "RTFUT3", JdeDataType.String, 60),
        new JdeField("RTX2", "RTX2", JdeDataType.String, 2),
        new JdeField("RTFUTCH1", "RTFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I313T_0", "Primary Key on RTPYID", new[] { "RTPYID" }, isUnique: true, isPrimaryKey: true)
    };
}
