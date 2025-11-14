using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I346 - .
/// </summary>
public class F75I346 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q9YEXU.
        /// </summary>
        public const string Q9YEXU = "Q9YEXU";

        /// <summary>
        /// Q9DOCO.
        /// </summary>
        public const string Q9DOCO = "Q9DOCO";

        /// <summary>
        /// Q9DCTO.
        /// </summary>
        public const string Q9DCTO = "Q9DCTO";

        /// <summary>
        /// Q9KCOO.
        /// </summary>
        public const string Q9KCOO = "Q9KCOO";

        /// <summary>
        /// Q9LNID.
        /// </summary>
        public const string Q9LNID = "Q9LNID";

        /// <summary>
        /// Q9OORN.
        /// </summary>
        public const string Q9OORN = "Q9OORN";

        /// <summary>
        /// Q9OCTO.
        /// </summary>
        public const string Q9OCTO = "Q9OCTO";

        /// <summary>
        /// Q9OKCO.
        /// </summary>
        public const string Q9OKCO = "Q9OKCO";

        /// <summary>
        /// Q9DOC.
        /// </summary>
        public const string Q9DOC = "Q9DOC";

        /// <summary>
        /// Q9DCT.
        /// </summary>
        public const string Q9DCT = "Q9DCT";

        /// <summary>
        /// Q9KCO.
        /// </summary>
        public const string Q9KCO = "Q9KCO";

        /// <summary>
        /// Q9IVD.
        /// </summary>
        public const string Q9IVD = "Q9IVD";

        /// <summary>
        /// Q9ITM.
        /// </summary>
        public const string Q9ITM = "Q9ITM";

        /// <summary>
        /// Q9LITM.
        /// </summary>
        public const string Q9LITM = "Q9LITM";

        /// <summary>
        /// Q9AITM.
        /// </summary>
        public const string Q9AITM = "Q9AITM";

        /// <summary>
        /// Q9SOQS.
        /// </summary>
        public const string Q9SOQS = "Q9SOQS";

        /// <summary>
        /// Q9UREC.
        /// </summary>
        public const string Q9UREC = "Q9UREC";

        /// <summary>
        /// Q9UOM.
        /// </summary>
        public const string Q9UOM = "Q9UOM";

        /// <summary>
        /// Q9YEXA.
        /// </summary>
        public const string Q9YEXA = "Q9YEXA";

        /// <summary>
        /// Q9ASVL.
        /// </summary>
        public const string Q9ASVL = "Q9ASVL";

        /// <summary>
        /// Q9AN8.
        /// </summary>
        public const string Q9AN8 = "Q9AN8";

        /// <summary>
        /// Q9RCDJ.
        /// </summary>
        public const string Q9RCDJ = "Q9RCDJ";

        /// <summary>
        /// Q9RCTM.
        /// </summary>
        public const string Q9RCTM = "Q9RCTM";

        /// <summary>
        /// Q9YD3D.
        /// </summary>
        public const string Q9YD3D = "Q9YD3D";

        /// <summary>
        /// Q9YCHN.
        /// </summary>
        public const string Q9YCHN = "Q9YCHN";

        /// <summary>
        /// Q9MCU.
        /// </summary>
        public const string Q9MCU = "Q9MCU";

        /// <summary>
        /// Q9LOCN.
        /// </summary>
        public const string Q9LOCN = "Q9LOCN";

        /// <summary>
        /// Q9LOTN.
        /// </summary>
        public const string Q9LOTN = "Q9LOTN";

        /// <summary>
        /// Q9RMK.
        /// </summary>
        public const string Q9RMK = "Q9RMK";

        /// <summary>
        /// Q9RWQT.
        /// </summary>
        public const string Q9RWQT = "Q9RWQT";

        /// <summary>
        /// Q9CPIT.
        /// </summary>
        public const string Q9CPIT = "Q9CPIT";

        /// <summary>
        /// Q9TRQT.
        /// </summary>
        public const string Q9TRQT = "Q9TRQT";

        /// <summary>
        /// Q9DSC.
        /// </summary>
        public const string Q9DSC = "Q9DSC";

        /// <summary>
        /// Q9QTY1.
        /// </summary>
        public const string Q9QTY1 = "Q9QTY1";

        /// <summary>
        /// Q9DSC1.
        /// </summary>
        public const string Q9DSC1 = "Q9DSC1";

        /// <summary>
        /// Q9DSC2.
        /// </summary>
        public const string Q9DSC2 = "Q9DSC2";

        /// <summary>
        /// Q9YD3T.
        /// </summary>
        public const string Q9YD3T = "Q9YD3T";

        /// <summary>
        /// Q9YD3N.
        /// </summary>
        public const string Q9YD3N = "Q9YD3N";

        /// <summary>
        /// Q9RBDJ.
        /// </summary>
        public const string Q9RBDJ = "Q9RBDJ";

        /// <summary>
        /// Q9PNTF.
        /// </summary>
        public const string Q9PNTF = "Q9PNTF";

        /// <summary>
        /// Q9MATC.
        /// </summary>
        public const string Q9MATC = "Q9MATC";

        /// <summary>
        /// Q9USER.
        /// </summary>
        public const string Q9USER = "Q9USER";

        /// <summary>
        /// Q9PID.
        /// </summary>
        public const string Q9PID = "Q9PID";

        /// <summary>
        /// Q9JOBN.
        /// </summary>
        public const string Q9JOBN = "Q9JOBN";

        /// <summary>
        /// Q9TDAY.
        /// </summary>
        public const string Q9TDAY = "Q9TDAY";

        /// <summary>
        /// Q9UPMJ.
        /// </summary>
        public const string Q9UPMJ = "Q9UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75I346";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q9YEXU", "Q9YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q9DOCO", "Q9DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("Q9DCTO", "Q9DCTO", JdeDataType.String, 4, true, true),
        new JdeField("Q9KCOO", "Q9KCOO", JdeDataType.String, 10, true, true),
        new JdeField("Q9LNID", "Q9LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q9OORN", "Q9OORN", JdeDataType.String, 16),
        new JdeField("Q9OCTO", "Q9OCTO", JdeDataType.String, 4),
        new JdeField("Q9OKCO", "Q9OKCO", JdeDataType.String, 10),
        new JdeField("Q9DOC", "Q9DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q9DCT", "Q9DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q9KCO", "Q9KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q9IVD", "Q9IVD", JdeDataType.Numeric),
        new JdeField("Q9ITM", "Q9ITM", JdeDataType.Numeric),
        new JdeField("Q9LITM", "Q9LITM", JdeDataType.String, 50),
        new JdeField("Q9AITM", "Q9AITM", JdeDataType.String, 50),
        new JdeField("Q9SOQS", "Q9SOQS", JdeDataType.Numeric),
        new JdeField("Q9UREC", "Q9UREC", JdeDataType.Numeric),
        new JdeField("Q9UOM", "Q9UOM", JdeDataType.String, 4),
        new JdeField("Q9YEXA", "Q9YEXA", JdeDataType.Numeric),
        new JdeField("Q9ASVL", "Q9ASVL", JdeDataType.Numeric),
        new JdeField("Q9AN8", "Q9AN8", JdeDataType.Numeric),
        new JdeField("Q9RCDJ", "Q9RCDJ", JdeDataType.Numeric),
        new JdeField("Q9RCTM", "Q9RCTM", JdeDataType.Numeric),
        new JdeField("Q9YD3D", "Q9YD3D", JdeDataType.Numeric, null, true, true),
        new JdeField("Q9YCHN", "Q9YCHN", JdeDataType.String, 40),
        new JdeField("Q9MCU", "Q9MCU", JdeDataType.String, 24),
        new JdeField("Q9LOCN", "Q9LOCN", JdeDataType.String, 40),
        new JdeField("Q9LOTN", "Q9LOTN", JdeDataType.String, 60),
        new JdeField("Q9RMK", "Q9RMK", JdeDataType.String, 60),
        new JdeField("Q9RWQT", "Q9RWQT", JdeDataType.Numeric),
        new JdeField("Q9CPIT", "Q9CPIT", JdeDataType.Numeric),
        new JdeField("Q9TRQT", "Q9TRQT", JdeDataType.Numeric),
        new JdeField("Q9DSC", "Q9DSC", JdeDataType.String, 60),
        new JdeField("Q9QTY1", "Q9QTY1", JdeDataType.Numeric),
        new JdeField("Q9DSC1", "Q9DSC1", JdeDataType.String, 60),
        new JdeField("Q9DSC2", "Q9DSC2", JdeDataType.String, 60),
        new JdeField("Q9YD3T", "Q9YD3T", JdeDataType.String, 4),
        new JdeField("Q9YD3N", "Q9YD3N", JdeDataType.Numeric),
        new JdeField("Q9RBDJ", "Q9RBDJ", JdeDataType.Numeric),
        new JdeField("Q9PNTF", "Q9PNTF", JdeDataType.String, 2),
        new JdeField("Q9MATC", "Q9MATC", JdeDataType.String, 2),
        new JdeField("Q9USER", "Q9USER", JdeDataType.String, 20),
        new JdeField("Q9PID", "Q9PID", JdeDataType.String, 20),
        new JdeField("Q9JOBN", "Q9JOBN", JdeDataType.String, 20),
        new JdeField("Q9TDAY", "Q9TDAY", JdeDataType.Numeric),
        new JdeField("Q9UPMJ", "Q9UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I346_0", "Primary Key on Q9YEXU, Q9YD3D, Q9KCOO, Q9DOCO, Q9DCTO, Q9LNID, Q9KCO, Q9DOC, Q9DCT", new[] { "Q9YEXU", "Q9YD3D", "Q9KCOO", "Q9DOCO", "Q9DCTO", "Q9LNID", "Q9KCO", "Q9DOC", "Q9DCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I346_3", "Index on Q9DOCO, Q9DCTO, Q9KCOO, Q9LNID", new[] { "Q9DOCO", "Q9DCTO", "Q9KCOO", "Q9LNID" }),
        new JdeIndex("F75I346_4", "Index on Q9YEXU, Q9YD3N", new[] { "Q9YEXU", "Q9YD3N" })
    };
}
