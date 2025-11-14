using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31111 - .
/// </summary>
public class FF31111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLUKID.
        /// </summary>
        public const string PLUKID = "PLUKID";

        /// <summary>
        /// PLMTID.
        /// </summary>
        public const string PLMTID = "PLMTID";

        /// <summary>
        /// PLPRODF31.
        /// </summary>
        public const string PLPRODF31 = "PLPRODF31";

        /// <summary>
        /// PLTRSID.
        /// </summary>
        public const string PLTRSID = "PLTRSID";

        /// <summary>
        /// PLDFMLINE.
        /// </summary>
        public const string PLDFMLINE = "PLDFMLINE";

        /// <summary>
        /// PLKIT.
        /// </summary>
        public const string PLKIT = "PLKIT";

        /// <summary>
        /// PLMMCU.
        /// </summary>
        public const string PLMMCU = "PLMMCU";

        /// <summary>
        /// PLITM.
        /// </summary>
        public const string PLITM = "PLITM";

        /// <summary>
        /// PLCMCU.
        /// </summary>
        public const string PLCMCU = "PLCMCU";

        /// <summary>
        /// PLCPNB.
        /// </summary>
        public const string PLCPNB = "PLCPNB";

        /// <summary>
        /// PLTRQTY.
        /// </summary>
        public const string PLTRQTY = "PLTRQTY";

        /// <summary>
        /// PLLTRQT.
        /// </summary>
        public const string PLLTRQT = "PLLTRQT";

        /// <summary>
        /// PLSOCN.
        /// </summary>
        public const string PLSOCN = "PLSOCN";

        /// <summary>
        /// PLUOM.
        /// </summary>
        public const string PLUOM = "PLUOM";

        /// <summary>
        /// PLUM.
        /// </summary>
        public const string PLUM = "PLUM";

        /// <summary>
        /// PLFORQ.
        /// </summary>
        public const string PLFORQ = "PLFORQ";

        /// <summary>
        /// PLITC.
        /// </summary>
        public const string PLITC = "PLITC";

        /// <summary>
        /// PLRORN.
        /// </summary>
        public const string PLRORN = "PLRORN";

        /// <summary>
        /// PLRCTO.
        /// </summary>
        public const string PLRCTO = "PLRCTO";

        /// <summary>
        /// PLRLLN.
        /// </summary>
        public const string PLRLLN = "PLRLLN";

        /// <summary>
        /// PLRKCO.
        /// </summary>
        public const string PLRKCO = "PLRKCO";

        /// <summary>
        /// PLOPSQ.
        /// </summary>
        public const string PLOPSQ = "PLOPSQ";

        /// <summary>
        /// PLBSEQ.
        /// </summary>
        public const string PLBSEQ = "PLBSEQ";

        /// <summary>
        /// PLRSCP.
        /// </summary>
        public const string PLRSCP = "PLRSCP";

        /// <summary>
        /// PLSCRP.
        /// </summary>
        public const string PLSCRP = "PLSCRP";

        /// <summary>
        /// PLREWP.
        /// </summary>
        public const string PLREWP = "PLREWP";

        /// <summary>
        /// PLASIP.
        /// </summary>
        public const string PLASIP = "PLASIP";

        /// <summary>
        /// PLCPYP.
        /// </summary>
        public const string PLCPYP = "PLCPYP";

        /// <summary>
        /// PLSTPP.
        /// </summary>
        public const string PLSTPP = "PLSTPP";

        /// <summary>
        /// PLLITM.
        /// </summary>
        public const string PLLITM = "PLLITM";

        /// <summary>
        /// PLAITM.
        /// </summary>
        public const string PLAITM = "PLAITM";

        /// <summary>
        /// PLDSC1.
        /// </summary>
        public const string PLDSC1 = "PLDSC1";

        /// <summary>
        /// PLDSC2.
        /// </summary>
        public const string PLDSC2 = "PLDSC2";

        /// <summary>
        /// PLLOCN.
        /// </summary>
        public const string PLLOCN = "PLLOCN";

        /// <summary>
        /// PLLOTN.
        /// </summary>
        public const string PLLOTN = "PLLOTN";

        /// <summary>
        /// PLAN8.
        /// </summary>
        public const string PLAN8 = "PLAN8";

        /// <summary>
        /// PLLNTY.
        /// </summary>
        public const string PLLNTY = "PLLNTY";

        /// <summary>
        /// PLSERN.
        /// </summary>
        public const string PLSERN = "PLSERN";

        /// <summary>
        /// PLLTDATE.
        /// </summary>
        public const string PLLTDATE = "PLLTDATE";

        /// <summary>
        /// PLUCNDJ.
        /// </summary>
        public const string PLUCNDJ = "PLUCNDJ";

        /// <summary>
        /// PLLRDATE.
        /// </summary>
        public const string PLLRDATE = "PLLRDATE";

        /// <summary>
        /// PLCTS1.
        /// </summary>
        public const string PLCTS1 = "PLCTS1";

        /// <summary>
        /// PLCTS4.
        /// </summary>
        public const string PLCTS4 = "PLCTS4";

        /// <summary>
        /// PLCTS8.
        /// </summary>
        public const string PLCTS8 = "PLCTS8";

        /// <summary>
        /// PLCTS7.
        /// </summary>
        public const string PLCTS7 = "PLCTS7";

        /// <summary>
        /// PLEA.
        /// </summary>
        public const string PLEA = "PLEA";

        /// <summary>
        /// PLDCT.
        /// </summary>
        public const string PLDCT = "PLDCT";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLOMCU.
        /// </summary>
        public const string PLOMCU = "PLOMCU";

        /// <summary>
        /// PLOBJ.
        /// </summary>
        public const string PLOBJ = "PLOBJ";

        /// <summary>
        /// PLSUB.
        /// </summary>
        public const string PLSUB = "PLSUB";

        /// <summary>
        /// PLCMRV.
        /// </summary>
        public const string PLCMRV = "PLCMRV";

        /// <summary>
        /// PLVEND.
        /// </summary>
        public const string PLVEND = "PLVEND";

        /// <summary>
        /// PLPOC.
        /// </summary>
        public const string PLPOC = "PLPOC";

        /// <summary>
        /// PLLGLDATE.
        /// </summary>
        public const string PLLGLDATE = "PLLGLDATE";

        /// <summary>
        /// PLPSN.
        /// </summary>
        public const string PLPSN = "PLPSN";

        /// <summary>
        /// PLLLEDATE.
        /// </summary>
        public const string PLLLEDATE = "PLLLEDATE";

        /// <summary>
        /// PLTRQT.
        /// </summary>
        public const string PLTRQT = "PLTRQT";

        /// <summary>
        /// PLTRSTS.
        /// </summary>
        public const string PLTRSTS = "PLTRSTS";

        /// <summary>
        /// PLCOST.
        /// </summary>
        public const string PLCOST = "PLCOST";

        /// <summary>
        /// PLCHPP.
        /// </summary>
        public const string PLCHPP = "PLCHPP";

        /// <summary>
        /// PLBSEQAN.
        /// </summary>
        public const string PLBSEQAN = "PLBSEQAN";

        /// <summary>
        /// PLTUSER.
        /// </summary>
        public const string PLTUSER = "PLTUSER";

        /// <summary>
        /// PLCUSER.
        /// </summary>
        public const string PLCUSER = "PLCUSER";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLUUPMJ.
        /// </summary>
        public const string PLUUPMJ = "PLUUPMJ";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";
    }

    /// <inheritdoc />
    public override string TableName => "FF31111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLUKID", "PLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLMTID", "PLMTID", JdeDataType.Numeric),
        new JdeField("PLPRODF31", "PLPRODF31", JdeDataType.Numeric),
        new JdeField("PLTRSID", "PLTRSID", JdeDataType.Numeric),
        new JdeField("PLDFMLINE", "PLDFMLINE", JdeDataType.String, 24),
        new JdeField("PLKIT", "PLKIT", JdeDataType.Numeric),
        new JdeField("PLMMCU", "PLMMCU", JdeDataType.String, 24),
        new JdeField("PLITM", "PLITM", JdeDataType.Numeric),
        new JdeField("PLCMCU", "PLCMCU", JdeDataType.String, 24),
        new JdeField("PLCPNB", "PLCPNB", JdeDataType.Numeric),
        new JdeField("PLTRQTY", "PLTRQTY", JdeDataType.Numeric),
        new JdeField("PLLTRQT", "PLLTRQT", JdeDataType.Numeric),
        new JdeField("PLSOCN", "PLSOCN", JdeDataType.Numeric),
        new JdeField("PLUOM", "PLUOM", JdeDataType.String, 4),
        new JdeField("PLUM", "PLUM", JdeDataType.String, 4),
        new JdeField("PLFORQ", "PLFORQ", JdeDataType.String, 2),
        new JdeField("PLITC", "PLITC", JdeDataType.String, 2),
        new JdeField("PLRORN", "PLRORN", JdeDataType.String, 16),
        new JdeField("PLRCTO", "PLRCTO", JdeDataType.String, 4),
        new JdeField("PLRLLN", "PLRLLN", JdeDataType.Numeric),
        new JdeField("PLRKCO", "PLRKCO", JdeDataType.String, 10),
        new JdeField("PLOPSQ", "PLOPSQ", JdeDataType.Numeric),
        new JdeField("PLBSEQ", "PLBSEQ", JdeDataType.Numeric),
        new JdeField("PLRSCP", "PLRSCP", JdeDataType.Numeric),
        new JdeField("PLSCRP", "PLSCRP", JdeDataType.Numeric),
        new JdeField("PLREWP", "PLREWP", JdeDataType.Numeric),
        new JdeField("PLASIP", "PLASIP", JdeDataType.Numeric),
        new JdeField("PLCPYP", "PLCPYP", JdeDataType.Numeric),
        new JdeField("PLSTPP", "PLSTPP", JdeDataType.Numeric),
        new JdeField("PLLITM", "PLLITM", JdeDataType.String, 50),
        new JdeField("PLAITM", "PLAITM", JdeDataType.String, 50),
        new JdeField("PLDSC1", "PLDSC1", JdeDataType.String, 60),
        new JdeField("PLDSC2", "PLDSC2", JdeDataType.String, 60),
        new JdeField("PLLOCN", "PLLOCN", JdeDataType.String, 40),
        new JdeField("PLLOTN", "PLLOTN", JdeDataType.String, 60),
        new JdeField("PLAN8", "PLAN8", JdeDataType.Numeric),
        new JdeField("PLLNTY", "PLLNTY", JdeDataType.String, 4),
        new JdeField("PLSERN", "PLSERN", JdeDataType.String, 60),
        new JdeField("PLLTDATE", "PLLTDATE", JdeDataType.Date),
        new JdeField("PLUCNDJ", "PLUCNDJ", JdeDataType.Date),
        new JdeField("PLLRDATE", "PLLRDATE", JdeDataType.Date),
        new JdeField("PLCTS1", "PLCTS1", JdeDataType.Numeric),
        new JdeField("PLCTS4", "PLCTS4", JdeDataType.Numeric),
        new JdeField("PLCTS8", "PLCTS8", JdeDataType.Numeric),
        new JdeField("PLCTS7", "PLCTS7", JdeDataType.Numeric),
        new JdeField("PLEA", "PLEA", JdeDataType.Numeric),
        new JdeField("PLDCT", "PLDCT", JdeDataType.String, 4),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24),
        new JdeField("PLOMCU", "PLOMCU", JdeDataType.String, 24),
        new JdeField("PLOBJ", "PLOBJ", JdeDataType.String, 12),
        new JdeField("PLSUB", "PLSUB", JdeDataType.String, 16),
        new JdeField("PLCMRV", "PLCMRV", JdeDataType.String, 6),
        new JdeField("PLVEND", "PLVEND", JdeDataType.Numeric),
        new JdeField("PLPOC", "PLPOC", JdeDataType.String, 2),
        new JdeField("PLLGLDATE", "PLLGLDATE", JdeDataType.Date),
        new JdeField("PLPSN", "PLPSN", JdeDataType.Numeric),
        new JdeField("PLLLEDATE", "PLLLEDATE", JdeDataType.Date),
        new JdeField("PLTRQT", "PLTRQT", JdeDataType.Numeric),
        new JdeField("PLTRSTS", "PLTRSTS", JdeDataType.String, 4),
        new JdeField("PLCOST", "PLCOST", JdeDataType.String, 6),
        new JdeField("PLCHPP", "PLCHPP", JdeDataType.String, 2),
        new JdeField("PLBSEQAN", "PLBSEQAN", JdeDataType.String, 10),
        new JdeField("PLTUSER", "PLTUSER", JdeDataType.String, 20),
        new JdeField("PLCUSER", "PLCUSER", JdeDataType.String, 20),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLUUPMJ", "PLUUPMJ", JdeDataType.Date),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31111_0", "Primary Key on PLUKID", new[] { "PLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31111_2", "Index on PLITM, PLCMCU, PLLTRQT", new[] { "PLITM", "PLCMCU", "PLLTRQT" }),
        new JdeIndex("FF31111_3", "Index on PLMTID, PLPRODF31, PLTRSID", new[] { "PLMTID", "PLPRODF31", "PLTRSID" }),
        new JdeIndex("FF31111_4", "Index on PLPRODF31, PLTRSID, PLOPSQ", new[] { "PLPRODF31", "PLTRSID", "PLOPSQ" }),
        new JdeIndex("FF31111_5", "Index on PLITM, PLCMCU, PLLOCN, PLLOTN", new[] { "PLITM", "PLCMCU", "PLLOCN", "PLLOTN" })
    };
}
