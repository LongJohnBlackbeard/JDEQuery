using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0780 - .
/// </summary>
public class F76B0780 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTB76ATCT.
        /// </summary>
        public const string RTB76ATCT = "RTB76ATCT";

        /// <summary>
        /// RTB76BLCK.
        /// </summary>
        public const string RTB76BLCK = "RTB76BLCK";

        /// <summary>
        /// RTB76RECD.
        /// </summary>
        public const string RTB76RECD = "RTB76RECD";

        /// <summary>
        /// RTB76FPTY.
        /// </summary>
        public const string RTB76FPTY = "RTB76FPTY";

        /// <summary>
        /// RTB76CIR.
        /// </summary>
        public const string RTB76CIR = "RTB76CIR";

        /// <summary>
        /// RTB76COR.
        /// </summary>
        public const string RTB76COR = "RTB76COR";

        /// <summary>
        /// RTB76CAR.
        /// </summary>
        public const string RTB76CAR = "RTB76CAR";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76B0780";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTB76ATCT", "RTB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("RTB76BLCK", "RTB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("RTB76RECD", "RTB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("RTB76FPTY", "RTB76FPTY", JdeDataType.String, 2, true, true),
        new JdeField("RTB76CIR", "RTB76CIR", JdeDataType.String, 4),
        new JdeField("RTB76COR", "RTB76COR", JdeDataType.String, 4),
        new JdeField("RTB76CAR", "RTB76CAR", JdeDataType.String, 4),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0780_0", "Primary Key on RTB76ATCT, RTB76BLCK, RTB76RECD, RTB76FPTY", new[] { "RTB76ATCT", "RTB76BLCK", "RTB76RECD", "RTB76FPTY" }, isUnique: true, isPrimaryKey: true)
    };
}
