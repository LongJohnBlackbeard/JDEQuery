using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01301D - .
/// </summary>
public class F01301D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADINSTID.
        /// </summary>
        public const string ADINSTID = "ADINSTID";

        /// <summary>
        /// ADACTIVID.
        /// </summary>
        public const string ADACTIVID = "ADACTIVID";

        /// <summary>
        /// ADINDID.
        /// </summary>
        public const string ADINDID = "ADINDID";

        /// <summary>
        /// ADINDIDTY.
        /// </summary>
        public const string ADINDIDTY = "ADINDIDTY";

        /// <summary>
        /// ADCALTY.
        /// </summary>
        public const string ADCALTY = "ADCALTY";

        /// <summary>
        /// ADPACTVID.
        /// </summary>
        public const string ADPACTVID = "ADPACTVID";

        /// <summary>
        /// ADACTVTYP.
        /// </summary>
        public const string ADACTVTYP = "ADACTVTYP";

        /// <summary>
        /// ADSUBJECT.
        /// </summary>
        public const string ADSUBJECT = "ADSUBJECT";

        /// <summary>
        /// ADACTVDESC.
        /// </summary>
        public const string ADACTVDESC = "ADACTVDESC";

        /// <summary>
        /// ADLOCATION.
        /// </summary>
        public const string ADLOCATION = "ADLOCATION";

        /// <summary>
        /// ADORIGNTOR.
        /// </summary>
        public const string ADORIGNTOR = "ADORIGNTOR";

        /// <summary>
        /// ADTDSTR.
        /// </summary>
        public const string ADTDSTR = "ADTDSTR";

        /// <summary>
        /// ADTDEND.
        /// </summary>
        public const string ADTDEND = "ADTDEND";

        /// <summary>
        /// ADALRM.
        /// </summary>
        public const string ADALRM = "ADALRM";

        /// <summary>
        /// ADLEADTIME.
        /// </summary>
        public const string ADLEADTIME = "ADLEADTIME";

        /// <summary>
        /// ADLEADTMEU.
        /// </summary>
        public const string ADLEADTMEU = "ADLEADTMEU";

        /// <summary>
        /// ADACTCAT.
        /// </summary>
        public const string ADACTCAT = "ADACTCAT";

        /// <summary>
        /// ADACTVPSF.
        /// </summary>
        public const string ADACTVPSF = "ADACTVPSF";

        /// <summary>
        /// ADCOMITLVL.
        /// </summary>
        public const string ADCOMITLVL = "ADCOMITLVL";

        /// <summary>
        /// ADADI.
        /// </summary>
        public const string ADADI = "ADADI";

        /// <summary>
        /// ADRECURID.
        /// </summary>
        public const string ADRECURID = "ADRECURID";

        /// <summary>
        /// ADRCCUR.
        /// </summary>
        public const string ADRCCUR = "ADRCCUR";

        /// <summary>
        /// ADACTPRV.
        /// </summary>
        public const string ADACTPRV = "ADACTPRV";

        /// <summary>
        /// ADACTCMPL.
        /// </summary>
        public const string ADACTCMPL = "ADACTCMPL";

        /// <summary>
        /// ADTDCMPL.
        /// </summary>
        public const string ADTDCMPL = "ADTDCMPL";

        /// <summary>
        /// ADINTE.
        /// </summary>
        public const string ADINTE = "ADINTE";

        /// <summary>
        /// ADSTPIM.
        /// </summary>
        public const string ADSTPIM = "ADSTPIM";

        /// <summary>
        /// ADDOCAL.
        /// </summary>
        public const string ADDOCAL = "ADDOCAL";

        /// <summary>
        /// ADACCNT.
        /// </summary>
        public const string ADACCNT = "ADACCNT";

        /// <summary>
        /// ADPARTN.
        /// </summary>
        public const string ADPARTN = "ADPARTN";

        /// <summary>
        /// ADACCNTC.
        /// </summary>
        public const string ADACCNTC = "ADACCNTC";

        /// <summary>
        /// ADPARTNC.
        /// </summary>
        public const string ADPARTNC = "ADPARTNC";

        /// <summary>
        /// ADPLNTY.
        /// </summary>
        public const string ADPLNTY = "ADPLNTY";

        /// <summary>
        /// ADISTODO.
        /// </summary>
        public const string ADISTODO = "ADISTODO";

        /// <summary>
        /// ADATVCD1.
        /// </summary>
        public const string ADATVCD1 = "ADATVCD1";

        /// <summary>
        /// ADATVCD2.
        /// </summary>
        public const string ADATVCD2 = "ADATVCD2";

        /// <summary>
        /// ADATVCD3.
        /// </summary>
        public const string ADATVCD3 = "ADATVCD3";

        /// <summary>
        /// ADATVCD4.
        /// </summary>
        public const string ADATVCD4 = "ADATVCD4";

        /// <summary>
        /// ADATVCD5.
        /// </summary>
        public const string ADATVCD5 = "ADATVCD5";

        /// <summary>
        /// ADURCH.
        /// </summary>
        public const string ADURCH = "ADURCH";

        /// <summary>
        /// ADURNUM.
        /// </summary>
        public const string ADURNUM = "ADURNUM";

        /// <summary>
        /// ADDOCO.
        /// </summary>
        public const string ADDOCO = "ADDOCO";

        /// <summary>
        /// ADURTIME.
        /// </summary>
        public const string ADURTIME = "ADURTIME";

        /// <summary>
        /// ADIDAN8.
        /// </summary>
        public const string ADIDAN8 = "ADIDAN8";

        /// <summary>
        /// ADUDTTM.
        /// </summary>
        public const string ADUDTTM = "ADUDTTM";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADEDATE.
        /// </summary>
        public const string ADEDATE = "ADEDATE";

        /// <summary>
        /// ADMKEY.
        /// </summary>
        public const string ADMKEY = "ADMKEY";

        /// <summary>
        /// ADENTDBY.
        /// </summary>
        public const string ADENTDBY = "ADENTDBY";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADOWNERID.
        /// </summary>
        public const string ADOWNERID = "ADOWNERID";

        /// <summary>
        /// ADOWNERIDT.
        /// </summary>
        public const string ADOWNERIDT = "ADOWNERIDT";

        /// <summary>
        /// ADOWNCALT.
        /// </summary>
        public const string ADOWNCALT = "ADOWNCALT";

        /// <summary>
        /// ADANOMALY.
        /// </summary>
        public const string ADANOMALY = "ADANOMALY";

        /// <summary>
        /// ADLEADID.
        /// </summary>
        public const string ADLEADID = "ADLEADID";

        /// <summary>
        /// ADOPPID.
        /// </summary>
        public const string ADOPPID = "ADOPPID";

        /// <summary>
        /// ADACSTS.
        /// </summary>
        public const string ADACSTS = "ADACSTS";

        /// <summary>
        /// ADOUTRES.
        /// </summary>
        public const string ADOUTRES = "ADOUTRES";

        /// <summary>
        /// ADACTINST.
        /// </summary>
        public const string ADACTINST = "ADACTINST";

        /// <summary>
        /// ADCO.
        /// </summary>
        public const string ADCO = "ADCO";
    }

    /// <inheritdoc />
    public override string TableName => "F01301D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADINSTID", "ADINSTID", JdeDataType.String, 72, true, true),
        new JdeField("ADACTIVID", "ADACTIVID", JdeDataType.String, 72),
        new JdeField("ADINDID", "ADINDID", JdeDataType.String, 32),
        new JdeField("ADINDIDTY", "ADINDIDTY", JdeDataType.String, 100),
        new JdeField("ADCALTY", "ADCALTY", JdeDataType.String, 100),
        new JdeField("ADPACTVID", "ADPACTVID", JdeDataType.String, 74),
        new JdeField("ADACTVTYP", "ADACTVTYP", JdeDataType.String, 82),
        new JdeField("ADSUBJECT", "ADSUBJECT", JdeDataType.String, 102),
        new JdeField("ADACTVDESC", "ADACTVDESC", JdeDataType.String, 3998),
        new JdeField("ADLOCATION", "ADLOCATION", JdeDataType.String, 102),
        new JdeField("ADORIGNTOR", "ADORIGNTOR", JdeDataType.Numeric),
        new JdeField("ADTDSTR", "ADTDSTR", JdeDataType.Date),
        new JdeField("ADTDEND", "ADTDEND", JdeDataType.Date),
        new JdeField("ADALRM", "ADALRM", JdeDataType.String, 2),
        new JdeField("ADLEADTIME", "ADLEADTIME", JdeDataType.Numeric),
        new JdeField("ADLEADTMEU", "ADLEADTMEU", JdeDataType.String, 82),
        new JdeField("ADACTCAT", "ADACTCAT", JdeDataType.String, 102),
        new JdeField("ADACTVPSF", "ADACTVPSF", JdeDataType.String, 2),
        new JdeField("ADCOMITLVL", "ADCOMITLVL", JdeDataType.Numeric),
        new JdeField("ADADI", "ADADI", JdeDataType.String, 2),
        new JdeField("ADRECURID", "ADRECURID", JdeDataType.String, 72),
        new JdeField("ADRCCUR", "ADRCCUR", JdeDataType.String, 2),
        new JdeField("ADACTPRV", "ADACTPRV", JdeDataType.String, 2),
        new JdeField("ADACTCMPL", "ADACTCMPL", JdeDataType.String, 2),
        new JdeField("ADTDCMPL", "ADTDCMPL", JdeDataType.Date),
        new JdeField("ADINTE", "ADINTE", JdeDataType.String, 2),
        new JdeField("ADSTPIM", "ADSTPIM", JdeDataType.String, 2),
        new JdeField("ADDOCAL", "ADDOCAL", JdeDataType.String, 2),
        new JdeField("ADACCNT", "ADACCNT", JdeDataType.Numeric),
        new JdeField("ADPARTN", "ADPARTN", JdeDataType.Numeric),
        new JdeField("ADACCNTC", "ADACCNTC", JdeDataType.Numeric),
        new JdeField("ADPARTNC", "ADPARTNC", JdeDataType.Numeric),
        new JdeField("ADPLNTY", "ADPLNTY", JdeDataType.String, 6),
        new JdeField("ADISTODO", "ADISTODO", JdeDataType.String, 2),
        new JdeField("ADATVCD1", "ADATVCD1", JdeDataType.String, 6),
        new JdeField("ADATVCD2", "ADATVCD2", JdeDataType.String, 6),
        new JdeField("ADATVCD3", "ADATVCD3", JdeDataType.String, 6),
        new JdeField("ADATVCD4", "ADATVCD4", JdeDataType.String, 6),
        new JdeField("ADATVCD5", "ADATVCD5", JdeDataType.String, 6),
        new JdeField("ADURCH", "ADURCH", JdeDataType.String, 100),
        new JdeField("ADURNUM", "ADURNUM", JdeDataType.Numeric),
        new JdeField("ADDOCO", "ADDOCO", JdeDataType.Numeric),
        new JdeField("ADURTIME", "ADURTIME", JdeDataType.Date),
        new JdeField("ADIDAN8", "ADIDAN8", JdeDataType.Numeric),
        new JdeField("ADUDTTM", "ADUDTTM", JdeDataType.Date),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADEDATE", "ADEDATE", JdeDataType.Date),
        new JdeField("ADMKEY", "ADMKEY", JdeDataType.String, 30),
        new JdeField("ADENTDBY", "ADENTDBY", JdeDataType.Numeric),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADOWNERID", "ADOWNERID", JdeDataType.String, 32),
        new JdeField("ADOWNERIDT", "ADOWNERIDT", JdeDataType.String, 100),
        new JdeField("ADOWNCALT", "ADOWNCALT", JdeDataType.String, 100),
        new JdeField("ADANOMALY", "ADANOMALY", JdeDataType.String, 2),
        new JdeField("ADLEADID", "ADLEADID", JdeDataType.Numeric),
        new JdeField("ADOPPID", "ADOPPID", JdeDataType.Numeric),
        new JdeField("ADACSTS", "ADACSTS", JdeDataType.String, 2),
        new JdeField("ADOUTRES", "ADOUTRES", JdeDataType.String, 20),
        new JdeField("ADACTINST", "ADACTINST", JdeDataType.Numeric),
        new JdeField("ADCO", "ADCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01301D_0", "Primary Key on ADINSTID", new[] { "ADINSTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01301D_2", "Index on ADACTIVID, ADACTINST", new[] { "ADACTIVID", "ADACTINST" }),
        new JdeIndex("F01301D_3", "Index on ADPACTVID, ADANOMALY, ADACTINST", new[] { "ADPACTVID", "ADANOMALY", "ADACTINST" }),
        new JdeIndex("F01301D_4", "Index on ADDOCO", new[] { "ADDOCO" }),
        new JdeIndex("F01301D_5", "Index on ADLEADID", new[] { "ADLEADID" }),
        new JdeIndex("F01301D_6", "Index on ADOPPID", new[] { "ADOPPID" }),
        new JdeIndex("F01301D_8", "Index on ADACCNT, ADCO, ADACCNTC", new[] { "ADACCNT", "ADCO", "ADACCNTC" }),
        new JdeIndex("F01301D_9", "Index on ADPARTN, ADPARTNC", new[] { "ADPARTN", "ADPARTNC" })
    };
}
