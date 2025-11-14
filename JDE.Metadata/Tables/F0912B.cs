using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0912B - .
/// </summary>
public class F0912B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R#HST.
        /// </summary>
        public const string R_HST = "R#HST";

        /// <summary>
        /// R#REVR.
        /// </summary>
        public const string R_REVR = "R#REVR";

        /// <summary>
        /// R#DCT.
        /// </summary>
        public const string R_DCT = "R#DCT";

        /// <summary>
        /// R#DOC.
        /// </summary>
        public const string R_DOC = "R#DOC";

        /// <summary>
        /// R#SEN.
        /// </summary>
        public const string R_SEN = "R#SEN";

        /// <summary>
        /// R#DGJ.
        /// </summary>
        public const string R_DGJ = "R#DGJ";

        /// <summary>
        /// R#CTRY.
        /// </summary>
        public const string R_CTRY = "R#CTRY";

        /// <summary>
        /// R#RFAC.
        /// </summary>
        public const string R_RFAC = "R#RFAC";

        /// <summary>
        /// R#EXA.
        /// </summary>
        public const string R_EXA = "R#EXA";

        /// <summary>
        /// R#CO.
        /// </summary>
        public const string R_CO = "R#CO";

        /// <summary>
        /// R#RF.
        /// </summary>
        public const string R_RF = "R#RF";

        /// <summary>
        /// R#ANI.
        /// </summary>
        public const string R_ANI = "R#ANI";

        /// <summary>
        /// R#AID.
        /// </summary>
        public const string R_AID = "R#AID";

        /// <summary>
        /// R#AM.
        /// </summary>
        public const string R_AM = "R#AM";

        /// <summary>
        /// R#SBL.
        /// </summary>
        public const string R_SBL = "R#SBL";

        /// <summary>
        /// R#SBLT.
        /// </summary>
        public const string R_SBLT = "R#SBLT";

        /// <summary>
        /// R#FCC.
        /// </summary>
        public const string R_FCC = "R#FCC";

        /// <summary>
        /// R#FCCN.
        /// </summary>
        public const string R_FCCN = "R#FCCN";

        /// <summary>
        /// R#FCCC.
        /// </summary>
        public const string R_FCCC = "R#FCCC";

        /// <summary>
        /// R#FROM.
        /// </summary>
        public const string R_FROM = "R#FROM";

        /// <summary>
        /// R#OBJF.
        /// </summary>
        public const string R_OBJF = "R#OBJF";

        /// <summary>
        /// R#FSUB.
        /// </summary>
        public const string R_FSUB = "R#FSUB";

        /// <summary>
        /// R#FSBL.
        /// </summary>
        public const string R_FSBL = "R#FSBL";

        /// <summary>
        /// R#SLK.
        /// </summary>
        public const string R_SLK = "R#SLK";

        /// <summary>
        /// R#FLT.
        /// </summary>
        public const string R_FLT = "R#FLT";

        /// <summary>
        /// R#FMYI.
        /// </summary>
        public const string R_FMYI = "R#FMYI";

        /// <summary>
        /// R#FPN.
        /// </summary>
        public const string R_FPN = "R#FPN";

        /// <summary>
        /// R#FFY.
        /// </summary>
        public const string R_FFY = "R#FFY";

        /// <summary>
        /// R#FCTY.
        /// </summary>
        public const string R_FCTY = "R#FCTY";

        /// <summary>
        /// R#THRU.
        /// </summary>
        public const string R_THRU = "R#THRU";

        /// <summary>
        /// R#OBJT.
        /// </summary>
        public const string R_OBJT = "R#OBJT";

        /// <summary>
        /// R#SUBT.
        /// </summary>
        public const string R_SUBT = "R#SUBT";

        /// <summary>
        /// R#TSBL.
        /// </summary>
        public const string R_TSBL = "R#TSBL";

        /// <summary>
        /// R#BCCN.
        /// </summary>
        public const string R_BCCN = "R#BCCN";

        /// <summary>
        /// R#BCCC.
        /// </summary>
        public const string R_BCCC = "R#BCCC";

        /// <summary>
        /// R#BFOB.
        /// </summary>
        public const string R_BFOB = "R#BFOB";

        /// <summary>
        /// R#BFSU.
        /// </summary>
        public const string R_BFSU = "R#BFSU";

        /// <summary>
        /// R#BFSL.
        /// </summary>
        public const string R_BFSL = "R#BFSL";

        /// <summary>
        /// R#BSLT.
        /// </summary>
        public const string R_BSLT = "R#BSLT";

        /// <summary>
        /// R#BLT.
        /// </summary>
        public const string R_BLT = "R#BLT";

        /// <summary>
        /// R#BMYI.
        /// </summary>
        public const string R_BMYI = "R#BMYI";

        /// <summary>
        /// R#BPNO.
        /// </summary>
        public const string R_BPNO = "R#BPNO";

        /// <summary>
        /// R#BFY.
        /// </summary>
        public const string R_BFY = "R#BFY";

        /// <summary>
        /// R#BCTR.
        /// </summary>
        public const string R_BCTR = "R#BCTR";

        /// <summary>
        /// R#BTOB.
        /// </summary>
        public const string R_BTOB = "R#BTOB";

        /// <summary>
        /// R#BTSU.
        /// </summary>
        public const string R_BTSU = "R#BTSU";

        /// <summary>
        /// R#BTSL.
        /// </summary>
        public const string R_BTSL = "R#BTSL";

        /// <summary>
        /// R#AOBA.
        /// </summary>
        public const string R_AOBA = "R#AOBA";

        /// <summary>
        /// R#ASBA.
        /// </summary>
        public const string R_ASBA = "R#ASBA";

        /// <summary>
        /// R#ASBL.
        /// </summary>
        public const string R_ASBL = "R#ASBL";

        /// <summary>
        /// R#ALTA.
        /// </summary>
        public const string R_ALTA = "R#ALTA";

        /// <summary>
        /// R#USER.
        /// </summary>
        public const string R_USER = "R#USER";

        /// <summary>
        /// R#LCT.
        /// </summary>
        public const string R_LCT = "R#LCT";

        /// <summary>
        /// R#SDTE.
        /// </summary>
        public const string R_SDTE = "R#SDTE";

        /// <summary>
        /// R#ASBT.
        /// </summary>
        public const string R_ASBT = "R#ASBT";

        /// <summary>
        /// R#PID.
        /// </summary>
        public const string R_PID = "R#PID";

        /// <summary>
        /// R#UPMJ.
        /// </summary>
        public const string R_UPMJ = "R#UPMJ";

        /// <summary>
        /// R#JOBN.
        /// </summary>
        public const string R_JOBN = "R#JOBN";

        /// <summary>
        /// R#UPMT.
        /// </summary>
        public const string R_UPMT = "R#UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0912B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R#HST", "R#HST", JdeDataType.String, 2),
        new JdeField("R#REVR", "R#REVR", JdeDataType.String, 2),
        new JdeField("R#DCT", "R#DCT", JdeDataType.String, 4, true, true),
        new JdeField("R#DOC", "R#DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("R#SEN", "R#SEN", JdeDataType.Numeric),
        new JdeField("R#DGJ", "R#DGJ", JdeDataType.Numeric),
        new JdeField("R#CTRY", "R#CTRY", JdeDataType.Numeric),
        new JdeField("R#RFAC", "R#RFAC", JdeDataType.Numeric),
        new JdeField("R#EXA", "R#EXA", JdeDataType.String, 60),
        new JdeField("R#CO", "R#CO", JdeDataType.String, 10, true, true),
        new JdeField("R#RF", "R#RF", JdeDataType.String, 4),
        new JdeField("R#ANI", "R#ANI", JdeDataType.String, 58),
        new JdeField("R#AID", "R#AID", JdeDataType.String, 16),
        new JdeField("R#AM", "R#AM", JdeDataType.String, 2),
        new JdeField("R#SBL", "R#SBL", JdeDataType.String, 16),
        new JdeField("R#SBLT", "R#SBLT", JdeDataType.String, 2),
        new JdeField("R#FCC", "R#FCC", JdeDataType.String, 24),
        new JdeField("R#FCCN", "R#FCCN", JdeDataType.String, 4),
        new JdeField("R#FCCC", "R#FCCC", JdeDataType.String, 20),
        new JdeField("R#FROM", "R#FROM", JdeDataType.String, 30),
        new JdeField("R#OBJF", "R#OBJF", JdeDataType.String, 12),
        new JdeField("R#FSUB", "R#FSUB", JdeDataType.String, 16),
        new JdeField("R#FSBL", "R#FSBL", JdeDataType.String, 16),
        new JdeField("R#SLK", "R#SLK", JdeDataType.String, 2),
        new JdeField("R#FLT", "R#FLT", JdeDataType.String, 4),
        new JdeField("R#FMYI", "R#FMYI", JdeDataType.String, 2),
        new JdeField("R#FPN", "R#FPN", JdeDataType.Numeric),
        new JdeField("R#FFY", "R#FFY", JdeDataType.Numeric),
        new JdeField("R#FCTY", "R#FCTY", JdeDataType.Numeric),
        new JdeField("R#THRU", "R#THRU", JdeDataType.String, 30),
        new JdeField("R#OBJT", "R#OBJT", JdeDataType.String, 12),
        new JdeField("R#SUBT", "R#SUBT", JdeDataType.String, 16),
        new JdeField("R#TSBL", "R#TSBL", JdeDataType.String, 16),
        new JdeField("R#BCCN", "R#BCCN", JdeDataType.String, 4),
        new JdeField("R#BCCC", "R#BCCC", JdeDataType.String, 20),
        new JdeField("R#BFOB", "R#BFOB", JdeDataType.String, 12),
        new JdeField("R#BFSU", "R#BFSU", JdeDataType.String, 16),
        new JdeField("R#BFSL", "R#BFSL", JdeDataType.String, 16),
        new JdeField("R#BSLT", "R#BSLT", JdeDataType.String, 2),
        new JdeField("R#BLT", "R#BLT", JdeDataType.String, 4),
        new JdeField("R#BMYI", "R#BMYI", JdeDataType.String, 2),
        new JdeField("R#BPNO", "R#BPNO", JdeDataType.Numeric),
        new JdeField("R#BFY", "R#BFY", JdeDataType.Numeric),
        new JdeField("R#BCTR", "R#BCTR", JdeDataType.Numeric),
        new JdeField("R#BTOB", "R#BTOB", JdeDataType.String, 12),
        new JdeField("R#BTSU", "R#BTSU", JdeDataType.String, 16),
        new JdeField("R#BTSL", "R#BTSL", JdeDataType.String, 16),
        new JdeField("R#AOBA", "R#AOBA", JdeDataType.String, 12),
        new JdeField("R#ASBA", "R#ASBA", JdeDataType.String, 16),
        new JdeField("R#ASBL", "R#ASBL", JdeDataType.String, 16),
        new JdeField("R#ALTA", "R#ALTA", JdeDataType.String, 4),
        new JdeField("R#USER", "R#USER", JdeDataType.String, 20),
        new JdeField("R#LCT", "R#LCT", JdeDataType.Numeric),
        new JdeField("R#SDTE", "R#SDTE", JdeDataType.Numeric),
        new JdeField("R#ASBT", "R#ASBT", JdeDataType.String, 2),
        new JdeField("R#PID", "R#PID", JdeDataType.String, 20),
        new JdeField("R#UPMJ", "R#UPMJ", JdeDataType.Numeric),
        new JdeField("R#JOBN", "R#JOBN", JdeDataType.String, 20),
        new JdeField("R#UPMT", "R#UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0912B_0", "Primary Key on R#DCT, R#DOC, R#CO", new[] { "R#DCT", "R#DOC", "R#CO" }, isUnique: true, isPrimaryKey: true)
    };
}
