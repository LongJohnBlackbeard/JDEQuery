using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1511H - .
/// </summary>
public class F1511H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N#GENT.
        /// </summary>
        public const string N_GENT = "N#GENT";

        /// <summary>
        /// N#ICU.
        /// </summary>
        public const string N_ICU = "N#ICU";

        /// <summary>
        /// N#DOC.
        /// </summary>
        public const string N_DOC = "N#DOC";

        /// <summary>
        /// N#SFX.
        /// </summary>
        public const string N_SFX = "N#SFX";

        /// <summary>
        /// N#DOCO.
        /// </summary>
        public const string N_DOCO = "N#DOCO";

        /// <summary>
        /// N#DCTO.
        /// </summary>
        public const string N_DCTO = "N#DCTO";

        /// <summary>
        /// N#SOSQ.
        /// </summary>
        public const string N_SOSQ = "N#SOSQ";

        /// <summary>
        /// N#MCUS.
        /// </summary>
        public const string N_MCUS = "N#MCUS";

        /// <summary>
        /// N#AN8.
        /// </summary>
        public const string N_AN8 = "N#AN8";

        /// <summary>
        /// N#AN8J.
        /// </summary>
        public const string N_AN8J = "N#AN8J";

        /// <summary>
        /// N#DL01.
        /// </summary>
        public const string N_DL01 = "N#DL01";

        /// <summary>
        /// N#MCU.
        /// </summary>
        public const string N_MCU = "N#MCU";

        /// <summary>
        /// N#OBJ.
        /// </summary>
        public const string N_OBJ = "N#OBJ";

        /// <summary>
        /// N#SUB.
        /// </summary>
        public const string N_SUB = "N#SUB";

        /// <summary>
        /// N#SBL.
        /// </summary>
        public const string N_SBL = "N#SBL";

        /// <summary>
        /// N#AID.
        /// </summary>
        public const string N_AID = "N#AID";

        /// <summary>
        /// N#CO.
        /// </summary>
        public const string N_CO = "N#CO";

        /// <summary>
        /// N#DG.
        /// </summary>
        public const string N_DG = "N#DG";

        /// <summary>
        /// N#DSV.
        /// </summary>
        public const string N_DSV = "N#DSV";

        /// <summary>
        /// N#GLC.
        /// </summary>
        public const string N_GLC = "N#GLC";

        /// <summary>
        /// N#BPN.
        /// </summary>
        public const string N_BPN = "N#BPN";

        /// <summary>
        /// N#YR.
        /// </summary>
        public const string N_YR = "N#YR";

        /// <summary>
        /// N#AG.
        /// </summary>
        public const string N_AG = "N#AG";

        /// <summary>
        /// N#AN01.
        /// </summary>
        public const string N_AN01 = "N#AN01";

        /// <summary>
        /// N#DI.
        /// </summary>
        public const string N_DI = "N#DI";

        /// <summary>
        /// N#DD.
        /// </summary>
        public const string N_DD = "N#DD";

        /// <summary>
        /// N#PTC.
        /// </summary>
        public const string N_PTC = "N#PTC";

        /// <summary>
        /// N#TRAN.
        /// </summary>
        public const string N_TRAN = "N#TRAN";

        /// <summary>
        /// N#SEPI.
        /// </summary>
        public const string N_SEPI = "N#SEPI";

        /// <summary>
        /// N#ITMG.
        /// </summary>
        public const string N_ITMG = "N#ITMG";

        /// <summary>
        /// N#LNID.
        /// </summary>
        public const string N_LNID = "N#LNID";

        /// <summary>
        /// N#DIC.
        /// </summary>
        public const string N_DIC = "N#DIC";

        /// <summary>
        /// N#PDUE.
        /// </summary>
        public const string N_PDUE = "N#PDUE";

        /// <summary>
        /// N#EPCL.
        /// </summary>
        public const string N_EPCL = "N#EPCL";

        /// <summary>
        /// N#DPER.
        /// </summary>
        public const string N_DPER = "N#DPER";

        /// <summary>
        /// N#DPAR.
        /// </summary>
        public const string N_DPAR = "N#DPAR";

        /// <summary>
        /// N#EXCD.
        /// </summary>
        public const string N_EXCD = "N#EXCD";

        /// <summary>
        /// N#BCI.
        /// </summary>
        public const string N_BCI = "N#BCI";

        /// <summary>
        /// N#PRDC.
        /// </summary>
        public const string N_PRDC = "N#PRDC";

        /// <summary>
        /// N#YRO.
        /// </summary>
        public const string N_YRO = "N#YRO";

        /// <summary>
        /// N#CTRY.
        /// </summary>
        public const string N_CTRY = "N#CTRY";

        /// <summary>
        /// N#RPRD.
        /// </summary>
        public const string N_RPRD = "N#RPRD";

        /// <summary>
        /// N#CRCD.
        /// </summary>
        public const string N_CRCD = "N#CRCD";

        /// <summary>
        /// N#CRR.
        /// </summary>
        public const string N_CRR = "N#CRR";

        /// <summary>
        /// N#ACR.
        /// </summary>
        public const string N_ACR = "N#ACR";

        /// <summary>
        /// N#TXA1.
        /// </summary>
        public const string N_TXA1 = "N#TXA1";

        /// <summary>
        /// N#EXR1.
        /// </summary>
        public const string N_EXR1 = "N#EXR1";

        /// <summary>
        /// N#STAM.
        /// </summary>
        public const string N_STAM = "N#STAM";

        /// <summary>
        /// N#ATXN.
        /// </summary>
        public const string N_ATXN = "N#ATXN";

        /// <summary>
        /// N#ATXA.
        /// </summary>
        public const string N_ATXA = "N#ATXA";

        /// <summary>
        /// N#USER.
        /// </summary>
        public const string N_USER = "N#USER";

        /// <summary>
        /// N#UPMJ.
        /// </summary>
        public const string N_UPMJ = "N#UPMJ";

        /// <summary>
        /// N#PID.
        /// </summary>
        public const string N_PID = "N#PID";

        /// <summary>
        /// N#JOBN.
        /// </summary>
        public const string N_JOBN = "N#JOBN";

        /// <summary>
        /// N#SBLT.
        /// </summary>
        public const string N_SBLT = "N#SBLT";

        /// <summary>
        /// N#CRRM.
        /// </summary>
        public const string N_CRRM = "N#CRRM";

        /// <summary>
        /// N#FAP.
        /// </summary>
        public const string N_FAP = "N#FAP";

        /// <summary>
        /// N#CDS.
        /// </summary>
        public const string N_CDS = "N#CDS";

        /// <summary>
        /// N#CDSA.
        /// </summary>
        public const string N_CDSA = "N#CDSA";

        /// <summary>
        /// N#CTAM.
        /// </summary>
        public const string N_CTAM = "N#CTAM";

        /// <summary>
        /// N#CTXA.
        /// </summary>
        public const string N_CTXA = "N#CTXA";

        /// <summary>
        /// N#CTXN.
        /// </summary>
        public const string N_CTXN = "N#CTXN";

        /// <summary>
        /// N#MI.
        /// </summary>
        public const string N_MI = "N#MI";

        /// <summary>
        /// N#DBAN.
        /// </summary>
        public const string N_DBAN = "N#DBAN";

        /// <summary>
        /// N#UNIT.
        /// </summary>
        public const string N_UNIT = "N#UNIT";

        /// <summary>
        /// N#BLMR.
        /// </summary>
        public const string N_BLMR = "N#BLMR";

        /// <summary>
        /// N#EFFC.
        /// </summary>
        public const string N_EFFC = "N#EFFC";

        /// <summary>
        /// N#SOBT.
        /// </summary>
        public const string N_SOBT = "N#SOBT";

        /// <summary>
        /// N#SBJR.
        /// </summary>
        public const string N_SBJR = "N#SBJR";

        /// <summary>
        /// N#ICB1.
        /// </summary>
        public const string N_ICB1 = "N#ICB1";

        /// <summary>
        /// N#ICB2.
        /// </summary>
        public const string N_ICB2 = "N#ICB2";

        /// <summary>
        /// N#ICB3.
        /// </summary>
        public const string N_ICB3 = "N#ICB3";

        /// <summary>
        /// N#ICB4.
        /// </summary>
        public const string N_ICB4 = "N#ICB4";

        /// <summary>
        /// N#ICB5.
        /// </summary>
        public const string N_ICB5 = "N#ICB5";

        /// <summary>
        /// N#INVP.
        /// </summary>
        public const string N_INVP = "N#INVP";

        /// <summary>
        /// N#PRRB.
        /// </summary>
        public const string N_PRRB = "N#PRRB";

        /// <summary>
        /// N#BCIR.
        /// </summary>
        public const string N_BCIR = "N#BCIR";

        /// <summary>
        /// N#ICBC.
        /// </summary>
        public const string N_ICBC = "N#ICBC";

        /// <summary>
        /// N#IST.
        /// </summary>
        public const string N_IST = "N#IST";

        /// <summary>
        /// N#SOTY.
        /// </summary>
        public const string N_SOTY = "N#SOTY";

        /// <summary>
        /// N#ODOC.
        /// </summary>
        public const string N_ODOC = "N#ODOC";

        /// <summary>
        /// N#ODCT.
        /// </summary>
        public const string N_ODCT = "N#ODCT";

        /// <summary>
        /// N#OSFX.
        /// </summary>
        public const string N_OSFX = "N#OSFX";

        /// <summary>
        /// N#UPMT.
        /// </summary>
        public const string N_UPMT = "N#UPMT";

        /// <summary>
        /// N#KCO.
        /// </summary>
        public const string N_KCO = "N#KCO";

        /// <summary>
        /// N#OKCO.
        /// </summary>
        public const string N_OKCO = "N#OKCO";
    }

    /// <inheritdoc />
    public override string TableName => "F1511H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N#GENT", "N#GENT", JdeDataType.String, 2, true, true),
        new JdeField("N#ICU", "N#ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("N#DOC", "N#DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("N#SFX", "N#SFX", JdeDataType.String, 6, true, true),
        new JdeField("N#DOCO", "N#DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N#DCTO", "N#DCTO", JdeDataType.String, 4),
        new JdeField("N#SOSQ", "N#SOSQ", JdeDataType.Numeric),
        new JdeField("N#MCUS", "N#MCUS", JdeDataType.String, 24),
        new JdeField("N#AN8", "N#AN8", JdeDataType.Numeric),
        new JdeField("N#AN8J", "N#AN8J", JdeDataType.Numeric),
        new JdeField("N#DL01", "N#DL01", JdeDataType.String, 60),
        new JdeField("N#MCU", "N#MCU", JdeDataType.String, 24),
        new JdeField("N#OBJ", "N#OBJ", JdeDataType.String, 12),
        new JdeField("N#SUB", "N#SUB", JdeDataType.String, 16),
        new JdeField("N#SBL", "N#SBL", JdeDataType.String, 16),
        new JdeField("N#AID", "N#AID", JdeDataType.String, 16),
        new JdeField("N#CO", "N#CO", JdeDataType.String, 10),
        new JdeField("N#DG", "N#DG", JdeDataType.Numeric),
        new JdeField("N#DSV", "N#DSV", JdeDataType.Numeric),
        new JdeField("N#GLC", "N#GLC", JdeDataType.String, 8),
        new JdeField("N#BPN", "N#BPN", JdeDataType.Numeric, null, true, true),
        new JdeField("N#YR", "N#YR", JdeDataType.Numeric, null, true, true),
        new JdeField("N#AG", "N#AG", JdeDataType.Numeric),
        new JdeField("N#AN01", "N#AN01", JdeDataType.Numeric),
        new JdeField("N#DI", "N#DI", JdeDataType.Numeric),
        new JdeField("N#DD", "N#DD", JdeDataType.Numeric),
        new JdeField("N#PTC", "N#PTC", JdeDataType.String, 6),
        new JdeField("N#TRAN", "N#TRAN", JdeDataType.String, 2),
        new JdeField("N#SEPI", "N#SEPI", JdeDataType.String, 2),
        new JdeField("N#ITMG", "N#ITMG", JdeDataType.String, 6),
        new JdeField("N#LNID", "N#LNID", JdeDataType.Numeric),
        new JdeField("N#DIC", "N#DIC", JdeDataType.Numeric),
        new JdeField("N#PDUE", "N#PDUE", JdeDataType.Numeric),
        new JdeField("N#EPCL", "N#EPCL", JdeDataType.String, 8),
        new JdeField("N#DPER", "N#DPER", JdeDataType.Numeric),
        new JdeField("N#DPAR", "N#DPAR", JdeDataType.Numeric),
        new JdeField("N#EXCD", "N#EXCD", JdeDataType.String, 2),
        new JdeField("N#BCI", "N#BCI", JdeDataType.Numeric, null, true, true),
        new JdeField("N#PRDC", "N#PRDC", JdeDataType.String, 8),
        new JdeField("N#YRO", "N#YRO", JdeDataType.Numeric),
        new JdeField("N#CTRY", "N#CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("N#RPRD", "N#RPRD", JdeDataType.Numeric),
        new JdeField("N#CRCD", "N#CRCD", JdeDataType.String, 6),
        new JdeField("N#CRR", "N#CRR", JdeDataType.Numeric),
        new JdeField("N#ACR", "N#ACR", JdeDataType.Numeric),
        new JdeField("N#TXA1", "N#TXA1", JdeDataType.String, 20),
        new JdeField("N#EXR1", "N#EXR1", JdeDataType.String, 4),
        new JdeField("N#STAM", "N#STAM", JdeDataType.Numeric),
        new JdeField("N#ATXN", "N#ATXN", JdeDataType.Numeric),
        new JdeField("N#ATXA", "N#ATXA", JdeDataType.Numeric),
        new JdeField("N#USER", "N#USER", JdeDataType.String, 20),
        new JdeField("N#UPMJ", "N#UPMJ", JdeDataType.Numeric),
        new JdeField("N#PID", "N#PID", JdeDataType.String, 20),
        new JdeField("N#JOBN", "N#JOBN", JdeDataType.String, 20),
        new JdeField("N#SBLT", "N#SBLT", JdeDataType.String, 2),
        new JdeField("N#CRRM", "N#CRRM", JdeDataType.String, 2),
        new JdeField("N#FAP", "N#FAP", JdeDataType.Numeric),
        new JdeField("N#CDS", "N#CDS", JdeDataType.Numeric),
        new JdeField("N#CDSA", "N#CDSA", JdeDataType.Numeric),
        new JdeField("N#CTAM", "N#CTAM", JdeDataType.Numeric),
        new JdeField("N#CTXA", "N#CTXA", JdeDataType.Numeric),
        new JdeField("N#CTXN", "N#CTXN", JdeDataType.Numeric),
        new JdeField("N#MI", "N#MI", JdeDataType.String, 2),
        new JdeField("N#DBAN", "N#DBAN", JdeDataType.Numeric),
        new JdeField("N#UNIT", "N#UNIT", JdeDataType.String, 16),
        new JdeField("N#BLMR", "N#BLMR", JdeDataType.String, 2),
        new JdeField("N#EFFC", "N#EFFC", JdeDataType.String, 2),
        new JdeField("N#SOBT", "N#SOBT", JdeDataType.String, 4, true, true),
        new JdeField("N#SBJR", "N#SBJR", JdeDataType.String, 2),
        new JdeField("N#ICB1", "N#ICB1", JdeDataType.String, 24),
        new JdeField("N#ICB2", "N#ICB2", JdeDataType.String, 24),
        new JdeField("N#ICB3", "N#ICB3", JdeDataType.String, 24),
        new JdeField("N#ICB4", "N#ICB4", JdeDataType.String, 24),
        new JdeField("N#ICB5", "N#ICB5", JdeDataType.String, 24),
        new JdeField("N#INVP", "N#INVP", JdeDataType.String, 2),
        new JdeField("N#PRRB", "N#PRRB", JdeDataType.String, 2),
        new JdeField("N#BCIR", "N#BCIR", JdeDataType.Numeric),
        new JdeField("N#ICBC", "N#ICBC", JdeDataType.String, 4),
        new JdeField("N#IST", "N#IST", JdeDataType.String, 2),
        new JdeField("N#SOTY", "N#SOTY", JdeDataType.String, 4),
        new JdeField("N#ODOC", "N#ODOC", JdeDataType.Numeric),
        new JdeField("N#ODCT", "N#ODCT", JdeDataType.String, 4),
        new JdeField("N#OSFX", "N#OSFX", JdeDataType.String, 6),
        new JdeField("N#UPMT", "N#UPMT", JdeDataType.Numeric),
        new JdeField("N#KCO", "N#KCO", JdeDataType.String, 10),
        new JdeField("N#OKCO", "N#OKCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1511H_0", "Primary Key on N#DOCO, N#GENT, N#CTRY, N#YR, N#BPN, N#SOBT, N#BCI, N#ICU, N#DOC, N#SFX", new[] { "N#DOCO", "N#GENT", "N#CTRY", "N#YR", "N#BPN", "N#SOBT", "N#BCI", "N#ICU", "N#DOC", "N#SFX" }, isUnique: true, isPrimaryKey: true)
    };
}
