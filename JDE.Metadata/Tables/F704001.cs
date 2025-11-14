using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704001 - .
/// </summary>
public class F704001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTK70BTXC.
        /// </summary>
        public const string PTK70BTXC = "PTK70BTXC";

        /// <summary>
        /// PTHDC.
        /// </summary>
        public const string PTHDC = "PTHDC";

        /// <summary>
        /// PTCKC.
        /// </summary>
        public const string PTCKC = "PTCKC";

        /// <summary>
        /// PTDCTM.
        /// </summary>
        public const string PTDCTM = "PTDCTM";

        /// <summary>
        /// PTDOCM.
        /// </summary>
        public const string PTDOCM = "PTDOCM";

        /// <summary>
        /// PTOKCO.
        /// </summary>
        public const string PTOKCO = "PTOKCO";

        /// <summary>
        /// PTODCT.
        /// </summary>
        public const string PTODCT = "PTODCT";

        /// <summary>
        /// PTODOC.
        /// </summary>
        public const string PTODOC = "PTODOC";

        /// <summary>
        /// PTOSFX.
        /// </summary>
        public const string PTOSFX = "PTOSFX";

        /// <summary>
        /// PTKCO.
        /// </summary>
        public const string PTKCO = "PTKCO";

        /// <summary>
        /// PTDCT.
        /// </summary>
        public const string PTDCT = "PTDCT";

        /// <summary>
        /// PTDOC.
        /// </summary>
        public const string PTDOC = "PTDOC";

        /// <summary>
        /// PTSFX.
        /// </summary>
        public const string PTSFX = "PTSFX";

        /// <summary>
        /// PTSFXE.
        /// </summary>
        public const string PTSFXE = "PTSFXE";

        /// <summary>
        /// PTCO.
        /// </summary>
        public const string PTCO = "PTCO";

        /// <summary>
        /// PTTX2.
        /// </summary>
        public const string PTTX2 = "PTTX2";

        /// <summary>
        /// PTK70BCNC.
        /// </summary>
        public const string PTK70BCNC = "PTK70BCNC";

        /// <summary>
        /// PTK70BJRD.
        /// </summary>
        public const string PTK70BJRD = "PTK70BJRD";

        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTTAX.
        /// </summary>
        public const string PTTAX = "PTTAX";

        /// <summary>
        /// PTCTRY.
        /// </summary>
        public const string PTCTRY = "PTCTRY";

        /// <summary>
        /// PTFY.
        /// </summary>
        public const string PTFY = "PTFY";

        /// <summary>
        /// PTPN.
        /// </summary>
        public const string PTPN = "PTPN";

        /// <summary>
        /// PTK70BORB.
        /// </summary>
        public const string PTK70BORB = "PTK70BORB";

        /// <summary>
        /// PTK70BREB.
        /// </summary>
        public const string PTK70BREB = "PTK70BREB";

        /// <summary>
        /// PTK70BSRB.
        /// </summary>
        public const string PTK70BSRB = "PTK70BSRB";

        /// <summary>
        /// PTK70BPRB.
        /// </summary>
        public const string PTK70BPRB = "PTK70BPRB";

        /// <summary>
        /// PTK70BPOB.
        /// </summary>
        public const string PTK70BPOB = "PTK70BPOB";

        /// <summary>
        /// PTK70BAAB.
        /// </summary>
        public const string PTK70BAAB = "PTK70BAAB";

        /// <summary>
        /// PTK70BCAB.
        /// </summary>
        public const string PTK70BCAB = "PTK70BCAB";

        /// <summary>
        /// PTK70BRT1.
        /// </summary>
        public const string PTK70BRT1 = "PTK70BRT1";

        /// <summary>
        /// PTK70BORW.
        /// </summary>
        public const string PTK70BORW = "PTK70BORW";

        /// <summary>
        /// PTK70BAAW.
        /// </summary>
        public const string PTK70BAAW = "PTK70BAAW";

        /// <summary>
        /// PTK70BREW.
        /// </summary>
        public const string PTK70BREW = "PTK70BREW";

        /// <summary>
        /// PTK70BSRW.
        /// </summary>
        public const string PTK70BSRW = "PTK70BSRW";

        /// <summary>
        /// PTK70BPRW.
        /// </summary>
        public const string PTK70BPRW = "PTK70BPRW";

        /// <summary>
        /// PTK70BATW.
        /// </summary>
        public const string PTK70BATW = "PTK70BATW";

        /// <summary>
        /// PTK70BPOW.
        /// </summary>
        public const string PTK70BPOW = "PTK70BPOW";

        /// <summary>
        /// PTK70BCAW.
        /// </summary>
        public const string PTK70BCAW = "PTK70BCAW";

        /// <summary>
        /// PTDMTJ.
        /// </summary>
        public const string PTDMTJ = "PTDMTJ";

        /// <summary>
        /// PTVDGJ.
        /// </summary>
        public const string PTVDGJ = "PTVDGJ";

        /// <summary>
        /// PTVR01.
        /// </summary>
        public const string PTVR01 = "PTVR01";

        /// <summary>
        /// PTFYR.
        /// </summary>
        public const string PTFYR = "PTFYR";

        /// <summary>
        /// PTK70ACEM.
        /// </summary>
        public const string PTK70ACEM = "PTK70ACEM";

        /// <summary>
        /// PTN001.
        /// </summary>
        public const string PTN001 = "PTN001";

        /// <summary>
        /// PTAN80.
        /// </summary>
        public const string PTAN80 = "PTAN80";

        /// <summary>
        /// PTFCO.
        /// </summary>
        public const string PTFCO = "PTFCO";

        /// <summary>
        /// PTK70UEMF.
        /// </summary>
        public const string PTK70UEMF = "PTK70UEMF";

        /// <summary>
        /// PTK70PSPI.
        /// </summary>
        public const string PTK70PSPI = "PTK70PSPI";

        /// <summary>
        /// PTCRRM.
        /// </summary>
        public const string PTCRRM = "PTCRRM";

        /// <summary>
        /// PTBCRC.
        /// </summary>
        public const string PTBCRC = "PTBCRC";

        /// <summary>
        /// PTCRCD.
        /// </summary>
        public const string PTCRCD = "PTCRCD";

        /// <summary>
        /// PTCRR.
        /// </summary>
        public const string PTCRR = "PTCRR";

        /// <summary>
        /// PTCRR1.
        /// </summary>
        public const string PTCRR1 = "PTCRR1";

        /// <summary>
        /// PTCRR2.
        /// </summary>
        public const string PTCRR2 = "PTCRR2";

        /// <summary>
        /// PTCRCM.
        /// </summary>
        public const string PTCRCM = "PTCRCM";

        /// <summary>
        /// PTURC1.
        /// </summary>
        public const string PTURC1 = "PTURC1";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F704001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTK70BTXC", "PTK70BTXC", JdeDataType.String, 20, true, true),
        new JdeField("PTHDC", "PTHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("PTCKC", "PTCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCTM", "PTDCTM", JdeDataType.String, 4, true, true),
        new JdeField("PTDOCM", "PTDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("PTOKCO", "PTOKCO", JdeDataType.String, 10, true, true),
        new JdeField("PTODCT", "PTODCT", JdeDataType.String, 4, true, true),
        new JdeField("PTODOC", "PTODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PTOSFX", "PTOSFX", JdeDataType.String, 6, true, true),
        new JdeField("PTKCO", "PTKCO", JdeDataType.String, 10, true, true),
        new JdeField("PTDCT", "PTDCT", JdeDataType.String, 4, true, true),
        new JdeField("PTDOC", "PTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PTSFX", "PTSFX", JdeDataType.String, 6, true, true),
        new JdeField("PTSFXE", "PTSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("PTCO", "PTCO", JdeDataType.String, 10),
        new JdeField("PTTX2", "PTTX2", JdeDataType.String, 40),
        new JdeField("PTK70BCNC", "PTK70BCNC", JdeDataType.String, 20),
        new JdeField("PTK70BJRD", "PTK70BJRD", JdeDataType.String, 8),
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric),
        new JdeField("PTTAX", "PTTAX", JdeDataType.String, 40),
        new JdeField("PTCTRY", "PTCTRY", JdeDataType.Numeric),
        new JdeField("PTFY", "PTFY", JdeDataType.Numeric),
        new JdeField("PTPN", "PTPN", JdeDataType.Numeric),
        new JdeField("PTK70BORB", "PTK70BORB", JdeDataType.Numeric),
        new JdeField("PTK70BREB", "PTK70BREB", JdeDataType.Numeric),
        new JdeField("PTK70BSRB", "PTK70BSRB", JdeDataType.Numeric),
        new JdeField("PTK70BPRB", "PTK70BPRB", JdeDataType.Numeric),
        new JdeField("PTK70BPOB", "PTK70BPOB", JdeDataType.Numeric),
        new JdeField("PTK70BAAB", "PTK70BAAB", JdeDataType.Numeric),
        new JdeField("PTK70BCAB", "PTK70BCAB", JdeDataType.Numeric),
        new JdeField("PTK70BRT1", "PTK70BRT1", JdeDataType.Numeric),
        new JdeField("PTK70BORW", "PTK70BORW", JdeDataType.Numeric),
        new JdeField("PTK70BAAW", "PTK70BAAW", JdeDataType.Numeric),
        new JdeField("PTK70BREW", "PTK70BREW", JdeDataType.Numeric),
        new JdeField("PTK70BSRW", "PTK70BSRW", JdeDataType.Numeric),
        new JdeField("PTK70BPRW", "PTK70BPRW", JdeDataType.Numeric),
        new JdeField("PTK70BATW", "PTK70BATW", JdeDataType.Numeric),
        new JdeField("PTK70BPOW", "PTK70BPOW", JdeDataType.Numeric),
        new JdeField("PTK70BCAW", "PTK70BCAW", JdeDataType.Numeric),
        new JdeField("PTDMTJ", "PTDMTJ", JdeDataType.Numeric),
        new JdeField("PTVDGJ", "PTVDGJ", JdeDataType.Numeric),
        new JdeField("PTVR01", "PTVR01", JdeDataType.String, 50),
        new JdeField("PTFYR", "PTFYR", JdeDataType.Numeric),
        new JdeField("PTK70ACEM", "PTK70ACEM", JdeDataType.String, 8),
        new JdeField("PTN001", "PTN001", JdeDataType.Numeric),
        new JdeField("PTAN80", "PTAN80", JdeDataType.Numeric),
        new JdeField("PTFCO", "PTFCO", JdeDataType.String, 10),
        new JdeField("PTK70UEMF", "PTK70UEMF", JdeDataType.String, 2),
        new JdeField("PTK70PSPI", "PTK70PSPI", JdeDataType.String, 2),
        new JdeField("PTCRRM", "PTCRRM", JdeDataType.String, 2),
        new JdeField("PTBCRC", "PTBCRC", JdeDataType.String, 6),
        new JdeField("PTCRCD", "PTCRCD", JdeDataType.String, 6),
        new JdeField("PTCRR", "PTCRR", JdeDataType.Numeric),
        new JdeField("PTCRR1", "PTCRR1", JdeDataType.Numeric),
        new JdeField("PTCRR2", "PTCRR2", JdeDataType.Numeric),
        new JdeField("PTCRCM", "PTCRCM", JdeDataType.String, 2),
        new JdeField("PTURC1", "PTURC1", JdeDataType.String, 6),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704001_0", "Primary Key on PTK70BTXC, PTHDC, PTCKC, PTDCTM, PTDOCM, PTOKCO, PTODCT, PTODOC, PTOSFX, PTKCO, PTDCT, PTDOC, PTSFX, PTSFXE", new[] { "PTK70BTXC", "PTHDC", "PTCKC", "PTDCTM", "PTDOCM", "PTOKCO", "PTODCT", "PTODOC", "PTOSFX", "PTKCO", "PTDCT", "PTDOC", "PTSFX", "PTSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F704001_2", "Index on PTK70BTXC, PTHDC, PTCKC", new[] { "PTK70BTXC", "PTHDC", "PTCKC" }),
        new JdeIndex("F704001_3", "Index on PTK70BTXC, PTOKCO, PTODCT, PTODOC, PTOSFX", new[] { "PTK70BTXC", "PTOKCO", "PTODCT", "PTODOC", "PTOSFX" }),
        new JdeIndex("F704001_4", "Index on PTK70BTXC, PTKCO, PTDCT, PTDOC, PTSFX, PTSFXE", new[] { "PTK70BTXC", "PTKCO", "PTDCT", "PTDOC", "PTSFX", "PTSFXE" })
    };
}
