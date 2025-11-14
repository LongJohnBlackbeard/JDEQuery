using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1720 - .
/// </summary>
public class F1720 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHDOCO.
        /// </summary>
        public const string CHDOCO = "CHDOCO";

        /// <summary>
        /// CHDCTO.
        /// </summary>
        public const string CHDCTO = "CHDCTO";

        /// <summary>
        /// CHKCOO.
        /// </summary>
        public const string CHKCOO = "CHKCOO";

        /// <summary>
        /// CHCOCH.
        /// </summary>
        public const string CHCOCH = "CHCOCH";

        /// <summary>
        /// CHDOC1.
        /// </summary>
        public const string CHDOC1 = "CHDOC1";

        /// <summary>
        /// CHDCT1.
        /// </summary>
        public const string CHDCT1 = "CHDCT1";

        /// <summary>
        /// CHSKCO.
        /// </summary>
        public const string CHSKCO = "CHSKCO";

        /// <summary>
        /// CHOSFX.
        /// </summary>
        public const string CHOSFX = "CHOSFX";

        /// <summary>
        /// CHPCTN.
        /// </summary>
        public const string CHPCTN = "CHPCTN";

        /// <summary>
        /// CHPCTT.
        /// </summary>
        public const string CHPCTT = "CHPCTT";

        /// <summary>
        /// CHPCKO.
        /// </summary>
        public const string CHPCKO = "CHPCKO";

        /// <summary>
        /// CHDL01.
        /// </summary>
        public const string CHDL01 = "CHDL01";

        /// <summary>
        /// CHDC.
        /// </summary>
        public const string CHDC = "CHDC";

        /// <summary>
        /// CHDL02.
        /// </summary>
        public const string CHDL02 = "CHDL02";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHANOB.
        /// </summary>
        public const string CHANOB = "CHANOB";

        /// <summary>
        /// CHUSA5.
        /// </summary>
        public const string CHUSA5 = "CHUSA5";

        /// <summary>
        /// CHLANO.
        /// </summary>
        public const string CHLANO = "CHLANO";

        /// <summary>
        /// CHCNSTS.
        /// </summary>
        public const string CHCNSTS = "CHCNSTS";

        /// <summary>
        /// CHCNTYP.
        /// </summary>
        public const string CHCNTYP = "CHCNTYP";

        /// <summary>
        /// CHCONTS.
        /// </summary>
        public const string CHCONTS = "CHCONTS";

        /// <summary>
        /// CHMCUS.
        /// </summary>
        public const string CHMCUS = "CHMCUS";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHCO.
        /// </summary>
        public const string CHCO = "CHCO";

        /// <summary>
        /// CHCSDT.
        /// </summary>
        public const string CHCSDT = "CHCSDT";

        /// <summary>
        /// CHCDTE.
        /// </summary>
        public const string CHCDTE = "CHCDTE";

        /// <summary>
        /// CHCNDJ.
        /// </summary>
        public const string CHCNDJ = "CHCNDJ";

        /// <summary>
        /// CHEXR1.
        /// </summary>
        public const string CHEXR1 = "CHEXR1";

        /// <summary>
        /// CHTXA1.
        /// </summary>
        public const string CHTXA1 = "CHTXA1";

        /// <summary>
        /// CHINVF.
        /// </summary>
        public const string CHINVF = "CHINVF";

        /// <summary>
        /// CHPTC.
        /// </summary>
        public const string CHPTC = "CHPTC";

        /// <summary>
        /// CHRYIN.
        /// </summary>
        public const string CHRYIN = "CHRYIN";

        /// <summary>
        /// CHCRCD.
        /// </summary>
        public const string CHCRCD = "CHCRCD";

        /// <summary>
        /// CHCRCF.
        /// </summary>
        public const string CHCRCF = "CHCRCF";

        /// <summary>
        /// CHCRRM.
        /// </summary>
        public const string CHCRRM = "CHCRRM";

        /// <summary>
        /// CHERDB.
        /// </summary>
        public const string CHERDB = "CHERDB";

        /// <summary>
        /// CHKH01.
        /// </summary>
        public const string CHKH01 = "CHKH01";

        /// <summary>
        /// CHKH02.
        /// </summary>
        public const string CHKH02 = "CHKH02";

        /// <summary>
        /// CHKH03.
        /// </summary>
        public const string CHKH03 = "CHKH03";

        /// <summary>
        /// CHKH04.
        /// </summary>
        public const string CHKH04 = "CHKH04";

        /// <summary>
        /// CHKH05.
        /// </summary>
        public const string CHKH05 = "CHKH05";

        /// <summary>
        /// CHKH06.
        /// </summary>
        public const string CHKH06 = "CHKH06";

        /// <summary>
        /// CHKH07.
        /// </summary>
        public const string CHKH07 = "CHKH07";

        /// <summary>
        /// CHKH08.
        /// </summary>
        public const string CHKH08 = "CHKH08";

        /// <summary>
        /// CHKH09.
        /// </summary>
        public const string CHKH09 = "CHKH09";

        /// <summary>
        /// CHKH10.
        /// </summary>
        public const string CHKH10 = "CHKH10";

        /// <summary>
        /// CHCRR.
        /// </summary>
        public const string CHCRR = "CHCRR";

        /// <summary>
        /// CHCRRD.
        /// </summary>
        public const string CHCRRD = "CHCRRD";

        /// <summary>
        /// CHTOTD.
        /// </summary>
        public const string CHTOTD = "CHTOTD";

        /// <summary>
        /// CHFOAG.
        /// </summary>
        public const string CHFOAG = "CHFOAG";

        /// <summary>
        /// CHCFEE.
        /// </summary>
        public const string CHCFEE = "CHCFEE";

        /// <summary>
        /// CHCFEF.
        /// </summary>
        public const string CHCFEF = "CHCFEF";

        /// <summary>
        /// CHJPID.
        /// </summary>
        public const string CHJPID = "CHJPID";

        /// <summary>
        /// CHVERS.
        /// </summary>
        public const string CHVERS = "CHVERS";

        /// <summary>
        /// CHINTY.
        /// </summary>
        public const string CHINTY = "CHINTY";

        /// <summary>
        /// CHRNFLG.
        /// </summary>
        public const string CHRNFLG = "CHRNFLG";

        /// <summary>
        /// CHBSWAR.
        /// </summary>
        public const string CHBSWAR = "CHBSWAR";

        /// <summary>
        /// CHPCPR.
        /// </summary>
        public const string CHPCPR = "CHPCPR";

        /// <summary>
        /// CHPMTC.
        /// </summary>
        public const string CHPMTC = "CHPMTC";

        /// <summary>
        /// CHCNRC.
        /// </summary>
        public const string CHCNRC = "CHCNRC";

        /// <summary>
        /// CHCNOT.
        /// </summary>
        public const string CHCNOT = "CHCNOT";

        /// <summary>
        /// CHFVTY.
        /// </summary>
        public const string CHFVTY = "CHFVTY";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHCRTU.
        /// </summary>
        public const string CHCRTU = "CHCRTU";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";

        /// <summary>
        /// CHASN1.
        /// </summary>
        public const string CHASN1 = "CHASN1";
    }

    /// <inheritdoc />
    public override string TableName => "F1720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHDOCO", "CHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDCTO", "CHDCTO", JdeDataType.String, 4),
        new JdeField("CHKCOO", "CHKCOO", JdeDataType.String, 10),
        new JdeField("CHCOCH", "CHCOCH", JdeDataType.String, 6, true, true),
        new JdeField("CHDOC1", "CHDOC1", JdeDataType.Numeric),
        new JdeField("CHDCT1", "CHDCT1", JdeDataType.String, 4),
        new JdeField("CHSKCO", "CHSKCO", JdeDataType.String, 10),
        new JdeField("CHOSFX", "CHOSFX", JdeDataType.String, 6),
        new JdeField("CHPCTN", "CHPCTN", JdeDataType.Numeric),
        new JdeField("CHPCTT", "CHPCTT", JdeDataType.String, 4),
        new JdeField("CHPCKO", "CHPCKO", JdeDataType.String, 10),
        new JdeField("CHDL01", "CHDL01", JdeDataType.String, 60),
        new JdeField("CHDC", "CHDC", JdeDataType.String, 80),
        new JdeField("CHDL02", "CHDL02", JdeDataType.String, 60),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHANOB", "CHANOB", JdeDataType.Numeric),
        new JdeField("CHUSA5", "CHUSA5", JdeDataType.Numeric),
        new JdeField("CHLANO", "CHLANO", JdeDataType.Numeric),
        new JdeField("CHCNSTS", "CHCNSTS", JdeDataType.String, 4),
        new JdeField("CHCNTYP", "CHCNTYP", JdeDataType.String, 8),
        new JdeField("CHCONTS", "CHCONTS", JdeDataType.String, 2),
        new JdeField("CHMCUS", "CHMCUS", JdeDataType.String, 24),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHCO", "CHCO", JdeDataType.String, 10),
        new JdeField("CHCSDT", "CHCSDT", JdeDataType.Numeric),
        new JdeField("CHCDTE", "CHCDTE", JdeDataType.Numeric),
        new JdeField("CHCNDJ", "CHCNDJ", JdeDataType.Numeric),
        new JdeField("CHEXR1", "CHEXR1", JdeDataType.String, 4),
        new JdeField("CHTXA1", "CHTXA1", JdeDataType.String, 20),
        new JdeField("CHINVF", "CHINVF", JdeDataType.String, 20),
        new JdeField("CHPTC", "CHPTC", JdeDataType.String, 6),
        new JdeField("CHRYIN", "CHRYIN", JdeDataType.String, 2),
        new JdeField("CHCRCD", "CHCRCD", JdeDataType.String, 6),
        new JdeField("CHCRCF", "CHCRCF", JdeDataType.String, 6),
        new JdeField("CHCRRM", "CHCRRM", JdeDataType.String, 2),
        new JdeField("CHERDB", "CHERDB", JdeDataType.String, 2),
        new JdeField("CHKH01", "CHKH01", JdeDataType.String, 20),
        new JdeField("CHKH02", "CHKH02", JdeDataType.String, 20),
        new JdeField("CHKH03", "CHKH03", JdeDataType.String, 20),
        new JdeField("CHKH04", "CHKH04", JdeDataType.String, 20),
        new JdeField("CHKH05", "CHKH05", JdeDataType.String, 20),
        new JdeField("CHKH06", "CHKH06", JdeDataType.String, 20),
        new JdeField("CHKH07", "CHKH07", JdeDataType.String, 20),
        new JdeField("CHKH08", "CHKH08", JdeDataType.String, 20),
        new JdeField("CHKH09", "CHKH09", JdeDataType.String, 20),
        new JdeField("CHKH10", "CHKH10", JdeDataType.String, 20),
        new JdeField("CHCRR", "CHCRR", JdeDataType.Numeric),
        new JdeField("CHCRRD", "CHCRRD", JdeDataType.Numeric),
        new JdeField("CHTOTD", "CHTOTD", JdeDataType.Numeric),
        new JdeField("CHFOAG", "CHFOAG", JdeDataType.Numeric),
        new JdeField("CHCFEE", "CHCFEE", JdeDataType.Numeric),
        new JdeField("CHCFEF", "CHCFEF", JdeDataType.Numeric),
        new JdeField("CHJPID", "CHJPID", JdeDataType.String, 20),
        new JdeField("CHVERS", "CHVERS", JdeDataType.String, 20),
        new JdeField("CHINTY", "CHINTY", JdeDataType.String, 2),
        new JdeField("CHRNFLG", "CHRNFLG", JdeDataType.String, 2),
        new JdeField("CHBSWAR", "CHBSWAR", JdeDataType.String, 2),
        new JdeField("CHPCPR", "CHPCPR", JdeDataType.Numeric),
        new JdeField("CHPMTC", "CHPMTC", JdeDataType.Numeric),
        new JdeField("CHCNRC", "CHCNRC", JdeDataType.String, 6),
        new JdeField("CHCNOT", "CHCNOT", JdeDataType.Numeric),
        new JdeField("CHFVTY", "CHFVTY", JdeDataType.String, 2),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHCRTU", "CHCRTU", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric),
        new JdeField("CHASN1", "CHASN1", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1720_0", "Primary Key on CHDOCO, CHCOCH", new[] { "CHDOCO", "CHCOCH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1720_7", "Index on CHAN8, CHBSWAR", new[] { "CHAN8", "CHBSWAR" })
    };
}
