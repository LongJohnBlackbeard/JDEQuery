using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4941 - .
/// </summary>
public class F4941 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSSHPN.
        /// </summary>
        public const string RSSHPN = "RSSHPN";

        /// <summary>
        /// RSRSSN.
        /// </summary>
        public const string RSRSSN = "RSRSSN";

        /// <summary>
        /// RSMOT.
        /// </summary>
        public const string RSMOT = "RSMOT";

        /// <summary>
        /// RSOVRM.
        /// </summary>
        public const string RSOVRM = "RSOVRM";

        /// <summary>
        /// RSCARS.
        /// </summary>
        public const string RSCARS = "RSCARS";

        /// <summary>
        /// RSOVRC.
        /// </summary>
        public const string RSOVRC = "RSOVRC";

        /// <summary>
        /// RSROUT.
        /// </summary>
        public const string RSROUT = "RSROUT";

        /// <summary>
        /// RSRTN.
        /// </summary>
        public const string RSRTN = "RSRTN";

        /// <summary>
        /// RSDLNO.
        /// </summary>
        public const string RSDLNO = "RSDLNO";

        /// <summary>
        /// RSFRSC.
        /// </summary>
        public const string RSFRSC = "RSFRSC";

        /// <summary>
        /// RSCZON.
        /// </summary>
        public const string RSCZON = "RSCZON";

        /// <summary>
        /// RSVMCU.
        /// </summary>
        public const string RSVMCU = "RSVMCU";

        /// <summary>
        /// RSLDNM.
        /// </summary>
        public const string RSLDNM = "RSLDNM";

        /// <summary>
        /// RSTRPL.
        /// </summary>
        public const string RSTRPL = "RSTRPL";

        /// <summary>
        /// RSSTSQ.
        /// </summary>
        public const string RSSTSQ = "RSSTSQ";

        /// <summary>
        /// RSANID.
        /// </summary>
        public const string RSANID = "RSANID";

        /// <summary>
        /// RSORGN.
        /// </summary>
        public const string RSORGN = "RSORGN";

        /// <summary>
        /// RSANCC.
        /// </summary>
        public const string RSANCC = "RSANCC";

        /// <summary>
        /// RSWGTS.
        /// </summary>
        public const string RSWGTS = "RSWGTS";

        /// <summary>
        /// RSWTUM.
        /// </summary>
        public const string RSWTUM = "RSWTUM";

        /// <summary>
        /// RSSCVL.
        /// </summary>
        public const string RSSCVL = "RSSCVL";

        /// <summary>
        /// RSVLUM.
        /// </summary>
        public const string RSVLUM = "RSVLUM";

        /// <summary>
        /// RSLGTS.
        /// </summary>
        public const string RSLGTS = "RSLGTS";

        /// <summary>
        /// RSWTHS.
        /// </summary>
        public const string RSWTHS = "RSWTHS";

        /// <summary>
        /// RSHGTS.
        /// </summary>
        public const string RSHGTS = "RSHGTS";

        /// <summary>
        /// RSGTHS.
        /// </summary>
        public const string RSGTHS = "RSGTHS";

        /// <summary>
        /// RSLUOM.
        /// </summary>
        public const string RSLUOM = "RSLUOM";

        /// <summary>
        /// RSNPCS.
        /// </summary>
        public const string RSNPCS = "RSNPCS";

        /// <summary>
        /// RSNCTR.
        /// </summary>
        public const string RSNCTR = "RSNCTR";

        /// <summary>
        /// RSCCUB.
        /// </summary>
        public const string RSCCUB = "RSCCUB";

        /// <summary>
        /// RSDSTN.
        /// </summary>
        public const string RSDSTN = "RSDSTN";

        /// <summary>
        /// RSUMD1.
        /// </summary>
        public const string RSUMD1 = "RSUMD1";

        /// <summary>
        /// RSDSRC.
        /// </summary>
        public const string RSDSRC = "RSDSRC";

        /// <summary>
        /// RSELTM.
        /// </summary>
        public const string RSELTM = "RSELTM";

        /// <summary>
        /// RSUM.
        /// </summary>
        public const string RSUM = "RSUM";

        /// <summary>
        /// RSAEXP.
        /// </summary>
        public const string RSAEXP = "RSAEXP";

        /// <summary>
        /// RSFEA.
        /// </summary>
        public const string RSFEA = "RSFEA";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSECST.
        /// </summary>
        public const string RSECST = "RSECST";

        /// <summary>
        /// RSPPDJ.
        /// </summary>
        public const string RSPPDJ = "RSPPDJ";

        /// <summary>
        /// RSPMDT.
        /// </summary>
        public const string RSPMDT = "RSPMDT";

        /// <summary>
        /// RSRSDJ.
        /// </summary>
        public const string RSRSDJ = "RSRSDJ";

        /// <summary>
        /// RSRSDT.
        /// </summary>
        public const string RSRSDT = "RSRSDT";

        /// <summary>
        /// RSLDDT.
        /// </summary>
        public const string RSLDDT = "RSLDDT";

        /// <summary>
        /// RSLDTM.
        /// </summary>
        public const string RSLDTM = "RSLDTM";

        /// <summary>
        /// RSADDJ.
        /// </summary>
        public const string RSADDJ = "RSADDJ";

        /// <summary>
        /// RSADTM.
        /// </summary>
        public const string RSADTM = "RSADTM";

        /// <summary>
        /// RSDLDT.
        /// </summary>
        public const string RSDLDT = "RSDLDT";

        /// <summary>
        /// RSDLTM.
        /// </summary>
        public const string RSDLTM = "RSDLTM";

        /// <summary>
        /// RSRRTR.
        /// </summary>
        public const string RSRRTR = "RSRRTR";

        /// <summary>
        /// RSRATR.
        /// </summary>
        public const string RSRATR = "RSRATR";

        /// <summary>
        /// RSDPCR.
        /// </summary>
        public const string RSDPCR = "RSDPCR";

        /// <summary>
        /// RSREFQ.
        /// </summary>
        public const string RSREFQ = "RSREFQ";

        /// <summary>
        /// RSREFN.
        /// </summary>
        public const string RSREFN = "RSREFN";

        /// <summary>
        /// RSFRTD.
        /// </summary>
        public const string RSFRTD = "RSFRTD";

        /// <summary>
        /// RSFRTV.
        /// </summary>
        public const string RSFRTV = "RSFRTV";

        /// <summary>
        /// RSFRVC.
        /// </summary>
        public const string RSFRVC = "RSFRVC";

        /// <summary>
        /// RSFRVF.
        /// </summary>
        public const string RSFRVF = "RSFRVF";

        /// <summary>
        /// RSCRCP.
        /// </summary>
        public const string RSCRCP = "RSCRCP";

        /// <summary>
        /// RSFRCC.
        /// </summary>
        public const string RSFRCC = "RSFRCC";

        /// <summary>
        /// RSFRCF.
        /// </summary>
        public const string RSFRCF = "RSFRCF";

        /// <summary>
        /// RSCRDC.
        /// </summary>
        public const string RSCRDC = "RSCRDC";

        /// <summary>
        /// RSINTF.
        /// </summary>
        public const string RSINTF = "RSINTF";

        /// <summary>
        /// RSIBRS.
        /// </summary>
        public const string RSIBRS = "RSIBRS";

        /// <summary>
        /// RSLSLT.
        /// </summary>
        public const string RSLSLT = "RSLSLT";

        /// <summary>
        /// RSLSUT.
        /// </summary>
        public const string RSLSUT = "RSLSUT";

        /// <summary>
        /// RSLALT.
        /// </summary>
        public const string RSLALT = "RSLALT";

        /// <summary>
        /// RSLAUT.
        /// </summary>
        public const string RSLAUT = "RSLAUT";

        /// <summary>
        /// RSTPUF.
        /// </summary>
        public const string RSTPUF = "RSTPUF";

        /// <summary>
        /// RSTPUT.
        /// </summary>
        public const string RSTPUT = "RSTPUT";

        /// <summary>
        /// RSTDLF.
        /// </summary>
        public const string RSTDLF = "RSTDLF";

        /// <summary>
        /// RSTDLT.
        /// </summary>
        public const string RSTDLT = "RSTDLT";

        /// <summary>
        /// RSDEPU.
        /// </summary>
        public const string RSDEPU = "RSDEPU";

        /// <summary>
        /// RSDLPU.
        /// </summary>
        public const string RSDLPU = "RSDLPU";

        /// <summary>
        /// RSDEDL.
        /// </summary>
        public const string RSDEDL = "RSDEDL";

        /// <summary>
        /// RSDLDL.
        /// </summary>
        public const string RSDLDL = "RSDLDL";

        /// <summary>
        /// RSDKID.
        /// </summary>
        public const string RSDKID = "RSDKID";

        /// <summary>
        /// RSPRNB.
        /// </summary>
        public const string RSPRNB = "RSPRNB";

        /// <summary>
        /// RSPRTE.
        /// </summary>
        public const string RSPRTE = "RSPRTE";

        /// <summary>
        /// RSLNMB.
        /// </summary>
        public const string RSLNMB = "RSLNMB";

        /// <summary>
        /// RSCNMR.
        /// </summary>
        public const string RSCNMR = "RSCNMR";

        /// <summary>
        /// RSURCD.
        /// </summary>
        public const string RSURCD = "RSURCD";

        /// <summary>
        /// RSURDT.
        /// </summary>
        public const string RSURDT = "RSURDT";

        /// <summary>
        /// RSURAT.
        /// </summary>
        public const string RSURAT = "RSURAT";

        /// <summary>
        /// RSURAB.
        /// </summary>
        public const string RSURAB = "RSURAB";

        /// <summary>
        /// RSURRF.
        /// </summary>
        public const string RSURRF = "RSURRF";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSTDAY.
        /// </summary>
        public const string RSTDAY = "RSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4941";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSSHPN", "RSSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("RSRSSN", "RSRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("RSMOT", "RSMOT", JdeDataType.String, 6),
        new JdeField("RSOVRM", "RSOVRM", JdeDataType.String, 2),
        new JdeField("RSCARS", "RSCARS", JdeDataType.Numeric),
        new JdeField("RSOVRC", "RSOVRC", JdeDataType.String, 2),
        new JdeField("RSROUT", "RSROUT", JdeDataType.String, 6),
        new JdeField("RSRTN", "RSRTN", JdeDataType.Numeric),
        new JdeField("RSDLNO", "RSDLNO", JdeDataType.Numeric),
        new JdeField("RSFRSC", "RSFRSC", JdeDataType.String, 16),
        new JdeField("RSCZON", "RSCZON", JdeDataType.String, 20),
        new JdeField("RSVMCU", "RSVMCU", JdeDataType.String, 24),
        new JdeField("RSLDNM", "RSLDNM", JdeDataType.Numeric),
        new JdeField("RSTRPL", "RSTRPL", JdeDataType.Numeric),
        new JdeField("RSSTSQ", "RSSTSQ", JdeDataType.Numeric),
        new JdeField("RSANID", "RSANID", JdeDataType.Numeric),
        new JdeField("RSORGN", "RSORGN", JdeDataType.Numeric),
        new JdeField("RSANCC", "RSANCC", JdeDataType.Numeric),
        new JdeField("RSWGTS", "RSWGTS", JdeDataType.Numeric),
        new JdeField("RSWTUM", "RSWTUM", JdeDataType.String, 4),
        new JdeField("RSSCVL", "RSSCVL", JdeDataType.Numeric),
        new JdeField("RSVLUM", "RSVLUM", JdeDataType.String, 4),
        new JdeField("RSLGTS", "RSLGTS", JdeDataType.Numeric),
        new JdeField("RSWTHS", "RSWTHS", JdeDataType.Numeric),
        new JdeField("RSHGTS", "RSHGTS", JdeDataType.Numeric),
        new JdeField("RSGTHS", "RSGTHS", JdeDataType.Numeric),
        new JdeField("RSLUOM", "RSLUOM", JdeDataType.String, 4),
        new JdeField("RSNPCS", "RSNPCS", JdeDataType.Numeric),
        new JdeField("RSNCTR", "RSNCTR", JdeDataType.Numeric),
        new JdeField("RSCCUB", "RSCCUB", JdeDataType.Numeric),
        new JdeField("RSDSTN", "RSDSTN", JdeDataType.Numeric),
        new JdeField("RSUMD1", "RSUMD1", JdeDataType.String, 4),
        new JdeField("RSDSRC", "RSDSRC", JdeDataType.String, 2),
        new JdeField("RSELTM", "RSELTM", JdeDataType.Numeric),
        new JdeField("RSUM", "RSUM", JdeDataType.String, 4),
        new JdeField("RSAEXP", "RSAEXP", JdeDataType.Numeric),
        new JdeField("RSFEA", "RSFEA", JdeDataType.Numeric),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSECST", "RSECST", JdeDataType.Numeric),
        new JdeField("RSPPDJ", "RSPPDJ", JdeDataType.Numeric),
        new JdeField("RSPMDT", "RSPMDT", JdeDataType.Numeric),
        new JdeField("RSRSDJ", "RSRSDJ", JdeDataType.Numeric),
        new JdeField("RSRSDT", "RSRSDT", JdeDataType.Numeric),
        new JdeField("RSLDDT", "RSLDDT", JdeDataType.Numeric),
        new JdeField("RSLDTM", "RSLDTM", JdeDataType.Numeric),
        new JdeField("RSADDJ", "RSADDJ", JdeDataType.Numeric),
        new JdeField("RSADTM", "RSADTM", JdeDataType.Numeric),
        new JdeField("RSDLDT", "RSDLDT", JdeDataType.Numeric),
        new JdeField("RSDLTM", "RSDLTM", JdeDataType.Numeric),
        new JdeField("RSRRTR", "RSRRTR", JdeDataType.String, 2),
        new JdeField("RSRATR", "RSRATR", JdeDataType.String, 2),
        new JdeField("RSDPCR", "RSDPCR", JdeDataType.String, 2),
        new JdeField("RSREFQ", "RSREFQ", JdeDataType.String, 4),
        new JdeField("RSREFN", "RSREFN", JdeDataType.String, 60),
        new JdeField("RSFRTD", "RSFRTD", JdeDataType.String, 2),
        new JdeField("RSFRTV", "RSFRTV", JdeDataType.String, 2),
        new JdeField("RSFRVC", "RSFRVC", JdeDataType.Numeric),
        new JdeField("RSFRVF", "RSFRVF", JdeDataType.Numeric),
        new JdeField("RSCRCP", "RSCRCP", JdeDataType.String, 6),
        new JdeField("RSFRCC", "RSFRCC", JdeDataType.Numeric),
        new JdeField("RSFRCF", "RSFRCF", JdeDataType.Numeric),
        new JdeField("RSCRDC", "RSCRDC", JdeDataType.String, 6),
        new JdeField("RSINTF", "RSINTF", JdeDataType.String, 2),
        new JdeField("RSIBRS", "RSIBRS", JdeDataType.String, 2),
        new JdeField("RSLSLT", "RSLSLT", JdeDataType.Numeric),
        new JdeField("RSLSUT", "RSLSUT", JdeDataType.Numeric),
        new JdeField("RSLALT", "RSLALT", JdeDataType.Numeric),
        new JdeField("RSLAUT", "RSLAUT", JdeDataType.Numeric),
        new JdeField("RSTPUF", "RSTPUF", JdeDataType.Numeric),
        new JdeField("RSTPUT", "RSTPUT", JdeDataType.Numeric),
        new JdeField("RSTDLF", "RSTDLF", JdeDataType.Numeric),
        new JdeField("RSTDLT", "RSTDLT", JdeDataType.Numeric),
        new JdeField("RSDEPU", "RSDEPU", JdeDataType.Numeric),
        new JdeField("RSDLPU", "RSDLPU", JdeDataType.Numeric),
        new JdeField("RSDEDL", "RSDEDL", JdeDataType.Numeric),
        new JdeField("RSDLDL", "RSDLDL", JdeDataType.Numeric),
        new JdeField("RSDKID", "RSDKID", JdeDataType.String, 40),
        new JdeField("RSPRNB", "RSPRNB", JdeDataType.Numeric),
        new JdeField("RSPRTE", "RSPRTE", JdeDataType.String, 2),
        new JdeField("RSLNMB", "RSLNMB", JdeDataType.Numeric),
        new JdeField("RSCNMR", "RSCNMR", JdeDataType.String, 48),
        new JdeField("RSURCD", "RSURCD", JdeDataType.String, 4),
        new JdeField("RSURDT", "RSURDT", JdeDataType.Numeric),
        new JdeField("RSURAT", "RSURAT", JdeDataType.Numeric),
        new JdeField("RSURAB", "RSURAB", JdeDataType.Numeric),
        new JdeField("RSURRF", "RSURRF", JdeDataType.String, 30),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSTDAY", "RSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4941_0", "Primary Key on RSSHPN, RSRSSN", new[] { "RSSHPN", "RSRSSN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4941_2", "Index on RSVMCU, RSLDNM, RSSTSQ", new[] { "RSVMCU", "RSLDNM", "RSSTSQ" }),
        new JdeIndex("F4941_3", "Index on RSDLNO, RSSHPN, RSRSSN", new[] { "RSDLNO", "RSSHPN", "RSRSSN" }),
        new JdeIndex("F4941_4", "Index on RSPPDJ", new[] { "RSPPDJ" }),
        new JdeIndex("F4941_5", "Index on RSSHPN, SYS_NC00092$", new[] { "RSSHPN", "SYS_NC00092$" }),
        new JdeIndex("F4941_6", "Index on RSCARS, RSORGN", new[] { "RSCARS", "RSORGN" })
    };
}
