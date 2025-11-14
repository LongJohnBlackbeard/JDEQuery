using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01301 - .
/// </summary>
public class F01301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMACTIVID.
        /// </summary>
        public const string AMACTIVID = "AMACTIVID";

        /// <summary>
        /// AMINDID.
        /// </summary>
        public const string AMINDID = "AMINDID";

        /// <summary>
        /// AMINDIDTY.
        /// </summary>
        public const string AMINDIDTY = "AMINDIDTY";

        /// <summary>
        /// AMCALTY.
        /// </summary>
        public const string AMCALTY = "AMCALTY";

        /// <summary>
        /// AMPACTVID.
        /// </summary>
        public const string AMPACTVID = "AMPACTVID";

        /// <summary>
        /// AMACTVTYP.
        /// </summary>
        public const string AMACTVTYP = "AMACTVTYP";

        /// <summary>
        /// AMSUBJECT.
        /// </summary>
        public const string AMSUBJECT = "AMSUBJECT";

        /// <summary>
        /// AMACTVDESC.
        /// </summary>
        public const string AMACTVDESC = "AMACTVDESC";

        /// <summary>
        /// AMLOCATION.
        /// </summary>
        public const string AMLOCATION = "AMLOCATION";

        /// <summary>
        /// AMORIGNTOR.
        /// </summary>
        public const string AMORIGNTOR = "AMORIGNTOR";

        /// <summary>
        /// AMTDSTR.
        /// </summary>
        public const string AMTDSTR = "AMTDSTR";

        /// <summary>
        /// AMTDEND.
        /// </summary>
        public const string AMTDEND = "AMTDEND";

        /// <summary>
        /// AMALRM.
        /// </summary>
        public const string AMALRM = "AMALRM";

        /// <summary>
        /// AMLEADTIME.
        /// </summary>
        public const string AMLEADTIME = "AMLEADTIME";

        /// <summary>
        /// AMLEADTMEU.
        /// </summary>
        public const string AMLEADTMEU = "AMLEADTMEU";

        /// <summary>
        /// AMACTCAT.
        /// </summary>
        public const string AMACTCAT = "AMACTCAT";

        /// <summary>
        /// AMACTVPSF.
        /// </summary>
        public const string AMACTVPSF = "AMACTVPSF";

        /// <summary>
        /// AMCOMITLVL.
        /// </summary>
        public const string AMCOMITLVL = "AMCOMITLVL";

        /// <summary>
        /// AMADI.
        /// </summary>
        public const string AMADI = "AMADI";

        /// <summary>
        /// AMRECURID.
        /// </summary>
        public const string AMRECURID = "AMRECURID";

        /// <summary>
        /// AMRCCUR.
        /// </summary>
        public const string AMRCCUR = "AMRCCUR";

        /// <summary>
        /// AMACTPRV.
        /// </summary>
        public const string AMACTPRV = "AMACTPRV";

        /// <summary>
        /// AMACTCMPL.
        /// </summary>
        public const string AMACTCMPL = "AMACTCMPL";

        /// <summary>
        /// AMTDCMPL.
        /// </summary>
        public const string AMTDCMPL = "AMTDCMPL";

        /// <summary>
        /// AMTDLDS.
        /// </summary>
        public const string AMTDLDS = "AMTDLDS";

        /// <summary>
        /// AMINTE.
        /// </summary>
        public const string AMINTE = "AMINTE";

        /// <summary>
        /// AMSTPIM.
        /// </summary>
        public const string AMSTPIM = "AMSTPIM";

        /// <summary>
        /// AMDOCAL.
        /// </summary>
        public const string AMDOCAL = "AMDOCAL";

        /// <summary>
        /// AMACCNT.
        /// </summary>
        public const string AMACCNT = "AMACCNT";

        /// <summary>
        /// AMPARTN.
        /// </summary>
        public const string AMPARTN = "AMPARTN";

        /// <summary>
        /// AMACCNTC.
        /// </summary>
        public const string AMACCNTC = "AMACCNTC";

        /// <summary>
        /// AMPARTNC.
        /// </summary>
        public const string AMPARTNC = "AMPARTNC";

        /// <summary>
        /// AMPLNTY.
        /// </summary>
        public const string AMPLNTY = "AMPLNTY";

        /// <summary>
        /// AMISTODO.
        /// </summary>
        public const string AMISTODO = "AMISTODO";

        /// <summary>
        /// AMATVCD1.
        /// </summary>
        public const string AMATVCD1 = "AMATVCD1";

        /// <summary>
        /// AMATVCD2.
        /// </summary>
        public const string AMATVCD2 = "AMATVCD2";

        /// <summary>
        /// AMATVCD3.
        /// </summary>
        public const string AMATVCD3 = "AMATVCD3";

        /// <summary>
        /// AMATVCD4.
        /// </summary>
        public const string AMATVCD4 = "AMATVCD4";

        /// <summary>
        /// AMATVCD5.
        /// </summary>
        public const string AMATVCD5 = "AMATVCD5";

        /// <summary>
        /// AMURCH.
        /// </summary>
        public const string AMURCH = "AMURCH";

        /// <summary>
        /// AMURNUM.
        /// </summary>
        public const string AMURNUM = "AMURNUM";

        /// <summary>
        /// AMURTIME.
        /// </summary>
        public const string AMURTIME = "AMURTIME";

        /// <summary>
        /// AMIDAN8.
        /// </summary>
        public const string AMIDAN8 = "AMIDAN8";

        /// <summary>
        /// AMUDTTM.
        /// </summary>
        public const string AMUDTTM = "AMUDTTM";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMEDATE.
        /// </summary>
        public const string AMEDATE = "AMEDATE";

        /// <summary>
        /// AMMKEY.
        /// </summary>
        public const string AMMKEY = "AMMKEY";

        /// <summary>
        /// AMENTDBY.
        /// </summary>
        public const string AMENTDBY = "AMENTDBY";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMOWNERID.
        /// </summary>
        public const string AMOWNERID = "AMOWNERID";

        /// <summary>
        /// AMOWNERIDT.
        /// </summary>
        public const string AMOWNERIDT = "AMOWNERIDT";

        /// <summary>
        /// AMOWNCALT.
        /// </summary>
        public const string AMOWNCALT = "AMOWNCALT";

        /// <summary>
        /// AMANOMALY.
        /// </summary>
        public const string AMANOMALY = "AMANOMALY";

        /// <summary>
        /// AMDOCO.
        /// </summary>
        public const string AMDOCO = "AMDOCO";

        /// <summary>
        /// AMLEADID.
        /// </summary>
        public const string AMLEADID = "AMLEADID";

        /// <summary>
        /// AMOPPID.
        /// </summary>
        public const string AMOPPID = "AMOPPID";

        /// <summary>
        /// AMACSTS.
        /// </summary>
        public const string AMACSTS = "AMACSTS";

        /// <summary>
        /// AMOUTRES.
        /// </summary>
        public const string AMOUTRES = "AMOUTRES";

        /// <summary>
        /// AMCO.
        /// </summary>
        public const string AMCO = "AMCO";
    }

    /// <inheritdoc />
    public override string TableName => "F01301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMACTIVID", "AMACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("AMINDID", "AMINDID", JdeDataType.String, 32),
        new JdeField("AMINDIDTY", "AMINDIDTY", JdeDataType.String, 100),
        new JdeField("AMCALTY", "AMCALTY", JdeDataType.String, 100),
        new JdeField("AMPACTVID", "AMPACTVID", JdeDataType.String, 74),
        new JdeField("AMACTVTYP", "AMACTVTYP", JdeDataType.String, 82),
        new JdeField("AMSUBJECT", "AMSUBJECT", JdeDataType.String, 102),
        new JdeField("AMACTVDESC", "AMACTVDESC", JdeDataType.String, 3998),
        new JdeField("AMLOCATION", "AMLOCATION", JdeDataType.String, 102),
        new JdeField("AMORIGNTOR", "AMORIGNTOR", JdeDataType.Numeric),
        new JdeField("AMTDSTR", "AMTDSTR", JdeDataType.Date),
        new JdeField("AMTDEND", "AMTDEND", JdeDataType.Date),
        new JdeField("AMALRM", "AMALRM", JdeDataType.String, 2),
        new JdeField("AMLEADTIME", "AMLEADTIME", JdeDataType.Numeric),
        new JdeField("AMLEADTMEU", "AMLEADTMEU", JdeDataType.String, 82),
        new JdeField("AMACTCAT", "AMACTCAT", JdeDataType.String, 102),
        new JdeField("AMACTVPSF", "AMACTVPSF", JdeDataType.String, 2),
        new JdeField("AMCOMITLVL", "AMCOMITLVL", JdeDataType.Numeric),
        new JdeField("AMADI", "AMADI", JdeDataType.String, 2),
        new JdeField("AMRECURID", "AMRECURID", JdeDataType.String, 72),
        new JdeField("AMRCCUR", "AMRCCUR", JdeDataType.String, 2),
        new JdeField("AMACTPRV", "AMACTPRV", JdeDataType.String, 2),
        new JdeField("AMACTCMPL", "AMACTCMPL", JdeDataType.String, 2),
        new JdeField("AMTDCMPL", "AMTDCMPL", JdeDataType.Date),
        new JdeField("AMTDLDS", "AMTDLDS", JdeDataType.Date),
        new JdeField("AMINTE", "AMINTE", JdeDataType.String, 2),
        new JdeField("AMSTPIM", "AMSTPIM", JdeDataType.String, 2),
        new JdeField("AMDOCAL", "AMDOCAL", JdeDataType.String, 2),
        new JdeField("AMACCNT", "AMACCNT", JdeDataType.Numeric),
        new JdeField("AMPARTN", "AMPARTN", JdeDataType.Numeric),
        new JdeField("AMACCNTC", "AMACCNTC", JdeDataType.Numeric),
        new JdeField("AMPARTNC", "AMPARTNC", JdeDataType.Numeric),
        new JdeField("AMPLNTY", "AMPLNTY", JdeDataType.String, 6),
        new JdeField("AMISTODO", "AMISTODO", JdeDataType.String, 2),
        new JdeField("AMATVCD1", "AMATVCD1", JdeDataType.String, 6),
        new JdeField("AMATVCD2", "AMATVCD2", JdeDataType.String, 6),
        new JdeField("AMATVCD3", "AMATVCD3", JdeDataType.String, 6),
        new JdeField("AMATVCD4", "AMATVCD4", JdeDataType.String, 6),
        new JdeField("AMATVCD5", "AMATVCD5", JdeDataType.String, 6),
        new JdeField("AMURCH", "AMURCH", JdeDataType.String, 100),
        new JdeField("AMURNUM", "AMURNUM", JdeDataType.Numeric),
        new JdeField("AMURTIME", "AMURTIME", JdeDataType.Date),
        new JdeField("AMIDAN8", "AMIDAN8", JdeDataType.Numeric),
        new JdeField("AMUDTTM", "AMUDTTM", JdeDataType.Date),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMEDATE", "AMEDATE", JdeDataType.Date),
        new JdeField("AMMKEY", "AMMKEY", JdeDataType.String, 30),
        new JdeField("AMENTDBY", "AMENTDBY", JdeDataType.Numeric),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMOWNERID", "AMOWNERID", JdeDataType.String, 32),
        new JdeField("AMOWNERIDT", "AMOWNERIDT", JdeDataType.String, 100),
        new JdeField("AMOWNCALT", "AMOWNCALT", JdeDataType.String, 100),
        new JdeField("AMANOMALY", "AMANOMALY", JdeDataType.String, 2),
        new JdeField("AMDOCO", "AMDOCO", JdeDataType.Numeric),
        new JdeField("AMLEADID", "AMLEADID", JdeDataType.Numeric),
        new JdeField("AMOPPID", "AMOPPID", JdeDataType.Numeric),
        new JdeField("AMACSTS", "AMACSTS", JdeDataType.String, 2),
        new JdeField("AMOUTRES", "AMOUTRES", JdeDataType.String, 20),
        new JdeField("AMCO", "AMCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01301_0", "Primary Key on AMACTIVID", new[] { "AMACTIVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01301_2", "Index on AMINDID, AMINDIDTY, AMCALTY", new[] { "AMINDID", "AMINDIDTY", "AMCALTY" }),
        new JdeIndex("F01301_3", "Index on AMPACTVID, AMANOMALY", new[] { "AMPACTVID", "AMANOMALY" })
    };
}
