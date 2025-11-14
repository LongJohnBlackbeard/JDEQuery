using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502WB - .
/// </summary>
public class F1502WB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N4ICU.
        /// </summary>
        public const string N4ICU = "N4ICU";

        /// <summary>
        /// N4DOCO.
        /// </summary>
        public const string N4DOCO = "N4DOCO";

        /// <summary>
        /// N4LSVR.
        /// </summary>
        public const string N4LSVR = "N4LSVR";

        /// <summary>
        /// N4LSET.
        /// </summary>
        public const string N4LSET = "N4LSET";

        /// <summary>
        /// N4LNID.
        /// </summary>
        public const string N4LNID = "N4LNID";

        /// <summary>
        /// N4BLGR.
        /// </summary>
        public const string N4BLGR = "N4BLGR";

        /// <summary>
        /// N4TRAN.
        /// </summary>
        public const string N4TRAN = "N4TRAN";

        /// <summary>
        /// N4GLC.
        /// </summary>
        public const string N4GLC = "N4GLC";

        /// <summary>
        /// N4RMK.
        /// </summary>
        public const string N4RMK = "N4RMK";

        /// <summary>
        /// N4AG.
        /// </summary>
        public const string N4AG = "N4AG";

        /// <summary>
        /// N4EFTB.
        /// </summary>
        public const string N4EFTB = "N4EFTB";

        /// <summary>
        /// N4EFTE.
        /// </summary>
        public const string N4EFTE = "N4EFTE";

        /// <summary>
        /// N4BLFC.
        /// </summary>
        public const string N4BLFC = "N4BLFC";

        /// <summary>
        /// N4BF01.
        /// </summary>
        public const string N4BF01 = "N4BF01";

        /// <summary>
        /// N4BF02.
        /// </summary>
        public const string N4BF02 = "N4BF02";

        /// <summary>
        /// N4BF03.
        /// </summary>
        public const string N4BF03 = "N4BF03";

        /// <summary>
        /// N4BF04.
        /// </summary>
        public const string N4BF04 = "N4BF04";

        /// <summary>
        /// N4BF05.
        /// </summary>
        public const string N4BF05 = "N4BF05";

        /// <summary>
        /// N4BF06.
        /// </summary>
        public const string N4BF06 = "N4BF06";

        /// <summary>
        /// N4BF07.
        /// </summary>
        public const string N4BF07 = "N4BF07";

        /// <summary>
        /// N4BF08.
        /// </summary>
        public const string N4BF08 = "N4BF08";

        /// <summary>
        /// N4BF09.
        /// </summary>
        public const string N4BF09 = "N4BF09";

        /// <summary>
        /// N4BF10.
        /// </summary>
        public const string N4BF10 = "N4BF10";

        /// <summary>
        /// N4BF11.
        /// </summary>
        public const string N4BF11 = "N4BF11";

        /// <summary>
        /// N4BF12.
        /// </summary>
        public const string N4BF12 = "N4BF12";

        /// <summary>
        /// N4BF13.
        /// </summary>
        public const string N4BF13 = "N4BF13";

        /// <summary>
        /// N4MCU.
        /// </summary>
        public const string N4MCU = "N4MCU";

        /// <summary>
        /// N4SBL.
        /// </summary>
        public const string N4SBL = "N4SBL";

        /// <summary>
        /// N4AN8J.
        /// </summary>
        public const string N4AN8J = "N4AN8J";

        /// <summary>
        /// N4UNIT.
        /// </summary>
        public const string N4UNIT = "N4UNIT";

        /// <summary>
        /// N4SMCU.
        /// </summary>
        public const string N4SMCU = "N4SMCU";

        /// <summary>
        /// N4TRAR.
        /// </summary>
        public const string N4TRAR = "N4TRAR";

        /// <summary>
        /// N4SEPI.
        /// </summary>
        public const string N4SEPI = "N4SEPI";

        /// <summary>
        /// N4ITMG.
        /// </summary>
        public const string N4ITMG = "N4ITMG";

        /// <summary>
        /// N4SUSP.
        /// </summary>
        public const string N4SUSP = "N4SUSP";

        /// <summary>
        /// N4DEAL.
        /// </summary>
        public const string N4DEAL = "N4DEAL";

        /// <summary>
        /// N4RN01.
        /// </summary>
        public const string N4RN01 = "N4RN01";

        /// <summary>
        /// N4RN02.
        /// </summary>
        public const string N4RN02 = "N4RN02";

        /// <summary>
        /// N4RN03.
        /// </summary>
        public const string N4RN03 = "N4RN03";

        /// <summary>
        /// N4RN04.
        /// </summary>
        public const string N4RN04 = "N4RN04";

        /// <summary>
        /// N4RN05.
        /// </summary>
        public const string N4RN05 = "N4RN05";

        /// <summary>
        /// N4AGSN.
        /// </summary>
        public const string N4AGSN = "N4AGSN";

        /// <summary>
        /// N4GENT.
        /// </summary>
        public const string N4GENT = "N4GENT";

        /// <summary>
        /// N4BCI.
        /// </summary>
        public const string N4BCI = "N4BCI";

        /// <summary>
        /// N4CRCD.
        /// </summary>
        public const string N4CRCD = "N4CRCD";

        /// <summary>
        /// N4CRR.
        /// </summary>
        public const string N4CRR = "N4CRR";

        /// <summary>
        /// N4ACR.
        /// </summary>
        public const string N4ACR = "N4ACR";

        /// <summary>
        /// N4TXA1.
        /// </summary>
        public const string N4TXA1 = "N4TXA1";

        /// <summary>
        /// N4EXR1.
        /// </summary>
        public const string N4EXR1 = "N4EXR1";

        /// <summary>
        /// N4STAM.
        /// </summary>
        public const string N4STAM = "N4STAM";

        /// <summary>
        /// N4ATXN.
        /// </summary>
        public const string N4ATXN = "N4ATXN";

        /// <summary>
        /// N4ATXA.
        /// </summary>
        public const string N4ATXA = "N4ATXA";

        /// <summary>
        /// N4SBLT.
        /// </summary>
        public const string N4SBLT = "N4SBLT";

        /// <summary>
        /// N4CRRM.
        /// </summary>
        public const string N4CRRM = "N4CRRM";

        /// <summary>
        /// N4FAP.
        /// </summary>
        public const string N4FAP = "N4FAP";

        /// <summary>
        /// N4CDS.
        /// </summary>
        public const string N4CDS = "N4CDS";

        /// <summary>
        /// N4CDSA.
        /// </summary>
        public const string N4CDSA = "N4CDSA";

        /// <summary>
        /// N4CTAM.
        /// </summary>
        public const string N4CTAM = "N4CTAM";

        /// <summary>
        /// N4CTXA.
        /// </summary>
        public const string N4CTXA = "N4CTXA";

        /// <summary>
        /// N4CTXN.
        /// </summary>
        public const string N4CTXN = "N4CTXN";

        /// <summary>
        /// N4BCI2.
        /// </summary>
        public const string N4BCI2 = "N4BCI2";

        /// <summary>
        /// N4BPN.
        /// </summary>
        public const string N4BPN = "N4BPN";

        /// <summary>
        /// N4YR.
        /// </summary>
        public const string N4YR = "N4YR";

        /// <summary>
        /// N4BPN#.
        /// </summary>
        public const string N4BPN_ = "N4BPN#";

        /// <summary>
        /// N4TRBM.
        /// </summary>
        public const string N4TRBM = "N4TRBM";

        /// <summary>
        /// N4TRBY.
        /// </summary>
        public const string N4TRBY = "N4TRBY";

        /// <summary>
        /// N4TRB#.
        /// </summary>
        public const string N4TRB_ = "N4TRB#";

        /// <summary>
        /// N4TREM.
        /// </summary>
        public const string N4TREM = "N4TREM";

        /// <summary>
        /// N4TREY.
        /// </summary>
        public const string N4TREY = "N4TREY";

        /// <summary>
        /// N4TRE#.
        /// </summary>
        public const string N4TRE_ = "N4TRE#";

        /// <summary>
        /// N4RNTA.
        /// </summary>
        public const string N4RNTA = "N4RNTA";

        /// <summary>
        /// N4BCI3.
        /// </summary>
        public const string N4BCI3 = "N4BCI3";

        /// <summary>
        /// N4SUDT.
        /// </summary>
        public const string N4SUDT = "N4SUDT";

        /// <summary>
        /// N4UNGR.
        /// </summary>
        public const string N4UNGR = "N4UNGR";

        /// <summary>
        /// N4URCD.
        /// </summary>
        public const string N4URCD = "N4URCD";

        /// <summary>
        /// N4URDT.
        /// </summary>
        public const string N4URDT = "N4URDT";

        /// <summary>
        /// N4URAT.
        /// </summary>
        public const string N4URAT = "N4URAT";

        /// <summary>
        /// N4URAB.
        /// </summary>
        public const string N4URAB = "N4URAB";

        /// <summary>
        /// N4URRF.
        /// </summary>
        public const string N4URRF = "N4URRF";

        /// <summary>
        /// N4USER.
        /// </summary>
        public const string N4USER = "N4USER";

        /// <summary>
        /// N4PID.
        /// </summary>
        public const string N4PID = "N4PID";

        /// <summary>
        /// N4UPMJ.
        /// </summary>
        public const string N4UPMJ = "N4UPMJ";

        /// <summary>
        /// N4UPMT.
        /// </summary>
        public const string N4UPMT = "N4UPMT";

        /// <summary>
        /// N4JOBN.
        /// </summary>
        public const string N4JOBN = "N4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1502WB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N4ICU", "N4ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("N4DOCO", "N4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("N4LSVR", "N4LSVR", JdeDataType.Numeric),
        new JdeField("N4LSET", "N4LSET", JdeDataType.String, 4),
        new JdeField("N4LNID", "N4LNID", JdeDataType.Numeric),
        new JdeField("N4BLGR", "N4BLGR", JdeDataType.String, 24),
        new JdeField("N4TRAN", "N4TRAN", JdeDataType.String, 2),
        new JdeField("N4GLC", "N4GLC", JdeDataType.String, 8, true, true),
        new JdeField("N4RMK", "N4RMK", JdeDataType.String, 60),
        new JdeField("N4AG", "N4AG", JdeDataType.Numeric),
        new JdeField("N4EFTB", "N4EFTB", JdeDataType.Numeric),
        new JdeField("N4EFTE", "N4EFTE", JdeDataType.Numeric),
        new JdeField("N4BLFC", "N4BLFC", JdeDataType.String, 2),
        new JdeField("N4BF01", "N4BF01", JdeDataType.String, 2),
        new JdeField("N4BF02", "N4BF02", JdeDataType.String, 2),
        new JdeField("N4BF03", "N4BF03", JdeDataType.String, 2),
        new JdeField("N4BF04", "N4BF04", JdeDataType.String, 2),
        new JdeField("N4BF05", "N4BF05", JdeDataType.String, 2),
        new JdeField("N4BF06", "N4BF06", JdeDataType.String, 2),
        new JdeField("N4BF07", "N4BF07", JdeDataType.String, 2),
        new JdeField("N4BF08", "N4BF08", JdeDataType.String, 2),
        new JdeField("N4BF09", "N4BF09", JdeDataType.String, 2),
        new JdeField("N4BF10", "N4BF10", JdeDataType.String, 2),
        new JdeField("N4BF11", "N4BF11", JdeDataType.String, 2),
        new JdeField("N4BF12", "N4BF12", JdeDataType.String, 2),
        new JdeField("N4BF13", "N4BF13", JdeDataType.String, 2),
        new JdeField("N4MCU", "N4MCU", JdeDataType.String, 24, true, true),
        new JdeField("N4SBL", "N4SBL", JdeDataType.String, 16),
        new JdeField("N4AN8J", "N4AN8J", JdeDataType.Numeric),
        new JdeField("N4UNIT", "N4UNIT", JdeDataType.String, 16, true, true),
        new JdeField("N4SMCU", "N4SMCU", JdeDataType.String, 24),
        new JdeField("N4TRAR", "N4TRAR", JdeDataType.String, 6),
        new JdeField("N4SEPI", "N4SEPI", JdeDataType.String, 2),
        new JdeField("N4ITMG", "N4ITMG", JdeDataType.String, 6),
        new JdeField("N4SUSP", "N4SUSP", JdeDataType.String, 2),
        new JdeField("N4DEAL", "N4DEAL", JdeDataType.String, 16),
        new JdeField("N4RN01", "N4RN01", JdeDataType.String, 6),
        new JdeField("N4RN02", "N4RN02", JdeDataType.String, 6),
        new JdeField("N4RN03", "N4RN03", JdeDataType.String, 6),
        new JdeField("N4RN04", "N4RN04", JdeDataType.String, 6),
        new JdeField("N4RN05", "N4RN05", JdeDataType.String, 6),
        new JdeField("N4AGSN", "N4AGSN", JdeDataType.Numeric),
        new JdeField("N4GENT", "N4GENT", JdeDataType.String, 2),
        new JdeField("N4BCI", "N4BCI", JdeDataType.Numeric, null, true, true),
        new JdeField("N4CRCD", "N4CRCD", JdeDataType.String, 6),
        new JdeField("N4CRR", "N4CRR", JdeDataType.Numeric),
        new JdeField("N4ACR", "N4ACR", JdeDataType.Numeric),
        new JdeField("N4TXA1", "N4TXA1", JdeDataType.String, 20),
        new JdeField("N4EXR1", "N4EXR1", JdeDataType.String, 4),
        new JdeField("N4STAM", "N4STAM", JdeDataType.Numeric),
        new JdeField("N4ATXN", "N4ATXN", JdeDataType.Numeric),
        new JdeField("N4ATXA", "N4ATXA", JdeDataType.Numeric),
        new JdeField("N4SBLT", "N4SBLT", JdeDataType.String, 2),
        new JdeField("N4CRRM", "N4CRRM", JdeDataType.String, 2),
        new JdeField("N4FAP", "N4FAP", JdeDataType.Numeric),
        new JdeField("N4CDS", "N4CDS", JdeDataType.Numeric),
        new JdeField("N4CDSA", "N4CDSA", JdeDataType.Numeric),
        new JdeField("N4CTAM", "N4CTAM", JdeDataType.Numeric),
        new JdeField("N4CTXA", "N4CTXA", JdeDataType.Numeric),
        new JdeField("N4CTXN", "N4CTXN", JdeDataType.Numeric),
        new JdeField("N4BCI2", "N4BCI2", JdeDataType.Numeric),
        new JdeField("N4BPN", "N4BPN", JdeDataType.Numeric),
        new JdeField("N4YR", "N4YR", JdeDataType.Numeric),
        new JdeField("N4BPN#", "N4BPN#", JdeDataType.Numeric),
        new JdeField("N4TRBM", "N4TRBM", JdeDataType.Numeric),
        new JdeField("N4TRBY", "N4TRBY", JdeDataType.Numeric),
        new JdeField("N4TRB#", "N4TRB#", JdeDataType.Numeric),
        new JdeField("N4TREM", "N4TREM", JdeDataType.Numeric),
        new JdeField("N4TREY", "N4TREY", JdeDataType.Numeric),
        new JdeField("N4TRE#", "N4TRE#", JdeDataType.Numeric),
        new JdeField("N4RNTA", "N4RNTA", JdeDataType.Numeric),
        new JdeField("N4BCI3", "N4BCI3", JdeDataType.Numeric),
        new JdeField("N4SUDT", "N4SUDT", JdeDataType.Numeric),
        new JdeField("N4UNGR", "N4UNGR", JdeDataType.String, 2, true, true),
        new JdeField("N4URCD", "N4URCD", JdeDataType.String, 4),
        new JdeField("N4URDT", "N4URDT", JdeDataType.Numeric),
        new JdeField("N4URAT", "N4URAT", JdeDataType.Numeric),
        new JdeField("N4URAB", "N4URAB", JdeDataType.Numeric),
        new JdeField("N4URRF", "N4URRF", JdeDataType.String, 30),
        new JdeField("N4USER", "N4USER", JdeDataType.String, 20),
        new JdeField("N4PID", "N4PID", JdeDataType.String, 20),
        new JdeField("N4UPMJ", "N4UPMJ", JdeDataType.Numeric),
        new JdeField("N4UPMT", "N4UPMT", JdeDataType.Numeric),
        new JdeField("N4JOBN", "N4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502WB_0", "Primary Key on N4ICU, N4DOCO, N4MCU, N4UNIT, N4GLC, N4UNGR, N4BCI", new[] { "N4ICU", "N4DOCO", "N4MCU", "N4UNIT", "N4GLC", "N4UNGR", "N4BCI" }, isUnique: true, isPrimaryKey: true)
    };
}
