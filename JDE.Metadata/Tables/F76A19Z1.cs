using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A19Z1 - .
/// </summary>
public class F76A19Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VKEDUS.
        /// </summary>
        public const string VKEDUS = "VKEDUS";

        /// <summary>
        /// VKEDTY.
        /// </summary>
        public const string VKEDTY = "VKEDTY";

        /// <summary>
        /// VKEDSQ.
        /// </summary>
        public const string VKEDSQ = "VKEDSQ";

        /// <summary>
        /// VKEDTN.
        /// </summary>
        public const string VKEDTN = "VKEDTN";

        /// <summary>
        /// VKEDCT.
        /// </summary>
        public const string VKEDCT = "VKEDCT";

        /// <summary>
        /// VKEDLN.
        /// </summary>
        public const string VKEDLN = "VKEDLN";

        /// <summary>
        /// VKEDFT.
        /// </summary>
        public const string VKEDFT = "VKEDFT";

        /// <summary>
        /// VKEDTS.
        /// </summary>
        public const string VKEDTS = "VKEDTS";

        /// <summary>
        /// VKEDDT.
        /// </summary>
        public const string VKEDDT = "VKEDDT";

        /// <summary>
        /// VKEDER.
        /// </summary>
        public const string VKEDER = "VKEDER";

        /// <summary>
        /// VKEDDL.
        /// </summary>
        public const string VKEDDL = "VKEDDL";

        /// <summary>
        /// VKEDSP.
        /// </summary>
        public const string VKEDSP = "VKEDSP";

        /// <summary>
        /// VKEDTC.
        /// </summary>
        public const string VKEDTC = "VKEDTC";

        /// <summary>
        /// VKEDTR.
        /// </summary>
        public const string VKEDTR = "VKEDTR";

        /// <summary>
        /// VKEDBT.
        /// </summary>
        public const string VKEDBT = "VKEDBT";

        /// <summary>
        /// VKEDGL.
        /// </summary>
        public const string VKEDGL = "VKEDGL";

        /// <summary>
        /// VKEDDH.
        /// </summary>
        public const string VKEDDH = "VKEDDH";

        /// <summary>
        /// VKEDAN.
        /// </summary>
        public const string VKEDAN = "VKEDAN";

        /// <summary>
        /// VKKCO.
        /// </summary>
        public const string VKKCO = "VKKCO";

        /// <summary>
        /// VKDCT.
        /// </summary>
        public const string VKDCT = "VKDCT";

        /// <summary>
        /// VKDOC.
        /// </summary>
        public const string VKDOC = "VKDOC";

        /// <summary>
        /// VKSFX.
        /// </summary>
        public const string VKSFX = "VKSFX";

        /// <summary>
        /// VKDCTM.
        /// </summary>
        public const string VKDCTM = "VKDCTM";

        /// <summary>
        /// VKDOCM.
        /// </summary>
        public const string VKDOCM = "VKDOCM";

        /// <summary>
        /// VKATXC.
        /// </summary>
        public const string VKATXC = "VKATXC";

        /// <summary>
        /// VKCO.
        /// </summary>
        public const string VKCO = "VKCO";

        /// <summary>
        /// VKMCU2.
        /// </summary>
        public const string VKMCU2 = "VKMCU2";

        /// <summary>
        /// VKAN8.
        /// </summary>
        public const string VKAN8 = "VKAN8";

        /// <summary>
        /// VKAC20.
        /// </summary>
        public const string VKAC20 = "VKAC20";

        /// <summary>
        /// VKATDA.
        /// </summary>
        public const string VKATDA = "VKATDA";

        /// <summary>
        /// VKATFA.
        /// </summary>
        public const string VKATFA = "VKATFA";

        /// <summary>
        /// VKTXR1.
        /// </summary>
        public const string VKTXR1 = "VKTXR1";

        /// <summary>
        /// VKAUMT.
        /// </summary>
        public const string VKAUMT = "VKAUMT";

        /// <summary>
        /// VKUOM.
        /// </summary>
        public const string VKUOM = "VKUOM";

        /// <summary>
        /// VKMCU.
        /// </summary>
        public const string VKMCU = "VKMCU";

        /// <summary>
        /// VKOBJ.
        /// </summary>
        public const string VKOBJ = "VKOBJ";

        /// <summary>
        /// VKSUB.
        /// </summary>
        public const string VKSUB = "VKSUB";

        /// <summary>
        /// VKAID.
        /// </summary>
        public const string VKAID = "VKAID";

        /// <summary>
        /// VKPRCS.
        /// </summary>
        public const string VKPRCS = "VKPRCS";
    }

    /// <inheritdoc />
    public override string TableName => "F76A19Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VKEDUS", "VKEDUS", JdeDataType.String, 20, true, true),
        new JdeField("VKEDTY", "VKEDTY", JdeDataType.String, 2),
        new JdeField("VKEDSQ", "VKEDSQ", JdeDataType.Numeric),
        new JdeField("VKEDTN", "VKEDTN", JdeDataType.String, 44, true, true),
        new JdeField("VKEDCT", "VKEDCT", JdeDataType.String, 4),
        new JdeField("VKEDLN", "VKEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("VKEDFT", "VKEDFT", JdeDataType.String, 20),
        new JdeField("VKEDTS", "VKEDTS", JdeDataType.String, 12),
        new JdeField("VKEDDT", "VKEDDT", JdeDataType.Numeric),
        new JdeField("VKEDER", "VKEDER", JdeDataType.String, 2),
        new JdeField("VKEDDL", "VKEDDL", JdeDataType.Numeric),
        new JdeField("VKEDSP", "VKEDSP", JdeDataType.String, 2),
        new JdeField("VKEDTC", "VKEDTC", JdeDataType.String, 2),
        new JdeField("VKEDTR", "VKEDTR", JdeDataType.String, 2),
        new JdeField("VKEDBT", "VKEDBT", JdeDataType.String, 30, true, true),
        new JdeField("VKEDGL", "VKEDGL", JdeDataType.String, 2),
        new JdeField("VKEDDH", "VKEDDH", JdeDataType.String, 2),
        new JdeField("VKEDAN", "VKEDAN", JdeDataType.Numeric),
        new JdeField("VKKCO", "VKKCO", JdeDataType.String, 10, true, true),
        new JdeField("VKDCT", "VKDCT", JdeDataType.String, 4, true, true),
        new JdeField("VKDOC", "VKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VKSFX", "VKSFX", JdeDataType.String, 6),
        new JdeField("VKDCTM", "VKDCTM", JdeDataType.String, 4, true, true),
        new JdeField("VKDOCM", "VKDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("VKATXC", "VKATXC", JdeDataType.String, 20, true, true),
        new JdeField("VKCO", "VKCO", JdeDataType.String, 10),
        new JdeField("VKMCU2", "VKMCU2", JdeDataType.String, 24),
        new JdeField("VKAN8", "VKAN8", JdeDataType.Numeric),
        new JdeField("VKAC20", "VKAC20", JdeDataType.String, 6),
        new JdeField("VKATDA", "VKATDA", JdeDataType.Numeric),
        new JdeField("VKATFA", "VKATFA", JdeDataType.Numeric),
        new JdeField("VKTXR1", "VKTXR1", JdeDataType.Numeric),
        new JdeField("VKAUMT", "VKAUMT", JdeDataType.Numeric),
        new JdeField("VKUOM", "VKUOM", JdeDataType.String, 4),
        new JdeField("VKMCU", "VKMCU", JdeDataType.String, 24),
        new JdeField("VKOBJ", "VKOBJ", JdeDataType.String, 12),
        new JdeField("VKSUB", "VKSUB", JdeDataType.String, 16),
        new JdeField("VKAID", "VKAID", JdeDataType.String, 16),
        new JdeField("VKPRCS", "VKPRCS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A19Z1_0", "Primary Key on VKEDUS, VKEDBT, VKEDTN, VKEDLN, VKKCO, VKDCT, VKDOC, VKDCTM, VKDOCM, VKATXC", new[] { "VKEDUS", "VKEDBT", "VKEDTN", "VKEDLN", "VKKCO", "VKDCT", "VKDOC", "VKDCTM", "VKDOCM", "VKATXC" }, isUnique: true, isPrimaryKey: true)
    };
}
