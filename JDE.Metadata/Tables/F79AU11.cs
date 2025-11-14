using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79AU11 - .
/// </summary>
public class F79AU11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRCTID.
        /// </summary>
        public const string GRCTID = "GRCTID";

        /// <summary>
        /// GRJOBS.
        /// </summary>
        public const string GRJOBS = "GRJOBS";

        /// <summary>
        /// GRLNIX.
        /// </summary>
        public const string GRLNIX = "GRLNIX";

        /// <summary>
        /// GRUKID.
        /// </summary>
        public const string GRUKID = "GRUKID";

        /// <summary>
        /// GRKCO.
        /// </summary>
        public const string GRKCO = "GRKCO";

        /// <summary>
        /// GRDCT.
        /// </summary>
        public const string GRDCT = "GRDCT";

        /// <summary>
        /// GRDOC.
        /// </summary>
        public const string GRDOC = "GRDOC";

        /// <summary>
        /// GRSFX.
        /// </summary>
        public const string GRSFX = "GRSFX";

        /// <summary>
        /// GRSFXE.
        /// </summary>
        public const string GRSFXE = "GRSFXE";

        /// <summary>
        /// GRLNID.
        /// </summary>
        public const string GRLNID = "GRLNID";

        /// <summary>
        /// GRAN8.
        /// </summary>
        public const string GRAN8 = "GRAN8";

        /// <summary>
        /// GRMMCU.
        /// </summary>
        public const string GRMMCU = "GRMMCU";

        /// <summary>
        /// GRITM.
        /// </summary>
        public const string GRITM = "GRITM";

        /// <summary>
        /// GRLITM.
        /// </summary>
        public const string GRLITM = "GRLITM";

        /// <summary>
        /// GRAITM.
        /// </summary>
        public const string GRAITM = "GRAITM";

        /// <summary>
        /// GRTRQT.
        /// </summary>
        public const string GRTRQT = "GRTRQT";

        /// <summary>
        /// GRUOM1.
        /// </summary>
        public const string GRUOM1 = "GRUOM1";

        /// <summary>
        /// GRTREX.
        /// </summary>
        public const string GRTREX = "GRTREX";

        /// <summary>
        /// GRTRDJ.
        /// </summary>
        public const string GRTRDJ = "GRTRDJ";

        /// <summary>
        /// GR79ADGHG.
        /// </summary>
        public const string GR79ADGHG = "GR79ADGHG";

        /// <summary>
        /// GRCTRY.
        /// </summary>
        public const string GRCTRY = "GRCTRY";

        /// <summary>
        /// GRFY.
        /// </summary>
        public const string GRFY = "GRFY";

        /// <summary>
        /// GRPN.
        /// </summary>
        public const string GRPN = "GRPN";

        /// <summary>
        /// GR79AGESID.
        /// </summary>
        public const string GR79AGESID = "GR79AGESID";

        /// <summary>
        /// GR79ASRC.
        /// </summary>
        public const string GR79ASRC = "GR79ASRC";

        /// <summary>
        /// GR79AEMSC.
        /// </summary>
        public const string GR79AEMSC = "GR79AEMSC";

        /// <summary>
        /// GR79AGCUM.
        /// </summary>
        public const string GR79AGCUM = "GR79AGCUM";

        /// <summary>
        /// GR79AEUQTY.
        /// </summary>
        public const string GR79AEUQTY = "GR79AEUQTY";

        /// <summary>
        /// GR79AEGJ.
        /// </summary>
        public const string GR79AEGJ = "GR79AEGJ";

        /// <summary>
        /// GR79ACO2Q.
        /// </summary>
        public const string GR79ACO2Q = "GR79ACO2Q";

        /// <summary>
        /// GRRE.
        /// </summary>
        public const string GRRE = "GRRE";

        /// <summary>
        /// GR79AGRCD.
        /// </summary>
        public const string GR79AGRCD = "GR79AGRCD";

        /// <summary>
        /// GR79AGS01.
        /// </summary>
        public const string GR79AGS01 = "GR79AGS01";

        /// <summary>
        /// GR79AGS02.
        /// </summary>
        public const string GR79AGS02 = "GR79AGS02";

        /// <summary>
        /// GRCOUN.
        /// </summary>
        public const string GRCOUN = "GRCOUN";

        /// <summary>
        /// GRADDS.
        /// </summary>
        public const string GRADDS = "GRADDS";

        /// <summary>
        /// GRCTR.
        /// </summary>
        public const string GRCTR = "GRCTR";

        /// <summary>
        /// GRNUMB.
        /// </summary>
        public const string GRNUMB = "GRNUMB";

        /// <summary>
        /// GRASII.
        /// </summary>
        public const string GRASII = "GRASII";

        /// <summary>
        /// GR79AGELT.
        /// </summary>
        public const string GR79AGELT = "GR79AGELT";

        /// <summary>
        /// GR79AGST.
        /// </summary>
        public const string GR79AGST = "GR79AGST";

        /// <summary>
        /// GRURCD.
        /// </summary>
        public const string GRURCD = "GRURCD";

        /// <summary>
        /// GRURRF.
        /// </summary>
        public const string GRURRF = "GRURRF";

        /// <summary>
        /// GRURAB.
        /// </summary>
        public const string GRURAB = "GRURAB";

        /// <summary>
        /// GRURAT.
        /// </summary>
        public const string GRURAT = "GRURAT";

        /// <summary>
        /// GRURDT.
        /// </summary>
        public const string GRURDT = "GRURDT";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRTDAY.
        /// </summary>
        public const string GRTDAY = "GRTDAY";

        /// <summary>
        /// GR79AVN01.
        /// </summary>
        public const string GR79AVN01 = "GR79AVN01";

        /// <summary>
        /// GRCRCD.
        /// </summary>
        public const string GRCRCD = "GRCRCD";

        /// <summary>
        /// GRCRR.
        /// </summary>
        public const string GRCRR = "GRCRR";

        /// <summary>
        /// GRBCRC.
        /// </summary>
        public const string GRBCRC = "GRBCRC";

        /// <summary>
        /// GR79ABV01.
        /// </summary>
        public const string GR79ABV01 = "GR79ABV01";

        /// <summary>
        /// GR79AGCRIT.
        /// </summary>
        public const string GR79AGCRIT = "GR79AGCRIT";

        /// <summary>
        /// GRMCU.
        /// </summary>
        public const string GRMCU = "GRMCU";

        /// <summary>
        /// GR79AGBNO.
        /// </summary>
        public const string GR79AGBNO = "GR79AGBNO";

        /// <summary>
        /// GR79AGCM.
        /// </summary>
        public const string GR79AGCM = "GR79AGCM";
    }

    /// <inheritdoc />
    public override string TableName => "F79AU11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRCTID", "GRCTID", JdeDataType.String, 30, true, true),
        new JdeField("GRJOBS", "GRJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GRLNIX", "GRLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("GRUKID", "GRUKID", JdeDataType.Numeric),
        new JdeField("GRKCO", "GRKCO", JdeDataType.String, 10),
        new JdeField("GRDCT", "GRDCT", JdeDataType.String, 4),
        new JdeField("GRDOC", "GRDOC", JdeDataType.Numeric),
        new JdeField("GRSFX", "GRSFX", JdeDataType.String, 6),
        new JdeField("GRSFXE", "GRSFXE", JdeDataType.Numeric),
        new JdeField("GRLNID", "GRLNID", JdeDataType.Numeric),
        new JdeField("GRAN8", "GRAN8", JdeDataType.Numeric),
        new JdeField("GRMMCU", "GRMMCU", JdeDataType.String, 24),
        new JdeField("GRITM", "GRITM", JdeDataType.Numeric),
        new JdeField("GRLITM", "GRLITM", JdeDataType.String, 50),
        new JdeField("GRAITM", "GRAITM", JdeDataType.String, 50),
        new JdeField("GRTRQT", "GRTRQT", JdeDataType.Numeric),
        new JdeField("GRUOM1", "GRUOM1", JdeDataType.String, 4),
        new JdeField("GRTREX", "GRTREX", JdeDataType.String, 60),
        new JdeField("GRTRDJ", "GRTRDJ", JdeDataType.Numeric),
        new JdeField("GR79ADGHG", "GR79ADGHG", JdeDataType.Numeric),
        new JdeField("GRCTRY", "GRCTRY", JdeDataType.Numeric),
        new JdeField("GRFY", "GRFY", JdeDataType.Numeric),
        new JdeField("GRPN", "GRPN", JdeDataType.Numeric),
        new JdeField("GR79AGESID", "GR79AGESID", JdeDataType.Numeric),
        new JdeField("GR79ASRC", "GR79ASRC", JdeDataType.String, 50),
        new JdeField("GR79AEMSC", "GR79AEMSC", JdeDataType.String, 20),
        new JdeField("GR79AGCUM", "GR79AGCUM", JdeDataType.String, 4),
        new JdeField("GR79AEUQTY", "GR79AEUQTY", JdeDataType.Numeric),
        new JdeField("GR79AEGJ", "GR79AEGJ", JdeDataType.Numeric),
        new JdeField("GR79ACO2Q", "GR79ACO2Q", JdeDataType.Numeric),
        new JdeField("GRRE", "GRRE", JdeDataType.String, 2),
        new JdeField("GR79AGRCD", "GR79AGRCD", JdeDataType.String, 6),
        new JdeField("GR79AGS01", "GR79AGS01", JdeDataType.String, 4),
        new JdeField("GR79AGS02", "GR79AGS02", JdeDataType.String, 4),
        new JdeField("GRCOUN", "GRCOUN", JdeDataType.String, 50),
        new JdeField("GRADDS", "GRADDS", JdeDataType.String, 6),
        new JdeField("GRCTR", "GRCTR", JdeDataType.String, 6),
        new JdeField("GRNUMB", "GRNUMB", JdeDataType.Numeric),
        new JdeField("GRASII", "GRASII", JdeDataType.String, 52),
        new JdeField("GR79AGELT", "GR79AGELT", JdeDataType.String, 4),
        new JdeField("GR79AGST", "GR79AGST", JdeDataType.String, 4),
        new JdeField("GRURCD", "GRURCD", JdeDataType.String, 4),
        new JdeField("GRURRF", "GRURRF", JdeDataType.String, 30),
        new JdeField("GRURAB", "GRURAB", JdeDataType.Numeric),
        new JdeField("GRURAT", "GRURAT", JdeDataType.Numeric),
        new JdeField("GRURDT", "GRURDT", JdeDataType.Numeric),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRTDAY", "GRTDAY", JdeDataType.Numeric),
        new JdeField("GR79AVN01", "GR79AVN01", JdeDataType.Numeric),
        new JdeField("GRCRCD", "GRCRCD", JdeDataType.String, 6),
        new JdeField("GRCRR", "GRCRR", JdeDataType.Numeric),
        new JdeField("GRBCRC", "GRBCRC", JdeDataType.String, 6),
        new JdeField("GR79ABV01", "GR79ABV01", JdeDataType.Numeric),
        new JdeField("GR79AGCRIT", "GR79AGCRIT", JdeDataType.String, 20),
        new JdeField("GRMCU", "GRMCU", JdeDataType.String, 24),
        new JdeField("GR79AGBNO", "GR79AGBNO", JdeDataType.Numeric),
        new JdeField("GR79AGCM", "GR79AGCM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79AU11_0", "Primary Key on GRCTID, GRJOBS, GRLNIX", new[] { "GRCTID", "GRJOBS", "GRLNIX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79AU11_2", "Index on GRCTID, GRJOBS, GRKCO, GRDCT, GRDOC, GRSFX, GRSFXE, GRLNID, GR79ADGHG", new[] { "GRCTID", "GRJOBS", "GRKCO", "GRDCT", "GRDOC", "GRSFX", "GRSFXE", "GRLNID", "GR79ADGHG" }),
        new JdeIndex("F79AU11_3", "Index on GRUPMJ", new[] { "GRUPMJ" }),
        new JdeIndex("F79AU11_4", "Index on GR79AGST, GRUPMJ", new[] { "GR79AGST", "GRUPMJ" }),
        new JdeIndex("F79AU11_5", "Index on GRUKID", new[] { "GRUKID" }),
        new JdeIndex("F79AU11_6", "Index on GRJOBS, GRKCO, GRDCT, GRDOC, GRSFX, GRSFXE, GRLNID", new[] { "GRJOBS", "GRKCO", "GRDCT", "GRDOC", "GRSFX", "GRSFXE", "GRLNID" })
    };
}
