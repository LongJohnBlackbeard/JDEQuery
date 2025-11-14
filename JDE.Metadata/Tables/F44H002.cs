using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H002 - .
/// </summary>
public class F44H002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARHBRLTP.
        /// </summary>
        public const string ARHBRLTP = "ARHBRLTP";

        /// <summary>
        /// ARHBACTP.
        /// </summary>
        public const string ARHBACTP = "ARHBACTP";

        /// <summary>
        /// ARHBLST.
        /// </summary>
        public const string ARHBLST = "ARHBLST";

        /// <summary>
        /// ARHBNXT.
        /// </summary>
        public const string ARHBNXT = "ARHBNXT";

        /// <summary>
        /// ARHBSTDES.
        /// </summary>
        public const string ARHBSTDES = "ARHBSTDES";

        /// <summary>
        /// ARHBHSFLG.
        /// </summary>
        public const string ARHBHSFLG = "ARHBHSFLG";

        /// <summary>
        /// ARHBA1TR.
        /// </summary>
        public const string ARHBA1TR = "ARHBA1TR";

        /// <summary>
        /// ARHBA2TR.
        /// </summary>
        public const string ARHBA2TR = "ARHBA2TR";

        /// <summary>
        /// ARHBA3TR.
        /// </summary>
        public const string ARHBA3TR = "ARHBA3TR";

        /// <summary>
        /// ARHBA4TR.
        /// </summary>
        public const string ARHBA4TR = "ARHBA4TR";

        /// <summary>
        /// ARHBA5TR.
        /// </summary>
        public const string ARHBA5TR = "ARHBA5TR";

        /// <summary>
        /// ARHBA6TR.
        /// </summary>
        public const string ARHBA6TR = "ARHBA6TR";

        /// <summary>
        /// ARHBA7TR.
        /// </summary>
        public const string ARHBA7TR = "ARHBA7TR";

        /// <summary>
        /// ARHBA8TR.
        /// </summary>
        public const string ARHBA8TR = "ARHBA8TR";

        /// <summary>
        /// ARHBA9TR.
        /// </summary>
        public const string ARHBA9TR = "ARHBA9TR";

        /// <summary>
        /// ARCRTU.
        /// </summary>
        public const string ARCRTU = "ARCRTU";

        /// <summary>
        /// ARCRTJ.
        /// </summary>
        public const string ARCRTJ = "ARCRTJ";

        /// <summary>
        /// ARCRTT.
        /// </summary>
        public const string ARCRTT = "ARCRTT";

        /// <summary>
        /// ARWRKSTNID.
        /// </summary>
        public const string ARWRKSTNID = "ARWRKSTNID";

        /// <summary>
        /// ARHBOPID.
        /// </summary>
        public const string ARHBOPID = "ARHBOPID";

        /// <summary>
        /// ARUPMB.
        /// </summary>
        public const string ARUPMB = "ARUPMB";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARHBRLTP", "ARHBRLTP", JdeDataType.String, 6, true, true),
        new JdeField("ARHBACTP", "ARHBACTP", JdeDataType.String, 2, true, true),
        new JdeField("ARHBLST", "ARHBLST", JdeDataType.String, 6, true, true),
        new JdeField("ARHBNXT", "ARHBNXT", JdeDataType.String, 6),
        new JdeField("ARHBSTDES", "ARHBSTDES", JdeDataType.String, 60),
        new JdeField("ARHBHSFLG", "ARHBHSFLG", JdeDataType.String, 2),
        new JdeField("ARHBA1TR", "ARHBA1TR", JdeDataType.String, 6),
        new JdeField("ARHBA2TR", "ARHBA2TR", JdeDataType.String, 6),
        new JdeField("ARHBA3TR", "ARHBA3TR", JdeDataType.String, 6),
        new JdeField("ARHBA4TR", "ARHBA4TR", JdeDataType.String, 6),
        new JdeField("ARHBA5TR", "ARHBA5TR", JdeDataType.String, 6),
        new JdeField("ARHBA6TR", "ARHBA6TR", JdeDataType.String, 6),
        new JdeField("ARHBA7TR", "ARHBA7TR", JdeDataType.String, 6),
        new JdeField("ARHBA8TR", "ARHBA8TR", JdeDataType.String, 6),
        new JdeField("ARHBA9TR", "ARHBA9TR", JdeDataType.String, 6),
        new JdeField("ARCRTU", "ARCRTU", JdeDataType.String, 20),
        new JdeField("ARCRTJ", "ARCRTJ", JdeDataType.Numeric),
        new JdeField("ARCRTT", "ARCRTT", JdeDataType.Numeric),
        new JdeField("ARWRKSTNID", "ARWRKSTNID", JdeDataType.String, 20),
        new JdeField("ARHBOPID", "ARHBOPID", JdeDataType.String, 20),
        new JdeField("ARUPMB", "ARUPMB", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H002_0", "Primary Key on ARHBRLTP, ARHBACTP, ARHBLST", new[] { "ARHBRLTP", "ARHBACTP", "ARHBLST" }, isUnique: true, isPrimaryKey: true)
    };
}
