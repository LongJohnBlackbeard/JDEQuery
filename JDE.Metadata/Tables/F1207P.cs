using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1207P - .
/// </summary>
public class F1207P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FWNUMB.
        /// </summary>
        public const string FWNUMB = "FWNUMB";

        /// <summary>
        /// FWAPID.
        /// </summary>
        public const string FWAPID = "FWAPID";

        /// <summary>
        /// FWASID.
        /// </summary>
        public const string FWASID = "FWASID";

        /// <summary>
        /// FWSRVT.
        /// </summary>
        public const string FWSRVT = "FWSRVT";

        /// <summary>
        /// FWMSTS.
        /// </summary>
        public const string FWMSTS = "FWMSTS";

        /// <summary>
        /// FWMPRI.
        /// </summary>
        public const string FWMPRI = "FWMPRI";

        /// <summary>
        /// FWKY.
        /// </summary>
        public const string FWKY = "FWKY";

        /// <summary>
        /// FWANP.
        /// </summary>
        public const string FWANP = "FWANP";

        /// <summary>
        /// FWRMK.
        /// </summary>
        public const string FWRMK = "FWRMK";

        /// <summary>
        /// FWSRVD.
        /// </summary>
        public const string FWSRVD = "FWSRVD";

        /// <summary>
        /// FWSRVM.
        /// </summary>
        public const string FWSRVM = "FWSRVM";

        /// <summary>
        /// FWSRVH.
        /// </summary>
        public const string FWSRVH = "FWSRVH";

        /// <summary>
        /// FWTDT.
        /// </summary>
        public const string FWTDT = "FWTDT";

        /// <summary>
        /// FWCPLM.
        /// </summary>
        public const string FWCPLM = "FWCPLM";

        /// <summary>
        /// FWCPLH.
        /// </summary>
        public const string FWCPLH = "FWCPLH";

        /// <summary>
        /// FWCPLD.
        /// </summary>
        public const string FWCPLD = "FWCPLD";

        /// <summary>
        /// FWLSTM.
        /// </summary>
        public const string FWLSTM = "FWLSTM";

        /// <summary>
        /// FWLSTH.
        /// </summary>
        public const string FWLSTH = "FWLSTH";

        /// <summary>
        /// FWLCPD.
        /// </summary>
        public const string FWLCPD = "FWLCPD";

        /// <summary>
        /// FWUSER.
        /// </summary>
        public const string FWUSER = "FWUSER";

        /// <summary>
        /// FWPID.
        /// </summary>
        public const string FWPID = "FWPID";

        /// <summary>
        /// FWUPMJ.
        /// </summary>
        public const string FWUPMJ = "FWUPMJ";

        /// <summary>
        /// FWJOBN.
        /// </summary>
        public const string FWJOBN = "FWJOBN";

        /// <summary>
        /// FWDOCO.
        /// </summary>
        public const string FWDOCO = "FWDOCO";

        /// <summary>
        /// FWWONA.
        /// </summary>
        public const string FWWONA = "FWWONA";

        /// <summary>
        /// FWMPC.
        /// </summary>
        public const string FWMPC = "FWMPC";

        /// <summary>
        /// FWSRVF.
        /// </summary>
        public const string FWSRVF = "FWSRVF";

        /// <summary>
        /// FWCPLF.
        /// </summary>
        public const string FWCPLF = "FWCPLF";

        /// <summary>
        /// FWLSTF.
        /// </summary>
        public const string FWLSTF = "FWLSTF";

        /// <summary>
        /// FWMLTW.
        /// </summary>
        public const string FWMLTW = "FWMLTW";

        /// <summary>
        /// FWORGM.
        /// </summary>
        public const string FWORGM = "FWORGM";

        /// <summary>
        /// FWORGH.
        /// </summary>
        public const string FWORGH = "FWORGH";

        /// <summary>
        /// FWORGF.
        /// </summary>
        public const string FWORGF = "FWORGF";

        /// <summary>
        /// FWOCCU.
        /// </summary>
        public const string FWOCCU = "FWOCCU";

        /// <summary>
        /// FWFRIN.
        /// </summary>
        public const string FWFRIN = "FWFRIN";

        /// <summary>
        /// FWUPMT.
        /// </summary>
        public const string FWUPMT = "FWUPMT";

        /// <summary>
        /// FWMCU.
        /// </summary>
        public const string FWMCU = "FWMCU";

        /// <summary>
        /// FWAAID.
        /// </summary>
        public const string FWAAID = "FWAAID";

        /// <summary>
        /// FWCRTL.
        /// </summary>
        public const string FWCRTL = "FWCRTL";

        /// <summary>
        /// FWPNST.
        /// </summary>
        public const string FWPNST = "FWPNST";

        /// <summary>
        /// FWPMC1.
        /// </summary>
        public const string FWPMC1 = "FWPMC1";

        /// <summary>
        /// FWPMC2.
        /// </summary>
        public const string FWPMC2 = "FWPMC2";

        /// <summary>
        /// FWDNHR.
        /// </summary>
        public const string FWDNHR = "FWDNHR";

        /// <summary>
        /// FWPDFL.
        /// </summary>
        public const string FWPDFL = "FWPDFL";

        /// <summary>
        /// FWUKID.
        /// </summary>
        public const string FWUKID = "FWUKID";

        /// <summary>
        /// FWTOLU.
        /// </summary>
        public const string FWTOLU = "FWTOLU";

        /// <summary>
        /// FWTOLL.
        /// </summary>
        public const string FWTOLL = "FWTOLL";

        /// <summary>
        /// FWHLDD.
        /// </summary>
        public const string FWHLDD = "FWHLDD";

        /// <summary>
        /// FWSPHR.
        /// </summary>
        public const string FWSPHR = "FWSPHR";

        /// <summary>
        /// FWSPWK.
        /// </summary>
        public const string FWSPWK = "FWSPWK";

        /// <summary>
        /// FWSPMN.
        /// </summary>
        public const string FWSPMN = "FWSPMN";

        /// <summary>
        /// FWWK.
        /// </summary>
        public const string FWWK = "FWWK";

        /// <summary>
        /// FWSPDW.
        /// </summary>
        public const string FWSPDW = "FWSPDW";

        /// <summary>
        /// FWPDFG.
        /// </summary>
        public const string FWPDFG = "FWPDFG";

        /// <summary>
        /// FWSRVM4.
        /// </summary>
        public const string FWSRVM4 = "FWSRVM4";

        /// <summary>
        /// FWLSTM4.
        /// </summary>
        public const string FWLSTM4 = "FWLSTM4";

        /// <summary>
        /// FWCPLM4.
        /// </summary>
        public const string FWCPLM4 = "FWCPLM4";

        /// <summary>
        /// FWORGM4.
        /// </summary>
        public const string FWORGM4 = "FWORGM4";

        /// <summary>
        /// FWSRVM5.
        /// </summary>
        public const string FWSRVM5 = "FWSRVM5";

        /// <summary>
        /// FWLSTM5.
        /// </summary>
        public const string FWLSTM5 = "FWLSTM5";

        /// <summary>
        /// FWCPLM5.
        /// </summary>
        public const string FWCPLM5 = "FWCPLM5";

        /// <summary>
        /// FWORGM5.
        /// </summary>
        public const string FWORGM5 = "FWORGM5";

        /// <summary>
        /// FWSRVM6.
        /// </summary>
        public const string FWSRVM6 = "FWSRVM6";

        /// <summary>
        /// FWLSTM6.
        /// </summary>
        public const string FWLSTM6 = "FWLSTM6";

        /// <summary>
        /// FWCPLM6.
        /// </summary>
        public const string FWCPLM6 = "FWCPLM6";

        /// <summary>
        /// FWORGM6.
        /// </summary>
        public const string FWORGM6 = "FWORGM6";
    }

    /// <inheritdoc />
    public override string TableName => "F1207P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FWNUMB", "FWNUMB", JdeDataType.Numeric),
        new JdeField("FWAPID", "FWAPID", JdeDataType.String, 24),
        new JdeField("FWASID", "FWASID", JdeDataType.String, 50),
        new JdeField("FWSRVT", "FWSRVT", JdeDataType.String, 16),
        new JdeField("FWMSTS", "FWMSTS", JdeDataType.String, 4),
        new JdeField("FWMPRI", "FWMPRI", JdeDataType.String, 2),
        new JdeField("FWKY", "FWKY", JdeDataType.String, 20),
        new JdeField("FWANP", "FWANP", JdeDataType.Numeric),
        new JdeField("FWRMK", "FWRMK", JdeDataType.String, 60),
        new JdeField("FWSRVD", "FWSRVD", JdeDataType.Numeric),
        new JdeField("FWSRVM", "FWSRVM", JdeDataType.Numeric),
        new JdeField("FWSRVH", "FWSRVH", JdeDataType.Numeric),
        new JdeField("FWTDT", "FWTDT", JdeDataType.Numeric),
        new JdeField("FWCPLM", "FWCPLM", JdeDataType.Numeric),
        new JdeField("FWCPLH", "FWCPLH", JdeDataType.Numeric),
        new JdeField("FWCPLD", "FWCPLD", JdeDataType.Numeric),
        new JdeField("FWLSTM", "FWLSTM", JdeDataType.Numeric),
        new JdeField("FWLSTH", "FWLSTH", JdeDataType.Numeric),
        new JdeField("FWLCPD", "FWLCPD", JdeDataType.Numeric),
        new JdeField("FWUSER", "FWUSER", JdeDataType.String, 20),
        new JdeField("FWPID", "FWPID", JdeDataType.String, 20),
        new JdeField("FWUPMJ", "FWUPMJ", JdeDataType.Numeric),
        new JdeField("FWJOBN", "FWJOBN", JdeDataType.String, 20),
        new JdeField("FWDOCO", "FWDOCO", JdeDataType.Numeric),
        new JdeField("FWWONA", "FWWONA", JdeDataType.Numeric),
        new JdeField("FWMPC", "FWMPC", JdeDataType.Numeric),
        new JdeField("FWSRVF", "FWSRVF", JdeDataType.Numeric),
        new JdeField("FWCPLF", "FWCPLF", JdeDataType.Numeric),
        new JdeField("FWLSTF", "FWLSTF", JdeDataType.Numeric),
        new JdeField("FWMLTW", "FWMLTW", JdeDataType.String, 2),
        new JdeField("FWORGM", "FWORGM", JdeDataType.Numeric),
        new JdeField("FWORGH", "FWORGH", JdeDataType.Numeric),
        new JdeField("FWORGF", "FWORGF", JdeDataType.Numeric),
        new JdeField("FWOCCU", "FWOCCU", JdeDataType.Numeric),
        new JdeField("FWFRIN", "FWFRIN", JdeDataType.String, 2),
        new JdeField("FWUPMT", "FWUPMT", JdeDataType.Numeric),
        new JdeField("FWMCU", "FWMCU", JdeDataType.String, 24),
        new JdeField("FWAAID", "FWAAID", JdeDataType.Numeric),
        new JdeField("FWCRTL", "FWCRTL", JdeDataType.Numeric),
        new JdeField("FWPNST", "FWPNST", JdeDataType.Numeric),
        new JdeField("FWPMC1", "FWPMC1", JdeDataType.String, 6),
        new JdeField("FWPMC2", "FWPMC2", JdeDataType.String, 6),
        new JdeField("FWDNHR", "FWDNHR", JdeDataType.Numeric),
        new JdeField("FWPDFL", "FWPDFL", JdeDataType.String, 2),
        new JdeField("FWUKID", "FWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FWTOLU", "FWTOLU", JdeDataType.Numeric),
        new JdeField("FWTOLL", "FWTOLL", JdeDataType.Numeric),
        new JdeField("FWHLDD", "FWHLDD", JdeDataType.Numeric),
        new JdeField("FWSPHR", "FWSPHR", JdeDataType.Numeric),
        new JdeField("FWSPWK", "FWSPWK", JdeDataType.Numeric),
        new JdeField("FWSPMN", "FWSPMN", JdeDataType.Numeric),
        new JdeField("FWWK", "FWWK", JdeDataType.Numeric),
        new JdeField("FWSPDW", "FWSPDW", JdeDataType.String, 2),
        new JdeField("FWPDFG", "FWPDFG", JdeDataType.String, 2),
        new JdeField("FWSRVM4", "FWSRVM4", JdeDataType.Numeric),
        new JdeField("FWLSTM4", "FWLSTM4", JdeDataType.Numeric),
        new JdeField("FWCPLM4", "FWCPLM4", JdeDataType.Numeric),
        new JdeField("FWORGM4", "FWORGM4", JdeDataType.Numeric),
        new JdeField("FWSRVM5", "FWSRVM5", JdeDataType.Numeric),
        new JdeField("FWLSTM5", "FWLSTM5", JdeDataType.Numeric),
        new JdeField("FWCPLM5", "FWCPLM5", JdeDataType.Numeric),
        new JdeField("FWORGM5", "FWORGM5", JdeDataType.Numeric),
        new JdeField("FWSRVM6", "FWSRVM6", JdeDataType.Numeric),
        new JdeField("FWLSTM6", "FWLSTM6", JdeDataType.Numeric),
        new JdeField("FWCPLM6", "FWCPLM6", JdeDataType.Numeric),
        new JdeField("FWORGM6", "FWORGM6", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1207P_0", "Primary Key on FWUKID", new[] { "FWUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
