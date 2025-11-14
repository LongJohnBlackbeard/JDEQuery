using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31111S - .
/// </summary>
public class FF31111S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRUKID.
        /// </summary>
        public const string PRUKID = "PRUKID";

        /// <summary>
        /// PRMTID.
        /// </summary>
        public const string PRMTID = "PRMTID";

        /// <summary>
        /// PRPRODF31.
        /// </summary>
        public const string PRPRODF31 = "PRPRODF31";

        /// <summary>
        /// PRTRSID.
        /// </summary>
        public const string PRTRSID = "PRTRSID";

        /// <summary>
        /// PRDFMLINE.
        /// </summary>
        public const string PRDFMLINE = "PRDFMLINE";

        /// <summary>
        /// PRKIT.
        /// </summary>
        public const string PRKIT = "PRKIT";

        /// <summary>
        /// PRMMCU.
        /// </summary>
        public const string PRMMCU = "PRMMCU";

        /// <summary>
        /// PRITM.
        /// </summary>
        public const string PRITM = "PRITM";

        /// <summary>
        /// PRCMCU.
        /// </summary>
        public const string PRCMCU = "PRCMCU";

        /// <summary>
        /// PRCPNB.
        /// </summary>
        public const string PRCPNB = "PRCPNB";

        /// <summary>
        /// PRTRQTY.
        /// </summary>
        public const string PRTRQTY = "PRTRQTY";

        /// <summary>
        /// PRLTRQT.
        /// </summary>
        public const string PRLTRQT = "PRLTRQT";

        /// <summary>
        /// PRSOCN.
        /// </summary>
        public const string PRSOCN = "PRSOCN";

        /// <summary>
        /// PRUOM.
        /// </summary>
        public const string PRUOM = "PRUOM";

        /// <summary>
        /// PRUM.
        /// </summary>
        public const string PRUM = "PRUM";

        /// <summary>
        /// PRFORQ.
        /// </summary>
        public const string PRFORQ = "PRFORQ";

        /// <summary>
        /// PRITC.
        /// </summary>
        public const string PRITC = "PRITC";

        /// <summary>
        /// PRRORN.
        /// </summary>
        public const string PRRORN = "PRRORN";

        /// <summary>
        /// PRRCTO.
        /// </summary>
        public const string PRRCTO = "PRRCTO";

        /// <summary>
        /// PRRLLN.
        /// </summary>
        public const string PRRLLN = "PRRLLN";

        /// <summary>
        /// PRRKCO.
        /// </summary>
        public const string PRRKCO = "PRRKCO";

        /// <summary>
        /// PROPSQ.
        /// </summary>
        public const string PROPSQ = "PROPSQ";

        /// <summary>
        /// PRBSEQ.
        /// </summary>
        public const string PRBSEQ = "PRBSEQ";

        /// <summary>
        /// PRRSCP.
        /// </summary>
        public const string PRRSCP = "PRRSCP";

        /// <summary>
        /// PRSCRP.
        /// </summary>
        public const string PRSCRP = "PRSCRP";

        /// <summary>
        /// PRREWP.
        /// </summary>
        public const string PRREWP = "PRREWP";

        /// <summary>
        /// PRASIP.
        /// </summary>
        public const string PRASIP = "PRASIP";

        /// <summary>
        /// PRCPYP.
        /// </summary>
        public const string PRCPYP = "PRCPYP";

        /// <summary>
        /// PRSTPP.
        /// </summary>
        public const string PRSTPP = "PRSTPP";

        /// <summary>
        /// PRLITM.
        /// </summary>
        public const string PRLITM = "PRLITM";

        /// <summary>
        /// PRAITM.
        /// </summary>
        public const string PRAITM = "PRAITM";

        /// <summary>
        /// PRDSC1.
        /// </summary>
        public const string PRDSC1 = "PRDSC1";

        /// <summary>
        /// PRDSC2.
        /// </summary>
        public const string PRDSC2 = "PRDSC2";

        /// <summary>
        /// PRLOCN.
        /// </summary>
        public const string PRLOCN = "PRLOCN";

        /// <summary>
        /// PRLOTN.
        /// </summary>
        public const string PRLOTN = "PRLOTN";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRLNTY.
        /// </summary>
        public const string PRLNTY = "PRLNTY";

        /// <summary>
        /// PRSERN.
        /// </summary>
        public const string PRSERN = "PRSERN";

        /// <summary>
        /// PRLTDATE.
        /// </summary>
        public const string PRLTDATE = "PRLTDATE";

        /// <summary>
        /// PRUCNDJ.
        /// </summary>
        public const string PRUCNDJ = "PRUCNDJ";

        /// <summary>
        /// PRLRDATE.
        /// </summary>
        public const string PRLRDATE = "PRLRDATE";

        /// <summary>
        /// PRCTS1.
        /// </summary>
        public const string PRCTS1 = "PRCTS1";

        /// <summary>
        /// PRCTS4.
        /// </summary>
        public const string PRCTS4 = "PRCTS4";

        /// <summary>
        /// PRCTS8.
        /// </summary>
        public const string PRCTS8 = "PRCTS8";

        /// <summary>
        /// PRCTS7.
        /// </summary>
        public const string PRCTS7 = "PRCTS7";

        /// <summary>
        /// PREA.
        /// </summary>
        public const string PREA = "PREA";

        /// <summary>
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PROMCU.
        /// </summary>
        public const string PROMCU = "PROMCU";

        /// <summary>
        /// PROBJ.
        /// </summary>
        public const string PROBJ = "PROBJ";

        /// <summary>
        /// PRSUB.
        /// </summary>
        public const string PRSUB = "PRSUB";

        /// <summary>
        /// PRCMRV.
        /// </summary>
        public const string PRCMRV = "PRCMRV";

        /// <summary>
        /// PRVEND.
        /// </summary>
        public const string PRVEND = "PRVEND";

        /// <summary>
        /// PRPOC.
        /// </summary>
        public const string PRPOC = "PRPOC";

        /// <summary>
        /// PRLGLDATE.
        /// </summary>
        public const string PRLGLDATE = "PRLGLDATE";

        /// <summary>
        /// PRPSN.
        /// </summary>
        public const string PRPSN = "PRPSN";

        /// <summary>
        /// PRLLEDATE.
        /// </summary>
        public const string PRLLEDATE = "PRLLEDATE";

        /// <summary>
        /// PRTRQT.
        /// </summary>
        public const string PRTRQT = "PRTRQT";

        /// <summary>
        /// PRTRSTS.
        /// </summary>
        public const string PRTRSTS = "PRTRSTS";

        /// <summary>
        /// PRCOST.
        /// </summary>
        public const string PRCOST = "PRCOST";

        /// <summary>
        /// PRCHPP.
        /// </summary>
        public const string PRCHPP = "PRCHPP";

        /// <summary>
        /// PRBSEQAN.
        /// </summary>
        public const string PRBSEQAN = "PRBSEQAN";

        /// <summary>
        /// PRTUSER.
        /// </summary>
        public const string PRTUSER = "PRTUSER";

        /// <summary>
        /// PRCUSER.
        /// </summary>
        public const string PRCUSER = "PRCUSER";

        /// <summary>
        /// PRURCD.
        /// </summary>
        public const string PRURCD = "PRURCD";

        /// <summary>
        /// PRURDT.
        /// </summary>
        public const string PRURDT = "PRURDT";

        /// <summary>
        /// PRURAT.
        /// </summary>
        public const string PRURAT = "PRURAT";

        /// <summary>
        /// PRURRF.
        /// </summary>
        public const string PRURRF = "PRURRF";

        /// <summary>
        /// PRURAB.
        /// </summary>
        public const string PRURAB = "PRURAB";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRUUPMJ.
        /// </summary>
        public const string PRUUPMJ = "PRUUPMJ";

        /// <summary>
        /// PRMKEY.
        /// </summary>
        public const string PRMKEY = "PRMKEY";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";
    }

    /// <inheritdoc />
    public override string TableName => "FF31111S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRUKID", "PRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRMTID", "PRMTID", JdeDataType.Numeric),
        new JdeField("PRPRODF31", "PRPRODF31", JdeDataType.Numeric),
        new JdeField("PRTRSID", "PRTRSID", JdeDataType.Numeric),
        new JdeField("PRDFMLINE", "PRDFMLINE", JdeDataType.String, 24),
        new JdeField("PRKIT", "PRKIT", JdeDataType.Numeric),
        new JdeField("PRMMCU", "PRMMCU", JdeDataType.String, 24),
        new JdeField("PRITM", "PRITM", JdeDataType.Numeric),
        new JdeField("PRCMCU", "PRCMCU", JdeDataType.String, 24),
        new JdeField("PRCPNB", "PRCPNB", JdeDataType.Numeric),
        new JdeField("PRTRQTY", "PRTRQTY", JdeDataType.Numeric),
        new JdeField("PRLTRQT", "PRLTRQT", JdeDataType.Numeric),
        new JdeField("PRSOCN", "PRSOCN", JdeDataType.Numeric),
        new JdeField("PRUOM", "PRUOM", JdeDataType.String, 4),
        new JdeField("PRUM", "PRUM", JdeDataType.String, 4),
        new JdeField("PRFORQ", "PRFORQ", JdeDataType.String, 2),
        new JdeField("PRITC", "PRITC", JdeDataType.String, 2),
        new JdeField("PRRORN", "PRRORN", JdeDataType.String, 16),
        new JdeField("PRRCTO", "PRRCTO", JdeDataType.String, 4),
        new JdeField("PRRLLN", "PRRLLN", JdeDataType.Numeric),
        new JdeField("PRRKCO", "PRRKCO", JdeDataType.String, 10),
        new JdeField("PROPSQ", "PROPSQ", JdeDataType.Numeric),
        new JdeField("PRBSEQ", "PRBSEQ", JdeDataType.Numeric),
        new JdeField("PRRSCP", "PRRSCP", JdeDataType.Numeric),
        new JdeField("PRSCRP", "PRSCRP", JdeDataType.Numeric),
        new JdeField("PRREWP", "PRREWP", JdeDataType.Numeric),
        new JdeField("PRASIP", "PRASIP", JdeDataType.Numeric),
        new JdeField("PRCPYP", "PRCPYP", JdeDataType.Numeric),
        new JdeField("PRSTPP", "PRSTPP", JdeDataType.Numeric),
        new JdeField("PRLITM", "PRLITM", JdeDataType.String, 50),
        new JdeField("PRAITM", "PRAITM", JdeDataType.String, 50),
        new JdeField("PRDSC1", "PRDSC1", JdeDataType.String, 60),
        new JdeField("PRDSC2", "PRDSC2", JdeDataType.String, 60),
        new JdeField("PRLOCN", "PRLOCN", JdeDataType.String, 40),
        new JdeField("PRLOTN", "PRLOTN", JdeDataType.String, 60),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric),
        new JdeField("PRLNTY", "PRLNTY", JdeDataType.String, 4),
        new JdeField("PRSERN", "PRSERN", JdeDataType.String, 60),
        new JdeField("PRLTDATE", "PRLTDATE", JdeDataType.Date),
        new JdeField("PRUCNDJ", "PRUCNDJ", JdeDataType.Date),
        new JdeField("PRLRDATE", "PRLRDATE", JdeDataType.Date),
        new JdeField("PRCTS1", "PRCTS1", JdeDataType.Numeric),
        new JdeField("PRCTS4", "PRCTS4", JdeDataType.Numeric),
        new JdeField("PRCTS8", "PRCTS8", JdeDataType.Numeric),
        new JdeField("PRCTS7", "PRCTS7", JdeDataType.Numeric),
        new JdeField("PREA", "PREA", JdeDataType.Numeric),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24),
        new JdeField("PROMCU", "PROMCU", JdeDataType.String, 24),
        new JdeField("PROBJ", "PROBJ", JdeDataType.String, 12),
        new JdeField("PRSUB", "PRSUB", JdeDataType.String, 16),
        new JdeField("PRCMRV", "PRCMRV", JdeDataType.String, 6),
        new JdeField("PRVEND", "PRVEND", JdeDataType.Numeric),
        new JdeField("PRPOC", "PRPOC", JdeDataType.String, 2),
        new JdeField("PRLGLDATE", "PRLGLDATE", JdeDataType.Date),
        new JdeField("PRPSN", "PRPSN", JdeDataType.Numeric),
        new JdeField("PRLLEDATE", "PRLLEDATE", JdeDataType.Date),
        new JdeField("PRTRQT", "PRTRQT", JdeDataType.Numeric),
        new JdeField("PRTRSTS", "PRTRSTS", JdeDataType.String, 4),
        new JdeField("PRCOST", "PRCOST", JdeDataType.String, 6),
        new JdeField("PRCHPP", "PRCHPP", JdeDataType.String, 2),
        new JdeField("PRBSEQAN", "PRBSEQAN", JdeDataType.String, 10),
        new JdeField("PRTUSER", "PRTUSER", JdeDataType.String, 20),
        new JdeField("PRCUSER", "PRCUSER", JdeDataType.String, 20),
        new JdeField("PRURCD", "PRURCD", JdeDataType.String, 4),
        new JdeField("PRURDT", "PRURDT", JdeDataType.Numeric),
        new JdeField("PRURAT", "PRURAT", JdeDataType.Numeric),
        new JdeField("PRURRF", "PRURRF", JdeDataType.String, 30),
        new JdeField("PRURAB", "PRURAB", JdeDataType.Numeric),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRUUPMJ", "PRUUPMJ", JdeDataType.Date),
        new JdeField("PRMKEY", "PRMKEY", JdeDataType.String, 30),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31111S_0", "Primary Key on PRUKID", new[] { "PRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31111S_2", "Index on PRITM, PRCMCU, PRLTRQT", new[] { "PRITM", "PRCMCU", "PRLTRQT" }),
        new JdeIndex("FF31111S_3", "Index on PRMTID, PRPRODF31, PRTRSID", new[] { "PRMTID", "PRPRODF31", "PRTRSID" }),
        new JdeIndex("FF31111S_4", "Index on PRPRODF31, PRTRSID, PROPSQ", new[] { "PRPRODF31", "PRTRSID", "PROPSQ" }),
        new JdeIndex("FF31111S_5", "Index on PRITM, PRCMCU, PRLOCN, PRLOTN", new[] { "PRITM", "PRCMCU", "PRLOCN", "PRLOTN" })
    };
}
