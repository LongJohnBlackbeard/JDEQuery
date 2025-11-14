using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3112T - .
/// </summary>
public class F3112T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLDOCO.
        /// </summary>
        public const string WLDOCO = "WLDOCO";

        /// <summary>
        /// WLOPSQ.
        /// </summary>
        public const string WLOPSQ = "WLOPSQ";

        /// <summary>
        /// WLOPSC.
        /// </summary>
        public const string WLOPSC = "WLOPSC";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLCAPU.
        /// </summary>
        public const string WLCAPU = "WLCAPU";

        /// <summary>
        /// WLCLHR.
        /// </summary>
        public const string WLCLHR = "WLCLHR";

        /// <summary>
        /// WLCMHR.
        /// </summary>
        public const string WLCMHR = "WLCMHR";

        /// <summary>
        /// WLCOST.
        /// </summary>
        public const string WLCOST = "WLCOST";

        /// <summary>
        /// WLCSHR.
        /// </summary>
        public const string WLCSHR = "WLCSHR";

        /// <summary>
        /// WLLOCN.
        /// </summary>
        public const string WLLOCN = "WLLOCN";

        /// <summary>
        /// WLRUC.
        /// </summary>
        public const string WLRUC = "WLRUC";

        /// <summary>
        /// WLWMCU.
        /// </summary>
        public const string WLWMCU = "WLWMCU";

        /// <summary>
        /// WLNUMB.
        /// </summary>
        public const string WLNUMB = "WLNUMB";

        /// <summary>
        /// WLCTS7.
        /// </summary>
        public const string WLCTS7 = "WLCTS7";

        /// <summary>
        /// WLCTS8.
        /// </summary>
        public const string WLCTS8 = "WLCTS8";
    }

    /// <inheritdoc />
    public override string TableName => "F3112T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLDOCO", "WLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WLOPSQ", "WLOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WLOPSC", "WLOPSC", JdeDataType.String, 4, true, true),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLCAPU", "WLCAPU", JdeDataType.String, 4),
        new JdeField("WLCLHR", "WLCLHR", JdeDataType.Numeric),
        new JdeField("WLCMHR", "WLCMHR", JdeDataType.Numeric),
        new JdeField("WLCOST", "WLCOST", JdeDataType.String, 6),
        new JdeField("WLCSHR", "WLCSHR", JdeDataType.Numeric),
        new JdeField("WLLOCN", "WLLOCN", JdeDataType.String, 40),
        new JdeField("WLRUC", "WLRUC", JdeDataType.Numeric),
        new JdeField("WLWMCU", "WLWMCU", JdeDataType.String, 24),
        new JdeField("WLNUMB", "WLNUMB", JdeDataType.Numeric),
        new JdeField("WLCTS7", "WLCTS7", JdeDataType.Numeric),
        new JdeField("WLCTS8", "WLCTS8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3112T_0", "Primary Key on WLDOCO, WLOPSQ, WLOPSC, WLMCU", new[] { "WLDOCO", "WLOPSQ", "WLOPSC", "WLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
