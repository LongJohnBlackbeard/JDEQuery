using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0220 - .
/// </summary>
public class F75A0220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSDCTM.
        /// </summary>
        public const string PSDCTM = "PSDCTM";

        /// <summary>
        /// PSDOCM.
        /// </summary>
        public const string PSDOCM = "PSDOCM";

        /// <summary>
        /// PSAN8.
        /// </summary>
        public const string PSAN8 = "PSAN8";

        /// <summary>
        /// PSTAX.
        /// </summary>
        public const string PSTAX = "PSTAX";

        /// <summary>
        /// PSMLNM.
        /// </summary>
        public const string PSMLNM = "PSMLNM";

        /// <summary>
        /// PSADD1.
        /// </summary>
        public const string PSADD1 = "PSADD1";

        /// <summary>
        /// PSADD2.
        /// </summary>
        public const string PSADD2 = "PSADD2";

        /// <summary>
        /// PSADD3.
        /// </summary>
        public const string PSADD3 = "PSADD3";

        /// <summary>
        /// PSADD4.
        /// </summary>
        public const string PSADD4 = "PSADD4";

        /// <summary>
        /// PSCTY1.
        /// </summary>
        public const string PSCTY1 = "PSCTY1";

        /// <summary>
        /// PSADDS.
        /// </summary>
        public const string PSADDS = "PSADDS";

        /// <summary>
        /// PSADDZ.
        /// </summary>
        public const string PSADDZ = "PSADDZ";

        /// <summary>
        /// PSPYE.
        /// </summary>
        public const string PSPYE = "PSPYE";

        /// <summary>
        /// PSSHL1.
        /// </summary>
        public const string PSSHL1 = "PSSHL1";

        /// <summary>
        /// PSSHL2.
        /// </summary>
        public const string PSSHL2 = "PSSHL2";

        /// <summary>
        /// PSSHL3.
        /// </summary>
        public const string PSSHL3 = "PSSHL3";

        /// <summary>
        /// PSSHL4.
        /// </summary>
        public const string PSSHL4 = "PSSHL4";

        /// <summary>
        /// PSSHL5.
        /// </summary>
        public const string PSSHL5 = "PSSHL5";

        /// <summary>
        /// PSSHL6.
        /// </summary>
        public const string PSSHL6 = "PSSHL6";

        /// <summary>
        /// PSAG.
        /// </summary>
        public const string PSAG = "PSAG";

        /// <summary>
        /// PSAA.
        /// </summary>
        public const string PSAA = "PSAA";

        /// <summary>
        /// PSDMTJ.
        /// </summary>
        public const string PSDMTJ = "PSDMTJ";

        /// <summary>
        /// PSURDT.
        /// </summary>
        public const string PSURDT = "PSURDT";

        /// <summary>
        /// PSURAB.
        /// </summary>
        public const string PSURAB = "PSURAB";

        /// <summary>
        /// PSURAT.
        /// </summary>
        public const string PSURAT = "PSURAT";

        /// <summary>
        /// PSURRF.
        /// </summary>
        public const string PSURRF = "PSURRF";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";

        /// <summary>
        /// PSUPMT.
        /// </summary>
        public const string PSUPMT = "PSUPMT";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSDCTM", "PSDCTM", JdeDataType.String, 4, true, true),
        new JdeField("PSDOCM", "PSDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("PSAN8", "PSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PSTAX", "PSTAX", JdeDataType.String, 40),
        new JdeField("PSMLNM", "PSMLNM", JdeDataType.String, 80),
        new JdeField("PSADD1", "PSADD1", JdeDataType.String, 80),
        new JdeField("PSADD2", "PSADD2", JdeDataType.String, 80),
        new JdeField("PSADD3", "PSADD3", JdeDataType.String, 80),
        new JdeField("PSADD4", "PSADD4", JdeDataType.String, 80),
        new JdeField("PSCTY1", "PSCTY1", JdeDataType.String, 50),
        new JdeField("PSADDS", "PSADDS", JdeDataType.String, 6),
        new JdeField("PSADDZ", "PSADDZ", JdeDataType.String, 24),
        new JdeField("PSPYE", "PSPYE", JdeDataType.Numeric),
        new JdeField("PSSHL1", "PSSHL1", JdeDataType.String, 80),
        new JdeField("PSSHL2", "PSSHL2", JdeDataType.String, 80),
        new JdeField("PSSHL3", "PSSHL3", JdeDataType.String, 80),
        new JdeField("PSSHL4", "PSSHL4", JdeDataType.String, 80),
        new JdeField("PSSHL5", "PSSHL5", JdeDataType.String, 80),
        new JdeField("PSSHL6", "PSSHL6", JdeDataType.String, 80),
        new JdeField("PSAG", "PSAG", JdeDataType.Numeric),
        new JdeField("PSAA", "PSAA", JdeDataType.Numeric),
        new JdeField("PSDMTJ", "PSDMTJ", JdeDataType.Numeric),
        new JdeField("PSURDT", "PSURDT", JdeDataType.Numeric),
        new JdeField("PSURAB", "PSURAB", JdeDataType.Numeric),
        new JdeField("PSURAT", "PSURAT", JdeDataType.Numeric),
        new JdeField("PSURRF", "PSURRF", JdeDataType.String, 30),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric),
        new JdeField("PSUPMT", "PSUPMT", JdeDataType.Numeric),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0220_0", "Primary Key on PSDCTM, PSDOCM, PSAN8", new[] { "PSDCTM", "PSDOCM", "PSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
