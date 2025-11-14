using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C575 - .
/// </summary>
public class F76C575 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q1ICU.
        /// </summary>
        public const string Q1ICU = "Q1ICU";

        /// <summary>
        /// Q1ICUT.
        /// </summary>
        public const string Q1ICUT = "Q1ICUT";

        /// <summary>
        /// Q1CTRY.
        /// </summary>
        public const string Q1CTRY = "Q1CTRY";

        /// <summary>
        /// Q1FY.
        /// </summary>
        public const string Q1FY = "Q1FY";

        /// <summary>
        /// Q1CO.
        /// </summary>
        public const string Q1CO = "Q1CO";

        /// <summary>
        /// Q1LT.
        /// </summary>
        public const string Q1LT = "Q1LT";

        /// <summary>
        /// Q1DCT.
        /// </summary>
        public const string Q1DCT = "Q1DCT";

        /// <summary>
        /// Q1DOC.
        /// </summary>
        public const string Q1DOC = "Q1DOC";

        /// <summary>
        /// Q1SFX.
        /// </summary>
        public const string Q1SFX = "Q1SFX";

        /// <summary>
        /// Q1VINV.
        /// </summary>
        public const string Q1VINV = "Q1VINV";

        /// <summary>
        /// Q1AN8.
        /// </summary>
        public const string Q1AN8 = "Q1AN8";

        /// <summary>
        /// Q1PN.
        /// </summary>
        public const string Q1PN = "Q1PN";

        /// <summary>
        /// Q1DGJ.
        /// </summary>
        public const string Q1DGJ = "Q1DGJ";

        /// <summary>
        /// Q1DSVJ.
        /// </summary>
        public const string Q1DSVJ = "Q1DSVJ";

        /// <summary>
        /// Q1JELN.
        /// </summary>
        public const string Q1JELN = "Q1JELN";

        /// <summary>
        /// Q1MCU.
        /// </summary>
        public const string Q1MCU = "Q1MCU";

        /// <summary>
        /// Q1OBJ.
        /// </summary>
        public const string Q1OBJ = "Q1OBJ";

        /// <summary>
        /// Q1SUB.
        /// </summary>
        public const string Q1SUB = "Q1SUB";

        /// <summary>
        /// Q1SBL.
        /// </summary>
        public const string Q1SBL = "Q1SBL";

        /// <summary>
        /// Q1SBLT.
        /// </summary>
        public const string Q1SBLT = "Q1SBLT";

        /// <summary>
        /// Q1C76JCN.
        /// </summary>
        public const string Q1C76JCN = "Q1C76JCN";

        /// <summary>
        /// Q1C76JCD.
        /// </summary>
        public const string Q1C76JCD = "Q1C76JCD";

        /// <summary>
        /// Q1C76JCB.
        /// </summary>
        public const string Q1C76JCB = "Q1C76JCB";

        /// <summary>
        /// Q1C76JCI.
        /// </summary>
        public const string Q1C76JCI = "Q1C76JCI";

        /// <summary>
        /// Q1C76RT.
        /// </summary>
        public const string Q1C76RT = "Q1C76RT";

        /// <summary>
        /// Q1C76JCS.
        /// </summary>
        public const string Q1C76JCS = "Q1C76JCS";

        /// <summary>
        /// Q1C76JCA.
        /// </summary>
        public const string Q1C76JCA = "Q1C76JCA";

        /// <summary>
        /// Q1ALT6.
        /// </summary>
        public const string Q1ALT6 = "Q1ALT6";

        /// <summary>
        /// Q1TAXC.
        /// </summary>
        public const string Q1TAXC = "Q1TAXC";

        /// <summary>
        /// Q1C76TPF.
        /// </summary>
        public const string Q1C76TPF = "Q1C76TPF";

        /// <summary>
        /// Q1C76PRF.
        /// </summary>
        public const string Q1C76PRF = "Q1C76PRF";

        /// <summary>
        /// Q1C76FT1.
        /// </summary>
        public const string Q1C76FT1 = "Q1C76FT1";

        /// <summary>
        /// Q1C76FT2.
        /// </summary>
        public const string Q1C76FT2 = "Q1C76FT2";

        /// <summary>
        /// Q1C76NOE.
        /// </summary>
        public const string Q1C76NOE = "Q1C76NOE";

        /// <summary>
        /// Q1CBNK.
        /// </summary>
        public const string Q1CBNK = "Q1CBNK";

        /// <summary>
        /// Q1C76MPO.
        /// </summary>
        public const string Q1C76MPO = "Q1C76MPO";

        /// <summary>
        /// Q1C76CN1.
        /// </summary>
        public const string Q1C76CN1 = "Q1C76CN1";

        /// <summary>
        /// Q1MATH10.
        /// </summary>
        public const string Q1MATH10 = "Q1MATH10";

        /// <summary>
        /// Q1USER.
        /// </summary>
        public const string Q1USER = "Q1USER";

        /// <summary>
        /// Q1PID.
        /// </summary>
        public const string Q1PID = "Q1PID";

        /// <summary>
        /// Q1JOBN.
        /// </summary>
        public const string Q1JOBN = "Q1JOBN";

        /// <summary>
        /// Q1UPMJ.
        /// </summary>
        public const string Q1UPMJ = "Q1UPMJ";

        /// <summary>
        /// Q1C76DIR.
        /// </summary>
        public const string Q1C76DIR = "Q1C76DIR";

        /// <summary>
        /// Q1COGR.
        /// </summary>
        public const string Q1COGR = "Q1COGR";

        /// <summary>
        /// Q1CAEC.
        /// </summary>
        public const string Q1CAEC = "Q1CAEC";

        /// <summary>
        /// Q1ODOC.
        /// </summary>
        public const string Q1ODOC = "Q1ODOC";

        /// <summary>
        /// Q1ODCT.
        /// </summary>
        public const string Q1ODCT = "Q1ODCT";

        /// <summary>
        /// Q1TXA1.
        /// </summary>
        public const string Q1TXA1 = "Q1TXA1";

        /// <summary>
        /// Q1EXR1.
        /// </summary>
        public const string Q1EXR1 = "Q1EXR1";

        /// <summary>
        /// Q1UPMT.
        /// </summary>
        public const string Q1UPMT = "Q1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C575";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q1ICU", "Q1ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1ICUT", "Q1ICUT", JdeDataType.String, 4, true, true),
        new JdeField("Q1CTRY", "Q1CTRY", JdeDataType.Numeric),
        new JdeField("Q1FY", "Q1FY", JdeDataType.Numeric),
        new JdeField("Q1CO", "Q1CO", JdeDataType.String, 10, true, true),
        new JdeField("Q1LT", "Q1LT", JdeDataType.String, 4),
        new JdeField("Q1DCT", "Q1DCT", JdeDataType.String, 4, true, true),
        new JdeField("Q1DOC", "Q1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1SFX", "Q1SFX", JdeDataType.String, 6),
        new JdeField("Q1VINV", "Q1VINV", JdeDataType.String, 50),
        new JdeField("Q1AN8", "Q1AN8", JdeDataType.Numeric),
        new JdeField("Q1PN", "Q1PN", JdeDataType.Numeric),
        new JdeField("Q1DGJ", "Q1DGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1DSVJ", "Q1DSVJ", JdeDataType.Numeric),
        new JdeField("Q1JELN", "Q1JELN", JdeDataType.Numeric, null, true, true),
        new JdeField("Q1MCU", "Q1MCU", JdeDataType.String, 24),
        new JdeField("Q1OBJ", "Q1OBJ", JdeDataType.String, 12),
        new JdeField("Q1SUB", "Q1SUB", JdeDataType.String, 16),
        new JdeField("Q1SBL", "Q1SBL", JdeDataType.String, 16),
        new JdeField("Q1SBLT", "Q1SBLT", JdeDataType.String, 2),
        new JdeField("Q1C76JCN", "Q1C76JCN", JdeDataType.Numeric),
        new JdeField("Q1C76JCD", "Q1C76JCD", JdeDataType.String, 2),
        new JdeField("Q1C76JCB", "Q1C76JCB", JdeDataType.Numeric),
        new JdeField("Q1C76JCI", "Q1C76JCI", JdeDataType.Numeric),
        new JdeField("Q1C76RT", "Q1C76RT", JdeDataType.String, 6, true, true),
        new JdeField("Q1C76JCS", "Q1C76JCS", JdeDataType.String, 6, true, true),
        new JdeField("Q1C76JCA", "Q1C76JCA", JdeDataType.String, 120),
        new JdeField("Q1ALT6", "Q1ALT6", JdeDataType.String, 2),
        new JdeField("Q1TAXC", "Q1TAXC", JdeDataType.String, 2),
        new JdeField("Q1C76TPF", "Q1C76TPF", JdeDataType.Numeric),
        new JdeField("Q1C76PRF", "Q1C76PRF", JdeDataType.String, 18),
        new JdeField("Q1C76FT1", "Q1C76FT1", JdeDataType.Numeric),
        new JdeField("Q1C76FT2", "Q1C76FT2", JdeDataType.Numeric),
        new JdeField("Q1C76NOE", "Q1C76NOE", JdeDataType.String, 30),
        new JdeField("Q1CBNK", "Q1CBNK", JdeDataType.String, 40),
        new JdeField("Q1C76MPO", "Q1C76MPO", JdeDataType.Numeric),
        new JdeField("Q1C76CN1", "Q1C76CN1", JdeDataType.Numeric),
        new JdeField("Q1MATH10", "Q1MATH10", JdeDataType.Numeric),
        new JdeField("Q1USER", "Q1USER", JdeDataType.String, 20),
        new JdeField("Q1PID", "Q1PID", JdeDataType.String, 20),
        new JdeField("Q1JOBN", "Q1JOBN", JdeDataType.String, 20),
        new JdeField("Q1UPMJ", "Q1UPMJ", JdeDataType.Numeric),
        new JdeField("Q1C76DIR", "Q1C76DIR", JdeDataType.String, 80),
        new JdeField("Q1COGR", "Q1COGR", JdeDataType.String, 4),
        new JdeField("Q1CAEC", "Q1CAEC", JdeDataType.Numeric),
        new JdeField("Q1ODOC", "Q1ODOC", JdeDataType.Numeric),
        new JdeField("Q1ODCT", "Q1ODCT", JdeDataType.String, 4),
        new JdeField("Q1TXA1", "Q1TXA1", JdeDataType.String, 20),
        new JdeField("Q1EXR1", "Q1EXR1", JdeDataType.String, 4),
        new JdeField("Q1UPMT", "Q1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C575_0", "Primary Key on Q1CO, Q1ICUT, Q1ICU, Q1JELN, Q1DCT, Q1DOC, Q1DGJ, Q1C76RT, Q1C76JCS", new[] { "Q1CO", "Q1ICUT", "Q1ICU", "Q1JELN", "Q1DCT", "Q1DOC", "Q1DGJ", "Q1C76RT", "Q1C76JCS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C575_2", "Index on Q1CO, Q1C76JCN, Q1DCT, Q1DOC, Q1JELN", new[] { "Q1CO", "Q1C76JCN", "Q1DCT", "Q1DOC", "Q1JELN" }),
        new JdeIndex("F76C575_3", "Index on Q1CO, Q1C76JCN, Q1COGR, Q1C76RT, Q1C76JCS", new[] { "Q1CO", "Q1C76JCN", "Q1COGR", "Q1C76RT", "Q1C76JCS" }),
        new JdeIndex("F76C575_4", "Index on Q1COGR, Q1C76JCN", new[] { "Q1COGR", "Q1C76JCN" }),
        new JdeIndex("F76C575_6", "Index on Q1OBJ, Q1SUB, Q1ICUT, Q1DCT", new[] { "Q1OBJ", "Q1SUB", "Q1ICUT", "Q1DCT" }),
        new JdeIndex("F76C575_7", "Index on Q1ICU, Q1ICUT, Q1CO, Q1DCT, Q1DOC, Q1DGJ, Q1JELN, Q1AN8", new[] { "Q1ICU", "Q1ICUT", "Q1CO", "Q1DCT", "Q1DOC", "Q1DGJ", "Q1JELN", "Q1AN8" }),
        new JdeIndex("F76C575_8", "Index on Q1ICU, Q1ICUT, Q1CO, Q1DCT, Q1DOC, Q1DGJ, Q1JELN", new[] { "Q1ICU", "Q1ICUT", "Q1CO", "Q1DCT", "Q1DOC", "Q1DGJ", "Q1JELN" }),
        new JdeIndex("F76C575_9", "Index on Q1COGR, Q1C76JCN, Q1C76RT", new[] { "Q1COGR", "Q1C76JCN", "Q1C76RT" })
    };
}
