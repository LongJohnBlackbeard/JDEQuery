using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI81 - .
/// </summary>
public class F76AUI81 : JdeTable
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
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

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
        /// WFADSA.
        /// </summary>
        public const string WFADSA = "WFADSA";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFAID.
        /// </summary>
        public const string WFAID = "WFAID";

        /// <summary>
        /// WFAIDD.
        /// </summary>
        public const string WFAIDD = "WFAIDD";

        /// <summary>
        /// WFCDSA.
        /// </summary>
        public const string WFCDSA = "WFCDSA";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFCRR.
        /// </summary>
        public const string WFCRR = "WFCRR";

        /// <summary>
        /// WFDDJ.
        /// </summary>
        public const string WFDDJ = "WFDDJ";

        /// <summary>
        /// WFDDNJ.
        /// </summary>
        public const string WFDDNJ = "WFDDNJ";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFFAP.
        /// </summary>
        public const string WFFAP = "WFFAP";

        /// <summary>
        /// WFGLC.
        /// </summary>
        public const string WFGLC = "WFGLC";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFICUT.
        /// </summary>
        public const string WFICUT = "WFICUT";

        /// <summary>
        /// WFADSC.
        /// </summary>
        public const string WFADSC = "WFADSC";

        /// <summary>
        /// WFAOPN.
        /// </summary>
        public const string WFAOPN = "WFAOPN";

        /// <summary>
        /// WFMATH01.
        /// </summary>
        public const string WFMATH01 = "WFMATH01";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFPAAP.
        /// </summary>
        public const string WFPAAP = "WFPAAP";

        /// <summary>
        /// WFPFAP.
        /// </summary>
        public const string WFPFAP = "WFPFAP";

        /// <summary>
        /// WFPYR.
        /// </summary>
        public const string WFPYR = "WFPYR";

        /// <summary>
        /// WFRC5.
        /// </summary>
        public const string WFRC5 = "WFRC5";

        /// <summary>
        /// WFRMK.
        /// </summary>
        public const string WFRMK = "WFRMK";

        /// <summary>
        /// WFSDCT.
        /// </summary>
        public const string WFSDCT = "WFSDCT";

        /// <summary>
        /// WFSDOC.
        /// </summary>
        public const string WFSDOC = "WFSDOC";

        /// <summary>
        /// WFSKCO.
        /// </summary>
        public const string WFSKCO = "WFSKCO";

        /// <summary>
        /// WFSFXO.
        /// </summary>
        public const string WFSFXO = "WFSFXO";

        /// <summary>
        /// WFUTIC.
        /// </summary>
        public const string WFUTIC = "WFUTIC";

        /// <summary>
        /// WFVR01.
        /// </summary>
        public const string WFVR01 = "WFVR01";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFVRE.
        /// </summary>
        public const string WFVRE = "WFVRE";

        /// <summary>
        /// WFFAD.
        /// </summary>
        public const string WFFAD = "WFFAD";

        /// <summary>
        /// WFVDGJ.
        /// </summary>
        public const string WFVDGJ = "WFVDGJ";

        /// <summary>
        /// WFPAD.
        /// </summary>
        public const string WFPAD = "WFPAD";

        /// <summary>
        /// WFNFVD.
        /// </summary>
        public const string WFNFVD = "WFNFVD";

        /// <summary>
        /// WFCDS.
        /// </summary>
        public const string WFCDS = "WFCDS";

        /// <summary>
        /// WFAGL.
        /// </summary>
        public const string WFAGL = "WFAGL";

        /// <summary>
        /// WFPOST.
        /// </summary>
        public const string WFPOST = "WFPOST";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI81";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10, true, true),
        new JdeField("WFRREF", "WFRREF", JdeDataType.String, 50, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6, true, true),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFAAP", "WFAAP", JdeDataType.Numeric),
        new JdeField("WFACR", "WFACR", JdeDataType.Numeric),
        new JdeField("WFACTN", "WFACTN", JdeDataType.String, 2),
        new JdeField("WFADSA", "WFADSA", JdeDataType.Numeric),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFAID", "WFAID", JdeDataType.String, 16),
        new JdeField("WFAIDD", "WFAIDD", JdeDataType.String, 16),
        new JdeField("WFCDSA", "WFCDSA", JdeDataType.Numeric),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFCRR", "WFCRR", JdeDataType.Numeric),
        new JdeField("WFDDJ", "WFDDJ", JdeDataType.Numeric),
        new JdeField("WFDDNJ", "WFDDNJ", JdeDataType.Numeric),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2),
        new JdeField("WFFAP", "WFFAP", JdeDataType.Numeric),
        new JdeField("WFGLC", "WFGLC", JdeDataType.String, 8),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric),
        new JdeField("WFICUT", "WFICUT", JdeDataType.String, 4),
        new JdeField("WFADSC", "WFADSC", JdeDataType.Numeric),
        new JdeField("WFAOPN", "WFAOPN", JdeDataType.Numeric),
        new JdeField("WFMATH01", "WFMATH01", JdeDataType.Numeric),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFPAAP", "WFPAAP", JdeDataType.Numeric),
        new JdeField("WFPFAP", "WFPFAP", JdeDataType.Numeric),
        new JdeField("WFPYR", "WFPYR", JdeDataType.Numeric),
        new JdeField("WFRC5", "WFRC5", JdeDataType.Numeric),
        new JdeField("WFRMK", "WFRMK", JdeDataType.String, 60),
        new JdeField("WFSDCT", "WFSDCT", JdeDataType.String, 4),
        new JdeField("WFSDOC", "WFSDOC", JdeDataType.Numeric),
        new JdeField("WFSKCO", "WFSKCO", JdeDataType.String, 10),
        new JdeField("WFSFXO", "WFSFXO", JdeDataType.String, 6),
        new JdeField("WFUTIC", "WFUTIC", JdeDataType.String, 4),
        new JdeField("WFVR01", "WFVR01", JdeDataType.String, 50),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFVRE", "WFVRE", JdeDataType.String, 6),
        new JdeField("WFFAD", "WFFAD", JdeDataType.Numeric),
        new JdeField("WFVDGJ", "WFVDGJ", JdeDataType.Numeric),
        new JdeField("WFPAD", "WFPAD", JdeDataType.Numeric),
        new JdeField("WFNFVD", "WFNFVD", JdeDataType.String, 2),
        new JdeField("WFCDS", "WFCDS", JdeDataType.Numeric),
        new JdeField("WFAGL", "WFAGL", JdeDataType.Numeric),
        new JdeField("WFPOST", "WFPOST", JdeDataType.String, 2),
        new JdeField("WFAAAJ", "WFAAAJ", JdeDataType.Numeric),
        new JdeField("WFFCHG", "WFFCHG", JdeDataType.Numeric),
        new JdeField("WFRSCO", "WFRSCO", JdeDataType.String, 4),
        new JdeField("WFECBA", "WFECBA", JdeDataType.Numeric),
        new JdeField("WFECBF", "WFECBF", JdeDataType.Numeric),
        new JdeField("WFECBR", "WFECBR", JdeDataType.String, 4),
        new JdeField("WFGLCC", "WFGLCC", JdeDataType.String, 8),
        new JdeField("WFAIDW", "WFAIDW", JdeDataType.String, 16),
        new JdeField("WFAIDC", "WFAIDC", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI81_0", "Primary Key on WFCO, WFRREF, WFKCO, WFDCT, WFDOC, WFSFX, WFJOBS, WFCTID", new[] { "WFCO", "WFRREF", "WFKCO", "WFDCT", "WFDOC", "WFSFX", "WFJOBS", "WFCTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76AUI81_2", "Index on WFJOBS, WFCTID, WFCO, WFRREF", new[] { "WFJOBS", "WFCTID", "WFCO", "WFRREF" })
    };
}
