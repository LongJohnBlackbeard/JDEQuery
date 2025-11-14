using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74RUI41 - .
/// </summary>
public class F74RUI41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W1KCO.
        /// </summary>
        public const string W1KCO = "W1KCO";

        /// <summary>
        /// W1DCT.
        /// </summary>
        public const string W1DCT = "W1DCT";

        /// <summary>
        /// W1DOC.
        /// </summary>
        public const string W1DOC = "W1DOC";

        /// <summary>
        /// W1LNID.
        /// </summary>
        public const string W1LNID = "W1LNID";

        /// <summary>
        /// W1SY.
        /// </summary>
        public const string W1SY = "W1SY";

        /// <summary>
        /// W1VOID.
        /// </summary>
        public const string W1VOID = "W1VOID";

        /// <summary>
        /// W1K74LECO.
        /// </summary>
        public const string W1K74LECO = "W1K74LECO";

        /// <summary>
        /// W1DIVJ.
        /// </summary>
        public const string W1DIVJ = "W1DIVJ";

        /// <summary>
        /// W1VINV.
        /// </summary>
        public const string W1VINV = "W1VINV";

        /// <summary>
        /// W1R74ADNU.
        /// </summary>
        public const string W1R74ADNU = "W1R74ADNU";

        /// <summary>
        /// W1R74ADDT.
        /// </summary>
        public const string W1R74ADDT = "W1R74ADDT";

        /// <summary>
        /// W1R74CONU.
        /// </summary>
        public const string W1R74CONU = "W1R74CONU";

        /// <summary>
        /// W1R74CODJ.
        /// </summary>
        public const string W1R74CODJ = "W1R74CODJ";

        /// <summary>
        /// W1R74ACNU.
        /// </summary>
        public const string W1R74ACNU = "W1R74ACNU";

        /// <summary>
        /// W1R74ACDJ.
        /// </summary>
        public const string W1R74ACDJ = "W1R74ACDJ";

        /// <summary>
        /// W1DMTJ.
        /// </summary>
        public const string W1DMTJ = "W1DMTJ";

        /// <summary>
        /// W1RCDJ.
        /// </summary>
        public const string W1RCDJ = "W1RCDJ";

        /// <summary>
        /// W1K74LMN.
        /// </summary>
        public const string W1K74LMN = "W1K74LMN";

        /// <summary>
        /// W1TAX.
        /// </summary>
        public const string W1TAX = "W1TAX";

        /// <summary>
        /// W1R74KPP.
        /// </summary>
        public const string W1R74KPP = "W1R74KPP";

        /// <summary>
        /// W1AEXP.
        /// </summary>
        public const string W1AEXP = "W1AEXP";

        /// <summary>
        /// W1MATH01.
        /// </summary>
        public const string W1MATH01 = "W1MATH01";

        /// <summary>
        /// W1STA1.
        /// </summary>
        public const string W1STA1 = "W1STA1";

        /// <summary>
        /// W1MATH02.
        /// </summary>
        public const string W1MATH02 = "W1MATH02";

        /// <summary>
        /// W1STA2.
        /// </summary>
        public const string W1STA2 = "W1STA2";

        /// <summary>
        /// W1ATXA.
        /// </summary>
        public const string W1ATXA = "W1ATXA";

        /// <summary>
        /// W1MATH04.
        /// </summary>
        public const string W1MATH04 = "W1MATH04";

        /// <summary>
        /// W1STA4.
        /// </summary>
        public const string W1STA4 = "W1STA4";

        /// <summary>
        /// W1ATXN.
        /// </summary>
        public const string W1ATXN = "W1ATXN";

        /// <summary>
        /// W1MATH05.
        /// </summary>
        public const string W1MATH05 = "W1MATH05";

        /// <summary>
        /// W1STA5.
        /// </summary>
        public const string W1STA5 = "W1STA5";

        /// <summary>
        /// W1EV01.
        /// </summary>
        public const string W1EV01 = "W1EV01";

        /// <summary>
        /// W1EV02.
        /// </summary>
        public const string W1EV02 = "W1EV02";

        /// <summary>
        /// W1RPD.
        /// </summary>
        public const string W1RPD = "W1RPD";

        /// <summary>
        /// W1JOBS.
        /// </summary>
        public const string W1JOBS = "W1JOBS";

        /// <summary>
        /// W1CTID.
        /// </summary>
        public const string W1CTID = "W1CTID";

        /// <summary>
        /// W1PID.
        /// </summary>
        public const string W1PID = "W1PID";

        /// <summary>
        /// W1USER.
        /// </summary>
        public const string W1USER = "W1USER";

        /// <summary>
        /// W1UPMJ.
        /// </summary>
        public const string W1UPMJ = "W1UPMJ";

        /// <summary>
        /// W1UPMT.
        /// </summary>
        public const string W1UPMT = "W1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74RUI41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W1KCO", "W1KCO", JdeDataType.String, 10, true, true),
        new JdeField("W1DCT", "W1DCT", JdeDataType.String, 4, true, true),
        new JdeField("W1DOC", "W1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("W1LNID", "W1LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("W1SY", "W1SY", JdeDataType.String, 8, true, true),
        new JdeField("W1VOID", "W1VOID", JdeDataType.String, 2),
        new JdeField("W1K74LECO", "W1K74LECO", JdeDataType.String, 10),
        new JdeField("W1DIVJ", "W1DIVJ", JdeDataType.Numeric),
        new JdeField("W1VINV", "W1VINV", JdeDataType.String, 50),
        new JdeField("W1R74ADNU", "W1R74ADNU", JdeDataType.String, 50),
        new JdeField("W1R74ADDT", "W1R74ADDT", JdeDataType.Numeric),
        new JdeField("W1R74CONU", "W1R74CONU", JdeDataType.String, 50),
        new JdeField("W1R74CODJ", "W1R74CODJ", JdeDataType.Numeric),
        new JdeField("W1R74ACNU", "W1R74ACNU", JdeDataType.String, 50),
        new JdeField("W1R74ACDJ", "W1R74ACDJ", JdeDataType.Numeric),
        new JdeField("W1DMTJ", "W1DMTJ", JdeDataType.Numeric),
        new JdeField("W1RCDJ", "W1RCDJ", JdeDataType.Numeric),
        new JdeField("W1K74LMN", "W1K74LMN", JdeDataType.String, 200),
        new JdeField("W1TAX", "W1TAX", JdeDataType.String, 40),
        new JdeField("W1R74KPP", "W1R74KPP", JdeDataType.String, 30),
        new JdeField("W1AEXP", "W1AEXP", JdeDataType.Numeric),
        new JdeField("W1MATH01", "W1MATH01", JdeDataType.Numeric),
        new JdeField("W1STA1", "W1STA1", JdeDataType.Numeric),
        new JdeField("W1MATH02", "W1MATH02", JdeDataType.Numeric),
        new JdeField("W1STA2", "W1STA2", JdeDataType.Numeric),
        new JdeField("W1ATXA", "W1ATXA", JdeDataType.Numeric),
        new JdeField("W1MATH04", "W1MATH04", JdeDataType.Numeric),
        new JdeField("W1STA4", "W1STA4", JdeDataType.Numeric),
        new JdeField("W1ATXN", "W1ATXN", JdeDataType.Numeric),
        new JdeField("W1MATH05", "W1MATH05", JdeDataType.Numeric),
        new JdeField("W1STA5", "W1STA5", JdeDataType.Numeric),
        new JdeField("W1EV01", "W1EV01", JdeDataType.String, 2),
        new JdeField("W1EV02", "W1EV02", JdeDataType.String, 2),
        new JdeField("W1RPD", "W1RPD", JdeDataType.Numeric),
        new JdeField("W1JOBS", "W1JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("W1CTID", "W1CTID", JdeDataType.String, 30, true, true),
        new JdeField("W1PID", "W1PID", JdeDataType.String, 20),
        new JdeField("W1USER", "W1USER", JdeDataType.String, 20),
        new JdeField("W1UPMJ", "W1UPMJ", JdeDataType.Numeric),
        new JdeField("W1UPMT", "W1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74RUI41_0", "Primary Key on W1KCO, W1DCT, W1DOC, W1LNID, W1SY, W1JOBS, W1CTID", new[] { "W1KCO", "W1DCT", "W1DOC", "W1LNID", "W1SY", "W1JOBS", "W1CTID" }, isUnique: true, isPrimaryKey: true)
    };
}
