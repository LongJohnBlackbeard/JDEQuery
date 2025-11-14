using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01301W - .
/// </summary>
public class F01301W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AWACTIVID.
        /// </summary>
        public const string AWACTIVID = "AWACTIVID";

        /// <summary>
        /// AWSNKY.
        /// </summary>
        public const string AWSNKY = "AWSNKY";

        /// <summary>
        /// AWINDID.
        /// </summary>
        public const string AWINDID = "AWINDID";

        /// <summary>
        /// AWINDIDTY.
        /// </summary>
        public const string AWINDIDTY = "AWINDIDTY";

        /// <summary>
        /// AWCALTY.
        /// </summary>
        public const string AWCALTY = "AWCALTY";

        /// <summary>
        /// AWPACTVID.
        /// </summary>
        public const string AWPACTVID = "AWPACTVID";

        /// <summary>
        /// AWACTVPSF.
        /// </summary>
        public const string AWACTVPSF = "AWACTVPSF";

        /// <summary>
        /// AWACTVTYP.
        /// </summary>
        public const string AWACTVTYP = "AWACTVTYP";

        /// <summary>
        /// AWSUBJECT.
        /// </summary>
        public const string AWSUBJECT = "AWSUBJECT";

        /// <summary>
        /// AWACTVDESC.
        /// </summary>
        public const string AWACTVDESC = "AWACTVDESC";

        /// <summary>
        /// AWLOCATION.
        /// </summary>
        public const string AWLOCATION = "AWLOCATION";

        /// <summary>
        /// AWORIGNTOR.
        /// </summary>
        public const string AWORIGNTOR = "AWORIGNTOR";

        /// <summary>
        /// AWTDSTR.
        /// </summary>
        public const string AWTDSTR = "AWTDSTR";

        /// <summary>
        /// AWTDEND.
        /// </summary>
        public const string AWTDEND = "AWTDEND";

        /// <summary>
        /// AWALRM.
        /// </summary>
        public const string AWALRM = "AWALRM";

        /// <summary>
        /// AWLEADTIME.
        /// </summary>
        public const string AWLEADTIME = "AWLEADTIME";

        /// <summary>
        /// AWLEADTMEU.
        /// </summary>
        public const string AWLEADTMEU = "AWLEADTMEU";

        /// <summary>
        /// AWACTCAT.
        /// </summary>
        public const string AWACTCAT = "AWACTCAT";

        /// <summary>
        /// AWCOMITLVL.
        /// </summary>
        public const string AWCOMITLVL = "AWCOMITLVL";

        /// <summary>
        /// AWADI.
        /// </summary>
        public const string AWADI = "AWADI";

        /// <summary>
        /// AWRECURID.
        /// </summary>
        public const string AWRECURID = "AWRECURID";

        /// <summary>
        /// AWRCCUR.
        /// </summary>
        public const string AWRCCUR = "AWRCCUR";

        /// <summary>
        /// AWACTPRV.
        /// </summary>
        public const string AWACTPRV = "AWACTPRV";

        /// <summary>
        /// AWACTCMPL.
        /// </summary>
        public const string AWACTCMPL = "AWACTCMPL";

        /// <summary>
        /// AWTDCMPL.
        /// </summary>
        public const string AWTDCMPL = "AWTDCMPL";

        /// <summary>
        /// AWTDLDS.
        /// </summary>
        public const string AWTDLDS = "AWTDLDS";

        /// <summary>
        /// AWINTE.
        /// </summary>
        public const string AWINTE = "AWINTE";

        /// <summary>
        /// AWSTPIM.
        /// </summary>
        public const string AWSTPIM = "AWSTPIM";

        /// <summary>
        /// AWDOCAL.
        /// </summary>
        public const string AWDOCAL = "AWDOCAL";

        /// <summary>
        /// AWACCNT.
        /// </summary>
        public const string AWACCNT = "AWACCNT";

        /// <summary>
        /// AWPARTN.
        /// </summary>
        public const string AWPARTN = "AWPARTN";

        /// <summary>
        /// AWACCNTC.
        /// </summary>
        public const string AWACCNTC = "AWACCNTC";

        /// <summary>
        /// AWPARTNC.
        /// </summary>
        public const string AWPARTNC = "AWPARTNC";

        /// <summary>
        /// AWPLNTY.
        /// </summary>
        public const string AWPLNTY = "AWPLNTY";

        /// <summary>
        /// AWISTODO.
        /// </summary>
        public const string AWISTODO = "AWISTODO";

        /// <summary>
        /// AWATVCD1.
        /// </summary>
        public const string AWATVCD1 = "AWATVCD1";

        /// <summary>
        /// AWATVCD2.
        /// </summary>
        public const string AWATVCD2 = "AWATVCD2";

        /// <summary>
        /// AWATVCD3.
        /// </summary>
        public const string AWATVCD3 = "AWATVCD3";

        /// <summary>
        /// AWATVCD4.
        /// </summary>
        public const string AWATVCD4 = "AWATVCD4";

        /// <summary>
        /// AWATVCD5.
        /// </summary>
        public const string AWATVCD5 = "AWATVCD5";

        /// <summary>
        /// AWURCH.
        /// </summary>
        public const string AWURCH = "AWURCH";

        /// <summary>
        /// AWURNUM.
        /// </summary>
        public const string AWURNUM = "AWURNUM";

        /// <summary>
        /// AWURTIME.
        /// </summary>
        public const string AWURTIME = "AWURTIME";

        /// <summary>
        /// AWACTGHST.
        /// </summary>
        public const string AWACTGHST = "AWACTGHST";

        /// <summary>
        /// AWUDTTM.
        /// </summary>
        public const string AWUDTTM = "AWUDTTM";

        /// <summary>
        /// AWUSER.
        /// </summary>
        public const string AWUSER = "AWUSER";

        /// <summary>
        /// AWEDATE.
        /// </summary>
        public const string AWEDATE = "AWEDATE";

        /// <summary>
        /// AWMKEY.
        /// </summary>
        public const string AWMKEY = "AWMKEY";

        /// <summary>
        /// AWENTDBY.
        /// </summary>
        public const string AWENTDBY = "AWENTDBY";

        /// <summary>
        /// AWPID.
        /// </summary>
        public const string AWPID = "AWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F01301W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AWACTIVID", "AWACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("AWSNKY", "AWSNKY", JdeDataType.String, 64, true, true),
        new JdeField("AWINDID", "AWINDID", JdeDataType.String, 32),
        new JdeField("AWINDIDTY", "AWINDIDTY", JdeDataType.String, 100),
        new JdeField("AWCALTY", "AWCALTY", JdeDataType.String, 100),
        new JdeField("AWPACTVID", "AWPACTVID", JdeDataType.String, 74),
        new JdeField("AWACTVPSF", "AWACTVPSF", JdeDataType.String, 2),
        new JdeField("AWACTVTYP", "AWACTVTYP", JdeDataType.String, 82),
        new JdeField("AWSUBJECT", "AWSUBJECT", JdeDataType.String, 102),
        new JdeField("AWACTVDESC", "AWACTVDESC", JdeDataType.String, 3998),
        new JdeField("AWLOCATION", "AWLOCATION", JdeDataType.String, 102),
        new JdeField("AWORIGNTOR", "AWORIGNTOR", JdeDataType.Numeric),
        new JdeField("AWTDSTR", "AWTDSTR", JdeDataType.Date),
        new JdeField("AWTDEND", "AWTDEND", JdeDataType.Date),
        new JdeField("AWALRM", "AWALRM", JdeDataType.String, 2),
        new JdeField("AWLEADTIME", "AWLEADTIME", JdeDataType.Numeric),
        new JdeField("AWLEADTMEU", "AWLEADTMEU", JdeDataType.String, 82),
        new JdeField("AWACTCAT", "AWACTCAT", JdeDataType.String, 102),
        new JdeField("AWCOMITLVL", "AWCOMITLVL", JdeDataType.Numeric),
        new JdeField("AWADI", "AWADI", JdeDataType.String, 2),
        new JdeField("AWRECURID", "AWRECURID", JdeDataType.String, 72),
        new JdeField("AWRCCUR", "AWRCCUR", JdeDataType.String, 2),
        new JdeField("AWACTPRV", "AWACTPRV", JdeDataType.String, 2),
        new JdeField("AWACTCMPL", "AWACTCMPL", JdeDataType.String, 2),
        new JdeField("AWTDCMPL", "AWTDCMPL", JdeDataType.Date),
        new JdeField("AWTDLDS", "AWTDLDS", JdeDataType.Date),
        new JdeField("AWINTE", "AWINTE", JdeDataType.String, 2),
        new JdeField("AWSTPIM", "AWSTPIM", JdeDataType.String, 2),
        new JdeField("AWDOCAL", "AWDOCAL", JdeDataType.String, 2),
        new JdeField("AWACCNT", "AWACCNT", JdeDataType.Numeric),
        new JdeField("AWPARTN", "AWPARTN", JdeDataType.Numeric),
        new JdeField("AWACCNTC", "AWACCNTC", JdeDataType.Numeric),
        new JdeField("AWPARTNC", "AWPARTNC", JdeDataType.Numeric),
        new JdeField("AWPLNTY", "AWPLNTY", JdeDataType.String, 6),
        new JdeField("AWISTODO", "AWISTODO", JdeDataType.String, 2),
        new JdeField("AWATVCD1", "AWATVCD1", JdeDataType.String, 6),
        new JdeField("AWATVCD2", "AWATVCD2", JdeDataType.String, 6),
        new JdeField("AWATVCD3", "AWATVCD3", JdeDataType.String, 6),
        new JdeField("AWATVCD4", "AWATVCD4", JdeDataType.String, 6),
        new JdeField("AWATVCD5", "AWATVCD5", JdeDataType.String, 6),
        new JdeField("AWURCH", "AWURCH", JdeDataType.String, 100),
        new JdeField("AWURNUM", "AWURNUM", JdeDataType.Numeric),
        new JdeField("AWURTIME", "AWURTIME", JdeDataType.Date),
        new JdeField("AWACTGHST", "AWACTGHST", JdeDataType.String, 2),
        new JdeField("AWUDTTM", "AWUDTTM", JdeDataType.Date),
        new JdeField("AWUSER", "AWUSER", JdeDataType.String, 20),
        new JdeField("AWEDATE", "AWEDATE", JdeDataType.Date),
        new JdeField("AWMKEY", "AWMKEY", JdeDataType.String, 30),
        new JdeField("AWENTDBY", "AWENTDBY", JdeDataType.Numeric),
        new JdeField("AWPID", "AWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01301W_0", "Primary Key on AWSNKY, AWACTIVID", new[] { "AWSNKY", "AWACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
