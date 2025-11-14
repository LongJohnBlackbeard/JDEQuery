using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82100 - .
/// </summary>
public class F82100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1QRYG.
        /// </summary>
        public const string A1QRYG = "A1QRYG";

        /// <summary>
        /// A1QRYN.
        /// </summary>
        public const string A1QRYN = "A1QRYN";

        /// <summary>
        /// A1JD.
        /// </summary>
        public const string A1JD = "A1JD";

        /// <summary>
        /// A1EXCL.
        /// </summary>
        public const string A1EXCL = "A1EXCL";

        /// <summary>
        /// A1DEST.
        /// </summary>
        public const string A1DEST = "A1DEST";

        /// <summary>
        /// A1USER.
        /// </summary>
        public const string A1USER = "A1USER";

        /// <summary>
        /// A1VCD.
        /// </summary>
        public const string A1VCD = "A1VCD";

        /// <summary>
        /// A1VED.
        /// </summary>
        public const string A1VED = "A1VED";

        /// <summary>
        /// A1PTSP.
        /// </summary>
        public const string A1PTSP = "A1PTSP";

        /// <summary>
        /// A1HJBQ.
        /// </summary>
        public const string A1HJBQ = "A1HJBQ";

        /// <summary>
        /// A1QTL1.
        /// </summary>
        public const string A1QTL1 = "A1QTL1";

        /// <summary>
        /// A1QTL2.
        /// </summary>
        public const string A1QTL2 = "A1QTL2";

        /// <summary>
        /// A1QTL3.
        /// </summary>
        public const string A1QTL3 = "A1QTL3";

        /// <summary>
        /// A1DTTL.
        /// </summary>
        public const string A1DTTL = "A1DTTL";

        /// <summary>
        /// A1JOBQ.
        /// </summary>
        public const string A1JOBQ = "A1JOBQ";

        /// <summary>
        /// A1DFLS.
        /// </summary>
        public const string A1DFLS = "A1DFLS";

        /// <summary>
        /// A1DFCS.
        /// </summary>
        public const string A1DFCS = "A1DFCS";

        /// <summary>
        /// A1WRAP.
        /// </summary>
        public const string A1WRAP = "A1WRAP";

        /// <summary>
        /// A1TCOL.
        /// </summary>
        public const string A1TCOL = "A1TCOL";

        /// <summary>
        /// A1MAXR.
        /// </summary>
        public const string A1MAXR = "A1MAXR";

        /// <summary>
        /// A1OLPP.
        /// </summary>
        public const string A1OLPP = "A1OLPP";

        /// <summary>
        /// A1OVTF.
        /// </summary>
        public const string A1OVTF = "A1OVTF";

        /// <summary>
        /// A1PRTQ.
        /// </summary>
        public const string A1PRTQ = "A1PRTQ";

        /// <summary>
        /// A1LPI.
        /// </summary>
        public const string A1LPI = "A1LPI";

        /// <summary>
        /// A1CPI.
        /// </summary>
        public const string A1CPI = "A1CPI";

        /// <summary>
        /// A1RCOP.
        /// </summary>
        public const string A1RCOP = "A1RCOP";

        /// <summary>
        /// A1DLIN.
        /// </summary>
        public const string A1DLIN = "A1DLIN";

        /// <summary>
        /// A1HLDQ.
        /// </summary>
        public const string A1HLDQ = "A1HLDQ";

        /// <summary>
        /// A1WDTH.
        /// </summary>
        public const string A1WDTH = "A1WDTH";

        /// <summary>
        /// A1LNTH.
        /// </summary>
        public const string A1LNTH = "A1LNTH";

        /// <summary>
        /// A1OVRF.
        /// </summary>
        public const string A1OVRF = "A1OVRF";

        /// <summary>
        /// A1FMTP.
        /// </summary>
        public const string A1FMTP = "A1FMTP";

        /// <summary>
        /// A1OAPG.
        /// </summary>
        public const string A1OAPG = "A1OAPG";

        /// <summary>
        /// A1SDRW.
        /// </summary>
        public const string A1SDRW = "A1SDRW";

        /// <summary>
        /// A1FNID.
        /// </summary>
        public const string A1FNID = "A1FNID";

        /// <summary>
        /// A1FMFD.
        /// </summary>
        public const string A1FMFD = "A1FMFD";

        /// <summary>
        /// A1PTQT.
        /// </summary>
        public const string A1PTQT = "A1PTQT";

        /// <summary>
        /// A1CCHR.
        /// </summary>
        public const string A1CCHR = "A1CCHR";

        /// <summary>
        /// A1GCHR.
        /// </summary>
        public const string A1GCHR = "A1GCHR";

        /// <summary>
        /// A1CDPG.
        /// </summary>
        public const string A1CDPG = "A1CDPG";

        /// <summary>
        /// A1PROT.
        /// </summary>
        public const string A1PROT = "A1PROT";

        /// <summary>
        /// A1PGFT.
        /// </summary>
        public const string A1PGFT = "A1PGFT";

        /// <summary>
        /// A1HJUS.
        /// </summary>
        public const string A1HJUS = "A1HJUS";

        /// <summary>
        /// A1SEPP.
        /// </summary>
        public const string A1SEPP = "A1SEPP";

        /// <summary>
        /// A1OUTP.
        /// </summary>
        public const string A1OUTP = "A1OUTP";

        /// <summary>
        /// A1OFIL.
        /// </summary>
        public const string A1OFIL = "A1OFIL";

        /// <summary>
        /// A1OLBR.
        /// </summary>
        public const string A1OLBR = "A1OLBR";

        /// <summary>
        /// A1OMBR.
        /// </summary>
        public const string A1OMBR = "A1OMBR";

        /// <summary>
        /// A1LNKG.
        /// </summary>
        public const string A1LNKG = "A1LNKG";

        /// <summary>
        /// A1LNKN.
        /// </summary>
        public const string A1LNKN = "A1LNKN";

        /// <summary>
        /// A1SVDL.
        /// </summary>
        public const string A1SVDL = "A1SVDL";

        /// <summary>
        /// A1DUPL.
        /// </summary>
        public const string A1DUPL = "A1DUPL";

        /// <summary>
        /// A1USRD.
        /// </summary>
        public const string A1USRD = "A1USRD";

        /// <summary>
        /// A1SAVE.
        /// </summary>
        public const string A1SAVE = "A1SAVE";

        /// <summary>
        /// A1SPLF.
        /// </summary>
        public const string A1SPLF = "A1SPLF";

        /// <summary>
        /// A1PDN.
        /// </summary>
        public const string A1PDN = "A1PDN";

        /// <summary>
        /// A1IPDS.
        /// </summary>
        public const string A1IPDS = "A1IPDS";

        /// <summary>
        /// A1DBAT.
        /// </summary>
        public const string A1DBAT = "A1DBAT";

        /// <summary>
        /// A1DBEC.
        /// </summary>
        public const string A1DBEC = "A1DBEC";

        /// <summary>
        /// A1DBRT.
        /// </summary>
        public const string A1DBRT = "A1DBRT";

        /// <summary>
        /// A1DBCD.
        /// </summary>
        public const string A1DBCD = "A1DBCD";

        /// <summary>
        /// A1DBPC.
        /// </summary>
        public const string A1DBPC = "A1DBPC";
    }

    /// <inheritdoc />
    public override string TableName => "F82100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1QRYG", "A1QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A1QRYN", "A1QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A1JD", "A1JD", JdeDataType.String, 100),
        new JdeField("A1EXCL", "A1EXCL", JdeDataType.String, 2),
        new JdeField("A1DEST", "A1DEST", JdeDataType.String, 2),
        new JdeField("A1USER", "A1USER", JdeDataType.String, 20),
        new JdeField("A1VCD", "A1VCD", JdeDataType.Numeric),
        new JdeField("A1VED", "A1VED", JdeDataType.Numeric),
        new JdeField("A1PTSP", "A1PTSP", JdeDataType.String, 2),
        new JdeField("A1HJBQ", "A1HJBQ", JdeDataType.String, 2),
        new JdeField("A1QTL1", "A1QTL1", JdeDataType.String, 100),
        new JdeField("A1QTL2", "A1QTL2", JdeDataType.String, 100),
        new JdeField("A1QTL3", "A1QTL3", JdeDataType.String, 100),
        new JdeField("A1DTTL", "A1DTTL", JdeDataType.String, 2),
        new JdeField("A1JOBQ", "A1JOBQ", JdeDataType.String, 20),
        new JdeField("A1DFLS", "A1DFLS", JdeDataType.Numeric),
        new JdeField("A1DFCS", "A1DFCS", JdeDataType.Numeric),
        new JdeField("A1WRAP", "A1WRAP", JdeDataType.String, 2),
        new JdeField("A1TCOL", "A1TCOL", JdeDataType.Numeric),
        new JdeField("A1MAXR", "A1MAXR", JdeDataType.Numeric),
        new JdeField("A1OLPP", "A1OLPP", JdeDataType.String, 2),
        new JdeField("A1OVTF", "A1OVTF", JdeDataType.String, 20),
        new JdeField("A1PRTQ", "A1PRTQ", JdeDataType.String, 20),
        new JdeField("A1LPI", "A1LPI", JdeDataType.String, 6),
        new JdeField("A1CPI", "A1CPI", JdeDataType.String, 8),
        new JdeField("A1RCOP", "A1RCOP", JdeDataType.Numeric),
        new JdeField("A1DLIN", "A1DLIN", JdeDataType.Numeric),
        new JdeField("A1HLDQ", "A1HLDQ", JdeDataType.String, 2),
        new JdeField("A1WDTH", "A1WDTH", JdeDataType.Numeric),
        new JdeField("A1LNTH", "A1LNTH", JdeDataType.Numeric),
        new JdeField("A1OVRF", "A1OVRF", JdeDataType.Numeric),
        new JdeField("A1FMTP", "A1FMTP", JdeDataType.String, 20),
        new JdeField("A1OAPG", "A1OAPG", JdeDataType.String, 2),
        new JdeField("A1SDRW", "A1SDRW", JdeDataType.String, 6),
        new JdeField("A1FNID", "A1FNID", JdeDataType.String, 20),
        new JdeField("A1FMFD", "A1FMFD", JdeDataType.String, 16),
        new JdeField("A1PTQT", "A1PTQT", JdeDataType.String, 12),
        new JdeField("A1CCHR", "A1CCHR", JdeDataType.String, 10),
        new JdeField("A1GCHR", "A1GCHR", JdeDataType.String, 14),
        new JdeField("A1CDPG", "A1CDPG", JdeDataType.String, 12),
        new JdeField("A1PROT", "A1PROT", JdeDataType.String, 10),
        new JdeField("A1PGFT", "A1PGFT", JdeDataType.String, 60),
        new JdeField("A1HJUS", "A1HJUS", JdeDataType.String, 12),
        new JdeField("A1SEPP", "A1SEPP", JdeDataType.String, 2),
        new JdeField("A1OUTP", "A1OUTP", JdeDataType.String, 2),
        new JdeField("A1OFIL", "A1OFIL", JdeDataType.String, 20),
        new JdeField("A1OLBR", "A1OLBR", JdeDataType.String, 20),
        new JdeField("A1OMBR", "A1OMBR", JdeDataType.String, 20),
        new JdeField("A1LNKG", "A1LNKG", JdeDataType.String, 20),
        new JdeField("A1LNKN", "A1LNKN", JdeDataType.String, 20),
        new JdeField("A1SVDL", "A1SVDL", JdeDataType.String, 2),
        new JdeField("A1DUPL", "A1DUPL", JdeDataType.String, 2),
        new JdeField("A1USRD", "A1USRD", JdeDataType.String, 20),
        new JdeField("A1SAVE", "A1SAVE", JdeDataType.String, 2),
        new JdeField("A1SPLF", "A1SPLF", JdeDataType.String, 20),
        new JdeField("A1PDN", "A1PDN", JdeDataType.String, 20),
        new JdeField("A1IPDS", "A1IPDS", JdeDataType.String, 2),
        new JdeField("A1DBAT", "A1DBAT", JdeDataType.String, 2),
        new JdeField("A1DBEC", "A1DBEC", JdeDataType.String, 2),
        new JdeField("A1DBRT", "A1DBRT", JdeDataType.String, 2),
        new JdeField("A1DBCD", "A1DBCD", JdeDataType.String, 6),
        new JdeField("A1DBPC", "A1DBPC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82100_0", "Primary Key on A1QRYG, A1QRYN", new[] { "A1QRYG", "A1QRYN" }, isUnique: true, isPrimaryKey: true)
    };
}
