using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI83 - .
/// </summary>
public class F76AUI83 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFRREF.
        /// </summary>
        public const string WFRREF = "WFRREF";

        /// <summary>
        /// WFPYID.
        /// </summary>
        public const string WFPYID = "WFPYID";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFRC5.
        /// </summary>
        public const string WFRC5 = "WFRC5";

        /// <summary>
        /// WFAAP.
        /// </summary>
        public const string WFAAP = "WFAAP";

        /// <summary>
        /// WFACR.
        /// </summary>
        public const string WFACR = "WFACR";

        /// <summary>
        /// WFACTN.
        /// </summary>
        public const string WFACTN = "WFACTN";

        /// <summary>
        /// WFADSC.
        /// </summary>
        public const string WFADSC = "WFADSC";

        /// <summary>
        /// WFADSA.
        /// </summary>
        public const string WFADSA = "WFADSA";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFAGL.
        /// </summary>
        public const string WFAGL = "WFAGL";

        /// <summary>
        /// WFAIDD.
        /// </summary>
        public const string WFAIDD = "WFAIDD";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFBCRC.
        /// </summary>
        public const string WFBCRC = "WFBCRC";

        /// <summary>
        /// WFCDS.
        /// </summary>
        public const string WFCDS = "WFCDS";

        /// <summary>
        /// WFCDSA.
        /// </summary>
        public const string WFCDSA = "WFCDSA";

        /// <summary>
        /// WFCKNU.
        /// </summary>
        public const string WFCKNU = "WFCKNU";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFCRRM.
        /// </summary>
        public const string WFCRRM = "WFCRRM";

        /// <summary>
        /// WFCRR.
        /// </summary>
        public const string WFCRR = "WFCRR";

        /// <summary>
        /// WFDDST.
        /// </summary>
        public const string WFDDST = "WFDDST";

        /// <summary>
        /// WFVLDT.
        /// </summary>
        public const string WFVLDT = "WFVLDT";

        /// <summary>
        /// WFDMTJ.
        /// </summary>
        public const string WFDMTJ = "WFDMTJ";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

        /// <summary>
        /// WFFCAM.
        /// </summary>
        public const string WFFCAM = "WFFCAM";

        /// <summary>
        /// WFCKAM.
        /// </summary>
        public const string WFCKAM = "WFCKAM";

        /// <summary>
        /// WFDICJ.
        /// </summary>
        public const string WFDICJ = "WFDICJ";

        /// <summary>
        /// WFKCOG.
        /// </summary>
        public const string WFKCOG = "WFKCOG";

        /// <summary>
        /// WFDCTG.
        /// </summary>
        public const string WFDCTG = "WFDCTG";

        /// <summary>
        /// WFDOCG.
        /// </summary>
        public const string WFDOCG = "WFDOCG";

        /// <summary>
        /// WFFAP.
        /// </summary>
        public const string WFFAP = "WFFAP";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFICUT.
        /// </summary>
        public const string WFICUT = "WFICUT";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFNFVD.
        /// </summary>
        public const string WFNFVD = "WFNFVD";

        /// <summary>
        /// WFPAAP.
        /// </summary>
        public const string WFPAAP = "WFPAAP";

        /// <summary>
        /// WFPFAP.
        /// </summary>
        public const string WFPFAP = "WFPFAP";

        /// <summary>
        /// WFPOST.
        /// </summary>
        public const string WFPOST = "WFPOST";

        /// <summary>
        /// WFRMK.
        /// </summary>
        public const string WFRMK = "WFRMK";

        /// <summary>
        /// WFUTIC.
        /// </summary>
        public const string WFUTIC = "WFUTIC";

        /// <summary>
        /// WFVDGJ.
        /// </summary>
        public const string WFVDGJ = "WFVDGJ";

        /// <summary>
        /// WFVRE.
        /// </summary>
        public const string WFVRE = "WFVRE";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFACVA.
        /// </summary>
        public const string WFACVA = "WFACVA";

        /// <summary>
        /// WFUNAP.
        /// </summary>
        public const string WFUNAP = "WFUNAP";

        /// <summary>
        /// WFFUNA.
        /// </summary>
        public const string WFFUNA = "WFFUNA";

        /// <summary>
        /// WFADEA.
        /// </summary>
        public const string WFADEA = "WFADEA";

        /// <summary>
        /// WFACLE.
        /// </summary>
        public const string WFACLE = "WFACLE";

        /// <summary>
        /// WFRYIN.
        /// </summary>
        public const string WFRYIN = "WFRYIN";

        /// <summary>
        /// WFPYR.
        /// </summary>
        public const string WFPYR = "WFPYR";

        /// <summary>
        /// WFDLT.
        /// </summary>
        public const string WFDLT = "WFDLT";

        /// <summary>
        /// WFAAAJ.
        /// </summary>
        public const string WFAAAJ = "WFAAAJ";

        /// <summary>
        /// WFFCHG.
        /// </summary>
        public const string WFFCHG = "WFFCHG";

        /// <summary>
        /// WFRSCO.
        /// </summary>
        public const string WFRSCO = "WFRSCO";

        /// <summary>
        /// WFECBA.
        /// </summary>
        public const string WFECBA = "WFECBA";

        /// <summary>
        /// WFECBF.
        /// </summary>
        public const string WFECBF = "WFECBF";

        /// <summary>
        /// WFECBR.
        /// </summary>
        public const string WFECBR = "WFECBR";

        /// <summary>
        /// WFGLCC.
        /// </summary>
        public const string WFGLCC = "WFGLCC";

        /// <summary>
        /// WFAIDW.
        /// </summary>
        public const string WFAIDW = "WFAIDW";

        /// <summary>
        /// WFAIDC.
        /// </summary>
        public const string WFAIDC = "WFAIDC";

        /// <summary>
        /// WFCRR1.
        /// </summary>
        public const string WFCRR1 = "WFCRR1";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI83";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10),
        new JdeField("WFRREF", "WFRREF", JdeDataType.String, 50),
        new JdeField("WFPYID", "WFPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6, true, true),
        new JdeField("WFRC5", "WFRC5", JdeDataType.Numeric),
        new JdeField("WFAAP", "WFAAP", JdeDataType.Numeric),
        new JdeField("WFACR", "WFACR", JdeDataType.Numeric),
        new JdeField("WFACTN", "WFACTN", JdeDataType.String, 2),
        new JdeField("WFADSC", "WFADSC", JdeDataType.Numeric),
        new JdeField("WFADSA", "WFADSA", JdeDataType.Numeric),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFAGL", "WFAGL", JdeDataType.Numeric),
        new JdeField("WFAIDD", "WFAIDD", JdeDataType.String, 16),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFBCRC", "WFBCRC", JdeDataType.String, 6),
        new JdeField("WFCDS", "WFCDS", JdeDataType.Numeric),
        new JdeField("WFCDSA", "WFCDSA", JdeDataType.Numeric),
        new JdeField("WFCKNU", "WFCKNU", JdeDataType.String, 50),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFCRRM", "WFCRRM", JdeDataType.String, 2),
        new JdeField("WFCRR", "WFCRR", JdeDataType.Numeric),
        new JdeField("WFDDST", "WFDDST", JdeDataType.String, 2),
        new JdeField("WFVLDT", "WFVLDT", JdeDataType.Numeric),
        new JdeField("WFDMTJ", "WFDMTJ", JdeDataType.Numeric),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFFCAM", "WFFCAM", JdeDataType.Numeric),
        new JdeField("WFCKAM", "WFCKAM", JdeDataType.Numeric),
        new JdeField("WFDICJ", "WFDICJ", JdeDataType.Numeric),
        new JdeField("WFKCOG", "WFKCOG", JdeDataType.String, 10),
        new JdeField("WFDCTG", "WFDCTG", JdeDataType.String, 4),
        new JdeField("WFDOCG", "WFDOCG", JdeDataType.Numeric),
        new JdeField("WFFAP", "WFFAP", JdeDataType.Numeric),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric),
        new JdeField("WFICUT", "WFICUT", JdeDataType.String, 4),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFNFVD", "WFNFVD", JdeDataType.String, 2),
        new JdeField("WFPAAP", "WFPAAP", JdeDataType.Numeric),
        new JdeField("WFPFAP", "WFPFAP", JdeDataType.Numeric),
        new JdeField("WFPOST", "WFPOST", JdeDataType.String, 2),
        new JdeField("WFRMK", "WFRMK", JdeDataType.String, 60),
        new JdeField("WFUTIC", "WFUTIC", JdeDataType.String, 4),
        new JdeField("WFVDGJ", "WFVDGJ", JdeDataType.Numeric),
        new JdeField("WFVRE", "WFVRE", JdeDataType.String, 6),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFACVA", "WFACVA", JdeDataType.String, 20),
        new JdeField("WFUNAP", "WFUNAP", JdeDataType.Numeric),
        new JdeField("WFFUNA", "WFFUNA", JdeDataType.Numeric),
        new JdeField("WFADEA", "WFADEA", JdeDataType.String, 20),
        new JdeField("WFACLE", "WFACLE", JdeDataType.String, 4),
        new JdeField("WFRYIN", "WFRYIN", JdeDataType.String, 2),
        new JdeField("WFPYR", "WFPYR", JdeDataType.Numeric),
        new JdeField("WFDLT", "WFDLT", JdeDataType.String, 2),
        new JdeField("WFAAAJ", "WFAAAJ", JdeDataType.Numeric),
        new JdeField("WFFCHG", "WFFCHG", JdeDataType.Numeric),
        new JdeField("WFRSCO", "WFRSCO", JdeDataType.String, 4),
        new JdeField("WFECBA", "WFECBA", JdeDataType.Numeric),
        new JdeField("WFECBF", "WFECBF", JdeDataType.Numeric),
        new JdeField("WFECBR", "WFECBR", JdeDataType.String, 4),
        new JdeField("WFGLCC", "WFGLCC", JdeDataType.String, 8),
        new JdeField("WFAIDW", "WFAIDW", JdeDataType.String, 16),
        new JdeField("WFAIDC", "WFAIDC", JdeDataType.String, 16),
        new JdeField("WFCRR1", "WFCRR1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI83_0", "Primary Key on WFPYID, WFKCO, WFDCT, WFDOC, WFSFX, WFJOBS, WFCTID", new[] { "WFPYID", "WFKCO", "WFDCT", "WFDOC", "WFSFX", "WFJOBS", "WFCTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76AUI83_2", "Index on WFJOBS, WFCTID, WFCO, WFRREF", new[] { "WFJOBS", "WFCTID", "WFCO", "WFRREF" }),
        new JdeIndex("F76AUI83_3", "Index on WFPYID, WFRC5", new[] { "WFPYID", "WFRC5" }),
        new JdeIndex("F76AUI83_4", "Index on WFCO, WFRREF", new[] { "WFCO", "WFRREF" })
    };
}
