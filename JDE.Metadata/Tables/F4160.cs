using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4160 - .
/// </summary>
public class F4160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITTGG.
        /// </summary>
        public const string ITTGG = "ITTGG";

        /// <summary>
        /// ITSFXO.
        /// </summary>
        public const string ITSFXO = "ITSFXO";

        /// <summary>
        /// ITITM.
        /// </summary>
        public const string ITITM = "ITITM";

        /// <summary>
        /// ITMCU.
        /// </summary>
        public const string ITMCU = "ITMCU";

        /// <summary>
        /// ITLOCN.
        /// </summary>
        public const string ITLOCN = "ITLOCN";

        /// <summary>
        /// ITLOTN.
        /// </summary>
        public const string ITLOTN = "ITLOTN";

        /// <summary>
        /// ITSTUN.
        /// </summary>
        public const string ITSTUN = "ITSTUN";

        /// <summary>
        /// ITDPRT.
        /// </summary>
        public const string ITDPRT = "ITDPRT";

        /// <summary>
        /// ITDISS.
        /// </summary>
        public const string ITDISS = "ITDISS";

        /// <summary>
        /// ITTMAN.
        /// </summary>
        public const string ITTMAN = "ITTMAN";

        /// <summary>
        /// ITCTAN.
        /// </summary>
        public const string ITCTAN = "ITCTAN";

        /// <summary>
        /// ITRMAN.
        /// </summary>
        public const string ITRMAN = "ITRMAN";

        /// <summary>
        /// ITENTB.
        /// </summary>
        public const string ITENTB = "ITENTB";

        /// <summary>
        /// ITUPID.
        /// </summary>
        public const string ITUPID = "ITUPID";

        /// <summary>
        /// ITTSTS.
        /// </summary>
        public const string ITTSTS = "ITTSTS";

        /// <summary>
        /// ITDJST.
        /// </summary>
        public const string ITDJST = "ITDJST";

        /// <summary>
        /// ITTST.
        /// </summary>
        public const string ITTST = "ITTST";

        /// <summary>
        /// ITTRQT.
        /// </summary>
        public const string ITTRQT = "ITTRQT";

        /// <summary>
        /// ITUOM.
        /// </summary>
        public const string ITUOM = "ITUOM";

        /// <summary>
        /// ITRMK.
        /// </summary>
        public const string ITRMK = "ITRMK";

        /// <summary>
        /// ITCYCL.
        /// </summary>
        public const string ITCYCL = "ITCYCL";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITRPMJ.
        /// </summary>
        public const string ITRPMJ = "ITRPMJ";

        /// <summary>
        /// ITRPMB.
        /// </summary>
        public const string ITRPMB = "ITRPMB";

        /// <summary>
        /// ITUNCS.
        /// </summary>
        public const string ITUNCS = "ITUNCS";

        /// <summary>
        /// ITLITM.
        /// </summary>
        public const string ITLITM = "ITLITM";

        /// <summary>
        /// ITAITM.
        /// </summary>
        public const string ITAITM = "ITAITM";

        /// <summary>
        /// ITAISL.
        /// </summary>
        public const string ITAISL = "ITAISL";

        /// <summary>
        /// ITBIN.
        /// </summary>
        public const string ITBIN = "ITBIN";

        /// <summary>
        /// ITSQOR.
        /// </summary>
        public const string ITSQOR = "ITSQOR";

        /// <summary>
        /// ITUOM2.
        /// </summary>
        public const string ITUOM2 = "ITUOM2";
    }

    /// <inheritdoc />
    public override string TableName => "F4160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITTGG", "ITTGG", JdeDataType.Numeric, null, true, true),
        new JdeField("ITSFXO", "ITSFXO", JdeDataType.String, 6),
        new JdeField("ITITM", "ITITM", JdeDataType.Numeric),
        new JdeField("ITMCU", "ITMCU", JdeDataType.String, 24, true, true),
        new JdeField("ITLOCN", "ITLOCN", JdeDataType.String, 40, true, true),
        new JdeField("ITLOTN", "ITLOTN", JdeDataType.String, 60, true, true),
        new JdeField("ITSTUN", "ITSTUN", JdeDataType.Numeric, null, true, true),
        new JdeField("ITDPRT", "ITDPRT", JdeDataType.Numeric),
        new JdeField("ITDISS", "ITDISS", JdeDataType.Numeric),
        new JdeField("ITTMAN", "ITTMAN", JdeDataType.Numeric),
        new JdeField("ITCTAN", "ITCTAN", JdeDataType.Numeric),
        new JdeField("ITRMAN", "ITRMAN", JdeDataType.Numeric),
        new JdeField("ITENTB", "ITENTB", JdeDataType.String, 20),
        new JdeField("ITUPID", "ITUPID", JdeDataType.String, 20),
        new JdeField("ITTSTS", "ITTSTS", JdeDataType.String, 4),
        new JdeField("ITDJST", "ITDJST", JdeDataType.Numeric),
        new JdeField("ITTST", "ITTST", JdeDataType.Numeric),
        new JdeField("ITTRQT", "ITTRQT", JdeDataType.Numeric),
        new JdeField("ITUOM", "ITUOM", JdeDataType.String, 4),
        new JdeField("ITRMK", "ITRMK", JdeDataType.String, 60),
        new JdeField("ITCYCL", "ITCYCL", JdeDataType.String, 6),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITRPMJ", "ITRPMJ", JdeDataType.Numeric),
        new JdeField("ITRPMB", "ITRPMB", JdeDataType.String, 20),
        new JdeField("ITUNCS", "ITUNCS", JdeDataType.Numeric),
        new JdeField("ITLITM", "ITLITM", JdeDataType.String, 50),
        new JdeField("ITAITM", "ITAITM", JdeDataType.String, 50),
        new JdeField("ITAISL", "ITAISL", JdeDataType.String, 16),
        new JdeField("ITBIN", "ITBIN", JdeDataType.String, 16),
        new JdeField("ITSQOR", "ITSQOR", JdeDataType.Numeric),
        new JdeField("ITUOM2", "ITUOM2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4160_0", "Primary Key on ITTGG, ITMCU, ITLOCN, ITLOTN, ITSTUN", new[] { "ITTGG", "ITMCU", "ITLOCN", "ITLOTN", "ITSTUN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4160_2", "Index on ITTSTS, ITMCU, ITTGG, ITLOCN, ITLOTN, ITSTUN", new[] { "ITTSTS", "ITMCU", "ITTGG", "ITLOCN", "ITLOTN", "ITSTUN" }),
        new JdeIndex("F4160_3", "Index on ITITM, ITMCU, ITLOCN, ITLOTN, ITTGG, ITSTUN", new[] { "ITITM", "ITMCU", "ITLOCN", "ITLOTN", "ITTGG", "ITSTUN" }),
        new JdeIndex("F4160_4", "Index on ITMCU, ITTMAN, ITITM, ITLOCN, ITLOTN, ITSTUN", new[] { "ITMCU", "ITTMAN", "ITITM", "ITLOCN", "ITLOTN", "ITSTUN" }),
        new JdeIndex("F4160_5", "Unique Index on ITTGG", new[] { "ITTGG" }, isUnique: true)
    };
}
