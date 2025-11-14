using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F83UI001 - .
/// </summary>
public class F83UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R1PID.
        /// </summary>
        public const string R1PID = "R1PID";

        /// <summary>
        /// R1VRID.
        /// </summary>
        public const string R1VRID = "R1VRID";

        /// <summary>
        /// R1BASECN.
        /// </summary>
        public const string R1BASECN = "R1BASECN";

        /// <summary>
        /// R1BACOLN.
        /// </summary>
        public const string R1BACOLN = "R1BACOLN";

        /// <summary>
        /// R1BAROWN.
        /// </summary>
        public const string R1BAROWN = "R1BAROWN";

        /// <summary>
        /// R1BALINN.
        /// </summary>
        public const string R1BALINN = "R1BALINN";

        /// <summary>
        /// R1CO.
        /// </summary>
        public const string R1CO = "R1CO";

        /// <summary>
        /// R1AID.
        /// </summary>
        public const string R1AID = "R1AID";

        /// <summary>
        /// R1PN.
        /// </summary>
        public const string R1PN = "R1PN";

        /// <summary>
        /// R1LT.
        /// </summary>
        public const string R1LT = "R1LT";

        /// <summary>
        /// R1FY.
        /// </summary>
        public const string R1FY = "R1FY";

        /// <summary>
        /// R1SBL.
        /// </summary>
        public const string R1SBL = "R1SBL";

        /// <summary>
        /// R1SBLT.
        /// </summary>
        public const string R1SBLT = "R1SBLT";

        /// <summary>
        /// R1CRCD.
        /// </summary>
        public const string R1CRCD = "R1CRCD";

        /// <summary>
        /// R1CRCX.
        /// </summary>
        public const string R1CRCX = "R1CRCX";

        /// <summary>
        /// R1AA.
        /// </summary>
        public const string R1AA = "R1AA";

        /// <summary>
        /// R1VWNM.
        /// </summary>
        public const string R1VWNM = "R1VWNM";

        /// <summary>
        /// R1ACTB.
        /// </summary>
        public const string R1ACTB = "R1ACTB";

        /// <summary>
        /// R1ABR1.
        /// </summary>
        public const string R1ABR1 = "R1ABR1";

        /// <summary>
        /// R1ABT1.
        /// </summary>
        public const string R1ABT1 = "R1ABT1";

        /// <summary>
        /// R1ABR2.
        /// </summary>
        public const string R1ABR2 = "R1ABR2";

        /// <summary>
        /// R1ABT2.
        /// </summary>
        public const string R1ABT2 = "R1ABT2";

        /// <summary>
        /// R1ABR3.
        /// </summary>
        public const string R1ABR3 = "R1ABR3";

        /// <summary>
        /// R1ABT3.
        /// </summary>
        public const string R1ABT3 = "R1ABT3";

        /// <summary>
        /// R1ABR4.
        /// </summary>
        public const string R1ABR4 = "R1ABR4";

        /// <summary>
        /// R1ABT4.
        /// </summary>
        public const string R1ABT4 = "R1ABT4";

        /// <summary>
        /// R1ITM.
        /// </summary>
        public const string R1ITM = "R1ITM";

        /// <summary>
        /// R1CFY.
        /// </summary>
        public const string R1CFY = "R1CFY";

        /// <summary>
        /// R1UPMJ.
        /// </summary>
        public const string R1UPMJ = "R1UPMJ";

        /// <summary>
        /// R1UPMT.
        /// </summary>
        public const string R1UPMT = "R1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F83UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R1PID", "R1PID", JdeDataType.String, 20, true, true),
        new JdeField("R1VRID", "R1VRID", JdeDataType.String, 20, true, true),
        new JdeField("R1BASECN", "R1BASECN", JdeDataType.Numeric, null, true, true),
        new JdeField("R1BACOLN", "R1BACOLN", JdeDataType.Numeric, null, true, true),
        new JdeField("R1BAROWN", "R1BAROWN", JdeDataType.Numeric, null, true, true),
        new JdeField("R1BALINN", "R1BALINN", JdeDataType.Numeric, null, true, true),
        new JdeField("R1CO", "R1CO", JdeDataType.String, 10),
        new JdeField("R1AID", "R1AID", JdeDataType.String, 16),
        new JdeField("R1PN", "R1PN", JdeDataType.Numeric),
        new JdeField("R1LT", "R1LT", JdeDataType.String, 4),
        new JdeField("R1FY", "R1FY", JdeDataType.Numeric),
        new JdeField("R1SBL", "R1SBL", JdeDataType.String, 16),
        new JdeField("R1SBLT", "R1SBLT", JdeDataType.String, 2),
        new JdeField("R1CRCD", "R1CRCD", JdeDataType.String, 6),
        new JdeField("R1CRCX", "R1CRCX", JdeDataType.String, 6),
        new JdeField("R1AA", "R1AA", JdeDataType.Numeric),
        new JdeField("R1VWNM", "R1VWNM", JdeDataType.Numeric),
        new JdeField("R1ACTB", "R1ACTB", JdeDataType.String, 20),
        new JdeField("R1ABR1", "R1ABR1", JdeDataType.String, 24),
        new JdeField("R1ABT1", "R1ABT1", JdeDataType.String, 2),
        new JdeField("R1ABR2", "R1ABR2", JdeDataType.String, 24),
        new JdeField("R1ABT2", "R1ABT2", JdeDataType.String, 2),
        new JdeField("R1ABR3", "R1ABR3", JdeDataType.String, 24),
        new JdeField("R1ABT3", "R1ABT3", JdeDataType.String, 2),
        new JdeField("R1ABR4", "R1ABR4", JdeDataType.String, 24),
        new JdeField("R1ABT4", "R1ABT4", JdeDataType.String, 2),
        new JdeField("R1ITM", "R1ITM", JdeDataType.Numeric),
        new JdeField("R1CFY", "R1CFY", JdeDataType.Numeric),
        new JdeField("R1UPMJ", "R1UPMJ", JdeDataType.Numeric),
        new JdeField("R1UPMT", "R1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F83UI001_0", "Primary Key on R1PID, R1VRID, R1BASECN, R1BACOLN, R1BAROWN, R1BALINN", new[] { "R1PID", "R1VRID", "R1BASECN", "R1BACOLN", "R1BAROWN", "R1BALINN" }, isUnique: true, isPrimaryKey: true)
    };
}
