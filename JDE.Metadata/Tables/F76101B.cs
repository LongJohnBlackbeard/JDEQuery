using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76101B - .
/// </summary>
public class F76101B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QXBRANFK.
        /// </summary>
        public const string QXBRANFK = "QXBRANFK";

        /// <summary>
        /// QXFCO.
        /// </summary>
        public const string QXFCO = "QXFCO";

        /// <summary>
        /// QXBNNF.
        /// </summary>
        public const string QXBNNF = "QXBNNF";

        /// <summary>
        /// QXBSER.
        /// </summary>
        public const string QXBSER = "QXBSER";

        /// <summary>
        /// QXN001.
        /// </summary>
        public const string QXN001 = "QXN001";

        /// <summary>
        /// QXDCT.
        /// </summary>
        public const string QXDCT = "QXDCT";

        /// <summary>
        /// QXBRAFOR.
        /// </summary>
        public const string QXBRAFOR = "QXBRAFOR";

        /// <summary>
        /// QXCO.
        /// </summary>
        public const string QXCO = "QXCO";

        /// <summary>
        /// QXMCU.
        /// </summary>
        public const string QXMCU = "QXMCU";

        /// <summary>
        /// QXAN8.
        /// </summary>
        public const string QXAN8 = "QXAN8";

        /// <summary>
        /// QXBCGC.
        /// </summary>
        public const string QXBCGC = "QXBCGC";

        /// <summary>
        /// QXBRAEST.
        /// </summary>
        public const string QXBRAEST = "QXBRAEST";

        /// <summary>
        /// QXBMUN.
        /// </summary>
        public const string QXBMUN = "QXBMUN";

        /// <summary>
        /// QXBICC.
        /// </summary>
        public const string QXBICC = "QXBICC";

        /// <summary>
        /// QXBRAANE.
        /// </summary>
        public const string QXBRAANE = "QXBRAANE";

        /// <summary>
        /// QXCTY1.
        /// </summary>
        public const string QXCTY1 = "QXCTY1";

        /// <summary>
        /// QXBRAUFE.
        /// </summary>
        public const string QXBRAUFE = "QXBRAUFE";

        /// <summary>
        /// QXBRAESE.
        /// </summary>
        public const string QXBRAESE = "QXBRAESE";

        /// <summary>
        /// QXBRAMUE.
        /// </summary>
        public const string QXBRAMUE = "QXBRAMUE";

        /// <summary>
        /// QXBRACGE.
        /// </summary>
        public const string QXBRACGE = "QXBRACGE";

        /// <summary>
        /// QXBRADLJ.
        /// </summary>
        public const string QXBRADLJ = "QXBRADLJ";

        /// <summary>
        /// QXBRADCL.
        /// </summary>
        public const string QXBRADCL = "QXBRADCL";

        /// <summary>
        /// QXBRADEJ.
        /// </summary>
        public const string QXBRADEJ = "QXBRADEJ";

        /// <summary>
        /// QXBRADEC.
        /// </summary>
        public const string QXBRADEC = "QXBRADEC";

        /// <summary>
        /// QXADDS.
        /// </summary>
        public const string QXADDS = "QXADDS";

        /// <summary>
        /// QXADDZ.
        /// </summary>
        public const string QXADDZ = "QXADDZ";

        /// <summary>
        /// QXBFRT.
        /// </summary>
        public const string QXBFRT = "QXBFRT";

        /// <summary>
        /// QXBSEG.
        /// </summary>
        public const string QXBSEG = "QXBSEG";

        /// <summary>
        /// QXBDFN.
        /// </summary>
        public const string QXBDFN = "QXBDFN";

        /// <summary>
        /// QXBRAVAL.
        /// </summary>
        public const string QXBRAVAL = "QXBRAVAL";

        /// <summary>
        /// QXBDES.
        /// </summary>
        public const string QXBDES = "QXBDES";

        /// <summary>
        /// QXBBTP.
        /// </summary>
        public const string QXBBTP = "QXBBTP";

        /// <summary>
        /// QXBIPI.
        /// </summary>
        public const string QXBIPI = "QXBIPI";

        /// <summary>
        /// QXBBCL.
        /// </summary>
        public const string QXBBCL = "QXBBCL";

        /// <summary>
        /// QXBICM.
        /// </summary>
        public const string QXBICM = "QXBICM";

        /// <summary>
        /// QXBRAAIC.
        /// </summary>
        public const string QXBRAAIC = "QXBRAAIC";

        /// <summary>
        /// QXBDIZ.
        /// </summary>
        public const string QXBDIZ = "QXBDIZ";

        /// <summary>
        /// QXBBIS.
        /// </summary>
        public const string QXBBIS = "QXBBIS";

        /// <summary>
        /// QXBVIS.
        /// </summary>
        public const string QXBVIS = "QXBVIS";

        /// <summary>
        /// QXBREP.
        /// </summary>
        public const string QXBREP = "QXBREP";

        /// <summary>
        /// QXBBCS.
        /// </summary>
        public const string QXBBCS = "QXBBCS";

        /// <summary>
        /// QXBISS.
        /// </summary>
        public const string QXBISS = "QXBISS";

        /// <summary>
        /// QXBVII.
        /// </summary>
        public const string QXBVII = "QXBVII";

        /// <summary>
        /// QXBVIP.
        /// </summary>
        public const string QXBVIP = "QXBVIP";

        /// <summary>
        /// QXBVOI.
        /// </summary>
        public const string QXBVOI = "QXBVOI";

        /// <summary>
        /// QXBVOP.
        /// </summary>
        public const string QXBVOP = "QXBVOP";

        /// <summary>
        /// QXBVTN.
        /// </summary>
        public const string QXBVTN = "QXBVTN";

        /// <summary>
        /// QXBRACM1.
        /// </summary>
        public const string QXBRACM1 = "QXBRACM1";

        /// <summary>
        /// QXBRAVF1.
        /// </summary>
        public const string QXBRAVF1 = "QXBRAVF1";

        /// <summary>
        /// QXBRACM2.
        /// </summary>
        public const string QXBRACM2 = "QXBRACM2";

        /// <summary>
        /// QXBRAVF2.
        /// </summary>
        public const string QXBRAVF2 = "QXBRAVF2";

        /// <summary>
        /// QXBRAOB1.
        /// </summary>
        public const string QXBRAOB1 = "QXBRAOB1";

        /// <summary>
        /// QXTRTY.
        /// </summary>
        public const string QXTRTY = "QXTRTY";

        /// <summary>
        /// QXBRAOB2.
        /// </summary>
        public const string QXBRAOB2 = "QXBRAOB2";

        /// <summary>
        /// QXUSER.
        /// </summary>
        public const string QXUSER = "QXUSER";

        /// <summary>
        /// QXPID.
        /// </summary>
        public const string QXPID = "QXPID";

        /// <summary>
        /// QXJOBN.
        /// </summary>
        public const string QXJOBN = "QXJOBN";

        /// <summary>
        /// QXUPMJ.
        /// </summary>
        public const string QXUPMJ = "QXUPMJ";

        /// <summary>
        /// QXUPMT.
        /// </summary>
        public const string QXUPMT = "QXUPMT";

        /// <summary>
        /// QXTDAY.
        /// </summary>
        public const string QXTDAY = "QXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76101B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QXBRANFK", "QXBRANFK", JdeDataType.Numeric, null, true, true),
        new JdeField("QXFCO", "QXFCO", JdeDataType.String, 10),
        new JdeField("QXBNNF", "QXBNNF", JdeDataType.Numeric),
        new JdeField("QXBSER", "QXBSER", JdeDataType.String, 4),
        new JdeField("QXN001", "QXN001", JdeDataType.Numeric),
        new JdeField("QXDCT", "QXDCT", JdeDataType.String, 4),
        new JdeField("QXBRAFOR", "QXBRAFOR", JdeDataType.Numeric),
        new JdeField("QXCO", "QXCO", JdeDataType.String, 10),
        new JdeField("QXMCU", "QXMCU", JdeDataType.String, 24),
        new JdeField("QXAN8", "QXAN8", JdeDataType.Numeric),
        new JdeField("QXBCGC", "QXBCGC", JdeDataType.String, 30),
        new JdeField("QXBRAEST", "QXBRAEST", JdeDataType.String, 40),
        new JdeField("QXBMUN", "QXBMUN", JdeDataType.String, 24),
        new JdeField("QXBICC", "QXBICC", JdeDataType.String, 2),
        new JdeField("QXBRAANE", "QXBRAANE", JdeDataType.Numeric),
        new JdeField("QXCTY1", "QXCTY1", JdeDataType.String, 50),
        new JdeField("QXBRAUFE", "QXBRAUFE", JdeDataType.String, 6),
        new JdeField("QXBRAESE", "QXBRAESE", JdeDataType.String, 40),
        new JdeField("QXBRAMUE", "QXBRAMUE", JdeDataType.String, 24),
        new JdeField("QXBRACGE", "QXBRACGE", JdeDataType.String, 30),
        new JdeField("QXBRADLJ", "QXBRADLJ", JdeDataType.Numeric),
        new JdeField("QXBRADCL", "QXBRADCL", JdeDataType.Numeric),
        new JdeField("QXBRADEJ", "QXBRADEJ", JdeDataType.Numeric),
        new JdeField("QXBRADEC", "QXBRADEC", JdeDataType.Numeric),
        new JdeField("QXADDS", "QXADDS", JdeDataType.String, 6),
        new JdeField("QXADDZ", "QXADDZ", JdeDataType.String, 24),
        new JdeField("QXBFRT", "QXBFRT", JdeDataType.Numeric),
        new JdeField("QXBSEG", "QXBSEG", JdeDataType.Numeric),
        new JdeField("QXBDFN", "QXBDFN", JdeDataType.Numeric),
        new JdeField("QXBRAVAL", "QXBRAVAL", JdeDataType.Numeric),
        new JdeField("QXBDES", "QXBDES", JdeDataType.Numeric),
        new JdeField("QXBBTP", "QXBBTP", JdeDataType.Numeric),
        new JdeField("QXBIPI", "QXBIPI", JdeDataType.Numeric),
        new JdeField("QXBBCL", "QXBBCL", JdeDataType.Numeric),
        new JdeField("QXBICM", "QXBICM", JdeDataType.Numeric),
        new JdeField("QXBRAAIC", "QXBRAAIC", JdeDataType.Numeric),
        new JdeField("QXBDIZ", "QXBDIZ", JdeDataType.Numeric),
        new JdeField("QXBBIS", "QXBBIS", JdeDataType.Numeric),
        new JdeField("QXBVIS", "QXBVIS", JdeDataType.Numeric),
        new JdeField("QXBREP", "QXBREP", JdeDataType.Numeric),
        new JdeField("QXBBCS", "QXBBCS", JdeDataType.Numeric),
        new JdeField("QXBISS", "QXBISS", JdeDataType.Numeric),
        new JdeField("QXBVII", "QXBVII", JdeDataType.Numeric),
        new JdeField("QXBVIP", "QXBVIP", JdeDataType.Numeric),
        new JdeField("QXBVOI", "QXBVOI", JdeDataType.Numeric),
        new JdeField("QXBVOP", "QXBVOP", JdeDataType.Numeric),
        new JdeField("QXBVTN", "QXBVTN", JdeDataType.Numeric),
        new JdeField("QXBRACM1", "QXBRACM1", JdeDataType.Numeric),
        new JdeField("QXBRAVF1", "QXBRAVF1", JdeDataType.Numeric),
        new JdeField("QXBRACM2", "QXBRACM2", JdeDataType.Numeric),
        new JdeField("QXBRAVF2", "QXBRAVF2", JdeDataType.Numeric),
        new JdeField("QXBRAOB1", "QXBRAOB1", JdeDataType.Numeric),
        new JdeField("QXTRTY", "QXTRTY", JdeDataType.String, 6),
        new JdeField("QXBRAOB2", "QXBRAOB2", JdeDataType.String, 2),
        new JdeField("QXUSER", "QXUSER", JdeDataType.String, 20),
        new JdeField("QXPID", "QXPID", JdeDataType.String, 20),
        new JdeField("QXJOBN", "QXJOBN", JdeDataType.String, 20),
        new JdeField("QXUPMJ", "QXUPMJ", JdeDataType.Numeric),
        new JdeField("QXUPMT", "QXUPMT", JdeDataType.Numeric),
        new JdeField("QXTDAY", "QXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76101B_0", "Primary Key on QXBRANFK", new[] { "QXBRANFK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76101B_2", "Index on QXFCO, QXBNNF, QXBSER, QXDCT, QXBRAFOR", new[] { "QXFCO", "QXBNNF", "QXBSER", "QXDCT", "QXBRAFOR" }),
        new JdeIndex("F76101B_3", "Index on QXBNNF, QXBSER, QXN001, QXDCT", new[] { "QXBNNF", "QXBSER", "QXN001", "QXDCT" }),
        new JdeIndex("F76101B_4", "Index on QXFCO, QXBNNF, QXBSER, QXDCT, QXBRAANE, QXAN8", new[] { "QXFCO", "QXBNNF", "QXBSER", "QXDCT", "QXBRAANE", "QXAN8" }),
        new JdeIndex("F76101B_5", "Index on QXFCO, QXBNNF, QXBSER, QXDCT, QXBRAANE, QXAN8, QXN001", new[] { "QXFCO", "QXBNNF", "QXBSER", "QXDCT", "QXBRAANE", "QXAN8", "QXN001" })
    };
}
