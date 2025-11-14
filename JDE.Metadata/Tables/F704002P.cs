using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704002P - .
/// </summary>
public class F704002P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFK70BTXC.
        /// </summary>
        public const string PFK70BTXC = "PFK70BTXC";

        /// <summary>
        /// PFPYID.
        /// </summary>
        public const string PFPYID = "PFPYID";

        /// <summary>
        /// PFDCTM.
        /// </summary>
        public const string PFDCTM = "PFDCTM";

        /// <summary>
        /// PFDOCM.
        /// </summary>
        public const string PFDOCM = "PFDOCM";

        /// <summary>
        /// PFOKCO.
        /// </summary>
        public const string PFOKCO = "PFOKCO";

        /// <summary>
        /// PFODCT.
        /// </summary>
        public const string PFODCT = "PFODCT";

        /// <summary>
        /// PFODOC.
        /// </summary>
        public const string PFODOC = "PFODOC";

        /// <summary>
        /// PFOSFX.
        /// </summary>
        public const string PFOSFX = "PFOSFX";

        /// <summary>
        /// PFKCO.
        /// </summary>
        public const string PFKCO = "PFKCO";

        /// <summary>
        /// PFDCT.
        /// </summary>
        public const string PFDCT = "PFDCT";

        /// <summary>
        /// PFDOC.
        /// </summary>
        public const string PFDOC = "PFDOC";

        /// <summary>
        /// PFSFX.
        /// </summary>
        public const string PFSFX = "PFSFX";

        /// <summary>
        /// PFSFXE.
        /// </summary>
        public const string PFSFXE = "PFSFXE";

        /// <summary>
        /// PFCO.
        /// </summary>
        public const string PFCO = "PFCO";

        /// <summary>
        /// PFTX2.
        /// </summary>
        public const string PFTX2 = "PFTX2";

        /// <summary>
        /// PFK70BCNC.
        /// </summary>
        public const string PFK70BCNC = "PFK70BCNC";

        /// <summary>
        /// PFK70BJRD.
        /// </summary>
        public const string PFK70BJRD = "PFK70BJRD";

        /// <summary>
        /// PFAN8.
        /// </summary>
        public const string PFAN8 = "PFAN8";

        /// <summary>
        /// PFTAX.
        /// </summary>
        public const string PFTAX = "PFTAX";

        /// <summary>
        /// PFCTRY.
        /// </summary>
        public const string PFCTRY = "PFCTRY";

        /// <summary>
        /// PFFY.
        /// </summary>
        public const string PFFY = "PFFY";

        /// <summary>
        /// PFPN.
        /// </summary>
        public const string PFPN = "PFPN";

        /// <summary>
        /// PFK70BORB.
        /// </summary>
        public const string PFK70BORB = "PFK70BORB";

        /// <summary>
        /// PFK70BREB.
        /// </summary>
        public const string PFK70BREB = "PFK70BREB";

        /// <summary>
        /// PFK70BSRB.
        /// </summary>
        public const string PFK70BSRB = "PFK70BSRB";

        /// <summary>
        /// PFK70BPRB.
        /// </summary>
        public const string PFK70BPRB = "PFK70BPRB";

        /// <summary>
        /// PFK70BPOB.
        /// </summary>
        public const string PFK70BPOB = "PFK70BPOB";

        /// <summary>
        /// PFK70BAAB.
        /// </summary>
        public const string PFK70BAAB = "PFK70BAAB";

        /// <summary>
        /// PFK70BCAB.
        /// </summary>
        public const string PFK70BCAB = "PFK70BCAB";

        /// <summary>
        /// PFK70BRT1.
        /// </summary>
        public const string PFK70BRT1 = "PFK70BRT1";

        /// <summary>
        /// PFK70BORW.
        /// </summary>
        public const string PFK70BORW = "PFK70BORW";

        /// <summary>
        /// PFK70BAAW.
        /// </summary>
        public const string PFK70BAAW = "PFK70BAAW";

        /// <summary>
        /// PFK70BREW.
        /// </summary>
        public const string PFK70BREW = "PFK70BREW";

        /// <summary>
        /// PFK70BSRW.
        /// </summary>
        public const string PFK70BSRW = "PFK70BSRW";

        /// <summary>
        /// PFK70BPRW.
        /// </summary>
        public const string PFK70BPRW = "PFK70BPRW";

        /// <summary>
        /// PFK70BATW.
        /// </summary>
        public const string PFK70BATW = "PFK70BATW";

        /// <summary>
        /// PFK70BPOW.
        /// </summary>
        public const string PFK70BPOW = "PFK70BPOW";

        /// <summary>
        /// PFK70BCAW.
        /// </summary>
        public const string PFK70BCAW = "PFK70BCAW";

        /// <summary>
        /// PFDMTJ.
        /// </summary>
        public const string PFDMTJ = "PFDMTJ";

        /// <summary>
        /// PFVDGJ.
        /// </summary>
        public const string PFVDGJ = "PFVDGJ";

        /// <summary>
        /// PFVR01.
        /// </summary>
        public const string PFVR01 = "PFVR01";

        /// <summary>
        /// PFFYR.
        /// </summary>
        public const string PFFYR = "PFFYR";

        /// <summary>
        /// PFK70ACEM.
        /// </summary>
        public const string PFK70ACEM = "PFK70ACEM";

        /// <summary>
        /// PFN001.
        /// </summary>
        public const string PFN001 = "PFN001";

        /// <summary>
        /// PFAN80.
        /// </summary>
        public const string PFAN80 = "PFAN80";

        /// <summary>
        /// PFFCO.
        /// </summary>
        public const string PFFCO = "PFFCO";

        /// <summary>
        /// PFK70UEMF.
        /// </summary>
        public const string PFK70UEMF = "PFK70UEMF";

        /// <summary>
        /// PFK70PSPI.
        /// </summary>
        public const string PFK70PSPI = "PFK70PSPI";

        /// <summary>
        /// PFCRRM.
        /// </summary>
        public const string PFCRRM = "PFCRRM";

        /// <summary>
        /// PFBCRC.
        /// </summary>
        public const string PFBCRC = "PFBCRC";

        /// <summary>
        /// PFCRCD.
        /// </summary>
        public const string PFCRCD = "PFCRCD";

        /// <summary>
        /// PFCRR.
        /// </summary>
        public const string PFCRR = "PFCRR";

        /// <summary>
        /// PFCRR1.
        /// </summary>
        public const string PFCRR1 = "PFCRR1";

        /// <summary>
        /// PFCRR2.
        /// </summary>
        public const string PFCRR2 = "PFCRR2";

        /// <summary>
        /// PFCRCM.
        /// </summary>
        public const string PFCRCM = "PFCRCM";

        /// <summary>
        /// PFURC1.
        /// </summary>
        public const string PFURC1 = "PFURC1";

        /// <summary>
        /// PFURDT.
        /// </summary>
        public const string PFURDT = "PFURDT";

        /// <summary>
        /// PFURRF.
        /// </summary>
        public const string PFURRF = "PFURRF";

        /// <summary>
        /// PFURAT.
        /// </summary>
        public const string PFURAT = "PFURAT";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F704002P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFK70BTXC", "PFK70BTXC", JdeDataType.String, 20, true, true),
        new JdeField("PFPYID", "PFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("PFDCTM", "PFDCTM", JdeDataType.String, 4, true, true),
        new JdeField("PFDOCM", "PFDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("PFOKCO", "PFOKCO", JdeDataType.String, 10, true, true),
        new JdeField("PFODCT", "PFODCT", JdeDataType.String, 4, true, true),
        new JdeField("PFODOC", "PFODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PFOSFX", "PFOSFX", JdeDataType.String, 6, true, true),
        new JdeField("PFKCO", "PFKCO", JdeDataType.String, 10, true, true),
        new JdeField("PFDCT", "PFDCT", JdeDataType.String, 4, true, true),
        new JdeField("PFDOC", "PFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PFSFX", "PFSFX", JdeDataType.String, 6, true, true),
        new JdeField("PFSFXE", "PFSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("PFCO", "PFCO", JdeDataType.String, 10),
        new JdeField("PFTX2", "PFTX2", JdeDataType.String, 40),
        new JdeField("PFK70BCNC", "PFK70BCNC", JdeDataType.String, 20),
        new JdeField("PFK70BJRD", "PFK70BJRD", JdeDataType.String, 8),
        new JdeField("PFAN8", "PFAN8", JdeDataType.Numeric),
        new JdeField("PFTAX", "PFTAX", JdeDataType.String, 40),
        new JdeField("PFCTRY", "PFCTRY", JdeDataType.Numeric),
        new JdeField("PFFY", "PFFY", JdeDataType.Numeric),
        new JdeField("PFPN", "PFPN", JdeDataType.Numeric),
        new JdeField("PFK70BORB", "PFK70BORB", JdeDataType.Numeric),
        new JdeField("PFK70BREB", "PFK70BREB", JdeDataType.Numeric),
        new JdeField("PFK70BSRB", "PFK70BSRB", JdeDataType.Numeric),
        new JdeField("PFK70BPRB", "PFK70BPRB", JdeDataType.Numeric),
        new JdeField("PFK70BPOB", "PFK70BPOB", JdeDataType.Numeric),
        new JdeField("PFK70BAAB", "PFK70BAAB", JdeDataType.Numeric),
        new JdeField("PFK70BCAB", "PFK70BCAB", JdeDataType.Numeric),
        new JdeField("PFK70BRT1", "PFK70BRT1", JdeDataType.Numeric),
        new JdeField("PFK70BORW", "PFK70BORW", JdeDataType.Numeric),
        new JdeField("PFK70BAAW", "PFK70BAAW", JdeDataType.Numeric),
        new JdeField("PFK70BREW", "PFK70BREW", JdeDataType.Numeric),
        new JdeField("PFK70BSRW", "PFK70BSRW", JdeDataType.Numeric),
        new JdeField("PFK70BPRW", "PFK70BPRW", JdeDataType.Numeric),
        new JdeField("PFK70BATW", "PFK70BATW", JdeDataType.Numeric),
        new JdeField("PFK70BPOW", "PFK70BPOW", JdeDataType.Numeric),
        new JdeField("PFK70BCAW", "PFK70BCAW", JdeDataType.Numeric),
        new JdeField("PFDMTJ", "PFDMTJ", JdeDataType.Numeric),
        new JdeField("PFVDGJ", "PFVDGJ", JdeDataType.Numeric),
        new JdeField("PFVR01", "PFVR01", JdeDataType.String, 50),
        new JdeField("PFFYR", "PFFYR", JdeDataType.Numeric),
        new JdeField("PFK70ACEM", "PFK70ACEM", JdeDataType.String, 8),
        new JdeField("PFN001", "PFN001", JdeDataType.Numeric),
        new JdeField("PFAN80", "PFAN80", JdeDataType.Numeric),
        new JdeField("PFFCO", "PFFCO", JdeDataType.String, 10),
        new JdeField("PFK70UEMF", "PFK70UEMF", JdeDataType.String, 2),
        new JdeField("PFK70PSPI", "PFK70PSPI", JdeDataType.String, 2),
        new JdeField("PFCRRM", "PFCRRM", JdeDataType.String, 2),
        new JdeField("PFBCRC", "PFBCRC", JdeDataType.String, 6),
        new JdeField("PFCRCD", "PFCRCD", JdeDataType.String, 6),
        new JdeField("PFCRR", "PFCRR", JdeDataType.Numeric),
        new JdeField("PFCRR1", "PFCRR1", JdeDataType.Numeric),
        new JdeField("PFCRR2", "PFCRR2", JdeDataType.Numeric),
        new JdeField("PFCRCM", "PFCRCM", JdeDataType.String, 2),
        new JdeField("PFURC1", "PFURC1", JdeDataType.String, 6),
        new JdeField("PFURDT", "PFURDT", JdeDataType.Numeric),
        new JdeField("PFURRF", "PFURRF", JdeDataType.String, 30),
        new JdeField("PFURAT", "PFURAT", JdeDataType.Numeric),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704002P_0", "Primary Key on PFK70BTXC, PFPYID, PFDCTM, PFDOCM, PFOKCO, PFODCT, PFODOC, PFOSFX, PFKCO, PFDCT, PFDOC, PFSFX, PFSFXE", new[] { "PFK70BTXC", "PFPYID", "PFDCTM", "PFDOCM", "PFOKCO", "PFODCT", "PFODOC", "PFOSFX", "PFKCO", "PFDCT", "PFDOC", "PFSFX", "PFSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F704002P_3", "Index on PFK70BTXC, PFKCO, PFDCT, PFDOC, PFSFX, PFSFXE", new[] { "PFK70BTXC", "PFKCO", "PFDCT", "PFDOC", "PFSFX", "PFSFXE" }),
        new JdeIndex("F704002P_4", "Index on PFK70BTXC, PFOKCO, PFODCT, PFODOC, PFOSFX", new[] { "PFK70BTXC", "PFOKCO", "PFODCT", "PFODOC", "PFOSFX" }),
        new JdeIndex("F704002P_5", "Index on PFK70BTXC, PFPYID", new[] { "PFK70BTXC", "PFPYID" }),
        new JdeIndex("F704002P_6", "Index on PFPYID", new[] { "PFPYID" })
    };
}
