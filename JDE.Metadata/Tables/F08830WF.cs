using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08830WF - .
/// </summary>
public class F08830WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YNMNAME.
        /// </summary>
        public const string YNMNAME = "YNMNAME";

        /// <summary>
        /// YNMTYPC.
        /// </summary>
        public const string YNMTYPC = "YNMTYPC";

        /// <summary>
        /// YNMDL01.
        /// </summary>
        public const string YNMDL01 = "YNMDL01";

        /// <summary>
        /// YNMOWNR.
        /// </summary>
        public const string YNMOWNR = "YNMOWNR";

        /// <summary>
        /// YNRWTYP.
        /// </summary>
        public const string YNRWTYP = "YNRWTYP";

        /// <summary>
        /// YNAN8.
        /// </summary>
        public const string YNAN8 = "YNAN8";

        /// <summary>
        /// YNALPH.
        /// </summary>
        public const string YNALPH = "YNALPH";

        /// <summary>
        /// YNANPA.
        /// </summary>
        public const string YNANPA = "YNANPA";

        /// <summary>
        /// YNSPRVN.
        /// </summary>
        public const string YNSPRVN = "YNSPRVN";

        /// <summary>
        /// YNDST.
        /// </summary>
        public const string YNDST = "YNDST";

        /// <summary>
        /// YNCO.
        /// </summary>
        public const string YNCO = "YNCO";

        /// <summary>
        /// YNHMCU.
        /// </summary>
        public const string YNHMCU = "YNHMCU";

        /// <summary>
        /// YNEST.
        /// </summary>
        public const string YNEST = "YNEST";

        /// <summary>
        /// YNPAST.
        /// </summary>
        public const string YNPAST = "YNPAST";

        /// <summary>
        /// YNUN.
        /// </summary>
        public const string YNUN = "YNUN";

        /// <summary>
        /// YNSALY.
        /// </summary>
        public const string YNSALY = "YNSALY";

        /// <summary>
        /// YNCOIHR.
        /// </summary>
        public const string YNCOIHR = "YNCOIHR";

        /// <summary>
        /// YNFTE.
        /// </summary>
        public const string YNFTE = "YNFTE";

        /// <summary>
        /// YNIH.
        /// </summary>
        public const string YNIH = "YNIH";

        /// <summary>
        /// YNPHRT.
        /// </summary>
        public const string YNPHRT = "YNPHRT";

        /// <summary>
        /// YNCASAL.
        /// </summary>
        public const string YNCASAL = "YNCASAL";

        /// <summary>
        /// YNCMPA.
        /// </summary>
        public const string YNCMPA = "YNCMPA";

        /// <summary>
        /// YNJBCX.
        /// </summary>
        public const string YNJBCX = "YNJBCX";

        /// <summary>
        /// YNCPDT.
        /// </summary>
        public const string YNCPDT = "YNCPDT";

        /// <summary>
        /// YNSAL.
        /// </summary>
        public const string YNSAL = "YNSAL";

        /// <summary>
        /// YNSLOC.
        /// </summary>
        public const string YNSLOC = "YNSLOC";

        /// <summary>
        /// YNPOS.
        /// </summary>
        public const string YNPOS = "YNPOS";

        /// <summary>
        /// YNDL01.
        /// </summary>
        public const string YNDL01 = "YNDL01";

        /// <summary>
        /// YNCDIJ.
        /// </summary>
        public const string YNCDIJ = "YNCDIJ";

        /// <summary>
        /// YNJBCD.
        /// </summary>
        public const string YNJBCD = "YNJBCD";

        /// <summary>
        /// YNDL02.
        /// </summary>
        public const string YNDL02 = "YNDL02";

        /// <summary>
        /// YNJBST.
        /// </summary>
        public const string YNJBST = "YNJBST";

        /// <summary>
        /// YNPGRD.
        /// </summary>
        public const string YNPGRD = "YNPGRD";

        /// <summary>
        /// YNPGRS.
        /// </summary>
        public const string YNPGRS = "YNPGRS";

        /// <summary>
        /// YNTIJM.
        /// </summary>
        public const string YNTIJM = "YNTIJM";

        /// <summary>
        /// YNTIPM.
        /// </summary>
        public const string YNTIPM = "YNTIPM";

        /// <summary>
        /// YNLISM.
        /// </summary>
        public const string YNLISM = "YNLISM";

        /// <summary>
        /// YNDR.
        /// </summary>
        public const string YNDR = "YNDR";

        /// <summary>
        /// YNLSRD.
        /// </summary>
        public const string YNLSRD = "YNLSRD";

        /// <summary>
        /// YNNSRD.
        /// </summary>
        public const string YNNSRD = "YNNSRD";

        /// <summary>
        /// YNCOCHG.
        /// </summary>
        public const string YNCOCHG = "YNCOCHG";

        /// <summary>
        /// YNBUCHG.
        /// </summary>
        public const string YNBUCHG = "YNBUCHG";

        /// <summary>
        /// YNPSCHG.
        /// </summary>
        public const string YNPSCHG = "YNPSCHG";

        /// <summary>
        /// YNUNCHG.
        /// </summary>
        public const string YNUNCHG = "YNUNCHG";

        /// <summary>
        /// YNLOCHG.
        /// </summary>
        public const string YNLOCHG = "YNLOCHG";

        /// <summary>
        /// YNPCCHG.
        /// </summary>
        public const string YNPCCHG = "YNPCCHG";

        /// <summary>
        /// YNCSCHG.
        /// </summary>
        public const string YNCSCHG = "YNCSCHG";

        /// <summary>
        /// YNCCCHG.
        /// </summary>
        public const string YNCCCHG = "YNCCCHG";

        /// <summary>
        /// YNCPCHG.
        /// </summary>
        public const string YNCPCHG = "YNCPCHG";

        /// <summary>
        /// YNPDCHG.
        /// </summary>
        public const string YNPDCHG = "YNPDCHG";

        /// <summary>
        /// YNJDCHG.
        /// </summary>
        public const string YNJDCHG = "YNJDCHG";

        /// <summary>
        /// YNSPCHG.
        /// </summary>
        public const string YNSPCHG = "YNSPCHG";

        /// <summary>
        /// YNCJTCHG.
        /// </summary>
        public const string YNCJTCHG = "YNCJTCHG";

        /// <summary>
        /// YNCJSCHG.
        /// </summary>
        public const string YNCJSCHG = "YNCJSCHG";

        /// <summary>
        /// YNCPGCHG.
        /// </summary>
        public const string YNCPGCHG = "YNCPGCHG";

        /// <summary>
        /// YNCPSCHG.
        /// </summary>
        public const string YNCPSCHG = "YNCPSCHG";

        /// <summary>
        /// YNLRDCHG.
        /// </summary>
        public const string YNLRDCHG = "YNLRDCHG";

        /// <summary>
        /// YNNSEFTO.
        /// </summary>
        public const string YNNSEFTO = "YNNSEFTO";

        /// <summary>
        /// YNNAS.
        /// </summary>
        public const string YNNAS = "YNNAS";

        /// <summary>
        /// YNNSOR.
        /// </summary>
        public const string YNNSOR = "YNNSOR";

        /// <summary>
        /// YNNCR.
        /// </summary>
        public const string YNNCR = "YNNCR";

        /// <summary>
        /// YNNPOS.
        /// </summary>
        public const string YNNPOS = "YNNPOS";

        /// <summary>
        /// YNNEJT.
        /// </summary>
        public const string YNNEJT = "YNNEJT";

        /// <summary>
        /// YNNHRR.
        /// </summary>
        public const string YNNHRR = "YNNHRR";

        /// <summary>
        /// YNNSALY.
        /// </summary>
        public const string YNNSALY = "YNNSALY";

        /// <summary>
        /// YNNPDL01.
        /// </summary>
        public const string YNNPDL01 = "YNNPDL01";

        /// <summary>
        /// YNNJT.
        /// </summary>
        public const string YNNJT = "YNNJT";

        /// <summary>
        /// YNNJTDL.
        /// </summary>
        public const string YNNJTDL = "YNNJTDL";

        /// <summary>
        /// YNNJS.
        /// </summary>
        public const string YNNJS = "YNNJS";

        /// <summary>
        /// YNNPGR.
        /// </summary>
        public const string YNNPGR = "YNNPGR";

        /// <summary>
        /// YNNPST.
        /// </summary>
        public const string YNNPST = "YNNPST";

        /// <summary>
        /// YNPFRQ.
        /// </summary>
        public const string YNPFRQ = "YNPFRQ";

        /// <summary>
        /// YNFLSA.
        /// </summary>
        public const string YNFLSA = "YNFLSA";

        /// <summary>
        /// YNNUN.
        /// </summary>
        public const string YNNUN = "YNNUN";

        /// <summary>
        /// YNDIVC.
        /// </summary>
        public const string YNDIVC = "YNDIVC";

        /// <summary>
        /// YNJTTRS.
        /// </summary>
        public const string YNJTTRS = "YNJTTRS";

        /// <summary>
        /// YNPAPL.
        /// </summary>
        public const string YNPAPL = "YNPAPL";

        /// <summary>
        /// YNDATRVW.
        /// </summary>
        public const string YNDATRVW = "YNDATRVW";

        /// <summary>
        /// YNTIRNK.
        /// </summary>
        public const string YNTIRNK = "YNTIRNK";

        /// <summary>
        /// YNTRNKD.
        /// </summary>
        public const string YNTRNKD = "YNTRNKD";

        /// <summary>
        /// YNJBPCTRQD.
        /// </summary>
        public const string YNJBPCTRQD = "YNJBPCTRQD";

        /// <summary>
        /// YNLTJCRW.
        /// </summary>
        public const string YNLTJCRW = "YNLTJCRW";

        /// <summary>
        /// YNTBAM.
        /// </summary>
        public const string YNTBAM = "YNTBAM";

        /// <summary>
        /// YNTIAM.
        /// </summary>
        public const string YNTIAM = "YNTIAM";

        /// <summary>
        /// YNAPPST.
        /// </summary>
        public const string YNAPPST = "YNAPPST";

        /// <summary>
        /// YNANAB.
        /// </summary>
        public const string YNANAB = "YNANAB";

        /// <summary>
        /// YNLARD.
        /// </summary>
        public const string YNLARD = "YNLARD";

        /// <summary>
        /// YNUSER.
        /// </summary>
        public const string YNUSER = "YNUSER";

        /// <summary>
        /// YNPID.
        /// </summary>
        public const string YNPID = "YNPID";

        /// <summary>
        /// YNUPMJ.
        /// </summary>
        public const string YNUPMJ = "YNUPMJ";

        /// <summary>
        /// YNUPMT.
        /// </summary>
        public const string YNUPMT = "YNUPMT";

        /// <summary>
        /// YNJOBN.
        /// </summary>
        public const string YNJOBN = "YNJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08830WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YNMNAME", "YNMNAME", JdeDataType.String, 20, true, true),
        new JdeField("YNMTYPC", "YNMTYPC", JdeDataType.String, 2),
        new JdeField("YNMDL01", "YNMDL01", JdeDataType.String, 60),
        new JdeField("YNMOWNR", "YNMOWNR", JdeDataType.Numeric, null, true, true),
        new JdeField("YNRWTYP", "YNRWTYP", JdeDataType.String, 2, true, true),
        new JdeField("YNAN8", "YNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YNALPH", "YNALPH", JdeDataType.String, 80),
        new JdeField("YNANPA", "YNANPA", JdeDataType.Numeric),
        new JdeField("YNSPRVN", "YNSPRVN", JdeDataType.String, 60),
        new JdeField("YNDST", "YNDST", JdeDataType.Numeric),
        new JdeField("YNCO", "YNCO", JdeDataType.String, 10),
        new JdeField("YNHMCU", "YNHMCU", JdeDataType.String, 24),
        new JdeField("YNEST", "YNEST", JdeDataType.String, 2),
        new JdeField("YNPAST", "YNPAST", JdeDataType.String, 2),
        new JdeField("YNUN", "YNUN", JdeDataType.String, 12),
        new JdeField("YNSALY", "YNSALY", JdeDataType.String, 2),
        new JdeField("YNCOIHR", "YNCOIHR", JdeDataType.Numeric),
        new JdeField("YNFTE", "YNFTE", JdeDataType.Numeric),
        new JdeField("YNIH", "YNIH", JdeDataType.Numeric),
        new JdeField("YNPHRT", "YNPHRT", JdeDataType.Numeric),
        new JdeField("YNCASAL", "YNCASAL", JdeDataType.Numeric),
        new JdeField("YNCMPA", "YNCMPA", JdeDataType.Numeric),
        new JdeField("YNJBCX", "YNJBCX", JdeDataType.String, 60),
        new JdeField("YNCPDT", "YNCPDT", JdeDataType.Numeric),
        new JdeField("YNSAL", "YNSAL", JdeDataType.Numeric),
        new JdeField("YNSLOC", "YNSLOC", JdeDataType.String, 16),
        new JdeField("YNPOS", "YNPOS", JdeDataType.String, 16),
        new JdeField("YNDL01", "YNDL01", JdeDataType.String, 60),
        new JdeField("YNCDIJ", "YNCDIJ", JdeDataType.Numeric),
        new JdeField("YNJBCD", "YNJBCD", JdeDataType.String, 12),
        new JdeField("YNDL02", "YNDL02", JdeDataType.String, 60),
        new JdeField("YNJBST", "YNJBST", JdeDataType.String, 8),
        new JdeField("YNPGRD", "YNPGRD", JdeDataType.String, 12),
        new JdeField("YNPGRS", "YNPGRS", JdeDataType.String, 8),
        new JdeField("YNTIJM", "YNTIJM", JdeDataType.Numeric),
        new JdeField("YNTIPM", "YNTIPM", JdeDataType.Numeric),
        new JdeField("YNLISM", "YNLISM", JdeDataType.Numeric),
        new JdeField("YNDR", "YNDR", JdeDataType.Numeric),
        new JdeField("YNLSRD", "YNLSRD", JdeDataType.Numeric),
        new JdeField("YNNSRD", "YNNSRD", JdeDataType.Numeric),
        new JdeField("YNCOCHG", "YNCOCHG", JdeDataType.String, 2),
        new JdeField("YNBUCHG", "YNBUCHG", JdeDataType.String, 2),
        new JdeField("YNPSCHG", "YNPSCHG", JdeDataType.String, 2),
        new JdeField("YNUNCHG", "YNUNCHG", JdeDataType.String, 2),
        new JdeField("YNLOCHG", "YNLOCHG", JdeDataType.String, 2),
        new JdeField("YNPCCHG", "YNPCCHG", JdeDataType.String, 2),
        new JdeField("YNCSCHG", "YNCSCHG", JdeDataType.String, 2),
        new JdeField("YNCCCHG", "YNCCCHG", JdeDataType.String, 2),
        new JdeField("YNCPCHG", "YNCPCHG", JdeDataType.String, 2),
        new JdeField("YNPDCHG", "YNPDCHG", JdeDataType.String, 2),
        new JdeField("YNJDCHG", "YNJDCHG", JdeDataType.String, 2),
        new JdeField("YNSPCHG", "YNSPCHG", JdeDataType.String, 2),
        new JdeField("YNCJTCHG", "YNCJTCHG", JdeDataType.String, 2),
        new JdeField("YNCJSCHG", "YNCJSCHG", JdeDataType.String, 2),
        new JdeField("YNCPGCHG", "YNCPGCHG", JdeDataType.String, 2),
        new JdeField("YNCPSCHG", "YNCPSCHG", JdeDataType.String, 2),
        new JdeField("YNLRDCHG", "YNLRDCHG", JdeDataType.String, 2),
        new JdeField("YNNSEFTO", "YNNSEFTO", JdeDataType.Numeric),
        new JdeField("YNNAS", "YNNAS", JdeDataType.Numeric),
        new JdeField("YNNSOR", "YNNSOR", JdeDataType.String, 2),
        new JdeField("YNNCR", "YNNCR", JdeDataType.Numeric),
        new JdeField("YNNPOS", "YNNPOS", JdeDataType.String, 16),
        new JdeField("YNNEJT", "YNNEJT", JdeDataType.String, 60),
        new JdeField("YNNHRR", "YNNHRR", JdeDataType.Numeric),
        new JdeField("YNNSALY", "YNNSALY", JdeDataType.String, 2),
        new JdeField("YNNPDL01", "YNNPDL01", JdeDataType.String, 60),
        new JdeField("YNNJT", "YNNJT", JdeDataType.String, 12),
        new JdeField("YNNJTDL", "YNNJTDL", JdeDataType.String, 60),
        new JdeField("YNNJS", "YNNJS", JdeDataType.String, 8),
        new JdeField("YNNPGR", "YNNPGR", JdeDataType.String, 12),
        new JdeField("YNNPST", "YNNPST", JdeDataType.String, 8),
        new JdeField("YNPFRQ", "YNPFRQ", JdeDataType.String, 2),
        new JdeField("YNFLSA", "YNFLSA", JdeDataType.String, 2),
        new JdeField("YNNUN", "YNNUN", JdeDataType.String, 12),
        new JdeField("YNDIVC", "YNDIVC", JdeDataType.String, 12),
        new JdeField("YNJTTRS", "YNJTTRS", JdeDataType.String, 6),
        new JdeField("YNPAPL", "YNPAPL", JdeDataType.Numeric),
        new JdeField("YNDATRVW", "YNDATRVW", JdeDataType.Numeric),
        new JdeField("YNTIRNK", "YNTIRNK", JdeDataType.Numeric),
        new JdeField("YNTRNKD", "YNTRNKD", JdeDataType.Numeric),
        new JdeField("YNJBPCTRQD", "YNJBPCTRQD", JdeDataType.Numeric),
        new JdeField("YNLTJCRW", "YNLTJCRW", JdeDataType.Numeric),
        new JdeField("YNTBAM", "YNTBAM", JdeDataType.Numeric),
        new JdeField("YNTIAM", "YNTIAM", JdeDataType.Numeric),
        new JdeField("YNAPPST", "YNAPPST", JdeDataType.String, 2),
        new JdeField("YNANAB", "YNANAB", JdeDataType.Numeric),
        new JdeField("YNLARD", "YNLARD", JdeDataType.Numeric),
        new JdeField("YNUSER", "YNUSER", JdeDataType.String, 20),
        new JdeField("YNPID", "YNPID", JdeDataType.String, 20),
        new JdeField("YNUPMJ", "YNUPMJ", JdeDataType.Numeric),
        new JdeField("YNUPMT", "YNUPMT", JdeDataType.Numeric),
        new JdeField("YNJOBN", "YNJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08830WF_0", "Primary Key on YNMNAME, YNRWTYP, YNAN8, YNMOWNR", new[] { "YNMNAME", "YNRWTYP", "YNAN8", "YNMOWNR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08830WF_3", "Index on YNMNAME, YNRWTYP, YNALPH", new[] { "YNMNAME", "YNRWTYP", "YNALPH" }),
        new JdeIndex("F08830WF_4", "Index on YNMNAME, YNRWTYP, YNAN8", new[] { "YNMNAME", "YNRWTYP", "YNAN8" }),
        new JdeIndex("F08830WF_5", "Index on YNMNAME, YNRWTYP, YNALPH, YNMOWNR", new[] { "YNMNAME", "YNRWTYP", "YNALPH", "YNMOWNR" })
    };
}
