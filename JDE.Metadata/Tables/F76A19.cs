using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A19 - .
/// </summary>
public class F76A19 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIKCO.
        /// </summary>
        public const string TIKCO = "TIKCO";

        /// <summary>
        /// TIDCT.
        /// </summary>
        public const string TIDCT = "TIDCT";

        /// <summary>
        /// TIDOC.
        /// </summary>
        public const string TIDOC = "TIDOC";

        /// <summary>
        /// TISFX.
        /// </summary>
        public const string TISFX = "TISFX";

        /// <summary>
        /// TIDCTM.
        /// </summary>
        public const string TIDCTM = "TIDCTM";

        /// <summary>
        /// TIDOCM.
        /// </summary>
        public const string TIDOCM = "TIDOCM";

        /// <summary>
        /// TIATXC.
        /// </summary>
        public const string TIATXC = "TIATXC";

        /// <summary>
        /// TICO.
        /// </summary>
        public const string TICO = "TICO";

        /// <summary>
        /// TIMCU2.
        /// </summary>
        public const string TIMCU2 = "TIMCU2";

        /// <summary>
        /// TIAN8.
        /// </summary>
        public const string TIAN8 = "TIAN8";

        /// <summary>
        /// TIAC20.
        /// </summary>
        public const string TIAC20 = "TIAC20";

        /// <summary>
        /// TIATDA.
        /// </summary>
        public const string TIATDA = "TIATDA";

        /// <summary>
        /// TIATFA.
        /// </summary>
        public const string TIATFA = "TIATFA";

        /// <summary>
        /// TITXR1.
        /// </summary>
        public const string TITXR1 = "TITXR1";

        /// <summary>
        /// TIAUMT.
        /// </summary>
        public const string TIAUMT = "TIAUMT";

        /// <summary>
        /// TIUOM.
        /// </summary>
        public const string TIUOM = "TIUOM";

        /// <summary>
        /// TIMCU.
        /// </summary>
        public const string TIMCU = "TIMCU";

        /// <summary>
        /// TIOBJ.
        /// </summary>
        public const string TIOBJ = "TIOBJ";

        /// <summary>
        /// TISUB.
        /// </summary>
        public const string TISUB = "TISUB";

        /// <summary>
        /// TIAID.
        /// </summary>
        public const string TIAID = "TIAID";

        /// <summary>
        /// TIPRCS.
        /// </summary>
        public const string TIPRCS = "TIPRCS";
    }

    /// <inheritdoc />
    public override string TableName => "F76A19";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIKCO", "TIKCO", JdeDataType.String, 10, true, true),
        new JdeField("TIDCT", "TIDCT", JdeDataType.String, 4, true, true),
        new JdeField("TIDOC", "TIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TISFX", "TISFX", JdeDataType.String, 6, true, true),
        new JdeField("TIDCTM", "TIDCTM", JdeDataType.String, 4, true, true),
        new JdeField("TIDOCM", "TIDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("TIATXC", "TIATXC", JdeDataType.String, 20, true, true),
        new JdeField("TICO", "TICO", JdeDataType.String, 10),
        new JdeField("TIMCU2", "TIMCU2", JdeDataType.String, 24),
        new JdeField("TIAN8", "TIAN8", JdeDataType.Numeric),
        new JdeField("TIAC20", "TIAC20", JdeDataType.String, 6),
        new JdeField("TIATDA", "TIATDA", JdeDataType.Numeric),
        new JdeField("TIATFA", "TIATFA", JdeDataType.Numeric),
        new JdeField("TITXR1", "TITXR1", JdeDataType.Numeric),
        new JdeField("TIAUMT", "TIAUMT", JdeDataType.Numeric),
        new JdeField("TIUOM", "TIUOM", JdeDataType.String, 4),
        new JdeField("TIMCU", "TIMCU", JdeDataType.String, 24),
        new JdeField("TIOBJ", "TIOBJ", JdeDataType.String, 12),
        new JdeField("TISUB", "TISUB", JdeDataType.String, 16),
        new JdeField("TIAID", "TIAID", JdeDataType.String, 16),
        new JdeField("TIPRCS", "TIPRCS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A19_0", "Primary Key on TIKCO, TIDCT, TIDOC, TISFX, TIDCTM, TIDOCM, TIATXC", new[] { "TIKCO", "TIDCT", "TIDOC", "TISFX", "TIDCTM", "TIDOCM", "TIATXC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A19_2", "Index on TIKCO, TIDCT, TIDOC, TIATXC", new[] { "TIKCO", "TIDCT", "TIDOC", "TIATXC" }),
        new JdeIndex("F76A19_3", "Index on TIKCO, TIDCT, TIDOC", new[] { "TIKCO", "TIDCT", "TIDOC" }),
        new JdeIndex("F76A19_4", "Index on TIKCO, TIDOC, TIDCT, TISFX, TIDCTM, TIDOCM", new[] { "TIKCO", "TIDOC", "TIDCT", "TISFX", "TIDCTM", "TIDOCM" })
    };
}
