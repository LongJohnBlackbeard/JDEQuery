using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1610 - .
/// </summary>
public class F1610 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDASNM.
        /// </summary>
        public const string CDASNM = "CDASNM";

        /// <summary>
        /// CDDL01.
        /// </summary>
        public const string CDDL01 = "CDDL01";

        /// <summary>
        /// CDSEQ.
        /// </summary>
        public const string CDSEQ = "CDSEQ";

        /// <summary>
        /// CDDL02.
        /// </summary>
        public const string CDDL02 = "CDDL02";

        /// <summary>
        /// CDCALT.
        /// </summary>
        public const string CDCALT = "CDCALT";

        /// <summary>
        /// CDAIC.
        /// </summary>
        public const string CDAIC = "CDAIC";

        /// <summary>
        /// CDFROT.
        /// </summary>
        public const string CDFROT = "CDFROT";

        /// <summary>
        /// CDFVRS.
        /// </summary>
        public const string CDFVRS = "CDFVRS";

        /// <summary>
        /// CDBSOT.
        /// </summary>
        public const string CDBSOT = "CDBSOT";

        /// <summary>
        /// CDBVRS.
        /// </summary>
        public const string CDBVRS = "CDBVRS";

        /// <summary>
        /// CDRFAC.
        /// </summary>
        public const string CDRFAC = "CDRFAC";

        /// <summary>
        /// CDBUD.
        /// </summary>
        public const string CDBUD = "CDBUD";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDDFOB.
        /// </summary>
        public const string CDDFOB = "CDDFOB";

        /// <summary>
        /// CDOBJ.
        /// </summary>
        public const string CDOBJ = "CDOBJ";

        /// <summary>
        /// CDDFSU.
        /// </summary>
        public const string CDDFSU = "CDDFSU";

        /// <summary>
        /// CDSUB.
        /// </summary>
        public const string CDSUB = "CDSUB";

        /// <summary>
        /// CDDFSB.
        /// </summary>
        public const string CDDFSB = "CDDFSB";

        /// <summary>
        /// CDSBL.
        /// </summary>
        public const string CDSBL = "CDSBL";

        /// <summary>
        /// CDDFST.
        /// </summary>
        public const string CDDFST = "CDDFST";

        /// <summary>
        /// CDSBLT.
        /// </summary>
        public const string CDSBLT = "CDSBLT";

        /// <summary>
        /// CDDFC1.
        /// </summary>
        public const string CDDFC1 = "CDDFC1";

        /// <summary>
        /// CDABR1.
        /// </summary>
        public const string CDABR1 = "CDABR1";

        /// <summary>
        /// CDDFT1.
        /// </summary>
        public const string CDDFT1 = "CDDFT1";

        /// <summary>
        /// CDABT1.
        /// </summary>
        public const string CDABT1 = "CDABT1";

        /// <summary>
        /// CDDFC2.
        /// </summary>
        public const string CDDFC2 = "CDDFC2";

        /// <summary>
        /// CDABR2.
        /// </summary>
        public const string CDABR2 = "CDABR2";

        /// <summary>
        /// CDDFT2.
        /// </summary>
        public const string CDDFT2 = "CDDFT2";

        /// <summary>
        /// CDABT2.
        /// </summary>
        public const string CDABT2 = "CDABT2";

        /// <summary>
        /// CDDFC3.
        /// </summary>
        public const string CDDFC3 = "CDDFC3";

        /// <summary>
        /// CDABR3.
        /// </summary>
        public const string CDABR3 = "CDABR3";

        /// <summary>
        /// CDDFT3.
        /// </summary>
        public const string CDDFT3 = "CDDFT3";

        /// <summary>
        /// CDABT3.
        /// </summary>
        public const string CDABT3 = "CDABT3";

        /// <summary>
        /// CDDFC4.
        /// </summary>
        public const string CDDFC4 = "CDDFC4";

        /// <summary>
        /// CDABR4.
        /// </summary>
        public const string CDABR4 = "CDABR4";

        /// <summary>
        /// CDDFT4.
        /// </summary>
        public const string CDDFT4 = "CDDFT4";

        /// <summary>
        /// CDABT4.
        /// </summary>
        public const string CDABT4 = "CDABT4";

        /// <summary>
        /// CDDFIT.
        /// </summary>
        public const string CDDFIT = "CDDFIT";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDDFLT.
        /// </summary>
        public const string CDDFLT = "CDDFLT";

        /// <summary>
        /// CDLT.
        /// </summary>
        public const string CDLT = "CDLT";

        /// <summary>
        /// CDDFAT.
        /// </summary>
        public const string CDDFAT = "CDDFAT";

        /// <summary>
        /// CDACTB.
        /// </summary>
        public const string CDACTB = "CDACTB";

        /// <summary>
        /// CDFFP.
        /// </summary>
        public const string CDFFP = "CDFFP";

        /// <summary>
        /// CDFTP.
        /// </summary>
        public const string CDFTP = "CDFTP";

        /// <summary>
        /// CDFFFY.
        /// </summary>
        public const string CDFFFY = "CDFFFY";

        /// <summary>
        /// CDFTFY.
        /// </summary>
        public const string CDFTFY = "CDFTFY";

        /// <summary>
        /// CDBOFP.
        /// </summary>
        public const string CDBOFP = "CDBOFP";

        /// <summary>
        /// CDBOTP.
        /// </summary>
        public const string CDBOTP = "CDBOTP";

        /// <summary>
        /// CDBOFF.
        /// </summary>
        public const string CDBOFF = "CDBOFF";

        /// <summary>
        /// CDBOTF.
        /// </summary>
        public const string CDBOTF = "CDBOTF";

        /// <summary>
        /// CDTOPF.
        /// </summary>
        public const string CDTOPF = "CDTOPF";

        /// <summary>
        /// CDTOPT.
        /// </summary>
        public const string CDTOPT = "CDTOPT";

        /// <summary>
        /// CDTFF.
        /// </summary>
        public const string CDTFF = "CDTFF";

        /// <summary>
        /// CDTTF.
        /// </summary>
        public const string CDTTF = "CDTTF";

        /// <summary>
        /// CDASFR.
        /// </summary>
        public const string CDASFR = "CDASFR";

        /// <summary>
        /// CDFL01.
        /// </summary>
        public const string CDFL01 = "CDFL01";

        /// <summary>
        /// CDFL02.
        /// </summary>
        public const string CDFL02 = "CDFL02";

        /// <summary>
        /// CDFL03.
        /// </summary>
        public const string CDFL03 = "CDFL03";

        /// <summary>
        /// CDFL04.
        /// </summary>
        public const string CDFL04 = "CDFL04";

        /// <summary>
        /// CDFL05.
        /// </summary>
        public const string CDFL05 = "CDFL05";

        /// <summary>
        /// CDCSPL.
        /// </summary>
        public const string CDCSPL = "CDCSPL";

        /// <summary>
        /// CDEFFF.
        /// </summary>
        public const string CDEFFF = "CDEFFF";

        /// <summary>
        /// CDEFFT.
        /// </summary>
        public const string CDEFFT = "CDEFFT";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDCO.
        /// </summary>
        public const string CDCO = "CDCO";

        /// <summary>
        /// CDCUD.
        /// </summary>
        public const string CDCUD = "CDCUD";

        /// <summary>
        /// CDRECA.
        /// </summary>
        public const string CDRECA = "CDRECA";

        /// <summary>
        /// CDRCAT.
        /// </summary>
        public const string CDRCAT = "CDRCAT";

        /// <summary>
        /// CDITH.
        /// </summary>
        public const string CDITH = "CDITH";
    }

    /// <inheritdoc />
    public override string TableName => "F1610";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDASNM", "CDASNM", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDL01", "CDDL01", JdeDataType.String, 60),
        new JdeField("CDSEQ", "CDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDL02", "CDDL02", JdeDataType.String, 60),
        new JdeField("CDCALT", "CDCALT", JdeDataType.String, 2),
        new JdeField("CDAIC", "CDAIC", JdeDataType.String, 2),
        new JdeField("CDFROT", "CDFROT", JdeDataType.String, 2),
        new JdeField("CDFVRS", "CDFVRS", JdeDataType.String, 20),
        new JdeField("CDBSOT", "CDBSOT", JdeDataType.String, 2),
        new JdeField("CDBVRS", "CDBVRS", JdeDataType.String, 20),
        new JdeField("CDRFAC", "CDRFAC", JdeDataType.Numeric),
        new JdeField("CDBUD", "CDBUD", JdeDataType.String, 2),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDDFOB", "CDDFOB", JdeDataType.String, 2),
        new JdeField("CDOBJ", "CDOBJ", JdeDataType.String, 12),
        new JdeField("CDDFSU", "CDDFSU", JdeDataType.String, 2),
        new JdeField("CDSUB", "CDSUB", JdeDataType.String, 16),
        new JdeField("CDDFSB", "CDDFSB", JdeDataType.String, 2),
        new JdeField("CDSBL", "CDSBL", JdeDataType.String, 16),
        new JdeField("CDDFST", "CDDFST", JdeDataType.String, 2),
        new JdeField("CDSBLT", "CDSBLT", JdeDataType.String, 2),
        new JdeField("CDDFC1", "CDDFC1", JdeDataType.String, 2),
        new JdeField("CDABR1", "CDABR1", JdeDataType.String, 24),
        new JdeField("CDDFT1", "CDDFT1", JdeDataType.String, 2),
        new JdeField("CDABT1", "CDABT1", JdeDataType.String, 2),
        new JdeField("CDDFC2", "CDDFC2", JdeDataType.String, 2),
        new JdeField("CDABR2", "CDABR2", JdeDataType.String, 24),
        new JdeField("CDDFT2", "CDDFT2", JdeDataType.String, 2),
        new JdeField("CDABT2", "CDABT2", JdeDataType.String, 2),
        new JdeField("CDDFC3", "CDDFC3", JdeDataType.String, 2),
        new JdeField("CDABR3", "CDABR3", JdeDataType.String, 24),
        new JdeField("CDDFT3", "CDDFT3", JdeDataType.String, 2),
        new JdeField("CDABT3", "CDABT3", JdeDataType.String, 2),
        new JdeField("CDDFC4", "CDDFC4", JdeDataType.String, 2),
        new JdeField("CDABR4", "CDABR4", JdeDataType.String, 24),
        new JdeField("CDDFT4", "CDDFT4", JdeDataType.String, 2),
        new JdeField("CDABT4", "CDABT4", JdeDataType.String, 2),
        new JdeField("CDDFIT", "CDDFIT", JdeDataType.String, 2),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDDFLT", "CDDFLT", JdeDataType.String, 2),
        new JdeField("CDLT", "CDLT", JdeDataType.String, 4),
        new JdeField("CDDFAT", "CDDFAT", JdeDataType.String, 2),
        new JdeField("CDACTB", "CDACTB", JdeDataType.String, 20),
        new JdeField("CDFFP", "CDFFP", JdeDataType.Numeric),
        new JdeField("CDFTP", "CDFTP", JdeDataType.Numeric),
        new JdeField("CDFFFY", "CDFFFY", JdeDataType.Numeric),
        new JdeField("CDFTFY", "CDFTFY", JdeDataType.Numeric),
        new JdeField("CDBOFP", "CDBOFP", JdeDataType.Numeric),
        new JdeField("CDBOTP", "CDBOTP", JdeDataType.Numeric),
        new JdeField("CDBOFF", "CDBOFF", JdeDataType.Numeric),
        new JdeField("CDBOTF", "CDBOTF", JdeDataType.Numeric),
        new JdeField("CDTOPF", "CDTOPF", JdeDataType.Numeric),
        new JdeField("CDTOPT", "CDTOPT", JdeDataType.Numeric),
        new JdeField("CDTFF", "CDTFF", JdeDataType.Numeric),
        new JdeField("CDTTF", "CDTTF", JdeDataType.Numeric),
        new JdeField("CDASFR", "CDASFR", JdeDataType.String, 2),
        new JdeField("CDFL01", "CDFL01", JdeDataType.String, 2),
        new JdeField("CDFL02", "CDFL02", JdeDataType.String, 2),
        new JdeField("CDFL03", "CDFL03", JdeDataType.String, 2),
        new JdeField("CDFL04", "CDFL04", JdeDataType.String, 2),
        new JdeField("CDFL05", "CDFL05", JdeDataType.String, 2),
        new JdeField("CDCSPL", "CDCSPL", JdeDataType.String, 20),
        new JdeField("CDEFFF", "CDEFFF", JdeDataType.Numeric),
        new JdeField("CDEFFT", "CDEFFT", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDCO", "CDCO", JdeDataType.String, 10),
        new JdeField("CDCUD", "CDCUD", JdeDataType.String, 2),
        new JdeField("CDRECA", "CDRECA", JdeDataType.String, 2),
        new JdeField("CDRCAT", "CDRCAT", JdeDataType.String, 2),
        new JdeField("CDITH", "CDITH", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1610_0", "Primary Key on CDASNM, CDSEQ", new[] { "CDASNM", "CDSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
