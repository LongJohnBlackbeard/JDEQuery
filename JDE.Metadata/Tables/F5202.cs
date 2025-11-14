using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5202 - .
/// </summary>
public class F5202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G6DOCO.
        /// </summary>
        public const string G6DOCO = "G6DOCO";

        /// <summary>
        /// G6DCTO.
        /// </summary>
        public const string G6DCTO = "G6DCTO";

        /// <summary>
        /// G6KCOO.
        /// </summary>
        public const string G6KCOO = "G6KCOO";

        /// <summary>
        /// G6COCH.
        /// </summary>
        public const string G6COCH = "G6COCH";

        /// <summary>
        /// G6LNID.
        /// </summary>
        public const string G6LNID = "G6LNID";

        /// <summary>
        /// G6OPIM.
        /// </summary>
        public const string G6OPIM = "G6OPIM";

        /// <summary>
        /// G6DL01.
        /// </summary>
        public const string G6DL01 = "G6DL01";

        /// <summary>
        /// G6SD1.
        /// </summary>
        public const string G6SD1 = "G6SD1";

        /// <summary>
        /// G6SD3.
        /// </summary>
        public const string G6SD3 = "G6SD3";

        /// <summary>
        /// G6CHD.
        /// </summary>
        public const string G6CHD = "G6CHD";

        /// <summary>
        /// G6TRMO.
        /// </summary>
        public const string G6TRMO = "G6TRMO";

        /// <summary>
        /// G6CHST.
        /// </summary>
        public const string G6CHST = "G6CHST";

        /// <summary>
        /// G6RTNR.
        /// </summary>
        public const string G6RTNR = "G6RTNR";

        /// <summary>
        /// G6RTN1.
        /// </summary>
        public const string G6RTN1 = "G6RTN1";

        /// <summary>
        /// G6RTNC.
        /// </summary>
        public const string G6RTNC = "G6RTNC";

        /// <summary>
        /// G6MCUS.
        /// </summary>
        public const string G6MCUS = "G6MCUS";

        /// <summary>
        /// G6MCU.
        /// </summary>
        public const string G6MCU = "G6MCU";

        /// <summary>
        /// G6OBJ.
        /// </summary>
        public const string G6OBJ = "G6OBJ";

        /// <summary>
        /// G6SUB.
        /// </summary>
        public const string G6SUB = "G6SUB";

        /// <summary>
        /// G6SBL.
        /// </summary>
        public const string G6SBL = "G6SBL";

        /// <summary>
        /// G6SBLT.
        /// </summary>
        public const string G6SBLT = "G6SBLT";

        /// <summary>
        /// G6CO.
        /// </summary>
        public const string G6CO = "G6CO";

        /// <summary>
        /// G6GLC.
        /// </summary>
        public const string G6GLC = "G6GLC";

        /// <summary>
        /// G6PRTP.
        /// </summary>
        public const string G6PRTP = "G6PRTP";

        /// <summary>
        /// G6SCOF.
        /// </summary>
        public const string G6SCOF = "G6SCOF";

        /// <summary>
        /// G6FSOF.
        /// </summary>
        public const string G6FSOF = "G6FSOF";

        /// <summary>
        /// G6RSOF.
        /// </summary>
        public const string G6RSOF = "G6RSOF";

        /// <summary>
        /// G6U.
        /// </summary>
        public const string G6U = "G6U";

        /// <summary>
        /// G6UM.
        /// </summary>
        public const string G6UM = "G6UM";

        /// <summary>
        /// G6UP.
        /// </summary>
        public const string G6UP = "G6UP";

        /// <summary>
        /// G6FUP.
        /// </summary>
        public const string G6FUP = "G6FUP";

        /// <summary>
        /// G6RUP.
        /// </summary>
        public const string G6RUP = "G6RUP";

        /// <summary>
        /// G6EXR1.
        /// </summary>
        public const string G6EXR1 = "G6EXR1";

        /// <summary>
        /// G6TXA1.
        /// </summary>
        public const string G6TXA1 = "G6TXA1";

        /// <summary>
        /// G6STAM.
        /// </summary>
        public const string G6STAM = "G6STAM";

        /// <summary>
        /// G6ATXN.
        /// </summary>
        public const string G6ATXN = "G6ATXN";

        /// <summary>
        /// G6ATXA.
        /// </summary>
        public const string G6ATXA = "G6ATXA";

        /// <summary>
        /// G6NTEX.
        /// </summary>
        public const string G6NTEX = "G6NTEX";

        /// <summary>
        /// G6FNTE.
        /// </summary>
        public const string G6FNTE = "G6FNTE";

        /// <summary>
        /// G6RNTE.
        /// </summary>
        public const string G6RNTE = "G6RNTE";

        /// <summary>
        /// G6NTEC.
        /// </summary>
        public const string G6NTEC = "G6NTEC";

        /// <summary>
        /// G6FNTO.
        /// </summary>
        public const string G6FNTO = "G6FNTO";

        /// <summary>
        /// G6RNTO.
        /// </summary>
        public const string G6RNTO = "G6RNTO";

        /// <summary>
        /// G6NTEU.
        /// </summary>
        public const string G6NTEU = "G6NTEU";

        /// <summary>
        /// G6RRBC.
        /// </summary>
        public const string G6RRBC = "G6RRBC";

        /// <summary>
        /// G6RRBA.
        /// </summary>
        public const string G6RRBA = "G6RRBA";

        /// <summary>
        /// G6FRBA.
        /// </summary>
        public const string G6FRBA = "G6FRBA";

        /// <summary>
        /// G6RRRA.
        /// </summary>
        public const string G6RRRA = "G6RRRA";

        /// <summary>
        /// G6EXMP.
        /// </summary>
        public const string G6EXMP = "G6EXMP";

        /// <summary>
        /// G6ALSQ.
        /// </summary>
        public const string G6ALSQ = "G6ALSQ";

        /// <summary>
        /// G6BLSP.
        /// </summary>
        public const string G6BLSP = "G6BLSP";

        /// <summary>
        /// G6BLWP.
        /// </summary>
        public const string G6BLWP = "G6BLWP";

        /// <summary>
        /// G6PYWP.
        /// </summary>
        public const string G6PYWP = "G6PYWP";

        /// <summary>
        /// G6MCBL.
        /// </summary>
        public const string G6MCBL = "G6MCBL";

        /// <summary>
        /// G6MKRP.
        /// </summary>
        public const string G6MKRP = "G6MKRP";

        /// <summary>
        /// G6FBAS.
        /// </summary>
        public const string G6FBAS = "G6FBAS";

        /// <summary>
        /// G6RFBS.
        /// </summary>
        public const string G6RFBS = "G6RFBS";

        /// <summary>
        /// G6RACD.
        /// </summary>
        public const string G6RACD = "G6RACD";

        /// <summary>
        /// G6ROLU.
        /// </summary>
        public const string G6ROLU = "G6ROLU";

        /// <summary>
        /// G6R001.
        /// </summary>
        public const string G6R001 = "G6R001";

        /// <summary>
        /// G6ACCO.
        /// </summary>
        public const string G6ACCO = "G6ACCO";

        /// <summary>
        /// G6AD01.
        /// </summary>
        public const string G6AD01 = "G6AD01";

        /// <summary>
        /// G6AD02.
        /// </summary>
        public const string G6AD02 = "G6AD02";

        /// <summary>
        /// G6AD03.
        /// </summary>
        public const string G6AD03 = "G6AD03";

        /// <summary>
        /// G6AD04.
        /// </summary>
        public const string G6AD04 = "G6AD04";

        /// <summary>
        /// G6AD05.
        /// </summary>
        public const string G6AD05 = "G6AD05";

        /// <summary>
        /// G6CTF1.
        /// </summary>
        public const string G6CTF1 = "G6CTF1";

        /// <summary>
        /// G6CTF2.
        /// </summary>
        public const string G6CTF2 = "G6CTF2";

        /// <summary>
        /// G6CTF3.
        /// </summary>
        public const string G6CTF3 = "G6CTF3";

        /// <summary>
        /// G6CTF4.
        /// </summary>
        public const string G6CTF4 = "G6CTF4";

        /// <summary>
        /// G6CTF5.
        /// </summary>
        public const string G6CTF5 = "G6CTF5";

        /// <summary>
        /// G6RMK.
        /// </summary>
        public const string G6RMK = "G6RMK";

        /// <summary>
        /// G6TAG.
        /// </summary>
        public const string G6TAG = "G6TAG";

        /// <summary>
        /// G6CRR.
        /// </summary>
        public const string G6CRR = "G6CRR";

        /// <summary>
        /// G6CRCD.
        /// </summary>
        public const string G6CRCD = "G6CRCD";

        /// <summary>
        /// G6CRCF.
        /// </summary>
        public const string G6CRCF = "G6CRCF";

        /// <summary>
        /// G6CRRD.
        /// </summary>
        public const string G6CRRD = "G6CRRD";

        /// <summary>
        /// G6CRRM.
        /// </summary>
        public const string G6CRRM = "G6CRRM";

        /// <summary>
        /// G6PID.
        /// </summary>
        public const string G6PID = "G6PID";

        /// <summary>
        /// G6JOBN.
        /// </summary>
        public const string G6JOBN = "G6JOBN";

        /// <summary>
        /// G6USER.
        /// </summary>
        public const string G6USER = "G6USER";

        /// <summary>
        /// G6MUPM.
        /// </summary>
        public const string G6MUPM = "G6MUPM";

        /// <summary>
        /// G6UPMT.
        /// </summary>
        public const string G6UPMT = "G6UPMT";

        /// <summary>
        /// G6VVTY.
        /// </summary>
        public const string G6VVTY = "G6VVTY";

        /// <summary>
        /// G6VVTC.
        /// </summary>
        public const string G6VVTC = "G6VVTC";

        /// <summary>
        /// G6FMET.
        /// </summary>
        public const string G6FMET = "G6FMET";

        /// <summary>
        /// G6FLAMT.
        /// </summary>
        public const string G6FLAMT = "G6FLAMT";

        /// <summary>
        /// G6RPHR.
        /// </summary>
        public const string G6RPHR = "G6RPHR";

        /// <summary>
        /// G6CUMYN.
        /// </summary>
        public const string G6CUMYN = "G6CUMYN";

        /// <summary>
        /// G6FCES.
        /// </summary>
        public const string G6FCES = "G6FCES";

        /// <summary>
        /// G6FLAMTF.
        /// </summary>
        public const string G6FLAMTF = "G6FLAMTF";

        /// <summary>
        /// G6RPHRF.
        /// </summary>
        public const string G6RPHRF = "G6RPHRF";

        /// <summary>
        /// G6REVPC.
        /// </summary>
        public const string G6REVPC = "G6REVPC";

        /// <summary>
        /// G6RESTA.
        /// </summary>
        public const string G6RESTA = "G6RESTA";

        /// <summary>
        /// G6INOV.
        /// </summary>
        public const string G6INOV = "G6INOV";

        /// <summary>
        /// G6GFFC.
        /// </summary>
        public const string G6GFFC = "G6GFFC";
    }

    /// <inheritdoc />
    public override string TableName => "F5202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G6DOCO", "G6DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("G6DCTO", "G6DCTO", JdeDataType.String, 4, true, true),
        new JdeField("G6KCOO", "G6KCOO", JdeDataType.String, 10, true, true),
        new JdeField("G6COCH", "G6COCH", JdeDataType.String, 6, true, true),
        new JdeField("G6LNID", "G6LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("G6OPIM", "G6OPIM", JdeDataType.String, 30),
        new JdeField("G6DL01", "G6DL01", JdeDataType.String, 60),
        new JdeField("G6SD1", "G6SD1", JdeDataType.Numeric),
        new JdeField("G6SD3", "G6SD3", JdeDataType.Numeric),
        new JdeField("G6CHD", "G6CHD", JdeDataType.Numeric),
        new JdeField("G6TRMO", "G6TRMO", JdeDataType.String, 2),
        new JdeField("G6CHST", "G6CHST", JdeDataType.String, 4),
        new JdeField("G6RTNR", "G6RTNR", JdeDataType.String, 6),
        new JdeField("G6RTN1", "G6RTN1", JdeDataType.String, 6),
        new JdeField("G6RTNC", "G6RTNC", JdeDataType.String, 6),
        new JdeField("G6MCUS", "G6MCUS", JdeDataType.String, 24),
        new JdeField("G6MCU", "G6MCU", JdeDataType.String, 24),
        new JdeField("G6OBJ", "G6OBJ", JdeDataType.String, 12),
        new JdeField("G6SUB", "G6SUB", JdeDataType.String, 16),
        new JdeField("G6SBL", "G6SBL", JdeDataType.String, 16),
        new JdeField("G6SBLT", "G6SBLT", JdeDataType.String, 2),
        new JdeField("G6CO", "G6CO", JdeDataType.String, 10),
        new JdeField("G6GLC", "G6GLC", JdeDataType.String, 8),
        new JdeField("G6PRTP", "G6PRTP", JdeDataType.String, 2),
        new JdeField("G6SCOF", "G6SCOF", JdeDataType.Numeric),
        new JdeField("G6FSOF", "G6FSOF", JdeDataType.Numeric),
        new JdeField("G6RSOF", "G6RSOF", JdeDataType.Numeric),
        new JdeField("G6U", "G6U", JdeDataType.Numeric),
        new JdeField("G6UM", "G6UM", JdeDataType.String, 4),
        new JdeField("G6UP", "G6UP", JdeDataType.Numeric),
        new JdeField("G6FUP", "G6FUP", JdeDataType.Numeric),
        new JdeField("G6RUP", "G6RUP", JdeDataType.Numeric),
        new JdeField("G6EXR1", "G6EXR1", JdeDataType.String, 4),
        new JdeField("G6TXA1", "G6TXA1", JdeDataType.String, 20),
        new JdeField("G6STAM", "G6STAM", JdeDataType.Numeric),
        new JdeField("G6ATXN", "G6ATXN", JdeDataType.Numeric),
        new JdeField("G6ATXA", "G6ATXA", JdeDataType.Numeric),
        new JdeField("G6NTEX", "G6NTEX", JdeDataType.Numeric),
        new JdeField("G6FNTE", "G6FNTE", JdeDataType.Numeric),
        new JdeField("G6RNTE", "G6RNTE", JdeDataType.Numeric),
        new JdeField("G6NTEC", "G6NTEC", JdeDataType.Numeric),
        new JdeField("G6FNTO", "G6FNTO", JdeDataType.Numeric),
        new JdeField("G6RNTO", "G6RNTO", JdeDataType.Numeric),
        new JdeField("G6NTEU", "G6NTEU", JdeDataType.Numeric),
        new JdeField("G6RRBC", "G6RRBC", JdeDataType.String, 6),
        new JdeField("G6RRBA", "G6RRBA", JdeDataType.Numeric),
        new JdeField("G6FRBA", "G6FRBA", JdeDataType.Numeric),
        new JdeField("G6RRRA", "G6RRRA", JdeDataType.Numeric),
        new JdeField("G6EXMP", "G6EXMP", JdeDataType.String, 2),
        new JdeField("G6ALSQ", "G6ALSQ", JdeDataType.String, 20),
        new JdeField("G6BLSP", "G6BLSP", JdeDataType.String, 2),
        new JdeField("G6BLWP", "G6BLWP", JdeDataType.String, 2),
        new JdeField("G6PYWP", "G6PYWP", JdeDataType.String, 2),
        new JdeField("G6MCBL", "G6MCBL", JdeDataType.String, 2),
        new JdeField("G6MKRP", "G6MKRP", JdeDataType.Numeric),
        new JdeField("G6FBAS", "G6FBAS", JdeDataType.String, 2),
        new JdeField("G6RFBS", "G6RFBS", JdeDataType.String, 2),
        new JdeField("G6RACD", "G6RACD", JdeDataType.String, 6),
        new JdeField("G6ROLU", "G6ROLU", JdeDataType.String, 2),
        new JdeField("G6R001", "G6R001", JdeDataType.String, 6),
        new JdeField("G6ACCO", "G6ACCO", JdeDataType.String, 2),
        new JdeField("G6AD01", "G6AD01", JdeDataType.String, 6),
        new JdeField("G6AD02", "G6AD02", JdeDataType.String, 6),
        new JdeField("G6AD03", "G6AD03", JdeDataType.String, 6),
        new JdeField("G6AD04", "G6AD04", JdeDataType.String, 6),
        new JdeField("G6AD05", "G6AD05", JdeDataType.String, 6),
        new JdeField("G6CTF1", "G6CTF1", JdeDataType.String, 2),
        new JdeField("G6CTF2", "G6CTF2", JdeDataType.String, 2),
        new JdeField("G6CTF3", "G6CTF3", JdeDataType.String, 2),
        new JdeField("G6CTF4", "G6CTF4", JdeDataType.String, 2),
        new JdeField("G6CTF5", "G6CTF5", JdeDataType.String, 2),
        new JdeField("G6RMK", "G6RMK", JdeDataType.String, 60),
        new JdeField("G6TAG", "G6TAG", JdeDataType.String, 16),
        new JdeField("G6CRR", "G6CRR", JdeDataType.Numeric),
        new JdeField("G6CRCD", "G6CRCD", JdeDataType.String, 6),
        new JdeField("G6CRCF", "G6CRCF", JdeDataType.String, 6),
        new JdeField("G6CRRD", "G6CRRD", JdeDataType.Numeric),
        new JdeField("G6CRRM", "G6CRRM", JdeDataType.String, 2),
        new JdeField("G6PID", "G6PID", JdeDataType.String, 20),
        new JdeField("G6JOBN", "G6JOBN", JdeDataType.String, 20),
        new JdeField("G6USER", "G6USER", JdeDataType.String, 20),
        new JdeField("G6MUPM", "G6MUPM", JdeDataType.Numeric),
        new JdeField("G6UPMT", "G6UPMT", JdeDataType.Numeric),
        new JdeField("G6VVTY", "G6VVTY", JdeDataType.String, 12),
        new JdeField("G6VVTC", "G6VVTC", JdeDataType.String, 20),
        new JdeField("G6FMET", "G6FMET", JdeDataType.String, 4),
        new JdeField("G6FLAMT", "G6FLAMT", JdeDataType.Numeric),
        new JdeField("G6RPHR", "G6RPHR", JdeDataType.Numeric),
        new JdeField("G6CUMYN", "G6CUMYN", JdeDataType.String, 2),
        new JdeField("G6FCES", "G6FCES", JdeDataType.String, 2),
        new JdeField("G6FLAMTF", "G6FLAMTF", JdeDataType.Numeric),
        new JdeField("G6RPHRF", "G6RPHRF", JdeDataType.Numeric),
        new JdeField("G6REVPC", "G6REVPC", JdeDataType.Numeric),
        new JdeField("G6RESTA", "G6RESTA", JdeDataType.String, 2),
        new JdeField("G6INOV", "G6INOV", JdeDataType.String, 2),
        new JdeField("G6GFFC", "G6GFFC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5202_0", "Primary Key on G6DOCO, G6DCTO, G6KCOO, G6COCH, G6LNID", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6COCH", "G6LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5202_2", "Index on G6DOCO, G6DCTO, G6KCOO, G6COCH, G6OPIM, G6LNID", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6COCH", "G6OPIM", "G6LNID" }),
        new JdeIndex("F5202_3", "Index on G6DOCO, G6DCTO, G6KCOO, G6MCU, G6SUB, G6OBJ, G6SBL, G6SBLT", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6MCU", "G6SUB", "G6OBJ", "G6SBL", "G6SBLT" }),
        new JdeIndex("F5202_4", "Index on G6DOCO, G6DCTO, G6KCOO, G6OPIM, G6COCH, G6LNID", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6OPIM", "G6COCH", "G6LNID" }),
        new JdeIndex("F5202_5", "Index on G6DOCO, G6DCTO, G6KCOO, G6ALSQ, G6COCH, G6OPIM, G6LNID", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6ALSQ", "G6COCH", "G6OPIM", "G6LNID" }),
        new JdeIndex("F5202_6", "Index on G6MCU", new[] { "G6MCU" }),
        new JdeIndex("F5202_7", "Index on G6DOCO, G6DCTO, G6KCOO", new[] { "G6DOCO", "G6DCTO", "G6KCOO" }),
        new JdeIndex("F5202_8", "Index on G6DOCO, G6DCTO, G6KCOO, G6PRTP, G6COCH, G6LNID", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6PRTP", "G6COCH", "G6LNID" }),
        new JdeIndex("F5202_9", "Index on G6DOCO, G6DCTO, G6KCOO, G6COCH, G6LNID, G6FMET", new[] { "G6DOCO", "G6DCTO", "G6KCOO", "G6COCH", "G6LNID", "G6FMET" })
    };
}
