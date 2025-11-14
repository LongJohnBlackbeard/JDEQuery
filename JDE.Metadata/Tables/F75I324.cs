using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I324 - .
/// </summary>
public class F75I324 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3KCO.
        /// </summary>
        public const string Q3KCO = "Q3KCO";

        /// <summary>
        /// Q3DOC.
        /// </summary>
        public const string Q3DOC = "Q3DOC";

        /// <summary>
        /// Q3DCT.
        /// </summary>
        public const string Q3DCT = "Q3DCT";

        /// <summary>
        /// Q3LNID.
        /// </summary>
        public const string Q3LNID = "Q3LNID";

        /// <summary>
        /// Q3AST.
        /// </summary>
        public const string Q3AST = "Q3AST";

        /// <summary>
        /// Q3YCHN.
        /// </summary>
        public const string Q3YCHN = "Q3YCHN";

        /// <summary>
        /// Q3KCOO.
        /// </summary>
        public const string Q3KCOO = "Q3KCOO";

        /// <summary>
        /// Q3DOCO.
        /// </summary>
        public const string Q3DOCO = "Q3DOCO";

        /// <summary>
        /// Q3DCTO.
        /// </summary>
        public const string Q3DCTO = "Q3DCTO";

        /// <summary>
        /// Q3MCU.
        /// </summary>
        public const string Q3MCU = "Q3MCU";

        /// <summary>
        /// Q3CO.
        /// </summary>
        public const string Q3CO = "Q3CO";

        /// <summary>
        /// Q3ITM.
        /// </summary>
        public const string Q3ITM = "Q3ITM";

        /// <summary>
        /// Q3LITM.
        /// </summary>
        public const string Q3LITM = "Q3LITM";

        /// <summary>
        /// Q3FVTR.
        /// </summary>
        public const string Q3FVTR = "Q3FVTR";

        /// <summary>
        /// Q3I75TAXA.
        /// </summary>
        public const string Q3I75TAXA = "Q3I75TAXA";

        /// <summary>
        /// Q3I75TXR.
        /// </summary>
        public const string Q3I75TXR = "Q3I75TXR";

        /// <summary>
        /// Q3I75TXRG.
        /// </summary>
        public const string Q3I75TXRG = "Q3I75TXRG";

        /// <summary>
        /// Q3I75TXTY.
        /// </summary>
        public const string Q3I75TXTY = "Q3I75TXTY";

        /// <summary>
        /// Q3AA1.
        /// </summary>
        public const string Q3AA1 = "Q3AA1";

        /// <summary>
        /// Q3AA2.
        /// </summary>
        public const string Q3AA2 = "Q3AA2";

        /// <summary>
        /// Q3AA3.
        /// </summary>
        public const string Q3AA3 = "Q3AA3";

        /// <summary>
        /// Q3DL01.
        /// </summary>
        public const string Q3DL01 = "Q3DL01";

        /// <summary>
        /// Q3DS01.
        /// </summary>
        public const string Q3DS01 = "Q3DS01";

        /// <summary>
        /// Q3DTE.
        /// </summary>
        public const string Q3DTE = "Q3DTE";

        /// <summary>
        /// Q3FLAG.
        /// </summary>
        public const string Q3FLAG = "Q3FLAG";

        /// <summary>
        /// Q3FFU2.
        /// </summary>
        public const string Q3FFU2 = "Q3FFU2";

        /// <summary>
        /// Q3INT01.
        /// </summary>
        public const string Q3INT01 = "Q3INT01";

        /// <summary>
        /// Q3USER.
        /// </summary>
        public const string Q3USER = "Q3USER";

        /// <summary>
        /// Q3JOBN.
        /// </summary>
        public const string Q3JOBN = "Q3JOBN";

        /// <summary>
        /// Q3UPMJ.
        /// </summary>
        public const string Q3UPMJ = "Q3UPMJ";

        /// <summary>
        /// Q3UPMT.
        /// </summary>
        public const string Q3UPMT = "Q3UPMT";

        /// <summary>
        /// Q3PID.
        /// </summary>
        public const string Q3PID = "Q3PID";
    }

    /// <inheritdoc />
    public override string TableName => "F75I324";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3KCO", "Q3KCO", JdeDataType.String, 10, true, true),
        new JdeField("Q3DOC", "Q3DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3DCT", "Q3DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q3LNID", "Q3LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3AST", "Q3AST", JdeDataType.String, 16, true, true),
        new JdeField("Q3YCHN", "Q3YCHN", JdeDataType.String, 40),
        new JdeField("Q3KCOO", "Q3KCOO", JdeDataType.String, 10),
        new JdeField("Q3DOCO", "Q3DOCO", JdeDataType.Numeric),
        new JdeField("Q3DCTO", "Q3DCTO", JdeDataType.String, 4),
        new JdeField("Q3MCU", "Q3MCU", JdeDataType.String, 24),
        new JdeField("Q3CO", "Q3CO", JdeDataType.String, 10),
        new JdeField("Q3ITM", "Q3ITM", JdeDataType.Numeric),
        new JdeField("Q3LITM", "Q3LITM", JdeDataType.String, 50),
        new JdeField("Q3FVTR", "Q3FVTR", JdeDataType.Numeric),
        new JdeField("Q3I75TAXA", "Q3I75TAXA", JdeDataType.Numeric),
        new JdeField("Q3I75TXR", "Q3I75TXR", JdeDataType.Numeric),
        new JdeField("Q3I75TXRG", "Q3I75TXRG", JdeDataType.String, 10),
        new JdeField("Q3I75TXTY", "Q3I75TXTY", JdeDataType.String, 10),
        new JdeField("Q3AA1", "Q3AA1", JdeDataType.Numeric),
        new JdeField("Q3AA2", "Q3AA2", JdeDataType.Numeric),
        new JdeField("Q3AA3", "Q3AA3", JdeDataType.Numeric),
        new JdeField("Q3DL01", "Q3DL01", JdeDataType.String, 60),
        new JdeField("Q3DS01", "Q3DS01", JdeDataType.String, 160),
        new JdeField("Q3DTE", "Q3DTE", JdeDataType.Numeric),
        new JdeField("Q3FLAG", "Q3FLAG", JdeDataType.String, 2),
        new JdeField("Q3FFU2", "Q3FFU2", JdeDataType.String, 2),
        new JdeField("Q3INT01", "Q3INT01", JdeDataType.Numeric),
        new JdeField("Q3USER", "Q3USER", JdeDataType.String, 20),
        new JdeField("Q3JOBN", "Q3JOBN", JdeDataType.String, 20),
        new JdeField("Q3UPMJ", "Q3UPMJ", JdeDataType.Numeric),
        new JdeField("Q3UPMT", "Q3UPMT", JdeDataType.Numeric),
        new JdeField("Q3PID", "Q3PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I324_0", "Primary Key on Q3KCO, Q3DOC, Q3DCT, Q3LNID, Q3AST", new[] { "Q3KCO", "Q3DOC", "Q3DCT", "Q3LNID", "Q3AST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I324_2", "Index on Q3KCO, Q3DOC, Q3DCT, Q3YCHN", new[] { "Q3KCO", "Q3DOC", "Q3DCT", "Q3YCHN" })
    };
}
