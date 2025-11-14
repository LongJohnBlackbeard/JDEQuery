using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5215 - .
/// </summary>
public class F5215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A5DOCO.
        /// </summary>
        public const string A5DOCO = "A5DOCO";

        /// <summary>
        /// A5DCTO.
        /// </summary>
        public const string A5DCTO = "A5DCTO";

        /// <summary>
        /// A5KCOO.
        /// </summary>
        public const string A5KCOO = "A5KCOO";

        /// <summary>
        /// A5COCH.
        /// </summary>
        public const string A5COCH = "A5COCH";

        /// <summary>
        /// A5LNID.
        /// </summary>
        public const string A5LNID = "A5LNID";

        /// <summary>
        /// A5OPIM.
        /// </summary>
        public const string A5OPIM = "A5OPIM";

        /// <summary>
        /// A5RCOC.
        /// </summary>
        public const string A5RCOC = "A5RCOC";

        /// <summary>
        /// A5LNIX.
        /// </summary>
        public const string A5LNIX = "A5LNIX";

        /// <summary>
        /// A5CCOD.
        /// </summary>
        public const string A5CCOD = "A5CCOD";

        /// <summary>
        /// A5PDBA.
        /// </summary>
        public const string A5PDBA = "A5PDBA";

        /// <summary>
        /// A5PTAX.
        /// </summary>
        public const string A5PTAX = "A5PTAX";

        /// <summary>
        /// A5USER.
        /// </summary>
        public const string A5USER = "A5USER";

        /// <summary>
        /// A5JOBN.
        /// </summary>
        public const string A5JOBN = "A5JOBN";

        /// <summary>
        /// A5PID.
        /// </summary>
        public const string A5PID = "A5PID";

        /// <summary>
        /// A5UPMJ.
        /// </summary>
        public const string A5UPMJ = "A5UPMJ";

        /// <summary>
        /// A5UPMT.
        /// </summary>
        public const string A5UPMT = "A5UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A5DOCO", "A5DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("A5DCTO", "A5DCTO", JdeDataType.String, 4, true, true),
        new JdeField("A5KCOO", "A5KCOO", JdeDataType.String, 10, true, true),
        new JdeField("A5COCH", "A5COCH", JdeDataType.String, 6, true, true),
        new JdeField("A5LNID", "A5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("A5OPIM", "A5OPIM", JdeDataType.String, 30),
        new JdeField("A5RCOC", "A5RCOC", JdeDataType.String, 6, true, true),
        new JdeField("A5LNIX", "A5LNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("A5CCOD", "A5CCOD", JdeDataType.String, 10, true, true),
        new JdeField("A5PDBA", "A5PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("A5PTAX", "A5PTAX", JdeDataType.String, 4, true, true),
        new JdeField("A5USER", "A5USER", JdeDataType.String, 20),
        new JdeField("A5JOBN", "A5JOBN", JdeDataType.String, 20),
        new JdeField("A5PID", "A5PID", JdeDataType.String, 20),
        new JdeField("A5UPMJ", "A5UPMJ", JdeDataType.Numeric),
        new JdeField("A5UPMT", "A5UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5215_0", "Primary Key on A5CCOD, A5PDBA, A5PTAX, A5DOCO, A5DCTO, A5KCOO, A5COCH, A5LNID, A5RCOC, A5LNIX", new[] { "A5CCOD", "A5PDBA", "A5PTAX", "A5DOCO", "A5DCTO", "A5KCOO", "A5COCH", "A5LNID", "A5RCOC", "A5LNIX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5215_5", "Index on A5CCOD, A5PDBA, A5PTAX, A5DOCO, A5DCTO, A5KCOO, A5RCOC, A5LNIX", new[] { "A5CCOD", "A5PDBA", "A5PTAX", "A5DOCO", "A5DCTO", "A5KCOO", "A5RCOC", "A5LNIX" }),
        new JdeIndex("F5215_8", "Index on A5DOCO, A5DCTO, A5KCOO, A5COCH, A5LNID", new[] { "A5DOCO", "A5DCTO", "A5KCOO", "A5COCH", "A5LNID" })
    };
}
