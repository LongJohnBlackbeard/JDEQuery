using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12071 - .
/// </summary>
public class F12071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FZSRVT.
        /// </summary>
        public const string FZSRVT = "FZSRVT";

        /// <summary>
        /// FZTDT.
        /// </summary>
        public const string FZTDT = "FZTDT";

        /// <summary>
        /// FZUPMJ.
        /// </summary>
        public const string FZUPMJ = "FZUPMJ";

        /// <summary>
        /// FZUPMT.
        /// </summary>
        public const string FZUPMT = "FZUPMT";

        /// <summary>
        /// FZUSER.
        /// </summary>
        public const string FZUSER = "FZUSER";

        /// <summary>
        /// FZWONA.
        /// </summary>
        public const string FZWONA = "FZWONA";

        /// <summary>
        /// FZACL0.
        /// </summary>
        public const string FZACL0 = "FZACL0";

        /// <summary>
        /// FZACL1.
        /// </summary>
        public const string FZACL1 = "FZACL1";

        /// <summary>
        /// FZACL2.
        /// </summary>
        public const string FZACL2 = "FZACL2";

        /// <summary>
        /// FZACL3.
        /// </summary>
        public const string FZACL3 = "FZACL3";

        /// <summary>
        /// FZACL4.
        /// </summary>
        public const string FZACL4 = "FZACL4";

        /// <summary>
        /// FZACL5.
        /// </summary>
        public const string FZACL5 = "FZACL5";

        /// <summary>
        /// FZACL6.
        /// </summary>
        public const string FZACL6 = "FZACL6";

        /// <summary>
        /// FZACL7.
        /// </summary>
        public const string FZACL7 = "FZACL7";

        /// <summary>
        /// FZACL8.
        /// </summary>
        public const string FZACL8 = "FZACL8";

        /// <summary>
        /// FZACL9.
        /// </summary>
        public const string FZACL9 = "FZACL9";

        /// <summary>
        /// FZCPLF.
        /// </summary>
        public const string FZCPLF = "FZCPLF";

        /// <summary>
        /// FZCPLH.
        /// </summary>
        public const string FZCPLH = "FZCPLH";

        /// <summary>
        /// FZCPLM.
        /// </summary>
        public const string FZCPLM = "FZCPLM";

        /// <summary>
        /// FZDOCO.
        /// </summary>
        public const string FZDOCO = "FZDOCO";

        /// <summary>
        /// FZKY.
        /// </summary>
        public const string FZKY = "FZKY";

        /// <summary>
        /// FZJOBN.
        /// </summary>
        public const string FZJOBN = "FZJOBN";

        /// <summary>
        /// FZLCPD.
        /// </summary>
        public const string FZLCPD = "FZLCPD";

        /// <summary>
        /// FZLSTF.
        /// </summary>
        public const string FZLSTF = "FZLSTF";

        /// <summary>
        /// FZLSTH.
        /// </summary>
        public const string FZLSTH = "FZLSTH";

        /// <summary>
        /// FZLSTM.
        /// </summary>
        public const string FZLSTM = "FZLSTM";

        /// <summary>
        /// FZMPC.
        /// </summary>
        public const string FZMPC = "FZMPC";

        /// <summary>
        /// FZMPRI.
        /// </summary>
        public const string FZMPRI = "FZMPRI";

        /// <summary>
        /// FZNUMB.
        /// </summary>
        public const string FZNUMB = "FZNUMB";

        /// <summary>
        /// FZMSTS.
        /// </summary>
        public const string FZMSTS = "FZMSTS";

        /// <summary>
        /// FZPID.
        /// </summary>
        public const string FZPID = "FZPID";

        /// <summary>
        /// FZRMK.
        /// </summary>
        public const string FZRMK = "FZRMK";

        /// <summary>
        /// FZSRVD.
        /// </summary>
        public const string FZSRVD = "FZSRVD";

        /// <summary>
        /// FZSRVF.
        /// </summary>
        public const string FZSRVF = "FZSRVF";

        /// <summary>
        /// FZSRVH.
        /// </summary>
        public const string FZSRVH = "FZSRVH";

        /// <summary>
        /// FZSRVM.
        /// </summary>
        public const string FZSRVM = "FZSRVM";

        /// <summary>
        /// FZWK.
        /// </summary>
        public const string FZWK = "FZWK";

        /// <summary>
        /// FZUKID.
        /// </summary>
        public const string FZUKID = "FZUKID";

        /// <summary>
        /// FZTOLU.
        /// </summary>
        public const string FZTOLU = "FZTOLU";

        /// <summary>
        /// FZTOLL.
        /// </summary>
        public const string FZTOLL = "FZTOLL";

        /// <summary>
        /// FZSPWK.
        /// </summary>
        public const string FZSPWK = "FZSPWK";

        /// <summary>
        /// FZSPMN.
        /// </summary>
        public const string FZSPMN = "FZSPMN";

        /// <summary>
        /// FZSPHR.
        /// </summary>
        public const string FZSPHR = "FZSPHR";

        /// <summary>
        /// FZSPDW.
        /// </summary>
        public const string FZSPDW = "FZSPDW";

        /// <summary>
        /// FZPNST.
        /// </summary>
        public const string FZPNST = "FZPNST";

        /// <summary>
        /// FZPMC2.
        /// </summary>
        public const string FZPMC2 = "FZPMC2";

        /// <summary>
        /// FZPMC1.
        /// </summary>
        public const string FZPMC1 = "FZPMC1";

        /// <summary>
        /// FZPDFL.
        /// </summary>
        public const string FZPDFL = "FZPDFL";

        /// <summary>
        /// FZORGM.
        /// </summary>
        public const string FZORGM = "FZORGM";

        /// <summary>
        /// FZORGH.
        /// </summary>
        public const string FZORGH = "FZORGH";

        /// <summary>
        /// FZORGF.
        /// </summary>
        public const string FZORGF = "FZORGF";

        /// <summary>
        /// FZOCCU.
        /// </summary>
        public const string FZOCCU = "FZOCCU";

        /// <summary>
        /// FZMLTW.
        /// </summary>
        public const string FZMLTW = "FZMLTW";

        /// <summary>
        /// FZHLDD.
        /// </summary>
        public const string FZHLDD = "FZHLDD";

        /// <summary>
        /// FZMCU.
        /// </summary>
        public const string FZMCU = "FZMCU";

        /// <summary>
        /// FZDNHR.
        /// </summary>
        public const string FZDNHR = "FZDNHR";

        /// <summary>
        /// FZCRTL.
        /// </summary>
        public const string FZCRTL = "FZCRTL";

        /// <summary>
        /// FZFRIN.
        /// </summary>
        public const string FZFRIN = "FZFRIN";

        /// <summary>
        /// FZCPLD.
        /// </summary>
        public const string FZCPLD = "FZCPLD";

        /// <summary>
        /// FZASID.
        /// </summary>
        public const string FZASID = "FZASID";

        /// <summary>
        /// FZAPID.
        /// </summary>
        public const string FZAPID = "FZAPID";

        /// <summary>
        /// FZAAID.
        /// </summary>
        public const string FZAAID = "FZAAID";

        /// <summary>
        /// FZANP.
        /// </summary>
        public const string FZANP = "FZANP";

        /// <summary>
        /// FZPDFG.
        /// </summary>
        public const string FZPDFG = "FZPDFG";

        /// <summary>
        /// FZSRVM4.
        /// </summary>
        public const string FZSRVM4 = "FZSRVM4";

        /// <summary>
        /// FZLSTM4.
        /// </summary>
        public const string FZLSTM4 = "FZLSTM4";

        /// <summary>
        /// FZCPLM4.
        /// </summary>
        public const string FZCPLM4 = "FZCPLM4";

        /// <summary>
        /// FZORGM4.
        /// </summary>
        public const string FZORGM4 = "FZORGM4";

        /// <summary>
        /// FZSRVM5.
        /// </summary>
        public const string FZSRVM5 = "FZSRVM5";

        /// <summary>
        /// FZLSTM5.
        /// </summary>
        public const string FZLSTM5 = "FZLSTM5";

        /// <summary>
        /// FZCPLM5.
        /// </summary>
        public const string FZCPLM5 = "FZCPLM5";

        /// <summary>
        /// FZORGM5.
        /// </summary>
        public const string FZORGM5 = "FZORGM5";

        /// <summary>
        /// FZSRVM6.
        /// </summary>
        public const string FZSRVM6 = "FZSRVM6";

        /// <summary>
        /// FZLSTM6.
        /// </summary>
        public const string FZLSTM6 = "FZLSTM6";

        /// <summary>
        /// FZCPLM6.
        /// </summary>
        public const string FZCPLM6 = "FZCPLM6";

        /// <summary>
        /// FZORGM6.
        /// </summary>
        public const string FZORGM6 = "FZORGM6";
    }

    /// <inheritdoc />
    public override string TableName => "F12071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FZSRVT", "FZSRVT", JdeDataType.String, 16, true, true),
        new JdeField("FZTDT", "FZTDT", JdeDataType.Numeric),
        new JdeField("FZUPMJ", "FZUPMJ", JdeDataType.Numeric),
        new JdeField("FZUPMT", "FZUPMT", JdeDataType.Numeric),
        new JdeField("FZUSER", "FZUSER", JdeDataType.String, 20),
        new JdeField("FZWONA", "FZWONA", JdeDataType.Numeric),
        new JdeField("FZACL0", "FZACL0", JdeDataType.String, 6, true, true),
        new JdeField("FZACL1", "FZACL1", JdeDataType.String, 6, true, true),
        new JdeField("FZACL2", "FZACL2", JdeDataType.String, 6, true, true),
        new JdeField("FZACL3", "FZACL3", JdeDataType.String, 6, true, true),
        new JdeField("FZACL4", "FZACL4", JdeDataType.String, 6, true, true),
        new JdeField("FZACL5", "FZACL5", JdeDataType.String, 6, true, true),
        new JdeField("FZACL6", "FZACL6", JdeDataType.String, 6, true, true),
        new JdeField("FZACL7", "FZACL7", JdeDataType.String, 6, true, true),
        new JdeField("FZACL8", "FZACL8", JdeDataType.String, 6, true, true),
        new JdeField("FZACL9", "FZACL9", JdeDataType.String, 6, true, true),
        new JdeField("FZCPLF", "FZCPLF", JdeDataType.Numeric),
        new JdeField("FZCPLH", "FZCPLH", JdeDataType.Numeric),
        new JdeField("FZCPLM", "FZCPLM", JdeDataType.Numeric),
        new JdeField("FZDOCO", "FZDOCO", JdeDataType.Numeric),
        new JdeField("FZKY", "FZKY", JdeDataType.String, 20),
        new JdeField("FZJOBN", "FZJOBN", JdeDataType.String, 20),
        new JdeField("FZLCPD", "FZLCPD", JdeDataType.Numeric),
        new JdeField("FZLSTF", "FZLSTF", JdeDataType.Numeric),
        new JdeField("FZLSTH", "FZLSTH", JdeDataType.Numeric),
        new JdeField("FZLSTM", "FZLSTM", JdeDataType.Numeric),
        new JdeField("FZMPC", "FZMPC", JdeDataType.Numeric),
        new JdeField("FZMPRI", "FZMPRI", JdeDataType.String, 2),
        new JdeField("FZNUMB", "FZNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FZMSTS", "FZMSTS", JdeDataType.String, 4),
        new JdeField("FZPID", "FZPID", JdeDataType.String, 20),
        new JdeField("FZRMK", "FZRMK", JdeDataType.String, 60),
        new JdeField("FZSRVD", "FZSRVD", JdeDataType.Numeric),
        new JdeField("FZSRVF", "FZSRVF", JdeDataType.Numeric),
        new JdeField("FZSRVH", "FZSRVH", JdeDataType.Numeric),
        new JdeField("FZSRVM", "FZSRVM", JdeDataType.Numeric),
        new JdeField("FZWK", "FZWK", JdeDataType.Numeric),
        new JdeField("FZUKID", "FZUKID", JdeDataType.Numeric),
        new JdeField("FZTOLU", "FZTOLU", JdeDataType.Numeric),
        new JdeField("FZTOLL", "FZTOLL", JdeDataType.Numeric),
        new JdeField("FZSPWK", "FZSPWK", JdeDataType.Numeric),
        new JdeField("FZSPMN", "FZSPMN", JdeDataType.Numeric),
        new JdeField("FZSPHR", "FZSPHR", JdeDataType.Numeric),
        new JdeField("FZSPDW", "FZSPDW", JdeDataType.String, 2),
        new JdeField("FZPNST", "FZPNST", JdeDataType.Numeric),
        new JdeField("FZPMC2", "FZPMC2", JdeDataType.String, 6),
        new JdeField("FZPMC1", "FZPMC1", JdeDataType.String, 6),
        new JdeField("FZPDFL", "FZPDFL", JdeDataType.String, 2),
        new JdeField("FZORGM", "FZORGM", JdeDataType.Numeric),
        new JdeField("FZORGH", "FZORGH", JdeDataType.Numeric),
        new JdeField("FZORGF", "FZORGF", JdeDataType.Numeric),
        new JdeField("FZOCCU", "FZOCCU", JdeDataType.Numeric),
        new JdeField("FZMLTW", "FZMLTW", JdeDataType.String, 2),
        new JdeField("FZHLDD", "FZHLDD", JdeDataType.Numeric),
        new JdeField("FZMCU", "FZMCU", JdeDataType.String, 24),
        new JdeField("FZDNHR", "FZDNHR", JdeDataType.Numeric),
        new JdeField("FZCRTL", "FZCRTL", JdeDataType.Numeric),
        new JdeField("FZFRIN", "FZFRIN", JdeDataType.String, 2),
        new JdeField("FZCPLD", "FZCPLD", JdeDataType.Numeric),
        new JdeField("FZASID", "FZASID", JdeDataType.String, 50),
        new JdeField("FZAPID", "FZAPID", JdeDataType.String, 24),
        new JdeField("FZAAID", "FZAAID", JdeDataType.Numeric),
        new JdeField("FZANP", "FZANP", JdeDataType.Numeric),
        new JdeField("FZPDFG", "FZPDFG", JdeDataType.String, 2),
        new JdeField("FZSRVM4", "FZSRVM4", JdeDataType.Numeric),
        new JdeField("FZLSTM4", "FZLSTM4", JdeDataType.Numeric),
        new JdeField("FZCPLM4", "FZCPLM4", JdeDataType.Numeric),
        new JdeField("FZORGM4", "FZORGM4", JdeDataType.Numeric),
        new JdeField("FZSRVM5", "FZSRVM5", JdeDataType.Numeric),
        new JdeField("FZLSTM5", "FZLSTM5", JdeDataType.Numeric),
        new JdeField("FZCPLM5", "FZCPLM5", JdeDataType.Numeric),
        new JdeField("FZORGM5", "FZORGM5", JdeDataType.Numeric),
        new JdeField("FZSRVM6", "FZSRVM6", JdeDataType.Numeric),
        new JdeField("FZLSTM6", "FZLSTM6", JdeDataType.Numeric),
        new JdeField("FZCPLM6", "FZCPLM6", JdeDataType.Numeric),
        new JdeField("FZORGM6", "FZORGM6", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12071_0", "Primary Key on FZNUMB, FZACL1, FZACL2, FZACL3, FZACL4, FZACL5, FZACL6, FZACL7, FZACL8, FZACL9, FZACL0, FZSRVT", new[] { "FZNUMB", "FZACL1", "FZACL2", "FZACL3", "FZACL4", "FZACL5", "FZACL6", "FZACL7", "FZACL8", "FZACL9", "FZACL0", "FZSRVT" }, isUnique: true, isPrimaryKey: true)
    };
}
